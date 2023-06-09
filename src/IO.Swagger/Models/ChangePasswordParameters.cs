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
    /// Information needed to change the current user password
    /// </summary>
    [DataContract]
    public partial class ChangePasswordParameters : IEquatable<ChangePasswordParameters>
    { 
        /// <summary>
        /// The current password
        /// </summary>
        /// <value>The current password</value>
        [Required]

        [DataMember(Name="OldPassword")]
        public string OldPassword { get; set; }

        /// <summary>
        /// The password to set
        /// </summary>
        /// <value>The password to set</value>
        [Required]

        [DataMember(Name="NewPassword")]
        public string NewPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangePasswordParameters {\n");
            sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ChangePasswordParameters)obj);
        }

        /// <summary>
        /// Returns true if ChangePasswordParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of ChangePasswordParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangePasswordParameters other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OldPassword == other.OldPassword ||
                    OldPassword != null &&
                    OldPassword.Equals(other.OldPassword)
                ) && 
                (
                    NewPassword == other.NewPassword ||
                    NewPassword != null &&
                    NewPassword.Equals(other.NewPassword)
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
                    if (OldPassword != null)
                    hashCode = hashCode * 59 + OldPassword.GetHashCode();
                    if (NewPassword != null)
                    hashCode = hashCode * 59 + NewPassword.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ChangePasswordParameters left, ChangePasswordParameters right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ChangePasswordParameters left, ChangePasswordParameters right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
