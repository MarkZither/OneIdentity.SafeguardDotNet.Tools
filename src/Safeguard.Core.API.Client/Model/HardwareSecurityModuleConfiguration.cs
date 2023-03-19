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
  public class HardwareSecurityModuleConfiguration {
    /// <summary>
    /// The hardware security module configuration file (crystoki.ini).
    /// </summary>
    /// <value>The hardware security module configuration file (crystoki.ini).</value>
    [DataMember(Name="IniFile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IniFile")]
    public string IniFile { get; set; }

    /// <summary>
    /// The crypo officer password to be used when integrating with a hardware security module.
    /// </summary>
    /// <value>The crypo officer password to be used when integrating with a hardware security module.</value>
    [DataMember(Name="CryptoOfficerPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CryptoOfficerPassword")]
    public string CryptoOfficerPassword { get; set; }

    /// <summary>
    /// The partition label to be used when integrating with a hardware security module.
    /// </summary>
    /// <value>The partition label to be used when integrating with a hardware security module.</value>
    [DataMember(Name="PartitionLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PartitionLabel")]
    public string PartitionLabel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HardwareSecurityModuleConfiguration {\n");
      sb.Append("  IniFile: ").Append(IniFile).Append("\n");
      sb.Append("  CryptoOfficerPassword: ").Append(CryptoOfficerPassword).Append("\n");
      sb.Append("  PartitionLabel: ").Append(PartitionLabel).Append("\n");
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
