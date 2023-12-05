// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The JitNetworkAccessPolicyInitiateContent. </summary>
    public partial class JitNetworkAccessPolicyInitiateContent
    {
        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessPolicyInitiateContent"/>. </summary>
        /// <param name="virtualMachines"> A list of virtual machines &amp; ports to open access for. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachines"/> is null. </exception>
        public JitNetworkAccessPolicyInitiateContent(IEnumerable<JitNetworkAccessPolicyInitiateVirtualMachine> virtualMachines)
        {
            Argument.AssertNotNull(virtualMachines, nameof(virtualMachines));

            VirtualMachines = virtualMachines.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessPolicyInitiateContent"/>. </summary>
        /// <param name="virtualMachines"> A list of virtual machines &amp; ports to open access for. </param>
        /// <param name="justification"> The justification for making the initiate request. </param>
        internal JitNetworkAccessPolicyInitiateContent(IList<JitNetworkAccessPolicyInitiateVirtualMachine> virtualMachines, string justification)
        {
            VirtualMachines = virtualMachines;
            Justification = justification;
        }

        /// <summary> A list of virtual machines &amp; ports to open access for. </summary>
        public IList<JitNetworkAccessPolicyInitiateVirtualMachine> VirtualMachines { get; }
        /// <summary> The justification for making the initiate request. </summary>
        public string Justification { get; set; }
    }
}
