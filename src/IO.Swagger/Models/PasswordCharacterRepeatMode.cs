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
        /// What type of restrictions to enforce for repeated characters
        /// </summary>
        /// <value>What type of restrictions to enforce for repeated characters</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum PasswordCharacterRepeatMode
        {
            /// <summary>
            /// Enum NotSpecifiedEnum for NotSpecified
            /// </summary>
            [EnumMember(Value = "NotSpecified")]
            NotSpecifiedEnum = 0,
            /// <summary>
            /// Enum NoConsecutiveRepeatedCharactersEnum for NoConsecutiveRepeatedCharacters
            /// </summary>
            [EnumMember(Value = "NoConsecutiveRepeatedCharacters")]
            NoConsecutiveRepeatedCharactersEnum = 1,
            /// <summary>
            /// Enum NoRepeatedCharactersEnum for NoRepeatedCharacters
            /// </summary>
            [EnumMember(Value = "NoRepeatedCharacters")]
            NoRepeatedCharactersEnum = 2,
            /// <summary>
            /// Enum AllowRepeatedCharactersEnum for AllowRepeatedCharacters
            /// </summary>
            [EnumMember(Value = "AllowRepeatedCharacters")]
            AllowRepeatedCharactersEnum = 3        }
}
