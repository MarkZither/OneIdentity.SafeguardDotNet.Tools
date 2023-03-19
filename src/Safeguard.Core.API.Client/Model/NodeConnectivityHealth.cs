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
  public class NodeConnectivityHealth {
    /// <summary>
    /// Gets or Sets ApplianceId
    /// </summary>
    [DataMember(Name="ApplianceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceId")]
    public string ApplianceId { get; set; }

    /// <summary>
    /// Gets or Sets AverageLatency
    /// </summary>
    [DataMember(Name="AverageLatency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AverageLatency")]
    public TimeInterval AverageLatency { get; set; }

    /// <summary>
    /// Gets or Sets IsReachable
    /// </summary>
    [DataMember(Name="IsReachable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsReachable")]
    public bool? IsReachable { get; set; }

    /// <summary>
    /// Gets or Sets MaxLatency
    /// </summary>
    [DataMember(Name="MaxLatency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxLatency")]
    public TimeInterval MaxLatency { get; set; }

    /// <summary>
    /// Gets or Sets MinLatency
    /// </summary>
    [DataMember(Name="MinLatency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinLatency")]
    public TimeInterval MinLatency { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeConnectivityHealth {\n");
      sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
      sb.Append("  AverageLatency: ").Append(AverageLatency).Append("\n");
      sb.Append("  IsReachable: ").Append(IsReachable).Append("\n");
      sb.Append("  MaxLatency: ").Append(MaxLatency).Append("\n");
      sb.Append("  MinLatency: ").Append(MinLatency).Append("\n");
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
