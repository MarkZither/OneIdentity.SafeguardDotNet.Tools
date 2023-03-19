using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a time interval
  /// </summary>
  [DataContract]
  public class TimeInterval {
    /// <summary>
    /// The days component of this time interval
    /// </summary>
    /// <value>The days component of this time interval</value>
    [DataMember(Name="Days", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Days")]
    public int? Days { get; set; }

    /// <summary>
    /// The hours component of this time interval
    /// </summary>
    /// <value>The hours component of this time interval</value>
    [DataMember(Name="Hours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Hours")]
    public int? Hours { get; set; }

    /// <summary>
    /// The milliseconds component of this time interval
    /// </summary>
    /// <value>The milliseconds component of this time interval</value>
    [DataMember(Name="Milliseconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Milliseconds")]
    public int? Milliseconds { get; set; }

    /// <summary>
    /// The minutes component of this time interval
    /// </summary>
    /// <value>The minutes component of this time interval</value>
    [DataMember(Name="Minutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Minutes")]
    public int? Minutes { get; set; }

    /// <summary>
    /// The seconds component of this time interval
    /// </summary>
    /// <value>The seconds component of this time interval</value>
    [DataMember(Name="Seconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Seconds")]
    public int? Seconds { get; set; }

    /// <summary>
    /// The value of this time interval in whole and fractional milliseconds
    /// </summary>
    /// <value>The value of this time interval in whole and fractional milliseconds</value>
    [DataMember(Name="TotalMilliseconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalMilliseconds")]
    public double? TotalMilliseconds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TimeInterval {\n");
      sb.Append("  Days: ").Append(Days).Append("\n");
      sb.Append("  Hours: ").Append(Hours).Append("\n");
      sb.Append("  Milliseconds: ").Append(Milliseconds).Append("\n");
      sb.Append("  Minutes: ").Append(Minutes).Append("\n");
      sb.Append("  Seconds: ").Append(Seconds).Append("\n");
      sb.Append("  TotalMilliseconds: ").Append(TotalMilliseconds).Append("\n");
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
