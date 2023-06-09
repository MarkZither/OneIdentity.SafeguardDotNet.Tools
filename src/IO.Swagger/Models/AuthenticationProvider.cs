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
    /// Available configurations for authentication
    /// </summary>
    [DataContract]
    public partial class AuthenticationProvider : IEquatable<AuthenticationProvider>
    { 
        /// <summary>
        /// Unique Id of authentication provider (Read-only)
        /// </summary>
        /// <value>Unique Id of authentication provider (Read-only)</value>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Name of the authentication provider (Read-only)
        /// </summary>
        /// <value>Name of the authentication provider (Read-only)</value>

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TypeReferenceName
        /// </summary>

        [DataMember(Name="TypeReferenceName")]
        public IdentityProviderTypeReferenceName TypeReferenceName { get; set; }

        /// <summary>
        /// Unique ID of related identity provider (Read-only)
        /// </summary>
        /// <value>Unique ID of related identity provider (Read-only)</value>

        [DataMember(Name="IdentityProviderId")]
        public int? IdentityProviderId { get; set; }

        /// <summary>
        /// RSTS provider identifier (Read-only)
        /// </summary>
        /// <value>RSTS provider identifier (Read-only)</value>

        [DataMember(Name="RstsProviderId")]
        public string RstsProviderId { get; set; }

        /// <summary>
        /// RSTS provider scope (Read-only)
        /// </summary>
        /// <value>RSTS provider scope (Read-only)</value>

        [DataMember(Name="RstsProviderScope")]
        public string RstsProviderScope { get; set; }

        /// <summary>
        /// When set to {true} on a provider, the login page will not display a drop down list              of all available providers. Instead, the end user will be defaulted in to using this provider.              Only one provider can be marked with {true} at a time. When updating a provider and setting              this to {true}, this will be automatically set to {false} on all other providers.
        /// </summary>
        /// <value>When set to {true} on a provider, the login page will not display a drop down list              of all available providers. Instead, the end user will be defaulted in to using this provider.              Only one provider can be marked with {true} at a time. When updating a provider and setting              this to {true}, this will be automatically set to {false} on all other providers.</value>

        [DataMember(Name="ForceAsDefault")]
        public bool? ForceAsDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticationProvider {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TypeReferenceName: ").Append(TypeReferenceName).Append("\n");
            sb.Append("  IdentityProviderId: ").Append(IdentityProviderId).Append("\n");
            sb.Append("  RstsProviderId: ").Append(RstsProviderId).Append("\n");
            sb.Append("  RstsProviderScope: ").Append(RstsProviderScope).Append("\n");
            sb.Append("  ForceAsDefault: ").Append(ForceAsDefault).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AuthenticationProvider)obj);
        }

        /// <summary>
        /// Returns true if AuthenticationProvider instances are equal
        /// </summary>
        /// <param name="other">Instance of AuthenticationProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticationProvider other)
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
                    TypeReferenceName == other.TypeReferenceName ||
                    TypeReferenceName != null &&
                    TypeReferenceName.Equals(other.TypeReferenceName)
                ) && 
                (
                    IdentityProviderId == other.IdentityProviderId ||
                    IdentityProviderId != null &&
                    IdentityProviderId.Equals(other.IdentityProviderId)
                ) && 
                (
                    RstsProviderId == other.RstsProviderId ||
                    RstsProviderId != null &&
                    RstsProviderId.Equals(other.RstsProviderId)
                ) && 
                (
                    RstsProviderScope == other.RstsProviderScope ||
                    RstsProviderScope != null &&
                    RstsProviderScope.Equals(other.RstsProviderScope)
                ) && 
                (
                    ForceAsDefault == other.ForceAsDefault ||
                    ForceAsDefault != null &&
                    ForceAsDefault.Equals(other.ForceAsDefault)
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
                    if (TypeReferenceName != null)
                    hashCode = hashCode * 59 + TypeReferenceName.GetHashCode();
                    if (IdentityProviderId != null)
                    hashCode = hashCode * 59 + IdentityProviderId.GetHashCode();
                    if (RstsProviderId != null)
                    hashCode = hashCode * 59 + RstsProviderId.GetHashCode();
                    if (RstsProviderScope != null)
                    hashCode = hashCode * 59 + RstsProviderScope.GetHashCode();
                    if (ForceAsDefault != null)
                    hashCode = hashCode * 59 + ForceAsDefault.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AuthenticationProvider left, AuthenticationProvider right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AuthenticationProvider left, AuthenticationProvider right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
