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
 * Do not modify this file. This file is generated from the pricing-2017-10-15.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Pricing.Model;
using Amazon.Pricing.Model.Internal.MarshallTransformations;
using Amazon.Pricing.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Pricing
{
    /// <summary>
    /// <para>Implementation for accessing Pricing</para>
    ///
    /// The Amazon Web Services Price List API is a centralized and convenient way to programmatically
    /// query Amazon Web Services for services, products, and pricing information. The Amazon
    /// Web Services Price List uses standardized product attributes such as <c>Location</c>,
    /// <c>Storage Class</c>, and <c>Operating System</c>, and provides prices at the SKU
    /// level. You can use the Amazon Web Services Price List to do the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Build cost control and scenario planning tools
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Reconcile billing data
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Forecast future spend for budgeting purposes
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provide cost benefit analysis that compare your internal workloads with Amazon Web
    /// Services
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Use <c>GetServices</c> without a service code to retrieve the service codes for all
    /// Amazon Web Services, then <c>GetServices</c> with a service code to retrieve the attribute
    /// names for that service. After you have the service code and attribute names, you can
    /// use <c>GetAttributeValues</c> to see what values are available for an attribute. With
    /// the service code and an attribute name and value, you can use <c>GetProducts</c> to
    /// find specific products that you're interested in, such as an <c>AmazonEC2</c> instance,
    /// with a <c>Provisioned IOPS</c> <c>volumeType</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/price-changes.html">Using
    /// the Amazon Web Services Price List API</a> in the <i>Billing User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonPricingClient : AmazonServiceClient, IAmazonPricing
    {
        private static IServiceMetadata serviceMetadata = new AmazonPricingMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IPricingPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPricingPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PricingPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonPricingClient with the credentials loaded from the application's
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
        public AmazonPricingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPricingConfig()) { }

        /// <summary>
        /// Constructs AmazonPricingClient with the credentials loaded from the application's
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
        public AmazonPricingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPricingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPricingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPricingClient Configuration Object</param>
        public AmazonPricingClient(AmazonPricingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonPricingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPricingClient(AWSCredentials credentials)
            : this(credentials, new AmazonPricingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPricingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPricingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Credentials and an
        /// AmazonPricingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPricingClient Configuration Object</param>
        public AmazonPricingClient(AWSCredentials credentials, AmazonPricingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPricingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPricingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPricingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPricingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPricingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPricingClient Configuration Object</param>
        public AmazonPricingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPricingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPricingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPricingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPricingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPricingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPricingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPricingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPricingClient Configuration Object</param>
        public AmazonPricingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPricingConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPricingEndpointResolver());
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


        #region  DescribeServices

        /// <summary>
        /// Returns the metadata for one service or a list of the metadata for all services. Use
        /// this without a service code to get the service codes for all services. Use it with
        /// a service code, such as <c>AmazonEC2</c>, to get information specific to that service,
        /// such as the attribute names available for that service. For example, some of the attribute
        /// names available for EC2 are <c>volumeType</c>, <c>maxIopsVolume</c>, <c>operation</c>,
        /// <c>locationType</c>, and <c>instanceCapacity10xlarge</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices service method.</param>
        /// 
        /// <returns>The response from the DescribeServices service method, as returned by Pricing.</returns>
        /// <exception cref="Amazon.Pricing.Model.ExpiredNextTokenException">
        /// The pagination token expired. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.NotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.ThrottlingException">
        /// You've made too many requests exceeding service quotas.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        public virtual DescribeServicesResponse DescribeServices(DescribeServicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServicesResponseUnmarshaller.Instance;

            return Invoke<DescribeServicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServices operation on AmazonPricingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        public virtual IAsyncResult BeginDescribeServices(DescribeServicesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServices.</param>
        /// 
        /// <returns>Returns a  DescribeServicesResult from Pricing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/DescribeServices">REST API Reference for DescribeServices Operation</seealso>
        public virtual DescribeServicesResponse EndDescribeServices(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeServicesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAttributeValues

        /// <summary>
        /// Returns a list of attribute values. Attributes are similar to the details in a Price
        /// List API offer file. For a list of available attributes, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/reading-an-offer.html#pps-defs">Offer
        /// File Definitions</a> in the <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/billing-what-is.html">Billing
        /// and Cost Management User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAttributeValues service method.</param>
        /// 
        /// <returns>The response from the GetAttributeValues service method, as returned by Pricing.</returns>
        /// <exception cref="Amazon.Pricing.Model.ExpiredNextTokenException">
        /// The pagination token expired. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.NotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.ThrottlingException">
        /// You've made too many requests exceeding service quotas.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetAttributeValues">REST API Reference for GetAttributeValues Operation</seealso>
        public virtual GetAttributeValuesResponse GetAttributeValues(GetAttributeValuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAttributeValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAttributeValuesResponseUnmarshaller.Instance;

            return Invoke<GetAttributeValuesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAttributeValues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAttributeValues operation on AmazonPricingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAttributeValues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetAttributeValues">REST API Reference for GetAttributeValues Operation</seealso>
        public virtual IAsyncResult BeginGetAttributeValues(GetAttributeValuesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAttributeValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAttributeValuesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAttributeValues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAttributeValues.</param>
        /// 
        /// <returns>Returns a  GetAttributeValuesResult from Pricing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetAttributeValues">REST API Reference for GetAttributeValues Operation</seealso>
        public virtual GetAttributeValuesResponse EndGetAttributeValues(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAttributeValuesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPriceListFileUrl

        /// <summary>
        /// <i> <b>This feature is in preview release and is subject to change. Your use of Amazon
        /// Web Services Price List API is subject to the Beta Service Participation terms of
        /// the <a href="https://aws.amazon.com/service-terms/">Amazon Web Services Service Terms</a>
        /// (Section 1.10).</b> </i> 
        /// 
        ///  
        /// <para>
        /// This returns the URL that you can retrieve your Price List file from. This URL is
        /// based on the <c>PriceListArn</c> and <c>FileFormat</c> that you retrieve from the
        /// <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_pricing_ListPriceLists.html">ListPriceLists</a>
        /// response. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPriceListFileUrl service method.</param>
        /// 
        /// <returns>The response from the GetPriceListFileUrl service method, as returned by Pricing.</returns>
        /// <exception cref="Amazon.Pricing.Model.AccessDeniedException">
        /// General authentication failure. The request wasn't signed correctly.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.NotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.ThrottlingException">
        /// You've made too many requests exceeding service quotas.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetPriceListFileUrl">REST API Reference for GetPriceListFileUrl Operation</seealso>
        public virtual GetPriceListFileUrlResponse GetPriceListFileUrl(GetPriceListFileUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPriceListFileUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPriceListFileUrlResponseUnmarshaller.Instance;

            return Invoke<GetPriceListFileUrlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPriceListFileUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPriceListFileUrl operation on AmazonPricingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPriceListFileUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetPriceListFileUrl">REST API Reference for GetPriceListFileUrl Operation</seealso>
        public virtual IAsyncResult BeginGetPriceListFileUrl(GetPriceListFileUrlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPriceListFileUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPriceListFileUrlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPriceListFileUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPriceListFileUrl.</param>
        /// 
        /// <returns>Returns a  GetPriceListFileUrlResult from Pricing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetPriceListFileUrl">REST API Reference for GetPriceListFileUrl Operation</seealso>
        public virtual GetPriceListFileUrlResponse EndGetPriceListFileUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPriceListFileUrlResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProducts

        /// <summary>
        /// Returns a list of all products that match the filter criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProducts service method.</param>
        /// 
        /// <returns>The response from the GetProducts service method, as returned by Pricing.</returns>
        /// <exception cref="Amazon.Pricing.Model.ExpiredNextTokenException">
        /// The pagination token expired. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.NotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.ThrottlingException">
        /// You've made too many requests exceeding service quotas.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetProducts">REST API Reference for GetProducts Operation</seealso>
        public virtual GetProductsResponse GetProducts(GetProductsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductsResponseUnmarshaller.Instance;

            return Invoke<GetProductsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProducts operation on AmazonPricingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProducts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetProducts">REST API Reference for GetProducts Operation</seealso>
        public virtual IAsyncResult BeginGetProducts(GetProductsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProducts.</param>
        /// 
        /// <returns>Returns a  GetProductsResult from Pricing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/GetProducts">REST API Reference for GetProducts Operation</seealso>
        public virtual GetProductsResponse EndGetProducts(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProductsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPriceLists

        /// <summary>
        /// <i> <b>This feature is in preview release and is subject to change. Your use of Amazon
        /// Web Services Price List API is subject to the Beta Service Participation terms of
        /// the <a href="https://aws.amazon.com/service-terms/">Amazon Web Services Service Terms</a>
        /// (Section 1.10).</b> </i> 
        /// 
        ///  
        /// <para>
        /// This returns a list of Price List references that the requester if authorized to view,
        /// given a <c>ServiceCode</c>, <c>CurrencyCode</c>, and an <c>EffectiveDate</c>. Use
        /// without a <c>RegionCode</c> filter to list Price List references from all available
        /// Amazon Web Services Regions. Use with a <c>RegionCode</c> filter to get the Price
        /// List reference that's specific to a specific Amazon Web Services Region. You can use
        /// the <c>PriceListArn</c> from the response to get your preferred Price List files through
        /// the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_pricing_GetPriceListFileUrl.html">GetPriceListFileUrl</a>
        /// API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPriceLists service method.</param>
        /// 
        /// <returns>The response from the ListPriceLists service method, as returned by Pricing.</returns>
        /// <exception cref="Amazon.Pricing.Model.AccessDeniedException">
        /// General authentication failure. The request wasn't signed correctly.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.ExpiredNextTokenException">
        /// The pagination token expired. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InternalErrorException">
        /// An error on the server occurred during the processing of your request. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.InvalidParameterException">
        /// One or more parameters had an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.NotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Pricing.Model.ThrottlingException">
        /// You've made too many requests exceeding service quotas.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/ListPriceLists">REST API Reference for ListPriceLists Operation</seealso>
        public virtual ListPriceListsResponse ListPriceLists(ListPriceListsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPriceListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPriceListsResponseUnmarshaller.Instance;

            return Invoke<ListPriceListsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPriceLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPriceLists operation on AmazonPricingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPriceLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/ListPriceLists">REST API Reference for ListPriceLists Operation</seealso>
        public virtual IAsyncResult BeginListPriceLists(ListPriceListsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPriceListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPriceListsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPriceLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPriceLists.</param>
        /// 
        /// <returns>Returns a  ListPriceListsResult from Pricing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pricing-2017-10-15/ListPriceLists">REST API Reference for ListPriceLists Operation</seealso>
        public virtual ListPriceListsResponse EndListPriceLists(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPriceListsResponse>(asyncResult);
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
            var resolver = new AmazonPricingEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}