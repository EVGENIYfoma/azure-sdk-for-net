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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a ManagedDatabaseTable along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="ManagedDatabaseTableResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetManagedDatabaseTableResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagedDatabaseSchemaResource"/> using the GetManagedDatabaseTable method.
    /// </summary>
    public partial class ManagedDatabaseTableResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ManagedDatabaseTableResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="managedInstanceName"> The managedInstanceName. </param>
        /// <param name="databaseName"> The databaseName. </param>
        /// <param name="schemaName"> The schemaName. </param>
        /// <param name="tableName"> The tableName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string managedInstanceName, string databaseName, string schemaName, string tableName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _managedDatabaseTableClientDiagnostics;
        private readonly ManagedDatabaseTablesRestOperations _managedDatabaseTableRestClient;
        private readonly DatabaseTableData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/databases/schemas/tables";

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseTableResource"/> class for mocking. </summary>
        protected ManagedDatabaseTableResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseTableResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ManagedDatabaseTableResource(ArmClient client, DatabaseTableData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedDatabaseTableResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedDatabaseTableResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedDatabaseTableClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string managedDatabaseTableApiVersion);
            _managedDatabaseTableRestClient = new ManagedDatabaseTablesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedDatabaseTableApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DatabaseTableData Data
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

        /// <summary> Gets a collection of ManagedDatabaseColumnResources in the ManagedDatabaseTable. </summary>
        /// <returns> An object representing collection of ManagedDatabaseColumnResources and their operations over a ManagedDatabaseColumnResource. </returns>
        public virtual ManagedDatabaseColumnCollection GetManagedDatabaseColumns()
        {
            return GetCachedClient(client => new ManagedDatabaseColumnCollection(client, Id));
        }

        /// <summary>
        /// Get managed database column
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseColumns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="columnName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ManagedDatabaseColumnResource>> GetManagedDatabaseColumnAsync(string columnName, CancellationToken cancellationToken = default)
        {
            return await GetManagedDatabaseColumns().GetAsync(columnName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get managed database column
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseColumns_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="columnName"> The name of the column. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="columnName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="columnName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ManagedDatabaseColumnResource> GetManagedDatabaseColumn(string columnName, CancellationToken cancellationToken = default)
        {
            return GetManagedDatabaseColumns().Get(columnName, cancellationToken);
        }

        /// <summary>
        /// Get managed database table
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseTables_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedDatabaseTableResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseTableClientDiagnostics.CreateScope("ManagedDatabaseTableResource.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseTableRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseTableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get managed database table
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedDatabaseTables_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedDatabaseTableResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _managedDatabaseTableClientDiagnostics.CreateScope("ManagedDatabaseTableResource.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseTableRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedDatabaseTableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
