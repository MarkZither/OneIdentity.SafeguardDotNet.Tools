using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A saved access request that can be used in a user request favorite
  /// </summary>
  [DataContract]
  public class SavedAccessRequest {
    /// <summary>
    /// Database ID of asset to request access to
    /// </summary>
    /// <value>Database ID of asset to request access to</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Database ID of the account to request password for (or access account for sessions)
    /// </summary>
    /// <value>Database ID of the account to request password for (or access account for sessions)</value>
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
    /// Name of the asset to request access for
    /// </summary>
    /// <value>Name of the asset to request access for</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Gets or Sets AccessRequestType
    /// </summary>
    [DataMember(Name="AccessRequestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessRequestType")]
    public AccessRequestType AccessRequestType { get; set; }

    /// <summary>
    /// Whether emergency access is being requested
    /// </summary>
    /// <value>Whether emergency access is being requested</value>
    [DataMember(Name="IsEmergency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsEmergency")]
    public bool? IsEmergency { get; set; }

    /// <summary>
    /// Database ID of the pre-defined reason code for why the password access is needed
    /// </summary>
    /// <value>Database ID of the pre-defined reason code for why the password access is needed</value>
    [DataMember(Name="ReasonCodeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonCodeId")]
    public int? ReasonCodeId { get; set; }

    /// <summary>
    /// Name of the pre-defined reason code for why the password access is needed
    /// </summary>
    /// <value>Name of the pre-defined reason code for why the password access is needed</value>
    [DataMember(Name="ReasonCodeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonCodeName")]
    public string ReasonCodeName { get; set; }

    /// <summary>
    /// Requester's reason of why the password access is needed
    /// </summary>
    /// <value>Requester's reason of why the password access is needed</value>
    [DataMember(Name="ReasonComment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonComment")]
    public string ReasonComment { get; set; }

    /// <summary>
    /// The number of days requested for password access. The sum of Requested Days/Hours/Minutes must not exceed 7 days.
    /// </summary>
    /// <value>The number of days requested for password access. The sum of Requested Days/Hours/Minutes must not exceed 7 days.</value>
    [DataMember(Name="RequestedDurationDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestedDurationDays")]
    public int? RequestedDurationDays { get; set; }

    /// <summary>
    /// The number of hours requested for password access. The sum of Requested Days/Hours/Minutes must not exceed 7 days.
    /// </summary>
    /// <value>The number of hours requested for password access. The sum of Requested Days/Hours/Minutes must not exceed 7 days.</value>
    [DataMember(Name="RequestedDurationHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestedDurationHours")]
    public int? RequestedDurationHours { get; set; }

    /// <summary>
    /// The number of minutes requested for password access. The sum of Requested Days/Hours/Minutes must not exceed 7 days.
    /// </summary>
    /// <value>The number of minutes requested for password access. The sum of Requested Days/Hours/Minutes must not exceed 7 days.</value>
    [DataMember(Name="RequestedDurationMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestedDurationMinutes")]
    public int? RequestedDurationMinutes { get; set; }

    /// <summary>
    /// List of requests that are currently active
    /// </summary>
    /// <value>List of requests that are currently active</value>
    [DataMember(Name="ActiveRequests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ActiveRequests")]
    public List<ActiveRequest> ActiveRequests { get; set; }

    /// <summary>
    /// Gets or Sets AssetPlatformType
    /// </summary>
    [DataMember(Name="AssetPlatformType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPlatformType")]
    public PlatformType AssetPlatformType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SavedAccessRequest {\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
      sb.Append("  AccountAssetId: ").Append(AccountAssetId).Append("\n");
      sb.Append("  AccountAssetName: ").Append(AccountAssetName).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  AccessRequestType: ").Append(AccessRequestType).Append("\n");
      sb.Append("  IsEmergency: ").Append(IsEmergency).Append("\n");
      sb.Append("  ReasonCodeId: ").Append(ReasonCodeId).Append("\n");
      sb.Append("  ReasonCodeName: ").Append(ReasonCodeName).Append("\n");
      sb.Append("  ReasonComment: ").Append(ReasonComment).Append("\n");
      sb.Append("  RequestedDurationDays: ").Append(RequestedDurationDays).Append("\n");
      sb.Append("  RequestedDurationHours: ").Append(RequestedDurationHours).Append("\n");
      sb.Append("  RequestedDurationMinutes: ").Append(RequestedDurationMinutes).Append("\n");
      sb.Append("  ActiveRequests: ").Append(ActiveRequests).Append("\n");
      sb.Append("  AssetPlatformType: ").Append(AssetPlatformType).Append("\n");
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
