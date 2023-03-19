using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Information about sessions initialized using this request
  /// </summary>
  [DataContract]
  public class AccessRequestSession {
    /// <summary>
    /// Unique ID of session for request
    /// </summary>
    /// <value>Unique ID of session for request</value>
    [DataMember(Name="SessionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionId")]
    public int? SessionId { get; set; }

    /// <summary>
    /// Date session was initialized
    /// </summary>
    /// <value>Date session was initialized</value>
    [DataMember(Name="InitializedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InitializedDate")]
    public DateTime? InitializedDate { get; set; }

    /// <summary>
    /// Date session connected to target asset
    /// </summary>
    /// <value>Date session connected to target asset</value>
    [DataMember(Name="ConnectedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConnectedDate")]
    public DateTime? ConnectedDate { get; set; }

    /// <summary>
    /// Date session was terminated
    /// </summary>
    /// <value>Date session was terminated</value>
    [DataMember(Name="TerminatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TerminatedDate")]
    public DateTime? TerminatedDate { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="State", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "State")]
    public SessionState State { get; set; }

    /// <summary>
    /// Whether session was recorded
    /// </summary>
    /// <value>Whether session was recorded</value>
    [DataMember(Name="HasRecording", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasRecording")]
    public bool? HasRecording { get; set; }

    /// <summary>
    /// Appliance ID session was run on
    /// </summary>
    /// <value>Appliance ID session was run on</value>
    [DataMember(Name="ApplianceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceId")]
    public string ApplianceId { get; set; }

    /// <summary>
    /// Appliance name session was run on
    /// </summary>
    /// <value>Appliance name session was run on</value>
    [DataMember(Name="ApplianceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceName")]
    public string ApplianceName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessRequestSession {\n");
      sb.Append("  SessionId: ").Append(SessionId).Append("\n");
      sb.Append("  InitializedDate: ").Append(InitializedDate).Append("\n");
      sb.Append("  ConnectedDate: ").Append(ConnectedDate).Append("\n");
      sb.Append("  TerminatedDate: ").Append(TerminatedDate).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  HasRecording: ").Append(HasRecording).Append("\n");
      sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
      sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
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
