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
        /// Type of network address
        /// </summary>
        /// <value>Type of network address</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NetworkAddressFamily
        {
            /// <summary>
            /// Enum Ipv4Enum for Ipv4
            /// </summary>
            [EnumMember(Value = "Ipv4")]
            Ipv4Enum = 0,
            /// <summary>
            /// Enum Ipv6Enum for Ipv6
            /// </summary>
            [EnumMember(Value = "Ipv6")]
            Ipv6Enum = 1        }
}
