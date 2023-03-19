using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Task information for an asset discovery job
  /// </summary>
  [DataContract]
  public class AssetDiscoveryJobTaskProperties {
    /// <summary>
    /// Whether this asset discovery job has any platform task failures (Read-only)
    /// </summary>
    /// <value>Whether this asset discovery job has any platform task failures (Read-only)</value>
    [DataMember(Name="HasTaskFailure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasTaskFailure")]
    public bool? HasTaskFailure { get; set; }

    /// <summary>
    /// The date/time of the last asset discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the last asset discovery (Read-only)</value>
    [DataMember(Name="LastAssetDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastAssetDiscoveryDate")]
    public DateTime? LastAssetDiscoveryDate { get; set; }

    /// <summary>
    /// The date/time of the last successful asset discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful asset discovery (Read-only)</value>
    [DataMember(Name="LastSuccessAssetDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessAssetDiscoveryDate")]
    public DateTime? LastSuccessAssetDiscoveryDate { get; set; }

    /// <summary>
    /// The date/time of the last failed asset discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed asset discovery (Read-only)</value>
    [DataMember(Name="LastFailureAssetDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureAssetDiscoveryDate")]
    public DateTime? LastFailureAssetDiscoveryDate { get; set; }

    /// <summary>
    /// Number of subsequent failed asset discovery attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed asset discovery attempts since last success (Read-only)</value>
    [DataMember(Name="FailedAssetDiscoveryAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedAssetDiscoveryAttempts")]
    public int? FailedAssetDiscoveryAttempts { get; set; }

    /// <summary>
    /// The date/time of the next asset discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the next asset discovery (Read-only)</value>
    [DataMember(Name="NextAssetDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextAssetDiscoveryDate")]
    public DateTime? NextAssetDiscoveryDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last asset discovery (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last asset discovery (Read-only)</value>
    [DataMember(Name="LastAssetDiscoveryTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastAssetDiscoveryTaskId")]
    public string LastAssetDiscoveryTaskId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetDiscoveryJobTaskProperties {\n");
      sb.Append("  HasTaskFailure: ").Append(HasTaskFailure).Append("\n");
      sb.Append("  LastAssetDiscoveryDate: ").Append(LastAssetDiscoveryDate).Append("\n");
      sb.Append("  LastSuccessAssetDiscoveryDate: ").Append(LastSuccessAssetDiscoveryDate).Append("\n");
      sb.Append("  LastFailureAssetDiscoveryDate: ").Append(LastFailureAssetDiscoveryDate).Append("\n");
      sb.Append("  FailedAssetDiscoveryAttempts: ").Append(FailedAssetDiscoveryAttempts).Append("\n");
      sb.Append("  NextAssetDiscoveryDate: ").Append(NextAssetDiscoveryDate).Append("\n");
      sb.Append("  LastAssetDiscoveryTaskId: ").Append(LastAssetDiscoveryTaskId).Append("\n");
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
