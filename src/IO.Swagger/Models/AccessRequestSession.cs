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
    /// Information about sessions initialized using this request
    /// </summary>
    [DataContract]
    public partial class AccessRequestSession : IEquatable<AccessRequestSession>
    { 
        /// <summary>
        /// Unique ID of session for request
        /// </summary>
        /// <value>Unique ID of session for request</value>

        [DataMember(Name="SessionId")]
        public int? SessionId { get; set; }

        /// <summary>
        /// Date session was initialized
        /// </summary>
        /// <value>Date session was initialized</value>

        [DataMember(Name="InitializedDate")]
        public DateTime? InitializedDate { get; set; }

        /// <summary>
        /// Date session connected to target asset
        /// </summary>
        /// <value>Date session connected to target asset</value>

        [DataMember(Name="ConnectedDate")]
        public DateTime? ConnectedDate { get; set; }

        /// <summary>
        /// Date session was terminated
        /// </summary>
        /// <value>Date session was terminated</value>

        [DataMember(Name="TerminatedDate")]
        public DateTime? TerminatedDate { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>

        [DataMember(Name="State")]
        public SessionState State { get; set; }

        /// <summary>
        /// Whether session was recorded
        /// </summary>
        /// <value>Whether session was recorded</value>

        [DataMember(Name="HasRecording")]
        public bool? HasRecording { get; set; }

        /// <summary>
        /// Appliance ID session was run on
        /// </summary>
        /// <value>Appliance ID session was run on</value>

        [DataMember(Name="ApplianceId")]
        public string ApplianceId { get; set; }

        /// <summary>
        /// Appliance name session was run on
        /// </summary>
        /// <value>Appliance name session was run on</value>

        [DataMember(Name="ApplianceName")]
        public string ApplianceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessRequestSession {\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  InitializedDate: ").Append(InitializedDate).Append("\n");
            sb.Append("  ConnectedDate: ").Append(ConnectedDate).Append("\n");
            sb.Append("  TerminatedDate: ").Append(TerminatedDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  HasRecording: ").Append(HasRecording).Append("\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AccessRequestSession)obj);
        }

        /// <summary>
        /// Returns true if AccessRequestSession instances are equal
        /// </summary>
        /// <param name="other">Instance of AccessRequestSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessRequestSession other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SessionId == other.SessionId ||
                    SessionId != null &&
                    SessionId.Equals(other.SessionId)
                ) && 
                (
                    InitializedDate == other.InitializedDate ||
                    InitializedDate != null &&
                    InitializedDate.Equals(other.InitializedDate)
                ) && 
                (
                    ConnectedDate == other.ConnectedDate ||
                    ConnectedDate != null &&
                    ConnectedDate.Equals(other.ConnectedDate)
                ) && 
                (
                    TerminatedDate == other.TerminatedDate ||
                    TerminatedDate != null &&
                    TerminatedDate.Equals(other.TerminatedDate)
                ) && 
                (
                    State == other.State ||
                    State != null &&
                    State.Equals(other.State)
                ) && 
                (
                    HasRecording == other.HasRecording ||
                    HasRecording != null &&
                    HasRecording.Equals(other.HasRecording)
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
                    if (SessionId != null)
                    hashCode = hashCode * 59 + SessionId.GetHashCode();
                    if (InitializedDate != null)
                    hashCode = hashCode * 59 + InitializedDate.GetHashCode();
                    if (ConnectedDate != null)
                    hashCode = hashCode * 59 + ConnectedDate.GetHashCode();
                    if (TerminatedDate != null)
                    hashCode = hashCode * 59 + TerminatedDate.GetHashCode();
                    if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                    if (HasRecording != null)
                    hashCode = hashCode * 59 + HasRecording.GetHashCode();
                    if (ApplianceId != null)
                    hashCode = hashCode * 59 + ApplianceId.GetHashCode();
                    if (ApplianceName != null)
                    hashCode = hashCode * 59 + ApplianceName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AccessRequestSession left, AccessRequestSession right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AccessRequestSession left, AccessRequestSession right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
