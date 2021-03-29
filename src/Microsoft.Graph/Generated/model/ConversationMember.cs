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
    /// The type Conversation Member.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ConversationMember>))]
    public partial class ConversationMember : Entity
    {
    
		///<summary>
		/// The internal ConversationMember constructor
		///</summary>
        protected internal ConversationMember()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the user.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets roles.
        /// The roles for that user.
        /// </summary>
        [JsonPropertyName("roles")]
        public IEnumerable<string> Roles { get; set; }
    
        /// <summary>
        /// Gets or sets visible history start date time.
        /// The timestamp denoting how far back a conversation's history is shared with the conversation member. This property is settable only for members of a chat.
        /// </summary>
        [JsonPropertyName("visibleHistoryStartDateTime")]
        public DateTimeOffset? VisibleHistoryStartDateTime { get; set; }
    
    }
}

