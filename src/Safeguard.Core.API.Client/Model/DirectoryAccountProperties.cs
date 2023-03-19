using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Properties mapping the entity to an account in a directory
  /// </summary>
  [DataContract]
  public class DirectoryAccountProperties {
    /// <summary>
    /// Netbios name of the domain this object is from (Read-only)
    /// </summary>
    /// <value>Netbios name of the domain this object is from (Read-only)</value>
    [DataMember(Name="NetbiosName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetbiosName")]
    public string NetbiosName { get; set; }

    /// <summary>
    /// Unique ID of the object in the directory (Read-only)
    /// </summary>
    /// <value>Unique ID of the object in the directory (Read-only)</value>
    [DataMember(Name="ObjectGuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectGuid")]
    public string ObjectGuid { get; set; }

    /// <summary>
    /// Security ID of the object in the directory (Active Directory only) (Read-only)
    /// </summary>
    /// <value>Security ID of the object in the directory (Active Directory only) (Read-only)</value>
    [DataMember(Name="ObjectSid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectSid")]
    public string ObjectSid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DirectoryAccountProperties {\n");
      sb.Append("  NetbiosName: ").Append(NetbiosName).Append("\n");
      sb.Append("  ObjectGuid: ").Append(ObjectGuid).Append("\n");
      sb.Append("  ObjectSid: ").Append(ObjectSid).Append("\n");
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
