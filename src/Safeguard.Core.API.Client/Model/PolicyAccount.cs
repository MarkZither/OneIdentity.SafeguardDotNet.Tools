using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an remote asset account available for request. A PolicyAccount is an   alternate view of an account that is used for AccessPolicies, AccountGroups,  and UserFavorites. The account must have a password and have AllowPasswordRequest set to true  in order to be used in UserFavorites or to be able to request the password of the account.
  /// </summary>
  [DataContract]
  public class PolicyAccount {
    /// <summary>
    /// The database key of the account (Read-only)
    /// </summary>
    /// <value>The database key of the account (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the account (Read-only)
    /// </summary>
    /// <value>The name of the account (Read-only)</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// A short description of the account. (Read-only)
    /// </summary>
    /// <value>A short description of the account. (Read-only)</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Whether the account has a password set or not (Read-only)
    /// </summary>
    /// <value>Whether the account has a password set or not (Read-only)</value>
    [DataMember(Name="HasPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasPassword")]
    public bool? HasPassword { get; set; }

    /// <summary>
    /// Whether the account has an SSH key assigned or not (Read-only)
    /// </summary>
    /// <value>Whether the account has an SSH key assigned or not (Read-only)</value>
    [DataMember(Name="HasSshKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasSshKey")]
    public bool? HasSshKey { get; set; }

    /// <summary>
    /// The domain name that the account belongs to. (Read-only)
    /// </summary>
    /// <value>The domain name that the account belongs to. (Read-only)</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// The distinguished name of the account. (Read-only)
    /// </summary>
    /// <value>The distinguished name of the account. (Read-only)</value>
    [DataMember(Name="DistinguishedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DistinguishedName")]
    public string DistinguishedName { get; set; }

    /// <summary>
    /// The netbios name of the domain the account is from. (Read-only)
    /// </summary>
    /// <value>The netbios name of the domain the account is from. (Read-only)</value>
    [DataMember(Name="NetBiosName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetBiosName")]
    public string NetBiosName { get; set; }

    /// <summary>
    /// Whether this account has been disabled. Prevent it from being used for access requests and automated password tasks (Read-only)
    /// </summary>
    /// <value>Whether this account has been disabled. Prevent it from being used for access requests and automated password tasks (Read-only)</value>
    [DataMember(Name="Disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Gets or Sets AccountType
    /// </summary>
    [DataMember(Name="AccountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountType")]
    public AccountType AccountType { get; set; }

    /// <summary>
    /// Whether this account is being used as a service account (Read-only)
    /// </summary>
    /// <value>Whether this account is being used as a service account (Read-only)</value>
    [DataMember(Name="IsServiceAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsServiceAccount")]
    public bool? IsServiceAccount { get; set; }

    /// <summary>
    /// Only notify account owners that password must be changed or account must be restored/suspended rather than running immediately (Read-only)
    /// </summary>
    /// <value>Only notify account owners that password must be changed or account must be restored/suspended rather than running immediately (Read-only)</value>
    [DataMember(Name="NotifyOwnersOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NotifyOwnersOnly")]
    public bool? NotifyOwnersOnly { get; set; }

    /// <summary>
    /// Whether an account should be suspended when it is checked in. Will be restored when made available for check out. (Read-only)
    /// </summary>
    /// <value>Whether an account should be suspended when it is checked in. Will be restored when made available for check out. (Read-only)</value>
    [DataMember(Name="SuspendAccountWhenCheckedIn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SuspendAccountWhenCheckedIn")]
    public bool? SuspendAccountWhenCheckedIn { get; set; }

    /// <summary>
    /// The alternate login name of the account. (Read-only)
    /// </summary>
    /// <value>The alternate login name of the account. (Read-only)</value>
    [DataMember(Name="AltLoginName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AltLoginName")]
    public string AltLoginName { get; set; }

    /// <summary>
    /// The number of users linked to the policy account (Read-only)
    /// </summary>
    /// <value>The number of users linked to the policy account (Read-only)</value>
    [DataMember(Name="LinkedUsersCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LinkedUsersCount")]
    public int? LinkedUsersCount { get; set; }

    /// <summary>
    /// Gets or Sets RequestProperties
    /// </summary>
    [DataMember(Name="RequestProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestProperties")]
    public AccountRequestProperties RequestProperties { get; set; }

    /// <summary>
    /// Gets or Sets Platform
    /// </summary>
    [DataMember(Name="Platform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Platform")]
    public AccountPlatformProperties Platform { get; set; }

    /// <summary>
    /// Gets or Sets Asset
    /// </summary>
    [DataMember(Name="Asset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Asset")]
    public AccountAssetProperties Asset { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PolicyAccount {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  HasPassword: ").Append(HasPassword).Append("\n");
      sb.Append("  HasSshKey: ").Append(HasSshKey).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  DistinguishedName: ").Append(DistinguishedName).Append("\n");
      sb.Append("  NetBiosName: ").Append(NetBiosName).Append("\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  IsServiceAccount: ").Append(IsServiceAccount).Append("\n");
      sb.Append("  NotifyOwnersOnly: ").Append(NotifyOwnersOnly).Append("\n");
      sb.Append("  SuspendAccountWhenCheckedIn: ").Append(SuspendAccountWhenCheckedIn).Append("\n");
      sb.Append("  AltLoginName: ").Append(AltLoginName).Append("\n");
      sb.Append("  LinkedUsersCount: ").Append(LinkedUsersCount).Append("\n");
      sb.Append("  RequestProperties: ").Append(RequestProperties).Append("\n");
      sb.Append("  Platform: ").Append(Platform).Append("\n");
      sb.Append("  Asset: ").Append(Asset).Append("\n");
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
