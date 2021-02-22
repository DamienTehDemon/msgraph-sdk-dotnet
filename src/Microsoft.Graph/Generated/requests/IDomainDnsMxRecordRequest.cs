// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDomainDnsMxRecordRequest.
    /// </summary>
    public partial interface IDomainDnsMxRecordRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DomainDnsMxRecord using POST.
        /// </summary>
        /// <param name="domainDnsMxRecordToCreate">The DomainDnsMxRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DomainDnsMxRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsMxRecord> CreateAsync(DomainDnsMxRecord domainDnsMxRecordToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DomainDnsMxRecord using POST and returns a <see cref="GraphResponse{DomainDnsMxRecord}"/> object.
        /// </summary>
        /// <param name="domainDnsMxRecordToCreate">The DomainDnsMxRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DomainDnsMxRecord}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DomainDnsMxRecord>> CreateResponseAsync(DomainDnsMxRecord domainDnsMxRecordToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DomainDnsMxRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DomainDnsMxRecord and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DomainDnsMxRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DomainDnsMxRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsMxRecord> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DomainDnsMxRecord and returns a <see cref="GraphResponse{DomainDnsMxRecord}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DomainDnsMxRecord}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DomainDnsMxRecord>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DomainDnsMxRecord using PATCH.
        /// </summary>
        /// <param name="domainDnsMxRecordToUpdate">The DomainDnsMxRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DomainDnsMxRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsMxRecord> UpdateAsync(DomainDnsMxRecord domainDnsMxRecordToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DomainDnsMxRecord using PATCH and returns a <see cref="GraphResponse{DomainDnsMxRecord}"/> object.
        /// </summary>
        /// <param name="domainDnsMxRecordToUpdate">The DomainDnsMxRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DomainDnsMxRecord}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DomainDnsMxRecord>> UpdateResponseAsync(DomainDnsMxRecord domainDnsMxRecordToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsMxRecordRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsMxRecordRequest Expand(Expression<Func<DomainDnsMxRecord, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsMxRecordRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsMxRecordRequest Select(Expression<Func<DomainDnsMxRecord, object>> selectExpression);

    }
}
