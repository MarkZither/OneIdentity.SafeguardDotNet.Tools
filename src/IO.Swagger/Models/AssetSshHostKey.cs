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
    /// Represents an SSH Host Key used to identify assets
    /// </summary>
    [DataContract]
    public partial class AssetSshHostKey : IEquatable<AssetSshHostKey>
    { 
        /// <summary>
        /// Public key of the asset
        /// </summary>
        /// <value>Public key of the asset</value>

        [MaxLength(8000)]
        [DataMember(Name="SshHostKey")]
        public string SshHostKey { get; set; }

        /// <summary>
        /// The MD5 fingerprint hash of the SSH host key (Read-only)
        /// </summary>
        /// <value>The MD5 fingerprint hash of the SSH host key (Read-only)</value>

        [DataMember(Name="Fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// The SHA256 fingerprint hash, Base64 encoded, of the SSH host key (Read-only)
        /// </summary>
        /// <value>The SHA256 fingerprint hash, Base64 encoded, of the SSH host key (Read-only)</value>

        [DataMember(Name="FingerprintSha256")]
        public string FingerprintSha256 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetSshHostKey {\n");
            sb.Append("  SshHostKey: ").Append(SshHostKey).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  FingerprintSha256: ").Append(FingerprintSha256).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AssetSshHostKey)obj);
        }

        /// <summary>
        /// Returns true if AssetSshHostKey instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetSshHostKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetSshHostKey other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SshHostKey == other.SshHostKey ||
                    SshHostKey != null &&
                    SshHostKey.Equals(other.SshHostKey)
                ) && 
                (
                    Fingerprint == other.Fingerprint ||
                    Fingerprint != null &&
                    Fingerprint.Equals(other.Fingerprint)
                ) && 
                (
                    FingerprintSha256 == other.FingerprintSha256 ||
                    FingerprintSha256 != null &&
                    FingerprintSha256.Equals(other.FingerprintSha256)
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
                    if (SshHostKey != null)
                    hashCode = hashCode * 59 + SshHostKey.GetHashCode();
                    if (Fingerprint != null)
                    hashCode = hashCode * 59 + Fingerprint.GetHashCode();
                    if (FingerprintSha256 != null)
                    hashCode = hashCode * 59 + FingerprintSha256.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AssetSshHostKey left, AssetSshHostKey right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AssetSshHostKey left, AssetSshHostKey right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}