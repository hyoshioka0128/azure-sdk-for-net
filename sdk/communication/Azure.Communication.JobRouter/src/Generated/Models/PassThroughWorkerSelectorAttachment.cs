// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.JobRouter
{
    /// <summary> Attaches a label selector where the value is pass through from the job label with the same key. </summary>
    public partial class PassThroughWorkerSelectorAttachment : WorkerSelectorAttachment
    {
        /// <summary> Initializes a new instance of PassThroughWorkerSelectorAttachment. </summary>
        /// <param name="key"> The label key to query against. </param>
        /// <param name="labelOperator"> Describes how the value of the label is compared to the value pass through. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public PassThroughWorkerSelectorAttachment(string key, LabelOperator labelOperator)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            Key = key;
            LabelOperator = labelOperator;
            Kind = "pass-through";
        }

        /// <summary> Initializes a new instance of PassThroughWorkerSelectorAttachment. </summary>
        /// <param name="kind"> The type discriminator describing the type of label selector attachment. </param>
        /// <param name="key"> The label key to query against. </param>
        /// <param name="labelOperator"> Describes how the value of the label is compared to the value pass through. </param>
        /// <param name="ttlSeconds"> Describes how long the attached label selector is valid in seconds. </param>
        internal PassThroughWorkerSelectorAttachment(string kind, string key, LabelOperator labelOperator, double? ttlSeconds) : base(kind)
        {
            Key = key;
            LabelOperator = labelOperator;
            _ttlSeconds = ttlSeconds;
            Kind = kind ?? "pass-through";
        }

        /// <summary> The label key to query against. </summary>
        public string Key { get; set; }
        /// <summary> Describes how the value of the label is compared to the value pass through. </summary>
        public LabelOperator LabelOperator { get; set; }
    }
}
