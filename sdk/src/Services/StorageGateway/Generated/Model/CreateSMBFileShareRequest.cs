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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSMBFileShare operation.
    /// Creates a Server Message Block (SMB) file share on an existing S3 File Gateway. In
    /// Storage Gateway, a file share is a file system mount point backed by Amazon S3 cloud
    /// storage. Storage Gateway exposes file shares using an SMB interface. This operation
    /// is only supported for S3 File Gateways.
    /// 
    ///  <important> 
    /// <para>
    /// S3 File Gateways require Security Token Service (Amazon Web Services STS) to be activated
    /// to enable you to create a file share. Make sure that Amazon Web Services STS is activated
    /// in the Amazon Web Services Region you are creating your S3 File Gateway in. If Amazon
    /// Web Services STS is not activated in this Amazon Web Services Region, activate it.
    /// For information about how to activate Amazon Web Services STS, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
    /// and deactivating Amazon Web Services STS in an Amazon Web Services Region</a> in the
    /// <i>Identity and Access Management User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// File gateways don't support creating hard or symbolic links on a file share.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateSMBFileShareRequest : AmazonStorageGatewayRequest
    {
        private bool? _accessBasedEnumeration;
        private List<string> _adminUserList = new List<string>();
        private string _auditDestinationARN;
        private string _authentication;
        private string _bucketRegion;
        private CacheAttributes _cacheAttributes;
        private CaseSensitivity _caseSensitivity;
        private string _clientToken;
        private string _defaultStorageClass;
        private string _fileShareName;
        private string _gatewayARN;
        private bool? _guessMIMETypeEnabled;
        private List<string> _invalidUserList = new List<string>();
        private bool? _kmsEncrypted;
        private string _kmsKey;
        private string _locationARN;
        private string _notificationPolicy;
        private ObjectACL _objectACL;
        private bool? _oplocksEnabled;
        private bool? _readOnly;
        private bool? _requesterPays;
        private string _role;
        private bool? _smbaclEnabled;
        private List<Tag> _tags = new List<Tag>();
        private List<string> _validUserList = new List<string>();
        private string _vpcEndpointDNSName;

        /// <summary>
        /// Gets and sets the property AccessBasedEnumeration. 
        /// <para>
        /// The files and folders on this share will only be visible to users with read access.
        /// </para>
        /// </summary>
        public bool AccessBasedEnumeration
        {
            get { return this._accessBasedEnumeration.GetValueOrDefault(); }
            set { this._accessBasedEnumeration = value; }
        }

        // Check to see if AccessBasedEnumeration property is set
        internal bool IsSetAccessBasedEnumeration()
        {
            return this._accessBasedEnumeration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AdminUserList. 
        /// <para>
        /// A list of users or groups in the Active Directory that will be granted administrator
        /// privileges on the file share. These users can do all file operations as the super-user.
        /// Acceptable formats include: <code>DOMAIN\User1</code>, <code>user1</code>, <code>@group1</code>,
        /// and <code>@DOMAIN\group1</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Use this option very carefully, because any user in this list can do anything they
        /// like on the file share, regardless of file permissions.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> AdminUserList
        {
            get { return this._adminUserList; }
            set { this._adminUserList = value; }
        }

        // Check to see if AdminUserList property is set
        internal bool IsSetAdminUserList()
        {
            return this._adminUserList != null && this._adminUserList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AuditDestinationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the storage used for audit logs.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string AuditDestinationARN
        {
            get { return this._auditDestinationARN; }
            set { this._auditDestinationARN = value; }
        }

        // Check to see if AuditDestinationARN property is set
        internal bool IsSetAuditDestinationARN()
        {
            return this._auditDestinationARN != null;
        }

        /// <summary>
        /// Gets and sets the property Authentication. 
        /// <para>
        /// The authentication method that users use to access the file share. The default is
        /// <code>ActiveDirectory</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>ActiveDirectory</code> | <code>GuestAccess</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=15)]
        public string Authentication
        {
            get { return this._authentication; }
            set { this._authentication = value; }
        }

        // Check to see if Authentication property is set
        internal bool IsSetAuthentication()
        {
            return this._authentication != null;
        }

        /// <summary>
        /// Gets and sets the property BucketRegion. 
        /// <para>
        /// Specifies the Region of the S3 bucket where the SMB file share stores files.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is required for SMB file shares that connect to Amazon S3 through a
        /// VPC endpoint, a VPC access point, or an access point alias that points to a VPC access
        /// point.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public string BucketRegion
        {
            get { return this._bucketRegion; }
            set { this._bucketRegion = value; }
        }

        // Check to see if BucketRegion property is set
        internal bool IsSetBucketRegion()
        {
            return this._bucketRegion != null;
        }

        /// <summary>
        /// Gets and sets the property CacheAttributes. 
        /// <para>
        /// Specifies refresh cache information for the file share.
        /// </para>
        /// </summary>
        public CacheAttributes CacheAttributes
        {
            get { return this._cacheAttributes; }
            set { this._cacheAttributes = value; }
        }

        // Check to see if CacheAttributes property is set
        internal bool IsSetCacheAttributes()
        {
            return this._cacheAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property CaseSensitivity. 
        /// <para>
        /// The case of an object name in an Amazon S3 bucket. For <code>ClientSpecified</code>,
        /// the client determines the case sensitivity. For <code>CaseSensitive</code>, the gateway
        /// determines the case sensitivity. The default value is <code>ClientSpecified</code>.
        /// </para>
        /// </summary>
        public CaseSensitivity CaseSensitivity
        {
            get { return this._caseSensitivity; }
            set { this._caseSensitivity = value; }
        }

        // Check to see if CaseSensitivity property is set
        internal bool IsSetCaseSensitivity()
        {
            return this._caseSensitivity != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique string value that you supply that is used by S3 File Gateway to ensure idempotent
        /// file share creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=100)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultStorageClass. 
        /// <para>
        /// The default storage class for objects put into an Amazon S3 bucket by the S3 File
        /// Gateway. The default value is <code>S3_STANDARD</code>. Optional.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>S3_STANDARD</code> | <code>S3_INTELLIGENT_TIERING</code> | <code>S3_STANDARD_IA</code>
        /// | <code>S3_ONEZONE_IA</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=50)]
        public string DefaultStorageClass
        {
            get { return this._defaultStorageClass; }
            set { this._defaultStorageClass = value; }
        }

        // Check to see if DefaultStorageClass property is set
        internal bool IsSetDefaultStorageClass()
        {
            return this._defaultStorageClass != null;
        }

        /// <summary>
        /// Gets and sets the property FileShareName. 
        /// <para>
        /// The name of the file share. Optional.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>FileShareName</code> must be set if an S3 prefix name is set in <code>LocationARN</code>,
        /// or if an access point or access point alias is used.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string FileShareName
        {
            get { return this._fileShareName; }
            set { this._fileShareName = value; }
        }

        // Check to see if FileShareName property is set
        internal bool IsSetFileShareName()
        {
            return this._fileShareName != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayARN. 
        /// <para>
        /// The ARN of the S3 File Gateway on which you want to create a file share.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property GuessMIMETypeEnabled. 
        /// <para>
        /// A value that enables guessing of the MIME type for uploaded objects based on file
        /// extensions. Set this value to <code>true</code> to enable MIME type guessing, otherwise
        /// set to <code>false</code>. The default value is <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>true</code> | <code>false</code> 
        /// </para>
        /// </summary>
        public bool GuessMIMETypeEnabled
        {
            get { return this._guessMIMETypeEnabled.GetValueOrDefault(); }
            set { this._guessMIMETypeEnabled = value; }
        }

        // Check to see if GuessMIMETypeEnabled property is set
        internal bool IsSetGuessMIMETypeEnabled()
        {
            return this._guessMIMETypeEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InvalidUserList. 
        /// <para>
        /// A list of users or groups in the Active Directory that are not allowed to access the
        /// file share. A group must be prefixed with the @ character. Acceptable formats include:
        /// <code>DOMAIN\User1</code>, <code>user1</code>, <code>@group1</code>, and <code>@DOMAIN\group1</code>.
        /// Can only be set if Authentication is set to <code>ActiveDirectory</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> InvalidUserList
        {
            get { return this._invalidUserList; }
            set { this._invalidUserList = value; }
        }

        // Check to see if InvalidUserList property is set
        internal bool IsSetInvalidUserList()
        {
            return this._invalidUserList != null && this._invalidUserList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KMSEncrypted. 
        /// <para>
        /// Set to <code>true</code> to use Amazon S3 server-side encryption with your own KMS
        /// key, or <code>false</code> to use a key managed by Amazon S3. Optional.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>true</code> | <code>false</code> 
        /// </para>
        /// </summary>
        public bool KMSEncrypted
        {
            get { return this._kmsEncrypted.GetValueOrDefault(); }
            set { this._kmsEncrypted = value; }
        }

        // Check to see if KMSEncrypted property is set
        internal bool IsSetKMSEncrypted()
        {
            return this._kmsEncrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KMSKey. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a symmetric customer master key (CMK) used for Amazon
        /// S3 server-side encryption. Storage Gateway does not support asymmetric CMKs. This
        /// value can only be set when <code>KMSEncrypted</code> is <code>true</code>. Optional.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=2048)]
        public string KMSKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KMSKey property is set
        internal bool IsSetKMSKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property LocationARN. 
        /// <para>
        /// A custom ARN for the backend storage used for storing data for file shares. It includes
        /// a resource ARN with an optional prefix concatenation. The prefix must end with a forward
        /// slash (/).
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify LocationARN as a bucket ARN, access point ARN or access point alias,
        /// as shown in the following examples.
        /// </para>
        ///  
        /// <para>
        /// Bucket ARN:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:s3:::my-bucket/prefix/</code> 
        /// </para>
        ///  
        /// <para>
        /// Access point ARN:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:s3:region:account-id:accesspoint/access-point-name/prefix/</code> 
        /// </para>
        ///  
        /// <para>
        /// If you specify an access point, the bucket policy must be configured to delegate access
        /// control to the access point. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-policies.html#access-points-delegating-control">Delegating
        /// access control to access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Access point alias:
        /// </para>
        ///  
        /// <para>
        ///  <code>test-ap-ab123cdef4gehijklmn5opqrstuvuse1a-s3alias</code> 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=16, Max=1400)]
        public string LocationARN
        {
            get { return this._locationARN; }
            set { this._locationARN = value; }
        }

        // Check to see if LocationARN property is set
        internal bool IsSetLocationARN()
        {
            return this._locationARN != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationPolicy. 
        /// <para>
        /// The notification policy of the file share. <code>SettlingTimeInSeconds</code> controls
        /// the number of seconds to wait after the last point in time a client wrote to a file
        /// before generating an <code>ObjectUploaded</code> notification. Because clients can
        /// make many small writes to files, it's best to set this parameter for as long as possible
        /// to avoid generating multiple notifications for the same file in a small time period.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>SettlingTimeInSeconds</code> has no effect on the timing of the object uploading
        /// to Amazon S3, only the timing of the notification.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following example sets <code>NotificationPolicy</code> on with <code>SettlingTimeInSeconds</code>
        /// set to 60.
        /// </para>
        ///  
        /// <para>
        ///  <code>{\"Upload\": {\"SettlingTimeInSeconds\": 60}}</code> 
        /// </para>
        ///  
        /// <para>
        /// The following example sets <code>NotificationPolicy</code> off.
        /// </para>
        ///  
        /// <para>
        ///  <code>{}</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string NotificationPolicy
        {
            get { return this._notificationPolicy; }
            set { this._notificationPolicy = value; }
        }

        // Check to see if NotificationPolicy property is set
        internal bool IsSetNotificationPolicy()
        {
            return this._notificationPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectACL. 
        /// <para>
        /// A value that sets the access control list (ACL) permission for objects in the S3 bucket
        /// that a S3 File Gateway puts objects into. The default value is <code>private</code>.
        /// </para>
        /// </summary>
        public ObjectACL ObjectACL
        {
            get { return this._objectACL; }
            set { this._objectACL = value; }
        }

        // Check to see if ObjectACL property is set
        internal bool IsSetObjectACL()
        {
            return this._objectACL != null;
        }

        /// <summary>
        /// Gets and sets the property OplocksEnabled. 
        /// <para>
        /// Specifies whether opportunistic locking is enabled for the SMB file share.
        /// </para>
        ///  <note> 
        /// <para>
        /// Enabling opportunistic locking on case-sensitive shares is not recommended for workloads
        /// that involve access to files with the same name in different case.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid Values: <code>true</code> | <code>false</code> 
        /// </para>
        /// </summary>
        public bool OplocksEnabled
        {
            get { return this._oplocksEnabled.GetValueOrDefault(); }
            set { this._oplocksEnabled = value; }
        }

        // Check to see if OplocksEnabled property is set
        internal bool IsSetOplocksEnabled()
        {
            return this._oplocksEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// A value that sets the write status of a file share. Set this value to <code>true</code>
        /// to set the write status to read-only, otherwise set to <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>true</code> | <code>false</code> 
        /// </para>
        /// </summary>
        public bool ReadOnly
        {
            get { return this._readOnly.GetValueOrDefault(); }
            set { this._readOnly = value; }
        }

        // Check to see if ReadOnly property is set
        internal bool IsSetReadOnly()
        {
            return this._readOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequesterPays. 
        /// <para>
        /// A value that sets who pays the cost of the request and the cost associated with data
        /// download from the S3 bucket. If this value is set to <code>true</code>, the requester
        /// pays the costs; otherwise, the S3 bucket owner pays. However, the S3 bucket owner
        /// always pays the cost of storing data.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>RequesterPays</code> is a configuration for the S3 bucket that backs the file
        /// share, so make sure that the configuration on the file share is the same as the S3
        /// bucket configuration.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid Values: <code>true</code> | <code>false</code> 
        /// </para>
        /// </summary>
        public bool RequesterPays
        {
            get { return this._requesterPays.GetValueOrDefault(); }
            set { this._requesterPays = value; }
        }

        // Check to see if RequesterPays property is set
        internal bool IsSetRequesterPays()
        {
            return this._requesterPays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The ARN of the Identity and Access Management (IAM) role that an S3 File Gateway assumes
        /// when it accesses the underlying storage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property SMBACLEnabled. 
        /// <para>
        /// Set this value to <code>true</code> to enable access control list (ACL) on the SMB
        /// file share. Set it to <code>false</code> to map file and directory permissions to
        /// the POSIX permissions.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/storagegateway/latest/userguide/smb-acl.html">Using
        /// Microsoft Windows ACLs to control access to an SMB file share</a> in the <i>Storage
        /// Gateway User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>true</code> | <code>false</code> 
        /// </para>
        /// </summary>
        public bool SMBACLEnabled
        {
            get { return this._smbaclEnabled.GetValueOrDefault(); }
            set { this._smbaclEnabled = value; }
        }

        // Check to see if SMBACLEnabled property is set
        internal bool IsSetSMBACLEnabled()
        {
            return this._smbaclEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of up to 50 tags that can be assigned to the NFS file share. Each tag is a
        /// key-value pair.
        /// </para>
        ///  <note> 
        /// <para>
        /// Valid characters for key and value are letters, spaces, and numbers representable
        /// in UTF-8 format, and the following special characters: + - = . _ : / @. The maximum
        /// length of a tag's key is 128 characters, and the maximum length for a tag's value
        /// is 256.
        /// </para>
        ///  </note>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ValidUserList. 
        /// <para>
        /// A list of users or groups in the Active Directory that are allowed to access the file
        /// <a href=""/> share. A group must be prefixed with the @ character. Acceptable formats
        /// include: <code>DOMAIN\User1</code>, <code>user1</code>, <code>@group1</code>, and
        /// <code>@DOMAIN\group1</code>. Can only be set if Authentication is set to <code>ActiveDirectory</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ValidUserList
        {
            get { return this._validUserList; }
            set { this._validUserList = value; }
        }

        // Check to see if ValidUserList property is set
        internal bool IsSetValidUserList()
        {
            return this._validUserList != null && this._validUserList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VPCEndpointDNSName. 
        /// <para>
        /// Specifies the DNS name for the VPC endpoint that the SMB file share uses to connect
        /// to Amazon S3.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is required for SMB file shares that connect to Amazon S3 through a
        /// VPC endpoint, a VPC access point, or an access point alias that points to a VPC access
        /// point.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string VPCEndpointDNSName
        {
            get { return this._vpcEndpointDNSName; }
            set { this._vpcEndpointDNSName = value; }
        }

        // Check to see if VPCEndpointDNSName property is set
        internal bool IsSetVPCEndpointDNSName()
        {
            return this._vpcEndpointDNSName != null;
        }

    }
}