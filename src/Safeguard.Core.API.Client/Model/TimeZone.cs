using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents the read-only property values of a time zone.
  /// </summary>
  [DataContract]
  public class TimeZone {
    /// <summary>
    /// The time zone's unique id. (Read-only)
    /// </summary>
    /// <value>The time zone's unique id. (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// The time zone's display name. (Read-only)
    /// </summary>
    /// <value>The time zone's display name. (Read-only)</value>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// A standard name of the time zone. (Read-only)
    /// </summary>
    /// <value>A standard name of the time zone. (Read-only)</value>
    [DataMember(Name="StandardName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StandardName")]
    public string StandardName { get; set; }

    /// <summary>
    /// A daylight name of the time zone. (Read-only)
    /// </summary>
    /// <value>A daylight name of the time zone. (Read-only)</value>
    [DataMember(Name="DaylightName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DaylightName")]
    public string DaylightName { get; set; }

    /// <summary>
    /// The IANA name of the time zone. (Read-only)
    /// </summary>
    /// <value>The IANA name of the time zone. (Read-only)</value>
    [DataMember(Name="IanaName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IanaName")]
    public string IanaName { get; set; }

    /// <summary>
    /// The time zone's offset from UTC (in minutes). May be a negative number or zero. (Read-only)
    /// </summary>
    /// <value>The time zone's offset from UTC (in minutes). May be a negative number or zero. (Read-only)</value>
    [DataMember(Name="UtcOffset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UtcOffset")]
    public int? UtcOffset { get; set; }

    /// <summary>
    /// A flag indicating whether or not the time zone observes Daylight Saving Time. (Read-only)
    /// </summary>
    /// <value>A flag indicating whether or not the time zone observes Daylight Saving Time. (Read-only)</value>
    [DataMember(Name="AllowsDst", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowsDst")]
    public bool? AllowsDst { get; set; }

    /// <summary>
    /// A flag indicating whether or not the time zone is obsolete. Obsolete time zones may still be referenced  by existing entities but should not be used when creating new entities. (Read-only)
    /// </summary>
    /// <value>A flag indicating whether or not the time zone is obsolete. Obsolete time zones may still be referenced  by existing entities but should not be used when creating new entities. (Read-only)</value>
    [DataMember(Name="Obsolete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Obsolete")]
    public bool? Obsolete { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TimeZone {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  StandardName: ").Append(StandardName).Append("\n");
      sb.Append("  DaylightName: ").Append(DaylightName).Append("\n");
      sb.Append("  IanaName: ").Append(IanaName).Append("\n");
      sb.Append("  UtcOffset: ").Append(UtcOffset).Append("\n");
      sb.Append("  AllowsDst: ").Append(AllowsDst).Append("\n");
      sb.Append("  Obsolete: ").Append(Obsolete).Append("\n");
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
