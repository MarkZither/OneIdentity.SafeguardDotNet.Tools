using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Provides parameters for personal account password generation.
  /// </summary>
  [DataContract]
  public class PersonalAccountPasswordRule {
    /// <summary>
    /// Length of the generated password
    /// </summary>
    /// <value>Length of the generated password</value>
    [DataMember(Name="Length", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Length")]
    public int? Length { get; set; }

    /// <summary>
    /// Password should include numbers
    /// </summary>
    /// <value>Password should include numbers</value>
    [DataMember(Name="IncludeNumbers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IncludeNumbers")]
    public bool? IncludeNumbers { get; set; }

    /// <summary>
    /// Password should include symbols
    /// </summary>
    /// <value>Password should include symbols</value>
    [DataMember(Name="IncludeSymbols", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IncludeSymbols")]
    public bool? IncludeSymbols { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PersonalAccountPasswordRule {\n");
      sb.Append("  Length: ").Append(Length).Append("\n");
      sb.Append("  IncludeNumbers: ").Append(IncludeNumbers).Append("\n");
      sb.Append("  IncludeSymbols: ").Append(IncludeSymbols).Append("\n");
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
