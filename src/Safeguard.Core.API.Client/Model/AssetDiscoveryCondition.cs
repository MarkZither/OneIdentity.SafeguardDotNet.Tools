using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Conditions to determine which assets to add to database
  /// </summary>
  [DataContract]
  public class AssetDiscoveryCondition {
    /// <summary>
    /// Gets or Sets ConditionType
    /// </summary>
    [DataMember(Name="ConditionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConditionType")]
    public AssetDiscoveryConditionType ConditionType { get; set; }

    /// <summary>
    /// Optional AD group to restrict Active Directory search to
    /// </summary>
    /// <value>Optional AD group to restrict Active Directory search to</value>
    [DataMember(Name="AdGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdGroups")]
    public List<string> AdGroups { get; set; }

    /// <summary>
    /// Custom LDAP filter to search for computer objects (Only available for Directory DiscoveryType)
    /// </summary>
    /// <value>Custom LDAP filter to search for computer objects (Only available for Directory DiscoveryType)</value>
    [DataMember(Name="LdapFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LdapFilter")]
    public string LdapFilter { get; set; }

    /// <summary>
    /// Set of property constraints to match against discovered assets
    /// </summary>
    /// <value>Set of property constraints to match against discovered assets</value>
    [DataMember(Name="PropertyConstraints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PropertyConstraints")]
    public List<AssetDiscoveryPropertyConstraint> PropertyConstraints { get; set; }

    /// <summary>
    /// Search base for computer objects (Only available for Directory DiscoveryType)
    /// </summary>
    /// <value>Search base for computer objects (Only available for Directory DiscoveryType)</value>
    [DataMember(Name="SearchBase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SearchBase")]
    public string SearchBase { get; set; }

    /// <summary>
    /// Gets or Sets SearchScope
    /// </summary>
    [DataMember(Name="SearchScope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SearchScope")]
    public DiscoverySearchScope SearchScope { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetDiscoveryCondition {\n");
      sb.Append("  ConditionType: ").Append(ConditionType).Append("\n");
      sb.Append("  AdGroups: ").Append(AdGroups).Append("\n");
      sb.Append("  LdapFilter: ").Append(LdapFilter).Append("\n");
      sb.Append("  PropertyConstraints: ").Append(PropertyConstraints).Append("\n");
      sb.Append("  SearchBase: ").Append(SearchBase).Append("\n");
      sb.Append("  SearchScope: ").Append(SearchScope).Append("\n");
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
