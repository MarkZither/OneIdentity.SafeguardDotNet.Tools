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
  public class MeEntitlement {
    /// <summary>
    /// Gets or Sets Account
    /// </summary>
    [DataMember(Name="Account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Account")]
    public MeEntitlementAccount Account { get; set; }

    /// <summary>
    /// Gets or Sets Asset
    /// </summary>
    [DataMember(Name="Asset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Asset")]
    public MeEntitlementAsset Asset { get; set; }

    /// <summary>
    /// Gets or Sets Policy
    /// </summary>
    [DataMember(Name="Policy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Policy")]
    public MeEntitlementPolicy Policy { get; set; }

    /// <summary>
    /// Gets or Sets ActiveRequests
    /// </summary>
    [DataMember(Name="ActiveRequests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ActiveRequests")]
    public List<ActiveRequest> ActiveRequests { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MeEntitlement {\n");
      sb.Append("  Account: ").Append(Account).Append("\n");
      sb.Append("  Asset: ").Append(Asset).Append("\n");
      sb.Append("  Policy: ").Append(Policy).Append("\n");
      sb.Append("  ActiveRequests: ").Append(ActiveRequests).Append("\n");
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
