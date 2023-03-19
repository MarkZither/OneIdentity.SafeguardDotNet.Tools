using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a session module connection policy
  /// </summary>
  [DataContract]
  public class SessionModuleConnectionPolicy {
    /// <summary>
    /// Connection policy identifier
    /// </summary>
    /// <value>Connection policy identifier</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// Connection policy name
    /// </summary>
    /// <value>Connection policy name</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Network address of the linked session module
    /// </summary>
    /// <value>Network address of the linked session module</value>
    [DataMember(Name="SpsNetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpsNetworkAddress")]
    public string SpsNetworkAddress { get; set; }

    /// <summary>
    /// Target address of the connection policy
    /// </summary>
    /// <value>Target address of the connection policy</value>
    [DataMember(Name="SpsTargetAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpsTargetAddress")]
    public string SpsTargetAddress { get; set; }

    /// <summary>
    /// Network port of the linked session module
    /// </summary>
    /// <value>Network port of the linked session module</value>
    [DataMember(Name="SpsNetworkPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpsNetworkPort")]
    public string SpsNetworkPort { get; set; }

    /// <summary>
    /// SPS host name.
    /// </summary>
    /// <value>SPS host name.</value>
    [DataMember(Name="SpsHostName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpsHostName")]
    public string SpsHostName { get; set; }

    /// <summary>
    /// SPS policy capabilities.
    /// </summary>
    /// <value>SPS policy capabilities.</value>
    [DataMember(Name="PolicyCapabilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyCapabilities")]
    public List<SessionPolicyCapabilities> PolicyCapabilities { get; set; }

    /// <summary>
    /// Gets or Sets Protocol
    /// </summary>
    [DataMember(Name="Protocol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Protocol")]
    public SessionModuleConnectionProtocol Protocol { get; set; }

    /// <summary>
    /// Session module connection ID
    /// </summary>
    /// <value>Session module connection ID</value>
    [DataMember(Name="SessionModuleConnectionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionModuleConnectionId")]
    public int? SessionModuleConnectionId { get; set; }

    /// <summary>
    /// Session module connection policy is disabled or not
    /// </summary>
    /// <value>Session module connection policy is disabled or not</value>
    [DataMember(Name="IsPolicyDisabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPolicyDisabled")]
    public bool? IsPolicyDisabled { get; set; }

    /// <summary>
    /// Does the session module connection policy require a host key
    /// </summary>
    /// <value>Does the session module connection policy require a host key</value>
    [DataMember(Name="RequiresHostKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequiresHostKey")]
    public bool? RequiresHostKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SessionModuleConnectionPolicy {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SpsNetworkAddress: ").Append(SpsNetworkAddress).Append("\n");
      sb.Append("  SpsTargetAddress: ").Append(SpsTargetAddress).Append("\n");
      sb.Append("  SpsNetworkPort: ").Append(SpsNetworkPort).Append("\n");
      sb.Append("  SpsHostName: ").Append(SpsHostName).Append("\n");
      sb.Append("  PolicyCapabilities: ").Append(PolicyCapabilities).Append("\n");
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
      sb.Append("  SessionModuleConnectionId: ").Append(SessionModuleConnectionId).Append("\n");
      sb.Append("  IsPolicyDisabled: ").Append(IsPolicyDisabled).Append("\n");
      sb.Append("  RequiresHostKey: ").Append(RequiresHostKey).Append("\n");
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
