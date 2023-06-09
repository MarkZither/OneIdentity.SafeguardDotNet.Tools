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
    /// Rule to apply to discover network assets
    /// </summary>
    [DataContract]
    public partial class AssetDiscoveryNetScanRule : IEquatable<AssetDiscoveryNetScanRule>
    { 
        /// <summary>
        /// Starting Ip
        /// </summary>
        /// <value>Starting Ip</value>
        [Required]

        [StringLength(45, MinimumLength=1)]
        [DataMember(Name="StartIp")]
        public string StartIp { get; set; }

        /// <summary>
        /// Ending Ip
        /// </summary>
        /// <value>Ending Ip</value>

        [StringLength(45, MinimumLength=1)]
        [DataMember(Name="EndIp")]
        public string EndIp { get; set; }

        /// <summary>
        /// Set Of Ips to exclude in network asset discovery scan request
        /// </summary>
        /// <value>Set Of Ips to exclude in network asset discovery scan request</value>

        [DataMember(Name="ExcludeIps")]
        public List<string> ExcludeIps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetDiscoveryNetScanRule {\n");
            sb.Append("  StartIp: ").Append(StartIp).Append("\n");
            sb.Append("  EndIp: ").Append(EndIp).Append("\n");
            sb.Append("  ExcludeIps: ").Append(ExcludeIps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((AssetDiscoveryNetScanRule)obj);
        }

        /// <summary>
        /// Returns true if AssetDiscoveryNetScanRule instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetDiscoveryNetScanRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetDiscoveryNetScanRule other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    StartIp == other.StartIp ||
                    StartIp != null &&
                    StartIp.Equals(other.StartIp)
                ) && 
                (
                    EndIp == other.EndIp ||
                    EndIp != null &&
                    EndIp.Equals(other.EndIp)
                ) && 
                (
                    ExcludeIps == other.ExcludeIps ||
                    ExcludeIps != null &&
                    ExcludeIps.SequenceEqual(other.ExcludeIps)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (StartIp != null)
                    hashCode = hashCode * 59 + StartIp.GetHashCode();
                    if (EndIp != null)
                    hashCode = hashCode * 59 + EndIp.GetHashCode();
                    if (ExcludeIps != null)
                    hashCode = hashCode * 59 + ExcludeIps.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AssetDiscoveryNetScanRule left, AssetDiscoveryNetScanRule right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AssetDiscoveryNetScanRule left, AssetDiscoveryNetScanRule right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
