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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// This is the response object from the ListDelegatedAdminAccounts operation.
    /// </summary>
    public partial class ListDelegatedAdminAccountsResponse : AmazonWebServiceResponse
    {
        private List<DelegatedAdminAccount> _delegatedAdminAccounts = new List<DelegatedAdminAccount>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DelegatedAdminAccounts. 
        /// <para>
        /// Details of the Amazon Inspector delegated administrator of your organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<DelegatedAdminAccount> DelegatedAdminAccounts
        {
            get { return this._delegatedAdminAccounts; }
            set { this._delegatedAdminAccounts = value; }
        }

        // Check to see if DelegatedAdminAccounts property is set
        internal bool IsSetDelegatedAdminAccounts()
        {
            return this._delegatedAdminAccounts != null && this._delegatedAdminAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to use for paginating results that are returned in the response. Set the value
        /// of this parameter to null for the first request to a list action. For subsequent calls,
        /// use the <c>NextToken</c> value returned from the previous request to continue listing
        /// results after the first page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}