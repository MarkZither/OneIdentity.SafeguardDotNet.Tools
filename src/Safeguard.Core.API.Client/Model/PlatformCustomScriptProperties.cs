using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Settings related to session access requests
  /// </summary>
  [DataContract]
  public class PlatformCustomScriptProperties {
    /// <summary>
    /// Whether a script has been uploaded for this custom platform (Read-only)
    /// </summary>
    /// <value>Whether a script has been uploaded for this custom platform (Read-only)</value>
    [DataMember(Name="HasScript", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasScript")]
    public bool? HasScript { get; set; }

    /// <summary>
    /// A list of parameters that should be provided to the custom platform script when invoked
    /// </summary>
    /// <value>A list of parameters that should be provided to the custom platform script when invoked</value>
    [DataMember(Name="Parameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Parameters")]
    public List<CustomScriptParameter> Parameters { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PlatformCustomScriptProperties {\n");
      sb.Append("  HasScript: ").Append(HasScript).Append("\n");
      sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
