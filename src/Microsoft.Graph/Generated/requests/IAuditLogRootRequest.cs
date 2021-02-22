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
    /// The interface IAuditLogRootRequest.
    /// </summary>
    public partial interface IAuditLogRootRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AuditLogRoot using POST.
        /// </summary>
        /// <param name="auditLogRootToCreate">The AuditLogRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AuditLogRoot.</returns>
        System.Threading.Tasks.Task<AuditLogRoot> CreateAsync(AuditLogRoot auditLogRootToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AuditLogRoot using POST and returns a <see cref="GraphResponse{AuditLogRoot}"/> object.
        /// </summary>
        /// <param name="auditLogRootToCreate">The AuditLogRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuditLogRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuditLogRoot>> CreateResponseAsync(AuditLogRoot auditLogRootToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AuditLogRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AuditLogRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AuditLogRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AuditLogRoot.</returns>
        System.Threading.Tasks.Task<AuditLogRoot> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AuditLogRoot and returns a <see cref="GraphResponse{AuditLogRoot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuditLogRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuditLogRoot>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AuditLogRoot using PATCH.
        /// </summary>
        /// <param name="auditLogRootToUpdate">The AuditLogRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AuditLogRoot.</returns>
        System.Threading.Tasks.Task<AuditLogRoot> UpdateAsync(AuditLogRoot auditLogRootToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AuditLogRoot using PATCH and returns a <see cref="GraphResponse{AuditLogRoot}"/> object.
        /// </summary>
        /// <param name="auditLogRootToUpdate">The AuditLogRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AuditLogRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AuditLogRoot>> UpdateResponseAsync(AuditLogRoot auditLogRootToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuditLogRootRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuditLogRootRequest Expand(Expression<Func<AuditLogRoot, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAuditLogRootRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAuditLogRootRequest Select(Expression<Func<AuditLogRoot, object>> selectExpression);

    }
}
