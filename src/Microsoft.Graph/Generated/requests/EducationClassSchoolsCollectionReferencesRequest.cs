// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type EducationClassSchoolsCollectionReferencesRequest.
    /// </summary>
    public partial class EducationClassSchoolsCollectionReferencesRequest : BaseRequest, IEducationClassSchoolsCollectionReferencesRequest
    {
        /// <summary>
        /// Constructs a new EducationClassSchoolsCollectionReferencesRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EducationClassSchoolsCollectionReferencesRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        /// <summary>
        /// Adds the specified EducationSchool to the collection via POST.
        /// </summary>
        /// <param name="educationSchool">The EducationSchool to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task AddAsync(EducationSchool educationSchool, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;

            if (string.IsNullOrEmpty(educationSchool.Id))
            {
                throw new ServiceException(new Error { Code = "invalidRequest", Message = "ID is required to add a reference." });
            }

            var requestBody = new ReferenceRequestBody { ODataId = string.Format("{0}/education/schools/{1}", this.Client.BaseUrl, educationSchool.Id) };
            return this.SendAsync(requestBody, cancellationToken);
        }

        /// <summary>
        /// Adds the specified EducationSchool to the collection via POST and returns a <see cref="GraphResponse{EducationSchool}"/> object of the request.
        /// </summary>
        /// <param name="educationSchool">The EducationSchool to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(EducationSchool educationSchool, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;

            if (string.IsNullOrEmpty(educationSchool.Id))
            {
                throw new ServiceException(new Error { Code = "invalidRequest", Message = "ID is required to add a reference." });
            }

            var requestBody = new ReferenceRequestBody { ODataId = string.Format("{0}/education/schools/{1}", this.Client.BaseUrl, educationSchool.Id) };
            return this.SendAsyncWithGraphResponse(requestBody, cancellationToken);
        }

    }
}
