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
    public partial class DiscoveredSshKey : IEquatable<DiscoveredSshKey>
    { 
        /// <summary>
        /// The date the ssh key was discovered
        /// </summary>
        /// <value>The date the ssh key was discovered</value>

        [DataMember(Name="DiscoveredDate")]
        public DateTime? DiscoveredDate { get; set; }

        /// <summary>
        /// Name of the account for which this ssh key was discovered
        /// </summary>
        /// <value>Name of the account for which this ssh key was discovered</value>

        [DataMember(Name="AccountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Domain name of the account for which this ssh key was discovered
        /// </summary>
        /// <value>Domain name of the account for which this ssh key was discovered</value>

        [DataMember(Name="AccountDomainName")]
        public string AccountDomainName { get; set; }

        /// <summary>
        /// Database ID of the account for which this ssh key was discovered
        /// </summary>
        /// <value>Database ID of the account for which this ssh key was discovered</value>

        [DataMember(Name="AccountId")]
        public int? AccountId { get; set; }

        /// <summary>
        /// Name of the asset on which this ssh key was discovered
        /// </summary>
        /// <value>Name of the asset on which this ssh key was discovered</value>

        [DataMember(Name="AssetName")]
        public string AssetName { get; set; }

        /// <summary>
        /// Database ID of the asset on which this ssh key was discovered
        /// </summary>
        /// <value>Database ID of the asset on which this ssh key was discovered</value>

        [DataMember(Name="AssetId")]
        public int? AssetId { get; set; }

        /// <summary>
        /// Database identifier for the asset partition on which this ssh key was discovered
        /// </summary>
        /// <value>Database identifier for the asset partition on which this ssh key was discovered</value>

        [DataMember(Name="AssetPartitionId")]
        public int? AssetPartitionId { get; set; }

        /// <summary>
        /// Name of the asset partition on which this ssh key was discovered
        /// </summary>
        /// <value>Name of the asset partition on which this ssh key was discovered</value>

        [DataMember(Name="AssetPartitionName")]
        public string AssetPartitionName { get; set; }

        /// <summary>
        /// Database Id of the profile used to discover the ssh key
        /// </summary>
        /// <value>Database Id of the profile used to discover the ssh key</value>

        [DataMember(Name="SshKeyProfileId")]
        public int? SshKeyProfileId { get; set; }

        /// <summary>
        /// Name of profile used to discover the ssh key
        /// </summary>
        /// <value>Name of profile used to discover the ssh key</value>

        [DataMember(Name="SshKeyProfileName")]
        public string SshKeyProfileName { get; set; }

        /// <summary>
        /// Database Id of the ssh key discovery schedule used to discover the ssh key
        /// </summary>
        /// <value>Database Id of the ssh key discovery schedule used to discover the ssh key</value>

        [DataMember(Name="SshKeyDiscoveryScheduleId")]
        public int? SshKeyDiscoveryScheduleId { get; set; }

        /// <summary>
        /// Name of ssh key discovery schedule used to discover the ssh key
        /// </summary>
        /// <value>Name of ssh key discovery schedule used to discover the ssh key</value>

        [DataMember(Name="SshKeyDiscoveryScheduleName")]
        public string SshKeyDiscoveryScheduleName { get; set; }

        /// <summary>
        /// Public key represented in base64
        /// </summary>
        /// <value>Public key represented in base64</value>

        [DataMember(Name="PublicKey")]
        public string PublicKey { get; set; }

        /// <summary>
        /// Comment associated with key
        /// </summary>
        /// <value>Comment associated with key</value>

        [DataMember(Name="Comment")]
        public string Comment { get; set; }

        /// <summary>
        /// The MD5 fingerprint hash of the SSH key (Read-only)
        /// </summary>
        /// <value>The MD5 fingerprint hash of the SSH key (Read-only)</value>

        [DataMember(Name="Fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// The SHA256 fingerprint hash, Base64 encoded, of the SSH key. (Read-only)
        /// </summary>
        /// <value>The SHA256 fingerprint hash, Base64 encoded, of the SSH key. (Read-only)</value>

        [DataMember(Name="FingerprintSha256")]
        public string FingerprintSha256 { get; set; }

        /// <summary>
        /// Gets or Sets KeyType
        /// </summary>

        [DataMember(Name="KeyType")]
        public SshKeyType KeyType { get; set; }

        /// <summary>
        /// Options associated with key
        /// </summary>
        /// <value>Options associated with key</value>

        [DataMember(Name="Options")]
        public string Options { get; set; }

        /// <summary>
        /// Length of SSH key
        /// </summary>
        /// <value>Length of SSH key</value>

        [DataMember(Name="KeyLength")]
        public int? KeyLength { get; set; }

        /// <summary>
        /// Gets or Sets AccountStatus
        /// </summary>

        [DataMember(Name="AccountStatus")]
        public DiscoveredAccountStatus AccountStatus { get; set; }

        /// <summary>
        /// Whether the private key is managed by Safeguard
        /// </summary>
        /// <value>Whether the private key is managed by Safeguard</value>

        [DataMember(Name="IsManaged")]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscoveredSshKey {\n");
            sb.Append("  DiscoveredDate: ").Append(DiscoveredDate).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AssetName: ").Append(AssetName).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
            sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
            sb.Append("  SshKeyProfileId: ").Append(SshKeyProfileId).Append("\n");
            sb.Append("  SshKeyProfileName: ").Append(SshKeyProfileName).Append("\n");
            sb.Append("  SshKeyDiscoveryScheduleId: ").Append(SshKeyDiscoveryScheduleId).Append("\n");
            sb.Append("  SshKeyDiscoveryScheduleName: ").Append(SshKeyDiscoveryScheduleName).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  FingerprintSha256: ").Append(FingerprintSha256).Append("\n");
            sb.Append("  KeyType: ").Append(KeyType).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  KeyLength: ").Append(KeyLength).Append("\n");
            sb.Append("  AccountStatus: ").Append(AccountStatus).Append("\n");
            sb.Append("  IsManaged: ").Append(IsManaged).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DiscoveredSshKey)obj);
        }

        /// <summary>
        /// Returns true if DiscoveredSshKey instances are equal
        /// </summary>
        /// <param name="other">Instance of DiscoveredSshKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscoveredSshKey other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DiscoveredDate == other.DiscoveredDate ||
                    DiscoveredDate != null &&
                    DiscoveredDate.Equals(other.DiscoveredDate)
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
                    AccountId == other.AccountId ||
                    AccountId != null &&
                    AccountId.Equals(other.AccountId)
                ) && 
                (
                    AssetName == other.AssetName ||
                    AssetName != null &&
                    AssetName.Equals(other.AssetName)
                ) && 
                (
                    AssetId == other.AssetId ||
                    AssetId != null &&
                    AssetId.Equals(other.AssetId)
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
                    SshKeyProfileId == other.SshKeyProfileId ||
                    SshKeyProfileId != null &&
                    SshKeyProfileId.Equals(other.SshKeyProfileId)
                ) && 
                (
                    SshKeyProfileName == other.SshKeyProfileName ||
                    SshKeyProfileName != null &&
                    SshKeyProfileName.Equals(other.SshKeyProfileName)
                ) && 
                (
                    SshKeyDiscoveryScheduleId == other.SshKeyDiscoveryScheduleId ||
                    SshKeyDiscoveryScheduleId != null &&
                    SshKeyDiscoveryScheduleId.Equals(other.SshKeyDiscoveryScheduleId)
                ) && 
                (
                    SshKeyDiscoveryScheduleName == other.SshKeyDiscoveryScheduleName ||
                    SshKeyDiscoveryScheduleName != null &&
                    SshKeyDiscoveryScheduleName.Equals(other.SshKeyDiscoveryScheduleName)
                ) && 
                (
                    PublicKey == other.PublicKey ||
                    PublicKey != null &&
                    PublicKey.Equals(other.PublicKey)
                ) && 
                (
                    Comment == other.Comment ||
                    Comment != null &&
                    Comment.Equals(other.Comment)
                ) && 
                (
                    Fingerprint == other.Fingerprint ||
                    Fingerprint != null &&
                    Fingerprint.Equals(other.Fingerprint)
                ) && 
                (
                    FingerprintSha256 == other.FingerprintSha256 ||
                    FingerprintSha256 != null &&
                    FingerprintSha256.Equals(other.FingerprintSha256)
                ) && 
                (
                    KeyType == other.KeyType ||
                    KeyType != null &&
                    KeyType.Equals(other.KeyType)
                ) && 
                (
                    Options == other.Options ||
                    Options != null &&
                    Options.Equals(other.Options)
                ) && 
                (
                    KeyLength == other.KeyLength ||
                    KeyLength != null &&
                    KeyLength.Equals(other.KeyLength)
                ) && 
                (
                    AccountStatus == other.AccountStatus ||
                    AccountStatus != null &&
                    AccountStatus.Equals(other.AccountStatus)
                ) && 
                (
                    IsManaged == other.IsManaged ||
                    IsManaged != null &&
                    IsManaged.Equals(other.IsManaged)
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
                    if (DiscoveredDate != null)
                    hashCode = hashCode * 59 + DiscoveredDate.GetHashCode();
                    if (AccountName != null)
                    hashCode = hashCode * 59 + AccountName.GetHashCode();
                    if (AccountDomainName != null)
                    hashCode = hashCode * 59 + AccountDomainName.GetHashCode();
                    if (AccountId != null)
                    hashCode = hashCode * 59 + AccountId.GetHashCode();
                    if (AssetName != null)
                    hashCode = hashCode * 59 + AssetName.GetHashCode();
                    if (AssetId != null)
                    hashCode = hashCode * 59 + AssetId.GetHashCode();
                    if (AssetPartitionId != null)
                    hashCode = hashCode * 59 + AssetPartitionId.GetHashCode();
                    if (AssetPartitionName != null)
                    hashCode = hashCode * 59 + AssetPartitionName.GetHashCode();
                    if (SshKeyProfileId != null)
                    hashCode = hashCode * 59 + SshKeyProfileId.GetHashCode();
                    if (SshKeyProfileName != null)
                    hashCode = hashCode * 59 + SshKeyProfileName.GetHashCode();
                    if (SshKeyDiscoveryScheduleId != null)
                    hashCode = hashCode * 59 + SshKeyDiscoveryScheduleId.GetHashCode();
                    if (SshKeyDiscoveryScheduleName != null)
                    hashCode = hashCode * 59 + SshKeyDiscoveryScheduleName.GetHashCode();
                    if (PublicKey != null)
                    hashCode = hashCode * 59 + PublicKey.GetHashCode();
                    if (Comment != null)
                    hashCode = hashCode * 59 + Comment.GetHashCode();
                    if (Fingerprint != null)
                    hashCode = hashCode * 59 + Fingerprint.GetHashCode();
                    if (FingerprintSha256 != null)
                    hashCode = hashCode * 59 + FingerprintSha256.GetHashCode();
                    if (KeyType != null)
                    hashCode = hashCode * 59 + KeyType.GetHashCode();
                    if (Options != null)
                    hashCode = hashCode * 59 + Options.GetHashCode();
                    if (KeyLength != null)
                    hashCode = hashCode * 59 + KeyLength.GetHashCode();
                    if (AccountStatus != null)
                    hashCode = hashCode * 59 + AccountStatus.GetHashCode();
                    if (IsManaged != null)
                    hashCode = hashCode * 59 + IsManaged.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DiscoveredSshKey left, DiscoveredSshKey right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DiscoveredSshKey left, DiscoveredSshKey right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
