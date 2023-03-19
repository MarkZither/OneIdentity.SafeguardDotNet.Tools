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
    /// An action/activity performed by a user
    /// </summary>
    [DataContract]
    public partial class AuditSearchLog : IEquatable<AuditSearchLog>
    { 
        /// <summary>
        /// Database ID of this log entry
        /// </summary>
        /// <value>Database ID of this log entry</value>

        [DataMember(Name="Id")]
        public string Id { get; set; }

        /// <summary>
        /// The date the activity occurred
        /// </summary>
        /// <value>The date the activity occurred</value>

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
        /// Gets or Sets Category
        /// </summary>

        [DataMember(Name="Category")]
        public AuditLogCategory Category { get; set; }

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
        /// Gets or Sets ErrorType
        /// </summary>

        [DataMember(Name="ErrorType")]
        public AuthenticationErrorType ErrorType { get; set; }

        /// <summary>
        /// Gets or Sets ObjectType
        /// </summary>

        [DataMember(Name="ObjectType")]
        public ObjectType ObjectType { get; set; }

        /// <summary>
        /// ID of object
        /// </summary>
        /// <value>ID of object</value>

        [DataMember(Name="ObjectId")]
        public string ObjectId { get; set; }

        /// <summary>
        /// Name of object
        /// </summary>
        /// <value>Name of object</value>

        [DataMember(Name="ObjectName")]
        public string ObjectName { get; set; }

        /// <summary>
        /// Access request ID
        /// </summary>
        /// <value>Access request ID</value>

        [DataMember(Name="RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// Access request session ID
        /// </summary>
        /// <value>Access request session ID</value>

        [DataMember(Name="SessionId")]
        public int? SessionId { get; set; }

        /// <summary>
        /// Gets or Sets RecordingProperties
        /// </summary>

        [DataMember(Name="RecordingProperties")]
        public SessionRecordingProperties RecordingProperties { get; set; }

        /// <summary>
        /// Gets or Sets AccessRequestType
        /// </summary>

        [DataMember(Name="AccessRequestType")]
        public AccessRequestType AccessRequestType { get; set; }

        /// <summary>
        /// Requester ID
        /// </summary>
        /// <value>Requester ID</value>

        [DataMember(Name="RequesterId")]
        public int? RequesterId { get; set; }

        /// <summary>
        /// Requester name
        /// </summary>
        /// <value>Requester name</value>

        [DataMember(Name="RequesterName")]
        public string RequesterName { get; set; }

        /// <summary>
        /// Account ID
        /// </summary>
        /// <value>Account ID</value>

        [DataMember(Name="AccountId")]
        public int? AccountId { get; set; }

        /// <summary>
        /// Account name
        /// </summary>
        /// <value>Account name</value>

        [DataMember(Name="AccountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Account domain name
        /// </summary>
        /// <value>Account domain name</value>

        [DataMember(Name="AccountDomainName")]
        public string AccountDomainName { get; set; }

        /// <summary>
        /// Asset ID
        /// </summary>
        /// <value>Asset ID</value>

        [DataMember(Name="AssetId")]
        public int? AssetId { get; set; }

        /// <summary>
        /// Asset name
        /// </summary>
        /// <value>Asset name</value>

        [DataMember(Name="AssetName")]
        public string AssetName { get; set; }

        /// <summary>
        /// Asset network address
        /// </summary>
        /// <value>Asset network address</value>

        [DataMember(Name="AssetNetworkAddress")]
        public string AssetNetworkAddress { get; set; }

        /// <summary>
        /// Asset Partition ID
        /// </summary>
        /// <value>Asset Partition ID</value>

        [DataMember(Name="AssetPartitionId")]
        public int? AssetPartitionId { get; set; }

        /// <summary>
        /// Asset Partition name
        /// </summary>
        /// <value>Asset Partition name</value>

        [DataMember(Name="AssetPartitionName")]
        public string AssetPartitionName { get; set; }

        /// <summary>
        /// Gets or Sets TaskName
        /// </summary>

        [DataMember(Name="TaskName")]
        public TaskNames TaskName { get; set; }

        /// <summary>
        /// Gets or Sets LicenseType
        /// </summary>

        [DataMember(Name="LicenseType")]
        public LicensableModule LicenseType { get; set; }

        /// <summary>
        /// Request submission date
        /// </summary>
        /// <value>Request submission date</value>

        [DataMember(Name="SubmittedDate")]
        public DateTime? SubmittedDate { get; set; }

        /// <summary>
        /// Supplemental data associated with the event, e.g., session commands
        /// </summary>
        /// <value>Supplemental data associated with the event, e.g., session commands</value>

        [DataMember(Name="Data")]
        public string Data { get; set; }

        /// <summary>
        /// Session node IpAddress that serves the session request.
        /// </summary>
        /// <value>Session node IpAddress that serves the session request.</value>

        [DataMember(Name="SessionSpsNodeIpAddress")]
        public string SessionSpsNodeIpAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditSearchLog {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LogTime: ").Append(LogTime).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
            sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
            sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventDisplayName: ").Append(EventDisplayName).Append("\n");
            sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  ObjectName: ").Append(ObjectName).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  RecordingProperties: ").Append(RecordingProperties).Append("\n");
            sb.Append("  AccessRequestType: ").Append(AccessRequestType).Append("\n");
            sb.Append("  RequesterId: ").Append(RequesterId).Append("\n");
            sb.Append("  RequesterName: ").Append(RequesterName).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetName: ").Append(AssetName).Append("\n");
            sb.Append("  AssetNetworkAddress: ").Append(AssetNetworkAddress).Append("\n");
            sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
            sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
            sb.Append("  TaskName: ").Append(TaskName).Append("\n");
            sb.Append("  LicenseType: ").Append(LicenseType).Append("\n");
            sb.Append("  SubmittedDate: ").Append(SubmittedDate).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  SessionSpsNodeIpAddress: ").Append(SessionSpsNodeIpAddress).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AuditSearchLog)obj);
        }

        /// <summary>
        /// Returns true if AuditSearchLog instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditSearchLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditSearchLog other)
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
                    Category == other.Category ||
                    Category != null &&
                    Category.Equals(other.Category)
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
                    ErrorType == other.ErrorType ||
                    ErrorType != null &&
                    ErrorType.Equals(other.ErrorType)
                ) && 
                (
                    ObjectType == other.ObjectType ||
                    ObjectType != null &&
                    ObjectType.Equals(other.ObjectType)
                ) && 
                (
                    ObjectId == other.ObjectId ||
                    ObjectId != null &&
                    ObjectId.Equals(other.ObjectId)
                ) && 
                (
                    ObjectName == other.ObjectName ||
                    ObjectName != null &&
                    ObjectName.Equals(other.ObjectName)
                ) && 
                (
                    RequestId == other.RequestId ||
                    RequestId != null &&
                    RequestId.Equals(other.RequestId)
                ) && 
                (
                    SessionId == other.SessionId ||
                    SessionId != null &&
                    SessionId.Equals(other.SessionId)
                ) && 
                (
                    RecordingProperties == other.RecordingProperties ||
                    RecordingProperties != null &&
                    RecordingProperties.Equals(other.RecordingProperties)
                ) && 
                (
                    AccessRequestType == other.AccessRequestType ||
                    AccessRequestType != null &&
                    AccessRequestType.Equals(other.AccessRequestType)
                ) && 
                (
                    RequesterId == other.RequesterId ||
                    RequesterId != null &&
                    RequesterId.Equals(other.RequesterId)
                ) && 
                (
                    RequesterName == other.RequesterName ||
                    RequesterName != null &&
                    RequesterName.Equals(other.RequesterName)
                ) && 
                (
                    AccountId == other.AccountId ||
                    AccountId != null &&
                    AccountId.Equals(other.AccountId)
                ) && 
                (
                    AccountName == other.AccountName ||
                    AccountName != null &&
                    AccountName.Equals(other.AccountName)
                ) && 
                (
                    AccountDomainName == other.AccountDomainName ||
                    AccountDomainName != null &&
                    AccountDomainName.Equals(other.AccountDomainName)
                ) && 
                (
                    AssetId == other.AssetId ||
                    AssetId != null &&
                    AssetId.Equals(other.AssetId)
                ) && 
                (
                    AssetName == other.AssetName ||
                    AssetName != null &&
                    AssetName.Equals(other.AssetName)
                ) && 
                (
                    AssetNetworkAddress == other.AssetNetworkAddress ||
                    AssetNetworkAddress != null &&
                    AssetNetworkAddress.Equals(other.AssetNetworkAddress)
                ) && 
                (
                    AssetPartitionId == other.AssetPartitionId ||
                    AssetPartitionId != null &&
                    AssetPartitionId.Equals(other.AssetPartitionId)
                ) && 
                (
                    AssetPartitionName == other.AssetPartitionName ||
                    AssetPartitionName != null &&
                    AssetPartitionName.Equals(other.AssetPartitionName)
                ) && 
                (
                    TaskName == other.TaskName ||
                    TaskName != null &&
                    TaskName.Equals(other.TaskName)
                ) && 
                (
                    LicenseType == other.LicenseType ||
                    LicenseType != null &&
                    LicenseType.Equals(other.LicenseType)
                ) && 
                (
                    SubmittedDate == other.SubmittedDate ||
                    SubmittedDate != null &&
                    SubmittedDate.Equals(other.SubmittedDate)
                ) && 
                (
                    Data == other.Data ||
                    Data != null &&
                    Data.Equals(other.Data)
                ) && 
                (
                    SessionSpsNodeIpAddress == other.SessionSpsNodeIpAddress ||
                    SessionSpsNodeIpAddress != null &&
                    SessionSpsNodeIpAddress.Equals(other.SessionSpsNodeIpAddress)
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
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (EventName != null)
                    hashCode = hashCode * 59 + EventName.GetHashCode();
                    if (EventDisplayName != null)
                    hashCode = hashCode * 59 + EventDisplayName.GetHashCode();
                    if (ErrorType != null)
                    hashCode = hashCode * 59 + ErrorType.GetHashCode();
                    if (ObjectType != null)
                    hashCode = hashCode * 59 + ObjectType.GetHashCode();
                    if (ObjectId != null)
                    hashCode = hashCode * 59 + ObjectId.GetHashCode();
                    if (ObjectName != null)
                    hashCode = hashCode * 59 + ObjectName.GetHashCode();
                    if (RequestId != null)
                    hashCode = hashCode * 59 + RequestId.GetHashCode();
                    if (SessionId != null)
                    hashCode = hashCode * 59 + SessionId.GetHashCode();
                    if (RecordingProperties != null)
                    hashCode = hashCode * 59 + RecordingProperties.GetHashCode();
                    if (AccessRequestType != null)
                    hashCode = hashCode * 59 + AccessRequestType.GetHashCode();
                    if (RequesterId != null)
                    hashCode = hashCode * 59 + RequesterId.GetHashCode();
                    if (RequesterName != null)
                    hashCode = hashCode * 59 + RequesterName.GetHashCode();
                    if (AccountId != null)
                    hashCode = hashCode * 59 + AccountId.GetHashCode();
                    if (AccountName != null)
                    hashCode = hashCode * 59 + AccountName.GetHashCode();
                    if (AccountDomainName != null)
                    hashCode = hashCode * 59 + AccountDomainName.GetHashCode();
                    if (AssetId != null)
                    hashCode = hashCode * 59 + AssetId.GetHashCode();
                    if (AssetName != null)
                    hashCode = hashCode * 59 + AssetName.GetHashCode();
                    if (AssetNetworkAddress != null)
                    hashCode = hashCode * 59 + AssetNetworkAddress.GetHashCode();
                    if (AssetPartitionId != null)
                    hashCode = hashCode * 59 + AssetPartitionId.GetHashCode();
                    if (AssetPartitionName != null)
                    hashCode = hashCode * 59 + AssetPartitionName.GetHashCode();
                    if (TaskName != null)
                    hashCode = hashCode * 59 + TaskName.GetHashCode();
                    if (LicenseType != null)
                    hashCode = hashCode * 59 + LicenseType.GetHashCode();
                    if (SubmittedDate != null)
                    hashCode = hashCode * 59 + SubmittedDate.GetHashCode();
                    if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                    if (SessionSpsNodeIpAddress != null)
                    hashCode = hashCode * 59 + SessionSpsNodeIpAddress.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AuditSearchLog left, AuditSearchLog right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AuditSearchLog left, AuditSearchLog right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
