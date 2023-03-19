using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Settings controlling when the policy/role will be effective
  /// </summary>
  [DataContract]
  public class HourlyRestrictionProperties {
    /// <summary>
    /// Whether time restrictions are to be enforced. If false, the policy/role is always valid.
    /// </summary>
    /// <value>Whether time restrictions are to be enforced. If false, the policy/role is always valid.</value>
    [DataMember(Name="EnableHourlyRestrictions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EnableHourlyRestrictions")]
    public bool? EnableHourlyRestrictions { get; set; }

    /// <summary>
    /// List of hours on Monday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.
    /// </summary>
    /// <value>List of hours on Monday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.</value>
    [DataMember(Name="MondayValidHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MondayValidHours")]
    public List<int?> MondayValidHours { get; set; }

    /// <summary>
    /// List of hours on Tuesday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.
    /// </summary>
    /// <value>List of hours on Tuesday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.</value>
    [DataMember(Name="TuesdayValidHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TuesdayValidHours")]
    public List<int?> TuesdayValidHours { get; set; }

    /// <summary>
    /// List of hours on Wednesday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.
    /// </summary>
    /// <value>List of hours on Wednesday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.</value>
    [DataMember(Name="WednesdayValidHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WednesdayValidHours")]
    public List<int?> WednesdayValidHours { get; set; }

    /// <summary>
    /// List of hours on Thursday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.
    /// </summary>
    /// <value>List of hours on Thursday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.</value>
    [DataMember(Name="ThursdayValidHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ThursdayValidHours")]
    public List<int?> ThursdayValidHours { get; set; }

    /// <summary>
    /// List of hours on Friday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.
    /// </summary>
    /// <value>List of hours on Friday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.</value>
    [DataMember(Name="FridayValidHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FridayValidHours")]
    public List<int?> FridayValidHours { get; set; }

    /// <summary>
    /// List of hours on Saturday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.
    /// </summary>
    /// <value>List of hours on Saturday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.</value>
    [DataMember(Name="SaturdayValidHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SaturdayValidHours")]
    public List<int?> SaturdayValidHours { get; set; }

    /// <summary>
    /// List of hours on Sunday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.
    /// </summary>
    /// <value>List of hours on Sunday when the policy/role is active where 0 represents 12:00 AM and 23 represents 11:00 PM.</value>
    [DataMember(Name="SundayValidHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SundayValidHours")]
    public List<int?> SundayValidHours { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HourlyRestrictionProperties {\n");
      sb.Append("  EnableHourlyRestrictions: ").Append(EnableHourlyRestrictions).Append("\n");
      sb.Append("  MondayValidHours: ").Append(MondayValidHours).Append("\n");
      sb.Append("  TuesdayValidHours: ").Append(TuesdayValidHours).Append("\n");
      sb.Append("  WednesdayValidHours: ").Append(WednesdayValidHours).Append("\n");
      sb.Append("  ThursdayValidHours: ").Append(ThursdayValidHours).Append("\n");
      sb.Append("  FridayValidHours: ").Append(FridayValidHours).Append("\n");
      sb.Append("  SaturdayValidHours: ").Append(SaturdayValidHours).Append("\n");
      sb.Append("  SundayValidHours: ").Append(SundayValidHours).Append("\n");
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
