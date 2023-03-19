using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// History SSH key assigned to an account
  /// </summary>
  [DataContract]
  public class AccountSshKeyHistory {
    /// <summary>
    /// When the password came into effect
    /// </summary>
    /// <value>When the password came into effect</value>
    [DataMember(Name="TimeStarted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeStarted")]
    public DateTime? TimeStarted { get; set; }

    /// <summary>
    /// When the passowrd expired or was changed
    /// </summary>
    /// <value>When the passowrd expired or was changed</value>
    [DataMember(Name="TimeEnded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeEnded")]
    public DateTime? TimeEnded { get; set; }

    /// <summary>
    /// Gets or Sets SshKey
    /// </summary>
    [DataMember(Name="SshKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKey")]
    public AccountSshKey SshKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountSshKeyHistory {\n");
      sb.Append("  TimeStarted: ").Append(TimeStarted).Append("\n");
      sb.Append("  TimeEnded: ").Append(TimeEnded).Append("\n");
      sb.Append("  SshKey: ").Append(SshKey).Append("\n");
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
