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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIdMappingWorkflow operation.
    /// Creates an <c>IdMappingWorkflow</c> object which stores the configuration of the data
    /// processing job to be run. Each <c>IdMappingWorkflow</c> must have a unique workflow
    /// name. To modify an existing workflow, use the <c>UpdateIdMappingWorkflow</c> API.
    /// </summary>
    public partial class CreateIdMappingWorkflowRequest : AmazonEntityResolutionRequest
    {
        private string _description;
        private IdMappingTechniques _idMappingTechniques;
        private List<IdMappingWorkflowInputSource> _inputSourceConfig = new List<IdMappingWorkflowInputSource>();
        private List<IdMappingWorkflowOutputSource> _outputSourceConfig = new List<IdMappingWorkflowOutputSource>();
        private string _roleArn;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _workflowName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IdMappingTechniques. 
        /// <para>
        /// An object which defines the <c>idMappingType</c> and the <c>providerProperties</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdMappingTechniques IdMappingTechniques
        {
            get { return this._idMappingTechniques; }
            set { this._idMappingTechniques = value; }
        }

        // Check to see if IdMappingTechniques property is set
        internal bool IsSetIdMappingTechniques()
        {
            return this._idMappingTechniques != null;
        }

        /// <summary>
        /// Gets and sets the property InputSourceConfig. 
        /// <para>
        /// A list of <c>InputSource</c> objects, which have the fields <c>InputSourceARN</c>
        /// and <c>SchemaName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<IdMappingWorkflowInputSource> InputSourceConfig
        {
            get { return this._inputSourceConfig; }
            set { this._inputSourceConfig = value; }
        }

        // Check to see if InputSourceConfig property is set
        internal bool IsSetInputSourceConfig()
        {
            return this._inputSourceConfig != null && this._inputSourceConfig.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputSourceConfig. 
        /// <para>
        /// A list of <c>IdMappingWorkflowOutputSource</c> objects, each of which contains fields
        /// <c>OutputS3Path</c> and <c>Output</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<IdMappingWorkflowOutputSource> OutputSourceConfig
        {
            get { return this._outputSourceConfig; }
            set { this._outputSourceConfig = value; }
        }

        // Check to see if OutputSourceConfig property is set
        internal bool IsSetOutputSourceConfig()
        {
            return this._outputSourceConfig != null && this._outputSourceConfig.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role. Entity Resolution assumes this role
        /// to create resources on your behalf as part of workflow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkflowName. 
        /// <para>
        /// The name of the workflow. There can't be multiple <c>IdMappingWorkflows</c> with the
        /// same name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string WorkflowName
        {
            get { return this._workflowName; }
            set { this._workflowName = value; }
        }

        // Check to see if WorkflowName property is set
        internal bool IsSetWorkflowName()
        {
            return this._workflowName != null;
        }

    }
}