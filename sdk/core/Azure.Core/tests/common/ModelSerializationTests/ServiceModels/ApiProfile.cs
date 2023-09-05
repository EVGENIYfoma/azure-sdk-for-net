// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Core.Tests.ResourceManager.Resources.Models
{
    /// <summary> The ApiProfile. </summary>
    public partial class ApiProfile
    {
        /// <summary> Initializes a new instance of ApiProfile. </summary>
        internal ApiProfile()
        {
        }

        /// <summary> Initializes a new instance of ApiProfile. </summary>
        /// <param name="profileVersion"> The profile version. </param>
        /// <param name="apiVersion"> The API version. </param>
        internal ApiProfile(string profileVersion, string apiVersion)
        {
            ProfileVersion = profileVersion;
            ApiVersion = apiVersion;
        }

        /// <summary> The profile version. </summary>
        public string ProfileVersion { get; }
        /// <summary> The API version. </summary>
        public string ApiVersion { get; }
    }
}
