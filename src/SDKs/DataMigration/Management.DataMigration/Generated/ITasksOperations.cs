// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// TasksOperations operations.
    /// </summary>
    public partial interface ITasksOperations
    {
        /// <summary>
        /// Get tasks in a service
        /// </summary>
        /// <remarks>
        /// The services resource is the top-level resource that represents the
        /// Database Migration Service. This method returns a list of tasks
        /// owned by a service resource. Some tasks may have a status of
        /// Unknown, which indicates that an error occurred while querying the
        /// status of that task.
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='serviceName'>
        /// Name of the service
        /// </param>
        /// <param name='projectName'>
        /// Name of the project
        /// </param>
        /// <param name='taskType'>
        /// Filter tasks by task type
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ProjectTask>>> ListWithHttpMessagesAsync(string groupName, string serviceName, string projectName, string taskType = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update task
        /// </summary>
        /// <remarks>
        /// The tasks resource is a nested, proxy-only resource representing
        /// work performed by a DMS instance. The PUT method creates a new task
        /// or updates an existing one, although since tasks have no mutable
        /// custom properties, there is little reason to update an exising one.
        /// </remarks>
        /// <param name='parameters'>
        /// Information about the task
        /// </param>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='serviceName'>
        /// Name of the service
        /// </param>
        /// <param name='projectName'>
        /// Name of the project
        /// </param>
        /// <param name='taskName'>
        /// Name of the Task
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProjectTask>> CreateOrUpdateWithHttpMessagesAsync(ProjectTask parameters, string groupName, string serviceName, string projectName, string taskName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get task information
        /// </summary>
        /// <remarks>
        /// The tasks resource is a nested, proxy-only resource representing
        /// work performed by a DMS instance. The GET method retrieves
        /// information about a task.
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='serviceName'>
        /// Name of the service
        /// </param>
        /// <param name='projectName'>
        /// Name of the project
        /// </param>
        /// <param name='taskName'>
        /// Name of the Task
        /// </param>
        /// <param name='expand'>
        /// Expand the response
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProjectTask>> GetWithHttpMessagesAsync(string groupName, string serviceName, string projectName, string taskName, string expand = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete task
        /// </summary>
        /// <remarks>
        /// The tasks resource is a nested, proxy-only resource representing
        /// work performed by a DMS instance. The DELETE method deletes a task,
        /// canceling it first if it's running.
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='serviceName'>
        /// Name of the service
        /// </param>
        /// <param name='projectName'>
        /// Name of the project
        /// </param>
        /// <param name='taskName'>
        /// Name of the Task
        /// </param>
        /// <param name='deleteRunningTasks'>
        /// Delete the resource even if it contains running tasks
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string groupName, string serviceName, string projectName, string taskName, bool? deleteRunningTasks = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update task
        /// </summary>
        /// <remarks>
        /// The tasks resource is a nested, proxy-only resource representing
        /// work performed by a DMS instance. The PATCH method updates an
        /// existing task, but since tasks have no mutable custom properties,
        /// there is little reason to do so.
        /// </remarks>
        /// <param name='parameters'>
        /// Information about the task
        /// </param>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='serviceName'>
        /// Name of the service
        /// </param>
        /// <param name='projectName'>
        /// Name of the project
        /// </param>
        /// <param name='taskName'>
        /// Name of the Task
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProjectTask>> UpdateWithHttpMessagesAsync(ProjectTask parameters, string groupName, string serviceName, string projectName, string taskName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancel a task
        /// </summary>
        /// <remarks>
        /// The tasks resource is a nested, proxy-only resource representing
        /// work performed by a DMS instance. This method cancels a task if
        /// it's currently queued or running.
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='serviceName'>
        /// Name of the service
        /// </param>
        /// <param name='projectName'>
        /// Name of the project
        /// </param>
        /// <param name='taskName'>
        /// Name of the Task
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProjectTask>> CancelWithHttpMessagesAsync(string groupName, string serviceName, string projectName, string taskName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Execute a command on a task
        /// </summary>
        /// <remarks>
        /// The tasks resource is a nested, proxy-only resource representing
        /// work performed by a DMS instance. This method executes a command on
        /// a running task.
        /// </remarks>
        /// <param name='groupName'>
        /// Name of the resource group
        /// </param>
        /// <param name='serviceName'>
        /// Name of the service
        /// </param>
        /// <param name='projectName'>
        /// Name of the project
        /// </param>
        /// <param name='taskName'>
        /// Name of the Task
        /// </param>
        /// <param name='parameters'>
        /// Command to execute
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<CommandProperties>> CommandWithHttpMessagesAsync(string groupName, string serviceName, string projectName, string taskName, CommandProperties parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get tasks in a service
        /// </summary>
        /// <remarks>
        /// The services resource is the top-level resource that represents the
        /// Database Migration Service. This method returns a list of tasks
        /// owned by a service resource. Some tasks may have a status of
        /// Unknown, which indicates that an error occurred while querying the
        /// status of that task.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ProjectTask>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
