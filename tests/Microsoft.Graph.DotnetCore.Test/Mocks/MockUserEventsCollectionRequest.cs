﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.DotnetCore.Test.Mocks
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    public class MockUserEventsCollectionRequest : IUserEventsCollectionRequest
    {
        IUserEventsCollectionPage NextPage { get; }

        public MockUserEventsCollectionRequest(
            IUserEventsCollectionPage nextPage)
        {
            NextPage = nextPage;
            RequestUrl = "nextLink";
        }

        public Task<IUserEventsCollectionPage> GetAsync()
        {
            return Task.FromResult<IUserEventsCollectionPage>(NextPage);
        }

        public Task<IUserEventsCollectionPage> GetAsync(CancellationToken cancellationToken)
        {
            return this.GetAsync();
        }

        #region Not implemented

        public Task<GraphResponse<UserEventsCollectionResponse>> GetResponseAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GraphResponse<UserEventsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<GraphResponse<Event>> AddResponseAsync(Event eventsEvent)
        {
            throw new NotImplementedException();
        }

        public Task<GraphResponse<Event>> AddResponseAsync(Event events, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public string ContentType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IList<HeaderOption> Headers => throw new NotImplementedException();

        public IBaseClient Client => throw new NotImplementedException();

        public HttpMethods Method => throw new NotImplementedException();

        public string RequestUrl { get; internal set; }

        public IList<QueryOption> QueryOptions => throw new NotImplementedException();

        public IDictionary<string, IMiddlewareOption> MiddlewareOptions => throw new NotImplementedException();
        public IResponseHandler ResponseHandler { get; }

        public Task<Event> AddAsync(Event eventsEvent)
        {
            throw new NotImplementedException();
        }

        public Task<Event> AddAsync(Event eventsEvent, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public IUserEventsCollectionRequest Expand(string value)
        {
            throw new NotImplementedException();
        }

        public IUserEventsCollectionRequest Expand(Expression<Func<Event, object>> expandExpression)
        {
            throw new NotImplementedException();
        }

        public IUserEventsCollectionRequest Filter(string value)
        {
            throw new NotImplementedException();
        }

        public IUserEventsCollectionRequest OrderBy(string value)
        {
            throw new NotImplementedException();
        }

        public IUserEventsCollectionRequest Select(string value)
        {
            throw new NotImplementedException();
        }

        public IUserEventsCollectionRequest Select(Expression<Func<Event, object>> selectExpression)
        {
            throw new NotImplementedException();
        }

        public IUserEventsCollectionRequest Skip(int value)
        {
            throw new NotImplementedException();
        }

        public IUserEventsCollectionRequest Top(int value)
        {
            throw new NotImplementedException();
        }

        public HttpRequestMessage GetHttpRequestMessage()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
