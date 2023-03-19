using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Configuration for managing SSH keys for accounts/assets in a partition
  /// </summary>
  [DataContract]
  public class SshKeyProfile {
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
    /// Id of the SSH key Check Schedule
    /// </summary>
    /// <value>Id of the SSH key Check Schedule</value>
    [DataMember(Name="CheckScheduleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CheckScheduleId")]
    public int? CheckScheduleId { get; set; }

    /// <summary>
    /// Name of the SSH key Check Schedule
    /// </summary>
    /// <value>Name of the SSH key Check Schedule</value>
    [DataMember(Name="CheckScheduleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CheckScheduleName")]
    public string CheckScheduleName { get; set; }

    /// <summary>
    /// Id of the SSH key Change Schedule
    /// </summary>
    /// <value>Id of the SSH key Change Schedule</value>
    [DataMember(Name="ChangeScheduleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangeScheduleId")]
    public int? ChangeScheduleId { get; set; }

    /// <summary>
    /// Name of the SSH key Change Schedule
    /// </summary>
    /// <value>Name of the SSH key Change Schedule</value>
    [DataMember(Name="ChangeScheduleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangeScheduleName")]
    public string ChangeScheduleName { get; set; }

    /// <summary>
    /// Id of the SSH key discovery Schedule
    /// </summary>
    /// <value>Id of the SSH key discovery Schedule</value>
    [DataMember(Name="DiscoveryScheduleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveryScheduleId")]
    public int? DiscoveryScheduleId { get; set; }

    /// <summary>
    /// Name of the SSH key discovery Schedule
    /// </summary>
    /// <value>Name of the SSH key discovery Schedule</value>
    [DataMember(Name="DiscoveryScheduleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveryScheduleName")]
    public string DiscoveryScheduleName { get; set; }

    /// <summary>
    /// Gets or Sets CheckSchedule
    /// </summary>
    [DataMember(Name="CheckSchedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CheckSchedule")]
    public SshKeyCheckSchedule CheckSchedule { get; set; }

    /// <summary>
    /// Gets or Sets ChangeSchedule
    /// </summary>
    [DataMember(Name="ChangeSchedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangeSchedule")]
    public SshKeyChangeSchedule ChangeSchedule { get; set; }

    /// <summary>
    /// Gets or Sets DiscoverySchedule
    /// </summary>
    [DataMember(Name="DiscoverySchedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoverySchedule")]
    public SshKeyDiscoverySchedule DiscoverySchedule { get; set; }

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
    /// List of partition owners that manage this profile
    /// </summary>
    /// <value>List of partition owners that manage this profile</value>
    [DataMember(Name="Owners", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Owners")]
    public List<User> Owners { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SshKeyProfile {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
      sb.Append("  CheckScheduleId: ").Append(CheckScheduleId).Append("\n");
      sb.Append("  CheckScheduleName: ").Append(CheckScheduleName).Append("\n");
      sb.Append("  ChangeScheduleId: ").Append(ChangeScheduleId).Append("\n");
      sb.Append("  ChangeScheduleName: ").Append(ChangeScheduleName).Append("\n");
      sb.Append("  DiscoveryScheduleId: ").Append(DiscoveryScheduleId).Append("\n");
      sb.Append("  DiscoveryScheduleName: ").Append(DiscoveryScheduleName).Append("\n");
      sb.Append("  CheckSchedule: ").Append(CheckSchedule).Append("\n");
      sb.Append("  ChangeSchedule: ").Append(ChangeSchedule).Append("\n");
      sb.Append("  DiscoverySchedule: ").Append(DiscoverySchedule).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  Owners: ").Append(Owners).Append("\n");
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
