﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.Pipeline;

namespace Azure.Core
{
    public static class RetriableStream
    {
        public static async Task<Stream> Create(Func<long, Task<Response>> responseFactory, ResponseClassifier responseClassifier, int maxRetries)
        {
            return Create(await responseFactory(0).ConfigureAwait(false), responseFactory, responseClassifier, maxRetries);
        }

        public static Stream Create(Response initialResponse, Func<long, Task<Response>> responseFactory, ResponseClassifier responseClassifier, int maxRetries)
        {
            return new RetriableStreamImpl(initialResponse, responseFactory, responseClassifier, maxRetries);
        }

        private class RetriableStreamImpl : ReadOnlyStream
        {
            private readonly ResponseClassifier _responseClassifier;

            private readonly Func<long, Task<Response>> _responseFactory;

            private readonly int _maxRetries;

            private readonly Stream _initialStream;

            private Stream _currentStream;

            private long _position;

            private int _retryCount;

            private List<Exception> _exceptions;

            public RetriableStreamImpl(Response initialResponse, Func<long, Task<Response>> responseFactory, ResponseClassifier responseClassifier, int maxRetries)
            {
                _initialStream = initialResponse.ContentStream;
                _currentStream = initialResponse.ContentStream;
                _responseClassifier = responseClassifier;
                _responseFactory = responseFactory;
                _maxRetries = maxRetries;
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                throw new NotSupportedException();
            }

            public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
            {
                while (true)
                {
                    try
                    {
                        var result = await _currentStream.ReadAsync(buffer, offset, count, cancellationToken).ConfigureAwait(false);
                        _position += result;
                        return result;
                    }
                    catch (Exception e)
                    {
                        await RetryAsync(e);
                    }
                }
            }

            private async Task RetryAsync(Exception exception)
            {
                if (!_responseClassifier.IsRetriableException(exception))
                {
                    ExceptionDispatchInfo.Capture(exception).Throw();
                }

                if (_exceptions == null)
                {
                    _exceptions = new List<Exception>();
                }

                _exceptions.Add(exception);

                _retryCount++;

                if (_retryCount > _maxRetries)
                {
                    throw new AggregateException($"Retry failed after {_retryCount} tries", _exceptions);
                }

                _currentStream = (await _responseFactory(_position)).ContentStream;
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                while (true)
                {
                    try
                    {
                        var result = _currentStream.Read(buffer, offset, count);
                        _position += result;
                        return result;

                    }
                    catch (Exception e)
                    {
                        RetryAsync(e).GetAwaiter().GetResult();
                    }
                }
            }

            public override bool CanRead => _currentStream.CanRead;
            public override bool CanSeek { get; } = false;
            public override long Length => _initialStream.Length;

            public override long Position
            {
                get => _position;
                set => throw new NotSupportedException();
            }
        }
    }
}
