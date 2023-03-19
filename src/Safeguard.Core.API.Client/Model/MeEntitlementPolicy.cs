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
  public class MeEntitlementPolicy {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [DataMember(Name="Priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Gets or Sets RolePriority
    /// </summary>
    [DataMember(Name="RolePriority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RolePriority")]
    public int? RolePriority { get; set; }

    /// <summary>
    /// Gets or Sets RequesterProperties
    /// </summary>
    [DataMember(Name="RequesterProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterProperties")]
    public PolicyRequesterProperties RequesterProperties { get; set; }

    /// <summary>
    /// Gets or Sets EmergencyAccessProperties
    /// </summary>
    [DataMember(Name="EmergencyAccessProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmergencyAccessProperties")]
    public PolicyEmergencyAccessProperties EmergencyAccessProperties { get; set; }

    /// <summary>
    /// Gets or Sets AccessRequestProperties
    /// </summary>
    [DataMember(Name="AccessRequestProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessRequestProperties")]
    public AccessRequestProperties AccessRequestProperties { get; set; }

    /// <summary>
    /// Gets or Sets EffectiveExpirationDate
    /// </summary>
    [DataMember(Name="EffectiveExpirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveExpirationDate")]
    public DateTime? EffectiveExpirationDate { get; set; }

    /// <summary>
    /// Gets or Sets EffectiveHourlyRestrictionProperties
    /// </summary>
    [DataMember(Name="EffectiveHourlyRestrictionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveHourlyRestrictionProperties")]
    public HourlyRestrictionProperties EffectiveHourlyRestrictionProperties { get; set; }

    /// <summary>
    /// Gets or Sets ReasonCodes
    /// </summary>
    [DataMember(Name="ReasonCodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonCodes")]
    public List<ReasonCode> ReasonCodes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MeEntitlementPolicy {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  RolePriority: ").Append(RolePriority).Append("\n");
      sb.Append("  RequesterProperties: ").Append(RequesterProperties).Append("\n");
      sb.Append("  EmergencyAccessProperties: ").Append(EmergencyAccessProperties).Append("\n");
      sb.Append("  AccessRequestProperties: ").Append(AccessRequestProperties).Append("\n");
      sb.Append("  EffectiveExpirationDate: ").Append(EffectiveExpirationDate).Append("\n");
      sb.Append("  EffectiveHourlyRestrictionProperties: ").Append(EffectiveHourlyRestrictionProperties).Append("\n");
      sb.Append("  ReasonCodes: ").Append(ReasonCodes).Append("\n");
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
