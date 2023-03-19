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
  public class AccessRequest {
    /// <summary>
    /// Gets or Sets AccessRequestType
    /// </summary>
    [DataMember(Name="AccessRequestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessRequestType")]
    public AccessRequestType AccessRequestType { get; set; }

    /// <summary>
    /// Database ID of the account being requested
    /// </summary>
    /// <value>Database ID of the account being requested</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Name of the account being requested
    /// </summary>
    /// <value>Name of the account being requested</value>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Name of the domain of the account
    /// </summary>
    /// <value>Name of the domain of the account</value>
    [DataMember(Name="AccountDomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDomainName")]
    public string AccountDomainName { get; set; }

    /// <summary>
    /// Database ID of the asset of the account
    /// </summary>
    /// <value>Database ID of the asset of the account</value>
    [DataMember(Name="AccountAssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountAssetId")]
    public int? AccountAssetId { get; set; }

    /// <summary>
    /// Name of the asset of the account
    /// </summary>
    /// <value>Name of the asset of the account</value>
    [DataMember(Name="AccountAssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountAssetName")]
    public string AccountAssetName { get; set; }

    /// <summary>
    /// Gets or Sets AccountRequestType
    /// </summary>
    [DataMember(Name="AccountRequestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountRequestType")]
    public AccountRequestType AccountRequestType { get; set; }

    /// <summary>
    /// {true} when the access request was approved by the current authenticated user
    /// </summary>
    /// <value>{true} when the access request was approved by the current authenticated user</value>
    [DataMember(Name="ApprovedByMe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApprovedByMe")]
    public bool? ApprovedByMe { get; set; }

    /// <summary>
    /// Database ID of the asset to request access for
    /// </summary>
    /// <value>Database ID of the asset to request access for</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Name of the asset to request access for
    /// </summary>
    /// <value>Name of the asset to request access for</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Network address of the asset to request access for
    /// </summary>
    /// <value>Network address of the asset to request access for</value>
    [DataMember(Name="AssetNetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetNetworkAddress")]
    public string AssetNetworkAddress { get; set; }

    /// <summary>
    /// SSH host key of the asset to request access for
    /// </summary>
    /// <value>SSH host key of the asset to request access for</value>
    [DataMember(Name="AssetSshHostKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetSshHostKey")]
    public string AssetSshHostKey { get; set; }

    /// <summary>
    /// The UTC Date/Time the access request was created
    /// </summary>
    /// <value>The UTC Date/Time the access request was created</value>
    [DataMember(Name="CreatedOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedOn")]
    public DateTime? CreatedOn { get; set; }

    /// <summary>
    /// The current number of approvals for the access request
    /// </summary>
    /// <value>The current number of approvals for the access request</value>
    [DataMember(Name="CurrentApprovalCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CurrentApprovalCount")]
    public int? CurrentApprovalCount { get; set; }

    /// <summary>
    /// The current number of reviews for the access request
    /// </summary>
    /// <value>The current number of reviews for the access request</value>
    [DataMember(Name="CurrentReviewerCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CurrentReviewerCount")]
    public int? CurrentReviewerCount { get; set; }

    /// <summary>
    /// The duration of the request in minutes.
    /// </summary>
    /// <value>The duration of the request in minutes.</value>
    [DataMember(Name="DurationInMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DurationInMinutes")]
    public int? DurationInMinutes { get; set; }

    /// <summary>
    /// The UTC Date/Time the access request will expire
    /// </summary>
    /// <value>The UTC Date/Time the access request will expire</value>
    [DataMember(Name="ExpiresOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExpiresOn")]
    public DateTime? ExpiresOn { get; set; }

    /// <summary>
    /// Qualified ID of the access request
    /// </summary>
    /// <value>Qualified ID of the access request</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// {true} when the access request was submitted as being an emergency
    /// </summary>
    /// <value>{true} when the access request was submitted as being an emergency</value>
    [DataMember(Name="IsEmergency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsEmergency")]
    public bool? IsEmergency { get; set; }

    /// <summary>
    /// {true} when the requester needs to acknowledge the access request before it will be \"closed\"
    /// </summary>
    /// <value>{true} when the requester needs to acknowledge the access request before it will be \"closed\"</value>
    [DataMember(Name="NeedsAcknowledgement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NeedsAcknowledgement")]
    public bool? NeedsAcknowledgement { get; set; }

    /// <summary>
    /// DateTimes when the request is available for access.
    /// </summary>
    /// <value>DateTimes when the request is available for access.</value>
    [DataMember(Name="RequestAvailability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestAvailability")]
    public List<DateTimeInterval> RequestAvailability { get; set; }

    /// <summary>
    /// Gets or Sets ReasonCode
    /// </summary>
    [DataMember(Name="ReasonCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonCode")]
    public ReasonCode ReasonCode { get; set; }

    /// <summary>
    /// Description of why the access request is needed
    /// </summary>
    /// <value>Description of why the access request is needed</value>
    [DataMember(Name="ReasonComment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonComment")]
    public string ReasonComment { get; set; }

    /// <summary>
    /// The duration of the access request (days)
    /// </summary>
    /// <value>The duration of the access request (days)</value>
    [DataMember(Name="RequestedDurationDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestedDurationDays")]
    public int? RequestedDurationDays { get; set; }

    /// <summary>
    /// The duration of the access request (hours)
    /// </summary>
    /// <value>The duration of the access request (hours)</value>
    [DataMember(Name="RequestedDurationHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestedDurationHours")]
    public int? RequestedDurationHours { get; set; }

    /// <summary>
    /// The duration of the access request (minutes)
    /// </summary>
    /// <value>The duration of the access request (minutes)</value>
    [DataMember(Name="RequestedDurationMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestedDurationMinutes")]
    public int? RequestedDurationMinutes { get; set; }

    /// <summary>
    /// The UTC Date/Time the access request becomes active
    /// </summary>
    /// <value>The UTC Date/Time the access request becomes active</value>
    [DataMember(Name="RequestedFor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestedFor")]
    public DateTime? RequestedFor { get; set; }

    /// <summary>
    /// Display name of the user that made the access request
    /// </summary>
    /// <value>Display name of the user that made the access request</value>
    [DataMember(Name="RequesterDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterDisplayName")]
    public string RequesterDisplayName { get; set; }

    /// <summary>
    /// Email address of the user that made the access request
    /// </summary>
    /// <value>Email address of the user that made the access request</value>
    [DataMember(Name="RequesterEmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterEmailAddress")]
    public string RequesterEmailAddress { get; set; }

    /// <summary>
    /// Database ID of the user that made the access request
    /// </summary>
    /// <value>Database ID of the user that made the access request</value>
    [DataMember(Name="RequesterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterId")]
    public int? RequesterId { get; set; }

    /// <summary>
    /// Number of approvals required before the access request can become available
    /// </summary>
    /// <value>Number of approvals required before the access request can become available</value>
    [DataMember(Name="RequiredApprovalCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequiredApprovalCount")]
    public int? RequiredApprovalCount { get; set; }

    /// <summary>
    /// Number of reviews required before the access request can be closed
    /// </summary>
    /// <value>Number of reviews required before the access request can be closed</value>
    [DataMember(Name="RequiredReviewerCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequiredReviewerCount")]
    public int? RequiredReviewerCount { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="State", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "State")]
    public AccessRequestState State { get; set; }

    /// <summary>
    /// The UTC date/time the Pangaea.Data.Transfer.V4.AccessRequestWorkflow.AccessRequest.State changed
    /// </summary>
    /// <value>The UTC date/time the Pangaea.Data.Transfer.V4.AccessRequestWorkflow.AccessRequest.State changed</value>
    [DataMember(Name="StateChangedOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StateChangedOn")]
    public DateTime? StateChangedOn { get; set; }

    /// <summary>
    /// Number of the help desk ticket as required by policy
    /// </summary>
    /// <value>Number of the help desk ticket as required by policy</value>
    [DataMember(Name="TicketNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TicketNumber")]
    public string TicketNumber { get; set; }

    /// <summary>
    /// {true} when the access request was cancelled by the requester
    /// </summary>
    /// <value>{true} when the access request was cancelled by the requester</value>
    [DataMember(Name="WasCancelled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasCancelled")]
    public bool? WasCancelled { get; set; }

    /// <summary>
    /// {true} when the access was checked out by the requester
    /// </summary>
    /// <value>{true} when the access was checked out by the requester</value>
    [DataMember(Name="WasCheckedOut", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasCheckedOut")]
    public bool? WasCheckedOut { get; set; }

    /// <summary>
    /// {true} when the access request was denied by an approver before the request was approved
    /// </summary>
    /// <value>{true} when the access request was denied by an approver before the request was approved</value>
    [DataMember(Name="WasDenied", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasDenied")]
    public bool? WasDenied { get; set; }

    /// <summary>
    /// {true} when the access request was closed due the requester being deleted or disabled.
    /// </summary>
    /// <value>{true} when the access request was closed due the requester being deleted or disabled.</value>
    [DataMember(Name="WasEvicted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasEvicted")]
    public bool? WasEvicted { get; set; }

    /// <summary>
    /// {true} when the access request expired as defined by {ExpirationUtcDateTime}
    /// </summary>
    /// <value>{true} when the access request expired as defined by {ExpirationUtcDateTime}</value>
    [DataMember(Name="WasExpired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasExpired")]
    public bool? WasExpired { get; set; }

    /// <summary>
    /// {true} when the access request was revoked by an approver after the request was approved
    /// </summary>
    /// <value>{true} when the access request was revoked by an approver after the request was approved</value>
    [DataMember(Name="WasRevoked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WasRevoked")]
    public bool? WasRevoked { get; set; }

    /// <summary>
    /// Actions that have occurred to the access request
    /// </summary>
    /// <value>Actions that have occurred to the access request</value>
    [DataMember(Name="WorkflowActions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WorkflowActions")]
    public List<AccessRequestWorkflowAction> WorkflowActions { get; set; }

    /// <summary>
    /// Database ID of the winning access policy for this request
    /// </summary>
    /// <value>Database ID of the winning access policy for this request</value>
    [DataMember(Name="PolicyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyId")]
    public int? PolicyId { get; set; }

    /// <summary>
    /// Name of the winning access policy for this request
    /// </summary>
    /// <value>Name of the winning access policy for this request</value>
    [DataMember(Name="PolicyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyName")]
    public string PolicyName { get; set; }

    /// <summary>
    /// Whether a reviewer is required to supply a comment
    /// </summary>
    /// <value>Whether a reviewer is required to supply a comment</value>
    [DataMember(Name="RequireReviewerComment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequireReviewerComment")]
    public bool? RequireReviewerComment { get; set; }

    /// <summary>
    /// Whether SRA remote sessions are enabled
    /// </summary>
    /// <value>Whether SRA remote sessions are enabled</value>
    [DataMember(Name="AllowSraSessionLaunch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSraSessionLaunch")]
    public bool? AllowSraSessionLaunch { get; set; }

    /// <summary>
    /// Whether password checkouts are allowed for session requests
    /// </summary>
    /// <value>Whether password checkouts are allowed for session requests</value>
    [DataMember(Name="AllowSessionPasswordRelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSessionPasswordRelease")]
    public bool? AllowSessionPasswordRelease { get; set; }

    /// <summary>
    /// Information about sessions initialized using this request
    /// </summary>
    /// <value>Information about sessions initialized using this request</value>
    [DataMember(Name="Sessions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Sessions")]
    public List<AccessRequestSession> Sessions { get; set; }

    /// <summary>
    /// Whether this policy will allow bypassing any pending reviews in order to create new requests.
    /// </summary>
    /// <value>Whether this policy will allow bypassing any pending reviews in order to create new requests.</value>
    [DataMember(Name="AllowSubsequentAccessRequestsWithoutReview", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSubsequentAccessRequestsWithoutReview")]
    public bool? AllowSubsequentAccessRequestsWithoutReview { get; set; }

    /// <summary>
    /// External session module connection ID
    /// </summary>
    /// <value>External session module connection ID</value>
    [DataMember(Name="SessionModuleConnectionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionModuleConnectionId")]
    public int? SessionModuleConnectionId { get; set; }

    /// <summary>
    /// External session connection policy reference
    /// </summary>
    /// <value>External session connection policy reference</value>
    [DataMember(Name="SessionConnectionPolicyRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionConnectionPolicyRef")]
    public string SessionConnectionPolicyRef { get; set; }

    /// <summary>
    /// Username of the user that made the access request
    /// </summary>
    /// <value>Username of the user that made the access request</value>
    [DataMember(Name="RequesterUsername", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterUsername")]
    public string RequesterUsername { get; set; }

    /// <summary>
    /// Whether SSH key checkouts are allowed for session requests
    /// </summary>
    /// <value>Whether SSH key checkouts are allowed for session requests</value>
    [DataMember(Name="AllowSessionSshKeyRelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSessionSshKeyRelease")]
    public bool? AllowSessionSshKeyRelease { get; set; }

    /// <summary>
    /// DistinguishedName of the account
    /// </summary>
    /// <value>DistinguishedName of the account</value>
    [DataMember(Name="AccountDistinguishedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDistinguishedName")]
    public string AccountDistinguishedName { get; set; }

    /// <summary>
    /// Platform ID of the asset to request access for
    /// </summary>
    /// <value>Platform ID of the asset to request access for</value>
    [DataMember(Name="AssetPlatformId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPlatformId")]
    public int? AssetPlatformId { get; set; }

    /// <summary>
    /// Gets or Sets AssetPlatformType
    /// </summary>
    [DataMember(Name="AssetPlatformType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPlatformType")]
    public PlatformType AssetPlatformType { get; set; }

    /// <summary>
    /// Platform display name of the asset to request access for
    /// </summary>
    /// <value>Platform display name of the asset to request access for</value>
    [DataMember(Name="AssetPlatformDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPlatformDisplayName")]
    public string AssetPlatformDisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessRequest {\n");
      sb.Append("  AccessRequestType: ").Append(AccessRequestType).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
      sb.Append("  AccountAssetId: ").Append(AccountAssetId).Append("\n");
      sb.Append("  AccountAssetName: ").Append(AccountAssetName).Append("\n");
      sb.Append("  AccountRequestType: ").Append(AccountRequestType).Append("\n");
      sb.Append("  ApprovedByMe: ").Append(ApprovedByMe).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  AssetNetworkAddress: ").Append(AssetNetworkAddress).Append("\n");
      sb.Append("  AssetSshHostKey: ").Append(AssetSshHostKey).Append("\n");
      sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
      sb.Append("  CurrentApprovalCount: ").Append(CurrentApprovalCount).Append("\n");
      sb.Append("  CurrentReviewerCount: ").Append(CurrentReviewerCount).Append("\n");
      sb.Append("  DurationInMinutes: ").Append(DurationInMinutes).Append("\n");
      sb.Append("  ExpiresOn: ").Append(ExpiresOn).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsEmergency: ").Append(IsEmergency).Append("\n");
      sb.Append("  NeedsAcknowledgement: ").Append(NeedsAcknowledgement).Append("\n");
      sb.Append("  RequestAvailability: ").Append(RequestAvailability).Append("\n");
      sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
      sb.Append("  ReasonComment: ").Append(ReasonComment).Append("\n");
      sb.Append("  RequestedDurationDays: ").Append(RequestedDurationDays).Append("\n");
      sb.Append("  RequestedDurationHours: ").Append(RequestedDurationHours).Append("\n");
      sb.Append("  RequestedDurationMinutes: ").Append(RequestedDurationMinutes).Append("\n");
      sb.Append("  RequestedFor: ").Append(RequestedFor).Append("\n");
      sb.Append("  RequesterDisplayName: ").Append(RequesterDisplayName).Append("\n");
      sb.Append("  RequesterEmailAddress: ").Append(RequesterEmailAddress).Append("\n");
      sb.Append("  RequesterId: ").Append(RequesterId).Append("\n");
      sb.Append("  RequiredApprovalCount: ").Append(RequiredApprovalCount).Append("\n");
      sb.Append("  RequiredReviewerCount: ").Append(RequiredReviewerCount).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  StateChangedOn: ").Append(StateChangedOn).Append("\n");
      sb.Append("  TicketNumber: ").Append(TicketNumber).Append("\n");
      sb.Append("  WasCancelled: ").Append(WasCancelled).Append("\n");
      sb.Append("  WasCheckedOut: ").Append(WasCheckedOut).Append("\n");
      sb.Append("  WasDenied: ").Append(WasDenied).Append("\n");
      sb.Append("  WasEvicted: ").Append(WasEvicted).Append("\n");
      sb.Append("  WasExpired: ").Append(WasExpired).Append("\n");
      sb.Append("  WasRevoked: ").Append(WasRevoked).Append("\n");
      sb.Append("  WorkflowActions: ").Append(WorkflowActions).Append("\n");
      sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
      sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
      sb.Append("  RequireReviewerComment: ").Append(RequireReviewerComment).Append("\n");
      sb.Append("  AllowSraSessionLaunch: ").Append(AllowSraSessionLaunch).Append("\n");
      sb.Append("  AllowSessionPasswordRelease: ").Append(AllowSessionPasswordRelease).Append("\n");
      sb.Append("  Sessions: ").Append(Sessions).Append("\n");
      sb.Append("  AllowSubsequentAccessRequestsWithoutReview: ").Append(AllowSubsequentAccessRequestsWithoutReview).Append("\n");
      sb.Append("  SessionModuleConnectionId: ").Append(SessionModuleConnectionId).Append("\n");
      sb.Append("  SessionConnectionPolicyRef: ").Append(SessionConnectionPolicyRef).Append("\n");
      sb.Append("  RequesterUsername: ").Append(RequesterUsername).Append("\n");
      sb.Append("  AllowSessionSshKeyRelease: ").Append(AllowSessionSshKeyRelease).Append("\n");
      sb.Append("  AccountDistinguishedName: ").Append(AccountDistinguishedName).Append("\n");
      sb.Append("  AssetPlatformId: ").Append(AssetPlatformId).Append("\n");
      sb.Append("  AssetPlatformType: ").Append(AssetPlatformType).Append("\n");
      sb.Append("  AssetPlatformDisplayName: ").Append(AssetPlatformDisplayName).Append("\n");
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
