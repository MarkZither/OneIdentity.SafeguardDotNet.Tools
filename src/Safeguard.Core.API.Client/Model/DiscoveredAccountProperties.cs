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
  public class DiscoveredAccountProperties {
    /// <summary>
    /// The unique ID of the account discovery schedule that discovered this account
    /// </summary>
    /// <value>The unique ID of the account discovery schedule that discovered this account</value>
    [DataMember(Name="AccountDiscoveryScheduleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDiscoveryScheduleId")]
    public int? AccountDiscoveryScheduleId { get; set; }

    /// <summary>
    /// The name of the account discovery schedule that discovered this account
    /// </summary>
    /// <value>The name of the account discovery schedule that discovered this account</value>
    [DataMember(Name="AccountDiscoveryScheduleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDiscoveryScheduleName")]
    public string AccountDiscoveryScheduleName { get; set; }

    /// <summary>
    /// The User ID discovered on the target system
    /// </summary>
    /// <value>The User ID discovered on the target system</value>
    [DataMember(Name="DiscoveredUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredUserId")]
    public string DiscoveredUserId { get; set; }

    /// <summary>
    /// The date the account was discovered
    /// </summary>
    /// <value>The date the account was discovered</value>
    [DataMember(Name="DiscoveredDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredDate")]
    public DateTime? DiscoveredDate { get; set; }

    /// <summary>
    /// The groups on the target system the user is a member of
    /// </summary>
    /// <value>The groups on the target system the user is a member of</value>
    [DataMember(Name="DiscoveredGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredGroups")]
    public List<DiscoveredGroup> DiscoveredGroups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiscoveredAccountProperties {\n");
      sb.Append("  AccountDiscoveryScheduleId: ").Append(AccountDiscoveryScheduleId).Append("\n");
      sb.Append("  AccountDiscoveryScheduleName: ").Append(AccountDiscoveryScheduleName).Append("\n");
      sb.Append("  DiscoveredUserId: ").Append(DiscoveredUserId).Append("\n");
      sb.Append("  DiscoveredDate: ").Append(DiscoveredDate).Append("\n");
      sb.Append("  DiscoveredGroups: ").Append(DiscoveredGroups).Append("\n");
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
