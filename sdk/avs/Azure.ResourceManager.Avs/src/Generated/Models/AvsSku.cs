// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The resource model definition representing SKU. </summary>
    public partial class AvsSku
    {
        /// <summary> Initializes a new instance of AvsSku. </summary>
        /// <param name="name"> The name of the SKU. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public AvsSku(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> The name of the SKU. </summary>
        public string Name { get; set; }
    }
}
