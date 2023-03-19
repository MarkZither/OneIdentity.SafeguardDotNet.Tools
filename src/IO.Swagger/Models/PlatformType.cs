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
        /// Gets or Sets PlatformType
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum PlatformType
        {
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 0,
            /// <summary>
            /// Enum AIXEnum for AIX
            /// </summary>
            [EnumMember(Value = "AIX")]
            AIXEnum = 1,
            /// <summary>
            /// Enum AS400Enum for AS400
            /// </summary>
            [EnumMember(Value = "AS400")]
            AS400Enum = 2,
            /// <summary>
            /// Enum CiscoASAEnum for CiscoASA
            /// </summary>
            [EnumMember(Value = "CiscoASA")]
            CiscoASAEnum = 3,
            /// <summary>
            /// Enum CiscoIOSEnum for CiscoIOS
            /// </summary>
            [EnumMember(Value = "CiscoIOS")]
            CiscoIOSEnum = 4,
            /// <summary>
            /// Enum IDRACEnum for iDRAC
            /// </summary>
            [EnumMember(Value = "iDRAC")]
            IDRACEnum = 5,
            /// <summary>
            /// Enum FortinetEnum for Fortinet
            /// </summary>
            [EnumMember(Value = "Fortinet")]
            FortinetEnum = 6,
            /// <summary>
            /// Enum FreeBsdEnum for FreeBsd
            /// </summary>
            [EnumMember(Value = "FreeBsd")]
            FreeBsdEnum = 7,
            /// <summary>
            /// Enum HPiLOEnum for HPiLO
            /// </summary>
            [EnumMember(Value = "HPiLO")]
            HPiLOEnum = 8,
            /// <summary>
            /// Enum HPUXEnum for HPUX
            /// </summary>
            [EnumMember(Value = "HPUX")]
            HPUXEnum = 9,
            /// <summary>
            /// Enum JunOSEnum for JunOS
            /// </summary>
            [EnumMember(Value = "JunOS")]
            JunOSEnum = 10,
            /// <summary>
            /// Enum LdapEnum for Ldap
            /// </summary>
            [EnumMember(Value = "Ldap")]
            LdapEnum = 11,
            /// <summary>
            /// Enum OSXEnum for OSX
            /// </summary>
            [EnumMember(Value = "OSX")]
            OSXEnum = 12,
            /// <summary>
            /// Enum ACF2Enum for ACF2
            /// </summary>
            [EnumMember(Value = "ACF2")]
            ACF2Enum = 13,
            /// <summary>
            /// Enum RACFEnum for RACF
            /// </summary>
            [EnumMember(Value = "RACF")]
            RACFEnum = 14,
            /// <summary>
            /// Enum RacfLdapEnum for RacfLdap
            /// </summary>
            [EnumMember(Value = "RacfLdap")]
            RacfLdapEnum = 15,
            /// <summary>
            /// Enum TopSecretEnum for TopSecret
            /// </summary>
            [EnumMember(Value = "TopSecret")]
            TopSecretEnum = 16,
            /// <summary>
            /// Enum SqlServerEnum for SqlServer
            /// </summary>
            [EnumMember(Value = "SqlServer")]
            SqlServerEnum = 17,
            /// <summary>
            /// Enum MySQLEnum for MySQL
            /// </summary>
            [EnumMember(Value = "MySQL")]
            MySQLEnum = 18,
            /// <summary>
            /// Enum OracleEnum for Oracle
            /// </summary>
            [EnumMember(Value = "Oracle")]
            OracleEnum = 19,
            /// <summary>
            /// Enum PanOSEnum for PanOS
            /// </summary>
            [EnumMember(Value = "PanOS")]
            PanOSEnum = 20,
            /// <summary>
            /// Enum SAPEnum for SAP
            /// </summary>
            [EnumMember(Value = "SAP")]
            SAPEnum = 21,
            /// <summary>
            /// Enum SonicOsEnum for SonicOs
            /// </summary>
            [EnumMember(Value = "SonicOs")]
            SonicOsEnum = 22,
            /// <summary>
            /// Enum SybaseEnum for Sybase
            /// </summary>
            [EnumMember(Value = "Sybase")]
            SybaseEnum = 23,
            /// <summary>
            /// Enum VSphereEnum for VSphere
            /// </summary>
            [EnumMember(Value = "VSphere")]
            VSphereEnum = 24,
            /// <summary>
            /// Enum WindowsEnum for Windows
            /// </summary>
            [EnumMember(Value = "Windows")]
            WindowsEnum = 25,
            /// <summary>
            /// Enum MicrosoftADEnum for MicrosoftAD
            /// </summary>
            [EnumMember(Value = "MicrosoftAD")]
            MicrosoftADEnum = 26,
            /// <summary>
            /// Enum RedHatEnterpriseEnum for RedHatEnterprise
            /// </summary>
            [EnumMember(Value = "RedHatEnterprise")]
            RedHatEnterpriseEnum = 27,
            /// <summary>
            /// Enum CentosEnum for Centos
            /// </summary>
            [EnumMember(Value = "Centos")]
            CentosEnum = 28,
            /// <summary>
            /// Enum FedoraEnum for Fedora
            /// </summary>
            [EnumMember(Value = "Fedora")]
            FedoraEnum = 29,
            /// <summary>
            /// Enum SuseEnum for Suse
            /// </summary>
            [EnumMember(Value = "Suse")]
            SuseEnum = 30,
            /// <summary>
            /// Enum DebianEnum for Debian
            /// </summary>
            [EnumMember(Value = "Debian")]
            DebianEnum = 31,
            /// <summary>
            /// Enum UbuntuEnum for Ubuntu
            /// </summary>
            [EnumMember(Value = "Ubuntu")]
            UbuntuEnum = 32,
            /// <summary>
            /// Enum OracleLinuxEnum for OracleLinux
            /// </summary>
            [EnumMember(Value = "OracleLinux")]
            OracleLinuxEnum = 33,
            /// <summary>
            /// Enum SolarisEnum for Solaris
            /// </summary>
            [EnumMember(Value = "Solaris")]
            SolarisEnum = 34,
            /// <summary>
            /// Enum SonicWallSmaEnum for SonicWallSma
            /// </summary>
            [EnumMember(Value = "SonicWallSma")]
            SonicWallSmaEnum = 35,
            /// <summary>
            /// Enum TwitterEnum for Twitter
            /// </summary>
            [EnumMember(Value = "Twitter")]
            TwitterEnum = 36,
            /// <summary>
            /// Enum LinuxOtherEnum for LinuxOther
            /// </summary>
            [EnumMember(Value = "LinuxOther")]
            LinuxOtherEnum = 37,
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 38,
            /// <summary>
            /// Enum HPiLOMPEnum for HPiLOMP
            /// </summary>
            [EnumMember(Value = "HPiLOMP")]
            HPiLOMPEnum = 39,
            /// <summary>
            /// Enum AwsEnum for Aws
            /// </summary>
            [EnumMember(Value = "Aws")]
            AwsEnum = 40,
            /// <summary>
            /// Enum FacebookEnum for Facebook
            /// </summary>
            [EnumMember(Value = "Facebook")]
            FacebookEnum = 41,
            /// <summary>
            /// Enum Acf2LdapEnum for Acf2Ldap
            /// </summary>
            [EnumMember(Value = "Acf2Ldap")]
            Acf2LdapEnum = 42,
            /// <summary>
            /// Enum F5BigIpEnum for F5BigIp
            /// </summary>
            [EnumMember(Value = "F5BigIp")]
            F5BigIpEnum = 43,
            /// <summary>
            /// Enum TopSecretLdapEnum for TopSecretLdap
            /// </summary>
            [EnumMember(Value = "TopSecretLdap")]
            TopSecretLdapEnum = 44,
            /// <summary>
            /// Enum MongoDBEnum for MongoDB
            /// </summary>
            [EnumMember(Value = "MongoDB")]
            MongoDBEnum = 45,
            /// <summary>
            /// Enum PostgreSQLEnum for PostgreSQL
            /// </summary>
            [EnumMember(Value = "PostgreSQL")]
            PostgreSQLEnum = 46,
            /// <summary>
            /// Enum SapHanaEnum for SapHana
            /// </summary>
            [EnumMember(Value = "SapHana")]
            SapHanaEnum = 47,
            /// <summary>
            /// Enum CustomEnum for Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            CustomEnum = 48,
            /// <summary>
            /// Enum AmazonLinuxEnum for AmazonLinux
            /// </summary>
            [EnumMember(Value = "AmazonLinux")]
            AmazonLinuxEnum = 49,
            /// <summary>
            /// Enum OtherManagedEnum for OtherManaged
            /// </summary>
            [EnumMember(Value = "OtherManaged")]
            OtherManagedEnum = 50,
            /// <summary>
            /// Enum WindowsSshEnum for WindowsSsh
            /// </summary>
            [EnumMember(Value = "WindowsSsh")]
            WindowsSshEnum = 51,
            /// <summary>
            /// Enum CheckPointEnum for CheckPoint
            /// </summary>
            [EnumMember(Value = "CheckPoint")]
            CheckPointEnum = 52,
            /// <summary>
            /// Enum StarlingConnectEnum for StarlingConnect
            /// </summary>
            [EnumMember(Value = "StarlingConnect")]
            StarlingConnectEnum = 53,
            /// <summary>
            /// Enum OtherDirectoryEnum for OtherDirectory
            /// </summary>
            [EnumMember(Value = "OtherDirectory")]
            OtherDirectoryEnum = 54,
            /// <summary>
            /// Enum CiscoISECLIEnum for CiscoISECLI
            /// </summary>
            [EnumMember(Value = "CiscoISECLI")]
            CiscoISECLIEnum = 55,
            /// <summary>
            /// Enum CiscoISEEnum for CiscoISE
            /// </summary>
            [EnumMember(Value = "CiscoISE")]
            CiscoISEEnum = 56,
            /// <summary>
            /// Enum WindowsRmEnum for WindowsRm
            /// </summary>
            [EnumMember(Value = "WindowsRm")]
            WindowsRmEnum = 57,
            /// <summary>
            /// Enum CiscoNxOsEnum for CiscoNxOs
            /// </summary>
            [EnumMember(Value = "CiscoNxOs")]
            CiscoNxOsEnum = 58,
            /// <summary>
            /// Enum StarlingDirectoryEnum for StarlingDirectory
            /// </summary>
            [EnumMember(Value = "StarlingDirectory")]
            StarlingDirectoryEnum = 59,
            /// <summary>
            /// Enum RedHatDirectoryEnum for RedHatDirectory
            /// </summary>
            [EnumMember(Value = "RedHatDirectory")]
            RedHatDirectoryEnum = 60,
            /// <summary>
            /// Enum EDirectoryLdapEnum for EDirectoryLdap
            /// </summary>
            [EnumMember(Value = "EDirectoryLdap")]
            EDirectoryLdapEnum = 61        }
}
