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
 * Do not modify this file. This file is generated from the managedblockchain-query-2023-05-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedBlockchainQuery.Model
{
    /// <summary>
    /// Container for the parameters to the GetTransaction operation.
    /// Gets the details of a transaction.
    /// 
    ///  <note> 
    /// <para>
    /// This action will return transaction details for all transactions that are <i>confirmed</i>
    /// on the blockchain, even if they have not reached <a href="https://docs.aws.amazon.com/managed-blockchain/latest/ambq-dg/key-concepts.html#finality">finality</a>.
    /// 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetTransactionRequest : AmazonManagedBlockchainQueryRequest
    {
        private QueryNetwork _network;
        private string _transactionHash;

        /// <summary>
        /// Gets and sets the property Network. 
        /// <para>
        /// The blockchain network where the transaction occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryNetwork Network
        {
            get { return this._network; }
            set { this._network = value; }
        }

        // Check to see if Network property is set
        internal bool IsSetNetwork()
        {
            return this._network != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionHash. 
        /// <para>
        /// The hash of the transaction. It is generated whenever a transaction is verified and
        /// added to the blockchain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransactionHash
        {
            get { return this._transactionHash; }
            set { this._transactionHash = value; }
        }

        // Check to see if TransactionHash property is set
        internal bool IsSetTransactionHash()
        {
            return this._transactionHash != null;
        }

    }
}