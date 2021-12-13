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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Container for the parameters to the RotateSecret operation.
    /// Configures and starts the asynchronous process of rotating the secret.
    /// 
    ///  
    /// <para>
    /// If you include the configuration parameters, the operation sets the values for the
    /// secret and then immediately starts a rotation. If you don't include the configuration
    /// parameters, the operation starts a rotation with the values already stored in the
    /// secret. For more information about rotation, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotating-secrets.html">Rotate
    /// secrets</a>.
    /// </para>
    ///  
    /// <para>
    /// To configure rotation, you include the ARN of an Amazon Web Services Lambda function
    /// and the schedule for the rotation. The Lambda rotation function creates a new version
    /// of the secret and creates or updates the credentials on the database or service to
    /// match. After testing the new credentials, the function marks the new secret version
    /// with the staging label <code>AWSCURRENT</code>. Then anyone who retrieves the secret
    /// gets the new version. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotate-secrets_how.html">How
    /// rotation works</a>.
    /// </para>
    ///  
    /// <para>
    /// When rotation is successful, the <code>AWSPENDING</code> staging label might be attached
    /// to the same version as the <code>AWSCURRENT</code> version, or it might not be attached
    /// to any version.
    /// </para>
    ///  
    /// <para>
    /// If the <code>AWSPENDING</code> staging label is present but not attached to the same
    /// version as <code>AWSCURRENT</code>, then any later invocation of <code>RotateSecret</code>
    /// assumes that a previous rotation request is still in progress and returns an error.
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have <code>secretsmanager:RotateSecret</code> permissions
    /// and <code>lambda:InvokeFunction</code> permissions on the function specified in the
    /// secret's metadata.
    /// </para>
    /// </summary>
    public partial class RotateSecretRequest : AmazonSecretsManagerRequest
    {
        private string _clientRequestToken;
        private string _rotationLambdaARN;
        private RotationRulesType _rotationRules;
        private string _secretId;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for the new version of the secret that helps ensure idempotency.
        /// Secrets Manager uses this value to prevent the accidental creation of duplicate versions
        /// if there are failures and retries during rotation. This value becomes the <code>VersionId</code>
        /// of the new version.
        /// </para>
        ///  
        /// <para>
        /// If you use the Amazon Web Services CLI or one of the Amazon Web Services SDK to call
        /// this operation, then you can leave this parameter empty. The CLI or SDK generates
        /// a random UUID for you and includes that in the request for this parameter. If you
        /// don't use the SDK and instead generate a raw HTTP request to the Secrets Manager service
        /// endpoint, then you must generate a <code>ClientRequestToken</code> yourself for new
        /// versions and include that value in the request.
        /// </para>
        ///  
        /// <para>
        /// You only need to specify this value if you implement your own retry logic and you
        /// want to ensure that Secrets Manager doesn't attempt to create a secret version twice.
        /// We recommend that you generate a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID-type</a>
        /// value to ensure uniqueness within the specified secret. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property RotationLambdaARN. 
        /// <para>
        /// The ARN of the Lambda rotation function that can rotate the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string RotationLambdaARN
        {
            get { return this._rotationLambdaARN; }
            set { this._rotationLambdaARN = value; }
        }

        // Check to see if RotationLambdaARN property is set
        internal bool IsSetRotationLambdaARN()
        {
            return this._rotationLambdaARN != null;
        }

        /// <summary>
        /// Gets and sets the property RotationRules. 
        /// <para>
        /// A structure that defines the rotation configuration for this secret.
        /// </para>
        /// </summary>
        public RotationRulesType RotationRules
        {
            get { return this._rotationRules; }
            set { this._rotationRules = value; }
        }

        // Check to see if RotationRules property is set
        internal bool IsSetRotationRules()
        {
            return this._rotationRules != null;
        }

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ARN or name of the secret to rotate.
        /// </para>
        ///  
        /// <para>
        /// For an ARN, we recommend that you specify a complete ARN rather than a partial ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string SecretId
        {
            get { return this._secretId; }
            set { this._secretId = value; }
        }

        // Check to see if SecretId property is set
        internal bool IsSetSecretId()
        {
            return this._secretId != null;
        }

    }
}