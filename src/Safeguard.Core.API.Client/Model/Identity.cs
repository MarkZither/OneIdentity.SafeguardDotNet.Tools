using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an Identity.  The Identity is either a group or a user.
  /// </summary>
  [DataContract]
  public class Identity {
    /// <summary>
    /// Display name of the Identity (Read-only)
    /// </summary>
    /// <value>Display name of the Identity (Read-only)</value>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Database ID of the Identity (Read-only)
    /// </summary>
    /// <value>Database ID of the Identity (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Database ID of the identity provider (Read-only)
    /// </summary>
    /// <value>Database ID of the identity provider (Read-only)</value>
    [DataMember(Name="IdentityProviderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IdentityProviderId")]
    public int? IdentityProviderId { get; set; }

    /// <summary>
    /// Name of the identity provider (Read-only)
    /// </summary>
    /// <value>Name of the identity provider (Read-only)</value>
    [DataMember(Name="IdentityProviderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IdentityProviderName")]
    public string IdentityProviderName { get; set; }

    /// <summary>
    /// Gets or Sets IdentityProviderTypeReferenceName
    /// </summary>
    [DataMember(Name="IdentityProviderTypeReferenceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IdentityProviderTypeReferenceName")]
    public IdentityProviderTypeReferenceName IdentityProviderTypeReferenceName { get; set; }

    /// <summary>
    /// Whether this identity is owned by the system and cannot be deleted (Read-only)
    /// </summary>
    /// <value>Whether this identity is owned by the system and cannot be deleted (Read-only)</value>
    [DataMember(Name="IsSystemOwned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSystemOwned")]
    public bool? IsSystemOwned { get; set; }

    /// <summary>
    /// Name of the Identity (Read-only)
    /// </summary>
    /// <value>Name of the Identity (Read-only)</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets PrincipalKind
    /// </summary>
    [DataMember(Name="PrincipalKind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrincipalKind")]
    public PrincipalKind PrincipalKind { get; set; }

    /// <summary>
    /// Email address of the Identity if applicable (Read-only)
    /// </summary>
    /// <value>Email address of the Identity if applicable (Read-only)</value>
    [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmailAddress")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Domain name of the Identity (Read-only)
    /// </summary>
    /// <value>Domain name of the Identity (Read-only)</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// Full display name of the Identity (Read-only)
    /// </summary>
    /// <value>Full display name of the Identity (Read-only)</value>
    [DataMember(Name="FullDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FullDisplayName")]
    public string FullDisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Identity {\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IdentityProviderId: ").Append(IdentityProviderId).Append("\n");
      sb.Append("  IdentityProviderName: ").Append(IdentityProviderName).Append("\n");
      sb.Append("  IdentityProviderTypeReferenceName: ").Append(IdentityProviderTypeReferenceName).Append("\n");
      sb.Append("  IsSystemOwned: ").Append(IsSystemOwned).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PrincipalKind: ").Append(PrincipalKind).Append("\n");
      sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  FullDisplayName: ").Append(FullDisplayName).Append("\n");
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
