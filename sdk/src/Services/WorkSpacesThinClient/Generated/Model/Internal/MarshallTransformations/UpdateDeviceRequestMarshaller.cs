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
 * Do not modify this file. This file is generated from the workspaces-thin-client-2023-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpacesThinClient.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkSpacesThinClient.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDevice Request Marshaller
    /// </summary>       
    public class UpdateDeviceRequestMarshaller : IMarshaller<IRequest, UpdateDeviceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDeviceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDeviceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkSpacesThinClient");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-08-22";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetId())
                throw new AmazonWorkSpacesThinClientException("Request object does not have required field Id set");
            request.AddPathResource("{id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/devices/{id}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDesiredSoftwareSetId())
                {
                    context.Writer.WritePropertyName("desiredSoftwareSetId");
                    context.Writer.Write(publicRequest.DesiredSoftwareSetId);
                }

                if(publicRequest.IsSetKmsKeyArn())
                {
                    context.Writer.WritePropertyName("kmsKeyArn");
                    context.Writer.Write(publicRequest.KmsKeyArn);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetSoftwareSetUpdateSchedule())
                {
                    context.Writer.WritePropertyName("softwareSetUpdateSchedule");
                    context.Writer.Write(publicRequest.SoftwareSetUpdateSchedule);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"api.";

            return request;
        }
        private static UpdateDeviceRequestMarshaller _instance = new UpdateDeviceRequestMarshaller();        

        internal static UpdateDeviceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDeviceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}