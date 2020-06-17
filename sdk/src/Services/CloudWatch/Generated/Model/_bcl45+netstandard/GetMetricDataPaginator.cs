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
    /// Base class for GetMetricData paginators.
    /// </summary>
    internal sealed partial class GetMetricDataPaginator : IPaginator<GetMetricDataResponse>, IGetMetricDataPaginator
    {
        private readonly IAmazonCloudWatch client;
        private readonly GetMetricDataRequest request;
        private int isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<GetMetricDataResponse> Responses => new PaginatedResponse<GetMetricDataResponse>(this);

        /// <summary>
        /// Enumerable containing all of the MetricDataResults
        /// </summary>
        public IPaginatedEnumerable<MetricDataResult> MetricDataResults => 
            new PaginatedResultKeyResponse<GetMetricDataResponse, MetricDataResult>(this, (i) => i.MetricDataResults);

        /// <summary>
        /// Enumerable containing all of the Messages
        /// </summary>
        public IPaginatedEnumerable<MessageData> Messages => 
            new PaginatedResultKeyResponse<GetMetricDataResponse, MessageData>(this, (i) => i.Messages);

        internal GetMetricDataPaginator(IAmazonCloudWatch client, GetMetricDataRequest request)
        {
            this.client = client;
            this.request = request;
        }
#if BCL
        IEnumerable<GetMetricDataResponse> IPaginator<GetMetricDataResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = request.NextToken;
            GetMetricDataResponse response;
            do
            {
                request.NextToken = nextToken;
                response = client.GetMetricData(request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (nextToken != null);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<GetMetricDataResponse> IPaginator<GetMetricDataResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = request.NextToken;
            GetMetricDataResponse response;
            do
            {
                request.NextToken = nextToken;
                response = await client.GetMetricDataAsync(request, cancellationToken).ConfigureAwait(false);
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