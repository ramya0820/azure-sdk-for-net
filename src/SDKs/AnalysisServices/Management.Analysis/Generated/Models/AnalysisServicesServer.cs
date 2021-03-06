// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Analysis.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents an instance of an Analysis Services resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AnalysisServicesServer : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AnalysisServicesServer class.
        /// </summary>
        public AnalysisServicesServer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AnalysisServicesServer class.
        /// </summary>
        /// <param name="location">Location of the Analysis Services
        /// resource.</param>
        /// <param name="sku">The SKU of the Analysis Services
        /// resource.</param>
        /// <param name="id">An identifier that represents the Analysis
        /// Services resource.</param>
        /// <param name="name">The name of the Analysis Services
        /// resource.</param>
        /// <param name="type">The type of the Analysis Services
        /// resource.</param>
        /// <param name="tags">Key-value pairs of additional resource
        /// provisioning properties.</param>
        /// <param name="asAdministrators">A collection of AS server
        /// administrators</param>
        /// <param name="backupBlobContainerUri">The SAS container URI to the
        /// backup container.</param>
        /// <param name="gatewayDetails">The gateway details configured for the
        /// AS server.</param>
        /// <param name="ipV4FirewallSettings">The firewall settings for the AS
        /// server.</param>
        /// <param name="querypoolConnectionMode">How the read-write server's
        /// participation in the query pool is controlled.&lt;br/&gt;It can
        /// have the following values: &lt;ul&gt;&lt;li&gt;readOnly - indicates
        /// that the read-write server is intended not to participate in query
        /// operations&lt;/li&gt;&lt;li&gt;all - indicates that the read-write
        /// server can participate in query
        /// operations&lt;/li&gt;&lt;/ul&gt;Specifying readOnly when capacity
        /// is 1 results in error. Possible values include: 'All',
        /// 'ReadOnly'</param>
        /// <param name="state">The current state of Analysis Services
        /// resource. The state is to indicate more states outside of resource
        /// provisioning. Possible values include: 'Deleting', 'Succeeded',
        /// 'Failed', 'Paused', 'Suspended', 'Provisioning', 'Updating',
        /// 'Suspending', 'Pausing', 'Resuming', 'Preparing', 'Scaling'</param>
        /// <param name="provisioningState">The current deployment state of
        /// Analysis Services resource. The provisioningState is to indicate
        /// states for resource provisioning. Possible values include:
        /// 'Deleting', 'Succeeded', 'Failed', 'Paused', 'Suspended',
        /// 'Provisioning', 'Updating', 'Suspending', 'Pausing', 'Resuming',
        /// 'Preparing', 'Scaling'</param>
        /// <param name="serverFullName">The full name of the Analysis Services
        /// resource.</param>
        public AnalysisServicesServer(string location, ResourceSku sku, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ServerAdministrators asAdministrators = default(ServerAdministrators), string backupBlobContainerUri = default(string), GatewayDetails gatewayDetails = default(GatewayDetails), IPv4FirewallSettings ipV4FirewallSettings = default(IPv4FirewallSettings), ConnectionMode? querypoolConnectionMode = default(ConnectionMode?), string state = default(string), string provisioningState = default(string), string serverFullName = default(string))
            : base(location, sku, id, name, type, tags)
        {
            AsAdministrators = asAdministrators;
            BackupBlobContainerUri = backupBlobContainerUri;
            GatewayDetails = gatewayDetails;
            IpV4FirewallSettings = ipV4FirewallSettings;
            QuerypoolConnectionMode = querypoolConnectionMode;
            State = state;
            ProvisioningState = provisioningState;
            ServerFullName = serverFullName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a collection of AS server administrators
        /// </summary>
        [JsonProperty(PropertyName = "properties.asAdministrators")]
        public ServerAdministrators AsAdministrators { get; set; }

        /// <summary>
        /// Gets or sets the SAS container URI to the backup container.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backupBlobContainerUri")]
        public string BackupBlobContainerUri { get; set; }

        /// <summary>
        /// Gets or sets the gateway details configured for the AS server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.gatewayDetails")]
        public GatewayDetails GatewayDetails { get; set; }

        /// <summary>
        /// Gets or sets the firewall settings for the AS server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipV4FirewallSettings")]
        public IPv4FirewallSettings IpV4FirewallSettings { get; set; }

        /// <summary>
        /// Gets or sets how the read-write server's participation in the query
        /// pool is controlled.&amp;lt;br/&amp;gt;It can have the following
        /// values: &amp;lt;ul&amp;gt;&amp;lt;li&amp;gt;readOnly - indicates
        /// that the read-write server is intended not to participate in query
        /// operations&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;all - indicates that
        /// the read-write server can participate in query
        /// operations&amp;lt;/li&amp;gt;&amp;lt;/ul&amp;gt;Specifying readOnly
        /// when capacity is 1 results in error. Possible values include:
        /// 'All', 'ReadOnly'
        /// </summary>
        [JsonProperty(PropertyName = "properties.querypoolConnectionMode")]
        public ConnectionMode? QuerypoolConnectionMode { get; set; }

        /// <summary>
        /// Gets the current state of Analysis Services resource. The state is
        /// to indicate more states outside of resource provisioning. Possible
        /// values include: 'Deleting', 'Succeeded', 'Failed', 'Paused',
        /// 'Suspended', 'Provisioning', 'Updating', 'Suspending', 'Pausing',
        /// 'Resuming', 'Preparing', 'Scaling'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets the current deployment state of Analysis Services resource.
        /// The provisioningState is to indicate states for resource
        /// provisioning. Possible values include: 'Deleting', 'Succeeded',
        /// 'Failed', 'Paused', 'Suspended', 'Provisioning', 'Updating',
        /// 'Suspending', 'Pausing', 'Resuming', 'Preparing', 'Scaling'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the full name of the Analysis Services resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverFullName")]
        public string ServerFullName { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
