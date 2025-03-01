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
using System.Net;

using Amazon.PaymentCryptographyData.Model;
using Amazon.PaymentCryptographyData.Model.Internal.MarshallTransformations;
using Amazon.PaymentCryptographyData.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.PaymentCryptographyData
{
    /// <summary>
    /// <para>Implementation for accessing PaymentCryptographyData</para>
    ///
    /// You use the Amazon Web Services Payment Cryptography Data Plane to manage how encryption
    /// keys are used for payment-related transaction processing and associated cryptographic
    /// operations. You can encrypt, decrypt, generate, verify, and translate payment-related
    /// cryptographic operations in Amazon Web Services Payment Cryptography. For more information,
    /// see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/data-operations.html">Data
    /// operations</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// 
    ///  
    /// <para>
    /// To manage your encryption keys, you use the <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/Welcome.html">Amazon
    /// Web Services Payment Cryptography Control Plane</a>. You can create, import, export,
    /// share, manage, and delete keys. You can also manage Identity and Access Management
    /// (IAM) policies for keys. 
    /// </para>
    /// </summary>
    public partial class AmazonPaymentCryptographyDataClient : AmazonServiceClient, IAmazonPaymentCryptographyData
    {
        private static IServiceMetadata serviceMetadata = new AmazonPaymentCryptographyDataMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonPaymentCryptographyDataClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPaymentCryptographyDataConfig()) { }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonPaymentCryptographyDataClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPaymentCryptographyDataConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonPaymentCryptographyDataClient Configuration Object</param>
        public AmazonPaymentCryptographyDataClient(AmazonPaymentCryptographyDataConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPaymentCryptographyDataClient(AWSCredentials credentials)
            : this(credentials, new AmazonPaymentCryptographyDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPaymentCryptographyDataClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPaymentCryptographyDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Credentials and an
        /// AmazonPaymentCryptographyDataClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPaymentCryptographyDataClient Configuration Object</param>
        public AmazonPaymentCryptographyDataClient(AWSCredentials credentials, AmazonPaymentCryptographyDataConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPaymentCryptographyDataClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPaymentCryptographyDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPaymentCryptographyDataClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPaymentCryptographyDataConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPaymentCryptographyDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPaymentCryptographyDataClient Configuration Object</param>
        public AmazonPaymentCryptographyDataClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPaymentCryptographyDataConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPaymentCryptographyDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPaymentCryptographyDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPaymentCryptographyDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPaymentCryptographyDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPaymentCryptographyDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPaymentCryptographyDataClient Configuration Object</param>
        public AmazonPaymentCryptographyDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPaymentCryptographyDataConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPaymentCryptographyDataEndpointResolver());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  DecryptData

        /// <summary>
        /// Decrypts ciphertext data to plaintext using symmetric, asymmetric, or DUKPT data encryption
        /// key. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/decrypt-data.html">Decrypt
        /// data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can use an encryption key generated within Amazon Web Services Payment Cryptography,
        /// or you can import your own encryption key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// For this operation, the key must have <c>KeyModesOfUse</c> set to <c>Decrypt</c>.
        /// In asymmetric decryption, Amazon Web Services Payment Cryptography decrypts the ciphertext
        /// using the private component of the asymmetric encryption key pair. For data encryption
        /// outside of Amazon Web Services Payment Cryptography, you can export the public component
        /// of the asymmetric key pair by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetPublicKeyCertificate.html">GetPublicCertificate</a>.
        /// </para>
        ///  
        /// <para>
        /// For symmetric and DUKPT decryption, Amazon Web Services Payment Cryptography supports
        /// <c>TDES</c> and <c>AES</c> algorithms. For asymmetric decryption, Amazon Web Services
        /// Payment Cryptography supports <c>RSA</c>. When you use DUKPT, for <c>TDES</c> algorithm,
        /// the ciphertext data length must be a multiple of 16 bytes. For <c>AES</c> algorithm,
        /// the ciphertext data length must be a multiple of 32 bytes.
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>EncryptData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetPublicKeyCertificate.html">GetPublicCertificate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DecryptData service method.</param>
        /// 
        /// <returns>The response from the DecryptData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/DecryptData">REST API Reference for DecryptData Operation</seealso>
        public virtual DecryptDataResponse DecryptData(DecryptDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecryptDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecryptDataResponseUnmarshaller.Instance;

            return Invoke<DecryptDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DecryptData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DecryptData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDecryptData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/DecryptData">REST API Reference for DecryptData Operation</seealso>
        public virtual IAsyncResult BeginDecryptData(DecryptDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecryptDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecryptDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DecryptData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDecryptData.</param>
        /// 
        /// <returns>Returns a  DecryptDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/DecryptData">REST API Reference for DecryptData Operation</seealso>
        public virtual DecryptDataResponse EndDecryptData(IAsyncResult asyncResult)
        {
            return EndInvoke<DecryptDataResponse>(asyncResult);
        }

        #endregion
        
        #region  EncryptData

        /// <summary>
        /// Encrypts plaintext data to ciphertext using symmetric, asymmetric, or DUKPT data encryption
        /// key. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/encrypt-data.html">Encrypt
        /// data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can generate an encryption key within Amazon Web Services Payment Cryptography
        /// by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
        /// You can import your own encryption key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// For this operation, the key must have <c>KeyModesOfUse</c> set to <c>Encrypt</c>.
        /// In asymmetric encryption, plaintext is encrypted using public component. You can import
        /// the public component of an asymmetric key pair created outside Amazon Web Services
        /// Payment Cryptography by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>).
        /// 
        /// </para>
        ///  
        /// <para>
        /// for symmetric and DUKPT encryption, Amazon Web Services Payment Cryptography supports
        /// <c>TDES</c> and <c>AES</c> algorithms. For asymmetric encryption, Amazon Web Services
        /// Payment Cryptography supports <c>RSA</c>. To encrypt using DUKPT, you must already
        /// have a DUKPT key in your account with <c>KeyModesOfUse</c> set to <c>DeriveKey</c>,
        /// or you can generate a new DUKPT key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DecryptData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetPublicKeyCertificate.html">GetPublicCertificate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReEncryptData</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EncryptData service method.</param>
        /// 
        /// <returns>The response from the EncryptData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/EncryptData">REST API Reference for EncryptData Operation</seealso>
        public virtual EncryptDataResponse EncryptData(EncryptDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EncryptDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EncryptDataResponseUnmarshaller.Instance;

            return Invoke<EncryptDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EncryptData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EncryptData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEncryptData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/EncryptData">REST API Reference for EncryptData Operation</seealso>
        public virtual IAsyncResult BeginEncryptData(EncryptDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EncryptDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EncryptDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EncryptData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEncryptData.</param>
        /// 
        /// <returns>Returns a  EncryptDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/EncryptData">REST API Reference for EncryptData Operation</seealso>
        public virtual EncryptDataResponse EndEncryptData(IAsyncResult asyncResult)
        {
            return EndInvoke<EncryptDataResponse>(asyncResult);
        }

        #endregion
        
        #region  GenerateCardValidationData

        /// <summary>
        /// Generates card-related validation data using algorithms such as Card Verification
        /// Values (CVV/CVV2), Dynamic Card Verification Values (dCVV/dCVV2), or Card Security
        /// Codes (CSC). For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/generate-card-data.html">Generate
        /// card data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation generates a CVV or CSC value that is printed on a payment credit or
        /// debit card during card production. The CVV or CSC, PAN (Primary Account Number) and
        /// expiration date of the card are required to check its validity during transaction
        /// processing. To begin this operation, a CVK (Card Verification Key) encryption key
        /// is required. You can use <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// or <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
        /// to establish a CVK within Amazon Web Services Payment Cryptography. The <c>KeyModesOfUse</c>
        /// should be set to <c>Generate</c> and <c>Verify</c> for a CVK encryption key. 
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>VerifyCardValidationData</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateCardValidationData service method.</param>
        /// 
        /// <returns>The response from the GenerateCardValidationData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GenerateCardValidationData">REST API Reference for GenerateCardValidationData Operation</seealso>
        public virtual GenerateCardValidationDataResponse GenerateCardValidationData(GenerateCardValidationDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateCardValidationDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateCardValidationDataResponseUnmarshaller.Instance;

            return Invoke<GenerateCardValidationDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateCardValidationData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateCardValidationData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateCardValidationData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GenerateCardValidationData">REST API Reference for GenerateCardValidationData Operation</seealso>
        public virtual IAsyncResult BeginGenerateCardValidationData(GenerateCardValidationDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateCardValidationDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateCardValidationDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateCardValidationData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateCardValidationData.</param>
        /// 
        /// <returns>Returns a  GenerateCardValidationDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GenerateCardValidationData">REST API Reference for GenerateCardValidationData Operation</seealso>
        public virtual GenerateCardValidationDataResponse EndGenerateCardValidationData(IAsyncResult asyncResult)
        {
            return EndInvoke<GenerateCardValidationDataResponse>(asyncResult);
        }

        #endregion
        
        #region  GenerateMac

        /// <summary>
        /// Generates a Message Authentication Code (MAC) cryptogram within Amazon Web Services
        /// Payment Cryptography. 
        /// 
        ///  
        /// <para>
        /// You can use this operation when keys won't be shared but mutual data is present on
        /// both ends for validation. In this case, known data values are used to generate a MAC
        /// on both ends for comparision without sending or receiving data in ciphertext or plaintext.
        /// You can use this operation to generate a DUPKT, HMAC or EMV MAC by setting generation
        /// attributes and algorithm to the associated values. The MAC generation encryption key
        /// must have valid values for <c>KeyUsage</c> such as <c>TR31_M7_HMAC_KEY</c> for HMAC
        /// generation, and they key must have <c>KeyModesOfUse</c> set to <c>Generate</c> and
        /// <c>Verify</c>.
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>VerifyMac</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateMac service method.</param>
        /// 
        /// <returns>The response from the GenerateMac service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GenerateMac">REST API Reference for GenerateMac Operation</seealso>
        public virtual GenerateMacResponse GenerateMac(GenerateMacRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateMacRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateMacResponseUnmarshaller.Instance;

            return Invoke<GenerateMacResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateMac operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateMac operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateMac
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GenerateMac">REST API Reference for GenerateMac Operation</seealso>
        public virtual IAsyncResult BeginGenerateMac(GenerateMacRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateMacRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateMacResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateMac operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateMac.</param>
        /// 
        /// <returns>Returns a  GenerateMacResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GenerateMac">REST API Reference for GenerateMac Operation</seealso>
        public virtual GenerateMacResponse EndGenerateMac(IAsyncResult asyncResult)
        {
            return EndInvoke<GenerateMacResponse>(asyncResult);
        }

        #endregion
        
        #region  GeneratePinData

        /// <summary>
        /// Generates pin-related data such as PIN, PIN Verification Value (PVV), PIN Block, and
        /// PIN Offset during new card issuance or reissuance. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/generate-pin-data.html">Generate
        /// PIN data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// PIN data is never transmitted in clear to or from Amazon Web Services Payment Cryptography.
        /// This operation generates PIN, PVV, or PIN Offset and then encrypts it using Pin Encryption
        /// Key (PEK) to create an <c>EncryptedPinBlock</c> for transmission from Amazon Web Services
        /// Payment Cryptography. This operation uses a separate Pin Verification Key (PVK) for
        /// VISA PVV generation. 
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GenerateCardValidationData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>TranslatePinData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>VerifyPinData</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GeneratePinData service method.</param>
        /// 
        /// <returns>The response from the GeneratePinData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GeneratePinData">REST API Reference for GeneratePinData Operation</seealso>
        public virtual GeneratePinDataResponse GeneratePinData(GeneratePinDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GeneratePinDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GeneratePinDataResponseUnmarshaller.Instance;

            return Invoke<GeneratePinDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GeneratePinData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GeneratePinData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGeneratePinData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GeneratePinData">REST API Reference for GeneratePinData Operation</seealso>
        public virtual IAsyncResult BeginGeneratePinData(GeneratePinDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GeneratePinDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GeneratePinDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GeneratePinData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGeneratePinData.</param>
        /// 
        /// <returns>Returns a  GeneratePinDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GeneratePinData">REST API Reference for GeneratePinData Operation</seealso>
        public virtual GeneratePinDataResponse EndGeneratePinData(IAsyncResult asyncResult)
        {
            return EndInvoke<GeneratePinDataResponse>(asyncResult);
        }

        #endregion
        
        #region  ReEncryptData

        /// <summary>
        /// Re-encrypt ciphertext using DUKPT, Symmetric and Asymmetric Data Encryption Keys.
        /// 
        /// 
        ///  
        /// <para>
        /// You can either generate an encryption key within Amazon Web Services Payment Cryptography
        /// by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// or import your own encryption key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// The <c>KeyArn</c> for use with this operation must be in a compatible key state with
        /// <c>KeyModesOfUse</c> set to <c>Encrypt</c>. In asymmetric encryption, ciphertext is
        /// encrypted using public component (imported by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>)
        /// of the asymmetric key pair created outside of Amazon Web Services Payment Cryptography.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For symmetric and DUKPT encryption, Amazon Web Services Payment Cryptography supports
        /// <c>TDES</c> and <c>AES</c> algorithms. For asymmetric encryption, Amazon Web Services
        /// Payment Cryptography supports <c>RSA</c>. To encrypt using DUKPT, a DUKPT key must
        /// already exist within your account with <c>KeyModesOfUse</c> set to <c>DeriveKey</c>
        /// or a new DUKPT can be generated by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DecryptData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>EncryptData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetPublicKeyCertificate.html">GetPublicCertificate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReEncryptData service method.</param>
        /// 
        /// <returns>The response from the ReEncryptData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/ReEncryptData">REST API Reference for ReEncryptData Operation</seealso>
        public virtual ReEncryptDataResponse ReEncryptData(ReEncryptDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReEncryptDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReEncryptDataResponseUnmarshaller.Instance;

            return Invoke<ReEncryptDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReEncryptData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReEncryptData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReEncryptData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/ReEncryptData">REST API Reference for ReEncryptData Operation</seealso>
        public virtual IAsyncResult BeginReEncryptData(ReEncryptDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReEncryptDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReEncryptDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReEncryptData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReEncryptData.</param>
        /// 
        /// <returns>Returns a  ReEncryptDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/ReEncryptData">REST API Reference for ReEncryptData Operation</seealso>
        public virtual ReEncryptDataResponse EndReEncryptData(IAsyncResult asyncResult)
        {
            return EndInvoke<ReEncryptDataResponse>(asyncResult);
        }

        #endregion
        
        #region  TranslatePinData

        /// <summary>
        /// Translates encrypted PIN block from and to ISO 9564 formats 0,1,3,4. For more information,
        /// see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/translate-pin-data.html">Translate
        /// PIN data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// PIN block translation involves changing the encrytion of PIN block from one encryption
        /// key to another encryption key and changing PIN block format from one to another without
        /// PIN block data leaving Amazon Web Services Payment Cryptography. The encryption key
        /// transformation can be from PEK (Pin Encryption Key) to BDK (Base Derivation Key) for
        /// DUKPT or from BDK for DUKPT to PEK. Amazon Web Services Payment Cryptography supports
        /// <c>TDES</c> and <c>AES</c> key derivation type for DUKPT tranlations. You can use
        /// this operation for P2PE (Point to Point Encryption) use cases where the encryption
        /// keys should change but the processing system either does not need to, or is not permitted
        /// to, decrypt the data.
        /// </para>
        ///  
        /// <para>
        /// The allowed combinations of PIN block format translations are guided by PCI. It is
        /// important to note that not all encrypted PIN block formats (example, format 1) require
        /// PAN (Primary Account Number) as input. And as such, PIN block format that requires
        /// PAN (example, formats 0,3,4) cannot be translated to a format (format 1) that does
        /// not require a PAN for generation. 
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// At this time, Amazon Web Services Payment Cryptography does not support translations
        /// to PIN format 4.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GeneratePinData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>VerifyPinData</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TranslatePinData service method.</param>
        /// 
        /// <returns>The response from the TranslatePinData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/TranslatePinData">REST API Reference for TranslatePinData Operation</seealso>
        public virtual TranslatePinDataResponse TranslatePinData(TranslatePinDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TranslatePinDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TranslatePinDataResponseUnmarshaller.Instance;

            return Invoke<TranslatePinDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TranslatePinData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TranslatePinData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTranslatePinData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/TranslatePinData">REST API Reference for TranslatePinData Operation</seealso>
        public virtual IAsyncResult BeginTranslatePinData(TranslatePinDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TranslatePinDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TranslatePinDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TranslatePinData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTranslatePinData.</param>
        /// 
        /// <returns>Returns a  TranslatePinDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/TranslatePinData">REST API Reference for TranslatePinData Operation</seealso>
        public virtual TranslatePinDataResponse EndTranslatePinData(IAsyncResult asyncResult)
        {
            return EndInvoke<TranslatePinDataResponse>(asyncResult);
        }

        #endregion
        
        #region  VerifyAuthRequestCryptogram

        /// <summary>
        /// Verifies Authorization Request Cryptogram (ARQC) for a EMV chip payment card authorization.
        /// For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/data-operations.verifyauthrequestcryptogram.html">Verify
        /// auth request cryptogram</a> in the <i>Amazon Web Services Payment Cryptography User
        /// Guide</i>.
        /// 
        ///  
        /// <para>
        /// ARQC generation is done outside of Amazon Web Services Payment Cryptography and is
        /// typically generated on a point of sale terminal for an EMV chip card to obtain payment
        /// authorization during transaction time. For ARQC verification, you must first import
        /// the ARQC generated outside of Amazon Web Services Payment Cryptography by calling
        /// <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// This operation uses the imported ARQC and an major encryption key (DUKPT) created
        /// by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// to either provide a boolean ARQC verification result or provide an APRC (Authorization
        /// Response Cryptogram) response using Method 1 or Method 2. The <c>ARPC_METHOD_1</c>
        /// uses <c>AuthResponseCode</c> to generate ARPC and <c>ARPC_METHOD_2</c> uses <c>CardStatusUpdate</c>
        /// to generate ARPC. 
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>VerifyCardValidationData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>VerifyPinData</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyAuthRequestCryptogram service method.</param>
        /// 
        /// <returns>The response from the VerifyAuthRequestCryptogram service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.VerificationFailedException">
        /// This request failed verification.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyAuthRequestCryptogram">REST API Reference for VerifyAuthRequestCryptogram Operation</seealso>
        public virtual VerifyAuthRequestCryptogramResponse VerifyAuthRequestCryptogram(VerifyAuthRequestCryptogramRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyAuthRequestCryptogramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyAuthRequestCryptogramResponseUnmarshaller.Instance;

            return Invoke<VerifyAuthRequestCryptogramResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyAuthRequestCryptogram operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyAuthRequestCryptogram operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyAuthRequestCryptogram
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyAuthRequestCryptogram">REST API Reference for VerifyAuthRequestCryptogram Operation</seealso>
        public virtual IAsyncResult BeginVerifyAuthRequestCryptogram(VerifyAuthRequestCryptogramRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyAuthRequestCryptogramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyAuthRequestCryptogramResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyAuthRequestCryptogram operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyAuthRequestCryptogram.</param>
        /// 
        /// <returns>Returns a  VerifyAuthRequestCryptogramResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyAuthRequestCryptogram">REST API Reference for VerifyAuthRequestCryptogram Operation</seealso>
        public virtual VerifyAuthRequestCryptogramResponse EndVerifyAuthRequestCryptogram(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyAuthRequestCryptogramResponse>(asyncResult);
        }

        #endregion
        
        #region  VerifyCardValidationData

        /// <summary>
        /// Verifies card-related validation data using algorithms such as Card Verification Values
        /// (CVV/CVV2), Dynamic Card Verification Values (dCVV/dCVV2) and Card Security Codes
        /// (CSC). For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/verify-card-data.html">Verify
        /// card data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation validates the CVV or CSC codes that is printed on a payment credit
        /// or debit card during card payment transaction. The input values are typically provided
        /// as part of an inbound transaction to an issuer or supporting platform partner. Amazon
        /// Web Services Payment Cryptography uses CVV or CSC, PAN (Primary Account Number) and
        /// expiration date of the card to check its validity during transaction processing. In
        /// this operation, the CVK (Card Verification Key) encryption key for use with card data
        /// verification is same as the one in used for <a>GenerateCardValidationData</a>. 
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GenerateCardValidationData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>VerifyAuthRequestCryptogram</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>VerifyPinData</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyCardValidationData service method.</param>
        /// 
        /// <returns>The response from the VerifyCardValidationData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.VerificationFailedException">
        /// This request failed verification.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyCardValidationData">REST API Reference for VerifyCardValidationData Operation</seealso>
        public virtual VerifyCardValidationDataResponse VerifyCardValidationData(VerifyCardValidationDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyCardValidationDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyCardValidationDataResponseUnmarshaller.Instance;

            return Invoke<VerifyCardValidationDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyCardValidationData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyCardValidationData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyCardValidationData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyCardValidationData">REST API Reference for VerifyCardValidationData Operation</seealso>
        public virtual IAsyncResult BeginVerifyCardValidationData(VerifyCardValidationDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyCardValidationDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyCardValidationDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyCardValidationData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyCardValidationData.</param>
        /// 
        /// <returns>Returns a  VerifyCardValidationDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyCardValidationData">REST API Reference for VerifyCardValidationData Operation</seealso>
        public virtual VerifyCardValidationDataResponse EndVerifyCardValidationData(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyCardValidationDataResponse>(asyncResult);
        }

        #endregion
        
        #region  VerifyMac

        /// <summary>
        /// Verifies a Message Authentication Code (MAC). 
        /// 
        ///  
        /// <para>
        /// You can use this operation when keys won't be shared but mutual data is present on
        /// both ends for validation. In this case, known data values are used to generate a MAC
        /// on both ends for verification without sending or receiving data in ciphertext or plaintext.
        /// You can use this operation to verify a DUPKT, HMAC or EMV MAC by setting generation
        /// attributes and algorithm to the associated values. Use the same encryption key for
        /// MAC verification as you use for <a>GenerateMac</a>. 
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GenerateMac</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyMac service method.</param>
        /// 
        /// <returns>The response from the VerifyMac service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.VerificationFailedException">
        /// This request failed verification.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyMac">REST API Reference for VerifyMac Operation</seealso>
        public virtual VerifyMacResponse VerifyMac(VerifyMacRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyMacRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyMacResponseUnmarshaller.Instance;

            return Invoke<VerifyMacResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyMac operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyMac operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyMac
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyMac">REST API Reference for VerifyMac Operation</seealso>
        public virtual IAsyncResult BeginVerifyMac(VerifyMacRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyMacRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyMacResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyMac operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyMac.</param>
        /// 
        /// <returns>Returns a  VerifyMacResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyMac">REST API Reference for VerifyMac Operation</seealso>
        public virtual VerifyMacResponse EndVerifyMac(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyMacResponse>(asyncResult);
        }

        #endregion
        
        #region  VerifyPinData

        /// <summary>
        /// Verifies pin-related data such as PIN and PIN Offset using algorithms including VISA
        /// PVV and IBM3624. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/verify-pin-data.html">Verify
        /// PIN data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation verifies PIN data for user payment card. A card holder PIN data is
        /// never transmitted in clear to or from Amazon Web Services Payment Cryptography. This
        /// operation uses PIN Verification Key (PVK) for PIN or PIN Offset generation and then
        /// encrypts it using PIN Encryption Key (PEK) to create an <c>EncryptedPinBlock</c> for
        /// transmission from Amazon Web Services Payment Cryptography. 
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GeneratePinData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>TranslatePinData</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyPinData service method.</param>
        /// 
        /// <returns>The response from the VerifyPinData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.VerificationFailedException">
        /// This request failed verification.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyPinData">REST API Reference for VerifyPinData Operation</seealso>
        public virtual VerifyPinDataResponse VerifyPinData(VerifyPinDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyPinDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyPinDataResponseUnmarshaller.Instance;

            return Invoke<VerifyPinDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyPinData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyPinData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyPinData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyPinData">REST API Reference for VerifyPinData Operation</seealso>
        public virtual IAsyncResult BeginVerifyPinData(VerifyPinDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyPinDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyPinDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyPinData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyPinData.</param>
        /// 
        /// <returns>Returns a  VerifyPinDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyPinData">REST API Reference for VerifyPinData Operation</seealso>
        public virtual VerifyPinDataResponse EndVerifyPinData(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyPinDataResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonPaymentCryptographyDataEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}