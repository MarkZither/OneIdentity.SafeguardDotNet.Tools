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
    /// Represents an Identity.  The Identity is either a group or a user.
    /// </summary>
    [DataContract]
    public partial class Identity : IEquatable<Identity>
    { 
        /// <summary>
        /// Display name of the Identity (Read-only)
        /// </summary>
        /// <value>Display name of the Identity (Read-only)</value>

        [DataMember(Name="DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Database ID of the Identity (Read-only)
        /// </summary>
        /// <value>Database ID of the Identity (Read-only)</value>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Database ID of the identity provider (Read-only)
        /// </summary>
        /// <value>Database ID of the identity provider (Read-only)</value>

        [DataMember(Name="IdentityProviderId")]
        public int? IdentityProviderId { get; set; }

        /// <summary>
        /// Name of the identity provider (Read-only)
        /// </summary>
        /// <value>Name of the identity provider (Read-only)</value>

        [DataMember(Name="IdentityProviderName")]
        public string IdentityProviderName { get; set; }

        /// <summary>
        /// Gets or Sets IdentityProviderTypeReferenceName
        /// </summary>

        [DataMember(Name="IdentityProviderTypeReferenceName")]
        public IdentityProviderTypeReferenceName IdentityProviderTypeReferenceName { get; set; }

        /// <summary>
        /// Whether this identity is owned by the system and cannot be deleted (Read-only)
        /// </summary>
        /// <value>Whether this identity is owned by the system and cannot be deleted (Read-only)</value>

        [DataMember(Name="IsSystemOwned")]
        public bool? IsSystemOwned { get; set; }

        /// <summary>
        /// Name of the Identity (Read-only)
        /// </summary>
        /// <value>Name of the Identity (Read-only)</value>

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalKind
        /// </summary>

        [DataMember(Name="PrincipalKind")]
        public PrincipalKind PrincipalKind { get; set; }

        /// <summary>
        /// Email address of the Identity if applicable (Read-only)
        /// </summary>
        /// <value>Email address of the Identity if applicable (Read-only)</value>

        [DataMember(Name="EmailAddress")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Domain name of the Identity (Read-only)
        /// </summary>
        /// <value>Domain name of the Identity (Read-only)</value>

        [DataMember(Name="DomainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Full display name of the Identity (Read-only)
        /// </summary>
        /// <value>Full display name of the Identity (Read-only)</value>

        [DataMember(Name="FullDisplayName")]
        public string FullDisplayName { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Identity {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdentityProviderId: ").Append(IdentityProviderId).Append("\n");
            sb.Append("  IdentityProviderName: ").Append(IdentityProviderName).Append("\n");
            sb.Append("  IdentityProviderTypeReferenceName: ").Append(IdentityProviderTypeReferenceName).Append("\n");
            sb.Append("  IsSystemOwned: ").Append(IsSystemOwned).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PrincipalKind: ").Append(PrincipalKind).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  FullDisplayName: ").Append(FullDisplayName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Identity)obj);
        }

        /// <summary>
        /// Returns true if Identity instances are equal
        /// </summary>
        /// <param name="other">Instance of Identity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Identity other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DisplayName == other.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    IdentityProviderId == other.IdentityProviderId ||
                    IdentityProviderId != null &&
                    IdentityProviderId.Equals(other.IdentityProviderId)
                ) && 
                (
                    IdentityProviderName == other.IdentityProviderName ||
                    IdentityProviderName != null &&
                    IdentityProviderName.Equals(other.IdentityProviderName)
                ) && 
                (
                    IdentityProviderTypeReferenceName == other.IdentityProviderTypeReferenceName ||
                    IdentityProviderTypeReferenceName != null &&
                    IdentityProviderTypeReferenceName.Equals(other.IdentityProviderTypeReferenceName)
                ) && 
                (
                    IsSystemOwned == other.IsSystemOwned ||
                    IsSystemOwned != null &&
                    IsSystemOwned.Equals(other.IsSystemOwned)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    PrincipalKind == other.PrincipalKind ||
                    PrincipalKind != null &&
                    PrincipalKind.Equals(other.PrincipalKind)
                ) && 
                (
                    EmailAddress == other.EmailAddress ||
                    EmailAddress != null &&
                    EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    DomainName == other.DomainName ||
                    DomainName != null &&
                    DomainName.Equals(other.DomainName)
                ) && 
                (
                    FullDisplayName == other.FullDisplayName ||
                    FullDisplayName != null &&
                    FullDisplayName.Equals(other.FullDisplayName)
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
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (IdentityProviderId != null)
                    hashCode = hashCode * 59 + IdentityProviderId.GetHashCode();
                    if (IdentityProviderName != null)
                    hashCode = hashCode * 59 + IdentityProviderName.GetHashCode();
                    if (IdentityProviderTypeReferenceName != null)
                    hashCode = hashCode * 59 + IdentityProviderTypeReferenceName.GetHashCode();
                    if (IsSystemOwned != null)
                    hashCode = hashCode * 59 + IsSystemOwned.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (PrincipalKind != null)
                    hashCode = hashCode * 59 + PrincipalKind.GetHashCode();
                    if (EmailAddress != null)
                    hashCode = hashCode * 59 + EmailAddress.GetHashCode();
                    if (DomainName != null)
                    hashCode = hashCode * 59 + DomainName.GetHashCode();
                    if (FullDisplayName != null)
                    hashCode = hashCode * 59 + FullDisplayName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Identity left, Identity right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Identity left, Identity right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
