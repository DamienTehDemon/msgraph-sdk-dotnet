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
    /// The interface IMuteParticipantOperationRequest.
    /// </summary>
    public partial interface IMuteParticipantOperationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MuteParticipantOperation using POST.
        /// </summary>
        /// <param name="muteParticipantOperationToCreate">The MuteParticipantOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MuteParticipantOperation.</returns>
        System.Threading.Tasks.Task<MuteParticipantOperation> CreateAsync(MuteParticipantOperation muteParticipantOperationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified MuteParticipantOperation using POST and returns a <see cref="GraphResponse{MuteParticipantOperation}"/> object.
        /// </summary>
        /// <param name="muteParticipantOperationToCreate">The MuteParticipantOperation to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MuteParticipantOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MuteParticipantOperation>> CreateResponseAsync(MuteParticipantOperation muteParticipantOperationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified MuteParticipantOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified MuteParticipantOperation and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified MuteParticipantOperation.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MuteParticipantOperation.</returns>
        System.Threading.Tasks.Task<MuteParticipantOperation> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified MuteParticipantOperation and returns a <see cref="GraphResponse{MuteParticipantOperation}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MuteParticipantOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MuteParticipantOperation>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified MuteParticipantOperation using PATCH.
        /// </summary>
        /// <param name="muteParticipantOperationToUpdate">The MuteParticipantOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MuteParticipantOperation.</returns>
        System.Threading.Tasks.Task<MuteParticipantOperation> UpdateAsync(MuteParticipantOperation muteParticipantOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified MuteParticipantOperation using PATCH and returns a <see cref="GraphResponse{MuteParticipantOperation}"/> object.
        /// </summary>
        /// <param name="muteParticipantOperationToUpdate">The MuteParticipantOperation to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MuteParticipantOperation}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MuteParticipantOperation>> UpdateResponseAsync(MuteParticipantOperation muteParticipantOperationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMuteParticipantOperationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMuteParticipantOperationRequest Expand(Expression<Func<MuteParticipantOperation, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMuteParticipantOperationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMuteParticipantOperationRequest Select(Expression<Func<MuteParticipantOperation, object>> selectExpression);

    }
}
