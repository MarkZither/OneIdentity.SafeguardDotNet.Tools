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
  public class LicenseSummary {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public LicenseType Type { get; set; }

    /// <summary>
    /// Gets or Sets Module
    /// </summary>
    [DataMember(Name="Module", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Module")]
    public LicensableModule Module { get; set; }

    /// <summary>
    /// Is the license currently valid. This will be false if the license  has expired.
    /// </summary>
    /// <value>Is the license currently valid. This will be false if the license  has expired.</value>
    [DataMember(Name="IsValid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsValid")]
    public bool? IsValid { get; set; }

    /// <summary>
    /// The date that this license expires, or null  if it is perpetual.
    /// </summary>
    /// <value>The date that this license expires, or null  if it is perpetual.</value>
    [DataMember(Name="Expires", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Expires")]
    public DateTime? Expires { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LicenseSummary {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Module: ").Append(Module).Append("\n");
      sb.Append("  IsValid: ").Append(IsValid).Append("\n");
      sb.Append("  Expires: ").Append(Expires).Append("\n");
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
