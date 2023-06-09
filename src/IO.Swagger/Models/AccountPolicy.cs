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
    /// Represents a policy that an account belongs to plus how that membership was granted
    /// </summary>
    [DataContract]
    public partial class AccountPolicy : IEquatable<AccountPolicy>
    { 
        /// <summary>
        /// Database ID of the policy the account belongs to
        /// </summary>
        /// <value>Database ID of the policy the account belongs to</value>

        [DataMember(Name="PolicyId")]
        public int? PolicyId { get; set; }

        /// <summary>
        /// Name of the policy the account belongs to
        /// </summary>
        /// <value>Name of the policy the account belongs to</value>

        [DataMember(Name="PolicyName")]
        public string PolicyName { get; set; }

        /// <summary>
        /// Gets or Sets AccessRequestType
        /// </summary>

        [DataMember(Name="AccessRequestType")]
        public AccessRequestType AccessRequestType { get; set; }

        /// <summary>
        /// Database ID of the role the policy belongs to
        /// </summary>
        /// <value>Database ID of the role the policy belongs to</value>

        [DataMember(Name="RoleId")]
        public int? RoleId { get; set; }

        /// <summary>
        /// Name of the role the policy belongs to
        /// </summary>
        /// <value>Name of the role the policy belongs to</value>

        [DataMember(Name="RoleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// Database ID of the account
        /// </summary>
        /// <value>Database ID of the account</value>

        [DataMember(Name="AccountId")]
        public int? AccountId { get; set; }

        /// <summary>
        /// Name of the account
        /// </summary>
        /// <value>Name of the account</value>

        [DataMember(Name="AccountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Database ID of the asset the account belongs to
        /// </summary>
        /// <value>Database ID of the asset the account belongs to</value>

        [DataMember(Name="AssetId")]
        public int? AssetId { get; set; }

        /// <summary>
        /// Name of the asset the account belongs to
        /// </summary>
        /// <value>Name of the asset the account belongs to</value>

        [DataMember(Name="AssetName")]
        public string AssetName { get; set; }

        /// <summary>
        /// Number of assets in the policy
        /// </summary>
        /// <value>Number of assets in the policy</value>

        [DataMember(Name="PolicyAssetCount")]
        public int? PolicyAssetCount { get; set; }

        /// <summary>
        /// Number of asset groups in the policy
        /// </summary>
        /// <value>Number of asset groups in the policy</value>

        [DataMember(Name="PolicyAssetGroupCount")]
        public int? PolicyAssetGroupCount { get; set; }

        /// <summary>
        /// Number of accounts in the policy
        /// </summary>
        /// <value>Number of accounts in the policy</value>

        [DataMember(Name="PolicyAccountCount")]
        public int? PolicyAccountCount { get; set; }

        /// <summary>
        /// Number of account groups in the policy
        /// </summary>
        /// <value>Number of account groups in the policy</value>

        [DataMember(Name="PolicyAccountGroupCount")]
        public int? PolicyAccountGroupCount { get; set; }

        /// <summary>
        /// How this policy membership was explicitly granted (Read-Only)
        /// </summary>
        /// <value>How this policy membership was explicitly granted (Read-Only)</value>

        [DataMember(Name="Membership")]
        public List<AccountPolicyMembership> Membership { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountPolicy {\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
            sb.Append("  AccessRequestType: ").Append(AccessRequestType).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetName: ").Append(AssetName).Append("\n");
            sb.Append("  PolicyAssetCount: ").Append(PolicyAssetCount).Append("\n");
            sb.Append("  PolicyAssetGroupCount: ").Append(PolicyAssetGroupCount).Append("\n");
            sb.Append("  PolicyAccountCount: ").Append(PolicyAccountCount).Append("\n");
            sb.Append("  PolicyAccountGroupCount: ").Append(PolicyAccountGroupCount).Append("\n");
            sb.Append("  Membership: ").Append(Membership).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AccountPolicy)obj);
        }

        /// <summary>
        /// Returns true if AccountPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountPolicy other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PolicyId == other.PolicyId ||
                    PolicyId != null &&
                    PolicyId.Equals(other.PolicyId)
                ) && 
                (
                    PolicyName == other.PolicyName ||
                    PolicyName != null &&
                    PolicyName.Equals(other.PolicyName)
                ) && 
                (
                    AccessRequestType == other.AccessRequestType ||
                    AccessRequestType != null &&
                    AccessRequestType.Equals(other.AccessRequestType)
                ) && 
                (
                    RoleId == other.RoleId ||
                    RoleId != null &&
                    RoleId.Equals(other.RoleId)
                ) && 
                (
                    RoleName == other.RoleName ||
                    RoleName != null &&
                    RoleName.Equals(other.RoleName)
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
                    PolicyAssetCount == other.PolicyAssetCount ||
                    PolicyAssetCount != null &&
                    PolicyAssetCount.Equals(other.PolicyAssetCount)
                ) && 
                (
                    PolicyAssetGroupCount == other.PolicyAssetGroupCount ||
                    PolicyAssetGroupCount != null &&
                    PolicyAssetGroupCount.Equals(other.PolicyAssetGroupCount)
                ) && 
                (
                    PolicyAccountCount == other.PolicyAccountCount ||
                    PolicyAccountCount != null &&
                    PolicyAccountCount.Equals(other.PolicyAccountCount)
                ) && 
                (
                    PolicyAccountGroupCount == other.PolicyAccountGroupCount ||
                    PolicyAccountGroupCount != null &&
                    PolicyAccountGroupCount.Equals(other.PolicyAccountGroupCount)
                ) && 
                (
                    Membership == other.Membership ||
                    Membership != null &&
                    Membership.SequenceEqual(other.Membership)
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
                    if (PolicyId != null)
                    hashCode = hashCode * 59 + PolicyId.GetHashCode();
                    if (PolicyName != null)
                    hashCode = hashCode * 59 + PolicyName.GetHashCode();
                    if (AccessRequestType != null)
                    hashCode = hashCode * 59 + AccessRequestType.GetHashCode();
                    if (RoleId != null)
                    hashCode = hashCode * 59 + RoleId.GetHashCode();
                    if (RoleName != null)
                    hashCode = hashCode * 59 + RoleName.GetHashCode();
                    if (AccountId != null)
                    hashCode = hashCode * 59 + AccountId.GetHashCode();
                    if (AccountName != null)
                    hashCode = hashCode * 59 + AccountName.GetHashCode();
                    if (AssetId != null)
                    hashCode = hashCode * 59 + AssetId.GetHashCode();
                    if (AssetName != null)
                    hashCode = hashCode * 59 + AssetName.GetHashCode();
                    if (PolicyAssetCount != null)
                    hashCode = hashCode * 59 + PolicyAssetCount.GetHashCode();
                    if (PolicyAssetGroupCount != null)
                    hashCode = hashCode * 59 + PolicyAssetGroupCount.GetHashCode();
                    if (PolicyAccountCount != null)
                    hashCode = hashCode * 59 + PolicyAccountCount.GetHashCode();
                    if (PolicyAccountGroupCount != null)
                    hashCode = hashCode * 59 + PolicyAccountGroupCount.GetHashCode();
                    if (Membership != null)
                    hashCode = hashCode * 59 + Membership.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AccountPolicy left, AccountPolicy right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AccountPolicy left, AccountPolicy right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
