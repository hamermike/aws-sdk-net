/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Base class for ListCollaborationPrivacyBudgetTemplates paginators.
    /// </summary>
    internal sealed partial class ListCollaborationPrivacyBudgetTemplatesPaginator : IPaginator<ListCollaborationPrivacyBudgetTemplatesResponse>, IListCollaborationPrivacyBudgetTemplatesPaginator
    {
        private readonly IAmazonCleanRooms _client;
        private readonly ListCollaborationPrivacyBudgetTemplatesRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListCollaborationPrivacyBudgetTemplatesResponse> Responses => new PaginatedResponse<ListCollaborationPrivacyBudgetTemplatesResponse>(this);

        /// <summary>
        /// Enumerable containing all of the CollaborationPrivacyBudgetTemplateSummaries
        /// </summary>
        public IPaginatedEnumerable<CollaborationPrivacyBudgetTemplateSummary> CollaborationPrivacyBudgetTemplateSummaries => 
            new PaginatedResultKeyResponse<ListCollaborationPrivacyBudgetTemplatesResponse, CollaborationPrivacyBudgetTemplateSummary>(this, (i) => i.CollaborationPrivacyBudgetTemplateSummaries);

        internal ListCollaborationPrivacyBudgetTemplatesPaginator(IAmazonCleanRooms client, ListCollaborationPrivacyBudgetTemplatesRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListCollaborationPrivacyBudgetTemplatesResponse> IPaginator<ListCollaborationPrivacyBudgetTemplatesResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListCollaborationPrivacyBudgetTemplatesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListCollaborationPrivacyBudgetTemplates(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListCollaborationPrivacyBudgetTemplatesResponse> IPaginator<ListCollaborationPrivacyBudgetTemplatesResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListCollaborationPrivacyBudgetTemplatesResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListCollaborationPrivacyBudgetTemplatesAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}