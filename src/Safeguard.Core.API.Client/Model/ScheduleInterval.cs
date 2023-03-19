using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Interval of time in which to execute tasks
  /// </summary>
  [DataContract]
  public class ScheduleInterval {
    /// <summary>
    /// Hour the interval starts
    /// </summary>
    /// <value>Hour the interval starts</value>
    [DataMember(Name="StartHour", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartHour")]
    public int? StartHour { get; set; }

    /// <summary>
    /// Minute the interval starts
    /// </summary>
    /// <value>Minute the interval starts</value>
    [DataMember(Name="StartMinute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartMinute")]
    public int? StartMinute { get; set; }

    /// <summary>
    /// Hour the interval ends
    /// </summary>
    /// <value>Hour the interval ends</value>
    [DataMember(Name="EndHour", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndHour")]
    public int? EndHour { get; set; }

    /// <summary>
    /// Minute the interval ends. The end minute is not included in the window interval
    /// </summary>
    /// <value>Minute the interval ends. The end minute is not included in the window interval</value>
    [DataMember(Name="EndMinute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndMinute")]
    public int? EndMinute { get; set; }

    /// <summary>
    /// Number of times to execute tasks during schedule window (derived using RepeatInterval for Hourly and Minute schedule types)
    /// </summary>
    /// <value>Number of times to execute tasks during schedule window (derived using RepeatInterval for Hourly and Minute schedule types)</value>
    [DataMember(Name="Iterations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Iterations")]
    public int? Iterations { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScheduleInterval {\n");
      sb.Append("  StartHour: ").Append(StartHour).Append("\n");
      sb.Append("  StartMinute: ").Append(StartMinute).Append("\n");
      sb.Append("  EndHour: ").Append(EndHour).Append("\n");
      sb.Append("  EndMinute: ").Append(EndMinute).Append("\n");
      sb.Append("  Iterations: ").Append(Iterations).Append("\n");
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
