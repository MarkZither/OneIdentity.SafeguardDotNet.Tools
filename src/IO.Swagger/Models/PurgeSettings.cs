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
    /// Represents setting governing how long to retain deleted entities
    /// </summary>
    [DataContract]
    public partial class PurgeSettings : IEquatable<PurgeSettings>
    { 
        /// <summary>
        /// Whether to automatically purged expired deleted assets
        /// </summary>
        /// <value>Whether to automatically purged expired deleted assets</value>

        [DataMember(Name="AutoPurgeAssets")]
        public bool? AutoPurgeAssets { get; set; }

        /// <summary>
        /// How long to retain deleted assets before purging
        /// </summary>
        /// <value>How long to retain deleted assets before purging</value>

        [Range(1, 3650)]
        [DataMember(Name="DeletedAssetRetentionInDays")]
        public int? DeletedAssetRetentionInDays { get; set; }

        /// <summary>
        /// Whether to automatically purged expired deleted asset accounts
        /// </summary>
        /// <value>Whether to automatically purged expired deleted asset accounts</value>

        [DataMember(Name="AutoPurgeAssetAccounts")]
        public bool? AutoPurgeAssetAccounts { get; set; }

        /// <summary>
        /// How long to retain deleted asset accounts before purging
        /// </summary>
        /// <value>How long to retain deleted asset accounts before purging</value>

        [Range(1, 3650)]
        [DataMember(Name="DeletedAssetAccountRetentionInDays")]
        public int? DeletedAssetAccountRetentionInDays { get; set; }

        /// <summary>
        /// Whether to automatically purged expired deleted users
        /// </summary>
        /// <value>Whether to automatically purged expired deleted users</value>

        [DataMember(Name="AutoPurgeUsers")]
        public bool? AutoPurgeUsers { get; set; }

        /// <summary>
        /// How long to retain deleted using before purging
        /// </summary>
        /// <value>How long to retain deleted using before purging</value>

        [Range(1, 3650)]
        [DataMember(Name="DeletedUserRetentionInDays")]
        public int? DeletedUserRetentionInDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurgeSettings {\n");
            sb.Append("  AutoPurgeAssets: ").Append(AutoPurgeAssets).Append("\n");
            sb.Append("  DeletedAssetRetentionInDays: ").Append(DeletedAssetRetentionInDays).Append("\n");
            sb.Append("  AutoPurgeAssetAccounts: ").Append(AutoPurgeAssetAccounts).Append("\n");
            sb.Append("  DeletedAssetAccountRetentionInDays: ").Append(DeletedAssetAccountRetentionInDays).Append("\n");
            sb.Append("  AutoPurgeUsers: ").Append(AutoPurgeUsers).Append("\n");
            sb.Append("  DeletedUserRetentionInDays: ").Append(DeletedUserRetentionInDays).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PurgeSettings)obj);
        }

        /// <summary>
        /// Returns true if PurgeSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of PurgeSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurgeSettings other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AutoPurgeAssets == other.AutoPurgeAssets ||
                    AutoPurgeAssets != null &&
                    AutoPurgeAssets.Equals(other.AutoPurgeAssets)
                ) && 
                (
                    DeletedAssetRetentionInDays == other.DeletedAssetRetentionInDays ||
                    DeletedAssetRetentionInDays != null &&
                    DeletedAssetRetentionInDays.Equals(other.DeletedAssetRetentionInDays)
                ) && 
                (
                    AutoPurgeAssetAccounts == other.AutoPurgeAssetAccounts ||
                    AutoPurgeAssetAccounts != null &&
                    AutoPurgeAssetAccounts.Equals(other.AutoPurgeAssetAccounts)
                ) && 
                (
                    DeletedAssetAccountRetentionInDays == other.DeletedAssetAccountRetentionInDays ||
                    DeletedAssetAccountRetentionInDays != null &&
                    DeletedAssetAccountRetentionInDays.Equals(other.DeletedAssetAccountRetentionInDays)
                ) && 
                (
                    AutoPurgeUsers == other.AutoPurgeUsers ||
                    AutoPurgeUsers != null &&
                    AutoPurgeUsers.Equals(other.AutoPurgeUsers)
                ) && 
                (
                    DeletedUserRetentionInDays == other.DeletedUserRetentionInDays ||
                    DeletedUserRetentionInDays != null &&
                    DeletedUserRetentionInDays.Equals(other.DeletedUserRetentionInDays)
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
                    if (AutoPurgeAssets != null)
                    hashCode = hashCode * 59 + AutoPurgeAssets.GetHashCode();
                    if (DeletedAssetRetentionInDays != null)
                    hashCode = hashCode * 59 + DeletedAssetRetentionInDays.GetHashCode();
                    if (AutoPurgeAssetAccounts != null)
                    hashCode = hashCode * 59 + AutoPurgeAssetAccounts.GetHashCode();
                    if (DeletedAssetAccountRetentionInDays != null)
                    hashCode = hashCode * 59 + DeletedAssetAccountRetentionInDays.GetHashCode();
                    if (AutoPurgeUsers != null)
                    hashCode = hashCode * 59 + AutoPurgeUsers.GetHashCode();
                    if (DeletedUserRetentionInDays != null)
                    hashCode = hashCode * 59 + DeletedUserRetentionInDays.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PurgeSettings left, PurgeSettings right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PurgeSettings left, PurgeSettings right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
