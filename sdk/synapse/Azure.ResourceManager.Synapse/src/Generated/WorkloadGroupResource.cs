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

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a WorkloadGroup along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WorkloadGroupResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWorkloadGroupResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlPoolResource" /> using the GetWorkloadGroup method.
    /// </summary>
    public partial class WorkloadGroupResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WorkloadGroupResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string workloadGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _workloadGroupSqlPoolWorkloadGroupClientDiagnostics;
        private readonly SqlPoolWorkloadGroupRestOperations _workloadGroupSqlPoolWorkloadGroupRestClient;
        private readonly WorkloadGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="WorkloadGroupResource"/> class for mocking. </summary>
        protected WorkloadGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WorkloadGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WorkloadGroupResource(ArmClient client, WorkloadGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WorkloadGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workloadGroupSqlPoolWorkloadGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string workloadGroupSqlPoolWorkloadGroupApiVersion);
            _workloadGroupSqlPoolWorkloadGroupRestClient = new SqlPoolWorkloadGroupRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workloadGroupSqlPoolWorkloadGroupApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/sqlPools/workloadGroups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WorkloadGroupData Data
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

        /// <summary> Gets a collection of WorkloadClassifierResources in the WorkloadGroup. </summary>
        /// <returns> An object representing collection of WorkloadClassifierResources and their operations over a WorkloadClassifierResource. </returns>
        public virtual WorkloadClassifierCollection GetWorkloadClassifiers()
        {
            return GetCachedClient(Client => new WorkloadClassifierCollection(Client, Id));
        }

        /// <summary>
        /// Get a workload classifier of Sql pool&apos;s workload group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}/workloadClassifiers/{workloadClassifierName}
        /// Operation Id: SqlPoolWorkloadClassifier_Get
        /// </summary>
        /// <param name="workloadClassifierName"> The name of the workload classifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadClassifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadClassifierName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<WorkloadClassifierResource>> GetWorkloadClassifierAsync(string workloadClassifierName, CancellationToken cancellationToken = default)
        {
            return await GetWorkloadClassifiers().GetAsync(workloadClassifierName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a workload classifier of Sql pool&apos;s workload group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}/workloadClassifiers/{workloadClassifierName}
        /// Operation Id: SqlPoolWorkloadClassifier_Get
        /// </summary>
        /// <param name="workloadClassifierName"> The name of the workload classifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadClassifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadClassifierName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<WorkloadClassifierResource> GetWorkloadClassifier(string workloadClassifierName, CancellationToken cancellationToken = default)
        {
            return GetWorkloadClassifiers().Get(workloadClassifierName, cancellationToken);
        }

        /// <summary>
        /// Get a Sql pool&apos;s workload group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}
        /// Operation Id: SqlPoolWorkloadGroup_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WorkloadGroupResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _workloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("WorkloadGroupResource.Get");
            scope.Start();
            try
            {
                var response = await _workloadGroupSqlPoolWorkloadGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Sql pool&apos;s workload group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}
        /// Operation Id: SqlPoolWorkloadGroup_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WorkloadGroupResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _workloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("WorkloadGroupResource.Get");
            scope.Start();
            try
            {
                var response = _workloadGroupSqlPoolWorkloadGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadGroupResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Remove Sql pool&apos;s workload group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}
        /// Operation Id: SqlPoolWorkloadGroup_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _workloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("WorkloadGroupResource.Delete");
            scope.Start();
            try
            {
                var response = await _workloadGroupSqlPoolWorkloadGroupRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation(_workloadGroupSqlPoolWorkloadGroupClientDiagnostics, Pipeline, _workloadGroupSqlPoolWorkloadGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Remove Sql pool&apos;s workload group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}
        /// Operation Id: SqlPoolWorkloadGroup_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _workloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("WorkloadGroupResource.Delete");
            scope.Start();
            try
            {
                var response = _workloadGroupSqlPoolWorkloadGroupRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SynapseArmOperation(_workloadGroupSqlPoolWorkloadGroupClientDiagnostics, Pipeline, _workloadGroupSqlPoolWorkloadGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
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
        /// Create Or Update a Sql pool&apos;s workload group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}
        /// Operation Id: SqlPoolWorkloadGroup_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The requested workload group state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkloadGroupResource>> UpdateAsync(WaitUntil waitUntil, WorkloadGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("WorkloadGroupResource.Update");
            scope.Start();
            try
            {
                var response = await _workloadGroupSqlPoolWorkloadGroupRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<WorkloadGroupResource>(new WorkloadGroupOperationSource(Client), _workloadGroupSqlPoolWorkloadGroupClientDiagnostics, Pipeline, _workloadGroupSqlPoolWorkloadGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create Or Update a Sql pool&apos;s workload group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/workloadGroups/{workloadGroupName}
        /// Operation Id: SqlPoolWorkloadGroup_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The requested workload group state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WorkloadGroupResource> Update(WaitUntil waitUntil, WorkloadGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadGroupSqlPoolWorkloadGroupClientDiagnostics.CreateScope("WorkloadGroupResource.Update");
            scope.Start();
            try
            {
                var response = _workloadGroupSqlPoolWorkloadGroupRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SynapseArmOperation<WorkloadGroupResource>(new WorkloadGroupOperationSource(Client), _workloadGroupSqlPoolWorkloadGroupClientDiagnostics, Pipeline, _workloadGroupSqlPoolWorkloadGroupRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
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
