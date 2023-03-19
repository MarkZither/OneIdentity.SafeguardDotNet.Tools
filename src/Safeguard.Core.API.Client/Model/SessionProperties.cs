using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Session access configuration
  /// </summary>
  [DataContract]
  public class SessionProperties {
    /// <summary>
    /// ID of the session module connection information
    /// </summary>
    /// <value>ID of the session module connection information</value>
    [DataMember(Name="SessionModuleConnectionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionModuleConnectionId")]
    public int? SessionModuleConnectionId { get; set; }

    /// <summary>
    /// Reference to the session module session connection policy
    /// </summary>
    /// <value>Reference to the session module session connection policy</value>
    [DataMember(Name="SessionConnectionPolicyRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionConnectionPolicyRef")]
    public string SessionConnectionPolicyRef { get; set; }

    /// <summary>
    /// Gets or Sets RemoteDesktopApplicationProperties
    /// </summary>
    [DataMember(Name="RemoteDesktopApplicationProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RemoteDesktopApplicationProperties")]
    public RemoteDesktopApplicationProperties RemoteDesktopApplicationProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SessionProperties {\n");
      sb.Append("  SessionModuleConnectionId: ").Append(SessionModuleConnectionId).Append("\n");
      sb.Append("  SessionConnectionPolicyRef: ").Append(SessionConnectionPolicyRef).Append("\n");
      sb.Append("  RemoteDesktopApplicationProperties: ").Append(RemoteDesktopApplicationProperties).Append("\n");
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
