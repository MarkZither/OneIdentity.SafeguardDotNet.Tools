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
        /// Gets or Sets SupportedReportDataSerializationFormat
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum SupportedReportDataSerializationFormat
        {
            /// <summary>
            /// Enum JsonEnum for Json
            /// </summary>
            [EnumMember(Value = "Json")]
            JsonEnum = 0,
            /// <summary>
            /// Enum CsvEnum for Csv
            /// </summary>
            [EnumMember(Value = "Csv")]
            CsvEnum = 1        }
}
