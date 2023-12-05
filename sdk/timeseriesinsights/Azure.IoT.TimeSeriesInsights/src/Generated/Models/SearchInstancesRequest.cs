// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Request to execute a search query against time series instances and return matching time series instances. </summary>
    internal partial class SearchInstancesRequest
    {
        /// <summary> Initializes a new instance of <see cref="SearchInstancesRequest"/>. </summary>
        /// <param name="searchString"> Query search string that will be matched to the attributes of time series instances. Example: "floor 100". Case-insensitive, must be present, but can be empty string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="searchString"/> is null. </exception>
        public SearchInstancesRequest(string searchString)
        {
            Argument.AssertNotNull(searchString, nameof(searchString));

            SearchString = searchString;
            Path = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SearchInstancesRequest"/>. </summary>
        /// <param name="searchString"> Query search string that will be matched to the attributes of time series instances. Example: "floor 100". Case-insensitive, must be present, but can be empty string. </param>
        /// <param name="path"> Filter on hierarchy path of time series instances. Path is represented as array of string path segments. First element should be hierarchy name. Example: ["Location", "California"]. Optional, case sensitive, never empty and can be null. </param>
        /// <param name="instances"> Parameters of how to return time series instances. Can be null. When both the instances and hierarchies parameters are null, the instances are returned in the results based on the default values of parameters, and hierarchies are not returned. </param>
        /// <param name="hierarchies"> Parameters of how to return time series instance hierarchies. If null, hierarchies are not returned. If instances parameter is null and hierarchies parameter is not null, only hierarchies with no instances are returned. </param>
        internal SearchInstancesRequest(string searchString, IList<string> path, SearchInstancesParameters instances, SearchInstancesHierarchiesParameters hierarchies)
        {
            SearchString = searchString;
            Path = path;
            Instances = instances;
            Hierarchies = hierarchies;
        }

        /// <summary> Query search string that will be matched to the attributes of time series instances. Example: "floor 100". Case-insensitive, must be present, but can be empty string. </summary>
        public string SearchString { get; }
        /// <summary> Filter on hierarchy path of time series instances. Path is represented as array of string path segments. First element should be hierarchy name. Example: ["Location", "California"]. Optional, case sensitive, never empty and can be null. </summary>
        public IList<string> Path { get; }
        /// <summary> Parameters of how to return time series instances. Can be null. When both the instances and hierarchies parameters are null, the instances are returned in the results based on the default values of parameters, and hierarchies are not returned. </summary>
        public SearchInstancesParameters Instances { get; set; }
        /// <summary> Parameters of how to return time series instance hierarchies. If null, hierarchies are not returned. If instances parameter is null and hierarchies parameter is not null, only hierarchies with no instances are returned. </summary>
        public SearchInstancesHierarchiesParameters Hierarchies { get; set; }
    }
}
