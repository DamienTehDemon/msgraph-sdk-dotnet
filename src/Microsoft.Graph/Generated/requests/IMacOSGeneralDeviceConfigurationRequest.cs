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
    /// The interface IMacOSGeneralDeviceConfigurationRequest.
    /// </summary>
    public partial interface IMacOSGeneralDeviceConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSGeneralDeviceConfiguration using POST.
        /// </summary>
        /// <param name="macOSGeneralDeviceConfigurationToCreate">The MacOSGeneralDeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSGeneralDeviceConfiguration> CreateAsync(MacOSGeneralDeviceConfiguration macOSGeneralDeviceConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified MacOSGeneralDeviceConfiguration using POST and returns a <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSGeneralDeviceConfigurationToCreate">The MacOSGeneralDeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSGeneralDeviceConfiguration>> CreateResponseAsync(MacOSGeneralDeviceConfiguration macOSGeneralDeviceConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified MacOSGeneralDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified MacOSGeneralDeviceConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified MacOSGeneralDeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSGeneralDeviceConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified MacOSGeneralDeviceConfiguration and returns a <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSGeneralDeviceConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified MacOSGeneralDeviceConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSGeneralDeviceConfigurationToUpdate">The MacOSGeneralDeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSGeneralDeviceConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSGeneralDeviceConfiguration> UpdateAsync(MacOSGeneralDeviceConfiguration macOSGeneralDeviceConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified MacOSGeneralDeviceConfiguration using PATCH and returns a <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSGeneralDeviceConfigurationToUpdate">The MacOSGeneralDeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSGeneralDeviceConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSGeneralDeviceConfiguration>> UpdateResponseAsync(MacOSGeneralDeviceConfiguration macOSGeneralDeviceConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSGeneralDeviceConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSGeneralDeviceConfigurationRequest Expand(Expression<Func<MacOSGeneralDeviceConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSGeneralDeviceConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSGeneralDeviceConfigurationRequest Select(Expression<Func<MacOSGeneralDeviceConfiguration, object>> selectExpression);

    }
}
