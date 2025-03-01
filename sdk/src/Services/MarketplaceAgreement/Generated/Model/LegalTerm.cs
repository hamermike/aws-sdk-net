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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Defines the list of text agreements proposed to the acceptors. An example is the end
    /// user license agreement (EULA).
    /// </summary>
    public partial class LegalTerm
    {
        private List<DocumentItem> _documents = new List<DocumentItem>();
        private string _type;

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// List of references to legal resources proposed to the buyers. An example is the EULA.
        /// </para>
        /// </summary>
        public List<DocumentItem> Documents
        {
            get { return this._documents; }
            set { this._documents = value; }
        }

        // Check to see if Documents property is set
        internal bool IsSetDocuments()
        {
            return this._documents != null && this._documents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Category of the term being updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}