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
  public class DiscoveredService {
    /// <summary>
    /// The account associated with the discovered service
    /// </summary>
    /// <value>The account associated with the discovered service</value>
    [DataMember(Name="DiscoveredAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredAccount")]
    public string DiscoveredAccount { get; set; }

    /// <summary>
    /// Asset partition id
    /// </summary>
    /// <value>Asset partition id</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Asset partition name
    /// </summary>
    /// <value>Asset partition name</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// Name of the asset on which this service was discovered
    /// </summary>
    /// <value>Name of the asset on which this service was discovered</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Id of the asset on which this service was discovered
    /// </summary>
    /// <value>Id of the asset on which this service was discovered</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Name of the discovered service
    /// </summary>
    /// <value>Name of the discovered service</value>
    [DataMember(Name="ServiceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceName")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Display Name of the discovered service
    /// </summary>
    /// <value>Display Name of the discovered service</value>
    [DataMember(Name="ServiceDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceDisplayName")]
    public string ServiceDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ServiceType
    /// </summary>
    [DataMember(Name="ServiceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceType")]
    public DiscoveredServiceType ServiceType { get; set; }

    /// <summary>
    /// Whether the service is enabled
    /// </summary>
    /// <value>Whether the service is enabled</value>
    [DataMember(Name="IsServiceEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsServiceEnabled")]
    public bool? IsServiceEnabled { get; set; }

    /// <summary>
    /// Unique ID of dependent account
    /// </summary>
    /// <value>Unique ID of dependent account</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Name of the dependent account
    /// </summary>
    /// <value>Name of the dependent account</value>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Domain name of the dependent account
    /// </summary>
    /// <value>Domain name of the dependent account</value>
    [DataMember(Name="AccountDomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDomainName")]
    public string AccountDomainName { get; set; }

    /// <summary>
    /// Unique ID of asset of the dependent account
    /// </summary>
    /// <value>Unique ID of asset of the dependent account</value>
    [DataMember(Name="AccountAssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountAssetId")]
    public int? AccountAssetId { get; set; }

    /// <summary>
    /// Name of asset of the dependent account
    /// </summary>
    /// <value>Name of asset of the dependent account</value>
    [DataMember(Name="AccountAssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountAssetName")]
    public string AccountAssetName { get; set; }

    /// <summary>
    /// Gets or Sets AccountStatus
    /// </summary>
    [DataMember(Name="AccountStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountStatus")]
    public DiscoveredServiceAccountStatus AccountStatus { get; set; }

    /// <summary>
    /// Is the account used by the service also a dependent account on the asset
    /// </summary>
    /// <value>Is the account used by the service also a dependent account on the asset</value>
    [DataMember(Name="IsDependentAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsDependentAccount")]
    public bool? IsDependentAccount { get; set; }

    /// <summary>
    /// Whether this service should be ignored if re-discovered
    /// </summary>
    /// <value>Whether this service should be ignored if re-discovered</value>
    [DataMember(Name="IsIgnored", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsIgnored")]
    public bool? IsIgnored { get; set; }

    /// <summary>
    /// The date the service was discovered
    /// </summary>
    /// <value>The date the service was discovered</value>
    [DataMember(Name="DiscoveredDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredDate")]
    public DateTime? DiscoveredDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiscoveredService {\n");
      sb.Append("  DiscoveredAccount: ").Append(DiscoveredAccount).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  ServiceDisplayName: ").Append(ServiceDisplayName).Append("\n");
      sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
      sb.Append("  IsServiceEnabled: ").Append(IsServiceEnabled).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
      sb.Append("  AccountAssetId: ").Append(AccountAssetId).Append("\n");
      sb.Append("  AccountAssetName: ").Append(AccountAssetName).Append("\n");
      sb.Append("  AccountStatus: ").Append(AccountStatus).Append("\n");
      sb.Append("  IsDependentAccount: ").Append(IsDependentAccount).Append("\n");
      sb.Append("  IsIgnored: ").Append(IsIgnored).Append("\n");
      sb.Append("  DiscoveredDate: ").Append(DiscoveredDate).Append("\n");
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
