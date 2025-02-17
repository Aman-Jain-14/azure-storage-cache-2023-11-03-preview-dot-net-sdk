// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The SKU of the cluster. This determines the size/capacity of the cluster. Required on PUT (CreateOrUpdate) requests. </summary>
    public partial class StreamAnalyticsClusterSku
    {
        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsClusterSku"/>. </summary>
        public StreamAnalyticsClusterSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsClusterSku"/>. </summary>
        /// <param name="name"> Specifies the SKU name of the cluster. Required on PUT (CreateOrUpdate) requests. </param>
        /// <param name="capacity"> Denotes the number of streaming units the cluster can support. Valid values for this property are multiples of 36 with a minimum value of 36 and maximum value of 216. Required on PUT (CreateOrUpdate) requests. </param>
        internal StreamAnalyticsClusterSku(StreamAnalyticsClusterSkuName? name, int? capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        /// <summary> Specifies the SKU name of the cluster. Required on PUT (CreateOrUpdate) requests. </summary>
        public StreamAnalyticsClusterSkuName? Name { get; set; }
        /// <summary> Denotes the number of streaming units the cluster can support. Valid values for this property are multiples of 36 with a minimum value of 36 and maximum value of 216. Required on PUT (CreateOrUpdate) requests. </summary>
        public int? Capacity { get; set; }
    }
}
