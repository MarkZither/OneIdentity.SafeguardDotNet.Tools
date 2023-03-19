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
  public class AssetTestConnectionParameters {
    /// <summary>
    /// Name of the asset to test the connection with
    /// </summary>
    /// <value>Name of the asset to test the connection with</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// The domain to test directory asset connection against. Forest root will be used if null.
    /// </summary>
    /// <value>The domain to test directory asset connection against. Forest root will be used if null.</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// Network DNS name or IP address used to connect to the machine over the network
    /// </summary>
    /// <value>Network DNS name or IP address used to connect to the machine over the network</value>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

    /// <summary>
    /// Database ID of platform type / version
    /// </summary>
    /// <value>Database ID of platform type / version</value>
    [DataMember(Name="PlatformId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformId")]
    public int? PlatformId { get; set; }

    /// <summary>
    /// Public key of the asset
    /// </summary>
    /// <value>Public key of the asset</value>
    [DataMember(Name="SshHostKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshHostKey")]
    public string SshHostKey { get; set; }

    /// <summary>
    /// Whether to auto-accept the ssh host key
    /// </summary>
    /// <value>Whether to auto-accept the ssh host key</value>
    [DataMember(Name="AutoAcceptSshHostKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AutoAcceptSshHostKey")]
    public bool? AutoAcceptSshHostKey { get; set; }

    /// <summary>
    /// Whether to enable extended logging for the task
    /// </summary>
    /// <value>Whether to enable extended logging for the task</value>
    [DataMember(Name="ExtendedLogging", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExtendedLogging")]
    public bool? ExtendedLogging { get; set; }

    /// <summary>
    /// List of available domain controllers. If this list is empty then DNS will be used instead.
    /// </summary>
    /// <value>List of available domain controllers. If this list is empty then DNS will be used instead.</value>
    [DataMember(Name="DomainControllers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainControllers")]
    public List<DomainController> DomainControllers { get; set; }

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
      sb.Append("class AssetTestConnectionParameters {\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
      sb.Append("  SshHostKey: ").Append(SshHostKey).Append("\n");
      sb.Append("  AutoAcceptSshHostKey: ").Append(AutoAcceptSshHostKey).Append("\n");
      sb.Append("  ExtendedLogging: ").Append(ExtendedLogging).Append("\n");
      sb.Append("  DomainControllers: ").Append(DomainControllers).Append("\n");
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
