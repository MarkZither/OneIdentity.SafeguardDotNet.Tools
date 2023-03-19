using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an associated account on an application to application registration.
  /// </summary>
  [DataContract]
  public class RegistrationRetrievableAccount {
    /// <summary>
    /// The account's unique id.
    /// </summary>
    /// <value>The account's unique id.</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// The account name.
    /// </summary>
    /// <value>The account name.</value>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// The account's API key.
    /// </summary>
    /// <value>The account's API key.</value>
    [DataMember(Name="ApiKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApiKey")]
    public string ApiKey { get; set; }

    /// <summary>
    /// List of restricted IP addresses
    /// </summary>
    /// <value>List of restricted IP addresses</value>
    [DataMember(Name="IpRestrictions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IpRestrictions")]
    public List<string> IpRestrictions { get; set; }

    /// <summary>
    /// ID of the asset
    /// </summary>
    /// <value>ID of the asset</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Name of the asset
    /// </summary>
    /// <value>Name of the asset</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// ID of the asset partition
    /// </summary>
    /// <value>ID of the asset partition</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of the asset partition
    /// </summary>
    /// <value>Name of the asset partition</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// Description of the asset
    /// </summary>
    /// <value>Description of the asset</value>
    [DataMember(Name="AssetDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetDescription")]
    public string AssetDescription { get; set; }

    /// <summary>
    /// Description of the account
    /// </summary>
    /// <value>Description of the account</value>
    [DataMember(Name="AccountDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDescription")]
    public string AccountDescription { get; set; }

    /// <summary>
    /// Network address of the asset
    /// </summary>
    /// <value>Network address of the asset</value>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

    /// <summary>
    /// Account disabled flag
    /// </summary>
    /// <value>Account disabled flag</value>
    [DataMember(Name="AccountDisabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDisabled")]
    public int? AccountDisabled { get; set; }

    /// <summary>
    /// Gets or Sets AccountType
    /// </summary>
    [DataMember(Name="AccountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountType")]
    public AccountType AccountType { get; set; }

    /// <summary>
    /// Domain name
    /// </summary>
    /// <value>Domain name</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RegistrationRetrievableAccount {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
      sb.Append("  IpRestrictions: ").Append(IpRestrictions).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  AssetDescription: ").Append(AssetDescription).Append("\n");
      sb.Append("  AccountDescription: ").Append(AccountDescription).Append("\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  AccountDisabled: ").Append(AccountDisabled).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
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
