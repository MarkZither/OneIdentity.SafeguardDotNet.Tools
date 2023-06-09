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
    /// Represents the service configuration on the appliance
    /// </summary>
    [DataContract]
    public partial class ServicesConfig : IEquatable<ServicesConfig>
    { 
        /// <summary>
        /// Password change enabled
        /// </summary>
        /// <value>Password change enabled</value>
        [Required]

        [DataMember(Name="PasswordChangeEnabled")]
        public bool? PasswordChangeEnabled { get; set; }

        /// <summary>
        /// Password check enabled
        /// </summary>
        /// <value>Password check enabled</value>
        [Required]

        [DataMember(Name="PasswordCheckEnabled")]
        public bool? PasswordCheckEnabled { get; set; }

        /// <summary>
        /// Password requests enabled
        /// </summary>
        /// <value>Password requests enabled</value>
        [Required]

        [DataMember(Name="PasswordRequestsEnabled")]
        public bool? PasswordRequestsEnabled { get; set; }

        /// <summary>
        /// Session requests enabled
        /// </summary>
        /// <value>Session requests enabled</value>
        [Required]

        [DataMember(Name="SessionRequestsEnabled")]
        public bool? SessionRequestsEnabled { get; set; }

        /// <summary>
        /// SSH Key requests enabled
        /// </summary>
        /// <value>SSH Key requests enabled</value>
        [Required]

        [DataMember(Name="SshKeyRequestsEnabled")]
        public bool? SshKeyRequestsEnabled { get; set; }

        /// <summary>
        /// Asset discovery enabled
        /// </summary>
        /// <value>Asset discovery enabled</value>

        [DataMember(Name="AssetDiscoveryEnabled")]
        public bool? AssetDiscoveryEnabled { get; set; }

        /// <summary>
        /// Directory sync enabled
        /// </summary>
        /// <value>Directory sync enabled</value>

        [DataMember(Name="DirectorySyncEnabled")]
        public bool? DirectorySyncEnabled { get; set; }

        /// <summary>
        /// SSH key enabled
        /// </summary>
        /// <value>SSH key enabled</value>
        [Required]

        [DataMember(Name="SshKeyCheckEnabled")]
        public bool? SshKeyCheckEnabled { get; set; }

        /// <summary>
        /// SSH key change enabled
        /// </summary>
        /// <value>SSH key change enabled</value>
        [Required]

        [DataMember(Name="SshKeyChangeEnabled")]
        public bool? SshKeyChangeEnabled { get; set; }

        /// <summary>
        /// SSH key discovery enabled
        /// </summary>
        /// <value>SSH key discovery enabled</value>
        [Required]

        [DataMember(Name="SshKeyDiscoveryEnabled")]
        public bool? SshKeyDiscoveryEnabled { get; set; }

        /// <summary>
        /// Discover accounts enabled
        /// </summary>
        /// <value>Discover accounts enabled</value>
        [Required]

        [DataMember(Name="DiscoverAccountsEnabled")]
        public bool? DiscoverAccountsEnabled { get; set; }

        /// <summary>
        /// Discover services enabled
        /// </summary>
        /// <value>Discover services enabled</value>
        [Required]

        [DataMember(Name="DiscoverServicesEnabled")]
        public bool? DiscoverServicesEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServicesConfig {\n");
            sb.Append("  PasswordChangeEnabled: ").Append(PasswordChangeEnabled).Append("\n");
            sb.Append("  PasswordCheckEnabled: ").Append(PasswordCheckEnabled).Append("\n");
            sb.Append("  PasswordRequestsEnabled: ").Append(PasswordRequestsEnabled).Append("\n");
            sb.Append("  SessionRequestsEnabled: ").Append(SessionRequestsEnabled).Append("\n");
            sb.Append("  SshKeyRequestsEnabled: ").Append(SshKeyRequestsEnabled).Append("\n");
            sb.Append("  AssetDiscoveryEnabled: ").Append(AssetDiscoveryEnabled).Append("\n");
            sb.Append("  DirectorySyncEnabled: ").Append(DirectorySyncEnabled).Append("\n");
            sb.Append("  SshKeyCheckEnabled: ").Append(SshKeyCheckEnabled).Append("\n");
            sb.Append("  SshKeyChangeEnabled: ").Append(SshKeyChangeEnabled).Append("\n");
            sb.Append("  SshKeyDiscoveryEnabled: ").Append(SshKeyDiscoveryEnabled).Append("\n");
            sb.Append("  DiscoverAccountsEnabled: ").Append(DiscoverAccountsEnabled).Append("\n");
            sb.Append("  DiscoverServicesEnabled: ").Append(DiscoverServicesEnabled).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ServicesConfig)obj);
        }

        /// <summary>
        /// Returns true if ServicesConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of ServicesConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServicesConfig other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PasswordChangeEnabled == other.PasswordChangeEnabled ||
                    PasswordChangeEnabled != null &&
                    PasswordChangeEnabled.Equals(other.PasswordChangeEnabled)
                ) && 
                (
                    PasswordCheckEnabled == other.PasswordCheckEnabled ||
                    PasswordCheckEnabled != null &&
                    PasswordCheckEnabled.Equals(other.PasswordCheckEnabled)
                ) && 
                (
                    PasswordRequestsEnabled == other.PasswordRequestsEnabled ||
                    PasswordRequestsEnabled != null &&
                    PasswordRequestsEnabled.Equals(other.PasswordRequestsEnabled)
                ) && 
                (
                    SessionRequestsEnabled == other.SessionRequestsEnabled ||
                    SessionRequestsEnabled != null &&
                    SessionRequestsEnabled.Equals(other.SessionRequestsEnabled)
                ) && 
                (
                    SshKeyRequestsEnabled == other.SshKeyRequestsEnabled ||
                    SshKeyRequestsEnabled != null &&
                    SshKeyRequestsEnabled.Equals(other.SshKeyRequestsEnabled)
                ) && 
                (
                    AssetDiscoveryEnabled == other.AssetDiscoveryEnabled ||
                    AssetDiscoveryEnabled != null &&
                    AssetDiscoveryEnabled.Equals(other.AssetDiscoveryEnabled)
                ) && 
                (
                    DirectorySyncEnabled == other.DirectorySyncEnabled ||
                    DirectorySyncEnabled != null &&
                    DirectorySyncEnabled.Equals(other.DirectorySyncEnabled)
                ) && 
                (
                    SshKeyCheckEnabled == other.SshKeyCheckEnabled ||
                    SshKeyCheckEnabled != null &&
                    SshKeyCheckEnabled.Equals(other.SshKeyCheckEnabled)
                ) && 
                (
                    SshKeyChangeEnabled == other.SshKeyChangeEnabled ||
                    SshKeyChangeEnabled != null &&
                    SshKeyChangeEnabled.Equals(other.SshKeyChangeEnabled)
                ) && 
                (
                    SshKeyDiscoveryEnabled == other.SshKeyDiscoveryEnabled ||
                    SshKeyDiscoveryEnabled != null &&
                    SshKeyDiscoveryEnabled.Equals(other.SshKeyDiscoveryEnabled)
                ) && 
                (
                    DiscoverAccountsEnabled == other.DiscoverAccountsEnabled ||
                    DiscoverAccountsEnabled != null &&
                    DiscoverAccountsEnabled.Equals(other.DiscoverAccountsEnabled)
                ) && 
                (
                    DiscoverServicesEnabled == other.DiscoverServicesEnabled ||
                    DiscoverServicesEnabled != null &&
                    DiscoverServicesEnabled.Equals(other.DiscoverServicesEnabled)
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
                    if (PasswordChangeEnabled != null)
                    hashCode = hashCode * 59 + PasswordChangeEnabled.GetHashCode();
                    if (PasswordCheckEnabled != null)
                    hashCode = hashCode * 59 + PasswordCheckEnabled.GetHashCode();
                    if (PasswordRequestsEnabled != null)
                    hashCode = hashCode * 59 + PasswordRequestsEnabled.GetHashCode();
                    if (SessionRequestsEnabled != null)
                    hashCode = hashCode * 59 + SessionRequestsEnabled.GetHashCode();
                    if (SshKeyRequestsEnabled != null)
                    hashCode = hashCode * 59 + SshKeyRequestsEnabled.GetHashCode();
                    if (AssetDiscoveryEnabled != null)
                    hashCode = hashCode * 59 + AssetDiscoveryEnabled.GetHashCode();
                    if (DirectorySyncEnabled != null)
                    hashCode = hashCode * 59 + DirectorySyncEnabled.GetHashCode();
                    if (SshKeyCheckEnabled != null)
                    hashCode = hashCode * 59 + SshKeyCheckEnabled.GetHashCode();
                    if (SshKeyChangeEnabled != null)
                    hashCode = hashCode * 59 + SshKeyChangeEnabled.GetHashCode();
                    if (SshKeyDiscoveryEnabled != null)
                    hashCode = hashCode * 59 + SshKeyDiscoveryEnabled.GetHashCode();
                    if (DiscoverAccountsEnabled != null)
                    hashCode = hashCode * 59 + DiscoverAccountsEnabled.GetHashCode();
                    if (DiscoverServicesEnabled != null)
                    hashCode = hashCode * 59 + DiscoverServicesEnabled.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ServicesConfig left, ServicesConfig right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ServicesConfig left, ServicesConfig right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
