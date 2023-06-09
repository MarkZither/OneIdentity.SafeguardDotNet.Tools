/*
 * Safeguard Core API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v4
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
        /// <summary>
        /// Gets or Sets DiscoveredServiceAccountStatus
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum DiscoveredServiceAccountStatus
        {
            /// <summary>
            /// Enum NoneEnum for None
            /// </summary>
            [EnumMember(Value = "None")]
            NoneEnum = 0,
            /// <summary>
            /// Enum IgnoredEnum for Ignored
            /// </summary>
            [EnumMember(Value = "Ignored")]
            IgnoredEnum = 1,
            /// <summary>
            /// Enum ManagedEnum for Managed
            /// </summary>
            [EnumMember(Value = "Managed")]
            ManagedEnum = 2,
            /// <summary>
            /// Enum DisabledEnum for Disabled
            /// </summary>
            [EnumMember(Value = "Disabled")]
            DisabledEnum = 3,
            /// <summary>
            /// Enum RestrictedEnum for Restricted
            /// </summary>
            [EnumMember(Value = "Restricted")]
            RestrictedEnum = 4        }
}
