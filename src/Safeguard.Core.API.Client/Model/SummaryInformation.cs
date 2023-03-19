using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The count of all tasks
  /// </summary>
  [DataContract]
  public class SummaryInformation {
    /// <summary>
    /// Sum of all TaskSummary.Count values for all dates being reported
    /// </summary>
    /// <value>Sum of all TaskSummary.Count values for all dates being reported</value>
    [DataMember(Name="TotalTaskCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalTaskCount")]
    public int? TotalTaskCount { get; set; }

    /// <summary>
    /// List of date buckets
    /// </summary>
    /// <value>List of date buckets</value>
    [DataMember(Name="SummaryDates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SummaryDates")]
    public List<DateTasks> SummaryDates { get; set; }

    /// <summary>
    /// Earliest date summarized
    /// </summary>
    /// <value>Earliest date summarized</value>
    [DataMember(Name="MinimumDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinimumDateTime")]
    public DateTime? MinimumDateTime { get; set; }

    /// <summary>
    /// Latest date summarized
    /// </summary>
    /// <value>Latest date summarized</value>
    [DataMember(Name="MaximumDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaximumDateTime")]
    public DateTime? MaximumDateTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SummaryInformation {\n");
      sb.Append("  TotalTaskCount: ").Append(TotalTaskCount).Append("\n");
      sb.Append("  SummaryDates: ").Append(SummaryDates).Append("\n");
      sb.Append("  MinimumDateTime: ").Append(MinimumDateTime).Append("\n");
      sb.Append("  MaximumDateTime: ").Append(MaximumDateTime).Append("\n");
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
