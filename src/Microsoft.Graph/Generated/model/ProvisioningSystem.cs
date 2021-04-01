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
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ProvisioningSystem.
    /// </summary>
    public partial class ProvisioningSystem : Identity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisioningSystem"/> class.
        /// </summary>
        public ProvisioningSystem()
        {
            this.ODataType = "microsoft.graph.provisioningSystem";
        }

        /// <summary>
        /// Gets or sets details.
        /// </summary>
        [JsonPropertyName("details")]
        public DetailsInfo Details { get; set; }
    
    }
}