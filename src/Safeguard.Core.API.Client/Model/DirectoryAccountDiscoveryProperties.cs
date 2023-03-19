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
  public class DirectoryAccountDiscoveryProperties {
    /// <summary>
    /// Gets or Sets RuleType
    /// </summary>
    [DataMember(Name="RuleType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RuleType")]
    public DirectoryAccountDiscoveryRuleType RuleType { get; set; }

    /// <summary>
    /// Gets or Sets PropertyConstraintProperties
    /// </summary>
    [DataMember(Name="PropertyConstraintProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PropertyConstraintProperties")]
    public DirectoryPropertyConstraintProperties PropertyConstraintProperties { get; set; }

    /// <summary>
    /// AD search base for discovering accounts
    /// </summary>
    /// <value>AD search base for discovering accounts</value>
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
    /// Name to search for 'Name' RuleType
    /// </summary>
    /// <value>Name to search for 'Name' RuleType</value>
    [DataMember(Name="SearchName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SearchName")]
    public string SearchName { get; set; }

    /// <summary>
    /// Gets or Sets SearchNameType
    /// </summary>
    [DataMember(Name="SearchNameType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SearchNameType")]
    public SearchNameType SearchNameType { get; set; }

    /// <summary>
    /// Custom LDAP filter to search for 'LdapFilter' RuleType
    /// </summary>
    /// <value>Custom LDAP filter to search for 'LdapFilter' RuleType</value>
    [DataMember(Name="LdapFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LdapFilter")]
    public string LdapFilter { get; set; }

    /// <summary>
    /// List of group distinguishedNames for searching membership for 'Group' RuleType
    /// </summary>
    /// <value>List of group distinguishedNames for searching membership for 'Group' RuleType</value>
    [DataMember(Name="Groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Groups")]
    public List<string> Groups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DirectoryAccountDiscoveryProperties {\n");
      sb.Append("  RuleType: ").Append(RuleType).Append("\n");
      sb.Append("  PropertyConstraintProperties: ").Append(PropertyConstraintProperties).Append("\n");
      sb.Append("  SearchBase: ").Append(SearchBase).Append("\n");
      sb.Append("  SearchScope: ").Append(SearchScope).Append("\n");
      sb.Append("  SearchName: ").Append(SearchName).Append("\n");
      sb.Append("  SearchNameType: ").Append(SearchNameType).Append("\n");
      sb.Append("  LdapFilter: ").Append(LdapFilter).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
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
