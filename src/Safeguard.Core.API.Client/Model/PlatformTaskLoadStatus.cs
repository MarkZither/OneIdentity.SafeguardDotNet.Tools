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
  public class PlatformTaskLoadStatus {
    /// <summary>
    /// Gets or Sets ApplianceLoadData
    /// </summary>
    [DataMember(Name="ApplianceLoadData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceLoadData")]
    public List<ApplianceLoadData> ApplianceLoadData { get; set; }

    /// <summary>
    /// Gets or Sets PendingPasswordChecks
    /// </summary>
    [DataMember(Name="PendingPasswordChecks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingPasswordChecks")]
    public int? PendingPasswordChecks { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledPasswordChecks
    /// </summary>
    [DataMember(Name="ScheduledPasswordChecks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledPasswordChecks")]
    public int? ScheduledPasswordChecks { get; set; }

    /// <summary>
    /// Gets or Sets PendingPasswordChanges
    /// </summary>
    [DataMember(Name="PendingPasswordChanges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingPasswordChanges")]
    public int? PendingPasswordChanges { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledPasswordChanges
    /// </summary>
    [DataMember(Name="ScheduledPasswordChanges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledPasswordChanges")]
    public int? ScheduledPasswordChanges { get; set; }

    /// <summary>
    /// Gets or Sets PendingSshKeyChecks
    /// </summary>
    [DataMember(Name="PendingSshKeyChecks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingSshKeyChecks")]
    public int? PendingSshKeyChecks { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledSshKeyChecks
    /// </summary>
    [DataMember(Name="ScheduledSshKeyChecks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledSshKeyChecks")]
    public int? ScheduledSshKeyChecks { get; set; }

    /// <summary>
    /// Gets or Sets PendingSshKeyChanges
    /// </summary>
    [DataMember(Name="PendingSshKeyChanges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingSshKeyChanges")]
    public int? PendingSshKeyChanges { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledSshKeyChanges
    /// </summary>
    [DataMember(Name="ScheduledSshKeyChanges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledSshKeyChanges")]
    public int? ScheduledSshKeyChanges { get; set; }

    /// <summary>
    /// Gets or Sets PendingSshKeyDiscoveries
    /// </summary>
    [DataMember(Name="PendingSshKeyDiscoveries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingSshKeyDiscoveries")]
    public int? PendingSshKeyDiscoveries { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledSshKeyDiscoveries
    /// </summary>
    [DataMember(Name="ScheduledSshKeyDiscoveries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledSshKeyDiscoveries")]
    public int? ScheduledSshKeyDiscoveries { get; set; }

    /// <summary>
    /// Gets or Sets PendingDependentAssetUpdates
    /// </summary>
    [DataMember(Name="PendingDependentAssetUpdates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingDependentAssetUpdates")]
    public int? PendingDependentAssetUpdates { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledDependentAssetUpdates
    /// </summary>
    [DataMember(Name="ScheduledDependentAssetUpdates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledDependentAssetUpdates")]
    public int? ScheduledDependentAssetUpdates { get; set; }

    /// <summary>
    /// Gets or Sets PendingAccountDiscoveries
    /// </summary>
    [DataMember(Name="PendingAccountDiscoveries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingAccountDiscoveries")]
    public int? PendingAccountDiscoveries { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledAccountDiscoveries
    /// </summary>
    [DataMember(Name="ScheduledAccountDiscoveries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledAccountDiscoveries")]
    public int? ScheduledAccountDiscoveries { get; set; }

    /// <summary>
    /// Gets or Sets PendingServiceDiscoveries
    /// </summary>
    [DataMember(Name="PendingServiceDiscoveries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingServiceDiscoveries")]
    public int? PendingServiceDiscoveries { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledServiceDiscoveries
    /// </summary>
    [DataMember(Name="ScheduledServiceDiscoveries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledServiceDiscoveries")]
    public int? ScheduledServiceDiscoveries { get; set; }

    /// <summary>
    /// Gets or Sets PendingAssetDiscoveries
    /// </summary>
    [DataMember(Name="PendingAssetDiscoveries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingAssetDiscoveries")]
    public int? PendingAssetDiscoveries { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledAssetDiscoveries
    /// </summary>
    [DataMember(Name="ScheduledAssetDiscoveries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledAssetDiscoveries")]
    public int? ScheduledAssetDiscoveries { get; set; }

    /// <summary>
    /// Gets or Sets PendingSuspendAccounts
    /// </summary>
    [DataMember(Name="PendingSuspendAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingSuspendAccounts")]
    public int? PendingSuspendAccounts { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledSuspendAccounts
    /// </summary>
    [DataMember(Name="ScheduledSuspendAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledSuspendAccounts")]
    public int? ScheduledSuspendAccounts { get; set; }

    /// <summary>
    /// Gets or Sets PendingRestoreAccounts
    /// </summary>
    [DataMember(Name="PendingRestoreAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingRestoreAccounts")]
    public int? PendingRestoreAccounts { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledRestoreAccounts
    /// </summary>
    [DataMember(Name="ScheduledRestoreAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledRestoreAccounts")]
    public int? ScheduledRestoreAccounts { get; set; }

    /// <summary>
    /// Gets or Sets PendingSyncAccounts
    /// </summary>
    [DataMember(Name="PendingSyncAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingSyncAccounts")]
    public int? PendingSyncAccounts { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledSyncAccounts
    /// </summary>
    [DataMember(Name="ScheduledSyncAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledSyncAccounts")]
    public int? ScheduledSyncAccounts { get; set; }

    /// <summary>
    /// Gets or Sets PendingTestConnections
    /// </summary>
    [DataMember(Name="PendingTestConnections", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingTestConnections")]
    public int? PendingTestConnections { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledTestConnections
    /// </summary>
    [DataMember(Name="ScheduledTestConnections", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledTestConnections")]
    public int? ScheduledTestConnections { get; set; }

    /// <summary>
    /// Gets or Sets PendingSshKeySyncAccounts
    /// </summary>
    [DataMember(Name="PendingSshKeySyncAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingSshKeySyncAccounts")]
    public int? PendingSshKeySyncAccounts { get; set; }

    /// <summary>
    /// Gets or Sets ScheduledSshKeySyncAccounts
    /// </summary>
    [DataMember(Name="ScheduledSshKeySyncAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduledSshKeySyncAccounts")]
    public int? ScheduledSshKeySyncAccounts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PlatformTaskLoadStatus {\n");
      sb.Append("  ApplianceLoadData: ").Append(ApplianceLoadData).Append("\n");
      sb.Append("  PendingPasswordChecks: ").Append(PendingPasswordChecks).Append("\n");
      sb.Append("  ScheduledPasswordChecks: ").Append(ScheduledPasswordChecks).Append("\n");
      sb.Append("  PendingPasswordChanges: ").Append(PendingPasswordChanges).Append("\n");
      sb.Append("  ScheduledPasswordChanges: ").Append(ScheduledPasswordChanges).Append("\n");
      sb.Append("  PendingSshKeyChecks: ").Append(PendingSshKeyChecks).Append("\n");
      sb.Append("  ScheduledSshKeyChecks: ").Append(ScheduledSshKeyChecks).Append("\n");
      sb.Append("  PendingSshKeyChanges: ").Append(PendingSshKeyChanges).Append("\n");
      sb.Append("  ScheduledSshKeyChanges: ").Append(ScheduledSshKeyChanges).Append("\n");
      sb.Append("  PendingSshKeyDiscoveries: ").Append(PendingSshKeyDiscoveries).Append("\n");
      sb.Append("  ScheduledSshKeyDiscoveries: ").Append(ScheduledSshKeyDiscoveries).Append("\n");
      sb.Append("  PendingDependentAssetUpdates: ").Append(PendingDependentAssetUpdates).Append("\n");
      sb.Append("  ScheduledDependentAssetUpdates: ").Append(ScheduledDependentAssetUpdates).Append("\n");
      sb.Append("  PendingAccountDiscoveries: ").Append(PendingAccountDiscoveries).Append("\n");
      sb.Append("  ScheduledAccountDiscoveries: ").Append(ScheduledAccountDiscoveries).Append("\n");
      sb.Append("  PendingServiceDiscoveries: ").Append(PendingServiceDiscoveries).Append("\n");
      sb.Append("  ScheduledServiceDiscoveries: ").Append(ScheduledServiceDiscoveries).Append("\n");
      sb.Append("  PendingAssetDiscoveries: ").Append(PendingAssetDiscoveries).Append("\n");
      sb.Append("  ScheduledAssetDiscoveries: ").Append(ScheduledAssetDiscoveries).Append("\n");
      sb.Append("  PendingSuspendAccounts: ").Append(PendingSuspendAccounts).Append("\n");
      sb.Append("  ScheduledSuspendAccounts: ").Append(ScheduledSuspendAccounts).Append("\n");
      sb.Append("  PendingRestoreAccounts: ").Append(PendingRestoreAccounts).Append("\n");
      sb.Append("  ScheduledRestoreAccounts: ").Append(ScheduledRestoreAccounts).Append("\n");
      sb.Append("  PendingSyncAccounts: ").Append(PendingSyncAccounts).Append("\n");
      sb.Append("  ScheduledSyncAccounts: ").Append(ScheduledSyncAccounts).Append("\n");
      sb.Append("  PendingTestConnections: ").Append(PendingTestConnections).Append("\n");
      sb.Append("  ScheduledTestConnections: ").Append(ScheduledTestConnections).Append("\n");
      sb.Append("  PendingSshKeySyncAccounts: ").Append(PendingSshKeySyncAccounts).Append("\n");
      sb.Append("  ScheduledSshKeySyncAccounts: ").Append(ScheduledSshKeySyncAccounts).Append("\n");
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
