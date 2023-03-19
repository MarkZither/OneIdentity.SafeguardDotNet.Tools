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
  public class ClusterOperationStatus {
    /// <summary>
    /// Gets or Sets Operation
    /// </summary>
    [DataMember(Name="Operation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Operation")]
    public ClusterOperation Operation { get; set; }

    /// <summary>
    /// Unique Id of the cluster member
    /// </summary>
    /// <value>Unique Id of the cluster member</value>
    [DataMember(Name="OwnerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OwnerId")]
    public string OwnerId { get; set; }

    /// <summary>
    /// The timestamp when this operation started
    /// </summary>
    /// <value>The timestamp when this operation started</value>
    [DataMember(Name="Started", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Started")]
    public DateTime? Started { get; set; }

    /// <summary>
    /// Status for each node in the cluster
    /// </summary>
    /// <value>Status for each node in the cluster</value>
    [DataMember(Name="Nodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Nodes")]
    public List<ClusterOperationNodeStatus> Nodes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClusterOperationStatus {\n");
      sb.Append("  Operation: ").Append(Operation).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  Started: ").Append(Started).Append("\n");
      sb.Append("  Nodes: ").Append(Nodes).Append("\n");
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
