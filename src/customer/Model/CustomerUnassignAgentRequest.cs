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
    /// CustomerUnassignAgentRequest
    /// </summary>
    [DataContract(Name = "customerUnassignAgentRequest")]
    public partial class CustomerUnassignAgentRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerUnassignAgentRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="agentGrn">agentGrn.</param>
        /// <param name="customerIds">customerIds.</param>
        public CustomerUnassignAgentRequest(string tenantId = default(string), string agentGrn = default(string), List<string> customerIds = default(List<string>))
        {
            this.TenantId = tenantId;
            this.AgentGrn = agentGrn;
            this.CustomerIds = customerIds;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets AgentGrn
        /// </summary>
        [DataMember(Name = "agentGrn", EmitDefaultValue = false)]
        public string AgentGrn { get; set; }

        /// <summary>
        /// Gets or Sets CustomerIds
        /// </summary>
        [DataMember(Name = "customerIds", EmitDefaultValue = false)]
        public List<string> CustomerIds { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerUnassignAgentRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  AgentGrn: ").Append(AgentGrn).Append("\n");
            sb.Append("  CustomerIds: ").Append(CustomerIds).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
