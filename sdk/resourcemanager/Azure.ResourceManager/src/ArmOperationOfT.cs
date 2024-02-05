﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using System;
using System.ClientModel.Primitives;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager
{
    /// <inheritdoc/>
    public class ArmOperation<T> : Operation<T> where T : notnull
    {
        private readonly OperationInternal<T>? _operation;
        private readonly RehydrationToken? _rehydrationToken;

        /// <summary> Initializes a new instance of ArmOperation. </summary>
        public ArmOperation(ArmClient client, RehydrationToken? rehydrationToken)
        {
            Argument.AssertNotNull(rehydrationToken, nameof(rehydrationToken));

            var isResource = typeof(T).GetConstructor(
                BindingFlags.NonPublic | BindingFlags.Instance,
                null,
                CallingConventions.Any,
                new Type[] { typeof(ArmClient), typeof(ResourceIdentifier) },
                null) is not null;
            var obj = Activator.CreateInstance(typeof(T), BindingFlags.NonPublic | BindingFlags.Instance, null, null, null);
            if (!isResource && obj is not IJsonModel<object>)
            {
                throw new InvalidOperationException($"Type {typeof(T)} should be Resource or ReousrceData");
            }

            IOperationSource<T> source = new GenericOperationSource<T>(client, isResource);
            var nextLinkOperation = NextLinkOperationImplementation.Create(source, client.Pipeline, rehydrationToken);
            // TODO: Do we need more specific OptionsNamespace, ProviderNamespace and OperationTypeName and possibly from id?
            var clientDiagnostics = new ClientDiagnostics("Azure.ResourceManager", "Microsoft.Resources", client.Diagnostics);
            _operation = new OperationInternal<T>(nextLinkOperation!, clientDiagnostics, null);
            _rehydrationToken = rehydrationToken;
        }

        /// <summary> Initializes a new instance of ArmOperation for mocking. </summary>
        protected ArmOperation()
        {
        }

        internal ArmOperation(OperationInternal<T> operation)
        {
            _operation = operation;
        }

        internal ArmOperation(Response<T> response, RehydrationToken? rehydrationToken)
        {
            _operation = OperationInternal<T>.Succeeded(response.GetRawResponse(), response.Value, rehydrationToken);
            _rehydrationToken = rehydrationToken;
        }

        internal ArmOperation(IOperationSource<T> source, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response, OperationFinalStateVia finalStateVia, bool skipApiVersionOverride = false, string? apiVersionOverrideValue = null)
        {
            var nextLinkOperation = NextLinkOperationImplementation.Create(source, pipeline, request.Method, request.Uri.ToUri(), response, finalStateVia, skipApiVersionOverride, apiVersionOverrideValue);
            _operation = new OperationInternal<T>(nextLinkOperation, clientDiagnostics, response);
            _rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(request.Method, request.Uri.ToUri(), response, finalStateVia, skipApiVersionOverride, apiVersionOverrideValue);
        }

        /// <inheritdoc />
        public override RehydrationToken? GetRehydrationToken() => _rehydrationToken;

#pragma warning disable CA1822
        /// <inheritdoc />
        public override string Id => throw new NotSupportedException();
#pragma warning restore CA1822

        /// <inheritdoc />
        public override T Value => _operation!.Value;

        /// <inheritdoc />
        public override bool HasValue => _operation!.HasValue;

        /// <inheritdoc />
        public override bool HasCompleted => _operation!.HasCompleted;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation!.RawResponse;

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation!.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation!.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override Response<T> WaitForCompletion(CancellationToken cancellationToken = default) => _operation!.WaitForCompletion(cancellationToken);

        /// <inheritdoc />
        public override Response<T> WaitForCompletion(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation!.WaitForCompletion(pollingInterval, cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<T>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation!.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<T>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation!.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
