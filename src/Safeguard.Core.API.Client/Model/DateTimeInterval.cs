using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents two datetimes - a begin and an end. The interval includes the begin, and excludes the end.
  /// </summary>
  [DataContract]
  public class DateTimeInterval {
    /// <summary>
    /// The inclusive lower bound of the interval
    /// </summary>
    /// <value>The inclusive lower bound of the interval</value>
    [DataMember(Name="Begin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Begin")]
    public DateTime? Begin { get; set; }

    /// <summary>
    /// The exclusive upper bound of the interval
    /// </summary>
    /// <value>The exclusive upper bound of the interval</value>
    [DataMember(Name="End", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "End")]
    public DateTime? End { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DateTimeInterval {\n");
      sb.Append("  Begin: ").Append(Begin).Append("\n");
      sb.Append("  End: ").Append(End).Append("\n");
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
