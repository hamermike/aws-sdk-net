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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the BatchGetAssetPropertyValue operation.
    /// </summary>
    public partial class BatchGetAssetPropertyValueResponse : AmazonWebServiceResponse
    {
        private List<BatchGetAssetPropertyValueErrorEntry> _errorEntries = new List<BatchGetAssetPropertyValueErrorEntry>();
        private string _nextToken;
        private List<BatchGetAssetPropertyValueSkippedEntry> _skippedEntries = new List<BatchGetAssetPropertyValueSkippedEntry>();
        private List<BatchGetAssetPropertyValueSuccessEntry> _successEntries = new List<BatchGetAssetPropertyValueSuccessEntry>();

        /// <summary>
        /// Gets and sets the property ErrorEntries. 
        /// <para>
        /// A list of the errors (if any) associated with the batch request. Each error entry
        /// contains the <c>entryId</c> of the entry that failed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchGetAssetPropertyValueErrorEntry> ErrorEntries
        {
            get { return this._errorEntries; }
            set { this._errorEntries = value; }
        }

        // Check to see if ErrorEntries property is set
        internal bool IsSetErrorEntries()
        {
            return this._errorEntries != null && this._errorEntries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or null if there are no additional results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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

        /// <summary>
        /// Gets and sets the property SkippedEntries. 
        /// <para>
        /// A list of entries that were not processed by this batch request. because these entries
        /// had been completely processed by previous paginated requests. Each skipped entry contains
        /// the <c>entryId</c> of the entry that skipped.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchGetAssetPropertyValueSkippedEntry> SkippedEntries
        {
            get { return this._skippedEntries; }
            set { this._skippedEntries = value; }
        }

        // Check to see if SkippedEntries property is set
        internal bool IsSetSkippedEntries()
        {
            return this._skippedEntries != null && this._skippedEntries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SuccessEntries. 
        /// <para>
        /// A list of entries that were processed successfully by this batch request. Each success
        /// entry contains the <c>entryId</c> of the entry that succeeded and the latest query
        /// result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchGetAssetPropertyValueSuccessEntry> SuccessEntries
        {
            get { return this._successEntries; }
            set { this._successEntries = value; }
        }

        // Check to see if SuccessEntries property is set
        internal bool IsSetSuccessEntries()
        {
            return this._successEntries != null && this._successEntries.Count > 0; 
        }

    }
}