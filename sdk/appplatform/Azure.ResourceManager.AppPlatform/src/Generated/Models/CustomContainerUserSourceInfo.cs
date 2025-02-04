// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Custom container user source info. </summary>
    public partial class CustomContainerUserSourceInfo : UserSourceInfo
    {
        /// <summary> Initializes a new instance of CustomContainerUserSourceInfo. </summary>
        public CustomContainerUserSourceInfo()
        {
            UserSourceInfoType = "Container";
        }

        /// <summary> Initializes a new instance of CustomContainerUserSourceInfo. </summary>
        /// <param name="userSourceInfoType"> Type of the source uploaded. </param>
        /// <param name="version"> Version of the source. </param>
        /// <param name="customContainer"> Custom container payload. </param>
        internal CustomContainerUserSourceInfo(string userSourceInfoType, string version, CustomContainer customContainer) : base(userSourceInfoType, version)
        {
            CustomContainer = customContainer;
            UserSourceInfoType = userSourceInfoType ?? "Container";
        }

        /// <summary> Custom container payload. </summary>
        public CustomContainer CustomContainer { get; set; }
    }
}
