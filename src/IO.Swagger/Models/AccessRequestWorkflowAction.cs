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
    /// Represents an action taken to a access request
    /// </summary>
    [DataContract]
    public partial class AccessRequestWorkflowAction : IEquatable<AccessRequestWorkflowAction>
    { 
        /// <summary>
        /// Gets or Sets ActionType
        /// </summary>

        [DataMember(Name="ActionType")]
        public AccessRequestStateAction ActionType { get; set; }

        /// <summary>
        /// Optional information about the action taken
        /// </summary>
        /// <value>Optional information about the action taken</value>

        [MaxLength(255)]
        [DataMember(Name="Comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets NewState
        /// </summary>

        [DataMember(Name="NewState")]
        public AccessRequestState NewState { get; set; }

        /// <summary>
        /// The UTC Date/Time the action took place
        /// </summary>
        /// <value>The UTC Date/Time the action took place</value>

        [DataMember(Name="OccurredOn")]
        public DateTime? OccurredOn { get; set; }

        /// <summary>
        /// Gets or Sets OldState
        /// </summary>

        [DataMember(Name="OldState")]
        public AccessRequestState OldState { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>

        [DataMember(Name="User")]
        public Identity User { get; set; }

        /// <summary>
        /// Identifier for the session that was initialized (if applicable)
        /// </summary>
        /// <value>Identifier for the session that was initialized (if applicable)</value>

        [DataMember(Name="SessionId")]
        public int? SessionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessRequestWorkflowAction {\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  NewState: ").Append(NewState).Append("\n");
            sb.Append("  OccurredOn: ").Append(OccurredOn).Append("\n");
            sb.Append("  OldState: ").Append(OldState).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AccessRequestWorkflowAction)obj);
        }

        /// <summary>
        /// Returns true if AccessRequestWorkflowAction instances are equal
        /// </summary>
        /// <param name="other">Instance of AccessRequestWorkflowAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessRequestWorkflowAction other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ActionType == other.ActionType ||
                    ActionType != null &&
                    ActionType.Equals(other.ActionType)
                ) && 
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.Equals(other.Comment)
                ) && 
                (
                    NewState == other.NewState ||
                    NewState != null &&
                    NewState.Equals(other.NewState)
                ) && 
                (
                    OccurredOn == other.OccurredOn ||
                    OccurredOn != null &&
                    OccurredOn.Equals(other.OccurredOn)
                ) && 
                (
                    OldState == other.OldState ||
                    OldState != null &&
                    OldState.Equals(other.OldState)
                ) && 
                (
                    User == other.User ||
                    User != null &&
                    User.Equals(other.User)
                ) && 
                (
                    SessionId == other.SessionId ||
                    SessionId != null &&
                    SessionId.Equals(other.SessionId)
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
                    if (ActionType != null)
                    hashCode = hashCode * 59 + ActionType.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                    if (NewState != null)
                    hashCode = hashCode * 59 + NewState.GetHashCode();
                    if (OccurredOn != null)
                    hashCode = hashCode * 59 + OccurredOn.GetHashCode();
                    if (OldState != null)
                    hashCode = hashCode * 59 + OldState.GetHashCode();
                    if (User != null)
                    hashCode = hashCode * 59 + User.GetHashCode();
                    if (SessionId != null)
                    hashCode = hashCode * 59 + SessionId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AccessRequestWorkflowAction left, AccessRequestWorkflowAction right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AccessRequestWorkflowAction left, AccessRequestWorkflowAction right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
