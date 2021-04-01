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
    /// The type App Consent Approval Route.
    /// </summary>
    public partial class AppConsentApprovalRoute : Entity
    {
    
		///<summary>
		/// The AppConsentApprovalRoute constructor
		///</summary>
        public AppConsentApprovalRoute()
        {
            this.ODataType = "microsoft.graph.appConsentApprovalRoute";
        }
	
        /// <summary>
        /// Gets or sets app consent requests.
        /// </summary>
        [JsonPropertyName("appConsentRequests")]
        public IAppConsentApprovalRouteAppConsentRequestsCollectionPage AppConsentRequests { get; set; }
    
    }
}

