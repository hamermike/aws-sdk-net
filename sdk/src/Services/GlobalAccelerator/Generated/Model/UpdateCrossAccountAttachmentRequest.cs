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
    /// Container for the parameters to the UpdateCrossAccountAttachment operation.
    /// Update a cross-account attachment to add or remove principals or resources. When you
    /// update an attachment to remove a principal (account ID or accelerator) or a resource,
    /// Global Accelerator revokes the permission for specific resources by doing the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If the principal is an account ID, Global Accelerator reviews every accelerator in
    /// the account and removes cross-account endpoints from all accelerators.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the principal is an accelerator, Global Accelerator reviews just that accelerator
    /// and removes cross-account endpoints from it.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If there are overlapping permissions provided by multiple cross-account attachments,
    /// Global Accelerator only removes endpoints if there are no current cross-account attachments
    /// that provide access permission. For example, if you delete a cross-account attachment
    /// that lists an accelerator as a principal, but another cross-account attachment includes
    /// the account ID that owns that accelerator, endpoints will not be removed from the
    /// accelerator.
    /// </para>
    /// </summary>
    public partial class UpdateCrossAccountAttachmentRequest : AmazonGlobalAcceleratorRequest
    {
        private List<string> _addPrincipals = new List<string>();
        private List<Resource> _addResources = new List<Resource>();
        private string _attachmentArn;
        private string _name;
        private List<string> _removePrincipals = new List<string>();
        private List<Resource> _removeResources = new List<Resource>();

        /// <summary>
        /// Gets and sets the property AddPrincipals. 
        /// <para>
        /// The principals to add to the cross-account attachment. A principal is an account or
        /// the Amazon Resource Name (ARN) of an accelerator that the attachment gives permission
        /// to add the resources from another account, listed in the attachment.
        /// </para>
        ///  
        /// <para>
        /// To add more than one principal, separate the account numbers or accelerator ARNs,
        /// or both, with commas.
        /// </para>
        /// </summary>
        public List<string> AddPrincipals
        {
            get { return this._addPrincipals; }
            set { this._addPrincipals = value; }
        }

        // Check to see if AddPrincipals property is set
        internal bool IsSetAddPrincipals()
        {
            return this._addPrincipals != null && this._addPrincipals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AddResources. 
        /// <para>
        /// The resources to add to the cross-account attachment. A resource listed in a cross-account
        /// attachment can be added to an accelerator by the principals that are listed in the
        /// attachment.
        /// </para>
        ///  
        /// <para>
        /// To add more than one resource, separate the resource ARNs with commas.
        /// </para>
        /// </summary>
        public List<Resource> AddResources
        {
            get { return this._addResources; }
            set { this._addResources = value; }
        }

        // Check to see if AddResources property is set
        internal bool IsSetAddResources()
        {
            return this._addResources != null && this._addResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AttachmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cross-account attachment to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string AttachmentArn
        {
            get { return this._attachmentArn; }
            set { this._attachmentArn = value; }
        }

        // Check to see if AttachmentArn property is set
        internal bool IsSetAttachmentArn()
        {
            return this._attachmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cross-account attachment. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
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
        /// Gets and sets the property RemovePrincipals. 
        /// <para>
        /// The principals to remove from the cross-account attachment. A principal is an account
        /// or the Amazon Resource Name (ARN) of an accelerator that is given permission to add
        /// the resources from another account, listed in the cross-account attachment.
        /// </para>
        ///  
        /// <para>
        /// To remove more than one principal, separate the account numbers or accelerator ARNs,
        /// or both, with commas.
        /// </para>
        /// </summary>
        public List<string> RemovePrincipals
        {
            get { return this._removePrincipals; }
            set { this._removePrincipals = value; }
        }

        // Check to see if RemovePrincipals property is set
        internal bool IsSetRemovePrincipals()
        {
            return this._removePrincipals != null && this._removePrincipals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RemoveResources. 
        /// <para>
        /// The resources to remove from the cross-account attachment. A resource listed in a
        /// cross-account attachment can be added to an accelerator fy principals that are listed
        /// in the cross-account attachment.
        /// </para>
        ///  
        /// <para>
        /// To remove more than one resource, separate the resource ARNs with commas.
        /// </para>
        /// </summary>
        public List<Resource> RemoveResources
        {
            get { return this._removeResources; }
            set { this._removeResources = value; }
        }

        // Check to see if RemoveResources property is set
        internal bool IsSetRemoveResources()
        {
            return this._removeResources != null && this._removeResources.Count > 0; 
        }

    }
}