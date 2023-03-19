using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Configuration for data and audit log archive, purge and repair.
  /// </summary>
  [DataContract]
  public class AuditLogMaintenance {
    /// <summary>
    /// The timezone in which the schedule should run
    /// </summary>
    /// <value>The timezone in which the schedule should run</value>
    [DataMember(Name="TimeZoneId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeZoneId")]
    public string TimeZoneId { get; set; }

    /// <summary>
    /// The description of the timezone in which the schedule should run (Read-only)
    /// </summary>
    /// <value>The description of the timezone in which the schedule should run (Read-only)</value>
    [DataMember(Name="TimeZoneDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeZoneDisplayName")]
    public string TimeZoneDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets DayOfWeek
    /// </summary>
    [DataMember(Name="DayOfWeek", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DayOfWeek")]
    public DayOfWeek DayOfWeek { get; set; }

    /// <summary>
    /// The hour of the day that the schedule will run. Default is midnight.
    /// </summary>
    /// <value>The hour of the day that the schedule will run. Default is midnight.</value>
    [DataMember(Name="StartHour", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartHour")]
    public int? StartHour { get; set; }

    /// <summary>
    /// How long to retain audit logs before deletion. Minimum is 30 days. Default is 365 days.
    /// </summary>
    /// <value>How long to retain audit logs before deletion. Minimum is 30 days. Default is 365 days.</value>
    [DataMember(Name="DaysToRetainLogs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DaysToRetainLogs")]
    public int? DaysToRetainLogs { get; set; }

    /// <summary>
    /// Specify true if audit logs older than DaysToRetainLogs should be purged. Default is false.  Audit logs will only be archived before purge if an archive server is configured.
    /// </summary>
    /// <value>Specify true if audit logs older than DaysToRetainLogs should be purged. Default is false.  Audit logs will only be archived before purge if an archive server is configured.</value>
    [DataMember(Name="PurgeArchiveAuditLogs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PurgeArchiveAuditLogs")]
    public bool? PurgeArchiveAuditLogs { get; set; }

    /// <summary>
    /// Database ID of archive server. Must be configured to archive audit logs before purge.
    /// </summary>
    /// <value>Database ID of archive server. Must be configured to archive audit logs before purge.</value>
    [DataMember(Name="ArchiveServerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ArchiveServerId")]
    public int? ArchiveServerId { get; set; }

    /// <summary>
    /// Name of archive server (Read-only)
    /// </summary>
    /// <value>Name of archive server (Read-only)</value>
    [DataMember(Name="ArchiveServerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ArchiveServerName")]
    public string ArchiveServerName { get; set; }

    /// <summary>
    /// The next time retention is scheduled to run
    /// </summary>
    /// <value>The next time retention is scheduled to run</value>
    [DataMember(Name="NextScheduledMaintenance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextScheduledMaintenance")]
    public DateTime? NextScheduledMaintenance { get; set; }

    /// <summary>
    /// The last time retention was run
    /// </summary>
    /// <value>The last time retention was run</value>
    [DataMember(Name="LastScheduledMaintenance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastScheduledMaintenance")]
    public DateTime? LastScheduledMaintenance { get; set; }

    /// <summary>
    /// The last time data sync completed
    /// </summary>
    /// <value>The last time data sync completed</value>
    [DataMember(Name="LastDataSync", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastDataSync")]
    public DateTime? LastDataSync { get; set; }

    /// <summary>
    /// The last time audit log sync completed
    /// </summary>
    /// <value>The last time audit log sync completed</value>
    [DataMember(Name="LastAuditLogSync", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastAuditLogSync")]
    public DateTime? LastAuditLogSync { get; set; }

    /// <summary>
    /// The last time retention was run and succeeded
    /// </summary>
    /// <value>The last time retention was run and succeeded</value>
    [DataMember(Name="LastScheduledRetentionSuccess", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastScheduledRetentionSuccess")]
    public DateTime? LastScheduledRetentionSuccess { get; set; }

    /// <summary>
    /// The last time retention was run and failed
    /// </summary>
    /// <value>The last time retention was run and failed</value>
    [DataMember(Name="LastScheduledRetentionFailure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastScheduledRetentionFailure")]
    public DateTime? LastScheduledRetentionFailure { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuditLogMaintenance {\n");
      sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
      sb.Append("  TimeZoneDisplayName: ").Append(TimeZoneDisplayName).Append("\n");
      sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
      sb.Append("  StartHour: ").Append(StartHour).Append("\n");
      sb.Append("  DaysToRetainLogs: ").Append(DaysToRetainLogs).Append("\n");
      sb.Append("  PurgeArchiveAuditLogs: ").Append(PurgeArchiveAuditLogs).Append("\n");
      sb.Append("  ArchiveServerId: ").Append(ArchiveServerId).Append("\n");
      sb.Append("  ArchiveServerName: ").Append(ArchiveServerName).Append("\n");
      sb.Append("  NextScheduledMaintenance: ").Append(NextScheduledMaintenance).Append("\n");
      sb.Append("  LastScheduledMaintenance: ").Append(LastScheduledMaintenance).Append("\n");
      sb.Append("  LastDataSync: ").Append(LastDataSync).Append("\n");
      sb.Append("  LastAuditLogSync: ").Append(LastAuditLogSync).Append("\n");
      sb.Append("  LastScheduledRetentionSuccess: ").Append(LastScheduledRetentionSuccess).Append("\n");
      sb.Append("  LastScheduledRetentionFailure: ").Append(LastScheduledRetentionFailure).Append("\n");
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
