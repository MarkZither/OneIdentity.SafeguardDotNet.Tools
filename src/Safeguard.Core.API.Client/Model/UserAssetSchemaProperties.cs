using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Directory attribute mappings for users
  /// </summary>
  [DataContract]
  public class UserAssetSchemaProperties {
    /// <summary>
    /// LDAP objects that have all of the specified objectClass types will be treated as users.  These objectClass types will also be used to validate the attributes mapped to user properties.
    /// </summary>
    /// <value>LDAP objects that have all of the specified objectClass types will be treated as users.  These objectClass types will also be used to validate the attributes mapped to user properties.</value>
    [DataMember(Name="UserClassType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserClassType")]
    public List<string> UserClassType { get; set; }

    /// <summary>
    /// Name of user name schema attribute
    /// </summary>
    /// <value>Name of user name schema attribute</value>
    [DataMember(Name="UserNameAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserNameAttribute")]
    public string UserNameAttribute { get; set; }

    /// <summary>
    /// Name of password schema attribute (Ldap only)
    /// </summary>
    /// <value>Name of password schema attribute (Ldap only)</value>
    [DataMember(Name="PasswordAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordAttribute")]
    public string PasswordAttribute { get; set; }

    /// <summary>
    /// Name of description schema attribute
    /// </summary>
    /// <value>Name of description schema attribute</value>
    [DataMember(Name="DescriptionAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DescriptionAttribute")]
    public string DescriptionAttribute { get; set; }

    /// <summary>
    /// Name of MemberOf schema attribute
    /// </summary>
    /// <value>Name of MemberOf schema attribute</value>
    [DataMember(Name="MemberOfAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MemberOfAttribute")]
    public string MemberOfAttribute { get; set; }

    /// <summary>
    /// Name of user principle
    /// </summary>
    /// <value>Name of user principle</value>
    [DataMember(Name="AltLoginNameAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AltLoginNameAttribute")]
    public string AltLoginNameAttribute { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserAssetSchemaProperties {\n");
      sb.Append("  UserClassType: ").Append(UserClassType).Append("\n");
      sb.Append("  UserNameAttribute: ").Append(UserNameAttribute).Append("\n");
      sb.Append("  PasswordAttribute: ").Append(PasswordAttribute).Append("\n");
      sb.Append("  DescriptionAttribute: ").Append(DescriptionAttribute).Append("\n");
      sb.Append("  MemberOfAttribute: ").Append(MemberOfAttribute).Append("\n");
      sb.Append("  AltLoginNameAttribute: ").Append(AltLoginNameAttribute).Append("\n");
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
