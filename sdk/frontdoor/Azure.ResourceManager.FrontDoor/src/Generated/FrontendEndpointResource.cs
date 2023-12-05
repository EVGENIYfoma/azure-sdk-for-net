// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.FrontDoor.Models;

namespace Azure.ResourceManager.FrontDoor
{
    /// <summary>
    /// A Class representing a FrontendEndpoint along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="FrontendEndpointResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetFrontendEndpointResource method.
    /// Otherwise you can get one from its parent resource <see cref="FrontDoorResource"/> using the GetFrontendEndpoint method.
    /// </summary>
    public partial class FrontendEndpointResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="FrontendEndpointResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="frontDoorName"> The frontDoorName. </param>
        /// <param name="frontendEndpointName"> The frontendEndpointName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string frontDoorName, string frontendEndpointName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}/frontendEndpoints/{frontendEndpointName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _frontendEndpointClientDiagnostics;
        private readonly FrontendEndpointsRestOperations _frontendEndpointRestClient;
        private readonly FrontendEndpointData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/frontDoors/frontendEndpoints";

        /// <summary> Initializes a new instance of the <see cref="FrontendEndpointResource"/> class for mocking. </summary>
        protected FrontendEndpointResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FrontendEndpointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FrontendEndpointResource(ArmClient client, FrontendEndpointData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="FrontendEndpointResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FrontendEndpointResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _frontendEndpointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.FrontDoor", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string frontendEndpointApiVersion);
            _frontendEndpointRestClient = new FrontendEndpointsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, frontendEndpointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FrontendEndpointData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a Frontend endpoint with the specified name within the specified Front Door.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}/frontendEndpoints/{frontendEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontendEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FrontendEndpointResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _frontendEndpointClientDiagnostics.CreateScope("FrontendEndpointResource.Get");
            scope.Start();
            try
            {
                var response = await _frontendEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontendEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Frontend endpoint with the specified name within the specified Front Door.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}/frontendEndpoints/{frontendEndpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontendEndpoints_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FrontendEndpointResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _frontendEndpointClientDiagnostics.CreateScope("FrontendEndpointResource.Get");
            scope.Start();
            try
            {
                var response = _frontendEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontendEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Enables a frontendEndpoint for HTTPS traffic
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}/frontendEndpoints/{frontendEndpointName}/enableHttps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontendEndpoints_EnableHttps</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="customHttpsConfiguration"> The configuration specifying how to enable HTTPS. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customHttpsConfiguration"/> is null. </exception>
        public virtual async Task<ArmOperation> EnableHttpsAsync(WaitUntil waitUntil, CustomHttpsConfiguration customHttpsConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(customHttpsConfiguration, nameof(customHttpsConfiguration));

            using var scope = _frontendEndpointClientDiagnostics.CreateScope("FrontendEndpointResource.EnableHttps");
            scope.Start();
            try
            {
                var response = await _frontendEndpointRestClient.EnableHttpsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, customHttpsConfiguration, cancellationToken).ConfigureAwait(false);
                var operation = new FrontDoorArmOperation(_frontendEndpointClientDiagnostics, Pipeline, _frontendEndpointRestClient.CreateEnableHttpsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, customHttpsConfiguration).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Enables a frontendEndpoint for HTTPS traffic
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}/frontendEndpoints/{frontendEndpointName}/enableHttps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontendEndpoints_EnableHttps</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="customHttpsConfiguration"> The configuration specifying how to enable HTTPS. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customHttpsConfiguration"/> is null. </exception>
        public virtual ArmOperation EnableHttps(WaitUntil waitUntil, CustomHttpsConfiguration customHttpsConfiguration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(customHttpsConfiguration, nameof(customHttpsConfiguration));

            using var scope = _frontendEndpointClientDiagnostics.CreateScope("FrontendEndpointResource.EnableHttps");
            scope.Start();
            try
            {
                var response = _frontendEndpointRestClient.EnableHttps(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, customHttpsConfiguration, cancellationToken);
                var operation = new FrontDoorArmOperation(_frontendEndpointClientDiagnostics, Pipeline, _frontendEndpointRestClient.CreateEnableHttpsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, customHttpsConfiguration).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Disables a frontendEndpoint for HTTPS traffic
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}/frontendEndpoints/{frontendEndpointName}/disableHttps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontendEndpoints_DisableHttps</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DisableHttpsAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _frontendEndpointClientDiagnostics.CreateScope("FrontendEndpointResource.DisableHttps");
            scope.Start();
            try
            {
                var response = await _frontendEndpointRestClient.DisableHttpsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new FrontDoorArmOperation(_frontendEndpointClientDiagnostics, Pipeline, _frontendEndpointRestClient.CreateDisableHttpsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Disables a frontendEndpoint for HTTPS traffic
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/frontDoors/{frontDoorName}/frontendEndpoints/{frontendEndpointName}/disableHttps</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontendEndpoints_DisableHttps</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation DisableHttps(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _frontendEndpointClientDiagnostics.CreateScope("FrontendEndpointResource.DisableHttps");
            scope.Start();
            try
            {
                var response = _frontendEndpointRestClient.DisableHttps(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new FrontDoorArmOperation(_frontendEndpointClientDiagnostics, Pipeline, _frontendEndpointRestClient.CreateDisableHttpsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
