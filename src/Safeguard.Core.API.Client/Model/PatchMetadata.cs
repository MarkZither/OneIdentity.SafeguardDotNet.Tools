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
  public class PatchMetadata {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="Title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets OsOnlyPatch
    /// </summary>
    [DataMember(Name="OsOnlyPatch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OsOnlyPatch")]
    public bool? OsOnlyPatch { get; set; }

    /// <summary>
    /// Gets or Sets TargetOsLevel
    /// </summary>
    [DataMember(Name="TargetOsLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TargetOsLevel")]
    public int? TargetOsLevel { get; set; }

    /// <summary>
    /// Gets or Sets TargetOsVersions
    /// </summary>
    [DataMember(Name="TargetOsVersions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TargetOsVersions")]
    public List<string> TargetOsVersions { get; set; }

    /// <summary>
    /// Gets or Sets SupportLink
    /// </summary>
    [DataMember(Name="SupportLink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportLink")]
    public string SupportLink { get; set; }

    /// <summary>
    /// Gets or Sets PatchVersion
    /// </summary>
    [DataMember(Name="PatchVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PatchVersion")]
    public PatchVersion PatchVersion { get; set; }

    /// <summary>
    /// Gets or Sets Released
    /// </summary>
    [DataMember(Name="Released", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Released")]
    public DateTime? Released { get; set; }

    /// <summary>
    /// Gets or Sets PayloadSizeBytes
    /// </summary>
    [DataMember(Name="PayloadSizeBytes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PayloadSizeBytes")]
    public long? PayloadSizeBytes { get; set; }

    /// <summary>
    /// Gets or Sets MinimumApplianceVersion
    /// </summary>
    [DataMember(Name="MinimumApplianceVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinimumApplianceVersion")]
    public PatchVersion MinimumApplianceVersion { get; set; }

    /// <summary>
    /// Gets or Sets LtsMinimumApplianceVersion
    /// </summary>
    [DataMember(Name="LtsMinimumApplianceVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LtsMinimumApplianceVersion")]
    public PatchVersion LtsMinimumApplianceVersion { get; set; }

    /// <summary>
    /// Gets or Sets MaximumApplianceVersion
    /// </summary>
    [DataMember(Name="MaximumApplianceVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaximumApplianceVersion")]
    public PatchVersion MaximumApplianceVersion { get; set; }

    /// <summary>
    /// Gets or Sets LtsMaximumApplianceVersion
    /// </summary>
    [DataMember(Name="LtsMaximumApplianceVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LtsMaximumApplianceVersion")]
    public PatchVersion LtsMaximumApplianceVersion { get; set; }

    /// <summary>
    /// Gets or Sets LtsType
    /// </summary>
    [DataMember(Name="LtsType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LtsType")]
    public string LtsType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PatchMetadata {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  OsOnlyPatch: ").Append(OsOnlyPatch).Append("\n");
      sb.Append("  TargetOsLevel: ").Append(TargetOsLevel).Append("\n");
      sb.Append("  TargetOsVersions: ").Append(TargetOsVersions).Append("\n");
      sb.Append("  SupportLink: ").Append(SupportLink).Append("\n");
      sb.Append("  PatchVersion: ").Append(PatchVersion).Append("\n");
      sb.Append("  Released: ").Append(Released).Append("\n");
      sb.Append("  PayloadSizeBytes: ").Append(PayloadSizeBytes).Append("\n");
      sb.Append("  MinimumApplianceVersion: ").Append(MinimumApplianceVersion).Append("\n");
      sb.Append("  LtsMinimumApplianceVersion: ").Append(LtsMinimumApplianceVersion).Append("\n");
      sb.Append("  MaximumApplianceVersion: ").Append(MaximumApplianceVersion).Append("\n");
      sb.Append("  LtsMaximumApplianceVersion: ").Append(LtsMaximumApplianceVersion).Append("\n");
      sb.Append("  LtsType: ").Append(LtsType).Append("\n");
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
