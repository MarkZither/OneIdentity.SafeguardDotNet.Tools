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
        /// Gets or Sets SshKeyType
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum SshKeyType
        {
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 0,
            /// <summary>
            /// Enum RsaEnum for Rsa
            /// </summary>
            [EnumMember(Value = "Rsa")]
            RsaEnum = 1,
            /// <summary>
            /// Enum DsaEnum for Dsa
            /// </summary>
            [EnumMember(Value = "Dsa")]
            DsaEnum = 2,
            /// <summary>
            /// Enum Ed25519Enum for Ed25519
            /// </summary>
            [EnumMember(Value = "Ed25519")]
            Ed25519Enum = 3,
            /// <summary>
            /// Enum EcdsaEnum for Ecdsa
            /// </summary>
            [EnumMember(Value = "Ecdsa")]
            EcdsaEnum = 4        }
}
