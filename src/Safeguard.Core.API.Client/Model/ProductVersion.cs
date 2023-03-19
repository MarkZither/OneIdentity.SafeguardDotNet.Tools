using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Product version of the code/image of the appliance
  /// </summary>
  [DataContract]
  public class ProductVersion {
    /// <summary>
    /// Major version (Read-only)
    /// </summary>
    /// <value>Major version (Read-only)</value>
    [DataMember(Name="Major", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Major")]
    public int? Major { get; set; }

    /// <summary>
    /// Minor version (Read-only)
    /// </summary>
    /// <value>Minor version (Read-only)</value>
    [DataMember(Name="Minor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Minor")]
    public int? Minor { get; set; }

    /// <summary>
    /// Revision number (Read-only)
    /// </summary>
    /// <value>Revision number (Read-only)</value>
    [DataMember(Name="Revision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// Build number (Read-only)
    /// </summary>
    /// <value>Build number (Read-only)</value>
    [DataMember(Name="Build", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Build")]
    public int? Build { get; set; }

    /// <summary>
    /// Date the code/image was built (Read-only)
    /// </summary>
    /// <value>Date the code/image was built (Read-only)</value>
    [DataMember(Name="BuildDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BuildDate")]
    public DateTime? BuildDate { get; set; }

    /// <summary>
    /// Type of build (Read-only)
    /// </summary>
    /// <value>Type of build (Read-only)</value>
    [DataMember(Name="BuildVariant", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BuildVariant")]
    public string BuildVariant { get; set; }

    /// <summary>
    /// Output type of build (Read-only)
    /// </summary>
    /// <value>Output type of build (Read-only)</value>
    [DataMember(Name="BuildPlatform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BuildPlatform")]
    public string BuildPlatform { get; set; }

    /// <summary>
    /// Gets or Sets RsmsVersion
    /// </summary>
    [DataMember(Name="RsmsVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RsmsVersion")]
    public string RsmsVersion { get; set; }

    /// <summary>
    /// Gets or Sets OsPatchLevel
    /// </summary>
    [DataMember(Name="OsPatchLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OsPatchLevel")]
    public int? OsPatchLevel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductVersion {\n");
      sb.Append("  Major: ").Append(Major).Append("\n");
      sb.Append("  Minor: ").Append(Minor).Append("\n");
      sb.Append("  Revision: ").Append(Revision).Append("\n");
      sb.Append("  Build: ").Append(Build).Append("\n");
      sb.Append("  BuildDate: ").Append(BuildDate).Append("\n");
      sb.Append("  BuildVariant: ").Append(BuildVariant).Append("\n");
      sb.Append("  BuildPlatform: ").Append(BuildPlatform).Append("\n");
      sb.Append("  RsmsVersion: ").Append(RsmsVersion).Append("\n");
      sb.Append("  OsPatchLevel: ").Append(OsPatchLevel).Append("\n");
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
