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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Parameters that are required to encrypt plaintext data using DUKPT.
    /// </summary>
    public partial class DukptEncryptionAttributes
    {
        private DukptDerivationType _dukptKeyDerivationType;
        private DukptKeyVariant _dukptKeyVariant;
        private string _initializationVector;
        private string _keySerialNumber;
        private DukptEncryptionMode _mode;

        /// <summary>
        /// Gets and sets the property DukptKeyDerivationType. 
        /// <para>
        /// The key type encrypted using DUKPT from a Base Derivation Key (BDK) and Key Serial
        /// Number (KSN). This must be less than or equal to the strength of the BDK. For example,
        /// you can't use <c>AES_128</c> as a derivation type for a BDK of <c>AES_128</c> or <c>TDES_2KEY</c>
        /// 
        /// </para>
        /// </summary>
        public DukptDerivationType DukptKeyDerivationType
        {
            get { return this._dukptKeyDerivationType; }
            set { this._dukptKeyDerivationType = value; }
        }

        // Check to see if DukptKeyDerivationType property is set
        internal bool IsSetDukptKeyDerivationType()
        {
            return this._dukptKeyDerivationType != null;
        }

        /// <summary>
        /// Gets and sets the property DukptKeyVariant. 
        /// <para>
        /// The type of use of DUKPT, which can be incoming data decryption, outgoing data encryption,
        /// or both.
        /// </para>
        /// </summary>
        public DukptKeyVariant DukptKeyVariant
        {
            get { return this._dukptKeyVariant; }
            set { this._dukptKeyVariant = value; }
        }

        // Check to see if DukptKeyVariant property is set
        internal bool IsSetDukptKeyVariant()
        {
            return this._dukptKeyVariant != null;
        }

        /// <summary>
        /// Gets and sets the property InitializationVector. 
        /// <para>
        /// An input to cryptographic primitive used to provide the intial state. Typically the
        /// <c>InitializationVector</c> must have a random or psuedo-random value, but sometimes
        /// it only needs to be unpredictable or unique. If you don't provide a value, Amazon
        /// Web Services Payment Cryptography generates a random value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=16, Max=32)]
        public string InitializationVector
        {
            get { return this._initializationVector; }
            set { this._initializationVector = value; }
        }

        // Check to see if InitializationVector property is set
        internal bool IsSetInitializationVector()
        {
            return this._initializationVector != null;
        }

        /// <summary>
        /// Gets and sets the property KeySerialNumber. 
        /// <para>
        /// The unique identifier known as Key Serial Number (KSN) that comes from an encrypting
        /// device using DUKPT encryption method. The KSN is derived from the encrypting device
        /// unique identifier and an internal transaction counter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=24)]
        public string KeySerialNumber
        {
            get { return this._keySerialNumber; }
            set { this._keySerialNumber = value; }
        }

        // Check to see if KeySerialNumber property is set
        internal bool IsSetKeySerialNumber()
        {
            return this._keySerialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The block cipher mode of operation. Block ciphers are designed to encrypt a block
        /// of data of fixed size, for example, 128 bits. The size of the input block is usually
        /// same as the size of the encrypted output block, while the key length can be different.
        /// A mode of operation describes how to repeatedly apply a cipher's single-block operation
        /// to securely transform amounts of data larger than a block.
        /// </para>
        ///  
        /// <para>
        /// The default is CBC.
        /// </para>
        /// </summary>
        public DukptEncryptionMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}