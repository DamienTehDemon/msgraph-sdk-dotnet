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
    /// The interface IManagedDeviceMobileAppConfigurationUserStatusRequest.
    /// </summary>
    public partial interface IManagedDeviceMobileAppConfigurationUserStatusRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfigurationUserStatus using POST.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationUserStatusToCreate">The ManagedDeviceMobileAppConfigurationUserStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagedDeviceMobileAppConfigurationUserStatus.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationUserStatus> CreateAsync(ManagedDeviceMobileAppConfigurationUserStatus managedDeviceMobileAppConfigurationUserStatusToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ManagedDeviceMobileAppConfigurationUserStatus using POST and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserStatus}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationUserStatusToCreate">The ManagedDeviceMobileAppConfigurationUserStatus to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserStatus}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationUserStatus>> CreateResponseAsync(ManagedDeviceMobileAppConfigurationUserStatus managedDeviceMobileAppConfigurationUserStatusToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfigurationUserStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ManagedDeviceMobileAppConfigurationUserStatus and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationUserStatus.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagedDeviceMobileAppConfigurationUserStatus.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationUserStatus> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ManagedDeviceMobileAppConfigurationUserStatus and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserStatus}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserStatus}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationUserStatus>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationUserStatus using PATCH.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationUserStatusToUpdate">The ManagedDeviceMobileAppConfigurationUserStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagedDeviceMobileAppConfigurationUserStatus.</returns>
        System.Threading.Tasks.Task<ManagedDeviceMobileAppConfigurationUserStatus> UpdateAsync(ManagedDeviceMobileAppConfigurationUserStatus managedDeviceMobileAppConfigurationUserStatusToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ManagedDeviceMobileAppConfigurationUserStatus using PATCH and returns a <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserStatus}"/> object.
        /// </summary>
        /// <param name="managedDeviceMobileAppConfigurationUserStatusToUpdate">The ManagedDeviceMobileAppConfigurationUserStatus to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagedDeviceMobileAppConfigurationUserStatus}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagedDeviceMobileAppConfigurationUserStatus>> UpdateResponseAsync(ManagedDeviceMobileAppConfigurationUserStatus managedDeviceMobileAppConfigurationUserStatusToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationUserStatusRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationUserStatusRequest Expand(Expression<Func<ManagedDeviceMobileAppConfigurationUserStatus, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationUserStatusRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagedDeviceMobileAppConfigurationUserStatusRequest Select(Expression<Func<ManagedDeviceMobileAppConfigurationUserStatus, object>> selectExpression);

    }
}
