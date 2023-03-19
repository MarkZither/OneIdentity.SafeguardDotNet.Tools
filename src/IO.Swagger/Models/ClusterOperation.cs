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
        /// Gets or Sets ClusterOperation
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ClusterOperation
        {
            /// <summary>
            /// Enum NoneEnum for None
            /// </summary>
            [EnumMember(Value = "None")]
            NoneEnum = 0,
            /// <summary>
            /// Enum EnrollEnum for Enroll
            /// </summary>
            [EnumMember(Value = "Enroll")]
            EnrollEnum = 1,
            /// <summary>
            /// Enum RemoveEnum for Remove
            /// </summary>
            [EnumMember(Value = "Remove")]
            RemoveEnum = 2,
            /// <summary>
            /// Enum FailoverEnum for Failover
            /// </summary>
            [EnumMember(Value = "Failover")]
            FailoverEnum = 3,
            /// <summary>
            /// Enum ResetEnum for Reset
            /// </summary>
            [EnumMember(Value = "Reset")]
            ResetEnum = 4,
            /// <summary>
            /// Enum PatchEnum for Patch
            /// </summary>
            [EnumMember(Value = "Patch")]
            PatchEnum = 5,
            /// <summary>
            /// Enum PatchDistributionEnum for PatchDistribution
            /// </summary>
            [EnumMember(Value = "PatchDistribution")]
            PatchDistributionEnum = 6,
            /// <summary>
            /// Enum UpdateIpEnum for UpdateIp
            /// </summary>
            [EnumMember(Value = "UpdateIp")]
            UpdateIpEnum = 7,
            /// <summary>
            /// Enum AuditLogSyncEnum for AuditLogSync
            /// </summary>
            [EnumMember(Value = "AuditLogSync")]
            AuditLogSyncEnum = 8,
            /// <summary>
            /// Enum JoinSessionsModuleEnum for JoinSessionsModule
            /// </summary>
            [EnumMember(Value = "JoinSessionsModule")]
            JoinSessionsModuleEnum = 9,
            /// <summary>
            /// Enum AuditLogPurgeArchiveEnum for AuditLogPurgeArchive
            /// </summary>
            [EnumMember(Value = "AuditLogPurgeArchive")]
            AuditLogPurgeArchiveEnum = 10        }
}
