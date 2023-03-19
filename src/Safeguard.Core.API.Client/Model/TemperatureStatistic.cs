using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class TemperatureStatistic {
    /// <summary>
    /// Gets or Sets TemperatureCelsius
    /// </summary>
    [DataMember(Name="TemperatureCelsius", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TemperatureCelsius")]
    public float? TemperatureCelsius { get; set; }

    /// <summary>
    /// Gets or Sets TemperatureFahrenheit
    /// </summary>
    [DataMember(Name="TemperatureFahrenheit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TemperatureFahrenheit")]
    public float? TemperatureFahrenheit { get; set; }

    /// <summary>
    /// Gets or Sets TemperatureKelvin
    /// </summary>
    [DataMember(Name="TemperatureKelvin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TemperatureKelvin")]
    public float? TemperatureKelvin { get; set; }

    /// <summary>
    /// Gets or Sets ZoneName
    /// </summary>
    [DataMember(Name="ZoneName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ZoneName")]
    public string ZoneName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TemperatureStatistic {\n");
      sb.Append("  TemperatureCelsius: ").Append(TemperatureCelsius).Append("\n");
      sb.Append("  TemperatureFahrenheit: ").Append(TemperatureFahrenheit).Append("\n");
      sb.Append("  TemperatureKelvin: ").Append(TemperatureKelvin).Append("\n");
      sb.Append("  ZoneName: ").Append(ZoneName).Append("\n");
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
