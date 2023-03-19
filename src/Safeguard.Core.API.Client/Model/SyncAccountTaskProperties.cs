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
  public class SyncAccountTaskProperties {
    /// <summary>
    /// The date/time of the last password change (Read-only)
    /// </summary>
    /// <value>The date/time of the last password change (Read-only)</value>
    [DataMember(Name="LastPasswordChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastPasswordChangeDate")]
    public DateTime? LastPasswordChangeDate { get; set; }

    /// <summary>
    /// The date/time of the last successful password change (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful password change (Read-only)</value>
    [DataMember(Name="LastSuccessPasswordChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessPasswordChangeDate")]
    public DateTime? LastSuccessPasswordChangeDate { get; set; }

    /// <summary>
    /// The date/time of the last failed password change (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed password change (Read-only)</value>
    [DataMember(Name="LastFailurePasswordChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailurePasswordChangeDate")]
    public DateTime? LastFailurePasswordChangeDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last password change (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last password change (Read-only)</value>
    [DataMember(Name="LastPasswordChangeTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastPasswordChangeTaskId")]
    public string LastPasswordChangeTaskId { get; set; }

    /// <summary>
    /// Number of subsequent failed password change attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed password change attempts since last success (Read-only)</value>
    [DataMember(Name="FailedPasswordChangeAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedPasswordChangeAttempts")]
    public int? FailedPasswordChangeAttempts { get; set; }

    /// <summary>
    /// The date/time of the next password change, if this account is enabled for automatic password management (Read-only)
    /// </summary>
    /// <value>The date/time of the next password change, if this account is enabled for automatic password management (Read-only)</value>
    [DataMember(Name="NextPasswordChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextPasswordChangeDate")]
    public DateTime? NextPasswordChangeDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SyncAccountTaskProperties {\n");
      sb.Append("  LastPasswordChangeDate: ").Append(LastPasswordChangeDate).Append("\n");
      sb.Append("  LastSuccessPasswordChangeDate: ").Append(LastSuccessPasswordChangeDate).Append("\n");
      sb.Append("  LastFailurePasswordChangeDate: ").Append(LastFailurePasswordChangeDate).Append("\n");
      sb.Append("  LastPasswordChangeTaskId: ").Append(LastPasswordChangeTaskId).Append("\n");
      sb.Append("  FailedPasswordChangeAttempts: ").Append(FailedPasswordChangeAttempts).Append("\n");
      sb.Append("  NextPasswordChangeDate: ").Append(NextPasswordChangeDate).Append("\n");
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
