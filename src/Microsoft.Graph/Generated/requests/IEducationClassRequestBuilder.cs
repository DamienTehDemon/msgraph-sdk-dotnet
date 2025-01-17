// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IEducationClassRequestBuilder.
    /// </summary>
    public partial interface IEducationClassRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IEducationClassRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IEducationClassRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Group.
        /// </summary>
        /// <returns>The <see cref="IGroupWithReferenceRequestBuilder"/>.</returns>
        IGroupWithReferenceRequestBuilder Group { get; }

        /// <summary>
        /// Gets the request builder for Members.
        /// </summary>
        /// <returns>The <see cref="IEducationClassMembersCollectionWithReferencesRequestBuilder"/>.</returns>
        IEducationClassMembersCollectionWithReferencesRequestBuilder Members { get; }

        /// <summary>
        /// Gets the request builder for Schools.
        /// </summary>
        /// <returns>The <see cref="IEducationClassSchoolsCollectionWithReferencesRequestBuilder"/>.</returns>
        IEducationClassSchoolsCollectionWithReferencesRequestBuilder Schools { get; }

        /// <summary>
        /// Gets the request builder for Teachers.
        /// </summary>
        /// <returns>The <see cref="IEducationClassTeachersCollectionWithReferencesRequestBuilder"/>.</returns>
        IEducationClassTeachersCollectionWithReferencesRequestBuilder Teachers { get; }
    
        
    
    }
}
