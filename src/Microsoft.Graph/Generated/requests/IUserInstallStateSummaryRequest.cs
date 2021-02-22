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
    /// The interface IUserInstallStateSummaryRequest.
    /// </summary>
    public partial interface IUserInstallStateSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserInstallStateSummary using POST.
        /// </summary>
        /// <param name="userInstallStateSummaryToCreate">The UserInstallStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserInstallStateSummary.</returns>
        System.Threading.Tasks.Task<UserInstallStateSummary> CreateAsync(UserInstallStateSummary userInstallStateSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UserInstallStateSummary using POST and returns a <see cref="GraphResponse{UserInstallStateSummary}"/> object.
        /// </summary>
        /// <param name="userInstallStateSummaryToCreate">The UserInstallStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserInstallStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserInstallStateSummary>> CreateResponseAsync(UserInstallStateSummary userInstallStateSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UserInstallStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UserInstallStateSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UserInstallStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserInstallStateSummary.</returns>
        System.Threading.Tasks.Task<UserInstallStateSummary> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UserInstallStateSummary and returns a <see cref="GraphResponse{UserInstallStateSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserInstallStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserInstallStateSummary>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UserInstallStateSummary using PATCH.
        /// </summary>
        /// <param name="userInstallStateSummaryToUpdate">The UserInstallStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserInstallStateSummary.</returns>
        System.Threading.Tasks.Task<UserInstallStateSummary> UpdateAsync(UserInstallStateSummary userInstallStateSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UserInstallStateSummary using PATCH and returns a <see cref="GraphResponse{UserInstallStateSummary}"/> object.
        /// </summary>
        /// <param name="userInstallStateSummaryToUpdate">The UserInstallStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserInstallStateSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserInstallStateSummary>> UpdateResponseAsync(UserInstallStateSummary userInstallStateSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserInstallStateSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserInstallStateSummaryRequest Expand(Expression<Func<UserInstallStateSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserInstallStateSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserInstallStateSummaryRequest Select(Expression<Func<UserInstallStateSummary, object>> selectExpression);

    }
}
