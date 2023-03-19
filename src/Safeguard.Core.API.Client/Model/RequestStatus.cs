using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class RequestStatus {
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="State", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "State")]
    public RequestState State { get; set; }

    /// <summary>
    /// How much of work associated with the request is complete (Read-only)
    /// </summary>
    /// <value>How much of work associated with the request is complete (Read-only)</value>
    [DataMember(Name="PercentComplete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PercentComplete")]
    public int? PercentComplete { get; set; }

    /// <summary>
    /// Is the request cancellable? (Read-only). The value of this flag is a suggestion only.
    /// </summary>
    /// <value>Is the request cancellable? (Read-only). The value of this flag is a suggestion only.</value>
    [DataMember(Name="Cancellable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Cancellable")]
    public bool? Cancellable { get; set; }

    /// <summary>
    /// When was this request accepted (Read-only)
    /// </summary>
    /// <value>When was this request accepted (Read-only)</value>
    [DataMember(Name="AcceptedTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AcceptedTime")]
    public DateTime? AcceptedTime { get; set; }

    /// <summary>
    /// Duration that request was being validated for acceptance (Read-only)
    /// </summary>
    /// <value>Duration that request was being validated for acceptance (Read-only)</value>
    [DataMember(Name="AcceptanceDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AcceptanceDuration")]
    public string AcceptanceDuration { get; set; }

    /// <summary>
    /// When was the request work started (Read-only)
    /// </summary>
    /// <value>When was the request work started (Read-only)</value>
    [DataMember(Name="StartTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartTime")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// Duration that request was queued (Read-only)
    /// </summary>
    /// <value>Duration that request was queued (Read-only)</value>
    [DataMember(Name="QueuedDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueuedDuration")]
    public string QueuedDuration { get; set; }

    /// <summary>
    /// When was the request completed (Read-only)
    /// </summary>
    /// <value>When was the request completed (Read-only)</value>
    [DataMember(Name="EndTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndTime")]
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Duration that request was running (Read-only)
    /// </summary>
    /// <value>Duration that request was running (Read-only)</value>
    [DataMember(Name="RunningDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RunningDuration")]
    public string RunningDuration { get; set; }

    /// <summary>
    /// Total duration that request was active (Read-only)
    /// </summary>
    /// <value>Total duration that request was active (Read-only)</value>
    [DataMember(Name="TotalDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalDuration")]
    public string TotalDuration { get; set; }

    /// <summary>
    /// Last message associated with the request (Read-only)
    /// </summary>
    /// <value>Last message associated with the request (Read-only)</value>
    [DataMember(Name="Message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Message")]
    public string Message { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RequestStatus {\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
      sb.Append("  Cancellable: ").Append(Cancellable).Append("\n");
      sb.Append("  AcceptedTime: ").Append(AcceptedTime).Append("\n");
      sb.Append("  AcceptanceDuration: ").Append(AcceptanceDuration).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  QueuedDuration: ").Append(QueuedDuration).Append("\n");
      sb.Append("  EndTime: ").Append(EndTime).Append("\n");
      sb.Append("  RunningDuration: ").Append(RunningDuration).Append("\n");
      sb.Append("  TotalDuration: ").Append(TotalDuration).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
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
