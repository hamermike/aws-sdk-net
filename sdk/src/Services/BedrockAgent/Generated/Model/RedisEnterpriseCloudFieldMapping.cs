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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// A mapping of Bedrock Knowledge Base fields to Redis Cloud field names
    /// </summary>
    public partial class RedisEnterpriseCloudFieldMapping
    {
        private string _metadataField;
        private string _textField;
        private string _vectorField;

        /// <summary>
        /// Gets and sets the property MetadataField.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string MetadataField
        {
            get { return this._metadataField; }
            set { this._metadataField = value; }
        }

        // Check to see if MetadataField property is set
        internal bool IsSetMetadataField()
        {
            return this._metadataField != null;
        }

        /// <summary>
        /// Gets and sets the property TextField.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string TextField
        {
            get { return this._textField; }
            set { this._textField = value; }
        }

        // Check to see if TextField property is set
        internal bool IsSetTextField()
        {
            return this._textField != null;
        }

        /// <summary>
        /// Gets and sets the property VectorField.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string VectorField
        {
            get { return this._vectorField; }
            set { this._vectorField = value; }
        }

        // Check to see if VectorField property is set
        internal bool IsSetVectorField()
        {
            return this._vectorField != null;
        }

    }
}