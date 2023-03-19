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
  public class CloudAssistantStatus {
    /// <summary>
    /// Gets or Sets Joined
    /// </summary>
    [DataMember(Name="Joined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Joined")]
    public bool? Joined { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name="Enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets SenderId
    /// </summary>
    [DataMember(Name="SenderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SenderId")]
    public string SenderId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CloudAssistantStatus {\n");
      sb.Append("  Joined: ").Append(Joined).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  SenderId: ").Append(SenderId).Append("\n");
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
