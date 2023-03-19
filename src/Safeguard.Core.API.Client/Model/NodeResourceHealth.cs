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
  public class NodeResourceHealth {
    /// <summary>
    /// Gets or Sets DiskFreeBytes
    /// </summary>
    [DataMember(Name="DiskFreeBytes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiskFreeBytes")]
    public long? DiskFreeBytes { get; set; }

    /// <summary>
    /// Gets or Sets DiskPercentFree
    /// </summary>
    [DataMember(Name="DiskPercentFree", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiskPercentFree")]
    public float? DiskPercentFree { get; set; }

    /// <summary>
    /// Gets or Sets DiskTotalBytes
    /// </summary>
    [DataMember(Name="DiskTotalBytes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiskTotalBytes")]
    public long? DiskTotalBytes { get; set; }

    /// <summary>
    /// Gets or Sets MemoryFreeBytes
    /// </summary>
    [DataMember(Name="MemoryFreeBytes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MemoryFreeBytes")]
    public long? MemoryFreeBytes { get; set; }

    /// <summary>
    /// Gets or Sets MemoryPercentFree
    /// </summary>
    [DataMember(Name="MemoryPercentFree", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MemoryPercentFree")]
    public float? MemoryPercentFree { get; set; }

    /// <summary>
    /// Gets or Sets MemoryTotalBytes
    /// </summary>
    [DataMember(Name="MemoryTotalBytes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MemoryTotalBytes")]
    public long? MemoryTotalBytes { get; set; }

    /// <summary>
    /// Gets or Sets ProcessorCount
    /// </summary>
    [DataMember(Name="ProcessorCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProcessorCount")]
    public int? ProcessorCount { get; set; }

    /// <summary>
    /// Gets or Sets ProcessorPercentUsed
    /// </summary>
    [DataMember(Name="ProcessorPercentUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProcessorPercentUsed")]
    public float? ProcessorPercentUsed { get; set; }

    /// <summary>
    /// Gets or Sets Temperatures
    /// </summary>
    [DataMember(Name="Temperatures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Temperatures")]
    public List<TemperatureStatistic> Temperatures { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeResourceHealth {\n");
      sb.Append("  DiskFreeBytes: ").Append(DiskFreeBytes).Append("\n");
      sb.Append("  DiskPercentFree: ").Append(DiskPercentFree).Append("\n");
      sb.Append("  DiskTotalBytes: ").Append(DiskTotalBytes).Append("\n");
      sb.Append("  MemoryFreeBytes: ").Append(MemoryFreeBytes).Append("\n");
      sb.Append("  MemoryPercentFree: ").Append(MemoryPercentFree).Append("\n");
      sb.Append("  MemoryTotalBytes: ").Append(MemoryTotalBytes).Append("\n");
      sb.Append("  ProcessorCount: ").Append(ProcessorCount).Append("\n");
      sb.Append("  ProcessorPercentUsed: ").Append(ProcessorPercentUsed).Append("\n");
      sb.Append("  Temperatures: ").Append(Temperatures).Append("\n");
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
