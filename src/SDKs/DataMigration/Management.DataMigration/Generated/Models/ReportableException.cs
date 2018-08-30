// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Exception object for all custom exceptions
    /// </summary>
    public partial class ReportableException
    {
        /// <summary>
        /// Initializes a new instance of the ReportableException class.
        /// </summary>
        public ReportableException()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReportableException class.
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="actionableMessage">Actionable steps for this
        /// exception</param>
        /// <param name="filePath">The path to the file where exception
        /// occurred</param>
        /// <param name="lineNumber">The line number where exception
        /// occurred</param>
        /// <param name="hResult">Coded numerical value that is assigned to a
        /// specific exception</param>
        /// <param name="stackTrace">Stack trace</param>
        public ReportableException(string message = default(string), string actionableMessage = default(string), string filePath = default(string), string lineNumber = default(string), int? hResult = default(int?), string stackTrace = default(string))
        {
            Message = message;
            ActionableMessage = actionableMessage;
            FilePath = filePath;
            LineNumber = lineNumber;
            HResult = hResult;
            StackTrace = stackTrace;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets error message
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets actionable steps for this exception
        /// </summary>
        [JsonProperty(PropertyName = "actionableMessage")]
        public string ActionableMessage { get; set; }

        /// <summary>
        /// Gets or sets the path to the file where exception occurred
        /// </summary>
        [JsonProperty(PropertyName = "filePath")]
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the line number where exception occurred
        /// </summary>
        [JsonProperty(PropertyName = "lineNumber")]
        public string LineNumber { get; set; }

        /// <summary>
        /// Gets or sets coded numerical value that is assigned to a specific
        /// exception
        /// </summary>
        [JsonProperty(PropertyName = "hResult")]
        public int? HResult { get; set; }

        /// <summary>
        /// Gets or sets stack trace
        /// </summary>
        [JsonProperty(PropertyName = "stackTrace")]
        public string StackTrace { get; set; }

    }
}
