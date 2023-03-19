using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Resource for viewing the password history of an account
  /// </summary>
  [DataContract]
  public class AccountPassword {
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
    /// The password during this time period
    /// </summary>
    /// <value>The password during this time period</value>
    [DataMember(Name="Password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Password")]
    public string Password { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountPassword {\n");
      sb.Append("  TimeStarted: ").Append(TimeStarted).Append("\n");
      sb.Append("  TimeEnded: ").Append(TimeEnded).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
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
