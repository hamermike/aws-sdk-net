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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents the properties of the node range for a multi-node parallel
    /// job.
    /// </summary>
    public partial class NodeRangeProperty
    {
        private ContainerProperties _container;
        private string _targetNodes;

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// The container details for the node range.
        /// </para>
        /// </summary>
        public ContainerProperties Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this._container != null;
        }

        /// <summary>
        /// Gets and sets the property TargetNodes. 
        /// <para>
        /// The range of nodes, using node index values. A range of <c>0:3</c> indicates nodes
        /// with index values of <c>0</c> through <c>3</c>. If the starting range value is omitted
        /// (<c>:n</c>), then <c>0</c> is used to start the range. If the ending range value is
        /// omitted (<c>n:</c>), then the highest possible node index is used to end the range.
        /// Your accumulative node ranges must account for all nodes (<c>0:n</c>). You can nest
        /// node ranges (for example, <c>0:10</c> and <c>4:5</c>). In this case, the <c>4:5</c>
        /// range properties override the <c>0:10</c> properties.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetNodes
        {
            get { return this._targetNodes; }
            set { this._targetNodes = value; }
        }

        // Check to see if TargetNodes property is set
        internal bool IsSetTargetNodes()
        {
            return this._targetNodes != null;
        }

    }
}