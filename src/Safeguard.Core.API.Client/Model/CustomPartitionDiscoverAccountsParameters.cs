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
  public class CustomPartitionDiscoverAccountsParameters {
    /// <summary>
    /// Gets or Sets AssetId
    /// </summary>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Friendly name used to identify this rule
    /// </summary>
    /// <value>Friendly name used to identify this rule</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// If selected, accounts found through discovery will be automatically taken under management.
    /// </summary>
    /// <value>If selected, accounts found through discovery will be automatically taken under management.</value>
    [DataMember(Name="AutoManageDiscoveredAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AutoManageDiscoveredAccounts")]
    public bool? AutoManageDiscoveredAccounts { get; set; }

    /// <summary>
    /// Gets or Sets AccountTemplate
    /// </summary>
    [DataMember(Name="AccountTemplate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountTemplate")]
    public AccountTemplate AccountTemplate { get; set; }

    /// <summary>
    /// Gets or Sets UnixAccountDiscoveryProperties
    /// </summary>
    [DataMember(Name="UnixAccountDiscoveryProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UnixAccountDiscoveryProperties")]
    public UnixAccountDiscoveryProperties UnixAccountDiscoveryProperties { get; set; }

    /// <summary>
    /// Gets or Sets WindowsAccountDiscoveryProperties
    /// </summary>
    [DataMember(Name="WindowsAccountDiscoveryProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WindowsAccountDiscoveryProperties")]
    public WindowsAccountDiscoveryProperties WindowsAccountDiscoveryProperties { get; set; }

    /// <summary>
    /// Gets or Sets DirectoryAccountDiscoveryProperties
    /// </summary>
    [DataMember(Name="DirectoryAccountDiscoveryProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryAccountDiscoveryProperties")]
    public DirectoryAccountDiscoveryProperties DirectoryAccountDiscoveryProperties { get; set; }

    /// <summary>
    /// Gets or Sets StarlingConnectAccountDiscoveryProperties
    /// </summary>
    [DataMember(Name="StarlingConnectAccountDiscoveryProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StarlingConnectAccountDiscoveryProperties")]
    public StarlingConnectAccountDiscoveryProperties StarlingConnectAccountDiscoveryProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CustomPartitionDiscoverAccountsParameters {\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  AutoManageDiscoveredAccounts: ").Append(AutoManageDiscoveredAccounts).Append("\n");
      sb.Append("  AccountTemplate: ").Append(AccountTemplate).Append("\n");
      sb.Append("  UnixAccountDiscoveryProperties: ").Append(UnixAccountDiscoveryProperties).Append("\n");
      sb.Append("  WindowsAccountDiscoveryProperties: ").Append(WindowsAccountDiscoveryProperties).Append("\n");
      sb.Append("  DirectoryAccountDiscoveryProperties: ").Append(DirectoryAccountDiscoveryProperties).Append("\n");
      sb.Append("  StarlingConnectAccountDiscoveryProperties: ").Append(StarlingConnectAccountDiscoveryProperties).Append("\n");
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
