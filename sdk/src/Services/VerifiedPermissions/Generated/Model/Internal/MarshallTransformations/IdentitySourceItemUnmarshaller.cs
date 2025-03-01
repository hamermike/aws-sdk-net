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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.VerifiedPermissions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.VerifiedPermissions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for IdentitySourceItem Object
    /// </summary>  
    public class IdentitySourceItemUnmarshaller : IUnmarshaller<IdentitySourceItem, XmlUnmarshallerContext>, IUnmarshaller<IdentitySourceItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        IdentitySourceItem IUnmarshaller<IdentitySourceItem, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public IdentitySourceItem Unmarshall(JsonUnmarshallerContext context)
        {
            IdentitySourceItem unmarshalledObject = new IdentitySourceItem();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("createdDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("details", targetDepth))
                {
                    var unmarshaller = IdentitySourceItemDetailsUnmarshaller.Instance;
                    unmarshalledObject.Details = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("identitySourceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IdentitySourceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdatedDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("policyStoreId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PolicyStoreId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("principalEntityType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrincipalEntityType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static IdentitySourceItemUnmarshaller _instance = new IdentitySourceItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IdentitySourceItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}