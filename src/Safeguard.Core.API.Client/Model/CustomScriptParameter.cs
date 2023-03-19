using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A parameters that should be provided to the custom platform script when invoked
  /// </summary>
  [DataContract]
  public class CustomScriptParameter {
    /// <summary>
    /// The name of the parameter
    /// </summary>
    /// <value>The name of the parameter</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Short explanation of the parameter
    /// </summary>
    /// <value>Short explanation of the parameter</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Default value of the parameter
    /// </summary>
    /// <value>Default value of the parameter</value>
    [DataMember(Name="DefaultValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultValue")]
    public string DefaultValue { get; set; }

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
      sb.Append("class CustomScriptParameter {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
