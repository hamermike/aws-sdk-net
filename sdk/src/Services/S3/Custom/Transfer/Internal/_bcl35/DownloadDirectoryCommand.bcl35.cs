﻿/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Amazon.S3;
using Amazon.S3.Model;

namespace Amazon.S3.Transfer.Internal
{
    internal partial class DownloadDirectoryCommand
    {
        public override void Execute()
        {
            ValidateRequest();
            EnsureDirectoryExists(new DirectoryInfo(this._request.LocalDirectory));

            List<S3Object> objs;
            string listRequestPrefix;
            try
            {
                ListObjectsRequest listRequest = ConstructListObjectRequest();
                listRequestPrefix = listRequest.Prefix;
                objs = GetS3ObjectsToDownload(listRequest);
            }
            catch (AmazonS3Exception ex)
            {
                if (ex.StatusCode != System.Net.HttpStatusCode.NotImplemented)
                    throw;

                ListObjectsV2Request listRequestV2 = ConstructListObjectRequestV2();
                listRequestPrefix = listRequestV2.Prefix;
                objs = GetS3ObjectsToDownloadV2(listRequestV2);
            }

            this._totalNumberOfFilesToDownload = objs.Count;

            foreach (S3Object s3o in objs)
            {
                if (s3o.Key.EndsWith("/", StringComparison.Ordinal))
                    continue;

                int prefixLength = listRequestPrefix.Length;
                // If DisableSlashCorrection is enabled (i.e. S3Directory is a key prefix) and it doesn't end with '/' then we need the parent directory to properly construct download path.
                if (this._request.DisableSlashCorrection && !listRequestPrefix.EndsWith("/"))
                {
                    prefixLength = listRequestPrefix.LastIndexOf("/") + 1;
                }

                this._currentFile = s3o.Key.Substring(prefixLength);

                var downloadRequest = ConstructTransferUtilityDownloadRequest(s3o, prefixLength);
                DownloadCommand command = new DownloadCommand(this._s3Client, downloadRequest);
                command.Execute();
            }
        }

        private List<S3Object> GetS3ObjectsToDownload(ListObjectsRequest listRequest)
        {
            List<S3Object> objs = new List<S3Object>();
            do
            {
                ListObjectsResponse listResponse = this._s3Client.ListObjects(listRequest);

                foreach (S3Object s3o in listResponse.S3Objects)
                {
                    if (ShouldDownload(s3o))
                    {
                        this._totalBytes += s3o.Size;
                        objs.Add(s3o);
                    }
                }
                listRequest.Marker = listResponse.NextMarker;
            } while (!string.IsNullOrEmpty(listRequest.Marker));
            return objs;
        }

        private List<S3Object> GetS3ObjectsToDownloadV2(ListObjectsV2Request listRequestV2)
        {
            List<S3Object> objs = new List<S3Object>();
            do
            {
                ListObjectsV2Response listResponse = this._s3Client.ListObjectsV2(listRequestV2);

                foreach (S3Object s3o in listResponse.S3Objects)
                {
                    if (ShouldDownload(s3o))
                    {
                        this._totalBytes += s3o.Size;
                        objs.Add(s3o);
                    }
                }
                listRequestV2.ContinuationToken = listResponse.NextContinuationToken;
            } while (!string.IsNullOrEmpty(listRequestV2.ContinuationToken));
            return objs;
        }
    }
}
