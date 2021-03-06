// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines weights on index fields for which matches should boost scoring
    /// in search queries.
    /// </summary>
    public partial class TextWeights
    {
        /// <summary>
        /// Initializes a new instance of the TextWeights class.
        /// </summary>
        public TextWeights()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TextWeights class.
        /// </summary>
        /// <param name="weights">The dictionary of per-field weights to boost
        /// document scoring. The keys are field names and the values are the
        /// weights for each field.</param>
        public TextWeights(IDictionary<string, double> weights)
        {
            Weights = weights;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the dictionary of per-field weights to boost document
        /// scoring. The keys are field names and the values are the weights
        /// for each field.
        /// </summary>
        [JsonProperty(PropertyName = "weights")]
        public IDictionary<string, double> Weights { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Weights == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Weights");
            }
        }
    }
}
