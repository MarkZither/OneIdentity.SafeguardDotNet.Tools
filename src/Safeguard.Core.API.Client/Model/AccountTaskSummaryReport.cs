using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A summary report of account tasks
  /// </summary>
  [DataContract]
  public class AccountTaskSummaryReport {
    /// <summary>
    /// Number of password check failures
    /// </summary>
    /// <value>Number of password check failures</value>
    [DataMember(Name="PasswordCheckFailures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordCheckFailures")]
    public int? PasswordCheckFailures { get; set; }

    /// <summary>
    /// Number of password change failures
    /// </summary>
    /// <value>Number of password change failures</value>
    [DataMember(Name="PasswordChangeFailures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordChangeFailures")]
    public int? PasswordChangeFailures { get; set; }

    /// <summary>
    /// Number of password check successes
    /// </summary>
    /// <value>Number of password check successes</value>
    [DataMember(Name="PasswordCheckSuccesses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordCheckSuccesses")]
    public int? PasswordCheckSuccesses { get; set; }

    /// <summary>
    /// Number of password change successes
    /// </summary>
    /// <value>Number of password change successes</value>
    [DataMember(Name="PasswordChangeSuccesses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordChangeSuccesses")]
    public int? PasswordChangeSuccesses { get; set; }

    /// <summary>
    /// Number of SSH key check failures
    /// </summary>
    /// <value>Number of SSH key check failures</value>
    [DataMember(Name="SshKeyCheckFailures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyCheckFailures")]
    public int? SshKeyCheckFailures { get; set; }

    /// <summary>
    /// Number of SSH key change failures
    /// </summary>
    /// <value>Number of SSH key change failures</value>
    [DataMember(Name="SshKeyChangeFailures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyChangeFailures")]
    public int? SshKeyChangeFailures { get; set; }

    /// <summary>
    /// Number of SSH key check successes
    /// </summary>
    /// <value>Number of SSH key check successes</value>
    [DataMember(Name="SshKeyCheckSuccesses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyCheckSuccesses")]
    public int? SshKeyCheckSuccesses { get; set; }

    /// <summary>
    /// Number of SSH key change successes
    /// </summary>
    /// <value>Number of SSH key change successes</value>
    [DataMember(Name="SshKeyChangeSuccesses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyChangeSuccesses")]
    public int? SshKeyChangeSuccesses { get; set; }

    /// <summary>
    /// Number of SSH key discovery failures
    /// </summary>
    /// <value>Number of SSH key discovery failures</value>
    [DataMember(Name="SshKeyDiscoveryFailures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyDiscoveryFailures")]
    public int? SshKeyDiscoveryFailures { get; set; }

    /// <summary>
    /// Number of SSH key revoke failures
    /// </summary>
    /// <value>Number of SSH key revoke failures</value>
    [DataMember(Name="SshKeyRevokeFailures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyRevokeFailures")]
    public int? SshKeyRevokeFailures { get; set; }

    /// <summary>
    /// Number of SSH key discovery successes
    /// </summary>
    /// <value>Number of SSH key discovery successes</value>
    [DataMember(Name="SshKeyDiscoverySuccesses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyDiscoverySuccesses")]
    public int? SshKeyDiscoverySuccesses { get; set; }

    /// <summary>
    /// Number of SSH key revoke successes
    /// </summary>
    /// <value>Number of SSH key revoke successes</value>
    [DataMember(Name="SshKeyRevokeSuccesses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyRevokeSuccesses")]
    public int? SshKeyRevokeSuccesses { get; set; }

    /// <summary>
    /// Number of suspend account failures
    /// </summary>
    /// <value>Number of suspend account failures</value>
    [DataMember(Name="SuspendAccountFailures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SuspendAccountFailures")]
    public int? SuspendAccountFailures { get; set; }

    /// <summary>
    /// Number of restore account failures
    /// </summary>
    /// <value>Number of restore account failures</value>
    [DataMember(Name="RestoreAccountFailures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RestoreAccountFailures")]
    public int? RestoreAccountFailures { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountTaskSummaryReport {\n");
      sb.Append("  PasswordCheckFailures: ").Append(PasswordCheckFailures).Append("\n");
      sb.Append("  PasswordChangeFailures: ").Append(PasswordChangeFailures).Append("\n");
      sb.Append("  PasswordCheckSuccesses: ").Append(PasswordCheckSuccesses).Append("\n");
      sb.Append("  PasswordChangeSuccesses: ").Append(PasswordChangeSuccesses).Append("\n");
      sb.Append("  SshKeyCheckFailures: ").Append(SshKeyCheckFailures).Append("\n");
      sb.Append("  SshKeyChangeFailures: ").Append(SshKeyChangeFailures).Append("\n");
      sb.Append("  SshKeyCheckSuccesses: ").Append(SshKeyCheckSuccesses).Append("\n");
      sb.Append("  SshKeyChangeSuccesses: ").Append(SshKeyChangeSuccesses).Append("\n");
      sb.Append("  SshKeyDiscoveryFailures: ").Append(SshKeyDiscoveryFailures).Append("\n");
      sb.Append("  SshKeyRevokeFailures: ").Append(SshKeyRevokeFailures).Append("\n");
      sb.Append("  SshKeyDiscoverySuccesses: ").Append(SshKeyDiscoverySuccesses).Append("\n");
      sb.Append("  SshKeyRevokeSuccesses: ").Append(SshKeyRevokeSuccesses).Append("\n");
      sb.Append("  SuspendAccountFailures: ").Append(SuspendAccountFailures).Append("\n");
      sb.Append("  RestoreAccountFailures: ").Append(RestoreAccountFailures).Append("\n");
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
