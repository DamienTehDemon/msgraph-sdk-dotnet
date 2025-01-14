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
    /// The type Device Compliance Policy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceCompliancePolicy : Entity
    {
    
		///<summary>
		/// The internal DeviceCompliancePolicy constructor
		///</summary>
        protected internal DeviceCompliancePolicy()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets created date time.
        /// DateTime the object was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Admin provided description of the Device Configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Admin provided name of the device configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// DateTime the object was last modified.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Version of the device configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "version", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Version { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The collection of assignments for this compliance policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceCompliancePolicyAssignmentsCollectionPage Assignments { get; set; }
    
        /// <summary>
        /// Gets or sets device setting state summaries.
        /// Compliance Setting State Device Summary
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceSettingStateSummaries", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceCompliancePolicyDeviceSettingStateSummariesCollectionPage DeviceSettingStateSummaries { get; set; }
    
        /// <summary>
        /// Gets or sets device statuses.
        /// List of DeviceComplianceDeviceStatus.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceStatuses", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceCompliancePolicyDeviceStatusesCollectionPage DeviceStatuses { get; set; }
    
        /// <summary>
        /// Gets or sets device status overview.
        /// Device compliance devices status overview
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceStatusOverview", Required = Newtonsoft.Json.Required.Default)]
        public DeviceComplianceDeviceOverview DeviceStatusOverview { get; set; }
    
        /// <summary>
        /// Gets or sets scheduled actions for rule.
        /// The list of scheduled action for this rule
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scheduledActionsForRule", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceCompliancePolicyScheduledActionsForRuleCollectionPage ScheduledActionsForRule { get; set; }
    
        /// <summary>
        /// Gets or sets user statuses.
        /// List of DeviceComplianceUserStatus.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userStatuses", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceCompliancePolicyUserStatusesCollectionPage UserStatuses { get; set; }
    
        /// <summary>
        /// Gets or sets user status overview.
        /// Device compliance users status overview
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userStatusOverview", Required = Newtonsoft.Json.Required.Default)]
        public DeviceComplianceUserOverview UserStatusOverview { get; set; }
    
    }
}

