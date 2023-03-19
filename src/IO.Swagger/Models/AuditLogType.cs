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
        /// Type of audit log
        /// </summary>
        /// <value>Type of audit log</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AuditLogType
        {
            /// <summary>
            /// Enum LoginsEnum for Logins
            /// </summary>
            [EnumMember(Value = "Logins")]
            LoginsEnum = 0,
            /// <summary>
            /// Enum AccessRequestsEnum for AccessRequests
            /// </summary>
            [EnumMember(Value = "AccessRequests")]
            AccessRequestsEnum = 1,
            /// <summary>
            /// Enum LicensesEnum for Licenses
            /// </summary>
            [EnumMember(Value = "Licenses")]
            LicensesEnum = 2,
            /// <summary>
            /// Enum PatchesEnum for Patches
            /// </summary>
            [EnumMember(Value = "Patches")]
            PatchesEnum = 3,
            /// <summary>
            /// Enum ObjectChangesEnum for ObjectChanges
            /// </summary>
            [EnumMember(Value = "ObjectChanges")]
            ObjectChangesEnum = 4,
            /// <summary>
            /// Enum PasswordsEnum for Passwords
            /// </summary>
            [EnumMember(Value = "Passwords")]
            PasswordsEnum = 5,
            /// <summary>
            /// Enum DiscoveryEnum for Discovery
            /// </summary>
            [EnumMember(Value = "Discovery")]
            DiscoveryEnum = 6,
            /// <summary>
            /// Enum ArchivesEnum for Archives
            /// </summary>
            [EnumMember(Value = "Archives")]
            ArchivesEnum = 7,
            /// <summary>
            /// Enum AppliancesEnum for Appliances
            /// </summary>
            [EnumMember(Value = "Appliances")]
            AppliancesEnum = 8,
            /// <summary>
            /// Enum SearchEnum for Search
            /// </summary>
            [EnumMember(Value = "Search")]
            SearchEnum = 9,
            /// <summary>
            /// Enum RetentionEnum for Retention
            /// </summary>
            [EnumMember(Value = "Retention")]
            RetentionEnum = 10,
            /// <summary>
            /// Enum PlatformScriptsEnum for PlatformScripts
            /// </summary>
            [EnumMember(Value = "PlatformScripts")]
            PlatformScriptsEnum = 11        }
}
