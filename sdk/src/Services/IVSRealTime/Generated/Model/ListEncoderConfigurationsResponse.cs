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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// This is the response object from the ListEncoderConfigurations operation.
    /// </summary>
    public partial class ListEncoderConfigurationsResponse : AmazonWebServiceResponse
    {
        private List<EncoderConfigurationSummary> _encoderConfigurations = new List<EncoderConfigurationSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EncoderConfigurations. 
        /// <para>
        /// List of the matching EncoderConfigurations (summary information only).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EncoderConfigurationSummary> EncoderConfigurations
        {
            get { return this._encoderConfigurations; }
            set { this._encoderConfigurations = value; }
        }

        // Check to see if EncoderConfigurations property is set
        internal bool IsSetEncoderConfigurations()
        {
            return this._encoderConfigurations != null && this._encoderConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more encoder configurations than <c>maxResults</c>, use <c>nextToken</c>
        /// in the request to get the next set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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