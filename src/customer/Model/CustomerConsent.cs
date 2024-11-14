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
    /// CustomerConsent
    /// </summary>
    [DataContract(Name = "customerConsent")]
    public partial class CustomerConsent : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public CustomerConsentSource? Source { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerConsent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="grn">grn.</param>
        /// <param name="preferences">preferences.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="source">source.</param>
        /// <param name="author">author.</param>
        /// <param name="subjectId">subjectId.</param>
        public CustomerConsent(string id = default(string), string grn = default(string), Dictionary<string, bool> preferences = default(Dictionary<string, bool>), DateTime createdAt = default(DateTime), CustomerConsentSource? source = default(CustomerConsentSource?), string author = default(string), string subjectId = default(string))
        {
            this.Id = id;
            this.Grn = grn;
            this.Preferences = preferences;
            this.CreatedAt = createdAt;
            this.Source = source;
            this.Author = author;
            this.SubjectId = subjectId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Grn
        /// </summary>
        [DataMember(Name = "grn", EmitDefaultValue = false)]
        public string Grn { get; set; }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name = "preferences", EmitDefaultValue = false)]
        public Dictionary<string, bool> Preferences { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", EmitDefaultValue = false)]
        public string Author { get; set; }

        /// <summary>
        /// Gets or Sets SubjectId
        /// </summary>
        [DataMember(Name = "subjectId", EmitDefaultValue = false)]
        public string SubjectId { get; set; }

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
            sb.Append("class CustomerConsent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Grn: ").Append(Grn).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  SubjectId: ").Append(SubjectId).Append("\n");
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
