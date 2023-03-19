using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A single entry from a task log
  /// </summary>
  [DataContract]
  public class Entry {
    /// <summary>
    /// The date and time the entry was recorded, UTC
    /// </summary>
    /// <value>The date and time the entry was recorded, UTC</value>
    [DataMember(Name="Recorded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Recorded")]
    public DateTime? Recorded { get; set; }

    /// <summary>
    /// Gets or Sets Level
    /// </summary>
    [DataMember(Name="Level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Level")]
    public EntryLevel Level { get; set; }

    /// <summary>
    /// The recorded message
    /// </summary>
    /// <value>The recorded message</value>
    [DataMember(Name="Event", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Event")]
    public string _Event { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Entry {\n");
      sb.Append("  Recorded: ").Append(Recorded).Append("\n");
      sb.Append("  Level: ").Append(Level).Append("\n");
      sb.Append("  _Event: ").Append(_Event).Append("\n");
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
