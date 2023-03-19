using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Appliance in the cluster
  /// </summary>
  [DataContract]
  public class Appliance {
    /// <summary>
    /// Appliance unique ID
    /// </summary>
    /// <value>Appliance unique ID</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// Appliance display name
    /// </summary>
    /// <value>Appliance display name</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// IPv4 address of this appliance
    /// </summary>
    /// <value>IPv4 address of this appliance</value>
    [DataMember(Name="Ipv4Address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Ipv4Address")]
    public string Ipv4Address { get; set; }

    /// <summary>
    /// IPv6 address of this appliance
    /// </summary>
    /// <value>IPv6 address of this appliance</value>
    [DataMember(Name="Ipv6Address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Ipv6Address")]
    public string Ipv6Address { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Appliance {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Ipv4Address: ").Append(Ipv4Address).Append("\n");
      sb.Append("  Ipv6Address: ").Append(Ipv6Address).Append("\n");
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
