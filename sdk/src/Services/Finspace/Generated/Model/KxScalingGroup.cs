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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Finspace.Model
{
    /// <summary>
    /// A structure for storing metadata of scaling group.
    /// </summary>
    public partial class KxScalingGroup
    {
        private string _availabilityZoneId;
        private List<string> _clusters = new List<string>();
        private DateTime? _createdTimestamp;
        private string _hostType;
        private DateTime? _lastModifiedTimestamp;
        private string _scalingGroupName;
        private KxScalingGroupStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The identifier of the availability zones.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property Clusters. 
        /// <para>
        ///  The list of clusters currently active in a given scaling group. 
        /// </para>
        /// </summary>
        public List<string> Clusters
        {
            get { return this._clusters; }
            set { this._clusters = value; }
        }

        // Check to see if Clusters property is set
        internal bool IsSetClusters()
        {
            return this._clusters != null && this._clusters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        ///  The timestamp at which the scaling group was created in FinSpace. The value is determined
        /// as epoch time in milliseconds. For example, the value for Monday, November 1, 2021
        /// 12:00:00 PM UTC is specified as 1635768000000. 
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HostType. 
        /// <para>
        ///  The memory and CPU capabilities of the scaling group host on which FinSpace Managed
        /// kdb clusters will be placed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string HostType
        {
            get { return this._hostType; }
            set { this._hostType = value; }
        }

        // Check to see if HostType property is set
        internal bool IsSetHostType()
        {
            return this._hostType != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        ///  The last time that the scaling group was updated in FinSpace. The value is determined
        /// as epoch time in milliseconds. For example, the value for Monday, November 1, 2021
        /// 12:00:00 PM UTC is specified as 1635768000000. 
        /// </para>
        /// </summary>
        public DateTime LastModifiedTimestamp
        {
            get { return this._lastModifiedTimestamp.GetValueOrDefault(); }
            set { this._lastModifiedTimestamp = value; }
        }

        // Check to see if LastModifiedTimestamp property is set
        internal bool IsSetLastModifiedTimestamp()
        {
            return this._lastModifiedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScalingGroupName. 
        /// <para>
        /// A unique identifier for the kdb scaling group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string ScalingGroupName
        {
            get { return this._scalingGroupName; }
            set { this._scalingGroupName = value; }
        }

        // Check to see if ScalingGroupName property is set
        internal bool IsSetScalingGroupName()
        {
            return this._scalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of scaling groups. 
        /// </para>
        /// </summary>
        public KxScalingGroupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        ///  The error message when a failed state occurs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}