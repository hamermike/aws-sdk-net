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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWorkgroup operation.
    /// Updates a workgroup with the specified configuration settings. You can't update multiple
    /// parameters in one request. For example, you can update <c>baseCapacity</c> or <c>port</c>
    /// in a single request, but you can't update both in the same request.
    /// </summary>
    public partial class UpdateWorkgroupRequest : AmazonRedshiftServerlessRequest
    {
        private int? _baseCapacity;
        private List<ConfigParameter> _configParameters = new List<ConfigParameter>();
        private bool? _enhancedVpcRouting;
        private int? _maxCapacity;
        private int? _port;
        private bool? _publiclyAccessible;
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _subnetIds = new List<string>();
        private string _workgroupName;

        /// <summary>
        /// Gets and sets the property BaseCapacity. 
        /// <para>
        /// The new base data warehouse capacity in Redshift Processing Units (RPUs).
        /// </para>
        /// </summary>
        public int BaseCapacity
        {
            get { return this._baseCapacity.GetValueOrDefault(); }
            set { this._baseCapacity = value; }
        }

        // Check to see if BaseCapacity property is set
        internal bool IsSetBaseCapacity()
        {
            return this._baseCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConfigParameters. 
        /// <para>
        /// An array of parameters to set for advanced control over a database. The options are
        /// <c>auto_mv</c>, <c>datestyle</c>, <c>enable_case_sensitive_identifier</c>, <c>enable_user_activity_logging</c>,
        /// <c>query_group</c>, <c>search_path</c>, <c>require_ssl</c>, and query monitoring metrics
        /// that let you define performance boundaries. For more information about query monitoring
        /// rules and available metrics, see <a href="https://docs.aws.amazon.com/redshift/latest/dg/cm-c-wlm-query-monitoring-rules.html#cm-c-wlm-query-monitoring-metrics-serverless">
        /// Query monitoring metrics for Amazon Redshift Serverless</a>.
        /// </para>
        /// </summary>
        public List<ConfigParameter> ConfigParameters
        {
            get { return this._configParameters; }
            set { this._configParameters = value; }
        }

        // Check to see if ConfigParameters property is set
        internal bool IsSetConfigParameters()
        {
            return this._configParameters != null && this._configParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnhancedVpcRouting. 
        /// <para>
        /// The value that specifies whether to turn on enhanced virtual private cloud (VPC) routing,
        /// which forces Amazon Redshift Serverless to route traffic through your VPC.
        /// </para>
        /// </summary>
        public bool EnhancedVpcRouting
        {
            get { return this._enhancedVpcRouting.GetValueOrDefault(); }
            set { this._enhancedVpcRouting = value; }
        }

        // Check to see if EnhancedVpcRouting property is set
        internal bool IsSetEnhancedVpcRouting()
        {
            return this._enhancedVpcRouting.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum data-warehouse capacity Amazon Redshift Serverless uses to serve queries.
        /// The max capacity is specified in RPUs.
        /// </para>
        /// </summary>
        public int MaxCapacity
        {
            get { return this._maxCapacity.GetValueOrDefault(); }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The custom port to use when connecting to a workgroup. Valid port ranges are 5431-5455
        /// and 8191-8215. The default is 5439.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// A value that specifies whether the workgroup can be accessible from a public network.
        /// </para>
        /// </summary>
        public bool PubliclyAccessible
        {
            get { return this._publiclyAccessible.GetValueOrDefault(); }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// An array of security group IDs to associate with the workgroup.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// An array of VPC subnet IDs to associate with the workgroup.
        /// </para>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The name of the workgroup to update. You can't update the name of a workgroup once
        /// it is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string WorkgroupName
        {
            get { return this._workgroupName; }
            set { this._workgroupName = value; }
        }

        // Check to see if WorkgroupName property is set
        internal bool IsSetWorkgroupName()
        {
            return this._workgroupName != null;
        }

    }
}