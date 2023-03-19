using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Configuration governing access requests
  /// </summary>
  [DataContract]
  public class AccessRequestProperties {
    /// <summary>
    /// Gets or Sets AccessRequestType
    /// </summary>
    [DataMember(Name="AccessRequestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessRequestType")]
    public AccessRequestType AccessRequestType { get; set; }

    /// <summary>
    /// Whether to allow more than one access request to be active at the same time
    /// </summary>
    /// <value>Whether to allow more than one access request to be active at the same time</value>
    [DataMember(Name="AllowSimultaneousAccess", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSimultaneousAccess")]
    public bool? AllowSimultaneousAccess { get; set; }

    /// <summary>
    /// Maximum number of times access can be granted during the same time period
    /// </summary>
    /// <value>Maximum number of times access can be granted during the same time period</value>
    [DataMember(Name="MaximumSimultaneousReleases", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaximumSimultaneousReleases")]
    public int? MaximumSimultaneousReleases { get; set; }

    /// <summary>
    /// Whether to change the account password after an access request is checked in
    /// </summary>
    /// <value>Whether to change the account password after an access request is checked in</value>
    [DataMember(Name="ChangePasswordAfterCheckin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangePasswordAfterCheckin")]
    public bool? ChangePasswordAfterCheckin { get; set; }

    /// <summary>
    /// Whether to change the SSH key pair after an access request is checked in
    /// </summary>
    /// <value>Whether to change the SSH key pair after an access request is checked in</value>
    [DataMember(Name="ChangeSshKeyAfterCheckin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangeSshKeyAfterCheckin")]
    public bool? ChangeSshKeyAfterCheckin { get; set; }

    /// <summary>
    /// Whether to allow the password to be released as part of a session access request (RemoteDesktop or Ssh)
    /// </summary>
    /// <value>Whether to allow the password to be released as part of a session access request (RemoteDesktop or Ssh)</value>
    [DataMember(Name="AllowSessionPasswordRelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSessionPasswordRelease")]
    public bool? AllowSessionPasswordRelease { get; set; }

    /// <summary>
    /// Whether to allow the SSH key to be released as part of a session access request (Ssh)
    /// </summary>
    /// <value>Whether to allow the SSH key to be released as part of a session access request (Ssh)</value>
    [DataMember(Name="AllowSessionSshKeyRelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSessionSshKeyRelease")]
    public bool? AllowSessionSshKeyRelease { get; set; }

    /// <summary>
    /// Gets or Sets SessionAccessAccountType
    /// </summary>
    [DataMember(Name="SessionAccessAccountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionAccessAccountType")]
    public SessionAccessAccountType SessionAccessAccountType { get; set; }

    /// <summary>
    /// Details of session access accounts (Read-only)
    /// </summary>
    /// <value>Details of session access accounts (Read-only)</value>
    [DataMember(Name="SessionAccessAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionAccessAccounts")]
    public List<PolicyAccount> SessionAccessAccounts { get; set; }

    /// <summary>
    /// Whether to terminate active sessions when the access request expires
    /// </summary>
    /// <value>Whether to terminate active sessions when the access request expires</value>
    [DataMember(Name="TerminateExpiredSessions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TerminateExpiredSessions")]
    public bool? TerminateExpiredSessions { get; set; }

    /// <summary>
    /// Whether to allow linked accounts to be requested
    /// </summary>
    /// <value>Whether to allow linked accounts to be requested</value>
    [DataMember(Name="AllowLinkedAccountPasswordAccess", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowLinkedAccountPasswordAccess")]
    public bool? AllowLinkedAccountPasswordAccess { get; set; }

    /// <summary>
    /// Whether the SSH private key will be encrypted upon check out
    /// </summary>
    /// <value>Whether the SSH private key will be encrypted upon check out</value>
    [DataMember(Name="PassphraseProtectSshKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PassphraseProtectSshKey")]
    public bool? PassphraseProtectSshKey { get; set; }

    /// <summary>
    /// Whether to use the AltLoginName AD attribute for a session connection launch string
    /// </summary>
    /// <value>Whether to use the AltLoginName AD attribute for a session connection launch string</value>
    [DataMember(Name="UseAltLoginName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseAltLoginName")]
    public bool? UseAltLoginName { get; set; }

    /// <summary>
    /// Whether to filter linked accounts using scope filtering. Only valid when using linked session accounts or linked account password access
    /// </summary>
    /// <value>Whether to filter linked accounts using scope filtering. Only valid when using linked session accounts or linked account password access</value>
    [DataMember(Name="LinkedAccountScopeFiltering", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LinkedAccountScopeFiltering")]
    public bool? LinkedAccountScopeFiltering { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessRequestProperties {\n");
      sb.Append("  AccessRequestType: ").Append(AccessRequestType).Append("\n");
      sb.Append("  AllowSimultaneousAccess: ").Append(AllowSimultaneousAccess).Append("\n");
      sb.Append("  MaximumSimultaneousReleases: ").Append(MaximumSimultaneousReleases).Append("\n");
      sb.Append("  ChangePasswordAfterCheckin: ").Append(ChangePasswordAfterCheckin).Append("\n");
      sb.Append("  ChangeSshKeyAfterCheckin: ").Append(ChangeSshKeyAfterCheckin).Append("\n");
      sb.Append("  AllowSessionPasswordRelease: ").Append(AllowSessionPasswordRelease).Append("\n");
      sb.Append("  AllowSessionSshKeyRelease: ").Append(AllowSessionSshKeyRelease).Append("\n");
      sb.Append("  SessionAccessAccountType: ").Append(SessionAccessAccountType).Append("\n");
      sb.Append("  SessionAccessAccounts: ").Append(SessionAccessAccounts).Append("\n");
      sb.Append("  TerminateExpiredSessions: ").Append(TerminateExpiredSessions).Append("\n");
      sb.Append("  AllowLinkedAccountPasswordAccess: ").Append(AllowLinkedAccountPasswordAccess).Append("\n");
      sb.Append("  PassphraseProtectSshKey: ").Append(PassphraseProtectSshKey).Append("\n");
      sb.Append("  UseAltLoginName: ").Append(UseAltLoginName).Append("\n");
      sb.Append("  LinkedAccountScopeFiltering: ").Append(LinkedAccountScopeFiltering).Append("\n");
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
