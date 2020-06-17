#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Base class for DescribeAlarmHistory paginators.
    /// </summary>
    internal sealed partial class DescribeAlarmHistoryPaginator : IPaginator<DescribeAlarmHistoryResponse>, IDescribeAlarmHistoryPaginator
    {
        private readonly IAmazonCloudWatch client;
        private readonly DescribeAlarmHistoryRequest request;
        private int isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<DescribeAlarmHistoryResponse> Responses => new PaginatedResponse<DescribeAlarmHistoryResponse>(this);

        /// <summary>
        /// Enumerable containing all of the AlarmHistoryItems
        /// </summary>
        public IPaginatedEnumerable<AlarmHistoryItem> AlarmHistoryItems => 
            new PaginatedResultKeyResponse<DescribeAlarmHistoryResponse, AlarmHistoryItem>(this, (i) => i.AlarmHistoryItems);

        internal DescribeAlarmHistoryPaginator(IAmazonCloudWatch client, DescribeAlarmHistoryRequest request)
        {
            this.client = client;
            this.request = request;
        }
#if BCL
        IEnumerable<DescribeAlarmHistoryResponse> IPaginator<DescribeAlarmHistoryResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = request.NextToken;
            DescribeAlarmHistoryResponse response;
            do
            {
                request.NextToken = nextToken;
                response = client.DescribeAlarmHistory(request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (nextToken != null);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<DescribeAlarmHistoryResponse> IPaginator<DescribeAlarmHistoryResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = request.NextToken;
            DescribeAlarmHistoryResponse response;
            do
            {
                request.NextToken = nextToken;
                response = await client.DescribeAlarmHistoryAsync(request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (nextToken != null);
        }
#endif
    }
}
#endif