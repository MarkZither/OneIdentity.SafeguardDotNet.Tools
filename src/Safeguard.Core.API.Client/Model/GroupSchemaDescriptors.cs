using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Descriptors for group schema properties
  /// </summary>
  [DataContract]
  public class GroupSchemaDescriptors {
    /// <summary>
    /// Gets or Sets GroupClassTypeDescriptor
    /// </summary>
    [DataMember(Name="GroupClassTypeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupClassTypeDescriptor")]
    public SchemaDescriptor GroupClassTypeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets MemberAttributeDescriptor
    /// </summary>
    [DataMember(Name="MemberAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MemberAttributeDescriptor")]
    public SchemaDescriptor MemberAttributeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets NameAttributeDescriptor
    /// </summary>
    [DataMember(Name="NameAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NameAttributeDescriptor")]
    public SchemaDescriptor NameAttributeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets DescriptionAttributeDescriptor
    /// </summary>
    [DataMember(Name="DescriptionAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DescriptionAttributeDescriptor")]
    public SchemaDescriptor DescriptionAttributeDescriptor { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupSchemaDescriptors {\n");
      sb.Append("  GroupClassTypeDescriptor: ").Append(GroupClassTypeDescriptor).Append("\n");
      sb.Append("  MemberAttributeDescriptor: ").Append(MemberAttributeDescriptor).Append("\n");
      sb.Append("  NameAttributeDescriptor: ").Append(NameAttributeDescriptor).Append("\n");
      sb.Append("  DescriptionAttributeDescriptor: ").Append(DescriptionAttributeDescriptor).Append("\n");
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
