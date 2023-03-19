using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Password Request Log
  /// </summary>
  [DataContract]
  public class AccessRequestLog {
    /// <summary>
    /// Gets or Sets UserProperties
    /// </summary>
    [DataMember(Name="UserProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserProperties")]
    public UserLogProperties UserProperties { get; set; }

    /// <summary>
    /// ID of the access request
    /// </summary>
    /// <value>ID of the access request</value>
    [DataMember(Name="RequestId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestId")]
    public string RequestId { get; set; }

    /// <summary>
    /// Gets or Sets AccessRequestType
    /// </summary>
    [DataMember(Name="AccessRequestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessRequestType")]
    public AccessRequestType AccessRequestType { get; set; }

    /// <summary>
    /// ID of the requester
    /// </summary>
    /// <value>ID of the requester</value>
    [DataMember(Name="RequesterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterId")]
    public int? RequesterId { get; set; }

    /// <summary>
    /// Name of the requester
    /// </summary>
    /// <value>Name of the requester</value>
    [DataMember(Name="RequesterName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterName")]
    public string RequesterName { get; set; }

    /// <summary>
    /// Username of the requester
    /// </summary>
    /// <value>Username of the requester</value>
    [DataMember(Name="RequesterUsername", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterUsername")]
    public string RequesterUsername { get; set; }

    /// <summary>
    /// Email of the requester
    /// </summary>
    /// <value>Email of the requester</value>
    [DataMember(Name="RequesterEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterEmail")]
    public string RequesterEmail { get; set; }

    /// <summary>
    /// Timezone of the requester
    /// </summary>
    /// <value>Timezone of the requester</value>
    [DataMember(Name="RequesterTimezone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterTimezone")]
    public string RequesterTimezone { get; set; }

    /// <summary>
    /// ID of the account that was requested
    /// </summary>
    /// <value>ID of the account that was requested</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Name of the account that was requested
    /// </summary>
    /// <value>Name of the account that was requested</value>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// ID of the asset of the account that was requested
    /// </summary>
    /// <value>ID of the asset of the account that was requested</value>
    [DataMember(Name="AccountAssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountAssetId")]
    public int? AccountAssetId { get; set; }

    /// <summary>
    /// Name of the asset of the account that was requested
    /// </summary>
    /// <value>Name of the asset of the account that was requested</value>
    [DataMember(Name="AccountAssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountAssetName")]
    public string AccountAssetName { get; set; }

    /// <summary>
    /// Domain name of the account that was requested
    /// </summary>
    /// <value>Domain name of the account that was requested</value>
    [DataMember(Name="AccountDomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDomainName")]
    public string AccountDomainName { get; set; }

    /// <summary>
    /// Distinguished name of the account that was requested
    /// </summary>
    /// <value>Distinguished name of the account that was requested</value>
    [DataMember(Name="AccountDistinguishedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDistinguishedName")]
    public string AccountDistinguishedName { get; set; }

    /// <summary>
    /// Gets or Sets AccountRequestType
    /// </summary>
    [DataMember(Name="AccountRequestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountRequestType")]
    public AccountRequestType AccountRequestType { get; set; }

    /// <summary>
    /// Id of the asset that was requested
    /// </summary>
    /// <value>Id of the asset that was requested</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Name of the asset that was requested
    /// </summary>
    /// <value>Name of the asset that was requested</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Network address of the asset that was requested
    /// </summary>
    /// <value>Network address of the asset that was requested</value>
    [DataMember(Name="AssetNetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetNetworkAddress")]
    public string AssetNetworkAddress { get; set; }

    /// <summary>
    /// Duration requested
    /// </summary>
    /// <value>Duration requested</value>
    [DataMember(Name="RequestDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestDuration")]
    public int? RequestDuration { get; set; }

    /// <summary>
    /// Time when request was submitted
    /// </summary>
    /// <value>Time when request was submitted</value>
    [DataMember(Name="SubmittedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubmittedAt")]
    public DateTime? SubmittedAt { get; set; }

    /// <summary>
    /// Time when request will available was required
    /// </summary>
    /// <value>Time when request will available was required</value>
    [DataMember(Name="RequiredAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequiredAt")]
    public DateTime? RequiredAt { get; set; }

    /// <summary>
    /// Time when request expires
    /// </summary>
    /// <value>Time when request expires</value>
    [DataMember(Name="RequestExpiresAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestExpiresAt")]
    public DateTime? RequestExpiresAt { get; set; }

    /// <summary>
    /// Time when request was approved
    /// </summary>
    /// <value>Time when request was approved</value>
    [DataMember(Name="ApprovedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApprovedAt")]
    public DateTime? ApprovedAt { get; set; }

    /// <summary>
    /// If request was for emergency
    /// </summary>
    /// <value>If request was for emergency</value>
    [DataMember(Name="IsEmergency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsEmergency")]
    public bool? IsEmergency { get; set; }

    /// <summary>
    /// If request was cancelled
    /// </summary>
    /// <value>If request was cancelled</value>
    [DataMember(Name="WasCancelled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasCancelled")]
    public bool? WasCancelled { get; set; }

    /// <summary>
    /// If request was denied
    /// </summary>
    /// <value>If request was denied</value>
    [DataMember(Name="WasDenied", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasDenied")]
    public bool? WasDenied { get; set; }

    /// <summary>
    /// If request was expired normally
    /// </summary>
    /// <value>If request was expired normally</value>
    [DataMember(Name="WasExpired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasExpired")]
    public bool? WasExpired { get; set; }

    /// <summary>
    /// If request was revoked
    /// </summary>
    /// <value>If request was revoked</value>
    [DataMember(Name="WasRevoked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasRevoked")]
    public bool? WasRevoked { get; set; }

    /// <summary>
    /// If request was checked out
    /// </summary>
    /// <value>If request was checked out</value>
    [DataMember(Name="WasCheckedOut", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasCheckedOut")]
    public bool? WasCheckedOut { get; set; }

    /// <summary>
    /// If request was evicted
    /// </summary>
    /// <value>If request was evicted</value>
    [DataMember(Name="WasEvicted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasEvicted")]
    public bool? WasEvicted { get; set; }

    /// <summary>
    /// Request reason code
    /// </summary>
    /// <value>Request reason code</value>
    [DataMember(Name="ReasonCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonCode")]
    public int? ReasonCode { get; set; }

    /// <summary>
    /// Request reason name
    /// </summary>
    /// <value>Request reason name</value>
    [DataMember(Name="ReasonName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonName")]
    public string ReasonName { get; set; }

    /// <summary>
    /// Request reason comment
    /// </summary>
    /// <value>Request reason comment</value>
    [DataMember(Name="ReasonComment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonComment")]
    public string ReasonComment { get; set; }

    /// <summary>
    /// Request ticket number
    /// </summary>
    /// <value>Request ticket number</value>
    [DataMember(Name="TicketNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TicketNumber")]
    public string TicketNumber { get; set; }

    /// <summary>
    /// True if the appliance was in offline workflow mode at the time of the log
    /// </summary>
    /// <value>True if the appliance was in offline workflow mode at the time of the log</value>
    [DataMember(Name="OfflineWorkflow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OfflineWorkflow")]
    public bool? OfflineWorkflow { get; set; }

    /// <summary>
    /// Id of access policy used for this request
    /// </summary>
    /// <value>Id of access policy used for this request</value>
    [DataMember(Name="PolicyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyId")]
    public int? PolicyId { get; set; }

    /// <summary>
    /// Name of access policy used for this request
    /// </summary>
    /// <value>Name of access policy used for this request</value>
    [DataMember(Name="PolicyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyName")]
    public string PolicyName { get; set; }

    /// <summary>
    /// Id of role used for this request
    /// </summary>
    /// <value>Id of role used for this request</value>
    [DataMember(Name="RoleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleId")]
    public int? RoleId { get; set; }

    /// <summary>
    /// Name of role used for this request
    /// </summary>
    /// <value>Name of role used for this request</value>
    [DataMember(Name="RoleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleName")]
    public string RoleName { get; set; }

    /// <summary>
    /// Default duration (days) the request will be available.
    /// </summary>
    /// <value>Default duration (days) the request will be available.</value>
    [DataMember(Name="DefaultReleaseDurationDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultReleaseDurationDays")]
    public int? DefaultReleaseDurationDays { get; set; }

    /// <summary>
    /// Default duration (hours) the request will be available.
    /// </summary>
    /// <value>Default duration (hours) the request will be available.</value>
    [DataMember(Name="DefaultReleaseDurationHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultReleaseDurationHours")]
    public int? DefaultReleaseDurationHours { get; set; }

    /// <summary>
    /// Default duration (minutes) the request will be available.
    /// </summary>
    /// <value>Default duration (minutes) the request will be available.</value>
    [DataMember(Name="DefaultReleaseDurationMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultReleaseDurationMinutes")]
    public int? DefaultReleaseDurationMinutes { get; set; }

    /// <summary>
    /// The maximum duration (days) the request will be available
    /// </summary>
    /// <value>The maximum duration (days) the request will be available</value>
    [DataMember(Name="MaximumReleaseDurationDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaximumReleaseDurationDays")]
    public int? MaximumReleaseDurationDays { get; set; }

    /// <summary>
    /// The maximum duration (hours) the request will be available.
    /// </summary>
    /// <value>The maximum duration (hours) the request will be available.</value>
    [DataMember(Name="MaximumReleaseDurationHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaximumReleaseDurationHours")]
    public int? MaximumReleaseDurationHours { get; set; }

    /// <summary>
    /// The maximum duration (minutes) the request will be available.
    /// </summary>
    /// <value>The maximum duration (minutes) the request will be available.</value>
    [DataMember(Name="MaximumReleaseDurationMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaximumReleaseDurationMinutes")]
    public int? MaximumReleaseDurationMinutes { get; set; }

    /// <summary>
    /// Gets or Sets HourlyRestrictionProperties
    /// </summary>
    [DataMember(Name="HourlyRestrictionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HourlyRestrictionProperties")]
    public HourlyRestrictionProperties HourlyRestrictionProperties { get; set; }

    /// <summary>
    /// Date/time after which the associated policy/role will cease to be active
    /// </summary>
    /// <value>Date/time after which the associated policy/role will cease to be active</value>
    [DataMember(Name="PolicyExpirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyExpirationDate")]
    public DateTime? PolicyExpirationDate { get; set; }

    /// <summary>
    /// Whether to allow the release duration to be modified during a request.
    /// </summary>
    /// <value>Whether to allow the release duration to be modified during a request.</value>
    [DataMember(Name="AllowCustomDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowCustomDuration")]
    public bool? AllowCustomDuration { get; set; }

    /// <summary>
    /// Requests must be approved before becoming available
    /// </summary>
    /// <value>Requests must be approved before becoming available</value>
    [DataMember(Name="RequiresApproval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequiresApproval")]
    public bool? RequiresApproval { get; set; }

    /// <summary>
    /// A reason code is required for request to be made.
    /// </summary>
    /// <value>A reason code is required for request to be made.</value>
    [DataMember(Name="RequiresReasonCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequiresReasonCode")]
    public bool? RequiresReasonCode { get; set; }

    /// <summary>
    /// A reason comment is required before a request can be made.
    /// </summary>
    /// <value>A reason comment is required before a request can be made.</value>
    [DataMember(Name="RequiresReasonComment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequiresReasonComment")]
    public bool? RequiresReasonComment { get; set; }

    /// <summary>
    /// Whether the members of this role can request emergency access
    /// </summary>
    /// <value>Whether the members of this role can request emergency access</value>
    [DataMember(Name="EmergencyAccessEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmergencyAccessEnabled")]
    public bool? EmergencyAccessEnabled { get; set; }

    /// <summary>
    /// Ignore hourly restrictions when requesting emergency access
    /// </summary>
    /// <value>Ignore hourly restrictions when requesting emergency access</value>
    [DataMember(Name="EmergencyAccessAnytime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmergencyAccessAnytime")]
    public bool? EmergencyAccessAnytime { get; set; }

    /// <summary>
    /// Allow multiple users to request emergency access simultaneously for same account
    /// </summary>
    /// <value>Allow multiple users to request emergency access simultaneously for same account</value>
    [DataMember(Name="EmergencyAccessSimultaneous", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmergencyAccessSimultaneous")]
    public bool? EmergencyAccessSimultaneous { get; set; }

    /// <summary>
    /// The minimum number of reviews required before a request is closed
    /// </summary>
    /// <value>The minimum number of reviews required before a request is closed</value>
    [DataMember(Name="RequiredReviewers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequiredReviewers")]
    public int? RequiredReviewers { get; set; }

    /// <summary>
    /// Whether to change the account password after a release has expired
    /// </summary>
    /// <value>Whether to change the account password after a release has expired</value>
    [DataMember(Name="ChangePasswordAfterRelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangePasswordAfterRelease")]
    public bool? ChangePasswordAfterRelease { get; set; }

    /// <summary>
    /// Whether to change the account SSH key after a release has expired
    /// </summary>
    /// <value>Whether to change the account SSH key after a release has expired</value>
    [DataMember(Name="ChangeSshKeyAfterRelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangeSshKeyAfterRelease")]
    public bool? ChangeSshKeyAfterRelease { get; set; }

    /// <summary>
    /// Allow password release during session request
    /// </summary>
    /// <value>Allow password release during session request</value>
    [DataMember(Name="AllowSessionPasswordRelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSessionPasswordRelease")]
    public bool? AllowSessionPasswordRelease { get; set; }

    /// <summary>
    /// Allow SSH key release during session request
    /// </summary>
    /// <value>Allow SSH key release during session request</value>
    [DataMember(Name="AllowSessionSshKeyRelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSessionSshKeyRelease")]
    public bool? AllowSessionSshKeyRelease { get; set; }

    /// <summary>
    /// Maximum number of requests during the same time period
    /// </summary>
    /// <value>Maximum number of requests during the same time period</value>
    [DataMember(Name="MaximumSimultaneousReleases", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaximumSimultaneousReleases")]
    public int? MaximumSimultaneousReleases { get; set; }

    /// <summary>
    /// The maximum duration (days) an expired request may be pending review before notifying escalation contacts
    /// </summary>
    /// <value>The maximum duration (days) an expired request may be pending review before notifying escalation contacts</value>
    [DataMember(Name="PendingReviewDurationBeforeEscalationDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingReviewDurationBeforeEscalationDays")]
    public int? PendingReviewDurationBeforeEscalationDays { get; set; }

    /// <summary>
    /// The maximum duration (hours) a expired request may be pending review before notifying escalation contacts
    /// </summary>
    /// <value>The maximum duration (hours) a expired request may be pending review before notifying escalation contacts</value>
    [DataMember(Name="PendingReviewDurationBeforeEscalationHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingReviewDurationBeforeEscalationHours")]
    public int? PendingReviewDurationBeforeEscalationHours { get; set; }

    /// <summary>
    /// The maximum duration (minutes) a expired request may be pending review before notifying escalation contacts
    /// </summary>
    /// <value>The maximum duration (minutes) a expired request may be pending review before notifying escalation contacts</value>
    [DataMember(Name="PendingReviewDurationBeforeEscalationMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingReviewDurationBeforeEscalationMinutes")]
    public int? PendingReviewDurationBeforeEscalationMinutes { get; set; }

    /// <summary>
    /// The maximum duration (days) a request may be pending approval before notifying escalation contacts
    /// </summary>
    /// <value>The maximum duration (days) a request may be pending approval before notifying escalation contacts</value>
    [DataMember(Name="PendingApprovalDurationBeforeEscalationDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingApprovalDurationBeforeEscalationDays")]
    public int? PendingApprovalDurationBeforeEscalationDays { get; set; }

    /// <summary>
    /// The maximum duration (hours) a request may be pending approval before notifying escalation contacts
    /// </summary>
    /// <value>The maximum duration (hours) a request may be pending approval before notifying escalation contacts</value>
    [DataMember(Name="PendingApprovalDurationBeforeEscalationHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingApprovalDurationBeforeEscalationHours")]
    public int? PendingApprovalDurationBeforeEscalationHours { get; set; }

    /// <summary>
    /// The maximum duration (minutes) a request may be pending approval before notifying escalation contacts
    /// </summary>
    /// <value>The maximum duration (minutes) a request may be pending approval before notifying escalation contacts</value>
    [DataMember(Name="PendingApprovalDurationBeforeEscalationMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingApprovalDurationBeforeEscalationMinutes")]
    public int? PendingApprovalDurationBeforeEscalationMinutes { get; set; }

    /// <summary>
    /// Policy reviewers
    /// </summary>
    /// <value>Policy reviewers</value>
    [DataMember(Name="Reviewers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Reviewers")]
    public List<AccessRequestLogIdentity> Reviewers { get; set; }

    /// <summary>
    /// Policy approver sets
    /// </summary>
    /// <value>Policy approver sets</value>
    [DataMember(Name="ApproverSets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApproverSets")]
    public List<AccessRequestLogApproverSet> ApproverSets { get; set; }

    /// <summary>
    /// Gets or Sets RequestState
    /// </summary>
    [DataMember(Name="RequestState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestState")]
    public AccessRequestState RequestState { get; set; }

    /// <summary>
    /// Gets or Sets SessionProperties
    /// </summary>
    [DataMember(Name="SessionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionProperties")]
    public SessionProperties SessionProperties { get; set; }

    /// <summary>
    /// ID of the broker
    /// </summary>
    /// <value>ID of the broker</value>
    [DataMember(Name="BrokerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BrokerId")]
    public int? BrokerId { get; set; }

    /// <summary>
    /// Name of the broker
    /// </summary>
    /// <value>Name of the broker</value>
    [DataMember(Name="BrokerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BrokerName")]
    public string BrokerName { get; set; }

    /// <summary>
    /// Allow Sra session launch
    /// </summary>
    /// <value>Allow Sra session launch</value>
    [DataMember(Name="AllowSraSessionLaunch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSraSessionLaunch")]
    public bool? AllowSraSessionLaunch { get; set; }

    /// <summary>
    /// Gets or Sets ApplicationSessionProperties
    /// </summary>
    [DataMember(Name="ApplicationSessionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationSessionProperties")]
    public ApplicationSessionProperties ApplicationSessionProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessRequestLog {\n");
      sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
      sb.Append("  RequestId: ").Append(RequestId).Append("\n");
      sb.Append("  AccessRequestType: ").Append(AccessRequestType).Append("\n");
      sb.Append("  RequesterId: ").Append(RequesterId).Append("\n");
      sb.Append("  RequesterName: ").Append(RequesterName).Append("\n");
      sb.Append("  RequesterUsername: ").Append(RequesterUsername).Append("\n");
      sb.Append("  RequesterEmail: ").Append(RequesterEmail).Append("\n");
      sb.Append("  RequesterTimezone: ").Append(RequesterTimezone).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountAssetId: ").Append(AccountAssetId).Append("\n");
      sb.Append("  AccountAssetName: ").Append(AccountAssetName).Append("\n");
      sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
      sb.Append("  AccountDistinguishedName: ").Append(AccountDistinguishedName).Append("\n");
      sb.Append("  AccountRequestType: ").Append(AccountRequestType).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  AssetNetworkAddress: ").Append(AssetNetworkAddress).Append("\n");
      sb.Append("  RequestDuration: ").Append(RequestDuration).Append("\n");
      sb.Append("  SubmittedAt: ").Append(SubmittedAt).Append("\n");
      sb.Append("  RequiredAt: ").Append(RequiredAt).Append("\n");
      sb.Append("  RequestExpiresAt: ").Append(RequestExpiresAt).Append("\n");
      sb.Append("  ApprovedAt: ").Append(ApprovedAt).Append("\n");
      sb.Append("  IsEmergency: ").Append(IsEmergency).Append("\n");
      sb.Append("  WasCancelled: ").Append(WasCancelled).Append("\n");
      sb.Append("  WasDenied: ").Append(WasDenied).Append("\n");
      sb.Append("  WasExpired: ").Append(WasExpired).Append("\n");
      sb.Append("  WasRevoked: ").Append(WasRevoked).Append("\n");
      sb.Append("  WasCheckedOut: ").Append(WasCheckedOut).Append("\n");
      sb.Append("  WasEvicted: ").Append(WasEvicted).Append("\n");
      sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
      sb.Append("  ReasonName: ").Append(ReasonName).Append("\n");
      sb.Append("  ReasonComment: ").Append(ReasonComment).Append("\n");
      sb.Append("  TicketNumber: ").Append(TicketNumber).Append("\n");
      sb.Append("  OfflineWorkflow: ").Append(OfflineWorkflow).Append("\n");
      sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
      sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
      sb.Append("  RoleId: ").Append(RoleId).Append("\n");
      sb.Append("  RoleName: ").Append(RoleName).Append("\n");
      sb.Append("  DefaultReleaseDurationDays: ").Append(DefaultReleaseDurationDays).Append("\n");
      sb.Append("  DefaultReleaseDurationHours: ").Append(DefaultReleaseDurationHours).Append("\n");
      sb.Append("  DefaultReleaseDurationMinutes: ").Append(DefaultReleaseDurationMinutes).Append("\n");
      sb.Append("  MaximumReleaseDurationDays: ").Append(MaximumReleaseDurationDays).Append("\n");
      sb.Append("  MaximumReleaseDurationHours: ").Append(MaximumReleaseDurationHours).Append("\n");
      sb.Append("  MaximumReleaseDurationMinutes: ").Append(MaximumReleaseDurationMinutes).Append("\n");
      sb.Append("  HourlyRestrictionProperties: ").Append(HourlyRestrictionProperties).Append("\n");
      sb.Append("  PolicyExpirationDate: ").Append(PolicyExpirationDate).Append("\n");
      sb.Append("  AllowCustomDuration: ").Append(AllowCustomDuration).Append("\n");
      sb.Append("  RequiresApproval: ").Append(RequiresApproval).Append("\n");
      sb.Append("  RequiresReasonCode: ").Append(RequiresReasonCode).Append("\n");
      sb.Append("  RequiresReasonComment: ").Append(RequiresReasonComment).Append("\n");
      sb.Append("  EmergencyAccessEnabled: ").Append(EmergencyAccessEnabled).Append("\n");
      sb.Append("  EmergencyAccessAnytime: ").Append(EmergencyAccessAnytime).Append("\n");
      sb.Append("  EmergencyAccessSimultaneous: ").Append(EmergencyAccessSimultaneous).Append("\n");
      sb.Append("  RequiredReviewers: ").Append(RequiredReviewers).Append("\n");
      sb.Append("  ChangePasswordAfterRelease: ").Append(ChangePasswordAfterRelease).Append("\n");
      sb.Append("  ChangeSshKeyAfterRelease: ").Append(ChangeSshKeyAfterRelease).Append("\n");
      sb.Append("  AllowSessionPasswordRelease: ").Append(AllowSessionPasswordRelease).Append("\n");
      sb.Append("  AllowSessionSshKeyRelease: ").Append(AllowSessionSshKeyRelease).Append("\n");
      sb.Append("  MaximumSimultaneousReleases: ").Append(MaximumSimultaneousReleases).Append("\n");
      sb.Append("  PendingReviewDurationBeforeEscalationDays: ").Append(PendingReviewDurationBeforeEscalationDays).Append("\n");
      sb.Append("  PendingReviewDurationBeforeEscalationHours: ").Append(PendingReviewDurationBeforeEscalationHours).Append("\n");
      sb.Append("  PendingReviewDurationBeforeEscalationMinutes: ").Append(PendingReviewDurationBeforeEscalationMinutes).Append("\n");
      sb.Append("  PendingApprovalDurationBeforeEscalationDays: ").Append(PendingApprovalDurationBeforeEscalationDays).Append("\n");
      sb.Append("  PendingApprovalDurationBeforeEscalationHours: ").Append(PendingApprovalDurationBeforeEscalationHours).Append("\n");
      sb.Append("  PendingApprovalDurationBeforeEscalationMinutes: ").Append(PendingApprovalDurationBeforeEscalationMinutes).Append("\n");
      sb.Append("  Reviewers: ").Append(Reviewers).Append("\n");
      sb.Append("  ApproverSets: ").Append(ApproverSets).Append("\n");
      sb.Append("  RequestState: ").Append(RequestState).Append("\n");
      sb.Append("  SessionProperties: ").Append(SessionProperties).Append("\n");
      sb.Append("  BrokerId: ").Append(BrokerId).Append("\n");
      sb.Append("  BrokerName: ").Append(BrokerName).Append("\n");
      sb.Append("  AllowSraSessionLaunch: ").Append(AllowSraSessionLaunch).Append("\n");
      sb.Append("  ApplicationSessionProperties: ").Append(ApplicationSessionProperties).Append("\n");
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
