// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Mount state. </summary>
    public readonly partial struct MountState : IEquatable<MountState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MountState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MountState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MountRequestedValue = "MountRequested";
        private const string MountedValue = "Mounted";
        private const string MountFailedValue = "MountFailed";
        private const string UnmountRequestedValue = "UnmountRequested";
        private const string UnmountFailedValue = "UnmountFailed";
        private const string UnmountedValue = "Unmounted";

        /// <summary> MountRequested. </summary>
        public static MountState MountRequested { get; } = new MountState(MountRequestedValue);
        /// <summary> Mounted. </summary>
        public static MountState Mounted { get; } = new MountState(MountedValue);
        /// <summary> MountFailed. </summary>
        public static MountState MountFailed { get; } = new MountState(MountFailedValue);
        /// <summary> UnmountRequested. </summary>
        public static MountState UnmountRequested { get; } = new MountState(UnmountRequestedValue);
        /// <summary> UnmountFailed. </summary>
        public static MountState UnmountFailed { get; } = new MountState(UnmountFailedValue);
        /// <summary> Unmounted. </summary>
        public static MountState Unmounted { get; } = new MountState(UnmountedValue);
        /// <summary> Determines if two <see cref="MountState"/> values are the same. </summary>
        public static bool operator ==(MountState left, MountState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MountState"/> values are not the same. </summary>
        public static bool operator !=(MountState left, MountState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MountState"/>. </summary>
        public static implicit operator MountState(string value) => new MountState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MountState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MountState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
