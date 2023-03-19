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
    /// Task information for an asset discovery job
    /// </summary>
    [DataContract]
    public partial class AssetDiscoveryJobTaskProperties : IEquatable<AssetDiscoveryJobTaskProperties>
    { 
        /// <summary>
        /// Whether this asset discovery job has any platform task failures (Read-only)
        /// </summary>
        /// <value>Whether this asset discovery job has any platform task failures (Read-only)</value>

        [DataMember(Name="HasTaskFailure")]
        public bool? HasTaskFailure { get; set; }

        /// <summary>
        /// The date/time of the last asset discovery (Read-only)
        /// </summary>
        /// <value>The date/time of the last asset discovery (Read-only)</value>

        [DataMember(Name="LastAssetDiscoveryDate")]
        public DateTime? LastAssetDiscoveryDate { get; set; }

        /// <summary>
        /// The date/time of the last successful asset discovery (Read-only)
        /// </summary>
        /// <value>The date/time of the last successful asset discovery (Read-only)</value>

        [DataMember(Name="LastSuccessAssetDiscoveryDate")]
        public DateTime? LastSuccessAssetDiscoveryDate { get; set; }

        /// <summary>
        /// The date/time of the last failed asset discovery (Read-only)
        /// </summary>
        /// <value>The date/time of the last failed asset discovery (Read-only)</value>

        [DataMember(Name="LastFailureAssetDiscoveryDate")]
        public DateTime? LastFailureAssetDiscoveryDate { get; set; }

        /// <summary>
        /// Number of subsequent failed asset discovery attempts since last success (Read-only)
        /// </summary>
        /// <value>Number of subsequent failed asset discovery attempts since last success (Read-only)</value>

        [DataMember(Name="FailedAssetDiscoveryAttempts")]
        public int? FailedAssetDiscoveryAttempts { get; set; }

        /// <summary>
        /// The date/time of the next asset discovery (Read-only)
        /// </summary>
        /// <value>The date/time of the next asset discovery (Read-only)</value>

        [DataMember(Name="NextAssetDiscoveryDate")]
        public DateTime? NextAssetDiscoveryDate { get; set; }

        /// <summary>
        /// The task audit log ID of the last asset discovery (Read-only)
        /// </summary>
        /// <value>The task audit log ID of the last asset discovery (Read-only)</value>

        [DataMember(Name="LastAssetDiscoveryTaskId")]
        public string LastAssetDiscoveryTaskId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetDiscoveryJobTaskProperties {\n");
            sb.Append("  HasTaskFailure: ").Append(HasTaskFailure).Append("\n");
            sb.Append("  LastAssetDiscoveryDate: ").Append(LastAssetDiscoveryDate).Append("\n");
            sb.Append("  LastSuccessAssetDiscoveryDate: ").Append(LastSuccessAssetDiscoveryDate).Append("\n");
            sb.Append("  LastFailureAssetDiscoveryDate: ").Append(LastFailureAssetDiscoveryDate).Append("\n");
            sb.Append("  FailedAssetDiscoveryAttempts: ").Append(FailedAssetDiscoveryAttempts).Append("\n");
            sb.Append("  NextAssetDiscoveryDate: ").Append(NextAssetDiscoveryDate).Append("\n");
            sb.Append("  LastAssetDiscoveryTaskId: ").Append(LastAssetDiscoveryTaskId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AssetDiscoveryJobTaskProperties)obj);
        }

        /// <summary>
        /// Returns true if AssetDiscoveryJobTaskProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetDiscoveryJobTaskProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetDiscoveryJobTaskProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    HasTaskFailure == other.HasTaskFailure ||
                    HasTaskFailure != null &&
                    HasTaskFailure.Equals(other.HasTaskFailure)
                ) && 
                (
                    LastAssetDiscoveryDate == other.LastAssetDiscoveryDate ||
                    LastAssetDiscoveryDate != null &&
                    LastAssetDiscoveryDate.Equals(other.LastAssetDiscoveryDate)
                ) && 
                (
                    LastSuccessAssetDiscoveryDate == other.LastSuccessAssetDiscoveryDate ||
                    LastSuccessAssetDiscoveryDate != null &&
                    LastSuccessAssetDiscoveryDate.Equals(other.LastSuccessAssetDiscoveryDate)
                ) && 
                (
                    LastFailureAssetDiscoveryDate == other.LastFailureAssetDiscoveryDate ||
                    LastFailureAssetDiscoveryDate != null &&
                    LastFailureAssetDiscoveryDate.Equals(other.LastFailureAssetDiscoveryDate)
                ) && 
                (
                    FailedAssetDiscoveryAttempts == other.FailedAssetDiscoveryAttempts ||
                    FailedAssetDiscoveryAttempts != null &&
                    FailedAssetDiscoveryAttempts.Equals(other.FailedAssetDiscoveryAttempts)
                ) && 
                (
                    NextAssetDiscoveryDate == other.NextAssetDiscoveryDate ||
                    NextAssetDiscoveryDate != null &&
                    NextAssetDiscoveryDate.Equals(other.NextAssetDiscoveryDate)
                ) && 
                (
                    LastAssetDiscoveryTaskId == other.LastAssetDiscoveryTaskId ||
                    LastAssetDiscoveryTaskId != null &&
                    LastAssetDiscoveryTaskId.Equals(other.LastAssetDiscoveryTaskId)
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
                    if (HasTaskFailure != null)
                    hashCode = hashCode * 59 + HasTaskFailure.GetHashCode();
                    if (LastAssetDiscoveryDate != null)
                    hashCode = hashCode * 59 + LastAssetDiscoveryDate.GetHashCode();
                    if (LastSuccessAssetDiscoveryDate != null)
                    hashCode = hashCode * 59 + LastSuccessAssetDiscoveryDate.GetHashCode();
                    if (LastFailureAssetDiscoveryDate != null)
                    hashCode = hashCode * 59 + LastFailureAssetDiscoveryDate.GetHashCode();
                    if (FailedAssetDiscoveryAttempts != null)
                    hashCode = hashCode * 59 + FailedAssetDiscoveryAttempts.GetHashCode();
                    if (NextAssetDiscoveryDate != null)
                    hashCode = hashCode * 59 + NextAssetDiscoveryDate.GetHashCode();
                    if (LastAssetDiscoveryTaskId != null)
                    hashCode = hashCode * 59 + LastAssetDiscoveryTaskId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AssetDiscoveryJobTaskProperties left, AssetDiscoveryJobTaskProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AssetDiscoveryJobTaskProperties left, AssetDiscoveryJobTaskProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
