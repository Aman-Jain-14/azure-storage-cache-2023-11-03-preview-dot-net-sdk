// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> The response of a CertificateObjectLocalRulestackResource list operation. </summary>
    internal partial class LocalRulestackCertificateObjectListResult
    {
        /// <summary> Initializes a new instance of <see cref="LocalRulestackCertificateObjectListResult"/>. </summary>
        /// <param name="value"> The items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal LocalRulestackCertificateObjectListResult(IEnumerable<LocalRulestackCertificateObjectData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="LocalRulestackCertificateObjectListResult"/>. </summary>
        /// <param name="value"> The items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal LocalRulestackCertificateObjectListResult(IReadOnlyList<LocalRulestackCertificateObjectData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The items on this page. </summary>
        public IReadOnlyList<LocalRulestackCertificateObjectData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public string NextLink { get; }
    }
}
