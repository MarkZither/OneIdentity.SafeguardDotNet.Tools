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
    /// Appliance log
    /// </summary>
    [DataContract]
    public partial class ApplianceLog : IEquatable<ApplianceLog>
    { 
        /// <summary>
        /// The unique id (Timeuuid) of this log entry
        /// </summary>
        /// <value>The unique id (Timeuuid) of this log entry</value>

        [DataMember(Name="LogId")]
        public string LogId { get; set; }

        /// <summary>
        /// Time of authentication
        /// </summary>
        /// <value>Time of authentication</value>

        [DataMember(Name="LogTime")]
        public DateTime? LogTime { get; set; }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>

        [DataMember(Name="EventName")]
        public EventName EventName { get; set; }

        /// <summary>
        /// Id of appliance
        /// </summary>
        /// <value>Id of appliance</value>

        [DataMember(Name="ApplianceId")]
        public string ApplianceId { get; set; }

        /// <summary>
        /// Name of appliance
        /// </summary>
        /// <value>Name of appliance</value>

        [DataMember(Name="ApplianceName")]
        public string ApplianceName { get; set; }

        /// <summary>
        /// JSON representation of log details (Read-only).
        /// </summary>
        /// <value>JSON representation of log details (Read-only).</value>

        [DataMember(Name="EventData")]
        public string EventData { get; set; }

        /// <summary>
        /// Name of the event
        /// </summary>
        /// <value>Name of the event</value>

        [DataMember(Name="EventDisplayName")]
        public string EventDisplayName { get; set; }

        /// <summary>
        /// Unique id of the user that authenticated.
        /// </summary>
        /// <value>Unique id of the user that authenticated.</value>

        [DataMember(Name="UserId")]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserProperties
        /// </summary>

        [DataMember(Name="UserProperties")]
        public UserLogProperties UserProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplianceLog {\n");
            sb.Append("  LogId: ").Append(LogId).Append("\n");
            sb.Append("  LogTime: ").Append(LogTime).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
            sb.Append("  EventData: ").Append(EventData).Append("\n");
            sb.Append("  EventDisplayName: ").Append(EventDisplayName).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ApplianceLog)obj);
        }

        /// <summary>
        /// Returns true if ApplianceLog instances are equal
        /// </summary>
        /// <param name="other">Instance of ApplianceLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplianceLog other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LogId == other.LogId ||
                    LogId != null &&
                    LogId.Equals(other.LogId)
                ) && 
                (
                    LogTime == other.LogTime ||
                    LogTime != null &&
                    LogTime.Equals(other.LogTime)
                ) && 
                (
                    EventName == other.EventName ||
                    EventName != null &&
                    EventName.Equals(other.EventName)
                ) && 
                (
                    ApplianceId == other.ApplianceId ||
                    ApplianceId != null &&
                    ApplianceId.Equals(other.ApplianceId)
                ) && 
                (
                    ApplianceName == other.ApplianceName ||
                    ApplianceName != null &&
                    ApplianceName.Equals(other.ApplianceName)
                ) && 
                (
                    EventData == other.EventData ||
                    EventData != null &&
                    EventData.Equals(other.EventData)
                ) && 
                (
                    EventDisplayName == other.EventDisplayName ||
                    EventDisplayName != null &&
                    EventDisplayName.Equals(other.EventDisplayName)
                ) && 
                (
                    UserId == other.UserId ||
                    UserId != null &&
                    UserId.Equals(other.UserId)
                ) && 
                (
                    UserProperties == other.UserProperties ||
                    UserProperties != null &&
                    UserProperties.Equals(other.UserProperties)
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
                    if (LogId != null)
                    hashCode = hashCode * 59 + LogId.GetHashCode();
                    if (LogTime != null)
                    hashCode = hashCode * 59 + LogTime.GetHashCode();
                    if (EventName != null)
                    hashCode = hashCode * 59 + EventName.GetHashCode();
                    if (ApplianceId != null)
                    hashCode = hashCode * 59 + ApplianceId.GetHashCode();
                    if (ApplianceName != null)
                    hashCode = hashCode * 59 + ApplianceName.GetHashCode();
                    if (EventData != null)
                    hashCode = hashCode * 59 + EventData.GetHashCode();
                    if (EventDisplayName != null)
                    hashCode = hashCode * 59 + EventDisplayName.GetHashCode();
                    if (UserId != null)
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    if (UserProperties != null)
                    hashCode = hashCode * 59 + UserProperties.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ApplianceLog left, ApplianceLog right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ApplianceLog left, ApplianceLog right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
