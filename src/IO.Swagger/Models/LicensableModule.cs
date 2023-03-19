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
        /// Gets or Sets LicensableModule
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum LicensableModule
        {
            /// <summary>
            /// Enum PasswordManagementEnum for PasswordManagement
            /// </summary>
            [EnumMember(Value = "PasswordManagement")]
            PasswordManagementEnum = 0,
            /// <summary>
            /// Enum SessionManagementEnum for SessionManagement
            /// </summary>
            [EnumMember(Value = "SessionManagement")]
            SessionManagementEnum = 1,
            /// <summary>
            /// Enum SecretsBrokerEnum for SecretsBroker
            /// </summary>
            [EnumMember(Value = "SecretsBroker")]
            SecretsBrokerEnum = 2        }
}
