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
        /// A value used to categorize the system or application that generated the syslog event.
        /// </summary>
        /// <value>A value used to categorize the system or application that generated the syslog event.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum SyslogFacility
        {
            /// <summary>
            /// Enum KernelEnum for Kernel
            /// </summary>
            [EnumMember(Value = "Kernel")]
            KernelEnum = 0,
            /// <summary>
            /// Enum UserEnum for User
            /// </summary>
            [EnumMember(Value = "User")]
            UserEnum = 1,
            /// <summary>
            /// Enum MailEnum for Mail
            /// </summary>
            [EnumMember(Value = "Mail")]
            MailEnum = 2,
            /// <summary>
            /// Enum DaemonsEnum for Daemons
            /// </summary>
            [EnumMember(Value = "Daemons")]
            DaemonsEnum = 3,
            /// <summary>
            /// Enum AuthorizationEnum for Authorization
            /// </summary>
            [EnumMember(Value = "Authorization")]
            AuthorizationEnum = 4,
            /// <summary>
            /// Enum SyslogEnum for Syslog
            /// </summary>
            [EnumMember(Value = "Syslog")]
            SyslogEnum = 5,
            /// <summary>
            /// Enum PrinterEnum for Printer
            /// </summary>
            [EnumMember(Value = "Printer")]
            PrinterEnum = 6,
            /// <summary>
            /// Enum NewsEnum for News
            /// </summary>
            [EnumMember(Value = "News")]
            NewsEnum = 7,
            /// <summary>
            /// Enum UucpEnum for Uucp
            /// </summary>
            [EnumMember(Value = "Uucp")]
            UucpEnum = 8,
            /// <summary>
            /// Enum ClockEnum for Clock
            /// </summary>
            [EnumMember(Value = "Clock")]
            ClockEnum = 9,
            /// <summary>
            /// Enum Authorization2Enum for Authorization2
            /// </summary>
            [EnumMember(Value = "Authorization2")]
            Authorization2Enum = 10,
            /// <summary>
            /// Enum FtpEnum for Ftp
            /// </summary>
            [EnumMember(Value = "Ftp")]
            FtpEnum = 11,
            /// <summary>
            /// Enum NtpEnum for Ntp
            /// </summary>
            [EnumMember(Value = "Ntp")]
            NtpEnum = 12,
            /// <summary>
            /// Enum AuditEnum for Audit
            /// </summary>
            [EnumMember(Value = "Audit")]
            AuditEnum = 13,
            /// <summary>
            /// Enum AlertEnum for Alert
            /// </summary>
            [EnumMember(Value = "Alert")]
            AlertEnum = 14,
            /// <summary>
            /// Enum Clock2Enum for Clock2
            /// </summary>
            [EnumMember(Value = "Clock2")]
            Clock2Enum = 15,
            /// <summary>
            /// Enum Local0Enum for Local0
            /// </summary>
            [EnumMember(Value = "Local0")]
            Local0Enum = 16,
            /// <summary>
            /// Enum Local1Enum for Local1
            /// </summary>
            [EnumMember(Value = "Local1")]
            Local1Enum = 17,
            /// <summary>
            /// Enum Local2Enum for Local2
            /// </summary>
            [EnumMember(Value = "Local2")]
            Local2Enum = 18,
            /// <summary>
            /// Enum Local3Enum for Local3
            /// </summary>
            [EnumMember(Value = "Local3")]
            Local3Enum = 19,
            /// <summary>
            /// Enum Local4Enum for Local4
            /// </summary>
            [EnumMember(Value = "Local4")]
            Local4Enum = 20,
            /// <summary>
            /// Enum Local5Enum for Local5
            /// </summary>
            [EnumMember(Value = "Local5")]
            Local5Enum = 21,
            /// <summary>
            /// Enum Local6Enum for Local6
            /// </summary>
            [EnumMember(Value = "Local6")]
            Local6Enum = 22,
            /// <summary>
            /// Enum Local7Enum for Local7
            /// </summary>
            [EnumMember(Value = "Local7")]
            Local7Enum = 23        }
}
