using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Descriptors for user schema properties
  /// </summary>
  [DataContract]
  public class UserAssetSchemaDescriptors {
    /// <summary>
    /// Gets or Sets UserClassTypeDescriptor
    /// </summary>
    [DataMember(Name="UserClassTypeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserClassTypeDescriptor")]
    public SchemaDescriptor UserClassTypeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets UserNameAttributeDescriptor
    /// </summary>
    [DataMember(Name="UserNameAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserNameAttributeDescriptor")]
    public SchemaDescriptor UserNameAttributeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets PasswordAttributeDescriptor
    /// </summary>
    [DataMember(Name="PasswordAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordAttributeDescriptor")]
    public SchemaDescriptor PasswordAttributeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets DescriptionAttributeDescriptor
    /// </summary>
    [DataMember(Name="DescriptionAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DescriptionAttributeDescriptor")]
    public SchemaDescriptor DescriptionAttributeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets MemberOfAttributeDescriptor
    /// </summary>
    [DataMember(Name="MemberOfAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MemberOfAttributeDescriptor")]
    public SchemaDescriptor MemberOfAttributeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets AltLoginNameAttributeDescriptor
    /// </summary>
    [DataMember(Name="AltLoginNameAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AltLoginNameAttributeDescriptor")]
    public SchemaDescriptor AltLoginNameAttributeDescriptor { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserAssetSchemaDescriptors {\n");
      sb.Append("  UserClassTypeDescriptor: ").Append(UserClassTypeDescriptor).Append("\n");
      sb.Append("  UserNameAttributeDescriptor: ").Append(UserNameAttributeDescriptor).Append("\n");
      sb.Append("  PasswordAttributeDescriptor: ").Append(PasswordAttributeDescriptor).Append("\n");
      sb.Append("  DescriptionAttributeDescriptor: ").Append(DescriptionAttributeDescriptor).Append("\n");
      sb.Append("  MemberOfAttributeDescriptor: ").Append(MemberOfAttributeDescriptor).Append("\n");
      sb.Append("  AltLoginNameAttributeDescriptor: ").Append(AltLoginNameAttributeDescriptor).Append("\n");
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
