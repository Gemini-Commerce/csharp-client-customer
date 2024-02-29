/*
 * CDP Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = customer.Client.OpenAPIDateConverter;

namespace customer.Model
{
    /// <summary>
    /// CustomerListCustomersRequestFilter
    /// </summary>
    [DataContract(Name = "customerListCustomersRequestFilter")]
    public partial class CustomerListCustomersRequestFilter : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerListCustomersRequestFilter" /> class.
        /// </summary>
        /// <param name="genders">genders.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="countries">countries.</param>
        /// <param name="agentGrn">agentGrn.</param>
        public CustomerListCustomersRequestFilter(List<string> genders = default(List<string>), List<ListCustomersRequestFilterDate> createdAt = default(List<ListCustomersRequestFilterDate>), List<string> countries = default(List<string>), string agentGrn = default(string))
        {
            this.Genders = genders;
            this.CreatedAt = createdAt;
            this.Countries = countries;
            this.AgentGrn = agentGrn;
        }

        /// <summary>
        /// Gets or Sets Genders
        /// </summary>
        [DataMember(Name = "genders", EmitDefaultValue = false)]
        public List<string> Genders { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public List<ListCustomersRequestFilterDate> CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Countries
        /// </summary>
        [DataMember(Name = "countries", EmitDefaultValue = false)]
        public List<string> Countries { get; set; }

        /// <summary>
        /// Gets or Sets AgentGrn
        /// </summary>
        [DataMember(Name = "agentGrn", EmitDefaultValue = false)]
        public string AgentGrn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerListCustomersRequestFilter {\n");
            sb.Append("  Genders: ").Append(Genders).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  AgentGrn: ").Append(AgentGrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
