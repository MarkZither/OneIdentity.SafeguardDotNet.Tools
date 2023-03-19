using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Specific to patching, will get translated to appliance Version after install
  /// </summary>
  [DataContract]
  public class PatchVersion {
    /// <summary>
    /// Major release number
    /// </summary>
    /// <value>Major release number</value>
    [DataMember(Name="Major", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Major")]
    public int? Major { get; set; }

    /// <summary>
    /// Minor feature update number
    /// </summary>
    /// <value>Minor feature update number</value>
    [DataMember(Name="Minor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Minor")]
    public int? Minor { get; set; }

    /// <summary>
    /// Bugfix service release number
    /// </summary>
    /// <value>Bugfix service release number</value>
    [DataMember(Name="ServicePack", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServicePack")]
    public int? ServicePack { get; set; }

    /// <summary>
    /// Hotfix/build number
    /// </summary>
    /// <value>Hotfix/build number</value>
    [DataMember(Name="HotfixLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HotfixLevel")]
    public int? HotfixLevel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PatchVersion {\n");
      sb.Append("  Major: ").Append(Major).Append("\n");
      sb.Append("  Minor: ").Append(Minor).Append("\n");
      sb.Append("  ServicePack: ").Append(ServicePack).Append("\n");
      sb.Append("  HotfixLevel: ").Append(HotfixLevel).Append("\n");
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
