// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The compute node information class.
    /// </summary>
    public partial class ComputeNodeInformation : IPropertyMetadata
    {
        #region Constructors

        internal ComputeNodeInformation(Models.ComputeNodeInformation protocolObject)
        {
            this.AffinityId = protocolObject.AffinityId;
            this.ComputeNodeId = protocolObject.NodeId;
            this.ComputeNodeUrl = protocolObject.NodeUrl;
            this.PoolId = protocolObject.PoolId;
            this.TaskRootDirectory = protocolObject.TaskRootDirectory;
            this.TaskRootDirectoryUrl = protocolObject.TaskRootDirectoryUrl;
        }

        #endregion Constructors

        #region ComputeNodeInformation

        /// <summary>
        /// Gets an opaque string that contains information about the location of the compute node.
        /// </summary>
        public string AffinityId { get; }

        /// <summary>
        /// Gets the compute node id.
        /// </summary>
        public string ComputeNodeId { get; }

        /// <summary>
        /// Gets the URL of the compute node.
        /// </summary>
        public string ComputeNodeUrl { get; }

        /// <summary>
        /// Gets the pool id.
        /// </summary>
        public string PoolId { get; }

        /// <summary>
        /// Gets the root directory of the current task on the compute node. You can use this path to retrieve files created 
        /// by the task such as log files.
        /// </summary>
        public string TaskRootDirectory { get; }

        /// <summary>
        /// Gets the URL to the root directory of the current task on the compute node.
        /// </summary>
        public string TaskRootDirectoryUrl { get; }

        #endregion // ComputeNodeInformation

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}