using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A service discovered as part of a service discovery task
  /// </summary>
  [DataContract]
  public class DiscoveredServiceLog {
    /// <summary>
    /// Account associated with the discovered service
    /// </summary>
    /// <value>Account associated with the discovered service</value>
    [DataMember(Name="DiscoveredAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredAccount")]
    public string DiscoveredAccount { get; set; }

    /// <summary>
    /// Name of the discovered service
    /// </summary>
    /// <value>Name of the discovered service</value>
    [DataMember(Name="ServiceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceName")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Display name of the service
    /// </summary>
    /// <value>Display name of the service</value>
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
    /// Whether the discovered service is enabled
    /// </summary>
    /// <value>Whether the discovered service is enabled</value>
    [DataMember(Name="IsServiceEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsServiceEnabled")]
    public bool? IsServiceEnabled { get; set; }

    /// <summary>
    /// Unique ID of managed account associated with account of discovered service
    /// </summary>
    /// <value>Unique ID of managed account associated with account of discovered service</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Name of managed account associated with account of discovered service
    /// </summary>
    /// <value>Name of managed account associated with account of discovered service</value>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Domain name of managed account associated with account of discovered service
    /// </summary>
    /// <value>Domain name of managed account associated with account of discovered service</value>
    [DataMember(Name="AccountDomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDomainName")]
    public string AccountDomainName { get; set; }

    /// <summary>
    /// Asset ID of managed account associated with account of discovered service
    /// </summary>
    /// <value>Asset ID of managed account associated with account of discovered service</value>
    [DataMember(Name="AccountAssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountAssetId")]
    public int? AccountAssetId { get; set; }

    /// <summary>
    /// Asset name of managed account associated with account of discovered service
    /// </summary>
    /// <value>Asset name of managed account associated with account of discovered service</value>
    [DataMember(Name="AccountAssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountAssetName")]
    public string AccountAssetName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiscoveredServiceLog {\n");
      sb.Append("  DiscoveredAccount: ").Append(DiscoveredAccount).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  ServiceDisplayName: ").Append(ServiceDisplayName).Append("\n");
      sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
      sb.Append("  IsServiceEnabled: ").Append(IsServiceEnabled).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
      sb.Append("  AccountAssetId: ").Append(AccountAssetId).Append("\n");
      sb.Append("  AccountAssetName: ").Append(AccountAssetName).Append("\n");
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
