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
        /// Gets or Sets TaggingGroupingObjectType
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TaggingGroupingObjectType
        {
            /// <summary>
            /// Enum AssetEnum for Asset
            /// </summary>
            [EnumMember(Value = "Asset")]
            AssetEnum = 0,
            /// <summary>
            /// Enum AssetAccountEnum for AssetAccount
            /// </summary>
            [EnumMember(Value = "AssetAccount")]
            AssetAccountEnum = 1,
            /// <summary>
            /// Enum AssetDiscoveryScheduleEnum for AssetDiscoverySchedule
            /// </summary>
            [EnumMember(Value = "AssetDiscoverySchedule")]
            AssetDiscoveryScheduleEnum = 2,
            /// <summary>
            /// Enum AssetAccountDiscoveryScheduleEnum for AssetAccountDiscoverySchedule
            /// </summary>
            [EnumMember(Value = "AssetAccountDiscoverySchedule")]
            AssetAccountDiscoveryScheduleEnum = 3,
            /// <summary>
            /// Enum DirectoryAccountEnum for DirectoryAccount
            /// </summary>
            [EnumMember(Value = "DirectoryAccount")]
            DirectoryAccountEnum = 4        }
}
