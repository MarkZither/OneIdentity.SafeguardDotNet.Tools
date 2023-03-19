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
  public class AssetDiscoverSshHostKeyParameters {
    /// <summary>
    /// Port used by SSH to login to the machine
    /// </summary>
    /// <value>Port used by SSH to login to the machine</value>
    [DataMember(Name="Port", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Port")]
    public int? Port { get; set; }

    /// <summary>
    /// Whether to auto-accept the ssh host key
    /// </summary>
    /// <value>Whether to auto-accept the ssh host key</value>
    [DataMember(Name="AutoAcceptSshHostKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AutoAcceptSshHostKey")]
    public bool? AutoAcceptSshHostKey { get; set; }

    /// <summary>
    /// The database ID of the platform of the system
    /// </summary>
    /// <value>The database ID of the platform of the system</value>
    [DataMember(Name="PlatformId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformId")]
    public int? PlatformId { get; set; }

    /// <summary>
    /// Network DNS name or IP address used to connect to the machine over the network.
    /// </summary>
    /// <value>Network DNS name or IP address used to connect to the machine over the network.</value>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

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
    public List<TaskCustomScriptParameter> CustomScriptParameters { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetDiscoverSshHostKeyParameters {\n");
      sb.Append("  Port: ").Append(Port).Append("\n");
      sb.Append("  AutoAcceptSshHostKey: ").Append(AutoAcceptSshHostKey).Append("\n");
      sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
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
