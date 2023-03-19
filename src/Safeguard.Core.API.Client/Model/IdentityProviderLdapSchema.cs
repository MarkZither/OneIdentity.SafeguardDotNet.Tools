using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Directory property mappings used when importing and synchronizing entities
  /// </summary>
  [DataContract]
  public class IdentityProviderLdapSchema {
    /// <summary>
    /// Gets or Sets UserProperties
    /// </summary>
    [DataMember(Name="UserProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserProperties")]
    public UserProviderSchemaProperties UserProperties { get; set; }

    /// <summary>
    /// Gets or Sets GroupProperties
    /// </summary>
    [DataMember(Name="GroupProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupProperties")]
    public GroupSchemaProperties GroupProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentityProviderLdapSchema {\n");
      sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
      sb.Append("  GroupProperties: ").Append(GroupProperties).Append("\n");
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
