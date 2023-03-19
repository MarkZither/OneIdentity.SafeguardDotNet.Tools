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
    public partial class SendTestEmailParameters : IEquatable<SendTestEmailParameters>
    { 
        /// <summary>
        /// Gets or Sets EventName
        /// </summary>

        [DataMember(Name="EventName")]
        public EventName EventName { get; set; }

        /// <summary>
        /// The Reply-To address to use when generating email notifications from this template.
        /// </summary>
        /// <value>The Reply-To address to use when generating email notifications from this template.</value>

        [MaxLength(512)]
        [DataMember(Name="ReplyToEmail")]
        public string ReplyToEmail { get; set; }

        /// <summary>
        /// The subject line template. Mustache-style tags are supported for insertion of event property data. See also Event for definitions of event property data.
        /// </summary>
        /// <value>The subject line template. Mustache-style tags are supported for insertion of event property data. See also Event for definitions of event property data.</value>
        [Required]

        [MaxLength(1024)]
        [DataMember(Name="SubjectTemplate")]
        public string SubjectTemplate { get; set; }

        /// <summary>
        /// The body template. Mustache-style tags are supported for insertion of event property data. See also Event for definitions of event property data.
        /// </summary>
        /// <value>The body template. Mustache-style tags are supported for insertion of event property data. See also Event for definitions of event property data.</value>
        [Required]

        [MaxLength(16384)]
        [DataMember(Name="BodyTemplate")]
        public string BodyTemplate { get; set; }

        /// <summary>
        /// Gets or Sets _Event
        /// </summary>

        [DataMember(Name="Event")]
        public ModelEvent _Event { get; set; }

        /// <summary>
        /// Email address to send test email to
        /// </summary>
        /// <value>Email address to send test email to</value>
        [Required]

        [DataMember(Name="ToEmail")]
        public string ToEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendTestEmailParameters {\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  ReplyToEmail: ").Append(ReplyToEmail).Append("\n");
            sb.Append("  SubjectTemplate: ").Append(SubjectTemplate).Append("\n");
            sb.Append("  BodyTemplate: ").Append(BodyTemplate).Append("\n");
            sb.Append("  _Event: ").Append(_Event).Append("\n");
            sb.Append("  ToEmail: ").Append(ToEmail).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SendTestEmailParameters)obj);
        }

        /// <summary>
        /// Returns true if SendTestEmailParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of SendTestEmailParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendTestEmailParameters other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    EventName == other.EventName ||
                    EventName != null &&
                    EventName.Equals(other.EventName)
                ) && 
                (
                    ReplyToEmail == other.ReplyToEmail ||
                    ReplyToEmail != null &&
                    ReplyToEmail.Equals(other.ReplyToEmail)
                ) && 
                (
                    SubjectTemplate == other.SubjectTemplate ||
                    SubjectTemplate != null &&
                    SubjectTemplate.Equals(other.SubjectTemplate)
                ) && 
                (
                    BodyTemplate == other.BodyTemplate ||
                    BodyTemplate != null &&
                    BodyTemplate.Equals(other.BodyTemplate)
                ) && 
                (
                    _Event == other._Event ||
                    _Event != null &&
                    _Event.Equals(other._Event)
                ) && 
                (
                    ToEmail == other.ToEmail ||
                    ToEmail != null &&
                    ToEmail.Equals(other.ToEmail)
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
                    if (EventName != null)
                    hashCode = hashCode * 59 + EventName.GetHashCode();
                    if (ReplyToEmail != null)
                    hashCode = hashCode * 59 + ReplyToEmail.GetHashCode();
                    if (SubjectTemplate != null)
                    hashCode = hashCode * 59 + SubjectTemplate.GetHashCode();
                    if (BodyTemplate != null)
                    hashCode = hashCode * 59 + BodyTemplate.GetHashCode();
                    if (_Event != null)
                    hashCode = hashCode * 59 + _Event.GetHashCode();
                    if (ToEmail != null)
                    hashCode = hashCode * 59 + ToEmail.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SendTestEmailParameters left, SendTestEmailParameters right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SendTestEmailParameters left, SendTestEmailParameters right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}