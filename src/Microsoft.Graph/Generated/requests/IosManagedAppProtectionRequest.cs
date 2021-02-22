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
    /// The type IosManagedAppProtectionRequest.
    /// </summary>
    public partial class IosManagedAppProtectionRequest : BaseRequest, IIosManagedAppProtectionRequest
    {
        /// <summary>
        /// Constructs a new IosManagedAppProtectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IosManagedAppProtectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IosManagedAppProtection using POST.
        /// </summary>
        /// <param name="iosManagedAppProtectionToCreate">The IosManagedAppProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosManagedAppProtection.</returns>
        public async System.Threading.Tasks.Task<IosManagedAppProtection> CreateAsync(IosManagedAppProtection iosManagedAppProtectionToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<IosManagedAppProtection>(iosManagedAppProtectionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified IosManagedAppProtection using POST and returns a <see cref="GraphResponse{IosManagedAppProtection}"/> object.
        /// </summary>
        /// <param name="iosManagedAppProtectionToCreate">The IosManagedAppProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosManagedAppProtection}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosManagedAppProtection>> CreateResponseAsync(IosManagedAppProtection iosManagedAppProtectionToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<IosManagedAppProtection>(iosManagedAppProtectionToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified IosManagedAppProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<IosManagedAppProtection>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IosManagedAppProtection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified IosManagedAppProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosManagedAppProtection.</returns>
        public async System.Threading.Tasks.Task<IosManagedAppProtection> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<IosManagedAppProtection>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified IosManagedAppProtection and returns a <see cref="GraphResponse{IosManagedAppProtection}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosManagedAppProtection}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosManagedAppProtection>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<IosManagedAppProtection>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IosManagedAppProtection using PATCH.
        /// </summary>
        /// <param name="iosManagedAppProtectionToUpdate">The IosManagedAppProtection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosManagedAppProtection.</returns>
        public async System.Threading.Tasks.Task<IosManagedAppProtection> UpdateAsync(IosManagedAppProtection iosManagedAppProtectionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<IosManagedAppProtection>(iosManagedAppProtectionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IosManagedAppProtection using PATCH and returns a <see cref="GraphResponse{IosManagedAppProtection}"/> object.
        /// </summary>
        /// <param name="iosManagedAppProtectionToUpdate">The IosManagedAppProtection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosManagedAppProtection}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IosManagedAppProtection>> UpdateResponseAsync(IosManagedAppProtection iosManagedAppProtectionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<IosManagedAppProtection>(iosManagedAppProtectionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosManagedAppProtectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIosManagedAppProtectionRequest Expand(Expression<Func<IosManagedAppProtection, object>> expandExpression)
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
        public IIosManagedAppProtectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIosManagedAppProtectionRequest Select(Expression<Func<IosManagedAppProtection, object>> selectExpression)
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
        /// <param name="iosManagedAppProtectionToInitialize">The <see cref="IosManagedAppProtection"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IosManagedAppProtection iosManagedAppProtectionToInitialize)
        {

            if (iosManagedAppProtectionToInitialize != null && iosManagedAppProtectionToInitialize.AdditionalData != null)
            {

                if (iosManagedAppProtectionToInitialize.Apps != null && iosManagedAppProtectionToInitialize.Apps.CurrentPage != null)
                {
                    iosManagedAppProtectionToInitialize.Apps.AdditionalData = iosManagedAppProtectionToInitialize.AdditionalData;

                    object nextPageLink;
                    iosManagedAppProtectionToInitialize.AdditionalData.TryGetValue("apps@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        iosManagedAppProtectionToInitialize.Apps.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
