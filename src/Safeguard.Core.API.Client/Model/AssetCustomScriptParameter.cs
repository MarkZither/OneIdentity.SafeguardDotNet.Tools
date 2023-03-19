using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Parameters passed to custom platform script
  /// </summary>
  [DataContract]
  public class AssetCustomScriptParameter {
    /// <summary>
    /// Name of the parameter
    /// </summary>
    /// <value>Name of the parameter</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Value of the parameter. If not specified (or set to null) the existing value will be retained (or set to default type value for create, e.g. empty string)
    /// </summary>
    /// <value>Value of the parameter. If not specified (or set to null) the existing value will be retained (or set to default type value for create, e.g. empty string)</value>
    [DataMember(Name="Value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Value")]
    public string Value { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public CustomScriptParameterType Type { get; set; }

    /// <summary>
    /// Gets or Sets TaskName
    /// </summary>
    [DataMember(Name="TaskName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaskName")]
    public TaskNames TaskName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetCustomScriptParameter {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TaskName: ").Append(TaskName).Append("\n");
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
