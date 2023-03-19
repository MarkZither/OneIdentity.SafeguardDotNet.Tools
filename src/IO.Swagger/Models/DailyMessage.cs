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
    /// Represents a Message of the Day.
    /// </summary>
    [DataContract]
    public partial class DailyMessage : IEquatable<DailyMessage>
    { 
        /// <summary>
        /// Flag for whether to use the Address field to access an RSS feed [true] or to access the Subject and Message fields from settings [false]
        /// </summary>
        /// <value>Flag for whether to use the Address field to access an RSS feed [true] or to access the Subject and Message fields from settings [false]</value>

        [DataMember(Name="UseRss")]
        public bool? UseRss { get; set; }

        /// <summary>
        /// Web Address of an RSS feed.
        /// </summary>
        /// <value>Web Address of an RSS feed.</value>

        [MaxLength(512)]
        [DataMember(Name="Address")]
        public string Address { get; set; }

        /// <summary>
        /// Subject line of a Daily Message.
        /// </summary>
        /// <value>Subject line of a Daily Message.</value>

        [MaxLength(512)]
        [DataMember(Name="Subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Content of a Daily Message.
        /// </summary>
        /// <value>Content of a Daily Message.</value>

        [MaxLength(512)]
        [DataMember(Name="Message")]
        public string Message { get; set; }

        /// <summary>
        /// Date this entity was updated (Read-only)
        /// </summary>
        /// <value>Date this entity was updated (Read-only)</value>

        [DataMember(Name="UpdatedDate")]
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// The database ID of the user that updated this entity (Read-only)
        /// </summary>
        /// <value>The database ID of the user that updated this entity (Read-only)</value>

        [DataMember(Name="UpdatedByUserId")]
        public int? UpdatedByUserId { get; set; }

        /// <summary>
        /// The display name of the user that updated this entity (Read-only)
        /// </summary>
        /// <value>The display name of the user that updated this entity (Read-only)</value>

        [DataMember(Name="UpdatedByUserDisplayName")]
        public string UpdatedByUserDisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DailyMessage {\n");
            sb.Append("  UseRss: ").Append(UseRss).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  UpdatedByUserId: ").Append(UpdatedByUserId).Append("\n");
            sb.Append("  UpdatedByUserDisplayName: ").Append(UpdatedByUserDisplayName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DailyMessage)obj);
        }

        /// <summary>
        /// Returns true if DailyMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of DailyMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DailyMessage other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UseRss == other.UseRss ||
                    UseRss != null &&
                    UseRss.Equals(other.UseRss)
                ) && 
                (
                    Address == other.Address ||
                    Address != null &&
                    Address.Equals(other.Address)
                ) && 
                (
                    Subject == other.Subject ||
                    Subject != null &&
                    Subject.Equals(other.Subject)
                ) && 
                (
                    Message == other.Message ||
                    Message != null &&
                    Message.Equals(other.Message)
                ) && 
                (
                    UpdatedDate == other.UpdatedDate ||
                    UpdatedDate != null &&
                    UpdatedDate.Equals(other.UpdatedDate)
                ) && 
                (
                    UpdatedByUserId == other.UpdatedByUserId ||
                    UpdatedByUserId != null &&
                    UpdatedByUserId.Equals(other.UpdatedByUserId)
                ) && 
                (
                    UpdatedByUserDisplayName == other.UpdatedByUserDisplayName ||
                    UpdatedByUserDisplayName != null &&
                    UpdatedByUserDisplayName.Equals(other.UpdatedByUserDisplayName)
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
                    if (UseRss != null)
                    hashCode = hashCode * 59 + UseRss.GetHashCode();
                    if (Address != null)
                    hashCode = hashCode * 59 + Address.GetHashCode();
                    if (Subject != null)
                    hashCode = hashCode * 59 + Subject.GetHashCode();
                    if (Message != null)
                    hashCode = hashCode * 59 + Message.GetHashCode();
                    if (UpdatedDate != null)
                    hashCode = hashCode * 59 + UpdatedDate.GetHashCode();
                    if (UpdatedByUserId != null)
                    hashCode = hashCode * 59 + UpdatedByUserId.GetHashCode();
                    if (UpdatedByUserDisplayName != null)
                    hashCode = hashCode * 59 + UpdatedByUserDisplayName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DailyMessage left, DailyMessage right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DailyMessage left, DailyMessage right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}