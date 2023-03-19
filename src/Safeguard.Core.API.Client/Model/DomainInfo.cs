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
  public class DomainInfo {
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
    /// Whether this domain should be visible in the UI for authentication and directory searches.
    /// </summary>
    /// <value>Whether this domain should be visible in the UI for authentication and directory searches.</value>
    [DataMember(Name="IsVisible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsVisible")]
    public bool? IsVisible { get; set; }

    /// <summary>
    /// Determines if this domain is also the forest root domain of an Active Directory forest.  Not applicable for LDAP  providers.  (Read-only)
    /// </summary>
    /// <value>Determines if this domain is also the forest root domain of an Active Directory forest.  Not applicable for LDAP  providers.  (Read-only)</value>
    [DataMember(Name="IsForestRoot", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsForestRoot")]
    public bool? IsForestRoot { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DomainInfo {\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  NetBiosName: ").Append(NetBiosName).Append("\n");
      sb.Append("  DomainUniqueId: ").Append(DomainUniqueId).Append("\n");
      sb.Append("  NamingContext: ").Append(NamingContext).Append("\n");
      sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
      sb.Append("  IsForestRoot: ").Append(IsForestRoot).Append("\n");
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
