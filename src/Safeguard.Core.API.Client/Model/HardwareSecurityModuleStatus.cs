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
  public class HardwareSecurityModuleStatus {
    /// <summary>
    /// Gets or Sets LastAccessDate
    /// </summary>
    [DataMember(Name="LastAccessDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastAccessDate")]
    public DateTime? LastAccessDate { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name="Enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets Configuration
    /// </summary>
    [DataMember(Name="Configuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Configuration")]
    public HardwareSecurityModuleConfiguration Configuration { get; set; }

    /// <summary>
    /// Gets or Sets HealthStatus
    /// </summary>
    [DataMember(Name="HealthStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HealthStatus")]
    public string HealthStatus { get; set; }

    /// <summary>
    /// Gets or Sets MasterKeyLabel
    /// </summary>
    [DataMember(Name="MasterKeyLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MasterKeyLabel")]
    public string MasterKeyLabel { get; set; }

    /// <summary>
    /// Gets or Sets TransitionToErrorState
    /// </summary>
    [DataMember(Name="TransitionToErrorState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransitionToErrorState")]
    public bool? TransitionToErrorState { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HardwareSecurityModuleStatus {\n");
      sb.Append("  LastAccessDate: ").Append(LastAccessDate).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
      sb.Append("  HealthStatus: ").Append(HealthStatus).Append("\n");
      sb.Append("  MasterKeyLabel: ").Append(MasterKeyLabel).Append("\n");
      sb.Append("  TransitionToErrorState: ").Append(TransitionToErrorState).Append("\n");
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
