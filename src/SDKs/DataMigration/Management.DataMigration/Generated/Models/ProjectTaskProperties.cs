// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Base class for all types of DMS task properties. If task is not
    /// supported by current client, this object is returned.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Unknown")]
    public partial class ProjectTaskProperties
    {
        /// <summary>
        /// Initializes a new instance of the ProjectTaskProperties class.
        /// </summary>
        public ProjectTaskProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProjectTaskProperties class.
        /// </summary>
        /// <param name="errors">Array of errors. This is ignored if
        /// submitted.</param>
        /// <param name="state">The state of the task. This is ignored if
        /// submitted. Possible values include: 'Unknown', 'Queued', 'Running',
        /// 'Canceled', 'Succeeded', 'Failed', 'FailedInputValidation',
        /// 'Faulted'</param>
        /// <param name="commands">Array of command properties.</param>
        /// <param name="clientData">Key value pairs of client data to attach
        /// meta data information to task</param>
        public ProjectTaskProperties(IList<ODataError> errors = default(IList<ODataError>), string state = default(string), IList<CommandProperties> commands = default(IList<CommandProperties>), IDictionary<string, string> clientData = default(IDictionary<string, string>))
        {
            Errors = errors;
            State = state;
            Commands = commands;
            ClientData = clientData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets array of errors. This is ignored if submitted.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<ODataError> Errors { get; private set; }

        /// <summary>
        /// Gets the state of the task. This is ignored if submitted. Possible
        /// values include: 'Unknown', 'Queued', 'Running', 'Canceled',
        /// 'Succeeded', 'Failed', 'FailedInputValidation', 'Faulted'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets array of command properties.
        /// </summary>
        [JsonProperty(PropertyName = "commands")]
        public IList<CommandProperties> Commands { get; private set; }

        /// <summary>
        /// Gets or sets key value pairs of client data to attach meta data
        /// information to task
        /// </summary>
        [JsonProperty(PropertyName = "clientData")]
        public IDictionary<string, string> ClientData { get; set; }

    }
}
