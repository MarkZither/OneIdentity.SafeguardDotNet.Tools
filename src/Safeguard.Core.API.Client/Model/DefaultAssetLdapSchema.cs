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
  public class DefaultAssetLdapSchema {
    /// <summary>
    /// Gets or Sets DefaultSchema
    /// </summary>
    [DataMember(Name="DefaultSchema", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultSchema")]
    public AssetLdapSchema DefaultSchema { get; set; }

    /// <summary>
    /// Gets or Sets UserSchemaDescriptors
    /// </summary>
    [DataMember(Name="UserSchemaDescriptors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserSchemaDescriptors")]
    public UserAssetSchemaDescriptors UserSchemaDescriptors { get; set; }

    /// <summary>
    /// Gets or Sets ComputerSchemaDescriptors
    /// </summary>
    [DataMember(Name="ComputerSchemaDescriptors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ComputerSchemaDescriptors")]
    public ComputerSchemaDescriptors ComputerSchemaDescriptors { get; set; }

    /// <summary>
    /// Gets or Sets GroupSchemaDescriptors
    /// </summary>
    [DataMember(Name="GroupSchemaDescriptors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupSchemaDescriptors")]
    public GroupAssetSchemaDescriptors GroupSchemaDescriptors { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DefaultAssetLdapSchema {\n");
      sb.Append("  DefaultSchema: ").Append(DefaultSchema).Append("\n");
      sb.Append("  UserSchemaDescriptors: ").Append(UserSchemaDescriptors).Append("\n");
      sb.Append("  ComputerSchemaDescriptors: ").Append(ComputerSchemaDescriptors).Append("\n");
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
