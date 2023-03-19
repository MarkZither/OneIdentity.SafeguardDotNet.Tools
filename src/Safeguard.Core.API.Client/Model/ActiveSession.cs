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
  public class ActiveSession {
    /// <summary>
    /// Appliance this session was run on
    /// </summary>
    /// <value>Appliance this session was run on</value>
    [DataMember(Name="ApplianceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceId")]
    public string ApplianceId { get; set; }

    /// <summary>
    /// Appliance this session was run on
    /// </summary>
    /// <value>Appliance this session was run on</value>
    [DataMember(Name="ApplianceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceName")]
    public string ApplianceName { get; set; }

    /// <summary>
    /// Qualified ID of the access request
    /// </summary>
    /// <value>Qualified ID of the access request</value>
    [DataMember(Name="AccessRequestId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessRequestId")]
    public string AccessRequestId { get; set; }

    /// <summary>
    /// Gets or Sets AccessRequestType
    /// </summary>
    [DataMember(Name="AccessRequestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessRequestType")]
    public AccessRequestType AccessRequestType { get; set; }

    /// <summary>
    /// Database ID of the asset to request access for
    /// </summary>
    /// <value>Database ID of the asset to request access for</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Name of the asset to request access for
    /// </summary>
    /// <value>Name of the asset to request access for</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Display name of the user that made the access request
    /// </summary>
    /// <value>Display name of the user that made the access request</value>
    [DataMember(Name="RequesterDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterDisplayName")]
    public string RequesterDisplayName { get; set; }

    /// <summary>
    /// Username of the user that made the access request
    /// </summary>
    /// <value>Username of the user that made the access request</value>
    [DataMember(Name="RequesterUsername", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterUsername")]
    public string RequesterUsername { get; set; }

    /// <summary>
    /// Email address of the user that made the access request
    /// </summary>
    /// <value>Email address of the user that made the access request</value>
    [DataMember(Name="RequesterEmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterEmailAddress")]
    public string RequesterEmailAddress { get; set; }

    /// <summary>
    /// Database ID of the user that made the access request
    /// </summary>
    /// <value>Database ID of the user that made the access request</value>
    [DataMember(Name="RequesterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterId")]
    public int? RequesterId { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActiveSession {\n");
      sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
      sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
      sb.Append("  AccessRequestId: ").Append(AccessRequestId).Append("\n");
      sb.Append("  AccessRequestType: ").Append(AccessRequestType).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  RequesterDisplayName: ").Append(RequesterDisplayName).Append("\n");
      sb.Append("  RequesterUsername: ").Append(RequesterUsername).Append("\n");
      sb.Append("  RequesterEmailAddress: ").Append(RequesterEmailAddress).Append("\n");
      sb.Append("  RequesterId: ").Append(RequesterId).Append("\n");
      sb.Append("  SessionId: ").Append(SessionId).Append("\n");
      sb.Append("  InitializedDate: ").Append(InitializedDate).Append("\n");
      sb.Append("  ConnectedDate: ").Append(ConnectedDate).Append("\n");
      sb.Append("  TerminatedDate: ").Append(TerminatedDate).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  HasRecording: ").Append(HasRecording).Append("\n");
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
