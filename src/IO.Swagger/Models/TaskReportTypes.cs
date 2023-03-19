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
        /// Types of task reports
        /// </summary>
        /// <value>Types of task reports</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TaskReportTypes
        {
            /// <summary>
            /// Enum FailedAccountTasksEnum for FailedAccountTasks
            /// </summary>
            [EnumMember(Value = "FailedAccountTasks")]
            FailedAccountTasksEnum = 0,
            /// <summary>
            /// Enum FailedAssetTasksEnum for FailedAssetTasks
            /// </summary>
            [EnumMember(Value = "FailedAssetTasks")]
            FailedAssetTasksEnum = 1        }
}