// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TextRecognitionMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextRecognitionMode
    {
        [EnumMember(Value = "Handwritten")]
        Handwritten,
        [EnumMember(Value = "Printed")]
        Printed
    }
    internal static class TextRecognitionModeEnumExtension
    {
        internal static string ToSerializedValue(this TextRecognitionMode? value)
        {
            return value == null ? null : ((TextRecognitionMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TextRecognitionMode value)
        {
            switch( value )
            {
                case TextRecognitionMode.Handwritten:
                    return "Handwritten";
                case TextRecognitionMode.Printed:
                    return "Printed";
            }
            return null;
        }

        internal static TextRecognitionMode? ParseTextRecognitionMode(this string value)
        {
            switch( value )
            {
                case "Handwritten":
                    return TextRecognitionMode.Handwritten;
                case "Printed":
                    return TextRecognitionMode.Printed;
            }
            return null;
        }
    }
}
