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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// This is the response object from the EvaluateCode operation.
    /// </summary>
    public partial class EvaluateCodeResponse : AmazonWebServiceResponse
    {
        private EvaluateCodeErrorDetail _error;
        private string _evaluationResult;
        private List<string> _logs = new List<string>();

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Contains the payload of the response error.
        /// </para>
        /// </summary>
        public EvaluateCodeErrorDetail Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationResult. 
        /// <para>
        /// The result of the evaluation operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public string EvaluationResult
        {
            get { return this._evaluationResult; }
            set { this._evaluationResult = value; }
        }

        // Check to see if EvaluationResult property is set
        internal bool IsSetEvaluationResult()
        {
            return this._evaluationResult != null;
        }

        /// <summary>
        /// Gets and sets the property Logs. 
        /// <para>
        /// A list of logs that were generated by calls to <c>util.log.info</c> and <c>util.log.error</c>
        /// in the evaluated code.
        /// </para>
        /// </summary>
        public List<string> Logs
        {
            get { return this._logs; }
            set { this._logs = value; }
        }

        // Check to see if Logs property is set
        internal bool IsSetLogs()
        {
            return this._logs != null && this._logs.Count > 0; 
        }

    }
}