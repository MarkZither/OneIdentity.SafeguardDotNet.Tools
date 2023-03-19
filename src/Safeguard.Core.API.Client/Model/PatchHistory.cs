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
  public class PatchHistory {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Metadata
    /// </summary>
    [DataMember(Name="Metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Metadata")]
    public PatchMetadata Metadata { get; set; }

    /// <summary>
    /// Gets or Sets Success
    /// </summary>
    [DataMember(Name="Success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Success")]
    public bool? Success { get; set; }

    /// <summary>
    /// Gets or Sets InstallationError
    /// </summary>
    [DataMember(Name="InstallationError", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InstallationError")]
    public string InstallationError { get; set; }

    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    [DataMember(Name="Timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Timestamp")]
    public DateTime? Timestamp { get; set; }

    /// <summary>
    /// Gets or Sets OldVersion
    /// </summary>
    [DataMember(Name="OldVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OldVersion")]
    public string OldVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PatchHistory {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  InstallationError: ").Append(InstallationError).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  OldVersion: ").Append(OldVersion).Append("\n");
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
