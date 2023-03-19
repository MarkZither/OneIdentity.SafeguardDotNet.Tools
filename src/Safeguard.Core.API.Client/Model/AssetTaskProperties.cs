using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Task information for an asset
  /// </summary>
  [DataContract]
  public class AssetTaskProperties {
    /// <summary>
    /// Whether this asset has any platform task failures (Read-only)
    /// </summary>
    /// <value>Whether this asset has any platform task failures (Read-only)</value>
    [DataMember(Name="HasAssetTaskFailure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasAssetTaskFailure")]
    public bool? HasAssetTaskFailure { get; set; }

    /// <summary>
    /// The date/time of the last account discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the last account discovery (Read-only)</value>
    [DataMember(Name="LastAccountDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastAccountDiscoveryDate")]
    public DateTime? LastAccountDiscoveryDate { get; set; }

    /// <summary>
    /// The date/time of the last successful account discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful account discovery (Read-only)</value>
    [DataMember(Name="LastSuccessAccountDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessAccountDiscoveryDate")]
    public DateTime? LastSuccessAccountDiscoveryDate { get; set; }

    /// <summary>
    /// The date/time of the last failed account discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed account discovery (Read-only)</value>
    [DataMember(Name="LastFailureAccountDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureAccountDiscoveryDate")]
    public DateTime? LastFailureAccountDiscoveryDate { get; set; }

    /// <summary>
    /// Number of subsequent failed account discovery attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed account discovery attempts since last success (Read-only)</value>
    [DataMember(Name="FailedAccountDiscoveryAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedAccountDiscoveryAttempts")]
    public int? FailedAccountDiscoveryAttempts { get; set; }

    /// <summary>
    /// The date/time of the next account discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the next account discovery (Read-only)</value>
    [DataMember(Name="NextAccountDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextAccountDiscoveryDate")]
    public DateTime? NextAccountDiscoveryDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last account discovery (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last account discovery (Read-only)</value>
    [DataMember(Name="LastAccountDiscoveryTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastAccountDiscoveryTaskId")]
    public string LastAccountDiscoveryTaskId { get; set; }

    /// <summary>
    /// The date/time of the last service discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the last service discovery (Read-only)</value>
    [DataMember(Name="LastServiceDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastServiceDiscoveryDate")]
    public DateTime? LastServiceDiscoveryDate { get; set; }

    /// <summary>
    /// The date/time of the last successful service discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful service discovery (Read-only)</value>
    [DataMember(Name="LastSuccessServiceDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessServiceDiscoveryDate")]
    public DateTime? LastSuccessServiceDiscoveryDate { get; set; }

    /// <summary>
    /// The date/time of the last failed service discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed service discovery (Read-only)</value>
    [DataMember(Name="LastFailureServiceDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureServiceDiscoveryDate")]
    public DateTime? LastFailureServiceDiscoveryDate { get; set; }

    /// <summary>
    /// Number of subsequent failed service discovery attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed service discovery attempts since last success (Read-only)</value>
    [DataMember(Name="FailedServiceDiscoveryAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedServiceDiscoveryAttempts")]
    public int? FailedServiceDiscoveryAttempts { get; set; }

    /// <summary>
    /// The date/time of the next service discovery (Read-only)
    /// </summary>
    /// <value>The date/time of the next service discovery (Read-only)</value>
    [DataMember(Name="NextServiceDiscoveryDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextServiceDiscoveryDate")]
    public DateTime? NextServiceDiscoveryDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last service discovery (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last service discovery (Read-only)</value>
    [DataMember(Name="LastServiceDiscoveryTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastServiceDiscoveryTaskId")]
    public string LastServiceDiscoveryTaskId { get; set; }

    /// <summary>
    /// The date/time of the test connection (Read-only)
    /// </summary>
    /// <value>The date/time of the test connection (Read-only)</value>
    [DataMember(Name="LastTestConnectionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastTestConnectionDate")]
    public DateTime? LastTestConnectionDate { get; set; }

    /// <summary>
    /// The date/time of the last successful test connection (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful test connection (Read-only)</value>
    [DataMember(Name="LastSuccessTestConnectionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessTestConnectionDate")]
    public DateTime? LastSuccessTestConnectionDate { get; set; }

    /// <summary>
    /// The date/time of the last failed test connnection (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed test connnection (Read-only)</value>
    [DataMember(Name="LastFailureTestConnectionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureTestConnectionDate")]
    public DateTime? LastFailureTestConnectionDate { get; set; }

    /// <summary>
    /// Number of subsequent failed test connection attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed test connection attempts since last success (Read-only)</value>
    [DataMember(Name="FailedTestConnectionAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedTestConnectionAttempts")]
    public int? FailedTestConnectionAttempts { get; set; }

    /// <summary>
    /// The date/time of the next test connection, if this Service is enabled for automatic password management (Read-only)
    /// </summary>
    /// <value>The date/time of the next test connection, if this Service is enabled for automatic password management (Read-only)</value>
    [DataMember(Name="NextTestConnectionDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextTestConnectionDate")]
    public DateTime? NextTestConnectionDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last test connection (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last test connection (Read-only)</value>
    [DataMember(Name="LastTestConnectionTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastTestConnectionTaskId")]
    public string LastTestConnectionTaskId { get; set; }

    /// <summary>
    /// The date/time of the dependent service update (Read-only)
    /// </summary>
    /// <value>The date/time of the dependent service update (Read-only)</value>
    [DataMember(Name="LastDependentServiceUpdateDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastDependentServiceUpdateDate")]
    public DateTime? LastDependentServiceUpdateDate { get; set; }

    /// <summary>
    /// The date/time of the last successful dependent service update (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful dependent service update (Read-only)</value>
    [DataMember(Name="LastSuccessDependentServiceUpdateDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessDependentServiceUpdateDate")]
    public DateTime? LastSuccessDependentServiceUpdateDate { get; set; }

    /// <summary>
    /// The date/time of the last failed dependent service update (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed dependent service update (Read-only)</value>
    [DataMember(Name="LastFailureDependentServiceUpdateDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureDependentServiceUpdateDate")]
    public DateTime? LastFailureDependentServiceUpdateDate { get; set; }

    /// <summary>
    /// Number of subsequent failed dependent service update attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed dependent service update attempts since last success (Read-only)</value>
    [DataMember(Name="FailedDependentServiceUpdateAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedDependentServiceUpdateAttempts")]
    public int? FailedDependentServiceUpdateAttempts { get; set; }

    /// <summary>
    /// The date/time of the next dependent service update, if this Service is enabled for automatic password management (Read-only)
    /// </summary>
    /// <value>The date/time of the next dependent service update, if this Service is enabled for automatic password management (Read-only)</value>
    [DataMember(Name="NextDependentServiceUpdateDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextDependentServiceUpdateDate")]
    public DateTime? NextDependentServiceUpdateDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last dependent service update (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last dependent service update (Read-only)</value>
    [DataMember(Name="LastDependentServiceUpdateTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastDependentServiceUpdateTaskId")]
    public string LastDependentServiceUpdateTaskId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetTaskProperties {\n");
      sb.Append("  HasAssetTaskFailure: ").Append(HasAssetTaskFailure).Append("\n");
      sb.Append("  LastAccountDiscoveryDate: ").Append(LastAccountDiscoveryDate).Append("\n");
      sb.Append("  LastSuccessAccountDiscoveryDate: ").Append(LastSuccessAccountDiscoveryDate).Append("\n");
      sb.Append("  LastFailureAccountDiscoveryDate: ").Append(LastFailureAccountDiscoveryDate).Append("\n");
      sb.Append("  FailedAccountDiscoveryAttempts: ").Append(FailedAccountDiscoveryAttempts).Append("\n");
      sb.Append("  NextAccountDiscoveryDate: ").Append(NextAccountDiscoveryDate).Append("\n");
      sb.Append("  LastAccountDiscoveryTaskId: ").Append(LastAccountDiscoveryTaskId).Append("\n");
      sb.Append("  LastServiceDiscoveryDate: ").Append(LastServiceDiscoveryDate).Append("\n");
      sb.Append("  LastSuccessServiceDiscoveryDate: ").Append(LastSuccessServiceDiscoveryDate).Append("\n");
      sb.Append("  LastFailureServiceDiscoveryDate: ").Append(LastFailureServiceDiscoveryDate).Append("\n");
      sb.Append("  FailedServiceDiscoveryAttempts: ").Append(FailedServiceDiscoveryAttempts).Append("\n");
      sb.Append("  NextServiceDiscoveryDate: ").Append(NextServiceDiscoveryDate).Append("\n");
      sb.Append("  LastServiceDiscoveryTaskId: ").Append(LastServiceDiscoveryTaskId).Append("\n");
      sb.Append("  LastTestConnectionDate: ").Append(LastTestConnectionDate).Append("\n");
      sb.Append("  LastSuccessTestConnectionDate: ").Append(LastSuccessTestConnectionDate).Append("\n");
      sb.Append("  LastFailureTestConnectionDate: ").Append(LastFailureTestConnectionDate).Append("\n");
      sb.Append("  FailedTestConnectionAttempts: ").Append(FailedTestConnectionAttempts).Append("\n");
      sb.Append("  NextTestConnectionDate: ").Append(NextTestConnectionDate).Append("\n");
      sb.Append("  LastTestConnectionTaskId: ").Append(LastTestConnectionTaskId).Append("\n");
      sb.Append("  LastDependentServiceUpdateDate: ").Append(LastDependentServiceUpdateDate).Append("\n");
      sb.Append("  LastSuccessDependentServiceUpdateDate: ").Append(LastSuccessDependentServiceUpdateDate).Append("\n");
      sb.Append("  LastFailureDependentServiceUpdateDate: ").Append(LastFailureDependentServiceUpdateDate).Append("\n");
      sb.Append("  FailedDependentServiceUpdateAttempts: ").Append(FailedDependentServiceUpdateAttempts).Append("\n");
      sb.Append("  NextDependentServiceUpdateDate: ").Append(NextDependentServiceUpdateDate).Append("\n");
      sb.Append("  LastDependentServiceUpdateTaskId: ").Append(LastDependentServiceUpdateTaskId).Append("\n");
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
