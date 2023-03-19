using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Information about the platform task execution (Read-only)
  /// </summary>
  [DataContract]
  public class PlatformTaskInformation {
    /// <summary>
    /// Gets or Sets TaskName
    /// </summary>
    [DataMember(Name="TaskName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaskName")]
    public TaskNames TaskName { get; set; }

    /// <summary>
    /// The date/time of the last attempt (Read-only)
    /// </summary>
    /// <value>The date/time of the last attempt (Read-only)</value>
    [DataMember(Name="LastTaskDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastTaskDate")]
    public DateTime? LastTaskDate { get; set; }

    /// <summary>
    /// The date/time of the last successful attempt (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful attempt (Read-only)</value>
    [DataMember(Name="LastSuccessTaskDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessTaskDate")]
    public DateTime? LastSuccessTaskDate { get; set; }

    /// <summary>
    /// The date/time of the last failed attempt (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed attempt (Read-only)</value>
    [DataMember(Name="LastFailureTaskDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureTaskDate")]
    public DateTime? LastFailureTaskDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last attempt (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last attempt (Read-only)</value>
    [DataMember(Name="LastTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastTaskId")]
    public string LastTaskId { get; set; }

    /// <summary>
    /// Number of subsequent failed attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed attempts since last success (Read-only)</value>
    [DataMember(Name="FailedTaskAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedTaskAttempts")]
    public int? FailedTaskAttempts { get; set; }

    /// <summary>
    /// The date/time of the next attempt, if this account is enabled for automatic password management (Read-only)
    /// </summary>
    /// <value>The date/time of the next attempt, if this account is enabled for automatic password management (Read-only)</value>
    [DataMember(Name="NextTaskDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextTaskDate")]
    public DateTime? NextTaskDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PlatformTaskInformation {\n");
      sb.Append("  TaskName: ").Append(TaskName).Append("\n");
      sb.Append("  LastTaskDate: ").Append(LastTaskDate).Append("\n");
      sb.Append("  LastSuccessTaskDate: ").Append(LastSuccessTaskDate).Append("\n");
      sb.Append("  LastFailureTaskDate: ").Append(LastFailureTaskDate).Append("\n");
      sb.Append("  LastTaskId: ").Append(LastTaskId).Append("\n");
      sb.Append("  FailedTaskAttempts: ").Append(FailedTaskAttempts).Append("\n");
      sb.Append("  NextTaskDate: ").Append(NextTaskDate).Append("\n");
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
