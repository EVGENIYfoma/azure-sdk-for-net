// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> describes the custom entity store assignment request. </summary>
    public partial class CustomEntityStoreAssignmentCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="CustomEntityStoreAssignmentCreateOrUpdateContent"/>. </summary>
        public CustomEntityStoreAssignmentCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CustomEntityStoreAssignmentCreateOrUpdateContent"/>. </summary>
        /// <param name="principal"> The principal assigned with entity store. If not provided, will use caller principal. Format of principal is: [AAD type]=[PrincipalObjectId];[TenantId]. </param>
        internal CustomEntityStoreAssignmentCreateOrUpdateContent(string principal)
        {
            Principal = principal;
        }

        /// <summary> The principal assigned with entity store. If not provided, will use caller principal. Format of principal is: [AAD type]=[PrincipalObjectId];[TenantId]. </summary>
        public string Principal { get; set; }
    }
}
