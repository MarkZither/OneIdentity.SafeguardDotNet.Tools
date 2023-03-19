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
        /// Type of operation to perform on a list
        /// </summary>
        /// <value>Type of operation to perform on a list</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ListOperation
        {
            /// <summary>
            /// Enum AddEnum for Add
            /// </summary>
            [EnumMember(Value = "Add")]
            AddEnum = 0,
            /// <summary>
            /// Enum RemoveEnum for Remove
            /// </summary>
            [EnumMember(Value = "Remove")]
            RemoveEnum = 1        }
}