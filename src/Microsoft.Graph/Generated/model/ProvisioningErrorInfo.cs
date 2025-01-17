// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type ProvisioningErrorInfo.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ProvisioningErrorInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisioningErrorInfo"/> class.
        /// </summary>
        public ProvisioningErrorInfo()
        {
            this.ODataType = "microsoft.graph.provisioningErrorInfo";
        }

        /// <summary>
        /// Gets or sets additionalDetails.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "additionalDetails", Required = Newtonsoft.Json.Required.Default)]
        public string AdditionalDetails { get; set; }
    
        /// <summary>
        /// Gets or sets errorCategory.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorCategory", Required = Newtonsoft.Json.Required.Default)]
        public ProvisioningStatusErrorCategory? ErrorCategory { get; set; }
    
        /// <summary>
        /// Gets or sets errorCode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorCode", Required = Newtonsoft.Json.Required.Default)]
        public string ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets reason.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reason", Required = Newtonsoft.Json.Required.Default)]
        public string Reason { get; set; }
    
        /// <summary>
        /// Gets or sets recommendedAction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recommendedAction", Required = Newtonsoft.Json.Required.Default)]
        public string RecommendedAction { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
