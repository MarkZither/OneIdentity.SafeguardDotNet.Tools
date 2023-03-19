using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents platform task data for an appliance
  /// </summary>
  [DataContract]
  public class ApplianceLoadData {
    /// <summary>
    /// Gets or Sets RecordDate
    /// </summary>
    [DataMember(Name="RecordDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecordDate")]
    public DateTime? RecordDate { get; set; }

    /// <summary>
    /// The appliance ID the load data is for
    /// </summary>
    /// <value>The appliance ID the load data is for</value>
    [DataMember(Name="ApplianceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceId")]
    public string ApplianceId { get; set; }

    /// <summary>
    /// Gets or Sets ApplianceState
    /// </summary>
    [DataMember(Name="ApplianceState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceState")]
    public ApplianceState ApplianceState { get; set; }

    /// <summary>
    /// Score out of 100 of audit log database when status measurement was taken
    /// </summary>
    /// <value>Score out of 100 of audit log database when status measurement was taken</value>
    [DataMember(Name="AuditLogScore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuditLogScore")]
    public int? AuditLogScore { get; set; }

    /// <summary>
    /// Score out of 100 of VPN latency when status measurement was taken
    /// </summary>
    /// <value>Score out of 100 of VPN latency when status measurement was taken</value>
    [DataMember(Name="VpnLatencyScore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VpnLatencyScore")]
    public int? VpnLatencyScore { get; set; }

    /// <summary>
    /// When this record information is expired
    /// </summary>
    /// <value>When this record information is expired</value>
    [DataMember(Name="TimeExpires", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeExpires")]
    public DateTime? TimeExpires { get; set; }

    /// <summary>
    /// Fitness score for this appliance
    /// </summary>
    /// <value>Fitness score for this appliance</value>
    [DataMember(Name="Score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Score")]
    public double? Score { get; set; }

    /// <summary>
    /// The appliance name the load data is for
    /// </summary>
    /// <value>The appliance name the load data is for</value>
    [DataMember(Name="ApplianceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceName")]
    public string ApplianceName { get; set; }

    /// <summary>
    /// The maximum number of task threads allowed (see /service/appliance/Settings)
    /// </summary>
    /// <value>The maximum number of task threads allowed (see /service/appliance/Settings)</value>
    [DataMember(Name="MaxTaskThreads", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxTaskThreads")]
    public int? MaxTaskThreads { get; set; }

    /// <summary>
    /// Total number of threads in use. One thread per unique asset.
    /// </summary>
    /// <value>Total number of threads in use. One thread per unique asset.</value>
    [DataMember(Name="TaskThreads", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaskThreads")]
    public int? TaskThreads { get; set; }

    /// <summary>
    /// Number of tasks queued on this appliance
    /// </summary>
    /// <value>Number of tasks queued on this appliance</value>
    [DataMember(Name="QueuedTasks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueuedTasks")]
    public int? QueuedTasks { get; set; }

    /// <summary>
    /// IP address of the appliance
    /// </summary>
    /// <value>IP address of the appliance</value>
    [DataMember(Name="ApplianceIpAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceIpAddress")]
    public string ApplianceIpAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplianceLoadData {\n");
      sb.Append("  RecordDate: ").Append(RecordDate).Append("\n");
      sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
      sb.Append("  ApplianceState: ").Append(ApplianceState).Append("\n");
      sb.Append("  AuditLogScore: ").Append(AuditLogScore).Append("\n");
      sb.Append("  VpnLatencyScore: ").Append(VpnLatencyScore).Append("\n");
      sb.Append("  TimeExpires: ").Append(TimeExpires).Append("\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
      sb.Append("  MaxTaskThreads: ").Append(MaxTaskThreads).Append("\n");
      sb.Append("  TaskThreads: ").Append(TaskThreads).Append("\n");
      sb.Append("  QueuedTasks: ").Append(QueuedTasks).Append("\n");
      sb.Append("  ApplianceIpAddress: ").Append(ApplianceIpAddress).Append("\n");
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
