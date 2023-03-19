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
    /// Represents an remote asset account
    /// </summary>
    [DataContract]
    public partial class DeletedAssetAccount : IEquatable<DeletedAssetAccount>
    { 
        /// <summary>
        /// The database ID of the account (Read-only)
        /// </summary>
        /// <value>The database ID of the account (Read-only)</value>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the account
        /// </summary>
        /// <value>The name of the account</value>

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// The distinguished name of the account (required for ACF2-Ldap)
        /// </summary>
        /// <value>The distinguished name of the account (required for ACF2-Ldap)</value>

        [DataMember(Name="DistinguishedName")]
        public string DistinguishedName { get; set; }

        /// <summary>
        /// Name of the domain this object is from. Required if this is an object to import from a directory.
        /// </summary>
        /// <value>Name of the domain this object is from. Required if this is an object to import from a directory.</value>

        [DataMember(Name="DomainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// A short description of the account.
        /// </summary>
        /// <value>A short description of the account.</value>

        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// Date this entity was created (Read-only)
        /// </summary>
        /// <value>Date this entity was created (Read-only)</value>

        [DataMember(Name="CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// The database ID of the user that created this entity (Read-only)
        /// </summary>
        /// <value>The database ID of the user that created this entity (Read-only)</value>

        [DataMember(Name="CreatedByUserId")]
        public int? CreatedByUserId { get; set; }

        /// <summary>
        /// The display name of the user that created this entity (Read-only)
        /// </summary>
        /// <value>The display name of the user that created this entity (Read-only)</value>

        [DataMember(Name="CreatedByUserDisplayName")]
        public string CreatedByUserDisplayName { get; set; }

        /// <summary>
        /// Date this entity was deleted (Read-only)
        /// </summary>
        /// <value>Date this entity was deleted (Read-only)</value>

        [DataMember(Name="DeletedDate")]
        public DateTime? DeletedDate { get; set; }

        /// <summary>
        /// The database ID of the user that deleted this entity (Read-only)
        /// </summary>
        /// <value>The database ID of the user that deleted this entity (Read-only)</value>

        [DataMember(Name="DeletedByUserId")]
        public int? DeletedByUserId { get; set; }

        /// <summary>
        /// The display name of the user that deleted this entity (Read-only)
        /// </summary>
        /// <value>The display name of the user that deleted this entity (Read-only)</value>

        [DataMember(Name="DeletedByUserDisplayName")]
        public string DeletedByUserDisplayName { get; set; }

        /// <summary>
        /// Whether this account has been disabled. Prevent it from being used for access requests and automated password tasks (Read-only)
        /// </summary>
        /// <value>Whether this account has been disabled. Prevent it from being used for access requests and automated password tasks (Read-only)</value>

        [DataMember(Name="Disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Whether this account is a service account or not (Read-only)
        /// </summary>
        /// <value>Whether this account is a service account or not (Read-only)</value>

        [DataMember(Name="IsServiceAccount")]
        public bool? IsServiceAccount { get; set; }

        /// <summary>
        /// Whether this account can be used as a service account for other assets (only valid for directory accounts)
        /// </summary>
        /// <value>Whether this account can be used as a service account for other assets (only valid for directory accounts)</value>

        [DataMember(Name="SharedServiceAccount")]
        public bool? SharedServiceAccount { get; set; }

        /// <summary>
        /// Gets or Sets DirectoryProperties
        /// </summary>

        [DataMember(Name="DirectoryProperties")]
        public DirectoryAccountProperties DirectoryProperties { get; set; }

        /// <summary>
        /// Gets or Sets Asset
        /// </summary>

        [DataMember(Name="Asset")]
        public AccountAssetProperties Asset { get; set; }

        /// <summary>
        /// Gets or Sets PasswordProfile
        /// </summary>

        [DataMember(Name="PasswordProfile")]
        public AccountProfileProperties PasswordProfile { get; set; }

        /// <summary>
        /// Gets or Sets SshKeyProfile
        /// </summary>

        [DataMember(Name="SshKeyProfile")]
        public AccountSshKeyProfileProperties SshKeyProfile { get; set; }

        /// <summary>
        /// Gets or Sets RequestProperties
        /// </summary>

        [DataMember(Name="RequestProperties")]
        public AccountRequestProperties RequestProperties { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>

        [DataMember(Name="Platform")]
        public AccountPlatformProperties Platform { get; set; }

        /// <summary>
        /// Gets or Sets SyncGroup
        /// </summary>

        [DataMember(Name="SyncGroup")]
        public AccountSyncGroupProperties SyncGroup { get; set; }

        /// <summary>
        /// Gets or Sets SshKeySyncGroup
        /// </summary>

        [DataMember(Name="SshKeySyncGroup")]
        public AccountSshKeySyncGroupProperties SshKeySyncGroup { get; set; }

        /// <summary>
        /// Gets or Sets DiscoveredProperties
        /// </summary>

        [DataMember(Name="DiscoveredProperties")]
        public DiscoveredAccountProperties DiscoveredProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletedAssetAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DistinguishedName: ").Append(DistinguishedName).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
            sb.Append("  DeletedDate: ").Append(DeletedDate).Append("\n");
            sb.Append("  DeletedByUserId: ").Append(DeletedByUserId).Append("\n");
            sb.Append("  DeletedByUserDisplayName: ").Append(DeletedByUserDisplayName).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  IsServiceAccount: ").Append(IsServiceAccount).Append("\n");
            sb.Append("  SharedServiceAccount: ").Append(SharedServiceAccount).Append("\n");
            sb.Append("  DirectoryProperties: ").Append(DirectoryProperties).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  PasswordProfile: ").Append(PasswordProfile).Append("\n");
            sb.Append("  SshKeyProfile: ").Append(SshKeyProfile).Append("\n");
            sb.Append("  RequestProperties: ").Append(RequestProperties).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  SyncGroup: ").Append(SyncGroup).Append("\n");
            sb.Append("  SshKeySyncGroup: ").Append(SshKeySyncGroup).Append("\n");
            sb.Append("  DiscoveredProperties: ").Append(DiscoveredProperties).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DeletedAssetAccount)obj);
        }

        /// <summary>
        /// Returns true if DeletedAssetAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of DeletedAssetAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeletedAssetAccount other)
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
                    DistinguishedName == other.DistinguishedName ||
                    DistinguishedName != null &&
                    DistinguishedName.Equals(other.DistinguishedName)
                ) && 
                (
                    DomainName == other.DomainName ||
                    DomainName != null &&
                    DomainName.Equals(other.DomainName)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    CreatedDate == other.CreatedDate ||
                    CreatedDate != null &&
                    CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    CreatedByUserId == other.CreatedByUserId ||
                    CreatedByUserId != null &&
                    CreatedByUserId.Equals(other.CreatedByUserId)
                ) && 
                (
                    CreatedByUserDisplayName == other.CreatedByUserDisplayName ||
                    CreatedByUserDisplayName != null &&
                    CreatedByUserDisplayName.Equals(other.CreatedByUserDisplayName)
                ) && 
                (
                    DeletedDate == other.DeletedDate ||
                    DeletedDate != null &&
                    DeletedDate.Equals(other.DeletedDate)
                ) && 
                (
                    DeletedByUserId == other.DeletedByUserId ||
                    DeletedByUserId != null &&
                    DeletedByUserId.Equals(other.DeletedByUserId)
                ) && 
                (
                    DeletedByUserDisplayName == other.DeletedByUserDisplayName ||
                    DeletedByUserDisplayName != null &&
                    DeletedByUserDisplayName.Equals(other.DeletedByUserDisplayName)
                ) && 
                (
                    Disabled == other.Disabled ||
                    Disabled != null &&
                    Disabled.Equals(other.Disabled)
                ) && 
                (
                    IsServiceAccount == other.IsServiceAccount ||
                    IsServiceAccount != null &&
                    IsServiceAccount.Equals(other.IsServiceAccount)
                ) && 
                (
                    SharedServiceAccount == other.SharedServiceAccount ||
                    SharedServiceAccount != null &&
                    SharedServiceAccount.Equals(other.SharedServiceAccount)
                ) && 
                (
                    DirectoryProperties == other.DirectoryProperties ||
                    DirectoryProperties != null &&
                    DirectoryProperties.Equals(other.DirectoryProperties)
                ) && 
                (
                    Asset == other.Asset ||
                    Asset != null &&
                    Asset.Equals(other.Asset)
                ) && 
                (
                    PasswordProfile == other.PasswordProfile ||
                    PasswordProfile != null &&
                    PasswordProfile.Equals(other.PasswordProfile)
                ) && 
                (
                    SshKeyProfile == other.SshKeyProfile ||
                    SshKeyProfile != null &&
                    SshKeyProfile.Equals(other.SshKeyProfile)
                ) && 
                (
                    RequestProperties == other.RequestProperties ||
                    RequestProperties != null &&
                    RequestProperties.Equals(other.RequestProperties)
                ) && 
                (
                    Platform == other.Platform ||
                    Platform != null &&
                    Platform.Equals(other.Platform)
                ) && 
                (
                    SyncGroup == other.SyncGroup ||
                    SyncGroup != null &&
                    SyncGroup.Equals(other.SyncGroup)
                ) && 
                (
                    SshKeySyncGroup == other.SshKeySyncGroup ||
                    SshKeySyncGroup != null &&
                    SshKeySyncGroup.Equals(other.SshKeySyncGroup)
                ) && 
                (
                    DiscoveredProperties == other.DiscoveredProperties ||
                    DiscoveredProperties != null &&
                    DiscoveredProperties.Equals(other.DiscoveredProperties)
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
                    if (DistinguishedName != null)
                    hashCode = hashCode * 59 + DistinguishedName.GetHashCode();
                    if (DomainName != null)
                    hashCode = hashCode * 59 + DomainName.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (CreatedDate != null)
                    hashCode = hashCode * 59 + CreatedDate.GetHashCode();
                    if (CreatedByUserId != null)
                    hashCode = hashCode * 59 + CreatedByUserId.GetHashCode();
                    if (CreatedByUserDisplayName != null)
                    hashCode = hashCode * 59 + CreatedByUserDisplayName.GetHashCode();
                    if (DeletedDate != null)
                    hashCode = hashCode * 59 + DeletedDate.GetHashCode();
                    if (DeletedByUserId != null)
                    hashCode = hashCode * 59 + DeletedByUserId.GetHashCode();
                    if (DeletedByUserDisplayName != null)
                    hashCode = hashCode * 59 + DeletedByUserDisplayName.GetHashCode();
                    if (Disabled != null)
                    hashCode = hashCode * 59 + Disabled.GetHashCode();
                    if (IsServiceAccount != null)
                    hashCode = hashCode * 59 + IsServiceAccount.GetHashCode();
                    if (SharedServiceAccount != null)
                    hashCode = hashCode * 59 + SharedServiceAccount.GetHashCode();
                    if (DirectoryProperties != null)
                    hashCode = hashCode * 59 + DirectoryProperties.GetHashCode();
                    if (Asset != null)
                    hashCode = hashCode * 59 + Asset.GetHashCode();
                    if (PasswordProfile != null)
                    hashCode = hashCode * 59 + PasswordProfile.GetHashCode();
                    if (SshKeyProfile != null)
                    hashCode = hashCode * 59 + SshKeyProfile.GetHashCode();
                    if (RequestProperties != null)
                    hashCode = hashCode * 59 + RequestProperties.GetHashCode();
                    if (Platform != null)
                    hashCode = hashCode * 59 + Platform.GetHashCode();
                    if (SyncGroup != null)
                    hashCode = hashCode * 59 + SyncGroup.GetHashCode();
                    if (SshKeySyncGroup != null)
                    hashCode = hashCode * 59 + SshKeySyncGroup.GetHashCode();
                    if (DiscoveredProperties != null)
                    hashCode = hashCode * 59 + DiscoveredProperties.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DeletedAssetAccount left, DeletedAssetAccount right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DeletedAssetAccount left, DeletedAssetAccount right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}