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
  public class NodeNetworkInformation {
    /// <summary>
    /// The IPv4 network address
    /// </summary>
    /// <value>The IPv4 network address</value>
    [DataMember(Name="Ipv4Address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Ipv4Address")]
    public string Ipv4Address { get; set; }

    /// <summary>
    /// The IPv6 network address
    /// </summary>
    /// <value>The IPv6 network address</value>
    [DataMember(Name="Ipv6Address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Ipv6Address")]
    public string Ipv6Address { get; set; }

    /// <summary>
    /// Whether the link is present
    /// </summary>
    /// <value>Whether the link is present</value>
    [DataMember(Name="LinkPresent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LinkPresent")]
    public bool? LinkPresent { get; set; }

    /// <summary>
    /// The speed of the network link.
    /// </summary>
    /// <value>The speed of the network link.</value>
    [DataMember(Name="LinkSpeedMbps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LinkSpeedMbps")]
    public int? LinkSpeedMbps { get; set; }

    /// <summary>
    /// MAC address of this interface
    /// </summary>
    /// <value>MAC address of this interface</value>
    [DataMember(Name="MacAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MacAddress")]
    public string MacAddress { get; set; }

    /// <summary>
    /// Host DNS Suffix
    /// </summary>
    /// <value>Host DNS Suffix</value>
    [DataMember(Name="HostDnsSuffix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HostDnsSuffix")]
    public string HostDnsSuffix { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeNetworkInformation {\n");
      sb.Append("  Ipv4Address: ").Append(Ipv4Address).Append("\n");
      sb.Append("  Ipv6Address: ").Append(Ipv6Address).Append("\n");
      sb.Append("  LinkPresent: ").Append(LinkPresent).Append("\n");
      sb.Append("  LinkSpeedMbps: ").Append(LinkSpeedMbps).Append("\n");
      sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
      sb.Append("  HostDnsSuffix: ").Append(HostDnsSuffix).Append("\n");
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
