using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a change made to an object
  /// </summary>
  [DataContract]
  public class PropertyChange {
    /// <summary>
    /// Display name of the property that changed
    /// </summary>
    /// <value>Display name of the property that changed</value>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The type name of the property that changed
    /// </summary>
    /// <value>The type name of the property that changed</value>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }

    /// <summary>
    /// The old value of the property that changed
    /// </summary>
    /// <value>The old value of the property that changed</value>
    [DataMember(Name="OldValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OldValue")]
    public string OldValue { get; set; }

    /// <summary>
    /// The new value of the property that changed
    /// </summary>
    /// <value>The new value of the property that changed</value>
    [DataMember(Name="NewValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NewValue")]
    public string NewValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PropertyChange {\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  OldValue: ").Append(OldValue).Append("\n");
      sb.Append("  NewValue: ").Append(NewValue).Append("\n");
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
