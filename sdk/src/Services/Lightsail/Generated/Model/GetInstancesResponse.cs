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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetInstances operation.
    /// </summary>
    public partial class GetInstancesResponse : AmazonWebServiceResponse
    {
        private List<Instance> _instances = new List<Instance>();
        private string _nextPageToken;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// An array of key-value pairs containing information about your instances.
        /// </para>
        /// </summary>
        public List<Instance> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && this._instances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to advance to the next page of results from your request.
        /// </para>
        ///  
        /// <para>
        /// A next page token is not returned if there are no more results to display.
        /// </para>
        ///  
        /// <para>
        /// To get the next page of results, perform another <c>GetInstances</c> request and specify
        /// the next page token using the <c>pageToken</c> parameter.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

    }
}