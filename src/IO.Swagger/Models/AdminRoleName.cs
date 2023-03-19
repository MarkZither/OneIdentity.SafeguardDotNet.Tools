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
        /// Names of admin roles a user can belong too
        /// </summary>
        /// <value>Names of admin roles a user can belong too</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AdminRoleName
        {
            /// <summary>
            /// Enum GlobalAdminEnum for GlobalAdmin
            /// </summary>
            [EnumMember(Value = "GlobalAdmin")]
            GlobalAdminEnum = 0,
            /// <summary>
            /// Enum AuditorEnum for Auditor
            /// </summary>
            [EnumMember(Value = "Auditor")]
            AuditorEnum = 1,
            /// <summary>
            /// Enum AssetAdminEnum for AssetAdmin
            /// </summary>
            [EnumMember(Value = "AssetAdmin")]
            AssetAdminEnum = 2,
            /// <summary>
            /// Enum ApplianceAdminEnum for ApplianceAdmin
            /// </summary>
            [EnumMember(Value = "ApplianceAdmin")]
            ApplianceAdminEnum = 3,
            /// <summary>
            /// Enum PolicyAdminEnum for PolicyAdmin
            /// </summary>
            [EnumMember(Value = "PolicyAdmin")]
            PolicyAdminEnum = 4,
            /// <summary>
            /// Enum UserAdminEnum for UserAdmin
            /// </summary>
            [EnumMember(Value = "UserAdmin")]
            UserAdminEnum = 5,
            /// <summary>
            /// Enum HelpdeskAdminEnum for HelpdeskAdmin
            /// </summary>
            [EnumMember(Value = "HelpdeskAdmin")]
            HelpdeskAdminEnum = 6,
            /// <summary>
            /// Enum OperationsAdminEnum for OperationsAdmin
            /// </summary>
            [EnumMember(Value = "OperationsAdmin")]
            OperationsAdminEnum = 7,
            /// <summary>
            /// Enum ApplicationAuditorEnum for ApplicationAuditor
            /// </summary>
            [EnumMember(Value = "ApplicationAuditor")]
            ApplicationAuditorEnum = 8,
            /// <summary>
            /// Enum SystemAuditorEnum for SystemAuditor
            /// </summary>
            [EnumMember(Value = "SystemAuditor")]
            SystemAuditorEnum = 9        }
}