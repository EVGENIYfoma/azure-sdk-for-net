// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Storage mapping input properties. </summary>
    internal partial class StorageMappingProperties
    {
        /// <summary> Initializes a new instance of <see cref="StorageMappingProperties"/>. </summary>
        public StorageMappingProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageMappingProperties"/>. </summary>
        /// <param name="targetStorageClassificationId"> The ID of the storage object. </param>
        internal StorageMappingProperties(ResourceIdentifier targetStorageClassificationId)
        {
            TargetStorageClassificationId = targetStorageClassificationId;
        }

        /// <summary> The ID of the storage object. </summary>
        public ResourceIdentifier TargetStorageClassificationId { get; set; }
    }
}
