using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a directory domain controller
  /// </summary>
  [DataContract]
  public class DomainController {
    /// <summary>
    /// Network DNS name or IP address used to connect to the machine over the network
    /// </summary>
    /// <value>Network DNS name or IP address used to connect to the machine over the network</value>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

    /// <summary>
    /// The domain that is managed
    /// </summary>
    /// <value>The domain that is managed</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// Whether this is a read-only domain controller or not
    /// </summary>
    /// <value>Whether this is a read-only domain controller or not</value>
    [DataMember(Name="IsWritable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsWritable")]
    public bool? IsWritable { get; set; }

    /// <summary>
    /// Gets or Sets ServerType
    /// </summary>
    [DataMember(Name="ServerType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServerType")]
    public DirectoryServerType ServerType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DomainController {\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  IsWritable: ").Append(IsWritable).Append("\n");
      sb.Append("  ServerType: ").Append(ServerType).Append("\n");
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
