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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A collection of settings that apply to users in a domain. These settings are specified
    /// when the <c>CreateUserProfile</c> API is called, and as <c>DefaultUserSettings</c>
    /// when the <c>CreateDomain</c> API is called.
    /// 
    ///  
    /// <para>
    ///  <c>SecurityGroups</c> is aggregated when specified in both calls. For all other settings
    /// in <c>UserSettings</c>, the values specified in <c>CreateUserProfile</c> take precedence
    /// over those specified in <c>CreateDomain</c>.
    /// </para>
    /// </summary>
    public partial class UserSettings
    {
        private CanvasAppSettings _canvasAppSettings;
        private CodeEditorAppSettings _codeEditorAppSettings;
        private List<CustomFileSystemConfig> _customFileSystemConfigs = new List<CustomFileSystemConfig>();
        private CustomPosixUserConfig _customPosixUserConfig;
        private string _defaultLandingUri;
        private string _executionRole;
        private JupyterLabAppSettings _jupyterLabAppSettings;
        private JupyterServerAppSettings _jupyterServerAppSettings;
        private KernelGatewayAppSettings _kernelGatewayAppSettings;
        private RSessionAppSettings _rSessionAppSettings;
        private RStudioServerProAppSettings _rStudioServerProAppSettings;
        private List<string> _securityGroups = new List<string>();
        private SharingSettings _sharingSettings;
        private DefaultSpaceStorageSettings _spaceStorageSettings;
        private StudioWebPortal _studioWebPortal;
        private TensorBoardAppSettings _tensorBoardAppSettings;

        /// <summary>
        /// Gets and sets the property CanvasAppSettings. 
        /// <para>
        /// The Canvas app settings.
        /// </para>
        /// </summary>
        public CanvasAppSettings CanvasAppSettings
        {
            get { return this._canvasAppSettings; }
            set { this._canvasAppSettings = value; }
        }

        // Check to see if CanvasAppSettings property is set
        internal bool IsSetCanvasAppSettings()
        {
            return this._canvasAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property CodeEditorAppSettings. 
        /// <para>
        /// The Code Editor application settings.
        /// </para>
        /// </summary>
        public CodeEditorAppSettings CodeEditorAppSettings
        {
            get { return this._codeEditorAppSettings; }
            set { this._codeEditorAppSettings = value; }
        }

        // Check to see if CodeEditorAppSettings property is set
        internal bool IsSetCodeEditorAppSettings()
        {
            return this._codeEditorAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property CustomFileSystemConfigs. 
        /// <para>
        /// The settings for assigning a custom file system to a user profile. Permitted users
        /// can access this file system in Amazon SageMaker Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2)]
        public List<CustomFileSystemConfig> CustomFileSystemConfigs
        {
            get { return this._customFileSystemConfigs; }
            set { this._customFileSystemConfigs = value; }
        }

        // Check to see if CustomFileSystemConfigs property is set
        internal bool IsSetCustomFileSystemConfigs()
        {
            return this._customFileSystemConfigs != null && this._customFileSystemConfigs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CustomPosixUserConfig. 
        /// <para>
        /// Details about the POSIX identity that is used for file system operations.
        /// </para>
        /// </summary>
        public CustomPosixUserConfig CustomPosixUserConfig
        {
            get { return this._customPosixUserConfig; }
            set { this._customPosixUserConfig = value; }
        }

        // Check to see if CustomPosixUserConfig property is set
        internal bool IsSetCustomPosixUserConfig()
        {
            return this._customPosixUserConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultLandingUri. 
        /// <para>
        /// The default experience that the user is directed to when accessing the domain. The
        /// supported values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>studio::</c>: Indicates that Studio is the default experience. This value can
        /// only be passed if <c>StudioWebPortal</c> is set to <c>ENABLED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>app:JupyterServer:</c>: Indicates that Studio Classic is the default experience.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=1023)]
        public string DefaultLandingUri
        {
            get { return this._defaultLandingUri; }
            set { this._defaultLandingUri = value; }
        }

        // Check to see if DefaultLandingUri property is set
        internal bool IsSetDefaultLandingUri()
        {
            return this._defaultLandingUri != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The execution role for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property JupyterLabAppSettings. 
        /// <para>
        /// The settings for the JupyterLab application.
        /// </para>
        /// </summary>
        public JupyterLabAppSettings JupyterLabAppSettings
        {
            get { return this._jupyterLabAppSettings; }
            set { this._jupyterLabAppSettings = value; }
        }

        // Check to see if JupyterLabAppSettings property is set
        internal bool IsSetJupyterLabAppSettings()
        {
            return this._jupyterLabAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property JupyterServerAppSettings. 
        /// <para>
        /// The Jupyter server's app settings.
        /// </para>
        /// </summary>
        public JupyterServerAppSettings JupyterServerAppSettings
        {
            get { return this._jupyterServerAppSettings; }
            set { this._jupyterServerAppSettings = value; }
        }

        // Check to see if JupyterServerAppSettings property is set
        internal bool IsSetJupyterServerAppSettings()
        {
            return this._jupyterServerAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property KernelGatewayAppSettings. 
        /// <para>
        /// The kernel gateway app settings.
        /// </para>
        /// </summary>
        public KernelGatewayAppSettings KernelGatewayAppSettings
        {
            get { return this._kernelGatewayAppSettings; }
            set { this._kernelGatewayAppSettings = value; }
        }

        // Check to see if KernelGatewayAppSettings property is set
        internal bool IsSetKernelGatewayAppSettings()
        {
            return this._kernelGatewayAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RSessionAppSettings. 
        /// <para>
        /// A collection of settings that configure the <c>RSessionGateway</c> app.
        /// </para>
        /// </summary>
        public RSessionAppSettings RSessionAppSettings
        {
            get { return this._rSessionAppSettings; }
            set { this._rSessionAppSettings = value; }
        }

        // Check to see if RSessionAppSettings property is set
        internal bool IsSetRSessionAppSettings()
        {
            return this._rSessionAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RStudioServerProAppSettings. 
        /// <para>
        /// A collection of settings that configure user interaction with the <c>RStudioServerPro</c>
        /// app.
        /// </para>
        /// </summary>
        public RStudioServerProAppSettings RStudioServerProAppSettings
        {
            get { return this._rStudioServerProAppSettings; }
            set { this._rStudioServerProAppSettings = value; }
        }

        // Check to see if RStudioServerProAppSettings property is set
        internal bool IsSetRStudioServerProAppSettings()
        {
            return this._rStudioServerProAppSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The security groups for the Amazon Virtual Private Cloud (VPC) that the domain uses
        /// for communication.
        /// </para>
        ///  
        /// <para>
        /// Optional when the <c>CreateDomain.AppNetworkAccessType</c> parameter is set to <c>PublicInternetOnly</c>.
        /// </para>
        ///  
        /// <para>
        /// Required when the <c>CreateDomain.AppNetworkAccessType</c> parameter is set to <c>VpcOnly</c>,
        /// unless specified as part of the <c>DefaultUserSettings</c> for the domain.
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker adds a security group to allow NFS traffic from Amazon SageMaker
        /// Studio. Therefore, the number of security groups that you can specify is one less
        /// than the maximum number shown.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SharingSettings. 
        /// <para>
        /// Specifies options for sharing Amazon SageMaker Studio notebooks.
        /// </para>
        /// </summary>
        public SharingSettings SharingSettings
        {
            get { return this._sharingSettings; }
            set { this._sharingSettings = value; }
        }

        // Check to see if SharingSettings property is set
        internal bool IsSetSharingSettings()
        {
            return this._sharingSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceStorageSettings. 
        /// <para>
        /// The storage settings for a private space.
        /// </para>
        /// </summary>
        public DefaultSpaceStorageSettings SpaceStorageSettings
        {
            get { return this._spaceStorageSettings; }
            set { this._spaceStorageSettings = value; }
        }

        // Check to see if SpaceStorageSettings property is set
        internal bool IsSetSpaceStorageSettings()
        {
            return this._spaceStorageSettings != null;
        }

        /// <summary>
        /// Gets and sets the property StudioWebPortal. 
        /// <para>
        /// Whether the user can access Studio. If this value is set to <c>DISABLED</c>, the user
        /// cannot access Studio, even if that is the default experience for the domain.
        /// </para>
        /// </summary>
        public StudioWebPortal StudioWebPortal
        {
            get { return this._studioWebPortal; }
            set { this._studioWebPortal = value; }
        }

        // Check to see if StudioWebPortal property is set
        internal bool IsSetStudioWebPortal()
        {
            return this._studioWebPortal != null;
        }

        /// <summary>
        /// Gets and sets the property TensorBoardAppSettings. 
        /// <para>
        /// The TensorBoard app settings.
        /// </para>
        /// </summary>
        public TensorBoardAppSettings TensorBoardAppSettings
        {
            get { return this._tensorBoardAppSettings; }
            set { this._tensorBoardAppSettings = value; }
        }

        // Check to see if TensorBoardAppSettings property is set
        internal bool IsSetTensorBoardAppSettings()
        {
            return this._tensorBoardAppSettings != null;
        }

    }
}