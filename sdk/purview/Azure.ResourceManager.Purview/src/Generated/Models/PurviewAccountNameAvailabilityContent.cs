// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The request payload for CheckNameAvailability API. </summary>
    public partial class PurviewAccountNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of <see cref="PurviewAccountNameAvailabilityContent"/>. </summary>
        public PurviewAccountNameAvailabilityContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PurviewAccountNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Resource name to verify for availability. </param>
        /// <param name="resourceType"> Fully qualified resource type which includes provider namespace. </param>
        internal PurviewAccountNameAvailabilityContent(string name, string resourceType)
        {
            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Resource name to verify for availability. </summary>
        public string Name { get; set; }
        /// <summary> Fully qualified resource type which includes provider namespace. </summary>
        public string ResourceType { get; set; }
    }
}
