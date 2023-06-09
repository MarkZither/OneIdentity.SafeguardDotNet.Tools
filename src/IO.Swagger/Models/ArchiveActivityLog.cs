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
    /// Represents an archive task that may run on a remote machine
    /// </summary>
    [DataContract]
    public partial class ArchiveActivityLog : IEquatable<ArchiveActivityLog>
    { 
        /// <summary>
        /// ID of the task (Read-only)
        /// </summary>
        /// <value>ID of the task (Read-only)</value>

        [DataMember(Name="Id")]
        public string Id { get; set; }

        /// <summary>
        /// The date the task was created
        /// </summary>
        /// <value>The date the task was created</value>

        [DataMember(Name="LogTime")]
        public DateTime? LogTime { get; set; }

        /// <summary>
        /// The database ID of the user that performed the activity
        /// </summary>
        /// <value>The database ID of the user that performed the activity</value>

        [DataMember(Name="UserId")]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserProperties
        /// </summary>

        [DataMember(Name="UserProperties")]
        public UserLogProperties UserProperties { get; set; }

        /// <summary>
        /// Id of appliance
        /// </summary>
        /// <value>Id of appliance</value>

        [DataMember(Name="ApplianceId")]
        public string ApplianceId { get; set; }

        /// <summary>
        /// Name of appliance
        /// </summary>
        /// <value>Name of appliance</value>

        [DataMember(Name="ApplianceName")]
        public string ApplianceName { get; set; }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>

        [DataMember(Name="EventName")]
        public EventName EventName { get; set; }

        /// <summary>
        /// Name of the event
        /// </summary>
        /// <value>Name of the event</value>

        [DataMember(Name="EventDisplayName")]
        public string EventDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets ArchiveType
        /// </summary>

        [DataMember(Name="ArchiveType")]
        public ArchiveType ArchiveType { get; set; }

        /// <summary>
        /// Source file or path
        /// </summary>
        /// <value>Source file or path</value>

        [DataMember(Name="SourcePath")]
        public string SourcePath { get; set; }

        /// <summary>
        /// Destination file or path. (Download only)
        /// </summary>
        /// <value>Destination file or path. (Download only)</value>

        [DataMember(Name="DestinationPath")]
        public string DestinationPath { get; set; }

        /// <summary>
        /// Name of file that is transferred (Read-only)
        /// </summary>
        /// <value>Name of file that is transferred (Read-only)</value>

        [DataMember(Name="FileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Unique ID of the file
        /// </summary>
        /// <value>Unique ID of the file</value>

        [DataMember(Name="FileId")]
        public string FileId { get; set; }

        /// <summary>
        /// Database ID of the asset or directory to execute this task on
        /// </summary>
        /// <value>Database ID of the asset or directory to execute this task on</value>

        [DataMember(Name="ArchiveServerId")]
        public int? ArchiveServerId { get; set; }

        /// <summary>
        /// Name of the asset or directory name the task was executed against (Read-only)
        /// </summary>
        /// <value>Name of the asset or directory name the task was executed against (Read-only)</value>

        [DataMember(Name="ArchiveServerName")]
        public string ArchiveServerName { get; set; }

        /// <summary>
        /// Network DNS name or IP address used to connect to the machine over the network.
        /// </summary>
        /// <value>Network DNS name or IP address used to connect to the machine over the network.</value>

        [MaxLength(255)]
        [DataMember(Name="NetworkAddress")]
        public string NetworkAddress { get; set; }

        /// <summary>
        /// Gets or Sets RequestStatus
        /// </summary>

        [DataMember(Name="RequestStatus")]
        public RequestStatus RequestStatus { get; set; }

        /// <summary>
        /// Detailed log of task execution. Only populated in results from the Tasks resource (Read-only)
        /// </summary>
        /// <value>Detailed log of task execution. Only populated in results from the Tasks resource (Read-only)</value>

        [DataMember(Name="Log")]
        public List<TaskLog> Log { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionProperties
        /// </summary>

        [DataMember(Name="ConnectionProperties")]
        public ArchiveServerConnectionProperties ConnectionProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchiveActivityLog {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LogTime: ").Append(LogTime).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventDisplayName: ").Append(EventDisplayName).Append("\n");
            sb.Append("  ArchiveType: ").Append(ArchiveType).Append("\n");
            sb.Append("  SourcePath: ").Append(SourcePath).Append("\n");
            sb.Append("  DestinationPath: ").Append(DestinationPath).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  ArchiveServerId: ").Append(ArchiveServerId).Append("\n");
            sb.Append("  ArchiveServerName: ").Append(ArchiveServerName).Append("\n");
            sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
            sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
            sb.Append("  Log: ").Append(Log).Append("\n");
            sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ArchiveActivityLog)obj);
        }

        /// <summary>
        /// Returns true if ArchiveActivityLog instances are equal
        /// </summary>
        /// <param name="other">Instance of ArchiveActivityLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchiveActivityLog other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    LogTime == other.LogTime ||
                    LogTime != null &&
                    LogTime.Equals(other.LogTime)
                ) && 
                (
                    UserId == other.UserId ||
                    UserId != null &&
                    UserId.Equals(other.UserId)
                ) && 
                (
                    UserProperties == other.UserProperties ||
                    UserProperties != null &&
                    UserProperties.Equals(other.UserProperties)
                ) && 
                (
                    ApplianceId == other.ApplianceId ||
                    ApplianceId != null &&
                    ApplianceId.Equals(other.ApplianceId)
                ) && 
                (
                    ApplianceName == other.ApplianceName ||
                    ApplianceName != null &&
                    ApplianceName.Equals(other.ApplianceName)
                ) && 
                (
                    EventName == other.EventName ||
                    EventName != null &&
                    EventName.Equals(other.EventName)
                ) && 
                (
                    EventDisplayName == other.EventDisplayName ||
                    EventDisplayName != null &&
                    EventDisplayName.Equals(other.EventDisplayName)
                ) && 
                (
                    ArchiveType == other.ArchiveType ||
                    ArchiveType != null &&
                    ArchiveType.Equals(other.ArchiveType)
                ) && 
                (
                    SourcePath == other.SourcePath ||
                    SourcePath != null &&
                    SourcePath.Equals(other.SourcePath)
                ) && 
                (
                    DestinationPath == other.DestinationPath ||
                    DestinationPath != null &&
                    DestinationPath.Equals(other.DestinationPath)
                ) && 
                (
                    FileName == other.FileName ||
                    FileName != null &&
                    FileName.Equals(other.FileName)
                ) && 
                (
                    FileId == other.FileId ||
                    FileId != null &&
                    FileId.Equals(other.FileId)
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
                    NetworkAddress == other.NetworkAddress ||
                    NetworkAddress != null &&
                    NetworkAddress.Equals(other.NetworkAddress)
                ) && 
                (
                    RequestStatus == other.RequestStatus ||
                    RequestStatus != null &&
                    RequestStatus.Equals(other.RequestStatus)
                ) && 
                (
                    Log == other.Log ||
                    Log != null &&
                    Log.SequenceEqual(other.Log)
                ) && 
                (
                    ConnectionProperties == other.ConnectionProperties ||
                    ConnectionProperties != null &&
                    ConnectionProperties.Equals(other.ConnectionProperties)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (LogTime != null)
                    hashCode = hashCode * 59 + LogTime.GetHashCode();
                    if (UserId != null)
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    if (UserProperties != null)
                    hashCode = hashCode * 59 + UserProperties.GetHashCode();
                    if (ApplianceId != null)
                    hashCode = hashCode * 59 + ApplianceId.GetHashCode();
                    if (ApplianceName != null)
                    hashCode = hashCode * 59 + ApplianceName.GetHashCode();
                    if (EventName != null)
                    hashCode = hashCode * 59 + EventName.GetHashCode();
                    if (EventDisplayName != null)
                    hashCode = hashCode * 59 + EventDisplayName.GetHashCode();
                    if (ArchiveType != null)
                    hashCode = hashCode * 59 + ArchiveType.GetHashCode();
                    if (SourcePath != null)
                    hashCode = hashCode * 59 + SourcePath.GetHashCode();
                    if (DestinationPath != null)
                    hashCode = hashCode * 59 + DestinationPath.GetHashCode();
                    if (FileName != null)
                    hashCode = hashCode * 59 + FileName.GetHashCode();
                    if (FileId != null)
                    hashCode = hashCode * 59 + FileId.GetHashCode();
                    if (ArchiveServerId != null)
                    hashCode = hashCode * 59 + ArchiveServerId.GetHashCode();
                    if (ArchiveServerName != null)
                    hashCode = hashCode * 59 + ArchiveServerName.GetHashCode();
                    if (NetworkAddress != null)
                    hashCode = hashCode * 59 + NetworkAddress.GetHashCode();
                    if (RequestStatus != null)
                    hashCode = hashCode * 59 + RequestStatus.GetHashCode();
                    if (Log != null)
                    hashCode = hashCode * 59 + Log.GetHashCode();
                    if (ConnectionProperties != null)
                    hashCode = hashCode * 59 + ConnectionProperties.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ArchiveActivityLog left, ArchiveActivityLog right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ArchiveActivityLog left, ArchiveActivityLog right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
