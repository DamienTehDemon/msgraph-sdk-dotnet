// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Identity Container.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IdentityContainer : Entity
    {
    
		///<summary>
		/// The IdentityContainer constructor
		///</summary>
        public IdentityContainer()
        {
            this.ODataType = "microsoft.graph.identityContainer";
        }
	
        /// <summary>
        /// Gets or sets conditional access.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conditionalAccess", Required = Newtonsoft.Json.Required.Default)]
        public ConditionalAccessRoot ConditionalAccess { get; set; }
    
        /// <summary>
        /// Gets or sets api connectors.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apiConnectors", Required = Newtonsoft.Json.Required.Default)]
        public IIdentityContainerApiConnectorsCollectionPage ApiConnectors { get; set; }
    
        /// <summary>
        /// Gets or sets b2x user flows.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "b2xUserFlows", Required = Newtonsoft.Json.Required.Default)]
        public IIdentityContainerB2xUserFlowsCollectionPage B2xUserFlows { get; set; }
    
        /// <summary>
        /// Gets or sets user flow attributes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userFlowAttributes", Required = Newtonsoft.Json.Required.Default)]
        public IIdentityContainerUserFlowAttributesCollectionPage UserFlowAttributes { get; set; }
    
    }
}

