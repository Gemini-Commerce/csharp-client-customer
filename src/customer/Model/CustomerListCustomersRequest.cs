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
    /// CustomerListCustomersRequest
    /// </summary>
    [DataContract(Name = "customerListCustomersRequest")]
    public partial class CustomerListCustomersRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerListCustomersRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="pageToken">pageToken.</param>
        /// <param name="filters">filters.</param>
        /// <param name="filterMask">filterMask.</param>
        public CustomerListCustomersRequest(string tenantId = default(string), long pageSize = default(long), string pageToken = default(string), CustomerListCustomersRequestFilter filters = default(CustomerListCustomersRequestFilter), string filterMask = default(string))
        {
            this.TenantId = tenantId;
            this.PageSize = pageSize;
            this.PageToken = pageToken;
            this.Filters = filters;
            this.FilterMask = filterMask;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public long PageSize { get; set; }

        /// <summary>
        /// Gets or Sets PageToken
        /// </summary>
        [DataMember(Name = "pageToken", EmitDefaultValue = false)]
        public string PageToken { get; set; }

        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name = "filters", EmitDefaultValue = false)]
        public CustomerListCustomersRequestFilter Filters { get; set; }

        /// <summary>
        /// Gets or Sets FilterMask
        /// </summary>
        [DataMember(Name = "filterMask", EmitDefaultValue = false)]
        public string FilterMask { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerListCustomersRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageToken: ").Append(PageToken).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  FilterMask: ").Append(FilterMask).Append("\n");
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