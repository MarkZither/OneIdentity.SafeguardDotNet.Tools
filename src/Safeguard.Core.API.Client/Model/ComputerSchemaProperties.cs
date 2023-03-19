using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Directory attribute mappings for computers
  /// </summary>
  [DataContract]
  public class ComputerSchemaProperties {
    /// <summary>
    /// LDAP objects that have all of the specified objectClass types will be treated as computers.  These objectClass types will also be used to validate the attributes mapped to computer properties.
    /// </summary>
    /// <value>LDAP objects that have all of the specified objectClass types will be treated as computers.  These objectClass types will also be used to validate the attributes mapped to computer properties.</value>
    [DataMember(Name="ComputerClassType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ComputerClassType")]
    public List<string> ComputerClassType { get; set; }

    /// <summary>
    /// Name of host name schema attribute
    /// </summary>
    /// <value>Name of host name schema attribute</value>
    [DataMember(Name="NameAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NameAttribute")]
    public string NameAttribute { get; set; }

    /// <summary>
    /// Name of description schema attribute
    /// </summary>
    /// <value>Name of description schema attribute</value>
    [DataMember(Name="DescriptionAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DescriptionAttribute")]
    public string DescriptionAttribute { get; set; }

    /// <summary>
    /// Name of host schema attribute
    /// </summary>
    /// <value>Name of host schema attribute</value>
    [DataMember(Name="NetworkAddressAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddressAttribute")]
    public string NetworkAddressAttribute { get; set; }

    /// <summary>
    /// Name of host AD schema attribute
    /// </summary>
    /// <value>Name of host AD schema attribute</value>
    [DataMember(Name="OperatingSystemAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OperatingSystemAttribute")]
    public string OperatingSystemAttribute { get; set; }

    /// <summary>
    /// Name of host schema attribute
    /// </summary>
    /// <value>Name of host schema attribute</value>
    [DataMember(Name="OperatingSystemVersionAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OperatingSystemVersionAttribute")]
    public string OperatingSystemVersionAttribute { get; set; }

    /// <summary>
    /// Member of group schema attribute
    /// </summary>
    /// <value>Member of group schema attribute</value>
    [DataMember(Name="MemberOfAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MemberOfAttribute")]
    public string MemberOfAttribute { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ComputerSchemaProperties {\n");
      sb.Append("  ComputerClassType: ").Append(ComputerClassType).Append("\n");
      sb.Append("  NameAttribute: ").Append(NameAttribute).Append("\n");
      sb.Append("  DescriptionAttribute: ").Append(DescriptionAttribute).Append("\n");
      sb.Append("  NetworkAddressAttribute: ").Append(NetworkAddressAttribute).Append("\n");
      sb.Append("  OperatingSystemAttribute: ").Append(OperatingSystemAttribute).Append("\n");
      sb.Append("  OperatingSystemVersionAttribute: ").Append(OperatingSystemVersionAttribute).Append("\n");
      sb.Append("  MemberOfAttribute: ").Append(MemberOfAttribute).Append("\n");
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
