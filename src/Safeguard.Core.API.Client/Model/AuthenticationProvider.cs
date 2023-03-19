using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Available configurations for authentication
  /// </summary>
  [DataContract]
  public class AuthenticationProvider {
    /// <summary>
    /// Unique Id of authentication provider (Read-only)
    /// </summary>
    /// <value>Unique Id of authentication provider (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of the authentication provider (Read-only)
    /// </summary>
    /// <value>Name of the authentication provider (Read-only)</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets TypeReferenceName
    /// </summary>
    [DataMember(Name="TypeReferenceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TypeReferenceName")]
    public IdentityProviderTypeReferenceName TypeReferenceName { get; set; }

    /// <summary>
    /// Unique ID of related identity provider (Read-only)
    /// </summary>
    /// <value>Unique ID of related identity provider (Read-only)</value>
    [DataMember(Name="IdentityProviderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IdentityProviderId")]
    public int? IdentityProviderId { get; set; }

    /// <summary>
    /// RSTS provider identifier (Read-only)
    /// </summary>
    /// <value>RSTS provider identifier (Read-only)</value>
    [DataMember(Name="RstsProviderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RstsProviderId")]
    public string RstsProviderId { get; set; }

    /// <summary>
    /// RSTS provider scope (Read-only)
    /// </summary>
    /// <value>RSTS provider scope (Read-only)</value>
    [DataMember(Name="RstsProviderScope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RstsProviderScope")]
    public string RstsProviderScope { get; set; }

    /// <summary>
    /// When set to {true} on a provider, the login page will not display a drop down list              of all available providers. Instead, the end user will be defaulted in to using this provider.              Only one provider can be marked with {true} at a time. When updating a provider and setting              this to {true}, this will be automatically set to {false} on all other providers.
    /// </summary>
    /// <value>When set to {true} on a provider, the login page will not display a drop down list              of all available providers. Instead, the end user will be defaulted in to using this provider.              Only one provider can be marked with {true} at a time. When updating a provider and setting              this to {true}, this will be automatically set to {false} on all other providers.</value>
    [DataMember(Name="ForceAsDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ForceAsDefault")]
    public bool? ForceAsDefault { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationProvider {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  TypeReferenceName: ").Append(TypeReferenceName).Append("\n");
      sb.Append("  IdentityProviderId: ").Append(IdentityProviderId).Append("\n");
      sb.Append("  RstsProviderId: ").Append(RstsProviderId).Append("\n");
      sb.Append("  RstsProviderScope: ").Append(RstsProviderScope).Append("\n");
      sb.Append("  ForceAsDefault: ").Append(ForceAsDefault).Append("\n");
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
