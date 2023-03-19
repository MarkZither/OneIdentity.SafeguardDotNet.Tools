using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents security configuration governing the access to assets and accounts
  /// </summary>
  [DataContract]
  public class AccessPolicy {
    /// <summary>
    /// The database ID of the policy (Read-only)
    /// </summary>
    /// <value>The database ID of the policy (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the policy
    /// </summary>
    /// <value>The name of the policy</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// The description of the policy
    /// </summary>
    /// <value>The description of the policy</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Database ID of the role this policy is assigned to
    /// </summary>
    /// <value>Database ID of the role this policy is assigned to</value>
    [DataMember(Name="RoleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleId")]
    public int? RoleId { get; set; }

    /// <summary>
    /// Name of the role this policy is assigned to (Read-only)
    /// </summary>
    /// <value>Name of the role this policy is assigned to (Read-only)</value>
    [DataMember(Name="RoleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleName")]
    public string RoleName { get; set; }

    /// <summary>
    /// Priority of the role this policy is assigned to (Read-only)
    /// </summary>
    /// <value>Priority of the role this policy is assigned to (Read-only)</value>
    [DataMember(Name="RolePriority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RolePriority")]
    public int? RolePriority { get; set; }

    /// <summary>
    /// The priority of this policy compared to other policies in this role  Set to 0 to add as the lowest priority policy. Default is max role priority plus 1.
    /// </summary>
    /// <value>The priority of this policy compared to other policies in this role  Set to 0 to add as the lowest priority policy. Default is max role priority plus 1.</value>
    [DataMember(Name="Priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Number of accounts that have been assigned to this policy
    /// </summary>
    /// <value>Number of accounts that have been assigned to this policy</value>
    [DataMember(Name="AccountCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountCount")]
    public int? AccountCount { get; set; }

    /// <summary>
    /// Number of assets that have been assigned to this policy
    /// </summary>
    /// <value>Number of assets that have been assigned to this policy</value>
    [DataMember(Name="AssetCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetCount")]
    public int? AssetCount { get; set; }

    /// <summary>
    /// Number of account groups that have been assigned to this policy
    /// </summary>
    /// <value>Number of account groups that have been assigned to this policy</value>
    [DataMember(Name="AccountGroupCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountGroupCount")]
    public int? AccountGroupCount { get; set; }

    /// <summary>
    /// Number of asset groups that have been assigned to this policy
    /// </summary>
    /// <value>Number of asset groups that have been assigned to this policy</value>
    [DataMember(Name="AssetGroupCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetGroupCount")]
    public int? AssetGroupCount { get; set; }

    /// <summary>
    /// Date this entity was created (Read-only)
    /// </summary>
    /// <value>Date this entity was created (Read-only)</value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The database ID of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The database ID of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserId")]
    public int? CreatedByUserId { get; set; }

    /// <summary>
    /// The display name of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The display name of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserDisplayName")]
    public string CreatedByUserDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets RequesterProperties
    /// </summary>
    [DataMember(Name="RequesterProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterProperties")]
    public PolicyRequesterProperties RequesterProperties { get; set; }

    /// <summary>
    /// Gets or Sets ApproverProperties
    /// </summary>
    [DataMember(Name="ApproverProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApproverProperties")]
    public PolicyApproverProperties ApproverProperties { get; set; }

    /// <summary>
    /// Gets or Sets ReviewerProperties
    /// </summary>
    [DataMember(Name="ReviewerProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReviewerProperties")]
    public PolicyReviewerProperties ReviewerProperties { get; set; }

    /// <summary>
    /// Gets or Sets AccessRequestProperties
    /// </summary>
    [DataMember(Name="AccessRequestProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessRequestProperties")]
    public AccessRequestProperties AccessRequestProperties { get; set; }

    /// <summary>
    /// Gets or Sets SessionProperties
    /// </summary>
    [DataMember(Name="SessionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionProperties")]
    public SessionProperties SessionProperties { get; set; }

    /// <summary>
    /// Gets or Sets EmergencyAccessProperties
    /// </summary>
    [DataMember(Name="EmergencyAccessProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmergencyAccessProperties")]
    public PolicyEmergencyAccessProperties EmergencyAccessProperties { get; set; }

    /// <summary>
    /// Sets of approvers required to approve requests granted by this policy
    /// </summary>
    /// <value>Sets of approvers required to approve requests granted by this policy</value>
    [DataMember(Name="ApproverSets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApproverSets")]
    public List<ApproverSet> ApproverSets { get; set; }

    /// <summary>
    /// List of identities allowed to review requests allowed by this policy
    /// </summary>
    /// <value>List of identities allowed to review requests allowed by this policy</value>
    [DataMember(Name="Reviewers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Reviewers")]
    public List<Identity> Reviewers { get; set; }

    /// <summary>
    /// List of contacts that will be notified when requests need to be escalated, etc.
    /// </summary>
    /// <value>List of contacts that will be notified when requests need to be escalated, etc.</value>
    [DataMember(Name="NotificationContacts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NotificationContacts")]
    public List<NotificationContact> NotificationContacts { get; set; }

    /// <summary>
    /// List of reason codes that may be used when making password requests
    /// </summary>
    /// <value>List of reason codes that may be used when making password requests</value>
    [DataMember(Name="ReasonCodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonCodes")]
    public List<ReasonCode> ReasonCodes { get; set; }

    /// <summary>
    /// List of scope items that be requested by this policy
    /// </summary>
    /// <value>List of scope items that be requested by this policy</value>
    [DataMember(Name="ScopeItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScopeItems")]
    public List<PolicyScopeItem> ScopeItems { get; set; }

    /// <summary>
    /// Date/time after which the associated policy/role will cease to be active
    /// </summary>
    /// <value>Date/time after which the associated policy/role will cease to be active</value>
    [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExpirationDate")]
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Whether this policy is expired.  (Read-only)
    /// </summary>
    /// <value>Whether this policy is expired.  (Read-only)</value>
    [DataMember(Name="IsExpired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsExpired")]
    public bool? IsExpired { get; set; }

    /// <summary>
    /// Whether this policy has an invalid connection policy.
    /// </summary>
    /// <value>Whether this policy has an invalid connection policy.</value>
    [DataMember(Name="InvalidConnectionPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvalidConnectionPolicy")]
    public bool? InvalidConnectionPolicy { get; set; }

    /// <summary>
    /// Gets or Sets HourlyRestrictionProperties
    /// </summary>
    [DataMember(Name="HourlyRestrictionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HourlyRestrictionProperties")]
    public HourlyRestrictionProperties HourlyRestrictionProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessPolicy {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  RoleId: ").Append(RoleId).Append("\n");
      sb.Append("  RoleName: ").Append(RoleName).Append("\n");
      sb.Append("  RolePriority: ").Append(RolePriority).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  AccountCount: ").Append(AccountCount).Append("\n");
      sb.Append("  AssetCount: ").Append(AssetCount).Append("\n");
      sb.Append("  AccountGroupCount: ").Append(AccountGroupCount).Append("\n");
      sb.Append("  AssetGroupCount: ").Append(AssetGroupCount).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
      sb.Append("  RequesterProperties: ").Append(RequesterProperties).Append("\n");
      sb.Append("  ApproverProperties: ").Append(ApproverProperties).Append("\n");
      sb.Append("  ReviewerProperties: ").Append(ReviewerProperties).Append("\n");
      sb.Append("  AccessRequestProperties: ").Append(AccessRequestProperties).Append("\n");
      sb.Append("  SessionProperties: ").Append(SessionProperties).Append("\n");
      sb.Append("  EmergencyAccessProperties: ").Append(EmergencyAccessProperties).Append("\n");
      sb.Append("  ApproverSets: ").Append(ApproverSets).Append("\n");
      sb.Append("  Reviewers: ").Append(Reviewers).Append("\n");
      sb.Append("  NotificationContacts: ").Append(NotificationContacts).Append("\n");
      sb.Append("  ReasonCodes: ").Append(ReasonCodes).Append("\n");
      sb.Append("  ScopeItems: ").Append(ScopeItems).Append("\n");
      sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
      sb.Append("  IsExpired: ").Append(IsExpired).Append("\n");
      sb.Append("  InvalidConnectionPolicy: ").Append(InvalidConnectionPolicy).Append("\n");
      sb.Append("  HourlyRestrictionProperties: ").Append(HourlyRestrictionProperties).Append("\n");
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
