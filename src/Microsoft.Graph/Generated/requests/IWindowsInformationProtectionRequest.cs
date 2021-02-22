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
    /// The interface IWindowsInformationProtectionRequest.
    /// </summary>
    public partial interface IWindowsInformationProtectionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsInformationProtection using POST.
        /// </summary>
        /// <param name="windowsInformationProtectionToCreate">The WindowsInformationProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsInformationProtection.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtection> CreateAsync(WindowsInformationProtection windowsInformationProtectionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified WindowsInformationProtection using POST and returns a <see cref="GraphResponse{WindowsInformationProtection}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionToCreate">The WindowsInformationProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtection>> CreateResponseAsync(WindowsInformationProtection windowsInformationProtectionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsInformationProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsInformationProtection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsInformationProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsInformationProtection.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtection> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsInformationProtection and returns a <see cref="GraphResponse{WindowsInformationProtection}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtection>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsInformationProtection using PATCH.
        /// </summary>
        /// <param name="windowsInformationProtectionToUpdate">The WindowsInformationProtection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsInformationProtection.</returns>
        System.Threading.Tasks.Task<WindowsInformationProtection> UpdateAsync(WindowsInformationProtection windowsInformationProtectionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsInformationProtection using PATCH and returns a <see cref="GraphResponse{WindowsInformationProtection}"/> object.
        /// </summary>
        /// <param name="windowsInformationProtectionToUpdate">The WindowsInformationProtection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsInformationProtection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsInformationProtection>> UpdateResponseAsync(WindowsInformationProtection windowsInformationProtectionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionRequest Expand(Expression<Func<WindowsInformationProtection, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsInformationProtectionRequest Select(Expression<Func<WindowsInformationProtection, object>> selectExpression);

    }
}
