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
    /// The interface IChangeTrackedEntityRequest.
    /// </summary>
    public partial interface IChangeTrackedEntityRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ChangeTrackedEntity using POST.
        /// </summary>
        /// <param name="changeTrackedEntityToCreate">The ChangeTrackedEntity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ChangeTrackedEntity.</returns>
        System.Threading.Tasks.Task<ChangeTrackedEntity> CreateAsync(ChangeTrackedEntity changeTrackedEntityToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ChangeTrackedEntity using POST and returns a <see cref="GraphResponse{ChangeTrackedEntity}"/> object.
        /// </summary>
        /// <param name="changeTrackedEntityToCreate">The ChangeTrackedEntity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ChangeTrackedEntity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ChangeTrackedEntity>> CreateResponseAsync(ChangeTrackedEntity changeTrackedEntityToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ChangeTrackedEntity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ChangeTrackedEntity and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ChangeTrackedEntity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ChangeTrackedEntity.</returns>
        System.Threading.Tasks.Task<ChangeTrackedEntity> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ChangeTrackedEntity and returns a <see cref="GraphResponse{ChangeTrackedEntity}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ChangeTrackedEntity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ChangeTrackedEntity>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ChangeTrackedEntity using PATCH.
        /// </summary>
        /// <param name="changeTrackedEntityToUpdate">The ChangeTrackedEntity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ChangeTrackedEntity.</returns>
        System.Threading.Tasks.Task<ChangeTrackedEntity> UpdateAsync(ChangeTrackedEntity changeTrackedEntityToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ChangeTrackedEntity using PATCH and returns a <see cref="GraphResponse{ChangeTrackedEntity}"/> object.
        /// </summary>
        /// <param name="changeTrackedEntityToUpdate">The ChangeTrackedEntity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ChangeTrackedEntity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ChangeTrackedEntity>> UpdateResponseAsync(ChangeTrackedEntity changeTrackedEntityToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IChangeTrackedEntityRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IChangeTrackedEntityRequest Expand(Expression<Func<ChangeTrackedEntity, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IChangeTrackedEntityRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IChangeTrackedEntityRequest Select(Expression<Func<ChangeTrackedEntity, object>> selectExpression);

    }
}
