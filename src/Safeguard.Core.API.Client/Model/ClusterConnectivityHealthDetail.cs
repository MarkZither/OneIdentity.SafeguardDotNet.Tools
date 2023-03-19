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
  public class ClusterConnectivityHealthDetail {
    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [DataMember(Name="Error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Error")]
    public string Error { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public HealthStatus Status { get; set; }

    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    [DataMember(Name="ErrorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ErrorCode")]
    public int? ErrorCode { get; set; }

    /// <summary>
    /// Gets or Sets ErrorDetail
    /// </summary>
    [DataMember(Name="ErrorDetail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ErrorDetail")]
    public string ErrorDetail { get; set; }

    /// <summary>
    /// Gets or Sets NodeConnectivity
    /// </summary>
    [DataMember(Name="NodeConnectivity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NodeConnectivity")]
    public List<NodeConnectivityHealth> NodeConnectivity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClusterConnectivityHealthDetail {\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
      sb.Append("  ErrorDetail: ").Append(ErrorDetail).Append("\n");
      sb.Append("  NodeConnectivity: ").Append(NodeConnectivity).Append("\n");
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
