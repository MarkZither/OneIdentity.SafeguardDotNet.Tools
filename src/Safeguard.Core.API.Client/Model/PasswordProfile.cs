using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Configuration for managing accounts/assets in a partition
  /// </summary>
  [DataContract]
  public class PasswordProfile {
    /// <summary>
    /// Database ID of the profile (Read-only)
    /// </summary>
    /// <value>Database ID of the profile (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of this profile
    /// </summary>
    /// <value>Name of this profile</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of this profile
    /// </summary>
    /// <value>Description of this profile</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Date this entity was created (Read-only)
    /// </summary>
    /// <value>Date this entity was created (Read-only)</value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The database ID of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The database ID of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserId")]
    public int? CreatedByUserId { get; set; }

    /// <summary>
    /// The display name of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The display name of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserDisplayName")]
    public string CreatedByUserDisplayName { get; set; }

    /// <summary>
    /// Database ID of the password complexity rule that will be enforced. The password rule governs the construction requirements for new password generation.
    /// </summary>
    /// <value>Database ID of the password complexity rule that will be enforced. The password rule governs the construction requirements for new password generation.</value>
    [DataMember(Name="AccountPasswordRuleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountPasswordRuleId")]
    public int? AccountPasswordRuleId { get; set; }

    /// <summary>
    /// Name of the account password rule enforced by this profile (Read-only)
    /// </summary>
    /// <value>Name of the account password rule enforced by this profile (Read-only)</value>
    [DataMember(Name="AccountPasswordRuleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountPasswordRuleName")]
    public string AccountPasswordRuleName { get; set; }

    /// <summary>
    /// Id of the Password Check Schedule
    /// </summary>
    /// <value>Id of the Password Check Schedule</value>
    [DataMember(Name="CheckScheduleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CheckScheduleId")]
    public int? CheckScheduleId { get; set; }

    /// <summary>
    /// Name of the Password Check Schedule
    /// </summary>
    /// <value>Name of the Password Check Schedule</value>
    [DataMember(Name="CheckScheduleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CheckScheduleName")]
    public string CheckScheduleName { get; set; }

    /// <summary>
    /// Id of the Password Change Schedule
    /// </summary>
    /// <value>Id of the Password Change Schedule</value>
    [DataMember(Name="ChangeScheduleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangeScheduleId")]
    public int? ChangeScheduleId { get; set; }

    /// <summary>
    /// Name of the Password Change Schedule
    /// </summary>
    /// <value>Name of the Password Change Schedule</value>
    [DataMember(Name="ChangeScheduleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangeScheduleName")]
    public string ChangeScheduleName { get; set; }

    /// <summary>
    /// Gets or Sets CheckSchedule
    /// </summary>
    [DataMember(Name="CheckSchedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CheckSchedule")]
    public PasswordCheckSchedule CheckSchedule { get; set; }

    /// <summary>
    /// Gets or Sets ChangeSchedule
    /// </summary>
    [DataMember(Name="ChangeSchedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangeSchedule")]
    public PasswordChangeSchedule ChangeSchedule { get; set; }

    /// <summary>
    /// Gets or Sets AccountPasswordRule
    /// </summary>
    [DataMember(Name="AccountPasswordRule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountPasswordRule")]
    public AccountPasswordRule AccountPasswordRule { get; set; }

    /// <summary>
    /// The asset partition this profile belongs to (Read-only)
    /// </summary>
    /// <value>The asset partition this profile belongs to (Read-only)</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of the asset partition this profile belongs to (Read-only)
    /// </summary>
    /// <value>Name of the asset partition this profile belongs to (Read-only)</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PasswordProfile {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
      sb.Append("  AccountPasswordRuleId: ").Append(AccountPasswordRuleId).Append("\n");
      sb.Append("  AccountPasswordRuleName: ").Append(AccountPasswordRuleName).Append("\n");
      sb.Append("  CheckScheduleId: ").Append(CheckScheduleId).Append("\n");
      sb.Append("  CheckScheduleName: ").Append(CheckScheduleName).Append("\n");
      sb.Append("  ChangeScheduleId: ").Append(ChangeScheduleId).Append("\n");
      sb.Append("  ChangeScheduleName: ").Append(ChangeScheduleName).Append("\n");
      sb.Append("  CheckSchedule: ").Append(CheckSchedule).Append("\n");
      sb.Append("  ChangeSchedule: ").Append(ChangeSchedule).Append("\n");
      sb.Append("  AccountPasswordRule: ").Append(AccountPasswordRule).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
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
