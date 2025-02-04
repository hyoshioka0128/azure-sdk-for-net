// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The definition of a prediction distribution. </summary>
    public partial class PredictionDistributionDefinitionDistributionsItem
    {
        /// <summary> Initializes a new instance of PredictionDistributionDefinitionDistributionsItem. </summary>
        internal PredictionDistributionDefinitionDistributionsItem()
        {
        }

        /// <summary> Initializes a new instance of PredictionDistributionDefinitionDistributionsItem. </summary>
        /// <param name="scoreThreshold"> Score threshold. </param>
        /// <param name="positives"> Number of positives. </param>
        /// <param name="negatives"> Number of negatives. </param>
        /// <param name="positivesAboveThreshold"> Number of positives above threshold. </param>
        /// <param name="negativesAboveThreshold"> Number of negatives above threshold. </param>
        internal PredictionDistributionDefinitionDistributionsItem(int? scoreThreshold, long? positives, long? negatives, long? positivesAboveThreshold, long? negativesAboveThreshold)
        {
            ScoreThreshold = scoreThreshold;
            Positives = positives;
            Negatives = negatives;
            PositivesAboveThreshold = positivesAboveThreshold;
            NegativesAboveThreshold = negativesAboveThreshold;
        }

        /// <summary> Score threshold. </summary>
        public int? ScoreThreshold { get; }
        /// <summary> Number of positives. </summary>
        public long? Positives { get; }
        /// <summary> Number of negatives. </summary>
        public long? Negatives { get; }
        /// <summary> Number of positives above threshold. </summary>
        public long? PositivesAboveThreshold { get; }
        /// <summary> Number of negatives above threshold. </summary>
        public long? NegativesAboveThreshold { get; }
    }
}
