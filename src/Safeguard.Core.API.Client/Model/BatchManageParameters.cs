using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Parameters needed for request to manage a batch of accounts
  /// </summary>
  [DataContract]
  public class BatchManageParameters {
    /// <summary>
    /// The discovered accounts to manage
    /// </summary>
    /// <value>The discovered accounts to manage</value>
    [DataMember(Name="DiscoveredAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredAccounts")]
    public List<DiscoveredAssetAccount> DiscoveredAccounts { get; set; }

    /// <summary>
    /// Gets or Sets AccountTemplate
    /// </summary>
    [DataMember(Name="AccountTemplate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountTemplate")]
    public AccountTemplate AccountTemplate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BatchManageParameters {\n");
      sb.Append("  DiscoveredAccounts: ").Append(DiscoveredAccounts).Append("\n");
      sb.Append("  AccountTemplate: ").Append(AccountTemplate).Append("\n");
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
