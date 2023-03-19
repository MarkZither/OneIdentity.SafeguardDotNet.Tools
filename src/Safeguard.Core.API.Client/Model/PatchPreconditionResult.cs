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
  public class PatchPreconditionResult {
    /// <summary>
    /// The Appliance Id of the appliance the patch precondition check was run on.
    /// </summary>
    /// <value>The Appliance Id of the appliance the patch precondition check was run on.</value>
    [DataMember(Name="ApplianceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceId")]
    public string ApplianceId { get; set; }

    /// <summary>
    /// True if this is an Operating System Patch, in which case use Pangaea.Data.Transfer.V3.Patch.PatchPreconditionResult.TargetOsLevel.  False if this a Safeguard Patch, in which case use Pangaea.Data.Transfer.V3.Patch.PatchPreconditionResult.PatchVersion.  Null if the patch metadata is unavailable
    /// </summary>
    /// <value>True if this is an Operating System Patch, in which case use Pangaea.Data.Transfer.V3.Patch.PatchPreconditionResult.TargetOsLevel.  False if this a Safeguard Patch, in which case use Pangaea.Data.Transfer.V3.Patch.PatchPreconditionResult.PatchVersion.  Null if the patch metadata is unavailable</value>
    [DataMember(Name="IsOsPatch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsOsPatch")]
    public bool? IsOsPatch { get; set; }

    /// <summary>
    /// Gets or Sets PatchVersion
    /// </summary>
    [DataMember(Name="PatchVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PatchVersion")]
    public PatchVersion PatchVersion { get; set; }

    /// <summary>
    /// Contains the Operating System target level if Pangaea.Data.Transfer.V3.Patch.PatchPreconditionResult.IsOsPatch is true.
    /// </summary>
    /// <value>Contains the Operating System target level if Pangaea.Data.Transfer.V3.Patch.PatchPreconditionResult.IsOsPatch is true.</value>
    [DataMember(Name="TargetOsLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TargetOsLevel")]
    public int? TargetOsLevel { get; set; }

    /// <summary>
    /// Errors which were detected when running the patch precondition check.
    /// </summary>
    /// <value>Errors which were detected when running the patch precondition check.</value>
    [DataMember(Name="Errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Errors")]
    public List<string> Errors { get; set; }

    /// <summary>
    /// Warnings which were detected when running the patch precondition check.
    /// </summary>
    /// <value>Warnings which were detected when running the patch precondition check.</value>
    [DataMember(Name="Warnings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Warnings")]
    public List<string> Warnings { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PatchPreconditionResult {\n");
      sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
      sb.Append("  IsOsPatch: ").Append(IsOsPatch).Append("\n");
      sb.Append("  PatchVersion: ").Append(PatchVersion).Append("\n");
      sb.Append("  TargetOsLevel: ").Append(TargetOsLevel).Append("\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
      sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
