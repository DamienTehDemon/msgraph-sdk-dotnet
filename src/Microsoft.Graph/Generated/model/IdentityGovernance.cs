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
    /// The type Identity Governance.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class IdentityGovernance
    {
    
		///<summary>
		/// The IdentityGovernance constructor
		///</summary>
        public IdentityGovernance()
        {
            this.ODataType = "microsoft.graph.identityGovernance";
        }
	
        /// <summary>
        /// Gets or sets access reviews.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accessReviews", Required = Newtonsoft.Json.Required.Default)]
        public AccessReviewSet AccessReviews { get; set; }
    
        /// <summary>
        /// Gets or sets app consent.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appConsent", Required = Newtonsoft.Json.Required.Default)]
        public AppConsentApprovalRoute AppConsent { get; set; }
    
        /// <summary>
        /// Gets or sets terms of use.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "termsOfUse", Required = Newtonsoft.Json.Required.Default)]
        public TermsOfUseContainer TermsOfUse { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

