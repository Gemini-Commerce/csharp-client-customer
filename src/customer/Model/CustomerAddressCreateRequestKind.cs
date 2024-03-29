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
    /// Defines customerAddressCreateRequestKind
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerAddressCreateRequestKind
    {
        /// <summary>
        /// Enum SHIPPING for value: SHIPPING
        /// </summary>
        [EnumMember(Value = "SHIPPING")]
        SHIPPING = 1,

        /// <summary>
        /// Enum BILLING for value: BILLING
        /// </summary>
        [EnumMember(Value = "BILLING")]
        BILLING = 2,

        /// <summary>
        /// Enum BOTH for value: BOTH
        /// </summary>
        [EnumMember(Value = "BOTH")]
        BOTH = 3
    }

}
