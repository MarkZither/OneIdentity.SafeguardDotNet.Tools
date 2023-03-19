using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents the read-only property values of a supported identity provider
  /// </summary>
  [DataContract]
  public class IdentityProviderType {
    /// <summary>
    /// The name of the identity provider type. (Read-only)
    /// </summary>
    /// <value>The name of the identity provider type. (Read-only)</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ReferenceName
    /// </summary>
    [DataMember(Name="ReferenceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReferenceName")]
    public IdentityProviderTypeReferenceName ReferenceName { get; set; }

    /// <summary>
    /// A flag indicating whether or not this identity provider type supports primary authentication. (Read-only)
    /// </summary>
    /// <value>A flag indicating whether or not this identity provider type supports primary authentication. (Read-only)</value>
    [DataMember(Name="AllowPrimaryAuthFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowPrimaryAuthFlag")]
    public bool? AllowPrimaryAuthFlag { get; set; }

    /// <summary>
    /// A flag indicating whether or not this identity provider type supports secondary authentication. (Read-only)
    /// </summary>
    /// <value>A flag indicating whether or not this identity provider type supports secondary authentication. (Read-only)</value>
    [DataMember(Name="AllowSecondaryAuthFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSecondaryAuthFlag")]
    public bool? AllowSecondaryAuthFlag { get; set; }

    /// <summary>
    /// A flag indicating whether or not multiple identity providers of this type may be configured. (Read-only)
    /// </summary>
    /// <value>A flag indicating whether or not multiple identity providers of this type may be configured. (Read-only)</value>
    [DataMember(Name="AllowMultipleConfigsFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowMultipleConfigsFlag")]
    public bool? AllowMultipleConfigsFlag { get; set; }

    /// <summary>
    /// When given, provides the default server port number for the identity provider configuration. (Read-only)
    /// </summary>
    /// <value>When given, provides the default server port number for the identity provider configuration. (Read-only)</value>
    [DataMember(Name="DefaultServerPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultServerPort")]
    public int? DefaultServerPort { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentityProviderType {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ReferenceName: ").Append(ReferenceName).Append("\n");
      sb.Append("  AllowPrimaryAuthFlag: ").Append(AllowPrimaryAuthFlag).Append("\n");
      sb.Append("  AllowSecondaryAuthFlag: ").Append(AllowSecondaryAuthFlag).Append("\n");
      sb.Append("  AllowMultipleConfigsFlag: ").Append(AllowMultipleConfigsFlag).Append("\n");
      sb.Append("  DefaultServerPort: ").Append(DefaultServerPort).Append("\n");
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
