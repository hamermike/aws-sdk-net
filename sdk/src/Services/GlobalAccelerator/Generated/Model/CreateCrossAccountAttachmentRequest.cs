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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCrossAccountAttachment operation.
    /// Create a cross-account attachment in Global Accelerator. You create a cross-account
    /// attachment to specify the <i>principals</i> who have permission to add to accelerators
    /// in their own account the resources in your account that you also list in the attachment.
    /// 
    ///  
    /// <para>
    /// A principal can be an Amazon Web Services account number or the Amazon Resource Name
    /// (ARN) for an accelerator. For account numbers that are listed as principals, to add
    /// a resource listed in the attachment to an accelerator, you must sign in to an account
    /// specified as a principal. Then you can add the resources that are listed to any of
    /// your accelerators. If an accelerator ARN is listed in the cross-account attachment
    /// as a principal, anyone with permission to make updates to the accelerator can add
    /// as endpoints resources that are listed in the attachment. 
    /// </para>
    /// </summary>
    public partial class CreateCrossAccountAttachmentRequest : AmazonGlobalAcceleratorRequest
    {
        private string _idempotencyToken;
        private string _name;
        private List<string> _principals = new List<string>();
        private List<Resource> _resources = new List<Resource>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency—that
        /// is, the uniqueness—of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cross-account attachment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Principals. 
        /// <para>
        /// The principals to list in the cross-account attachment. A principal can be an Amazon
        /// Web Services account number or the Amazon Resource Name (ARN) for an accelerator.
        /// 
        /// </para>
        /// </summary>
        public List<string> Principals
        {
            get { return this._principals; }
            set { this._principals = value; }
        }

        // Check to see if Principals property is set
        internal bool IsSetPrincipals()
        {
            return this._principals != null && this._principals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The Amazon Resource Names (ARNs) for the resources to list in the cross-account attachment.
        /// A resource can be any supported Amazon Web Services resource type for Global Accelerator.
        /// 
        /// </para>
        /// </summary>
        public List<Resource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && this._resources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Create tags for cross-account attachment.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/tagging-in-global-accelerator.html">Tagging
        /// in Global Accelerator</a> in the <i>Global Accelerator Developer Guide</i>.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}