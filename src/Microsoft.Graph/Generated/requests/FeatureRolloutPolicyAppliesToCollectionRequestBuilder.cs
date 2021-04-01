// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type FeatureRolloutPolicyAppliesToCollectionRequestBuilder.
    /// </summary>
    public partial class FeatureRolloutPolicyAppliesToCollectionRequestBuilder : BaseRequestBuilder, IFeatureRolloutPolicyAppliesToCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new FeatureRolloutPolicyAppliesToCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public FeatureRolloutPolicyAppliesToCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IFeatureRolloutPolicyAppliesToCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IFeatureRolloutPolicyAppliesToCollectionRequest Request(IEnumerable<Option> options)
        {
            return new FeatureRolloutPolicyAppliesToCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDirectoryObjectRequestBuilder"/> for the specified FeatureRolloutPolicyDirectoryObject.
        /// </summary>
        /// <param name="id">The ID for the FeatureRolloutPolicyDirectoryObject.</param>
        /// <returns>The <see cref="IDirectoryObjectRequestBuilder"/>.</returns>
        public IDirectoryObjectRequestBuilder this[string id]
        {
            get
            {
                return new DirectoryObjectRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DirectoryObjectValidateProperties.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectValidatePropertiesRequestBuilder"/>.</returns>
        public IDirectoryObjectValidatePropertiesRequestBuilder ValidateProperties(
            string entityType = null,
            string displayName = null,
            string mailNickname = null,
            Guid? onBehalfOfUserId = null)
        {
            return new DirectoryObjectValidatePropertiesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.validateProperties"),
                this.Client,
                entityType,
                displayName,
                mailNickname,
                onBehalfOfUserId);
        }

        /// <summary>
        /// Gets the request builder for DirectoryObjectGetAvailableExtensionProperties.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectGetAvailableExtensionPropertiesRequestBuilder"/>.</returns>
        public IDirectoryObjectGetAvailableExtensionPropertiesRequestBuilder GetAvailableExtensionProperties(
            bool? isSyncedFromOnPremises = null)
        {
            return new DirectoryObjectGetAvailableExtensionPropertiesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getAvailableExtensionProperties"),
                this.Client,
                isSyncedFromOnPremises);
        }

        /// <summary>
        /// Gets the request builder for DirectoryObjectGetByIds.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectGetByIdsRequestBuilder"/>.</returns>
        public IDirectoryObjectGetByIdsRequestBuilder GetByIds(
            IEnumerable<string> ids,
            IEnumerable<string> types = null)
        {
            return new DirectoryObjectGetByIdsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getByIds"),
                this.Client,
                ids,
                types);
        }
    }
}
