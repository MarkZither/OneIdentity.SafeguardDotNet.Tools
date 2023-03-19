using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Information needed to change the current user password
  /// </summary>
  [DataContract]
  public class ChangePasswordParameters {
    /// <summary>
    /// The current password
    /// </summary>
    /// <value>The current password</value>
    [DataMember(Name="OldPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OldPassword")]
    public string OldPassword { get; set; }

    /// <summary>
    /// The password to set
    /// </summary>
    /// <value>The password to set</value>
    [DataMember(Name="NewPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NewPassword")]
    public string NewPassword { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChangePasswordParameters {\n");
      sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
      sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
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
