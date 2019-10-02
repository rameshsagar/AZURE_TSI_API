// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.TimeSeriesInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System;
    using System.Linq;

    /// <summary>
    /// Time series expression (TSX) written as a single string. Examples:
    /// "$event.Status.String='Good'", "avg($event.Temperature)". Refer to the
    /// documentation on how to write time series expressions.
    /// </summary>
    public partial class Tsx
    {
        /// <summary>
        /// Initializes a new instance of the Tsx class.
        /// </summary>
        public Tsx()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Tsx class.
        /// </summary>
        /// <param name="tsxProperty">Time series expression (TSX) written as a
        /// single string. Examples: "$event.Status.String='Good'",
        /// "avg($event.Temperature)". Refer to the documentation on how to
        /// write time series expressions.</param>
        public Tsx(string tsxProperty)
        {
            TsxProperty = tsxProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets time series expression (TSX) written as a single
        /// string. Examples: "$event.Status.String='Good'",
        /// "avg($event.Temperature)". Refer to the documentation on how to
        /// write time series expressions.
        /// </summary>
        [JsonProperty(PropertyName = "tsx")]
        public string TsxProperty { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TsxProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TsxProperty");
            }
        }

        public static implicit operator Tsx(string v)
        {
            throw new NotImplementedException();
        }
    }
}
