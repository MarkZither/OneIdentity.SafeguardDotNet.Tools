using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The count of a given scheduled task. Used in DateTasks.Counts array.
  /// </summary>
  [DataContract]
  public class TaskSummary {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public TaskNames Name { get; set; }

    /// <summary>
    /// Count of scheduled tasks
    /// </summary>
    /// <value>Count of scheduled tasks</value>
    [DataMember(Name="Count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Count")]
    public int? Count { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TaskSummary {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
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
