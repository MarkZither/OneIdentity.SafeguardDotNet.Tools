using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Descriptors for computer schema properties
  /// </summary>
  [DataContract]
  public class ComputerSchemaDescriptors {
    /// <summary>
    /// Gets or Sets ComputerClassTypeDescriptor
    /// </summary>
    [DataMember(Name="ComputerClassTypeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ComputerClassTypeDescriptor")]
    public SchemaDescriptor ComputerClassTypeDescriptor { get; set; }

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
    /// Gets or Sets NetworkAddressAttributeDescriptor
    /// </summary>
    [DataMember(Name="NetworkAddressAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddressAttributeDescriptor")]
    public SchemaDescriptor NetworkAddressAttributeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets OperatingSystemAttributeDescriptor
    /// </summary>
    [DataMember(Name="OperatingSystemAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OperatingSystemAttributeDescriptor")]
    public SchemaDescriptor OperatingSystemAttributeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets OperatingSystemVersionAttributeDescriptor
    /// </summary>
    [DataMember(Name="OperatingSystemVersionAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OperatingSystemVersionAttributeDescriptor")]
    public SchemaDescriptor OperatingSystemVersionAttributeDescriptor { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ComputerSchemaDescriptors {\n");
      sb.Append("  ComputerClassTypeDescriptor: ").Append(ComputerClassTypeDescriptor).Append("\n");
      sb.Append("  NameAttributeDescriptor: ").Append(NameAttributeDescriptor).Append("\n");
      sb.Append("  DescriptionAttributeDescriptor: ").Append(DescriptionAttributeDescriptor).Append("\n");
      sb.Append("  NetworkAddressAttributeDescriptor: ").Append(NetworkAddressAttributeDescriptor).Append("\n");
      sb.Append("  OperatingSystemAttributeDescriptor: ").Append(OperatingSystemAttributeDescriptor).Append("\n");
      sb.Append("  OperatingSystemVersionAttributeDescriptor: ").Append(OperatingSystemVersionAttributeDescriptor).Append("\n");
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
