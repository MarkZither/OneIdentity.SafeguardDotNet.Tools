using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an action taken to a access request
  /// </summary>
  [DataContract]
  public class AccessRequestWorkflowAction {
    /// <summary>
    /// Gets or Sets ActionType
    /// </summary>
    [DataMember(Name="ActionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ActionType")]
    public AccessRequestStateAction ActionType { get; set; }

    /// <summary>
    /// Optional information about the action taken
    /// </summary>
    /// <value>Optional information about the action taken</value>
    [DataMember(Name="Comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Gets or Sets NewState
    /// </summary>
    [DataMember(Name="NewState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NewState")]
    public AccessRequestState NewState { get; set; }

    /// <summary>
    /// The UTC Date/Time the action took place
    /// </summary>
    /// <value>The UTC Date/Time the action took place</value>
    [DataMember(Name="OccurredOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OccurredOn")]
    public DateTime? OccurredOn { get; set; }

    /// <summary>
    /// Gets or Sets OldState
    /// </summary>
    [DataMember(Name="OldState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OldState")]
    public AccessRequestState OldState { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="User", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "User")]
    public Identity User { get; set; }

    /// <summary>
    /// Identifier for the session that was initialized (if applicable)
    /// </summary>
    /// <value>Identifier for the session that was initialized (if applicable)</value>
    [DataMember(Name="SessionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionId")]
    public int? SessionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessRequestWorkflowAction {\n");
      sb.Append("  ActionType: ").Append(ActionType).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  NewState: ").Append(NewState).Append("\n");
      sb.Append("  OccurredOn: ").Append(OccurredOn).Append("\n");
      sb.Append("  OldState: ").Append(OldState).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  SessionId: ").Append(SessionId).Append("\n");
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
