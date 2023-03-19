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
  public class ClusterMember {
    /// <summary>
    /// Gets or Sets Health
    /// </summary>
    [DataMember(Name="Health", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Health")]
    public NodeHealth Health { get; set; }

    /// <summary>
    /// Unique Id of the cluster member
    /// </summary>
    /// <value>Unique Id of the cluster member</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// Flag indicating whether the member is the cluster leader
    /// </summary>
    /// <value>Flag indicating whether the member is the cluster leader</value>
    [DataMember(Name="IsLeader", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsLeader")]
    public bool? IsLeader { get; set; }

    /// <summary>
    /// Name of the cluster member
    /// </summary>
    /// <value>Name of the cluster member</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// HostDnsSuffix of the cluster member
    /// </summary>
    /// <value>HostDnsSuffix of the cluster member</value>
    [DataMember(Name="HostDnsSuffix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HostDnsSuffix")]
    public string HostDnsSuffix { get; set; }

    /// <summary>
    /// The Ipv4 address of the cluster member
    /// </summary>
    /// <value>The Ipv4 address of the cluster member</value>
    [DataMember(Name="Ipv4Address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Ipv4Address")]
    public string Ipv4Address { get; set; }

    /// <summary>
    /// The Ipv6 address of the cluster member
    /// </summary>
    /// <value>The Ipv6 address of the cluster member</value>
    [DataMember(Name="Ipv6Address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Ipv6Address")]
    public string Ipv6Address { get; set; }

    /// <summary>
    /// The thumbprint of the certificate used for SSL
    /// </summary>
    /// <value>The thumbprint of the certificate used for SSL</value>
    [DataMember(Name="SslCertificateThumbprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SslCertificateThumbprint")]
    public string SslCertificateThumbprint { get; set; }

    /// <summary>
    /// The timestamp when this member was enrolled in the cluster
    /// </summary>
    /// <value>The timestamp when this member was enrolled in the cluster</value>
    [DataMember(Name="EnrolledSince", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EnrolledSince")]
    public DateTime? EnrolledSince { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClusterMember {\n");
      sb.Append("  Health: ").Append(Health).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsLeader: ").Append(IsLeader).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  HostDnsSuffix: ").Append(HostDnsSuffix).Append("\n");
      sb.Append("  Ipv4Address: ").Append(Ipv4Address).Append("\n");
      sb.Append("  Ipv6Address: ").Append(Ipv6Address).Append("\n");
      sb.Append("  SslCertificateThumbprint: ").Append(SslCertificateThumbprint).Append("\n");
      sb.Append("  EnrolledSince: ").Append(EnrolledSince).Append("\n");
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
