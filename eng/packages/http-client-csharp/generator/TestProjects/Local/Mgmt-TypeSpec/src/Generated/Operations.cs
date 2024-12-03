// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using MgmtTypeSpec.Models;

namespace MgmtTypeSpec
{
    /// <summary></summary>
    public partial class Operations
    {
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of Operations for mocking. </summary>
        protected Operations()
        {
        }

        internal Operations(HttpPipeline pipeline, Uri endpoint, string apiVersion)
        {
            _endpoint = endpoint;
            Pipeline = pipeline;
            _apiVersion = apiVersion;
        }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public HttpPipeline Pipeline { get; }

        /// <summary>
        /// [Protocol Method] List the operations for the provider
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual Response List(RequestContext context)
        {
            using HttpMessage message = CreateListRequest(context);
            return Pipeline.ProcessMessage(message, context);
        }

        /// <summary>
        /// [Protocol Method] List the operations for the provider
        /// <list type="bullet">
        /// <item>
        /// <description> This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios. </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<Response> ListAsync(RequestContext context)
        {
            using HttpMessage message = CreateListRequest(context);
            return await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
        }

        /// <summary> List the operations for the provider. </summary>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual Response<OperationListResult> List()
        {
            Response result = List(context: null);
            return Response.FromValue((OperationListResult)result, result);
        }

        /// <summary> List the operations for the provider. </summary>
        /// <param name="cancellationToken"> The cancellation token that can be used to cancel the operation. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        public virtual async Task<Response<OperationListResult>> ListAsync(CancellationToken cancellationToken = default)
        {
            Response result = await ListAsync(cancellationToken.CanBeCanceled ? new RequestContext { CancellationToken = cancellationToken } : null).ConfigureAwait(false);
            return Response.FromValue((OperationListResult)result, result);
        }
    }
}
