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
    /// Numeric variable represents a single continuous numeric signal that can
    /// be reconstructed using interpolation.
    /// </summary>
    [Newtonsoft.Json.JsonObject("numeric")]
    public partial class NumericVariable : Variable
    {
        /// <summary>
        /// Initializes a new instance of the NumericVariable class.
        /// </summary>
        public NumericVariable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NumericVariable class.
        /// </summary>
        /// <param name="value">Value time series expression is used to
        /// represent the value of the signal that is going to be aggregated or
        /// interpolated. For example, temperature values from the event is
        /// represented like this: "$event.Temperature.Double".</param>
        /// <param name="aggregation">Aggregation time series expression when
        /// kind is "numeric" is used to represent the aggregation that needs
        /// to be performed on the $value expression. This requires $value to
        /// be specified and can only use $value inside the aggregate
        /// functions. For example, aggregation for calculating minimum of the
        /// $value is written as: "min($value)".</param>
        /// <param name="filter">Filter over the events that restricts the
        /// number of events being considered for computation. Example:
        /// "$event.Status.String='Good'". Optional.</param>


        public NumericVariable(Tsx aggregation, Tsx value = default(Tsx), Tsx filter = default(Tsx))


        {
            Value = value;
            Aggregation = aggregation;
            Filter = filter;
            CustomInit();

        }



        public NumericVariable(Tsx aggregation, string kind, Tsx value = default(Tsx),Tsx filter = default(Tsx))
           
        {
            Kind = kind;
            string numeric = "numeric";
            string aggregate = "aggregate";

            if (Kind.Equals(numeric))
            {
              Aggregation = aggregation;
              Value = value;
              Filter = filter;
              CustomInit();
            }

            if (Kind.Equals(aggregate))
            {
                Aggregation = aggregation;
                Filter = filter;
                CustomInit();
            }


        }








        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value time series expression is used to represent the
        /// value of the signal that is going to be aggregated or interpolated.
        /// For example, temperature values from the event is represented like
        /// this: "$event.Temperature.Double".
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public Tsx Value { get; set; }

        /// <summary>
        /// Gets or sets aggregation time series expression when kind is
        /// "numeric" is used to represent the aggregation that needs to be
        /// performed on the $value expression. This requires $value to be
        /// specified and can only use $value inside the aggregate functions.
        /// For example, aggregation for calculating minimum of the $value is
        /// written as: "min($value)".
        /// </summary>
        [JsonProperty(PropertyName = "aggregation")]
        public Tsx Aggregation { get; set; }

        [JsonProperty(PropertyName = "kind")]
        public String Kind { get; set; }

        [JsonProperty(PropertyName = "filter")]
        public Tsx Filter { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            Validate();
            //if (Value == null)
            //{
            //    throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            //}
            if (Aggregation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Aggregation");
            }
            if (Value != null)
            {
                Value.Validate();
            }
            if (Aggregation != null)
            {
                Aggregation.Validate();
            }
        }
    }
}
