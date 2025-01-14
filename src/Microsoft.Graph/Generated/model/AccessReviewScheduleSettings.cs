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
    /// The type AccessReviewScheduleSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AccessReviewScheduleSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessReviewScheduleSettings"/> class.
        /// </summary>
        public AccessReviewScheduleSettings()
        {
            this.ODataType = "microsoft.graph.accessReviewScheduleSettings";
        }

        /// <summary>
        /// Gets or sets applyActions.
        /// Optional field. Describes the  actions to take once a review is complete. There are two types that are currently supported: removeAccessApplyAction (default) and disableAndDeleteUserApplyAction. Field only needs to be specified in the case of disableAndDeleteUserApplyAction. See accessReviewApplyAction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applyActions", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AccessReviewApplyAction> ApplyActions { get; set; }
    
        /// <summary>
        /// Gets or sets autoApplyDecisionsEnabled.
        /// Flag to indicate whether auto-apply feature is enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "autoApplyDecisionsEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? AutoApplyDecisionsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets defaultDecision.
        /// Decision chosen if defaultDecisionEnabled is enabled. Can be one of 'Approve', 'Deny', or 'Recommendation'.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultDecision", Required = Newtonsoft.Json.Required.Default)]
        public string DefaultDecision { get; set; }
    
        /// <summary>
        /// Gets or sets defaultDecisionEnabled.
        /// Flag to indicate whether default decision is enabled/disabled when reviewers do not respond.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "defaultDecisionEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? DefaultDecisionEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets instanceDurationInDays.
        /// Duration of each recurrence of review (accessReviewInstance) in number of days.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "instanceDurationInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? InstanceDurationInDays { get; set; }
    
        /// <summary>
        /// Gets or sets justificationRequiredOnApproval.
        /// Flag to indicate whether reviewers are required to provide justification with their decision.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "justificationRequiredOnApproval", Required = Newtonsoft.Json.Required.Default)]
        public bool? JustificationRequiredOnApproval { get; set; }
    
        /// <summary>
        /// Gets or sets mailNotificationsEnabled.
        /// Flag to indicate whether emails are enabled/disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mailNotificationsEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? MailNotificationsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets recommendationsEnabled.
        /// Flag to indicate whether decision recommendations are enabled/disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recommendationsEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? RecommendationsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets recurrence.
        /// Detailed settings for recurrence. Using standard Outlook recurrence object. Note that dayOfMonth is not supported - use property startDate on recurrenceRange to determine the day the review will start on.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recurrence", Required = Newtonsoft.Json.Required.Default)]
        public PatternedRecurrence Recurrence { get; set; }
    
        /// <summary>
        /// Gets or sets reminderNotificationsEnabled.
        /// Flag to indicate whether reminders are enabled/disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reminderNotificationsEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? ReminderNotificationsEnabled { get; set; }
    
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
