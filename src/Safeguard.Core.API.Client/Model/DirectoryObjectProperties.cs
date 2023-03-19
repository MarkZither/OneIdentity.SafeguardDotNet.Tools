using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Properties mapping the entity to an object in a directory
  /// </summary>
  [DataContract]
  public class DirectoryObjectProperties {
    /// <summary>
    /// The directory this object was imported from. Required if this is an object to import from a directory.
    /// </summary>
    /// <value>The directory this object was imported from. Required if this is an object to import from a directory.</value>
    [DataMember(Name="DirectoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryId")]
    public int? DirectoryId { get; set; }

    /// <summary>
    /// The name of the directory this object was imported from. (Read-only)
    /// </summary>
    /// <value>The name of the directory this object was imported from. (Read-only)</value>
    [DataMember(Name="DirectoryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryName")]
    public string DirectoryName { get; set; }

    /// <summary>
    /// Name of the domain this object is from. Required if this is an object to import from a directory.
    /// </summary>
    /// <value>Name of the domain this object is from. Required if this is an object to import from a directory.</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// Netbios name of the domain this object is from (Read-only)
    /// </summary>
    /// <value>Netbios name of the domain this object is from (Read-only)</value>
    [DataMember(Name="NetbiosName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetbiosName")]
    public string NetbiosName { get; set; }

    /// <summary>
    /// The distinguished name of the object (Read-only)
    /// </summary>
    /// <value>The distinguished name of the object (Read-only)</value>
    [DataMember(Name="DistinguishedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DistinguishedName")]
    public string DistinguishedName { get; set; }

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
      sb.Append("class DirectoryObjectProperties {\n");
      sb.Append("  DirectoryId: ").Append(DirectoryId).Append("\n");
      sb.Append("  DirectoryName: ").Append(DirectoryName).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  NetbiosName: ").Append(NetbiosName).Append("\n");
      sb.Append("  DistinguishedName: ").Append(DistinguishedName).Append("\n");
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
