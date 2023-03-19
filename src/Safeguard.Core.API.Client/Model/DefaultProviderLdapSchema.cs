using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Default ldap schema for a directory
  /// </summary>
  [DataContract]
  public class DefaultProviderLdapSchema {
    /// <summary>
    /// Gets or Sets DefaultSchema
    /// </summary>
    [DataMember(Name="DefaultSchema", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultSchema")]
    public IdentityProviderLdapSchema DefaultSchema { get; set; }

    /// <summary>
    /// Gets or Sets UserSchemaDescriptors
    /// </summary>
    [DataMember(Name="UserSchemaDescriptors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserSchemaDescriptors")]
    public UserProviderSchemaDescriptors UserSchemaDescriptors { get; set; }

    /// <summary>
    /// Gets or Sets GroupSchemaDescriptors
    /// </summary>
    [DataMember(Name="GroupSchemaDescriptors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupSchemaDescriptors")]
    public GroupSchemaDescriptors GroupSchemaDescriptors { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DefaultProviderLdapSchema {\n");
      sb.Append("  DefaultSchema: ").Append(DefaultSchema).Append("\n");
      sb.Append("  UserSchemaDescriptors: ").Append(UserSchemaDescriptors).Append("\n");
      sb.Append("  GroupSchemaDescriptors: ").Append(GroupSchemaDescriptors).Append("\n");
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
