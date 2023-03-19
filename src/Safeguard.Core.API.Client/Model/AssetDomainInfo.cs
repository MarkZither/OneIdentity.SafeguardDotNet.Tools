using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents information about available domains that can be searched in an Directory
  /// </summary>
  [DataContract]
  public class AssetDomainInfo {
    /// <summary>
    /// Name of the domain
    /// </summary>
    /// <value>Name of the domain</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// Netbios name of the domain
    /// </summary>
    /// <value>Netbios name of the domain</value>
    [DataMember(Name="NetBiosName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetBiosName")]
    public string NetBiosName { get; set; }

    /// <summary>
    /// Sid of the Domain
    /// </summary>
    /// <value>Sid of the Domain</value>
    [DataMember(Name="DomainUniqueId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainUniqueId")]
    public string DomainUniqueId { get; set; }

    /// <summary>
    /// Default Naming Context for the Domain
    /// </summary>
    /// <value>Default Naming Context for the Domain</value>
    [DataMember(Name="NamingContext", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NamingContext")]
    public string NamingContext { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetDomainInfo {\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  NetBiosName: ").Append(NetBiosName).Append("\n");
      sb.Append("  DomainUniqueId: ").Append(DomainUniqueId).Append("\n");
      sb.Append("  NamingContext: ").Append(NamingContext).Append("\n");
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
