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
  public class SshKeySyncAccountTaskProperties {
    /// <summary>
    /// The date/time of the last SshKey change (Read-only)
    /// </summary>
    /// <value>The date/time of the last SshKey change (Read-only)</value>
    [DataMember(Name="LastSshKeyChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSshKeyChangeDate")]
    public DateTime? LastSshKeyChangeDate { get; set; }

    /// <summary>
    /// The date/time of the last successful SshKey change (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful SshKey change (Read-only)</value>
    [DataMember(Name="LastSuccessSshKeyChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessSshKeyChangeDate")]
    public DateTime? LastSuccessSshKeyChangeDate { get; set; }

    /// <summary>
    /// The date/time of the last failed SshKey change (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed SshKey change (Read-only)</value>
    [DataMember(Name="LastFailureSshKeyChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureSshKeyChangeDate")]
    public DateTime? LastFailureSshKeyChangeDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last SshKey change (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last SshKey change (Read-only)</value>
    [DataMember(Name="LastSshKeyChangeTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSshKeyChangeTaskId")]
    public string LastSshKeyChangeTaskId { get; set; }

    /// <summary>
    /// Number of subsequent failed SshKey change attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed SshKey change attempts since last success (Read-only)</value>
    [DataMember(Name="FailedSshKeyChangeAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedSshKeyChangeAttempts")]
    public int? FailedSshKeyChangeAttempts { get; set; }

    /// <summary>
    /// The date/time of the next SshKey change, if this account is enabled for automatic SshKey management (Read-only)
    /// </summary>
    /// <value>The date/time of the next SshKey change, if this account is enabled for automatic SshKey management (Read-only)</value>
    [DataMember(Name="NextSshKeyChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextSshKeyChangeDate")]
    public DateTime? NextSshKeyChangeDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SshKeySyncAccountTaskProperties {\n");
      sb.Append("  LastSshKeyChangeDate: ").Append(LastSshKeyChangeDate).Append("\n");
      sb.Append("  LastSuccessSshKeyChangeDate: ").Append(LastSuccessSshKeyChangeDate).Append("\n");
      sb.Append("  LastFailureSshKeyChangeDate: ").Append(LastFailureSshKeyChangeDate).Append("\n");
      sb.Append("  LastSshKeyChangeTaskId: ").Append(LastSshKeyChangeTaskId).Append("\n");
      sb.Append("  FailedSshKeyChangeAttempts: ").Append(FailedSshKeyChangeAttempts).Append("\n");
      sb.Append("  NextSshKeyChangeDate: ").Append(NextSshKeyChangeDate).Append("\n");
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
