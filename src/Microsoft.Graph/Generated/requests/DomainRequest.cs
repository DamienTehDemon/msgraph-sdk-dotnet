// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type DomainRequest.
    /// </summary>
    public partial class DomainRequest : BaseRequest, IDomainRequest
    {
        /// <summary>
        /// Constructs a new DomainRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DomainRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Domain using POST.
        /// </summary>
        /// <param name="domainToCreate">The Domain to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Domain.</returns>
        public async System.Threading.Tasks.Task<Domain> CreateAsync(Domain domainToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<Domain>(domainToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Domain using POST and returns a <see cref="GraphResponse{Domain}"/> object.
        /// </summary>
        /// <param name="domainToCreate">The Domain to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Domain}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Domain>> CreateResponseAsync(Domain domainToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<Domain>(domainToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Domain.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<Domain>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Domain and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Domain.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Domain.</returns>
        public async System.Threading.Tasks.Task<Domain> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<Domain>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Domain and returns a <see cref="GraphResponse{Domain}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Domain}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Domain>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<Domain>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Domain using PATCH.
        /// </summary>
        /// <param name="domainToUpdate">The Domain to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Domain.</returns>
        public async System.Threading.Tasks.Task<Domain> UpdateAsync(Domain domainToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<Domain>(domainToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Domain using PATCH and returns a <see cref="GraphResponse{Domain}"/> object.
        /// </summary>
        /// <param name="domainToUpdate">The Domain to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Domain}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Domain>> UpdateResponseAsync(Domain domainToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<Domain>(domainToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDomainRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDomainRequest Expand(Expression<Func<Domain, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IDomainRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDomainRequest Select(Expression<Func<Domain, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="domainToInitialize">The <see cref="Domain"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Domain domainToInitialize)
        {

            if (domainToInitialize != null && domainToInitialize.AdditionalData != null)
            {

                if (domainToInitialize.DomainNameReferences != null && domainToInitialize.DomainNameReferences.CurrentPage != null)
                {
                    domainToInitialize.DomainNameReferences.AdditionalData = domainToInitialize.AdditionalData;

                    object nextPageLink;
                    domainToInitialize.AdditionalData.TryGetValue("domainNameReferences@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        domainToInitialize.DomainNameReferences.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (domainToInitialize.ServiceConfigurationRecords != null && domainToInitialize.ServiceConfigurationRecords.CurrentPage != null)
                {
                    domainToInitialize.ServiceConfigurationRecords.AdditionalData = domainToInitialize.AdditionalData;

                    object nextPageLink;
                    domainToInitialize.AdditionalData.TryGetValue("serviceConfigurationRecords@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        domainToInitialize.ServiceConfigurationRecords.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (domainToInitialize.VerificationDnsRecords != null && domainToInitialize.VerificationDnsRecords.CurrentPage != null)
                {
                    domainToInitialize.VerificationDnsRecords.AdditionalData = domainToInitialize.AdditionalData;

                    object nextPageLink;
                    domainToInitialize.AdditionalData.TryGetValue("verificationDnsRecords@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        domainToInitialize.VerificationDnsRecords.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
