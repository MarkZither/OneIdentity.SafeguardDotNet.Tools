using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Credential parameters for directory schema discovery
  /// </summary>
  [DataContract]
  public class IdentityProviderSchemaParameters {
    /// <summary>
    /// Use service account credentials from specified directory provider
    /// </summary>
    /// <value>Use service account credentials from specified directory provider</value>
    [DataMember(Name="DirectoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryId")]
    public int? DirectoryId { get; set; }

    /// <summary>
    /// The network address of the server the directory resides on (not required for Active Directory)
    /// </summary>
    /// <value>The network address of the server the directory resides on (not required for Active Directory)</value>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

    /// <summary>
    /// Gets or Sets TypeReferenceName
    /// </summary>
    [DataMember(Name="TypeReferenceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TypeReferenceName")]
    public IdentityProviderTypeReferenceName TypeReferenceName { get; set; }

    /// <summary>
    /// Gets or Sets ConnectionProperties
    /// </summary>
    [DataMember(Name="ConnectionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConnectionProperties")]
    public DirectoryConnectionProperties ConnectionProperties { get; set; }

    /// <summary>
    /// List of available domain controllers. If this list is empty then DNS will be used instead.
    /// </summary>
    /// <value>List of available domain controllers. If this list is empty then DNS will be used instead.</value>
    [DataMember(Name="DomainControllers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainControllers")]
    public List<DomainController> DomainControllers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentityProviderSchemaParameters {\n");
      sb.Append("  DirectoryId: ").Append(DirectoryId).Append("\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  TypeReferenceName: ").Append(TypeReferenceName).Append("\n");
      sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
      sb.Append("  DomainControllers: ").Append(DomainControllers).Append("\n");
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
