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
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Agreement.
    /// </summary>
    public partial class Agreement : Entity
    {
    
		///<summary>
		/// The Agreement constructor
		///</summary>
        public Agreement()
        {
            this.ODataType = "microsoft.graph.agreement";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// Display name of the agreement. The display name is used for internal tracking of the agreement but is not shown to end users who view the agreement.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is per device acceptance required.
        /// Indicates whether end users are required to accept this agreement on every device that they access it from. The end user is required to register their device in Azure AD, if they haven't already done so.
        /// </summary>
        [JsonPropertyName("isPerDeviceAcceptanceRequired")]
        public bool? IsPerDeviceAcceptanceRequired { get; set; }
    
        /// <summary>
        /// Gets or sets is viewing before acceptance required.
        /// Indicates whether the user has to expand the agreement before accepting.
        /// </summary>
        [JsonPropertyName("isViewingBeforeAcceptanceRequired")]
        public bool? IsViewingBeforeAcceptanceRequired { get; set; }
    
        /// <summary>
        /// Gets or sets terms expiration.
        /// Expiration schedule and frequency of agreement for all users.
        /// </summary>
        [JsonPropertyName("termsExpiration")]
        public TermsExpiration TermsExpiration { get; set; }
    
        /// <summary>
        /// Gets or sets user reaccept required frequency.
        /// The duration after which the user must re-accept the terms of use. The value is represented in ISO 8601 format for durations.
        /// </summary>
        [JsonPropertyName("userReacceptRequiredFrequency")]
        public Duration UserReacceptRequiredFrequency { get; set; }
    
        /// <summary>
        /// Gets or sets acceptances.
        /// Read-only. Information about acceptances of this agreement.
        /// </summary>
        [JsonPropertyName("acceptances")]
        public IAgreementAcceptancesCollectionPage Acceptances { get; set; }
    
        /// <summary>
        /// Gets or sets file.
        /// Default PDF linked to this agreement.
        /// </summary>
        [JsonPropertyName("file")]
        public AgreementFile File { get; set; }
    
        /// <summary>
        /// Gets or sets files.
        /// PDFs linked to this agreement. This property is in the process of being deprecated. Use the  file property instead.
        /// </summary>
        [JsonPropertyName("files")]
        public IAgreementFilesCollectionPage Files { get; set; }
    
    }
}

