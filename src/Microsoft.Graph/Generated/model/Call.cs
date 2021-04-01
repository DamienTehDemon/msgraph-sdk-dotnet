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
    /// The type Call.
    /// </summary>
    public partial class Call : Entity
    {
    
		///<summary>
		/// The Call constructor
		///</summary>
        public Call()
        {
            this.ODataType = "microsoft.graph.call";
        }
	
        /// <summary>
        /// Gets or sets callback uri.
        /// The callback URL on which callbacks will be delivered. Must be https.
        /// </summary>
        [JsonPropertyName("callbackUri")]
        public string CallbackUri { get; set; }
    
        /// <summary>
        /// Gets or sets call chain id.
        /// A unique identifier for all the participant calls in a conference or a unique identifier for two participant calls in a P2P call.  This needs to be copied over from Microsoft.Graph.Call.CallChainId.
        /// </summary>
        [JsonPropertyName("callChainId")]
        public string CallChainId { get; set; }
    
        /// <summary>
        /// Gets or sets call options.
        /// </summary>
        [JsonPropertyName("callOptions")]
        public CallOptions CallOptions { get; set; }
    
        /// <summary>
        /// Gets or sets call routes.
        /// The routing information on how the call was retargeted. Read-only.
        /// </summary>
        [JsonPropertyName("callRoutes")]
        public IEnumerable<CallRoute> CallRoutes { get; set; }
    
        /// <summary>
        /// Gets or sets chat info.
        /// The chat information. Required information for joining a meeting.
        /// </summary>
        [JsonPropertyName("chatInfo")]
        public ChatInfo ChatInfo { get; set; }
    
        /// <summary>
        /// Gets or sets direction.
        /// The direction of the call. The possible value are incoming or outgoing. Read-only.
        /// </summary>
        [JsonPropertyName("direction")]
        public CallDirection? Direction { get; set; }
    
        /// <summary>
        /// Gets or sets incoming context.
        /// The context associated with an incoming call. Read-only. Server generated.
        /// </summary>
        [JsonPropertyName("incomingContext")]
        public IncomingContext IncomingContext { get; set; }
    
        /// <summary>
        /// Gets or sets media config.
        /// The media configuration. Required.
        /// </summary>
        [JsonPropertyName("mediaConfig")]
        public MediaConfig MediaConfig { get; set; }
    
        /// <summary>
        /// Gets or sets media state.
        /// Read-only. The call media state.
        /// </summary>
        [JsonPropertyName("mediaState")]
        public CallMediaState MediaState { get; set; }
    
        /// <summary>
        /// Gets or sets meeting info.
        /// The meeting information that's required for joining a meeting.
        /// </summary>
        [JsonPropertyName("meetingInfo")]
        public MeetingInfo MeetingInfo { get; set; }
    
        /// <summary>
        /// Gets or sets my participant id.
        /// </summary>
        [JsonPropertyName("myParticipantId")]
        public string MyParticipantId { get; set; }
    
        /// <summary>
        /// Gets or sets requested modalities.
        /// </summary>
        [JsonPropertyName("requestedModalities")]
        public IEnumerable<Modality> RequestedModalities { get; set; }
    
        /// <summary>
        /// Gets or sets result info.
        /// </summary>
        [JsonPropertyName("resultInfo")]
        public ResultInfo ResultInfo { get; set; }
    
        /// <summary>
        /// Gets or sets source.
        /// </summary>
        [JsonPropertyName("source")]
        public ParticipantInfo Source { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [JsonPropertyName("state")]
        public CallState? State { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets targets.
        /// </summary>
        [JsonPropertyName("targets")]
        public IEnumerable<InvitationParticipantInfo> Targets { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets tone info.
        /// </summary>
        [JsonPropertyName("toneInfo")]
        public ToneInfo ToneInfo { get; set; }
    
        /// <summary>
        /// Gets or sets transcription.
        /// The transcription information for the call. Read-only.
        /// </summary>
        [JsonPropertyName("transcription")]
        public CallTranscriptionInfo Transcription { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("operations")]
        public ICallOperationsCollectionPage Operations { get; set; }
    
        /// <summary>
        /// Gets or sets participants.
        /// Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("participants")]
        public ICallParticipantsCollectionPage Participants { get; set; }
    
    }
}

