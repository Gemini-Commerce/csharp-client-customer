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
    /// CustomerUpdateSubscriberRequest
    /// </summary>
    [DataContract(Name = "customerUpdateSubscriberRequest")]
    public partial class CustomerUpdateSubscriberRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerUpdateSubscriberRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="subscriber">subscriber.</param>
        /// <param name="fieldMask">fieldMask.</param>
        public CustomerUpdateSubscriberRequest(string tenantId = default(string), CustomerSubscriberResponseWithNewsletterRequest subscriber = default(CustomerSubscriberResponseWithNewsletterRequest), string fieldMask = default(string))
        {
            this.TenantId = tenantId;
            this.Subscriber = subscriber;
            this.FieldMask = fieldMask;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets Subscriber
        /// </summary>
        [DataMember(Name = "subscriber", EmitDefaultValue = false)]
        public CustomerSubscriberResponseWithNewsletterRequest Subscriber { get; set; }

        /// <summary>
        /// Gets or Sets FieldMask
        /// </summary>
        [DataMember(Name = "fieldMask", EmitDefaultValue = false)]
        public string FieldMask { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerUpdateSubscriberRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Subscriber: ").Append(Subscriber).Append("\n");
            sb.Append("  FieldMask: ").Append(FieldMask).Append("\n");
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
