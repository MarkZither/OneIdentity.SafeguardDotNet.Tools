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
        /// Gets or Sets ServiceAccountCredentialType
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ServiceAccountCredentialType
        {
            /// <summary>
            /// Enum NoneEnum for None
            /// </summary>
            [EnumMember(Value = "None")]
            NoneEnum = 0,
            /// <summary>
            /// Enum PasswordEnum for Password
            /// </summary>
            [EnumMember(Value = "Password")]
            PasswordEnum = 1,
            /// <summary>
            /// Enum SshKeyEnum for SshKey
            /// </summary>
            [EnumMember(Value = "SshKey")]
            SshKeyEnum = 2,
            /// <summary>
            /// Enum DirectoryPasswordEnum for DirectoryPassword
            /// </summary>
            [EnumMember(Value = "DirectoryPassword")]
            DirectoryPasswordEnum = 3,
            /// <summary>
            /// Enum LocalHostPasswordEnum for LocalHostPassword
            /// </summary>
            [EnumMember(Value = "LocalHostPassword")]
            LocalHostPasswordEnum = 4,
            /// <summary>
            /// Enum AccessKeyEnum for AccessKey
            /// </summary>
            [EnumMember(Value = "AccessKey")]
            AccessKeyEnum = 5,
            /// <summary>
            /// Enum AccountPasswordEnum for AccountPassword
            /// </summary>
            [EnumMember(Value = "AccountPassword")]
            AccountPasswordEnum = 6,
            /// <summary>
            /// Enum CustomEnum for Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            CustomEnum = 7,
            /// <summary>
            /// Enum StarlingConnectEnum for StarlingConnect
            /// </summary>
            [EnumMember(Value = "StarlingConnect")]
            StarlingConnectEnum = 8        }
}
