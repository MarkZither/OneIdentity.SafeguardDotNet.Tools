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
        /// Represents the subscriber type
        /// </summary>
        /// <value>Represents the subscriber type</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum EventSubscriberType
        {
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 0,
            /// <summary>
            /// Enum EmailEnum for Email
            /// </summary>
            [EnumMember(Value = "Email")]
            EmailEnum = 1,
            /// <summary>
            /// Enum SnmpEnum for Snmp
            /// </summary>
            [EnumMember(Value = "Snmp")]
            SnmpEnum = 2,
            /// <summary>
            /// Enum SignalrEnum for Signalr
            /// </summary>
            [EnumMember(Value = "Signalr")]
            SignalrEnum = 3,
            /// <summary>
            /// Enum SyslogEnum for Syslog
            /// </summary>
            [EnumMember(Value = "Syslog")]
            SyslogEnum = 4        }
}
