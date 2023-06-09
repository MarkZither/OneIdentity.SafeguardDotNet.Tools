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
    /// 
    /// </summary>
    [DataContract]
    public partial class SshKeySyncAccountTaskProperties : IEquatable<SshKeySyncAccountTaskProperties>
    { 
        /// <summary>
        /// The date/time of the last SshKey change (Read-only)
        /// </summary>
        /// <value>The date/time of the last SshKey change (Read-only)</value>

        [DataMember(Name="LastSshKeyChangeDate")]
        public DateTime? LastSshKeyChangeDate { get; set; }

        /// <summary>
        /// The date/time of the last successful SshKey change (Read-only)
        /// </summary>
        /// <value>The date/time of the last successful SshKey change (Read-only)</value>

        [DataMember(Name="LastSuccessSshKeyChangeDate")]
        public DateTime? LastSuccessSshKeyChangeDate { get; set; }

        /// <summary>
        /// The date/time of the last failed SshKey change (Read-only)
        /// </summary>
        /// <value>The date/time of the last failed SshKey change (Read-only)</value>

        [DataMember(Name="LastFailureSshKeyChangeDate")]
        public DateTime? LastFailureSshKeyChangeDate { get; set; }

        /// <summary>
        /// The task audit log ID of the last SshKey change (Read-only)
        /// </summary>
        /// <value>The task audit log ID of the last SshKey change (Read-only)</value>

        [DataMember(Name="LastSshKeyChangeTaskId")]
        public string LastSshKeyChangeTaskId { get; set; }

        /// <summary>
        /// Number of subsequent failed SshKey change attempts since last success (Read-only)
        /// </summary>
        /// <value>Number of subsequent failed SshKey change attempts since last success (Read-only)</value>

        [DataMember(Name="FailedSshKeyChangeAttempts")]
        public int? FailedSshKeyChangeAttempts { get; set; }

        /// <summary>
        /// The date/time of the next SshKey change, if this account is enabled for automatic SshKey management (Read-only)
        /// </summary>
        /// <value>The date/time of the next SshKey change, if this account is enabled for automatic SshKey management (Read-only)</value>

        [DataMember(Name="NextSshKeyChangeDate")]
        public DateTime? NextSshKeyChangeDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SshKeySyncAccountTaskProperties {\n");
            sb.Append("  LastSshKeyChangeDate: ").Append(LastSshKeyChangeDate).Append("\n");
            sb.Append("  LastSuccessSshKeyChangeDate: ").Append(LastSuccessSshKeyChangeDate).Append("\n");
            sb.Append("  LastFailureSshKeyChangeDate: ").Append(LastFailureSshKeyChangeDate).Append("\n");
            sb.Append("  LastSshKeyChangeTaskId: ").Append(LastSshKeyChangeTaskId).Append("\n");
            sb.Append("  FailedSshKeyChangeAttempts: ").Append(FailedSshKeyChangeAttempts).Append("\n");
            sb.Append("  NextSshKeyChangeDate: ").Append(NextSshKeyChangeDate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SshKeySyncAccountTaskProperties)obj);
        }

        /// <summary>
        /// Returns true if SshKeySyncAccountTaskProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of SshKeySyncAccountTaskProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SshKeySyncAccountTaskProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LastSshKeyChangeDate == other.LastSshKeyChangeDate ||
                    LastSshKeyChangeDate != null &&
                    LastSshKeyChangeDate.Equals(other.LastSshKeyChangeDate)
                ) && 
                (
                    LastSuccessSshKeyChangeDate == other.LastSuccessSshKeyChangeDate ||
                    LastSuccessSshKeyChangeDate != null &&
                    LastSuccessSshKeyChangeDate.Equals(other.LastSuccessSshKeyChangeDate)
                ) && 
                (
                    LastFailureSshKeyChangeDate == other.LastFailureSshKeyChangeDate ||
                    LastFailureSshKeyChangeDate != null &&
                    LastFailureSshKeyChangeDate.Equals(other.LastFailureSshKeyChangeDate)
                ) && 
                (
                    LastSshKeyChangeTaskId == other.LastSshKeyChangeTaskId ||
                    LastSshKeyChangeTaskId != null &&
                    LastSshKeyChangeTaskId.Equals(other.LastSshKeyChangeTaskId)
                ) && 
                (
                    FailedSshKeyChangeAttempts == other.FailedSshKeyChangeAttempts ||
                    FailedSshKeyChangeAttempts != null &&
                    FailedSshKeyChangeAttempts.Equals(other.FailedSshKeyChangeAttempts)
                ) && 
                (
                    NextSshKeyChangeDate == other.NextSshKeyChangeDate ||
                    NextSshKeyChangeDate != null &&
                    NextSshKeyChangeDate.Equals(other.NextSshKeyChangeDate)
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
                    if (LastSshKeyChangeDate != null)
                    hashCode = hashCode * 59 + LastSshKeyChangeDate.GetHashCode();
                    if (LastSuccessSshKeyChangeDate != null)
                    hashCode = hashCode * 59 + LastSuccessSshKeyChangeDate.GetHashCode();
                    if (LastFailureSshKeyChangeDate != null)
                    hashCode = hashCode * 59 + LastFailureSshKeyChangeDate.GetHashCode();
                    if (LastSshKeyChangeTaskId != null)
                    hashCode = hashCode * 59 + LastSshKeyChangeTaskId.GetHashCode();
                    if (FailedSshKeyChangeAttempts != null)
                    hashCode = hashCode * 59 + FailedSshKeyChangeAttempts.GetHashCode();
                    if (NextSshKeyChangeDate != null)
                    hashCode = hashCode * 59 + NextSshKeyChangeDate.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SshKeySyncAccountTaskProperties left, SshKeySyncAccountTaskProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SshKeySyncAccountTaskProperties left, SshKeySyncAccountTaskProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
