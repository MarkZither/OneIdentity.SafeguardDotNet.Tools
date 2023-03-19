using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Information about session recording
  /// </summary>
  [DataContract]
  public class SessionRecordingProperties {
    /// <summary>
    /// Whether session was recorded
    /// </summary>
    /// <value>Whether session was recorded</value>
    [DataMember(Name="HasRecording", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasRecording")]
    public bool? HasRecording { get; set; }

    /// <summary>
    /// ID of the SPS appliance server where the session recording resides
    /// </summary>
    /// <value>ID of the SPS appliance server where the session recording resides</value>
    [DataMember(Name="SpsApplianceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpsApplianceId")]
    public int? SpsApplianceId { get; set; }

    /// <summary>
    /// Id of the recording
    /// </summary>
    /// <value>Id of the recording</value>
    [DataMember(Name="RecordingId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecordingId")]
    public string RecordingId { get; set; }

    /// <summary>
    /// Session result
    /// </summary>
    /// <value>Session result</value>
    [DataMember(Name="SessionResult", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionResult")]
    public string SessionResult { get; set; }

    /// <summary>
    /// Download URL of the recording
    /// </summary>
    /// <value>Download URL of the recording</value>
    [DataMember(Name="DownloadUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DownloadUrl")]
    public string DownloadUrl { get; set; }

    /// <summary>
    /// Is the session recording currently live
    /// </summary>
    /// <value>Is the session recording currently live</value>
    [DataMember(Name="IsLive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsLive")]
    public bool? IsLive { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SessionRecordingProperties {\n");
      sb.Append("  HasRecording: ").Append(HasRecording).Append("\n");
      sb.Append("  SpsApplianceId: ").Append(SpsApplianceId).Append("\n");
      sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
      sb.Append("  SessionResult: ").Append(SessionResult).Append("\n");
      sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
      sb.Append("  IsLive: ").Append(IsLive).Append("\n");
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
