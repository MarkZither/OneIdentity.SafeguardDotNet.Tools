using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a file transfer protocol used by archive servers
  /// </summary>
  [DataContract]
  public class TransferProtocol {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public TransferProtocolType Id { get; set; }

    /// <summary>
    /// Name of this protocol (Read-only)
    /// </summary>
    /// <value>Name of this protocol (Read-only)</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of this protocol (Read-only)
    /// </summary>
    /// <value>Description of this protocol (Read-only)</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Protocol supports using a custom port
    /// </summary>
    /// <value>Protocol supports using a custom port</value>
    [DataMember(Name="SupportsCustomPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsCustomPort")]
    public bool? SupportsCustomPort { get; set; }

    /// <summary>
    /// Protocol supports password username/authentication
    /// </summary>
    /// <value>Protocol supports password username/authentication</value>
    [DataMember(Name="SupportsPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsPassword")]
    public bool? SupportsPassword { get; set; }

    /// <summary>
    /// Protocol supports SSH username/key authentication
    /// </summary>
    /// <value>Protocol supports SSH username/key authentication</value>
    [DataMember(Name="SupportsSshKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsSshKey")]
    public bool? SupportsSshKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransferProtocol {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  SupportsCustomPort: ").Append(SupportsCustomPort).Append("\n");
      sb.Append("  SupportsPassword: ").Append(SupportsPassword).Append("\n");
      sb.Append("  SupportsSshKey: ").Append(SupportsSshKey).Append("\n");
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
