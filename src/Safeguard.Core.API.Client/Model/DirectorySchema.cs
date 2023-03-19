using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A schema definition from AD
  /// </summary>
  [DataContract]
  public class DirectorySchema {
    /// <summary>
    /// The name of the schame attribute
    /// </summary>
    /// <value>The name of the schame attribute</value>
    [DataMember(Name="ObjectClassName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectClassName")]
    public string ObjectClassName { get; set; }

    /// <summary>
    /// Value type of attribute
    /// </summary>
    /// <value>Value type of attribute</value>
    [DataMember(Name="Attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Attributes")]
    public List<DirectorySchemaAttribute> Attributes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DirectorySchema {\n");
      sb.Append("  ObjectClassName: ").Append(ObjectClassName).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
