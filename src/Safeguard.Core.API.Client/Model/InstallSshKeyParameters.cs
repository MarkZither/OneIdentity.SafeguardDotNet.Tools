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
  public class InstallSshKeyParameters {
    /// <summary>
    /// Gets or Sets SshKeyToInstall
    /// </summary>
    [DataMember(Name="SshKeyToInstall", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyToInstall")]
    public AccountSshKey SshKeyToInstall { get; set; }

    /// <summary>
    /// Whether to auto-accept the ssh host key
    /// </summary>
    /// <value>Whether to auto-accept the ssh host key</value>
    [DataMember(Name="AutoAcceptSshHostKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AutoAcceptSshHostKey")]
    public bool? AutoAcceptSshHostKey { get; set; }

    /// <summary>
    /// Gets or Sets ConnectionProperties
    /// </summary>
    [DataMember(Name="ConnectionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConnectionProperties")]
    public AssetConnectionProperties ConnectionProperties { get; set; }

    /// <summary>
    /// Set of parameters to pass to custom platform script
    /// </summary>
    /// <value>Set of parameters to pass to custom platform script</value>
    [DataMember(Name="CustomScriptParameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomScriptParameters")]
    public List<AssetCustomScriptParameter> CustomScriptParameters { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InstallSshKeyParameters {\n");
      sb.Append("  SshKeyToInstall: ").Append(SshKeyToInstall).Append("\n");
      sb.Append("  AutoAcceptSshHostKey: ").Append(AutoAcceptSshHostKey).Append("\n");
      sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
      sb.Append("  CustomScriptParameters: ").Append(CustomScriptParameters).Append("\n");
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
