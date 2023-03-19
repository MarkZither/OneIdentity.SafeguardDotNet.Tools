using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The count of all tasks occurring in a given summary interval
  /// </summary>
  [DataContract]
  public class DateTasks {
    /// <summary>
    /// Sum of all TaskSummary.Count for this summary interval
    /// </summary>
    /// <value>Sum of all TaskSummary.Count for this summary interval</value>
    [DataMember(Name="TotalDateTaskCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalDateTaskCount")]
    public int? TotalDateTaskCount { get; set; }

    /// <summary>
    /// Beginning of interval being summarized
    /// </summary>
    /// <value>Beginning of interval being summarized</value>
    [DataMember(Name="SummaryDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SummaryDateTime")]
    public DateTime? SummaryDateTime { get; set; }

    /// <summary>
    /// List of task names and counts for this summary interval
    /// </summary>
    /// <value>List of task names and counts for this summary interval</value>
    [DataMember(Name="Counts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Counts")]
    public List<TaskSummary> Counts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DateTasks {\n");
      sb.Append("  TotalDateTaskCount: ").Append(TotalDateTaskCount).Append("\n");
      sb.Append("  SummaryDateTime: ").Append(SummaryDateTime).Append("\n");
      sb.Append("  Counts: ").Append(Counts).Append("\n");
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
