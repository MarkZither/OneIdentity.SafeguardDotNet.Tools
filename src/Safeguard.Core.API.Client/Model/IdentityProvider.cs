using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an identity provider. Almost all identity providers are also implicitly authentication providers (depending on  the IdentityProviderType: AllowPrimaryAuthFlag and AllowSecondaryAuthFlag values).
  /// </summary>
  [DataContract]
  public class IdentityProvider {
    /// <summary>
    /// The identity provider's unique id.  This is a system-assigned value that is generated when an identity provider is first configured. (Read-only)
    /// </summary>
    /// <value>The identity provider's unique id.  This is a system-assigned value that is generated when an identity provider is first configured. (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets TypeReferenceName
    /// </summary>
    [DataMember(Name="TypeReferenceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TypeReferenceName")]
    public IdentityProviderTypeReferenceName TypeReferenceName { get; set; }

    /// <summary>
    /// The name of the identity provider.  This value will be user-visible on login dialogs and must be unique across all identity providers.
    /// </summary>
    /// <value>The name of the identity provider.  This value will be user-visible on login dialogs and must be unique across all identity providers.</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// The description of the identity provider.
    /// </summary>
    /// <value>The description of the identity provider.</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Network address of the provider if this is an Ldap directory (Read-only)
    /// </summary>
    /// <value>Network address of the provider if this is an Ldap directory (Read-only)</value>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

    /// <summary>
    /// If this provider is system owned then it cannot be modified. (Read-only)
    /// </summary>
    /// <value>If this provider is system owned then it cannot be modified. (Read-only)</value>
    [DataMember(Name="IsSystemOwned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSystemOwned")]
    public bool? IsSystemOwned { get; set; }

    /// <summary>
    /// If this provider represents a directory. (Read-only)
    /// </summary>
    /// <value>If this provider represents a directory. (Read-only)</value>
    [DataMember(Name="IsDirectory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsDirectory")]
    public bool? IsDirectory { get; set; }

    /// <summary>
    /// The RSTS provider id, if this provider supports authentication. This value is for information only and is not normally needed. (Read-only)
    /// </summary>
    /// <value>The RSTS provider id, if this provider supports authentication. This value is for information only and is not normally needed. (Read-only)</value>
    [DataMember(Name="RstsProviderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RstsProviderId")]
    public string RstsProviderId { get; set; }

    /// <summary>
    /// The RSTS provider scope, if this provider supports authentication. This value is for information only and is not normally needed. (Read-only)
    /// </summary>
    /// <value>The RSTS provider scope, if this provider supports authentication. This value is for information only and is not normally needed. (Read-only)</value>
    [DataMember(Name="RstsProviderScope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RstsProviderScope")]
    public string RstsProviderScope { get; set; }

    /// <summary>
    /// Gets or Sets StarlingProperties
    /// </summary>
    [DataMember(Name="StarlingProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StarlingProperties")]
    public IdentityProviderStarlingProperties StarlingProperties { get; set; }

    /// <summary>
    /// Gets or Sets RadiusProperties
    /// </summary>
    [DataMember(Name="RadiusProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RadiusProperties")]
    public IdentityProviderConfigRadiusProperties RadiusProperties { get; set; }

    /// <summary>
    /// Gets or Sets ExternalFederationProperties
    /// </summary>
    [DataMember(Name="ExternalFederationProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExternalFederationProperties")]
    public IdentityProviderConfigExternalFederationProperties ExternalFederationProperties { get; set; }

    /// <summary>
    /// Gets or Sets Fido2Properties
    /// </summary>
    [DataMember(Name="Fido2Properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Fido2Properties")]
    public IdentityProviderConfigFido2Properties Fido2Properties { get; set; }

    /// <summary>
    /// Gets or Sets OneLoginMfaProperties
    /// </summary>
    [DataMember(Name="OneLoginMfaProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OneLoginMfaProperties")]
    public IdentityProviderConfigOneLoginMfaProperties OneLoginMfaProperties { get; set; }

    /// <summary>
    /// Gets or Sets DirectoryProperties
    /// </summary>
    [DataMember(Name="DirectoryProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryProperties")]
    public IdentityProviderDirectoryProperties DirectoryProperties { get; set; }

    /// <summary>
    /// Date this entity was created (Read-only)
    /// </summary>
    /// <value>Date this entity was created (Read-only)</value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The database ID of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The database ID of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserId")]
    public int? CreatedByUserId { get; set; }

    /// <summary>
    /// The display name of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The display name of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserDisplayName")]
    public string CreatedByUserDisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentityProvider {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  TypeReferenceName: ").Append(TypeReferenceName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  IsSystemOwned: ").Append(IsSystemOwned).Append("\n");
      sb.Append("  IsDirectory: ").Append(IsDirectory).Append("\n");
      sb.Append("  RstsProviderId: ").Append(RstsProviderId).Append("\n");
      sb.Append("  RstsProviderScope: ").Append(RstsProviderScope).Append("\n");
      sb.Append("  StarlingProperties: ").Append(StarlingProperties).Append("\n");
      sb.Append("  RadiusProperties: ").Append(RadiusProperties).Append("\n");
      sb.Append("  ExternalFederationProperties: ").Append(ExternalFederationProperties).Append("\n");
      sb.Append("  Fido2Properties: ").Append(Fido2Properties).Append("\n");
      sb.Append("  OneLoginMfaProperties: ").Append(OneLoginMfaProperties).Append("\n");
      sb.Append("  DirectoryProperties: ").Append(DirectoryProperties).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
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
