using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Options available with Network Type Discovery
  /// </summary>
  [DataContract]
  public class NetworkDiscoveryOptions {
    /// <summary>
    /// Attempt to determine operating system using the OS fingerprint. Can increase duration of discovery.
    /// </summary>
    /// <value>Attempt to determine operating system using the OS fingerprint. Can increase duration of discovery.</value>
    [DataMember(Name="OsFingerPrint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OsFingerPrint")]
    public bool? OsFingerPrint { get; set; }

    /// <summary>
    /// Time allowed, in seconds, for network scan to run before cancelling the task. Set to 0 to use the default of 15 minutes.
    /// </summary>
    /// <value>Time allowed, in seconds, for network scan to run before cancelling the task. Set to 0 to use the default of 15 minutes.</value>
    [DataMember(Name="ScanTimeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScanTimeout")]
    public int? ScanTimeout { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NetworkDiscoveryOptions {\n");
      sb.Append("  OsFingerPrint: ").Append(OsFingerPrint).Append("\n");
      sb.Append("  ScanTimeout: ").Append(ScanTimeout).Append("\n");
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
