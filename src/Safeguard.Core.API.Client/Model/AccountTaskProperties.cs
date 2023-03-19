using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Task information for accounts
  /// </summary>
  [DataContract]
  public class AccountTaskProperties {
    /// <summary>
    /// Whether this account has any platform task failures (Read-only)
    /// </summary>
    /// <value>Whether this account has any platform task failures (Read-only)</value>
    [DataMember(Name="HasAccountTaskFailure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasAccountTaskFailure")]
    public bool? HasAccountTaskFailure { get; set; }

    /// <summary>
    /// The date/time of the last password check (Read-only)
    /// </summary>
    /// <value>The date/time of the last password check (Read-only)</value>
    [DataMember(Name="LastPasswordCheckDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastPasswordCheckDate")]
    public DateTime? LastPasswordCheckDate { get; set; }

    /// <summary>
    /// The date/time of the last successful password check (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful password check (Read-only)</value>
    [DataMember(Name="LastSuccessPasswordCheckDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessPasswordCheckDate")]
    public DateTime? LastSuccessPasswordCheckDate { get; set; }

    /// <summary>
    /// The date/time of the last failed password check (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed password check (Read-only)</value>
    [DataMember(Name="LastFailurePasswordCheckDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailurePasswordCheckDate")]
    public DateTime? LastFailurePasswordCheckDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last password check (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last password check (Read-only)</value>
    [DataMember(Name="LastPasswordCheckTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastPasswordCheckTaskId")]
    public string LastPasswordCheckTaskId { get; set; }

    /// <summary>
    /// Number of subsequent failed password check attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed password check attempts since last success (Read-only)</value>
    [DataMember(Name="FailedPasswordCheckAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedPasswordCheckAttempts")]
    public int? FailedPasswordCheckAttempts { get; set; }

    /// <summary>
    /// The date/time of the next password check, if this account is enabled for automatic password management (Read-only)
    /// </summary>
    /// <value>The date/time of the next password check, if this account is enabled for automatic password management (Read-only)</value>
    [DataMember(Name="NextPasswordCheckDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextPasswordCheckDate")]
    public DateTime? NextPasswordCheckDate { get; set; }

    /// <summary>
    /// The date/time of the last password change (Read-only)
    /// </summary>
    /// <value>The date/time of the last password change (Read-only)</value>
    [DataMember(Name="LastPasswordChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastPasswordChangeDate")]
    public DateTime? LastPasswordChangeDate { get; set; }

    /// <summary>
    /// The date/time of the last successful password change (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful password change (Read-only)</value>
    [DataMember(Name="LastSuccessPasswordChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessPasswordChangeDate")]
    public DateTime? LastSuccessPasswordChangeDate { get; set; }

    /// <summary>
    /// The date/time of the last failed password change (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed password change (Read-only)</value>
    [DataMember(Name="LastFailurePasswordChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailurePasswordChangeDate")]
    public DateTime? LastFailurePasswordChangeDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last password change (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last password change (Read-only)</value>
    [DataMember(Name="LastPasswordChangeTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastPasswordChangeTaskId")]
    public string LastPasswordChangeTaskId { get; set; }

    /// <summary>
    /// Number of subsequent failed password change attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed password change attempts since last success (Read-only)</value>
    [DataMember(Name="FailedPasswordChangeAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedPasswordChangeAttempts")]
    public int? FailedPasswordChangeAttempts { get; set; }

    /// <summary>
    /// The date/time of the next password change, if this account is enabled for automatic password management (Read-only)
    /// </summary>
    /// <value>The date/time of the next password change, if this account is enabled for automatic password management (Read-only)</value>
    [DataMember(Name="NextPasswordChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextPasswordChangeDate")]
    public DateTime? NextPasswordChangeDate { get; set; }

    /// <summary>
    /// The date/time of the last SSH key check (Read-only)
    /// </summary>
    /// <value>The date/time of the last SSH key check (Read-only)</value>
    [DataMember(Name="LastSshKeyCheckDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSshKeyCheckDate")]
    public DateTime? LastSshKeyCheckDate { get; set; }

    /// <summary>
    /// The date/time of the last successful SSH key check (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful SSH key check (Read-only)</value>
    [DataMember(Name="LastSuccessSshKeyCheckDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessSshKeyCheckDate")]
    public DateTime? LastSuccessSshKeyCheckDate { get; set; }

    /// <summary>
    /// The date/time of the last failed SSH key check (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed SSH key check (Read-only)</value>
    [DataMember(Name="LastFailureSshKeyCheckDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureSshKeyCheckDate")]
    public DateTime? LastFailureSshKeyCheckDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last SSH key check (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last SSH key check (Read-only)</value>
    [DataMember(Name="LastSshKeyCheckTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSshKeyCheckTaskId")]
    public string LastSshKeyCheckTaskId { get; set; }

    /// <summary>
    /// Number of subsequent failed ssh key check attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed ssh key check attempts since last success (Read-only)</value>
    [DataMember(Name="FailedSshKeyCheckAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedSshKeyCheckAttempts")]
    public int? FailedSshKeyCheckAttempts { get; set; }

    /// <summary>
    /// The date/time of the next SSH key check (Read-only)
    /// </summary>
    /// <value>The date/time of the next SSH key check (Read-only)</value>
    [DataMember(Name="NextSshKeyCheckDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextSshKeyCheckDate")]
    public DateTime? NextSshKeyCheckDate { get; set; }

    /// <summary>
    /// The date/time of the last SSH key change (Read-only)
    /// </summary>
    /// <value>The date/time of the last SSH key change (Read-only)</value>
    [DataMember(Name="LastSshKeyChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSshKeyChangeDate")]
    public DateTime? LastSshKeyChangeDate { get; set; }

    /// <summary>
    /// The date/time of the last successful SSH key change (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful SSH key change (Read-only)</value>
    [DataMember(Name="LastSuccessSshKeyChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessSshKeyChangeDate")]
    public DateTime? LastSuccessSshKeyChangeDate { get; set; }

    /// <summary>
    /// The date/time of the last failed SSH key discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed SSH key discovery (Read-only)</value>
    [DataMember(Name="LastFailureSshKeyChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureSshKeyChangeDate")]
    public DateTime? LastFailureSshKeyChangeDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last SSH key change (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last SSH key change (Read-only)</value>
    [DataMember(Name="LastSshKeyChangeTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSshKeyChangeTaskId")]
    public string LastSshKeyChangeTaskId { get; set; }

    /// <summary>
    /// Number of subsequent failed ssh key change attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed ssh key change attempts since last success (Read-only)</value>
    [DataMember(Name="FailedSshKeyChangeAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedSshKeyChangeAttempts")]
    public int? FailedSshKeyChangeAttempts { get; set; }

    /// <summary>
    /// The date/time of the next SSH key change (Read-only)
    /// </summary>
    /// <value>The date/time of the next SSH key change (Read-only)</value>
    [DataMember(Name="NextSshKeyChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextSshKeyChangeDate")]
    public DateTime? NextSshKeyChangeDate { get; set; }

    /// <summary>
    /// The date/time of the last SSH key discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the last SSH key discovery (Read-only)</value>
    [DataMember(Name="LastSshKeyDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSshKeyDiscoveryDate")]
    public DateTime? LastSshKeyDiscoveryDate { get; set; }

    /// <summary>
    /// The date/time of the last successful SSH key discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful SSH key discovery (Read-only)</value>
    [DataMember(Name="LastSuccessSshKeyDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessSshKeyDiscoveryDate")]
    public DateTime? LastSuccessSshKeyDiscoveryDate { get; set; }

    /// <summary>
    /// The date/time of the last failed SSH key discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed SSH key discovery (Read-only)</value>
    [DataMember(Name="LastFailureSshKeyDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureSshKeyDiscoveryDate")]
    public DateTime? LastFailureSshKeyDiscoveryDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last SSH key discovery (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last SSH key discovery (Read-only)</value>
    [DataMember(Name="LastSshKeyDiscoveryTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSshKeyDiscoveryTaskId")]
    public string LastSshKeyDiscoveryTaskId { get; set; }

    /// <summary>
    /// Number of subsequent failed ssh key discovery attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed ssh key discovery attempts since last success (Read-only)</value>
    [DataMember(Name="FailedSshKeyDiscoveryAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedSshKeyDiscoveryAttempts")]
    public int? FailedSshKeyDiscoveryAttempts { get; set; }

    /// <summary>
    /// The date/time of the next SSH key discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the next SSH key discovery (Read-only)</value>
    [DataMember(Name="NextSshKeyDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextSshKeyDiscoveryDate")]
    public DateTime? NextSshKeyDiscoveryDate { get; set; }

    /// <summary>
    /// The date/time of the last revoke SSH key task (Read-only)
    /// </summary>
    /// <value>The date/time of the last revoke SSH key task (Read-only)</value>
    [DataMember(Name="LastSshKeyRevokeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSshKeyRevokeDate")]
    public DateTime? LastSshKeyRevokeDate { get; set; }

    /// <summary>
    /// The date/time of the last successful revoke SSH key task (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful revoke SSH key task (Read-only)</value>
    [DataMember(Name="LastSuccessSshKeyRevokeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessSshKeyRevokeDate")]
    public DateTime? LastSuccessSshKeyRevokeDate { get; set; }

    /// <summary>
    /// The date/time of the last failed revoke SSH key task (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed revoke SSH key task (Read-only)</value>
    [DataMember(Name="LastFailureSshKeyRevokeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureSshKeyRevokeDate")]
    public DateTime? LastFailureSshKeyRevokeDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last SSH key revoke (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last SSH key revoke (Read-only)</value>
    [DataMember(Name="LastSshKeyRevokeTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSshKeyRevokeTaskId")]
    public string LastSshKeyRevokeTaskId { get; set; }

    /// <summary>
    /// Number of subsequent failed revoke SSH key task attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed revoke SSH key task attempts since last success (Read-only)</value>
    [DataMember(Name="FailedSshKeyRevokeAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedSshKeyRevokeAttempts")]
    public int? FailedSshKeyRevokeAttempts { get; set; }

    /// <summary>
    /// The date/time of the last suspend account task (Read-only)
    /// </summary>
    /// <value>The date/time of the last suspend account task (Read-only)</value>
    [DataMember(Name="LastSuspendAccountDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuspendAccountDate")]
    public DateTime? LastSuspendAccountDate { get; set; }

    /// <summary>
    /// The date/time of the last successful suspend account task (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful suspend account task (Read-only)</value>
    [DataMember(Name="LastSuccessSuspendAccountDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessSuspendAccountDate")]
    public DateTime? LastSuccessSuspendAccountDate { get; set; }

    /// <summary>
    /// The date/time of the last failed suspend account task (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed suspend account task (Read-only)</value>
    [DataMember(Name="LastFailureSuspendAccountDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureSuspendAccountDate")]
    public DateTime? LastFailureSuspendAccountDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last suspend account (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last suspend account (Read-only)</value>
    [DataMember(Name="LastSuspendAccountTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuspendAccountTaskId")]
    public string LastSuspendAccountTaskId { get; set; }

    /// <summary>
    /// Number of subsequent failed suspend account task attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed suspend account task attempts since last success (Read-only)</value>
    [DataMember(Name="FailedSuspendAccountAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedSuspendAccountAttempts")]
    public int? FailedSuspendAccountAttempts { get; set; }

    /// <summary>
    /// The date/time of the next suspend account task, if this account is enabled for automatic password management (Read-only)
    /// </summary>
    /// <value>The date/time of the next suspend account task, if this account is enabled for automatic password management (Read-only)</value>
    [DataMember(Name="NextSuspendAccountDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextSuspendAccountDate")]
    public DateTime? NextSuspendAccountDate { get; set; }

    /// <summary>
    /// The date/time of the last restore account task (Read-only)
    /// </summary>
    /// <value>The date/time of the last restore account task (Read-only)</value>
    [DataMember(Name="LastRestoreAccountDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastRestoreAccountDate")]
    public DateTime? LastRestoreAccountDate { get; set; }

    /// <summary>
    /// The date/time of the last successful restore account task (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful restore account task (Read-only)</value>
    [DataMember(Name="LastSuccessRestoreAccountDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessRestoreAccountDate")]
    public DateTime? LastSuccessRestoreAccountDate { get; set; }

    /// <summary>
    /// The date/time of the last failed restore account task (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed restore account task (Read-only)</value>
    [DataMember(Name="LastFailureRestoreAccountDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureRestoreAccountDate")]
    public DateTime? LastFailureRestoreAccountDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last restore account (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last restore account (Read-only)</value>
    [DataMember(Name="LastRestoreAccountTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastRestoreAccountTaskId")]
    public string LastRestoreAccountTaskId { get; set; }

    /// <summary>
    /// Number of subsequent failed restore account task attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed restore account task attempts since last success (Read-only)</value>
    [DataMember(Name="FailedRestoreAccountAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedRestoreAccountAttempts")]
    public int? FailedRestoreAccountAttempts { get; set; }

    /// <summary>
    /// The date/time of the next restore account task, if this account is enabled for automatic password management (Read-only)
    /// </summary>
    /// <value>The date/time of the next restore account task, if this account is enabled for automatic password management (Read-only)</value>
    [DataMember(Name="NextRestoreAccountDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextRestoreAccountDate")]
    public DateTime? NextRestoreAccountDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountTaskProperties {\n");
      sb.Append("  HasAccountTaskFailure: ").Append(HasAccountTaskFailure).Append("\n");
      sb.Append("  LastPasswordCheckDate: ").Append(LastPasswordCheckDate).Append("\n");
      sb.Append("  LastSuccessPasswordCheckDate: ").Append(LastSuccessPasswordCheckDate).Append("\n");
      sb.Append("  LastFailurePasswordCheckDate: ").Append(LastFailurePasswordCheckDate).Append("\n");
      sb.Append("  LastPasswordCheckTaskId: ").Append(LastPasswordCheckTaskId).Append("\n");
      sb.Append("  FailedPasswordCheckAttempts: ").Append(FailedPasswordCheckAttempts).Append("\n");
      sb.Append("  NextPasswordCheckDate: ").Append(NextPasswordCheckDate).Append("\n");
      sb.Append("  LastPasswordChangeDate: ").Append(LastPasswordChangeDate).Append("\n");
      sb.Append("  LastSuccessPasswordChangeDate: ").Append(LastSuccessPasswordChangeDate).Append("\n");
      sb.Append("  LastFailurePasswordChangeDate: ").Append(LastFailurePasswordChangeDate).Append("\n");
      sb.Append("  LastPasswordChangeTaskId: ").Append(LastPasswordChangeTaskId).Append("\n");
      sb.Append("  FailedPasswordChangeAttempts: ").Append(FailedPasswordChangeAttempts).Append("\n");
      sb.Append("  NextPasswordChangeDate: ").Append(NextPasswordChangeDate).Append("\n");
      sb.Append("  LastSshKeyCheckDate: ").Append(LastSshKeyCheckDate).Append("\n");
      sb.Append("  LastSuccessSshKeyCheckDate: ").Append(LastSuccessSshKeyCheckDate).Append("\n");
      sb.Append("  LastFailureSshKeyCheckDate: ").Append(LastFailureSshKeyCheckDate).Append("\n");
      sb.Append("  LastSshKeyCheckTaskId: ").Append(LastSshKeyCheckTaskId).Append("\n");
      sb.Append("  FailedSshKeyCheckAttempts: ").Append(FailedSshKeyCheckAttempts).Append("\n");
      sb.Append("  NextSshKeyCheckDate: ").Append(NextSshKeyCheckDate).Append("\n");
      sb.Append("  LastSshKeyChangeDate: ").Append(LastSshKeyChangeDate).Append("\n");
      sb.Append("  LastSuccessSshKeyChangeDate: ").Append(LastSuccessSshKeyChangeDate).Append("\n");
      sb.Append("  LastFailureSshKeyChangeDate: ").Append(LastFailureSshKeyChangeDate).Append("\n");
      sb.Append("  LastSshKeyChangeTaskId: ").Append(LastSshKeyChangeTaskId).Append("\n");
      sb.Append("  FailedSshKeyChangeAttempts: ").Append(FailedSshKeyChangeAttempts).Append("\n");
      sb.Append("  NextSshKeyChangeDate: ").Append(NextSshKeyChangeDate).Append("\n");
      sb.Append("  LastSshKeyDiscoveryDate: ").Append(LastSshKeyDiscoveryDate).Append("\n");
      sb.Append("  LastSuccessSshKeyDiscoveryDate: ").Append(LastSuccessSshKeyDiscoveryDate).Append("\n");
      sb.Append("  LastFailureSshKeyDiscoveryDate: ").Append(LastFailureSshKeyDiscoveryDate).Append("\n");
      sb.Append("  LastSshKeyDiscoveryTaskId: ").Append(LastSshKeyDiscoveryTaskId).Append("\n");
      sb.Append("  FailedSshKeyDiscoveryAttempts: ").Append(FailedSshKeyDiscoveryAttempts).Append("\n");
      sb.Append("  NextSshKeyDiscoveryDate: ").Append(NextSshKeyDiscoveryDate).Append("\n");
      sb.Append("  LastSshKeyRevokeDate: ").Append(LastSshKeyRevokeDate).Append("\n");
      sb.Append("  LastSuccessSshKeyRevokeDate: ").Append(LastSuccessSshKeyRevokeDate).Append("\n");
      sb.Append("  LastFailureSshKeyRevokeDate: ").Append(LastFailureSshKeyRevokeDate).Append("\n");
      sb.Append("  LastSshKeyRevokeTaskId: ").Append(LastSshKeyRevokeTaskId).Append("\n");
      sb.Append("  FailedSshKeyRevokeAttempts: ").Append(FailedSshKeyRevokeAttempts).Append("\n");
      sb.Append("  LastSuspendAccountDate: ").Append(LastSuspendAccountDate).Append("\n");
      sb.Append("  LastSuccessSuspendAccountDate: ").Append(LastSuccessSuspendAccountDate).Append("\n");
      sb.Append("  LastFailureSuspendAccountDate: ").Append(LastFailureSuspendAccountDate).Append("\n");
      sb.Append("  LastSuspendAccountTaskId: ").Append(LastSuspendAccountTaskId).Append("\n");
      sb.Append("  FailedSuspendAccountAttempts: ").Append(FailedSuspendAccountAttempts).Append("\n");
      sb.Append("  NextSuspendAccountDate: ").Append(NextSuspendAccountDate).Append("\n");
      sb.Append("  LastRestoreAccountDate: ").Append(LastRestoreAccountDate).Append("\n");
      sb.Append("  LastSuccessRestoreAccountDate: ").Append(LastSuccessRestoreAccountDate).Append("\n");
      sb.Append("  LastFailureRestoreAccountDate: ").Append(LastFailureRestoreAccountDate).Append("\n");
      sb.Append("  LastRestoreAccountTaskId: ").Append(LastRestoreAccountTaskId).Append("\n");
      sb.Append("  FailedRestoreAccountAttempts: ").Append(FailedRestoreAccountAttempts).Append("\n");
      sb.Append("  NextRestoreAccountDate: ").Append(NextRestoreAccountDate).Append("\n");
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
