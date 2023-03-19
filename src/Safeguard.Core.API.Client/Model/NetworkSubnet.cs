using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a network subnet in CIDR notation e.g., 192.168.1.0/24
  /// </summary>
  [DataContract]
  public class NetworkSubnet {
    /// <summary>
    /// Gets or Sets AddressFamily
    /// </summary>
    [DataMember(Name="AddressFamily", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AddressFamily")]
    public NetworkAddressFamily AddressFamily { get; set; }

    /// <summary>
    /// Address of the network e.g., 192.168.1.0 or 2001:0db8:0123:4567:89ab:cdef:1234:5678
    /// </summary>
    /// <value>Address of the network e.g., 192.168.1.0 or 2001:0db8:0123:4567:89ab:cdef:1234:5678</value>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

    /// <summary>
    /// The length of the network prefix e.g., 24
    /// </summary>
    /// <value>The length of the network prefix e.g., 24</value>
    [DataMember(Name="NetworkPrefixLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkPrefixLength")]
    public int? NetworkPrefixLength { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NetworkSubnet {\n");
      sb.Append("  AddressFamily: ").Append(AddressFamily).Append("\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  NetworkPrefixLength: ").Append(NetworkPrefixLength).Append("\n");
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
