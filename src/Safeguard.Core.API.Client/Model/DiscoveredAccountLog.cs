using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An account discovered as part of an account discovery task
  /// </summary>
  [DataContract]
  public class DiscoveredAccountLog {
    /// <summary>
    /// Name of the discovered account
    /// </summary>
    /// <value>Name of the discovered account</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Discovered ID of the account
    /// </summary>
    /// <value>Discovered ID of the account</value>
    [DataMember(Name="DiscoveredUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredUserId")]
    public string DiscoveredUserId { get; set; }

    /// <summary>
    /// Domain name of the discovered account
    /// </summary>
    /// <value>Domain name of the discovered account</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public DiscoveredAccountStatus Status { get; set; }

    /// <summary>
    /// Discovered groups of the account
    /// </summary>
    /// <value>Discovered groups of the account</value>
    [DataMember(Name="DiscoveredGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredGroups")]
    public List<DiscoveredGroupLog> DiscoveredGroups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiscoveredAccountLog {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DiscoveredUserId: ").Append(DiscoveredUserId).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  DiscoveredGroups: ").Append(DiscoveredGroups).Append("\n");
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
