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
  public class ClusterPatchModel {
    /// <summary>
    /// Gets or Sets StagingStatus
    /// </summary>
    [DataMember(Name="StagingStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StagingStatus")]
    public PatchStagingStatus StagingStatus { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets NetworkAddress
    /// </summary>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

    /// <summary>
    /// Gets or Sets Isleader
    /// </summary>
    [DataMember(Name="Isleader", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Isleader")]
    public bool? Isleader { get; set; }

    /// <summary>
    /// Gets or Sets Errors
    /// </summary>
    [DataMember(Name="Errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Errors")]
    public List<string> Errors { get; set; }

    /// <summary>
    /// Gets or Sets Warnings
    /// </summary>
    [DataMember(Name="Warnings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Warnings")]
    public List<string> Warnings { get; set; }

    /// <summary>
    /// Gets or Sets PatchVersion
    /// </summary>
    [DataMember(Name="PatchVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PatchVersion")]
    public string PatchVersion { get; set; }

    /// <summary>
    /// Gets or Sets TargetOsLevel
    /// </summary>
    [DataMember(Name="TargetOsLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TargetOsLevel")]
    public int? TargetOsLevel { get; set; }

    /// <summary>
    /// Gets or Sets IsOsPatch
    /// </summary>
    [DataMember(Name="IsOsPatch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsOsPatch")]
    public bool? IsOsPatch { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClusterPatchModel {\n");
      sb.Append("  StagingStatus: ").Append(StagingStatus).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  Isleader: ").Append(Isleader).Append("\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
      sb.Append("  Warnings: ").Append(Warnings).Append("\n");
      sb.Append("  PatchVersion: ").Append(PatchVersion).Append("\n");
      sb.Append("  TargetOsLevel: ").Append(TargetOsLevel).Append("\n");
      sb.Append("  IsOsPatch: ").Append(IsOsPatch).Append("\n");
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
