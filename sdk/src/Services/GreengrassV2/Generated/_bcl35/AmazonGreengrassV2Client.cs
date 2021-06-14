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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.GreengrassV2.Model;
using Amazon.GreengrassV2.Model.Internal.MarshallTransformations;
using Amazon.GreengrassV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.GreengrassV2
{
    /// <summary>
    /// Implementation for accessing GreengrassV2
    ///
    /// AWS IoT Greengrass brings local compute, messaging, data management, sync, and ML
    /// inference capabilities to edge devices. This enables devices to collect and analyze
    /// data closer to the source of information, react autonomously to local events, and
    /// communicate securely with each other on local networks. Local devices can also communicate
    /// securely with AWS IoT Core and export IoT data to the AWS Cloud. AWS IoT Greengrass
    /// developers can use AWS Lambda functions and components to create and deploy applications
    /// to fleets of edge devices for local operation.
    /// 
    ///  
    /// <para>
    /// AWS IoT Greengrass Version 2 provides a new major version of the AWS IoT Greengrass
    /// Core software, new APIs, and a new console. Use this API reference to learn how to
    /// use the AWS IoT Greengrass V2 API operations to manage components, manage deployments,
    /// and core devices.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/what-is-iot-greengrass.html">What
    /// is AWS IoT Greengrass?</a> in the <i>AWS IoT Greengrass V2 Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonGreengrassV2Client : AmazonServiceClient, IAmazonGreengrassV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonGreengrassV2Metadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with the credentials loaded from the application's
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
        public AmazonGreengrassV2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGreengrassV2Config()) { }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with the credentials loaded from the application's
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
        public AmazonGreengrassV2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGreengrassV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGreengrassV2Client Configuration Object</param>
        public AmazonGreengrassV2Client(AmazonGreengrassV2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGreengrassV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonGreengrassV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGreengrassV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGreengrassV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Credentials and an
        /// AmazonGreengrassV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGreengrassV2Client Configuration Object</param>
        public AmazonGreengrassV2Client(AWSCredentials credentials, AmazonGreengrassV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGreengrassV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGreengrassV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGreengrassV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGreengrassV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGreengrassV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGreengrassV2Client Configuration Object</param>
        public AmazonGreengrassV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonGreengrassV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGreengrassV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGreengrassV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGreengrassV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGreengrassV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGreengrassV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGreengrassV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGreengrassV2Client Configuration Object</param>
        public AmazonGreengrassV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGreengrassV2Config clientConfig)
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


        #region  BatchAssociateClientDeviceWithCoreDevice

        /// <summary>
        /// Associate a list of client devices with a core device. Use this API operation to specify
        /// which client devices can discover a core device through cloud discovery. With cloud
        /// discovery, client devices connect to AWS IoT Greengrass to retrieve associated core
        /// devices' connectivity information and certificates. For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/configure-cloud-discovery.html">Configure
        /// cloud discovery</a> in the <i>AWS IoT Greengrass V2 Developer Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// Client devices are local IoT devices that connect to and communicate with an AWS IoT
        /// Greengrass core device over MQTT. You can connect client devices to a core device
        /// to sync MQTT messages and data to AWS IoT Core and interact with client devices in
        /// AWS IoT Greengrass components. For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/interact-with-local-iot-devices.html">Interact
        /// with local IoT devices</a> in the <i>AWS IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateClientDeviceWithCoreDevice service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateClientDeviceWithCoreDevice service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/BatchAssociateClientDeviceWithCoreDevice">REST API Reference for BatchAssociateClientDeviceWithCoreDevice Operation</seealso>
        public virtual BatchAssociateClientDeviceWithCoreDeviceResponse BatchAssociateClientDeviceWithCoreDevice(BatchAssociateClientDeviceWithCoreDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateClientDeviceWithCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateClientDeviceWithCoreDeviceResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateClientDeviceWithCoreDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateClientDeviceWithCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateClientDeviceWithCoreDevice operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAssociateClientDeviceWithCoreDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/BatchAssociateClientDeviceWithCoreDevice">REST API Reference for BatchAssociateClientDeviceWithCoreDevice Operation</seealso>
        public virtual IAsyncResult BeginBatchAssociateClientDeviceWithCoreDevice(BatchAssociateClientDeviceWithCoreDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchAssociateClientDeviceWithCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateClientDeviceWithCoreDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAssociateClientDeviceWithCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAssociateClientDeviceWithCoreDevice.</param>
        /// 
        /// <returns>Returns a  BatchAssociateClientDeviceWithCoreDeviceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/BatchAssociateClientDeviceWithCoreDevice">REST API Reference for BatchAssociateClientDeviceWithCoreDevice Operation</seealso>
        public virtual BatchAssociateClientDeviceWithCoreDeviceResponse EndBatchAssociateClientDeviceWithCoreDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchAssociateClientDeviceWithCoreDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDisassociateClientDeviceFromCoreDevice

        /// <summary>
        /// Disassociate a list of client devices from a core device. After you disassociate a
        /// client device from a core device, the client device won't be able to use cloud discovery
        /// to retrieve the core device's connectivity information and certificates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateClientDeviceFromCoreDevice service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateClientDeviceFromCoreDevice service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/BatchDisassociateClientDeviceFromCoreDevice">REST API Reference for BatchDisassociateClientDeviceFromCoreDevice Operation</seealso>
        public virtual BatchDisassociateClientDeviceFromCoreDeviceResponse BatchDisassociateClientDeviceFromCoreDevice(BatchDisassociateClientDeviceFromCoreDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateClientDeviceFromCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateClientDeviceFromCoreDeviceResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateClientDeviceFromCoreDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateClientDeviceFromCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateClientDeviceFromCoreDevice operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisassociateClientDeviceFromCoreDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/BatchDisassociateClientDeviceFromCoreDevice">REST API Reference for BatchDisassociateClientDeviceFromCoreDevice Operation</seealso>
        public virtual IAsyncResult BeginBatchDisassociateClientDeviceFromCoreDevice(BatchDisassociateClientDeviceFromCoreDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDisassociateClientDeviceFromCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateClientDeviceFromCoreDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisassociateClientDeviceFromCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisassociateClientDeviceFromCoreDevice.</param>
        /// 
        /// <returns>Returns a  BatchDisassociateClientDeviceFromCoreDeviceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/BatchDisassociateClientDeviceFromCoreDevice">REST API Reference for BatchDisassociateClientDeviceFromCoreDevice Operation</seealso>
        public virtual BatchDisassociateClientDeviceFromCoreDeviceResponse EndBatchDisassociateClientDeviceFromCoreDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDisassociateClientDeviceFromCoreDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelDeployment

        /// <summary>
        /// Cancels a deployment. This operation cancels the deployment for devices that haven't
        /// yet received it. If a device already received the deployment, this operation doesn't
        /// change anything for that device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDeployment service method.</param>
        /// 
        /// <returns>The response from the CancelDeployment service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CancelDeployment">REST API Reference for CancelDeployment Operation</seealso>
        public virtual CancelDeploymentResponse CancelDeployment(CancelDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDeploymentResponseUnmarshaller.Instance;

            return Invoke<CancelDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelDeployment operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CancelDeployment">REST API Reference for CancelDeployment Operation</seealso>
        public virtual IAsyncResult BeginCancelDeployment(CancelDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelDeployment.</param>
        /// 
        /// <returns>Returns a  CancelDeploymentResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CancelDeployment">REST API Reference for CancelDeployment Operation</seealso>
        public virtual CancelDeploymentResponse EndCancelDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateComponentVersion

        /// <summary>
        /// Creates a component. Components are software that run on AWS IoT Greengrass core devices.
        /// After you develop and test a component on your core device, you can use this operation
        /// to upload your component to AWS IoT Greengrass. Then, you can deploy the component
        /// to other core devices.
        /// 
        ///  
        /// <para>
        /// You can use this operation to do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Create components from recipes</b> 
        /// </para>
        ///  
        /// <para>
        /// Create a component from a recipe, which is a file that defines the component's metadata,
        /// parameters, dependencies, lifecycle, artifacts, and platform capability. For more
        /// information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/component-recipe-reference.html">AWS
        /// IoT Greengrass component recipe reference</a> in the <i>AWS IoT Greengrass V2 Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To create a component from a recipe, specify <code>inlineRecipe</code> when you call
        /// this operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Create components from Lambda functions</b> 
        /// </para>
        ///  
        /// <para>
        /// Create a component from an AWS Lambda function that runs on AWS IoT Greengrass. This
        /// creates a recipe and artifacts from the Lambda function's deployment package. You
        /// can use this operation to migrate Lambda functions from AWS IoT Greengrass V1 to AWS
        /// IoT Greengrass V2.
        /// </para>
        ///  
        /// <para>
        /// This function only accepts Lambda functions that use the following runtimes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Python 2.7 – <code>python2.7</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Python 3.7 – <code>python3.7</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Python 3.8 – <code>python3.8</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Java 8 – <code>java8</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Node.js 10 – <code>nodejs10.x</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Node.js 12 – <code>nodejs12.x</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To create a component from a Lambda function, specify <code>lambdaFunction</code>
        /// when you call this operation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponentVersion service method.</param>
        /// 
        /// <returns>The response from the CreateComponentVersion service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota. For example, you might have the maximum number
        /// of components that you can create.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CreateComponentVersion">REST API Reference for CreateComponentVersion Operation</seealso>
        public virtual CreateComponentVersionResponse CreateComponentVersion(CreateComponentVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentVersionResponseUnmarshaller.Instance;

            return Invoke<CreateComponentVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateComponentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComponentVersion operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComponentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CreateComponentVersion">REST API Reference for CreateComponentVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateComponentVersion(CreateComponentVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateComponentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateComponentVersion.</param>
        /// 
        /// <returns>Returns a  CreateComponentVersionResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CreateComponentVersion">REST API Reference for CreateComponentVersion Operation</seealso>
        public virtual CreateComponentVersionResponse EndCreateComponentVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateComponentVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDeployment

        /// <summary>
        /// Creates a continuous deployment for a target, which is a AWS IoT Greengrass core device
        /// or group of core devices. When you add a new core device to a group of core devices
        /// that has a deployment, AWS IoT Greengrass deploys that group's deployment to the new
        /// device.
        /// 
        ///  
        /// <para>
        /// You can define one deployment for each target. When you create a new deployment for
        /// a target that has an existing deployment, you replace the previous deployment. AWS
        /// IoT Greengrass applies the new deployment to the target devices.
        /// </para>
        ///  
        /// <para>
        /// Every deployment has a revision number that indicates how many deployment revisions
        /// you define for a target. Use this operation to create a new revision of an existing
        /// deployment. This operation returns the revision number of the new deployment when
        /// you create it.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/create-deployments.html">Create
        /// deployments</a> in the <i>AWS IoT Greengrass V2 Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteComponent

        /// <summary>
        /// Deletes a version of a component from AWS IoT Greengrass.
        /// 
        ///  <note> 
        /// <para>
        /// This operation deletes the component's recipe and artifacts. As a result, deployments
        /// that refer to this component version will fail. If you have deployments that use this
        /// component version, you can remove the component from the deployment or update the
        /// deployment to use a valid version.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent service method.</param>
        /// 
        /// <returns>The response from the DeleteComponent service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual DeleteComponentResponse DeleteComponent(DeleteComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return Invoke<DeleteComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual IAsyncResult BeginDeleteComponent(DeleteComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteComponent.</param>
        /// 
        /// <returns>Returns a  DeleteComponentResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual DeleteComponentResponse EndDeleteComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCoreDevice

        /// <summary>
        /// Deletes a AWS IoT Greengrass core device, which is an AWS IoT thing. This operation
        /// removes the core device from the list of core devices. This operation doesn't delete
        /// the AWS IoT thing. For more information about how to delete the AWS IoT thing, see
        /// <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_DeleteThing.html">DeleteThing</a>
        /// in the <i>AWS IoT API Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreDevice service method.</param>
        /// 
        /// <returns>The response from the DeleteCoreDevice service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DeleteCoreDevice">REST API Reference for DeleteCoreDevice Operation</seealso>
        public virtual DeleteCoreDeviceResponse DeleteCoreDevice(DeleteCoreDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreDeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteCoreDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreDevice operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCoreDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DeleteCoreDevice">REST API Reference for DeleteCoreDevice Operation</seealso>
        public virtual IAsyncResult BeginDeleteCoreDevice(DeleteCoreDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCoreDevice.</param>
        /// 
        /// <returns>Returns a  DeleteCoreDeviceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DeleteCoreDevice">REST API Reference for DeleteCoreDevice Operation</seealso>
        public virtual DeleteCoreDeviceResponse EndDeleteCoreDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCoreDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeComponent

        /// <summary>
        /// Retrieves metadata for a version of a component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponent service method.</param>
        /// 
        /// <returns>The response from the DescribeComponent service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        public virtual DescribeComponentResponse DescribeComponent(DescribeComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentResponseUnmarshaller.Instance;

            return Invoke<DescribeComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComponent operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        public virtual IAsyncResult BeginDescribeComponent(DescribeComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComponent.</param>
        /// 
        /// <returns>Returns a  DescribeComponentResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/DescribeComponent">REST API Reference for DescribeComponent Operation</seealso>
        public virtual DescribeComponentResponse EndDescribeComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComponent

        /// <summary>
        /// Gets the recipe for a version of a component. Core devices can call this operation
        /// to identify the artifacts and requirements to install a component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
        /// 
        /// <returns>The response from the GetComponent service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual GetComponentResponse GetComponent(GetComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return Invoke<GetComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComponent operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual IAsyncResult BeginGetComponent(GetComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComponent.</param>
        /// 
        /// <returns>Returns a  GetComponentResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual GetComponentResponse EndGetComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComponentVersionArtifact

        /// <summary>
        /// Gets the pre-signed URL to download a public component artifact. Core devices call
        /// this operation to identify the URL that they can use to download an artifact to install.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponentVersionArtifact service method.</param>
        /// 
        /// <returns>The response from the GetComponentVersionArtifact service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetComponentVersionArtifact">REST API Reference for GetComponentVersionArtifact Operation</seealso>
        public virtual GetComponentVersionArtifactResponse GetComponentVersionArtifact(GetComponentVersionArtifactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentVersionArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentVersionArtifactResponseUnmarshaller.Instance;

            return Invoke<GetComponentVersionArtifactResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComponentVersionArtifact operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComponentVersionArtifact operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComponentVersionArtifact
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetComponentVersionArtifact">REST API Reference for GetComponentVersionArtifact Operation</seealso>
        public virtual IAsyncResult BeginGetComponentVersionArtifact(GetComponentVersionArtifactRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentVersionArtifactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentVersionArtifactResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComponentVersionArtifact operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComponentVersionArtifact.</param>
        /// 
        /// <returns>Returns a  GetComponentVersionArtifactResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetComponentVersionArtifact">REST API Reference for GetComponentVersionArtifact Operation</seealso>
        public virtual GetComponentVersionArtifactResponse EndGetComponentVersionArtifact(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComponentVersionArtifactResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCoreDevice

        /// <summary>
        /// Retrieves metadata for a AWS IoT Greengrass core device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDevice service method.</param>
        /// 
        /// <returns>The response from the GetCoreDevice service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetCoreDevice">REST API Reference for GetCoreDevice Operation</seealso>
        public virtual GetCoreDeviceResponse GetCoreDevice(GetCoreDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreDeviceResponseUnmarshaller.Instance;

            return Invoke<GetCoreDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCoreDevice operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCoreDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetCoreDevice">REST API Reference for GetCoreDevice Operation</seealso>
        public virtual IAsyncResult BeginGetCoreDevice(GetCoreDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCoreDevice.</param>
        /// 
        /// <returns>Returns a  GetCoreDeviceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetCoreDevice">REST API Reference for GetCoreDevice Operation</seealso>
        public virtual GetCoreDeviceResponse EndGetCoreDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCoreDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeployment

        /// <summary>
        /// Gets a deployment. Deployments define the components that run on AWS IoT Greengrass
        /// core devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual IAsyncResult BeginGetDeployment(GetDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployment.</param>
        /// 
        /// <returns>Returns a  GetDeploymentResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual GetDeploymentResponse EndGetDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  ListClientDevicesAssociatedWithCoreDevice

        /// <summary>
        /// Retrieves a paginated list of client devices that are associated with a core device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClientDevicesAssociatedWithCoreDevice service method.</param>
        /// 
        /// <returns>The response from the ListClientDevicesAssociatedWithCoreDevice service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListClientDevicesAssociatedWithCoreDevice">REST API Reference for ListClientDevicesAssociatedWithCoreDevice Operation</seealso>
        public virtual ListClientDevicesAssociatedWithCoreDeviceResponse ListClientDevicesAssociatedWithCoreDevice(ListClientDevicesAssociatedWithCoreDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClientDevicesAssociatedWithCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClientDevicesAssociatedWithCoreDeviceResponseUnmarshaller.Instance;

            return Invoke<ListClientDevicesAssociatedWithCoreDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClientDevicesAssociatedWithCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClientDevicesAssociatedWithCoreDevice operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClientDevicesAssociatedWithCoreDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListClientDevicesAssociatedWithCoreDevice">REST API Reference for ListClientDevicesAssociatedWithCoreDevice Operation</seealso>
        public virtual IAsyncResult BeginListClientDevicesAssociatedWithCoreDevice(ListClientDevicesAssociatedWithCoreDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClientDevicesAssociatedWithCoreDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClientDevicesAssociatedWithCoreDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClientDevicesAssociatedWithCoreDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClientDevicesAssociatedWithCoreDevice.</param>
        /// 
        /// <returns>Returns a  ListClientDevicesAssociatedWithCoreDeviceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListClientDevicesAssociatedWithCoreDevice">REST API Reference for ListClientDevicesAssociatedWithCoreDevice Operation</seealso>
        public virtual ListClientDevicesAssociatedWithCoreDeviceResponse EndListClientDevicesAssociatedWithCoreDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClientDevicesAssociatedWithCoreDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComponents

        /// <summary>
        /// Retrieves a paginated list of component summaries. This list includes components that
        /// you have permission to view.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return Invoke<ListComponentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponents operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual IAsyncResult BeginListComponents(ListComponentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComponents.</param>
        /// 
        /// <returns>Returns a  ListComponentsResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual ListComponentsResponse EndListComponents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComponentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComponentVersions

        /// <summary>
        /// Retrieves a paginated list of all versions for a component. Greater versions are listed
        /// first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponentVersions service method.</param>
        /// 
        /// <returns>The response from the ListComponentVersions service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListComponentVersions">REST API Reference for ListComponentVersions Operation</seealso>
        public virtual ListComponentVersionsResponse ListComponentVersions(ListComponentVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentVersionsResponseUnmarshaller.Instance;

            return Invoke<ListComponentVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponentVersions operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponentVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListComponentVersions">REST API Reference for ListComponentVersions Operation</seealso>
        public virtual IAsyncResult BeginListComponentVersions(ListComponentVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComponentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComponentVersions.</param>
        /// 
        /// <returns>Returns a  ListComponentVersionsResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListComponentVersions">REST API Reference for ListComponentVersions Operation</seealso>
        public virtual ListComponentVersionsResponse EndListComponentVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComponentVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCoreDevices

        /// <summary>
        /// Retrieves a paginated list of AWS IoT Greengrass core devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDevices service method.</param>
        /// 
        /// <returns>The response from the ListCoreDevices service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListCoreDevices">REST API Reference for ListCoreDevices Operation</seealso>
        public virtual ListCoreDevicesResponse ListCoreDevices(ListCoreDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCoreDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreDevicesResponseUnmarshaller.Instance;

            return Invoke<ListCoreDevicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCoreDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCoreDevices operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCoreDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListCoreDevices">REST API Reference for ListCoreDevices Operation</seealso>
        public virtual IAsyncResult BeginListCoreDevices(ListCoreDevicesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCoreDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreDevicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCoreDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCoreDevices.</param>
        /// 
        /// <returns>Returns a  ListCoreDevicesResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListCoreDevices">REST API Reference for ListCoreDevices Operation</seealso>
        public virtual ListCoreDevicesResponse EndListCoreDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCoreDevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDeployments

        /// <summary>
        /// Retrieves a paginated list of deployments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments service method.</param>
        /// 
        /// <returns>The response from the ListDeployments service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual ListDeploymentsResponse ListDeployments(ListDeploymentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListDeploymentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeployments operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual IAsyncResult BeginListDeployments(ListDeploymentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeploymentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeployments.</param>
        /// 
        /// <returns>Returns a  ListDeploymentsResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListDeployments">REST API Reference for ListDeployments Operation</seealso>
        public virtual ListDeploymentsResponse EndListDeployments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDeploymentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEffectiveDeployments

        /// <summary>
        /// Retrieves a paginated list of deployment jobs that AWS IoT Greengrass sends to AWS
        /// IoT Greengrass core devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEffectiveDeployments service method.</param>
        /// 
        /// <returns>The response from the ListEffectiveDeployments service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListEffectiveDeployments">REST API Reference for ListEffectiveDeployments Operation</seealso>
        public virtual ListEffectiveDeploymentsResponse ListEffectiveDeployments(ListEffectiveDeploymentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEffectiveDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEffectiveDeploymentsResponseUnmarshaller.Instance;

            return Invoke<ListEffectiveDeploymentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEffectiveDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEffectiveDeployments operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEffectiveDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListEffectiveDeployments">REST API Reference for ListEffectiveDeployments Operation</seealso>
        public virtual IAsyncResult BeginListEffectiveDeployments(ListEffectiveDeploymentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEffectiveDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEffectiveDeploymentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEffectiveDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEffectiveDeployments.</param>
        /// 
        /// <returns>Returns a  ListEffectiveDeploymentsResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListEffectiveDeployments">REST API Reference for ListEffectiveDeployments Operation</seealso>
        public virtual ListEffectiveDeploymentsResponse EndListEffectiveDeployments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEffectiveDeploymentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListInstalledComponents

        /// <summary>
        /// Retrieves a paginated list of the components that a AWS IoT Greengrass core device
        /// runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstalledComponents service method.</param>
        /// 
        /// <returns>The response from the ListInstalledComponents service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListInstalledComponents">REST API Reference for ListInstalledComponents Operation</seealso>
        public virtual ListInstalledComponentsResponse ListInstalledComponents(ListInstalledComponentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstalledComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstalledComponentsResponseUnmarshaller.Instance;

            return Invoke<ListInstalledComponentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstalledComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstalledComponents operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstalledComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListInstalledComponents">REST API Reference for ListInstalledComponents Operation</seealso>
        public virtual IAsyncResult BeginListInstalledComponents(ListInstalledComponentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstalledComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstalledComponentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstalledComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstalledComponents.</param>
        /// 
        /// <returns>Returns a  ListInstalledComponentsResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListInstalledComponents">REST API Reference for ListInstalledComponents Operation</seealso>
        public virtual ListInstalledComponentsResponse EndListInstalledComponents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstalledComponentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves the list of tags for an AWS IoT Greengrass resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ResolveComponentCandidates

        /// <summary>
        /// Retrieves a list of components that meet the component, version, and platform requirements
        /// of a deployment. AWS IoT Greengrass core devices call this operation when they receive
        /// a deployment to identify the components to install.
        /// 
        ///  
        /// <para>
        /// This operation identifies components that meet all dependency requirements for a deployment.
        /// If the requirements conflict, then this operation returns an error and the deployment
        /// fails. For example, this occurs if component <code>A</code> requires version <code>&gt;2.0.0</code>
        /// and component <code>B</code> requires version <code>&lt;2.0.0</code> of a component
        /// dependency.
        /// </para>
        ///  
        /// <para>
        /// When you specify the component candidates to resolve, AWS IoT Greengrass compares
        /// each component's digest from the core device with the component's digest in the AWS
        /// Cloud. If the digests don't match, then AWS IoT Greengrass specifies to use the version
        /// from the AWS Cloud.
        /// </para>
        ///  <important> 
        /// <para>
        /// To use this operation, you must use the data plane API endpoint and authenticate with
        /// an AWS IoT device certificate. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/greengrass.html">AWS
        /// IoT Greengrass endpoints and quotas</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveComponentCandidates service method.</param>
        /// 
        /// <returns>The response from the ResolveComponentCandidates service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. For example, you might have exceeded the
        /// amount of times that you can retrieve device or deployment status per second.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ResolveComponentCandidates">REST API Reference for ResolveComponentCandidates Operation</seealso>
        public virtual ResolveComponentCandidatesResponse ResolveComponentCandidates(ResolveComponentCandidatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveComponentCandidatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveComponentCandidatesResponseUnmarshaller.Instance;

            return Invoke<ResolveComponentCandidatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResolveComponentCandidates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveComponentCandidates operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResolveComponentCandidates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ResolveComponentCandidates">REST API Reference for ResolveComponentCandidates Operation</seealso>
        public virtual IAsyncResult BeginResolveComponentCandidates(ResolveComponentCandidatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveComponentCandidatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveComponentCandidatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResolveComponentCandidates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResolveComponentCandidates.</param>
        /// 
        /// <returns>Returns a  ResolveComponentCandidatesResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/ResolveComponentCandidates">REST API Reference for ResolveComponentCandidates Operation</seealso>
        public virtual ResolveComponentCandidatesResponse EndResolveComponentCandidates(IAsyncResult asyncResult)
        {
            return EndInvoke<ResolveComponentCandidatesResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds tags to an AWS IoT Greengrass resource. If a tag already exists for the resource,
        /// this operation updates the tag's value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag from an AWS IoT Greengrass resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GreengrassV2.</returns>
        /// <exception cref="Amazon.GreengrassV2.Model.InternalServerException">
        /// AWS IoT Greengrass can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.GreengrassV2.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonGreengrassV2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from GreengrassV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/greengrassv2-2020-11-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
    }
}