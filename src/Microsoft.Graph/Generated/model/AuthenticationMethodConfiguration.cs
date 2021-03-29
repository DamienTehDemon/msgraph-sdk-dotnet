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
    /// The type Authentication Method Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AuthenticationMethodConfiguration>))]
    public partial class AuthenticationMethodConfiguration : Entity
    {
    
		///<summary>
		/// The internal AuthenticationMethodConfiguration constructor
		///</summary>
        protected internal AuthenticationMethodConfiguration()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets state.
        /// The state of the policy. Possible values are: enabled, disabled.
        /// </summary>
        [JsonPropertyName("state")]
        public AuthenticationMethodState? State { get; set; }
    
    }
}

