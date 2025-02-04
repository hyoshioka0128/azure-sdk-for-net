// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Online deployment scoring requests configuration. </summary>
    public partial class OnlineRequestSettings
    {
        /// <summary> Initializes a new instance of OnlineRequestSettings. </summary>
        public OnlineRequestSettings()
        {
        }

        /// <summary> Initializes a new instance of OnlineRequestSettings. </summary>
        /// <param name="maxConcurrentRequestsPerInstance"> The number of maximum concurrent requests per node allowed per deployment. Defaults to 1. </param>
        /// <param name="maxQueueWait">
        /// The maximum amount of time a request will stay in the queue in ISO 8601 format.
        /// Defaults to 500ms.
        /// </param>
        /// <param name="requestTimeout">
        /// The scoring timeout in ISO 8601 format.
        /// Defaults to 5000ms.
        /// </param>
        internal OnlineRequestSettings(int? maxConcurrentRequestsPerInstance, TimeSpan? maxQueueWait, TimeSpan? requestTimeout)
        {
            MaxConcurrentRequestsPerInstance = maxConcurrentRequestsPerInstance;
            MaxQueueWait = maxQueueWait;
            RequestTimeout = requestTimeout;
        }

        /// <summary> The number of maximum concurrent requests per node allowed per deployment. Defaults to 1. </summary>
        public int? MaxConcurrentRequestsPerInstance { get; set; }
        /// <summary>
        /// The maximum amount of time a request will stay in the queue in ISO 8601 format.
        /// Defaults to 500ms.
        /// </summary>
        public TimeSpan? MaxQueueWait { get; set; }
        /// <summary>
        /// The scoring timeout in ISO 8601 format.
        /// Defaults to 5000ms.
        /// </summary>
        public TimeSpan? RequestTimeout { get; set; }
    }
}
