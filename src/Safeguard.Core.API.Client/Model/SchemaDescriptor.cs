using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Descriptor for a schema property
  /// </summary>
  [DataContract]
  public class SchemaDescriptor {
    /// <summary>
    /// This property is required to be set
    /// </summary>
    /// <value>This property is required to be set</value>
    [DataMember(Name="Required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Required")]
    public bool? Required { get; set; }

    /// <summary>
    /// This property is readonly
    /// </summary>
    /// <value>This property is readonly</value>
    [DataMember(Name="ReadOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReadOnly")]
    public bool? _ReadOnly { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SchemaDescriptor {\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
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
