// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The details for required tool calls that must be submitted for an assistant thread run to continue. </summary>
    public partial class SubmitToolOutputsAction : RequiredAction
    {
        /// <summary> Initializes a new instance of <see cref="SubmitToolOutputsAction"/>. </summary>
        /// <param name="internalDetails"> The details describing tools that should be called to submit tool outputs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="internalDetails"/> is null. </exception>
        internal SubmitToolOutputsAction(InternalSubmitToolOutputsDetails internalDetails)
        {
            Argument.AssertNotNull(internalDetails, nameof(internalDetails));

            Type = "submit_tool_outputs";
            InternalDetails = internalDetails;
        }

        /// <summary> Initializes a new instance of <see cref="SubmitToolOutputsAction"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="internalDetails"> The details describing tools that should be called to submit tool outputs. </param>
        internal SubmitToolOutputsAction(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalSubmitToolOutputsDetails internalDetails) : base(type, serializedAdditionalRawData)
        {
            InternalDetails = internalDetails;
        }

        /// <summary> Initializes a new instance of <see cref="SubmitToolOutputsAction"/> for deserialization. </summary>
        internal SubmitToolOutputsAction()
        {
        }
    }
}
