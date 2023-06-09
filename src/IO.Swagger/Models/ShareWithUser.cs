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
    public partial class ShareWithUser : IEquatable<ShareWithUser>
    { 
        /// <summary>
        /// The user&#x27;s unique ID.  This is a system-assigned value that is generated when a user is first created. (Read-only)
        /// </summary>
        /// <value>The user&#x27;s unique ID.  This is a system-assigned value that is generated when a user is first created. (Read-only)</value>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Friendly identifier of the user&#x27;s identity in Safeguard.  Must be unique per identity provider.
        /// </summary>
        /// <value>Friendly identifier of the user&#x27;s identity in Safeguard.  Must be unique per identity provider.</value>
        [Required]

        [MaxLength(255)]
        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of this user
        /// </summary>
        /// <value>Description of this user</value>

        [MaxLength(255)]
        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// The user&#x27;s display name (Read-only)
        /// </summary>
        /// <value>The user&#x27;s display name (Read-only)</value>

        [DataMember(Name="DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The user&#x27;s last name. No double quotes.
        /// </summary>
        /// <value>The user&#x27;s last name. No double quotes.</value>

        [StringLength(30, MinimumLength=1)]
        [DataMember(Name="LastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The user&#x27;s first name. No double quotes.
        /// </summary>
        /// <value>The user&#x27;s first name. No double quotes.</value>

        [StringLength(30, MinimumLength=1)]
        [DataMember(Name="FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The user&#x27;s email address.
        /// </summary>
        /// <value>The user&#x27;s email address.</value>

        [MaxLength(255)]
        [DataMember(Name="EmailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The user&#x27;s work phone number.
        /// </summary>
        /// <value>The user&#x27;s work phone number.</value>

        [MaxLength(30)]
        [DataMember(Name="WorkPhone")]
        public string WorkPhone { get; set; }

        /// <summary>
        /// The user&#x27;s mobile phone number.
        /// </summary>
        /// <value>The user&#x27;s mobile phone number.</value>

        [MaxLength(30)]
        [DataMember(Name="MobilePhone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Binary photo data. Base64 encoded.  Limited to 64 KB when decoded.  Must be a valid BMP, GIF, JPEG, PNG, or TIFF image.
        /// </summary>
        /// <value>Binary photo data. Base64 encoded.  Limited to 64 KB when decoded.  Must be a valid BMP, GIF, JPEG, PNG, or TIFF image.</value>

        [DataMember(Name="Base64PhotoData")]
        public string Base64PhotoData { get; set; }

        /// <summary>
        /// Gets or Sets DirectoryProperties
        /// </summary>

        [DataMember(Name="DirectoryProperties")]
        public DirectoryObjectProperties DirectoryProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShareWithUser {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
            sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  Base64PhotoData: ").Append(Base64PhotoData).Append("\n");
            sb.Append("  DirectoryProperties: ").Append(DirectoryProperties).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ShareWithUser)obj);
        }

        /// <summary>
        /// Returns true if ShareWithUser instances are equal
        /// </summary>
        /// <param name="other">Instance of ShareWithUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShareWithUser other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    DisplayName == other.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    LastName == other.LastName ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
                ) && 
                (
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    EmailAddress == other.EmailAddress ||
                    EmailAddress != null &&
                    EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    WorkPhone == other.WorkPhone ||
                    WorkPhone != null &&
                    WorkPhone.Equals(other.WorkPhone)
                ) && 
                (
                    MobilePhone == other.MobilePhone ||
                    MobilePhone != null &&
                    MobilePhone.Equals(other.MobilePhone)
                ) && 
                (
                    Base64PhotoData == other.Base64PhotoData ||
                    Base64PhotoData != null &&
                    Base64PhotoData.Equals(other.Base64PhotoData)
                ) && 
                (
                    DirectoryProperties == other.DirectoryProperties ||
                    DirectoryProperties != null &&
                    DirectoryProperties.Equals(other.DirectoryProperties)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (EmailAddress != null)
                    hashCode = hashCode * 59 + EmailAddress.GetHashCode();
                    if (WorkPhone != null)
                    hashCode = hashCode * 59 + WorkPhone.GetHashCode();
                    if (MobilePhone != null)
                    hashCode = hashCode * 59 + MobilePhone.GetHashCode();
                    if (Base64PhotoData != null)
                    hashCode = hashCode * 59 + Base64PhotoData.GetHashCode();
                    if (DirectoryProperties != null)
                    hashCode = hashCode * 59 + DirectoryProperties.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ShareWithUser left, ShareWithUser right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ShareWithUser left, ShareWithUser right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
