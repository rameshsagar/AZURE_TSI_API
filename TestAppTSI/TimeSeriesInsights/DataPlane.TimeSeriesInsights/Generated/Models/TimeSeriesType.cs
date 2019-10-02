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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Time series type defines variables or formulas for doing computation on
    /// events associated with time series instances. Each time series instance
    /// is associated with exactly one type. A type can have one or more
    /// variables. For example, a time series instance might be of type
    /// Temperature Sensor, which consists of the variables avg temperature,
    /// min temperature, and max temperature.
    /// </summary>
    public partial class TimeSeriesType
    {
        /// <summary>
        /// Initializes a new instance of the TimeSeriesType class.
        /// </summary>
        public TimeSeriesType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TimeSeriesType class.
        /// </summary>
        /// <param name="name">User-given unique name for the type. Mutable,
        /// not null.</param>
        /// <param name="variables">Different variables associated with the
        /// type. Not empty, not null.</param>
        /// <param name="id">Unique type identifier that is immutable. Can be
        /// null on create or update requests, and then server generates the
        /// ID. Not null on get and delete operations.</param>
        /// <param name="description">Description of the type. May be
        /// null.</param>
        public TimeSeriesType(string name, IDictionary<string, NumericVariable> variables, System.Guid? id = default(System.Guid?), string description = default(string))
        {
            Id = id;
            Name = name;
            Description = description;
            Variables = variables;
            CustomInit();
        }


        //public TimeSeriesType(string name, IDictionary<string, AggregateVariable> variables, System.Guid? id = default(System.Guid?), string description = default(string))
        //{
        //    Id = id;
        //    Name = name;
        //    Description = description;
        //    Variables = variables;
        //    CustomInit();
        //}


        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique type identifier that is immutable. Can be null
        /// on create or update requests, and then server generates the ID. Not
        /// null on get and delete operations.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets user-given unique name for the type. Mutable, not
        /// null.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description of the type. May be null.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets different variables associated with the type. Not
        /// empty, not null.
        /// </summary>
        [JsonProperty(PropertyName = "variables")]
        public IDictionary<string, NumericVariable> Variables { get; set; }

       


        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            //if (Variables == null)
            //{
            //    throw new ValidationException(ValidationRules.CannotBeNull, "Variables");
            //}
            //if (Variables != null)
            //{
            //    foreach (var valueElement in Variables.Values)
            //    {
            //        if (valueElement != null)
            //        {
            //            valueElement.Validate();
            //        }
            //    }
            //}
        }
    }
}
