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
        /// In what format will the SSH key, in particular the private key be exported to when downloading or checking it out.
        /// </summary>
        /// <value>In what format will the SSH key, in particular the private key be exported to when downloading or checking it out.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum SshKeyFormat
        {
            /// <summary>
            /// Enum OpenSshEnum for OpenSsh
            /// </summary>
            [EnumMember(Value = "OpenSsh")]
            OpenSshEnum = 0,
            /// <summary>
            /// Enum Ssh2Enum for Ssh2
            /// </summary>
            [EnumMember(Value = "Ssh2")]
            Ssh2Enum = 1,
            /// <summary>
            /// Enum PuttyEnum for Putty
            /// </summary>
            [EnumMember(Value = "Putty")]
            PuttyEnum = 2        }
}
