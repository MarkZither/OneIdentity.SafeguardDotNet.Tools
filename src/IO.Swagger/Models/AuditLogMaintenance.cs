/*
 * Safeguard Core API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v4
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// Configuration for data and audit log archive, purge and repair.
    /// </summary>
    [DataContract]
    public partial class AuditLogMaintenance : IEquatable<AuditLogMaintenance>
    { 
        /// <summary>
        /// The timezone in which the schedule should run
        /// </summary>
        /// <value>The timezone in which the schedule should run</value>

        [DataMember(Name="TimeZoneId")]
        public string TimeZoneId { get; set; }

        /// <summary>
        /// The description of the timezone in which the schedule should run (Read-only)
        /// </summary>
        /// <value>The description of the timezone in which the schedule should run (Read-only)</value>

        [DataMember(Name="TimeZoneDisplayName")]
        public string TimeZoneDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets DayOfWeek
        /// </summary>

        [DataMember(Name="DayOfWeek")]
        public DayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// The hour of the day that the schedule will run. Default is midnight.
        /// </summary>
        /// <value>The hour of the day that the schedule will run. Default is midnight.</value>

        [Range(0, 23)]
        [DataMember(Name="StartHour")]
        public int? StartHour { get; set; }

        /// <summary>
        /// How long to retain audit logs before deletion. Minimum is 30 days. Default is 365 days.
        /// </summary>
        /// <value>How long to retain audit logs before deletion. Minimum is 30 days. Default is 365 days.</value>

        [Range(30, 2147483647)]
        [DataMember(Name="DaysToRetainLogs")]
        public int? DaysToRetainLogs { get; set; }

        /// <summary>
        /// Specify true if audit logs older than DaysToRetainLogs should be purged. Default is false.  Audit logs will only be archived before purge if an archive server is configured.
        /// </summary>
        /// <value>Specify true if audit logs older than DaysToRetainLogs should be purged. Default is false.  Audit logs will only be archived before purge if an archive server is configured.</value>

        [DataMember(Name="PurgeArchiveAuditLogs")]
        public bool? PurgeArchiveAuditLogs { get; set; }

        /// <summary>
        /// Database ID of archive server. Must be configured to archive audit logs before purge.
        /// </summary>
        /// <value>Database ID of archive server. Must be configured to archive audit logs before purge.</value>

        [DataMember(Name="ArchiveServerId")]
        public int? ArchiveServerId { get; set; }

        /// <summary>
        /// Name of archive server (Read-only)
        /// </summary>
        /// <value>Name of archive server (Read-only)</value>

        [DataMember(Name="ArchiveServerName")]
        public string ArchiveServerName { get; set; }

        /// <summary>
        /// The next time retention is scheduled to run
        /// </summary>
        /// <value>The next time retention is scheduled to run</value>

        [DataMember(Name="NextScheduledMaintenance")]
        public DateTime? NextScheduledMaintenance { get; set; }

        /// <summary>
        /// The last time retention was run
        /// </summary>
        /// <value>The last time retention was run</value>

        [DataMember(Name="LastScheduledMaintenance")]
        public DateTime? LastScheduledMaintenance { get; set; }

        /// <summary>
        /// The last time data sync completed
        /// </summary>
        /// <value>The last time data sync completed</value>

        [DataMember(Name="LastDataSync")]
        public DateTime? LastDataSync { get; set; }

        /// <summary>
        /// The last time audit log sync completed
        /// </summary>
        /// <value>The last time audit log sync completed</value>

        [DataMember(Name="LastAuditLogSync")]
        public DateTime? LastAuditLogSync { get; set; }

        /// <summary>
        /// The last time retention was run and succeeded
        /// </summary>
        /// <value>The last time retention was run and succeeded</value>

        [DataMember(Name="LastScheduledRetentionSuccess")]
        public DateTime? LastScheduledRetentionSuccess { get; set; }

        /// <summary>
        /// The last time retention was run and failed
        /// </summary>
        /// <value>The last time retention was run and failed</value>

        [DataMember(Name="LastScheduledRetentionFailure")]
        public DateTime? LastScheduledRetentionFailure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((AuditLogMaintenance)obj);
        }

        /// <summary>
        /// Returns true if AuditLogMaintenance instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditLogMaintenance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditLogMaintenance other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TimeZoneId == other.TimeZoneId ||
                    TimeZoneId != null &&
                    TimeZoneId.Equals(other.TimeZoneId)
                ) && 
                (
                    TimeZoneDisplayName == other.TimeZoneDisplayName ||
                    TimeZoneDisplayName != null &&
                    TimeZoneDisplayName.Equals(other.TimeZoneDisplayName)
                ) && 
                (
                    DayOfWeek == other.DayOfWeek ||
                    DayOfWeek != null &&
                    DayOfWeek.Equals(other.DayOfWeek)
                ) && 
                (
                    StartHour == other.StartHour ||
                    StartHour != null &&
                    StartHour.Equals(other.StartHour)
                ) && 
                (
                    DaysToRetainLogs == other.DaysToRetainLogs ||
                    DaysToRetainLogs != null &&
                    DaysToRetainLogs.Equals(other.DaysToRetainLogs)
                ) && 
                (
                    PurgeArchiveAuditLogs == other.PurgeArchiveAuditLogs ||
                    PurgeArchiveAuditLogs != null &&
                    PurgeArchiveAuditLogs.Equals(other.PurgeArchiveAuditLogs)
                ) && 
                (
                    ArchiveServerId == other.ArchiveServerId ||
                    ArchiveServerId != null &&
                    ArchiveServerId.Equals(other.ArchiveServerId)
                ) && 
                (
                    ArchiveServerName == other.ArchiveServerName ||
                    ArchiveServerName != null &&
                    ArchiveServerName.Equals(other.ArchiveServerName)
                ) && 
                (
                    NextScheduledMaintenance == other.NextScheduledMaintenance ||
                    NextScheduledMaintenance != null &&
                    NextScheduledMaintenance.Equals(other.NextScheduledMaintenance)
                ) && 
                (
                    LastScheduledMaintenance == other.LastScheduledMaintenance ||
                    LastScheduledMaintenance != null &&
                    LastScheduledMaintenance.Equals(other.LastScheduledMaintenance)
                ) && 
                (
                    LastDataSync == other.LastDataSync ||
                    LastDataSync != null &&
                    LastDataSync.Equals(other.LastDataSync)
                ) && 
                (
                    LastAuditLogSync == other.LastAuditLogSync ||
                    LastAuditLogSync != null &&
                    LastAuditLogSync.Equals(other.LastAuditLogSync)
                ) && 
                (
                    LastScheduledRetentionSuccess == other.LastScheduledRetentionSuccess ||
                    LastScheduledRetentionSuccess != null &&
                    LastScheduledRetentionSuccess.Equals(other.LastScheduledRetentionSuccess)
                ) && 
                (
                    LastScheduledRetentionFailure == other.LastScheduledRetentionFailure ||
                    LastScheduledRetentionFailure != null &&
                    LastScheduledRetentionFailure.Equals(other.LastScheduledRetentionFailure)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (TimeZoneId != null)
                    hashCode = hashCode * 59 + TimeZoneId.GetHashCode();
                    if (TimeZoneDisplayName != null)
                    hashCode = hashCode * 59 + TimeZoneDisplayName.GetHashCode();
                    if (DayOfWeek != null)
                    hashCode = hashCode * 59 + DayOfWeek.GetHashCode();
                    if (StartHour != null)
                    hashCode = hashCode * 59 + StartHour.GetHashCode();
                    if (DaysToRetainLogs != null)
                    hashCode = hashCode * 59 + DaysToRetainLogs.GetHashCode();
                    if (PurgeArchiveAuditLogs != null)
                    hashCode = hashCode * 59 + PurgeArchiveAuditLogs.GetHashCode();
                    if (ArchiveServerId != null)
                    hashCode = hashCode * 59 + ArchiveServerId.GetHashCode();
                    if (ArchiveServerName != null)
                    hashCode = hashCode * 59 + ArchiveServerName.GetHashCode();
                    if (NextScheduledMaintenance != null)
                    hashCode = hashCode * 59 + NextScheduledMaintenance.GetHashCode();
                    if (LastScheduledMaintenance != null)
                    hashCode = hashCode * 59 + LastScheduledMaintenance.GetHashCode();
                    if (LastDataSync != null)
                    hashCode = hashCode * 59 + LastDataSync.GetHashCode();
                    if (LastAuditLogSync != null)
                    hashCode = hashCode * 59 + LastAuditLogSync.GetHashCode();
                    if (LastScheduledRetentionSuccess != null)
                    hashCode = hashCode * 59 + LastScheduledRetentionSuccess.GetHashCode();
                    if (LastScheduledRetentionFailure != null)
                    hashCode = hashCode * 59 + LastScheduledRetentionFailure.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AuditLogMaintenance left, AuditLogMaintenance right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AuditLogMaintenance left, AuditLogMaintenance right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
