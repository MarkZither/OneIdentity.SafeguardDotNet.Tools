using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an appliance that has been assigned to a managed network
  /// </summary>
  [DataContract]
  public class NetworkMember {
    /// <summary>
    /// Gets or Sets SessionMemberStatus
    /// </summary>
    [DataMember(Name="SessionMemberStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionMemberStatus")]
    public SessionMemberStatus SessionMemberStatus { get; set; }

    /// <summary>
    /// Roles assigned to the sessions member
    /// </summary>
    /// <value>Roles assigned to the sessions member</value>
    [DataMember(Name="SessionMemberRoles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionMemberRoles")]
    public List<string> SessionMemberRoles { get; set; }

    /// <summary>
    /// The unique ID of the appliance
    /// </summary>
    /// <value>The unique ID of the appliance</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// The display name of the appliance
    /// </summary>
    /// <value>The display name of the appliance</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// The Host Dns Suffix of the appliance
    /// </summary>
    /// <value>The Host Dns Suffix of the appliance</value>
    [DataMember(Name="HostDnsSuffix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HostDnsSuffix")]
    public string HostDnsSuffix { get; set; }

    /// <summary>
    /// The IPv4 address of this appliance
    /// </summary>
    /// <value>The IPv4 address of this appliance</value>
    [DataMember(Name="Ipv4Address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Ipv4Address")]
    public string Ipv4Address { get; set; }

    /// <summary>
    /// The IPv6 address of this appliance
    /// </summary>
    /// <value>The IPv6 address of this appliance</value>
    [DataMember(Name="Ipv6Address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Ipv6Address")]
    public string Ipv6Address { get; set; }

    /// <summary>
    /// Determines if the member is a sessions appliance
    /// </summary>
    /// <value>Determines if the member is a sessions appliance</value>
    [DataMember(Name="IsSessionMember", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSessionMember")]
    public bool? IsSessionMember { get; set; }

    /// <summary>
    /// Configuration sync status to the sessions member
    /// </summary>
    /// <value>Configuration sync status to the sessions member</value>
    [DataMember(Name="SyncStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncStatus")]
    public string SyncStatus { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NetworkMember {\n");
      sb.Append("  SessionMemberStatus: ").Append(SessionMemberStatus).Append("\n");
      sb.Append("  SessionMemberRoles: ").Append(SessionMemberRoles).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  HostDnsSuffix: ").Append(HostDnsSuffix).Append("\n");
      sb.Append("  Ipv4Address: ").Append(Ipv4Address).Append("\n");
      sb.Append("  Ipv6Address: ").Append(Ipv6Address).Append("\n");
      sb.Append("  IsSessionMember: ").Append(IsSessionMember).Append("\n");
      sb.Append("  SyncStatus: ").Append(SyncStatus).Append("\n");
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
