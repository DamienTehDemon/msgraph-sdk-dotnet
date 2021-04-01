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
    /// The type Education Class.
    /// </summary>
    public partial class EducationClass : Entity
    {
    
		///<summary>
		/// The EducationClass constructor
		///</summary>
        public EducationClass()
        {
            this.ODataType = "microsoft.graph.educationClass";
        }
	
        /// <summary>
        /// Gets or sets class code.
        /// Class code used by the school to identify the class.
        /// </summary>
        [JsonPropertyName("classCode")]
        public string ClassCode { get; set; }
    
        /// <summary>
        /// Gets or sets course.
        /// Course information for the class
        /// </summary>
        [JsonPropertyName("course")]
        public EducationCourse Course { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// Entity who created the class
        /// </summary>
        [JsonPropertyName("createdBy")]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the class.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of the class.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets external id.
        /// ID of the class from the syncing system.
        /// </summary>
        [JsonPropertyName("externalId")]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or sets external name.
        /// Name of the class in the syncing system.
        /// </summary>
        [JsonPropertyName("externalName")]
        public string ExternalName { get; set; }
    
        /// <summary>
        /// Gets or sets external source.
        /// How this class was created. The possible values are: sis, manual, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("externalSource")]
        public EducationExternalSource? ExternalSource { get; set; }
    
        /// <summary>
        /// Gets or sets external source detail.
        /// The name of the external source this resources was generated from.
        /// </summary>
        [JsonPropertyName("externalSourceDetail")]
        public string ExternalSourceDetail { get; set; }
    
        /// <summary>
        /// Gets or sets grade.
        /// Grade level of the class.
        /// </summary>
        [JsonPropertyName("grade")]
        public string Grade { get; set; }
    
        /// <summary>
        /// Gets or sets mail nickname.
        /// Mail name for sending email to all members, if this is enabled.
        /// </summary>
        [JsonPropertyName("mailNickname")]
        public string MailNickname { get; set; }
    
        /// <summary>
        /// Gets or sets term.
        /// Term for this class.
        /// </summary>
        [JsonPropertyName("term")]
        public EducationTerm Term { get; set; }
    
        /// <summary>
        /// Gets or sets group.
        /// The directory group corresponding to this class.
        /// </summary>
        [JsonPropertyName("group")]
        public Group Group { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// All users in the class. Nullable.
        /// </summary>
        [JsonPropertyName("members")]
        public IEducationClassMembersCollectionWithReferencesPage Members { get; set; }
    
        /// <summary>
        /// Gets or sets schools.
        /// All schools that this class is associated with. Nullable.
        /// </summary>
        [JsonPropertyName("schools")]
        public IEducationClassSchoolsCollectionWithReferencesPage Schools { get; set; }
    
        /// <summary>
        /// Gets or sets teachers.
        /// All teachers in the class. Nullable.
        /// </summary>
        [JsonPropertyName("teachers")]
        public IEducationClassTeachersCollectionWithReferencesPage Teachers { get; set; }
    
    }
}

