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
    /// The interface IWorkbookChartLegendRequest.
    /// </summary>
    public partial interface IWorkbookChartLegendRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartLegend using POST.
        /// </summary>
        /// <param name="workbookChartLegendToCreate">The WorkbookChartLegend to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartLegend.</returns>
        System.Threading.Tasks.Task<WorkbookChartLegend> CreateAsync(WorkbookChartLegend workbookChartLegendToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified WorkbookChartLegend using POST and returns a <see cref="GraphResponse{WorkbookChartLegend}"/> object.
        /// </summary>
        /// <param name="workbookChartLegendToCreate">The WorkbookChartLegend to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartLegend}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartLegend>> CreateResponseAsync(WorkbookChartLegend workbookChartLegendToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WorkbookChartLegend.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WorkbookChartLegend and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WorkbookChartLegend.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartLegend.</returns>
        System.Threading.Tasks.Task<WorkbookChartLegend> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WorkbookChartLegend and returns a <see cref="GraphResponse{WorkbookChartLegend}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartLegend}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartLegend>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkbookChartLegend using PATCH.
        /// </summary>
        /// <param name="workbookChartLegendToUpdate">The WorkbookChartLegend to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartLegend.</returns>
        System.Threading.Tasks.Task<WorkbookChartLegend> UpdateAsync(WorkbookChartLegend workbookChartLegendToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkbookChartLegend using PATCH and returns a <see cref="GraphResponse{WorkbookChartLegend}"/> object.
        /// </summary>
        /// <param name="workbookChartLegendToUpdate">The WorkbookChartLegend to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookChartLegend}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartLegend>> UpdateResponseAsync(WorkbookChartLegend workbookChartLegendToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartLegendRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartLegendRequest Expand(Expression<Func<WorkbookChartLegend, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartLegendRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartLegendRequest Select(Expression<Func<WorkbookChartLegend, object>> selectExpression);

    }
}
