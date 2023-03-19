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
    public partial class UserOwnershipDetail : IEquatable<UserOwnershipDetail>
    { 
        /// <summary>
        /// Gets or Sets OwnershipType
        /// </summary>

        [DataMember(Name="OwnershipType")]
        public OwnershipType OwnershipType { get; set; }

        /// <summary>
        /// ID of the owned item (PartitionId, AssetId, or AccountId)
        /// </summary>
        /// <value>ID of the owned item (PartitionId, AssetId, or AccountId)</value>

        [DataMember(Name="ItemId")]
        public int? ItemId { get; set; }

        /// <summary>
        /// ID of the partition
        /// </summary>
        /// <value>ID of the partition</value>

        [DataMember(Name="AssetPartitionId")]
        public int? AssetPartitionId { get; set; }

        /// <summary>
        /// Name of the partition
        /// </summary>
        /// <value>Name of the partition</value>

        [DataMember(Name="AssetPartitionName")]
        public string AssetPartitionName { get; set; }

        /// <summary>
        /// ID of the asset owne
        /// </summary>
        /// <value>ID of the asset owne</value>

        [DataMember(Name="AssetId")]
        public int? AssetId { get; set; }

        /// <summary>
        /// Name of the asset owned
        /// </summary>
        /// <value>Name of the asset owned</value>

        [DataMember(Name="AssetName")]
        public string AssetName { get; set; }

        /// <summary>
        /// Network address of the asset owned
        /// </summary>
        /// <value>Network address of the asset owned</value>

        [DataMember(Name="AssetNetworkAddress")]
        public string AssetNetworkAddress { get; set; }

        /// <summary>
        /// ID of the account owned
        /// </summary>
        /// <value>ID of the account owned</value>

        [DataMember(Name="AccountId")]
        public int? AccountId { get; set; }

        /// <summary>
        /// Name of the account owned
        /// </summary>
        /// <value>Name of the account owned</value>

        [DataMember(Name="AccountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Domain name of the account owned
        /// </summary>
        /// <value>Domain name of the account owned</value>

        [DataMember(Name="AccountDomainName")]
        public string AccountDomainName { get; set; }

        /// <summary>
        /// ID of the tag (applies to tag ownership report)
        /// </summary>
        /// <value>ID of the tag (applies to tag ownership report)</value>

        [DataMember(Name="TagId")]
        public int? TagId { get; set; }

        /// <summary>
        /// Name of the tag (applies to tag ownership report)
        /// </summary>
        /// <value>Name of the tag (applies to tag ownership report)</value>

        [DataMember(Name="TagName")]
        public string TagName { get; set; }

        /// <summary>
        /// ID of the user who is an owner
        /// </summary>
        /// <value>ID of the user who is an owner</value>

        [DataMember(Name="UserId")]
        public int? UserId { get; set; }

        /// <summary>
        /// DisplayName of the user who is an owner
        /// </summary>
        /// <value>DisplayName of the user who is an owner</value>

        [DataMember(Name="UserDisplayName")]
        public string UserDisplayName { get; set; }

        /// <summary>
        /// UserName of user who is an owner
        /// </summary>
        /// <value>UserName of user who is an owner</value>

        [DataMember(Name="UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// DomainName of user who is an owner
        /// </summary>
        /// <value>DomainName of user who is an owner</value>

        [DataMember(Name="UserDomainName")]
        public string UserDomainName { get; set; }

        /// <summary>
        /// How ownership was assigned
        /// </summary>
        /// <value>How ownership was assigned</value>

        [DataMember(Name="IsDirect")]
        public bool? IsDirect { get; set; }

        /// <summary>
        /// How ownership was assigned
        /// </summary>
        /// <value>How ownership was assigned</value>

        [DataMember(Name="IsTag")]
        public bool? IsTag { get; set; }

        /// <summary>
        /// A list of direct groups the identity is a part of that grants the identity access to the resource.
        /// </summary>
        /// <value>A list of direct groups the identity is a part of that grants the identity access to the resource.</value>

        [DataMember(Name="ViaDirectGroups")]
        public List<Identity> ViaDirectGroups { get; set; }

        /// <summary>
        /// A list of tag groups the identity is a part of that grants the identity access to the resource.
        /// </summary>
        /// <value>A list of tag groups the identity is a part of that grants the identity access to the resource.</value>

        [DataMember(Name="ViaTagGroups")]
        public List<Identity> ViaTagGroups { get; set; }

        /// <summary>
        /// A list of tags the identity is a part of that grants the identity access to the resource.
        /// </summary>
        /// <value>A list of tags the identity is a part of that grants the identity access to the resource.</value>

        [DataMember(Name="ViaTags")]
        public List<PartitionTag> ViaTags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserOwnershipDetail {\n");
            sb.Append("  OwnershipType: ").Append(OwnershipType).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
            sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetName: ").Append(AssetName).Append("\n");
            sb.Append("  AssetNetworkAddress: ").Append(AssetNetworkAddress).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
            sb.Append("  TagName: ").Append(TagName).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserDisplayName: ").Append(UserDisplayName).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UserDomainName: ").Append(UserDomainName).Append("\n");
            sb.Append("  IsDirect: ").Append(IsDirect).Append("\n");
            sb.Append("  IsTag: ").Append(IsTag).Append("\n");
            sb.Append("  ViaDirectGroups: ").Append(ViaDirectGroups).Append("\n");
            sb.Append("  ViaTagGroups: ").Append(ViaTagGroups).Append("\n");
            sb.Append("  ViaTags: ").Append(ViaTags).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UserOwnershipDetail)obj);
        }

        /// <summary>
        /// Returns true if UserOwnershipDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of UserOwnershipDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserOwnershipDetail other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OwnershipType == other.OwnershipType ||
                    OwnershipType != null &&
                    OwnershipType.Equals(other.OwnershipType)
                ) && 
                (
                    ItemId == other.ItemId ||
                    ItemId != null &&
                    ItemId.Equals(other.ItemId)
                ) && 
                (
                    AssetPartitionId == other.AssetPartitionId ||
                    AssetPartitionId != null &&
                    AssetPartitionId.Equals(other.AssetPartitionId)
                ) && 
                (
                    AssetPartitionName == other.AssetPartitionName ||
                    AssetPartitionName != null &&
                    AssetPartitionName.Equals(other.AssetPartitionName)
                ) && 
                (
                    AssetId == other.AssetId ||
                    AssetId != null &&
                    AssetId.Equals(other.AssetId)
                ) && 
                (
                    AssetName == other.AssetName ||
                    AssetName != null &&
                    AssetName.Equals(other.AssetName)
                ) && 
                (
                    AssetNetworkAddress == other.AssetNetworkAddress ||
                    AssetNetworkAddress != null &&
                    AssetNetworkAddress.Equals(other.AssetNetworkAddress)
                ) && 
                (
                    AccountId == other.AccountId ||
                    AccountId != null &&
                    AccountId.Equals(other.AccountId)
                ) && 
                (
                    AccountName == other.AccountName ||
                    AccountName != null &&
                    AccountName.Equals(other.AccountName)
                ) && 
                (
                    AccountDomainName == other.AccountDomainName ||
                    AccountDomainName != null &&
                    AccountDomainName.Equals(other.AccountDomainName)
                ) && 
                (
                    TagId == other.TagId ||
                    TagId != null &&
                    TagId.Equals(other.TagId)
                ) && 
                (
                    TagName == other.TagName ||
                    TagName != null &&
                    TagName.Equals(other.TagName)
                ) && 
                (
                    UserId == other.UserId ||
                    UserId != null &&
                    UserId.Equals(other.UserId)
                ) && 
                (
                    UserDisplayName == other.UserDisplayName ||
                    UserDisplayName != null &&
                    UserDisplayName.Equals(other.UserDisplayName)
                ) && 
                (
                    UserName == other.UserName ||
                    UserName != null &&
                    UserName.Equals(other.UserName)
                ) && 
                (
                    UserDomainName == other.UserDomainName ||
                    UserDomainName != null &&
                    UserDomainName.Equals(other.UserDomainName)
                ) && 
                (
                    IsDirect == other.IsDirect ||
                    IsDirect != null &&
                    IsDirect.Equals(other.IsDirect)
                ) && 
                (
                    IsTag == other.IsTag ||
                    IsTag != null &&
                    IsTag.Equals(other.IsTag)
                ) && 
                (
                    ViaDirectGroups == other.ViaDirectGroups ||
                    ViaDirectGroups != null &&
                    ViaDirectGroups.SequenceEqual(other.ViaDirectGroups)
                ) && 
                (
                    ViaTagGroups == other.ViaTagGroups ||
                    ViaTagGroups != null &&
                    ViaTagGroups.SequenceEqual(other.ViaTagGroups)
                ) && 
                (
                    ViaTags == other.ViaTags ||
                    ViaTags != null &&
                    ViaTags.SequenceEqual(other.ViaTags)
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
                    if (OwnershipType != null)
                    hashCode = hashCode * 59 + OwnershipType.GetHashCode();
                    if (ItemId != null)
                    hashCode = hashCode * 59 + ItemId.GetHashCode();
                    if (AssetPartitionId != null)
                    hashCode = hashCode * 59 + AssetPartitionId.GetHashCode();
                    if (AssetPartitionName != null)
                    hashCode = hashCode * 59 + AssetPartitionName.GetHashCode();
                    if (AssetId != null)
                    hashCode = hashCode * 59 + AssetId.GetHashCode();
                    if (AssetName != null)
                    hashCode = hashCode * 59 + AssetName.GetHashCode();
                    if (AssetNetworkAddress != null)
                    hashCode = hashCode * 59 + AssetNetworkAddress.GetHashCode();
                    if (AccountId != null)
                    hashCode = hashCode * 59 + AccountId.GetHashCode();
                    if (AccountName != null)
                    hashCode = hashCode * 59 + AccountName.GetHashCode();
                    if (AccountDomainName != null)
                    hashCode = hashCode * 59 + AccountDomainName.GetHashCode();
                    if (TagId != null)
                    hashCode = hashCode * 59 + TagId.GetHashCode();
                    if (TagName != null)
                    hashCode = hashCode * 59 + TagName.GetHashCode();
                    if (UserId != null)
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    if (UserDisplayName != null)
                    hashCode = hashCode * 59 + UserDisplayName.GetHashCode();
                    if (UserName != null)
                    hashCode = hashCode * 59 + UserName.GetHashCode();
                    if (UserDomainName != null)
                    hashCode = hashCode * 59 + UserDomainName.GetHashCode();
                    if (IsDirect != null)
                    hashCode = hashCode * 59 + IsDirect.GetHashCode();
                    if (IsTag != null)
                    hashCode = hashCode * 59 + IsTag.GetHashCode();
                    if (ViaDirectGroups != null)
                    hashCode = hashCode * 59 + ViaDirectGroups.GetHashCode();
                    if (ViaTagGroups != null)
                    hashCode = hashCode * 59 + ViaTagGroups.GetHashCode();
                    if (ViaTags != null)
                    hashCode = hashCode * 59 + ViaTags.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UserOwnershipDetail left, UserOwnershipDetail right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserOwnershipDetail left, UserOwnershipDetail right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
