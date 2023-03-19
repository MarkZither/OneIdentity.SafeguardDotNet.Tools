using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserAccountEntitlement {
    /// <summary>
    /// ID of the user granted access
    /// </summary>
    /// <value>ID of the user granted access</value>
    [DataMember(Name="UserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserId")]
    public int? UserId { get; set; }

    /// <summary>
    /// DisplayName of the user granted access
    /// </summary>
    /// <value>DisplayName of the user granted access</value>
    [DataMember(Name="UserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserDisplayName")]
    public string UserDisplayName { get; set; }

    /// <summary>
    /// UserName of user granted access
    /// </summary>
    /// <value>UserName of user granted access</value>
    [DataMember(Name="UserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserName")]
    public string UserName { get; set; }

    /// <summary>
    /// DomainName of user granted access
    /// </summary>
    /// <value>DomainName of user granted access</value>
    [DataMember(Name="UserDomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserDomainName")]
    public string UserDomainName { get; set; }

    /// <summary>
    /// Administrative roles this user has been granted. e.g. GlobalAdmin, Auditor, ApplicationAuditor, SystemAuditor, AssetAdmin, ApplianceAdmin, PolicyAdmin, UserAdmin, HelpdeskAdmin, OperationsAdmin
    /// </summary>
    /// <value>Administrative roles this user has been granted. e.g. GlobalAdmin, Auditor, ApplicationAuditor, SystemAuditor, AssetAdmin, ApplianceAdmin, PolicyAdmin, UserAdmin, HelpdeskAdmin, OperationsAdmin</value>
    [DataMember(Name="AdminRoles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdminRoles")]
    public List<AdminRoleName> AdminRoles { get; set; }

    /// <summary>
    /// Whether this user owns any partitions
    /// </summary>
    /// <value>Whether this user owns any partitions</value>
    [DataMember(Name="IsPartitionOwner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPartitionOwner")]
    public bool? IsPartitionOwner { get; set; }

    /// <summary>
    /// ID of the asset granted access to
    /// </summary>
    /// <value>ID of the asset granted access to</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Name of the asset granted access to
    /// </summary>
    /// <value>Name of the asset granted access to</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Network address of the asset granted access to
    /// </summary>
    /// <value>Network address of the asset granted access to</value>
    [DataMember(Name="AssetNetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetNetworkAddress")]
    public string AssetNetworkAddress { get; set; }

    /// <summary>
    /// ID of the partition of the asset
    /// </summary>
    /// <value>ID of the partition of the asset</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of the partition of the asset
    /// </summary>
    /// <value>Name of the partition of the asset</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// ID of the account granted access to
    /// </summary>
    /// <value>ID of the account granted access to</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Name of the account granted access to
    /// </summary>
    /// <value>Name of the account granted access to</value>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Domain name of the account granted access to
    /// </summary>
    /// <value>Domain name of the account granted access to</value>
    [DataMember(Name="AccountDomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDomainName")]
    public string AccountDomainName { get; set; }

    /// <summary>
    /// ID of the asset the account belongs to
    /// </summary>
    /// <value>ID of the asset the account belongs to</value>
    [DataMember(Name="AccountAssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountAssetId")]
    public int? AccountAssetId { get; set; }

    /// <summary>
    /// Name of the asset the account belongs to
    /// </summary>
    /// <value>Name of the asset the account belongs to</value>
    [DataMember(Name="AccountAssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountAssetName")]
    public string AccountAssetName { get; set; }

    /// <summary>
    /// ID of the policy granting access
    /// </summary>
    /// <value>ID of the policy granting access</value>
    [DataMember(Name="AccessPolicyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessPolicyId")]
    public int? AccessPolicyId { get; set; }

    /// <summary>
    /// Name of the policy granting access
    /// </summary>
    /// <value>Name of the policy granting access</value>
    [DataMember(Name="AccessPolicyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessPolicyName")]
    public string AccessPolicyName { get; set; }

    /// <summary>
    /// Gets or Sets AccessRequestType
    /// </summary>
    [DataMember(Name="AccessRequestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessRequestType")]
    public AccessRequestType AccessRequestType { get; set; }

    /// <summary>
    /// Whether password access is also granted for session requests
    /// </summary>
    /// <value>Whether password access is also granted for session requests</value>
    [DataMember(Name="AllowSessionPasswordRelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSessionPasswordRelease")]
    public bool? AllowSessionPasswordRelease { get; set; }

    /// <summary>
    /// Whether SSH key access is also granted for session requests
    /// </summary>
    /// <value>Whether SSH key access is also granted for session requests</value>
    [DataMember(Name="AllowSessionSshKeyRelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSessionSshKeyRelease")]
    public bool? AllowSessionSshKeyRelease { get; set; }

    /// <summary>
    /// Whether password will be changed after requests are checked in
    /// </summary>
    /// <value>Whether password will be changed after requests are checked in</value>
    [DataMember(Name="ChangePasswordAfterCheckin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangePasswordAfterCheckin")]
    public bool? ChangePasswordAfterCheckin { get; set; }

    /// <summary>
    /// Whether the SSH key will be changed after requests are checked in
    /// </summary>
    /// <value>Whether the SSH key will be changed after requests are checked in</value>
    [DataMember(Name="ChangeSshKeyAfterCheckin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangeSshKeyAfterCheckin")]
    public bool? ChangeSshKeyAfterCheckin { get; set; }

    /// <summary>
    /// Whether the SSH key will be protected with a passphrase each time it is checked out
    /// </summary>
    /// <value>Whether the SSH key will be protected with a passphrase each time it is checked out</value>
    [DataMember(Name="PassphraseProtectSshKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PassphraseProtectSshKey")]
    public bool? PassphraseProtectSshKey { get; set; }

    /// <summary>
    /// ID of the role the policy belongs to
    /// </summary>
    /// <value>ID of the role the policy belongs to</value>
    [DataMember(Name="RoleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleId")]
    public int? RoleId { get; set; }

    /// <summary>
    /// Name of the role the policy belongs to
    /// </summary>
    /// <value>Name of the role the policy belongs to</value>
    [DataMember(Name="RoleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleName")]
    public string RoleName { get; set; }

    /// <summary>
    /// Effective expiration date of role/policy
    /// </summary>
    /// <value>Effective expiration date of role/policy</value>
    [DataMember(Name="EffectiveExpirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveExpirationDate")]
    public DateTime? EffectiveExpirationDate { get; set; }

    /// <summary>
    /// Gets or Sets EffectiveHourlyRestrictionProperties
    /// </summary>
    [DataMember(Name="EffectiveHourlyRestrictionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveHourlyRestrictionProperties")]
    public HourlyRestrictionProperties EffectiveHourlyRestrictionProperties { get; set; }

    /// <summary>
    /// ID of role member in the role granting access to user
    /// </summary>
    /// <value>ID of role member in the role granting access to user</value>
    [DataMember(Name="RoleIdentityId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleIdentityId")]
    public int? RoleIdentityId { get; set; }

    /// <summary>
    /// Name of role member in the role granting access to user
    /// </summary>
    /// <value>Name of role member in the role granting access to user</value>
    [DataMember(Name="RoleIdentityName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleIdentityName")]
    public string RoleIdentityName { get; set; }

    /// <summary>
    /// Gets or Sets RoleIdentityType
    /// </summary>
    [DataMember(Name="RoleIdentityType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleIdentityType")]
    public PrincipalKind RoleIdentityType { get; set; }

    /// <summary>
    /// Whether account is linked to the user
    /// </summary>
    /// <value>Whether account is linked to the user</value>
    [DataMember(Name="FromLinkedAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FromLinkedAccount")]
    public bool? FromLinkedAccount { get; set; }

    /// <summary>
    /// Gets or Sets AccountRequestType
    /// </summary>
    [DataMember(Name="AccountRequestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountRequestType")]
    public AccountRequestType AccountRequestType { get; set; }

    /// <summary>
    /// Last time the user last used password
    /// </summary>
    /// <value>Last time the user last used password</value>
    [DataMember(Name="PasswordLastAccessedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordLastAccessedDate")]
    public DateTime? PasswordLastAccessedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserAccountEntitlement {\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  UserDisplayName: ").Append(UserDisplayName).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  UserDomainName: ").Append(UserDomainName).Append("\n");
      sb.Append("  AdminRoles: ").Append(AdminRoles).Append("\n");
      sb.Append("  IsPartitionOwner: ").Append(IsPartitionOwner).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  AssetNetworkAddress: ").Append(AssetNetworkAddress).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
      sb.Append("  AccountAssetId: ").Append(AccountAssetId).Append("\n");
      sb.Append("  AccountAssetName: ").Append(AccountAssetName).Append("\n");
      sb.Append("  AccessPolicyId: ").Append(AccessPolicyId).Append("\n");
      sb.Append("  AccessPolicyName: ").Append(AccessPolicyName).Append("\n");
      sb.Append("  AccessRequestType: ").Append(AccessRequestType).Append("\n");
      sb.Append("  AllowSessionPasswordRelease: ").Append(AllowSessionPasswordRelease).Append("\n");
      sb.Append("  AllowSessionSshKeyRelease: ").Append(AllowSessionSshKeyRelease).Append("\n");
      sb.Append("  ChangePasswordAfterCheckin: ").Append(ChangePasswordAfterCheckin).Append("\n");
      sb.Append("  ChangeSshKeyAfterCheckin: ").Append(ChangeSshKeyAfterCheckin).Append("\n");
      sb.Append("  PassphraseProtectSshKey: ").Append(PassphraseProtectSshKey).Append("\n");
      sb.Append("  RoleId: ").Append(RoleId).Append("\n");
      sb.Append("  RoleName: ").Append(RoleName).Append("\n");
      sb.Append("  EffectiveExpirationDate: ").Append(EffectiveExpirationDate).Append("\n");
      sb.Append("  EffectiveHourlyRestrictionProperties: ").Append(EffectiveHourlyRestrictionProperties).Append("\n");
      sb.Append("  RoleIdentityId: ").Append(RoleIdentityId).Append("\n");
      sb.Append("  RoleIdentityName: ").Append(RoleIdentityName).Append("\n");
      sb.Append("  RoleIdentityType: ").Append(RoleIdentityType).Append("\n");
      sb.Append("  FromLinkedAccount: ").Append(FromLinkedAccount).Append("\n");
      sb.Append("  AccountRequestType: ").Append(AccountRequestType).Append("\n");
      sb.Append("  PasswordLastAccessedDate: ").Append(PasswordLastAccessedDate).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
