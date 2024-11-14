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
    /// CustomerCreateRequest
    /// </summary>
    [DataContract(Name = "customerCreateRequest")]
    public partial class CustomerCreateRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCreateRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="em">em.</param>
        /// <param name="name">name.</param>
        /// <param name="surname">surname.</param>
        /// <param name="email">email.</param>
        /// <param name="birthdate">birthdate.</param>
        /// <param name="gender">gender.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="source">source.</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="nationality">nationality.</param>
        /// <param name="groups">groups.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="newsletters">newsletters.</param>
        /// <param name="doNotNotify">doNotNotify.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="migratedPassword">migratedPassword.</param>
        /// <param name="market">market.</param>
        /// <param name="preferredLocale">preferredLocale.</param>
        /// <param name="taxCode">taxCode.</param>
        /// <param name="certifiedEmail">certifiedEmail.</param>
        /// <param name="sdiCode">sdiCode.</param>
        /// <param name="fiscalCode">fiscalCode.</param>
        /// <param name="companyName">companyName.</param>
        /// <param name="additionalInfo">additionalInfo.</param>
        /// <param name="externalIds">externalIds.</param>
        /// <param name="consent">consent.</param>
        /// <param name="aggregationId">aggregationId.</param>
        public CustomerCreateRequest(string tenantId = default(string), CustomerEMFields em = default(CustomerEMFields), string name = default(string), string surname = default(string), string email = default(string), DateTime birthdate = default(DateTime), string gender = default(string), bool enabled = default(bool), string source = default(string), List<CustomerAddressEntity> addresses = default(List<CustomerAddressEntity>), string phoneNumber = default(string), string nationality = default(string), List<string> groups = default(List<string>), bool deleted = default(bool), List<CustomerNewsletterRequest> newsletters = default(List<CustomerNewsletterRequest>), bool doNotNotify = default(bool), Dictionary<string, ProtobufAny> attributes = default(Dictionary<string, ProtobufAny>), CustomerPassword migratedPassword = default(CustomerPassword), string market = default(string), string preferredLocale = default(string), string taxCode = default(string), string certifiedEmail = default(string), string sdiCode = default(string), string fiscalCode = default(string), string companyName = default(string), Object additionalInfo = default(Object), Dictionary<string, string> externalIds = default(Dictionary<string, string>), CustomerCreateConsentRequest consent = default(CustomerCreateConsentRequest), string aggregationId = default(string))
        {
            this.TenantId = tenantId;
            this.Em = em;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Birthdate = birthdate;
            this.Gender = gender;
            this.Enabled = enabled;
            this.Source = source;
            this.Addresses = addresses;
            this.PhoneNumber = phoneNumber;
            this.Nationality = nationality;
            this.Groups = groups;
            this.Deleted = deleted;
            this.Newsletters = newsletters;
            this.DoNotNotify = doNotNotify;
            this.Attributes = attributes;
            this.MigratedPassword = migratedPassword;
            this.Market = market;
            this.PreferredLocale = preferredLocale;
            this.TaxCode = taxCode;
            this.CertifiedEmail = certifiedEmail;
            this.SdiCode = sdiCode;
            this.FiscalCode = fiscalCode;
            this.CompanyName = companyName;
            this.AdditionalInfo = additionalInfo;
            this.ExternalIds = externalIds;
            this.Consent = consent;
            this.AggregationId = aggregationId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets Em
        /// </summary>
        [DataMember(Name = "em", EmitDefaultValue = false)]
        public CustomerEMFields Em { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name = "surname", EmitDefaultValue = false)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Birthdate
        /// </summary>
        [DataMember(Name = "birthdate", EmitDefaultValue = false)]
        public DateTime Birthdate { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<CustomerAddressEntity> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name = "phoneNumber", EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets Nationality
        /// </summary>
        [DataMember(Name = "nationality", EmitDefaultValue = false)]
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or Sets Newsletters
        /// </summary>
        [DataMember(Name = "newsletters", EmitDefaultValue = false)]
        public List<CustomerNewsletterRequest> Newsletters { get; set; }

        /// <summary>
        /// Gets or Sets DoNotNotify
        /// </summary>
        [DataMember(Name = "doNotNotify", EmitDefaultValue = true)]
        public bool DoNotNotify { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public Dictionary<string, ProtobufAny> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets MigratedPassword
        /// </summary>
        [DataMember(Name = "migratedPassword", EmitDefaultValue = false)]
        public CustomerPassword MigratedPassword { get; set; }

        /// <summary>
        /// Gets or Sets Market
        /// </summary>
        [DataMember(Name = "market", EmitDefaultValue = false)]
        public string Market { get; set; }

        /// <summary>
        /// Gets or Sets PreferredLocale
        /// </summary>
        [DataMember(Name = "preferredLocale", EmitDefaultValue = false)]
        public string PreferredLocale { get; set; }

        /// <summary>
        /// Gets or Sets TaxCode
        /// </summary>
        [DataMember(Name = "taxCode", EmitDefaultValue = false)]
        public string TaxCode { get; set; }

        /// <summary>
        /// Gets or Sets CertifiedEmail
        /// </summary>
        [DataMember(Name = "certifiedEmail", EmitDefaultValue = false)]
        public string CertifiedEmail { get; set; }

        /// <summary>
        /// Gets or Sets SdiCode
        /// </summary>
        [DataMember(Name = "sdiCode", EmitDefaultValue = false)]
        public string SdiCode { get; set; }

        /// <summary>
        /// Gets or Sets FiscalCode
        /// </summary>
        [DataMember(Name = "fiscalCode", EmitDefaultValue = false)]
        public string FiscalCode { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name = "companyName", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalInfo
        /// </summary>
        [DataMember(Name = "additionalInfo", EmitDefaultValue = false)]
        public Object AdditionalInfo { get; set; }

        /// <summary>
        /// Gets or Sets ExternalIds
        /// </summary>
        [DataMember(Name = "externalIds", EmitDefaultValue = false)]
        public Dictionary<string, string> ExternalIds { get; set; }

        /// <summary>
        /// Gets or Sets Consent
        /// </summary>
        [DataMember(Name = "consent", EmitDefaultValue = false)]
        public CustomerCreateConsentRequest Consent { get; set; }

        /// <summary>
        /// Gets or Sets AggregationId
        /// </summary>
        [DataMember(Name = "aggregationId", EmitDefaultValue = false)]
        public string AggregationId { get; set; }

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
            sb.Append("class CustomerCreateRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Em: ").Append(Em).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Birthdate: ").Append(Birthdate).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Newsletters: ").Append(Newsletters).Append("\n");
            sb.Append("  DoNotNotify: ").Append(DoNotNotify).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  MigratedPassword: ").Append(MigratedPassword).Append("\n");
            sb.Append("  Market: ").Append(Market).Append("\n");
            sb.Append("  PreferredLocale: ").Append(PreferredLocale).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  CertifiedEmail: ").Append(CertifiedEmail).Append("\n");
            sb.Append("  SdiCode: ").Append(SdiCode).Append("\n");
            sb.Append("  FiscalCode: ").Append(FiscalCode).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("  ExternalIds: ").Append(ExternalIds).Append("\n");
            sb.Append("  Consent: ").Append(Consent).Append("\n");
            sb.Append("  AggregationId: ").Append(AggregationId).Append("\n");
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
