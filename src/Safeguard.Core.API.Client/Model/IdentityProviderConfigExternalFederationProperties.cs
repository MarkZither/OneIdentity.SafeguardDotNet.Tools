using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// When the TypeReferenceName property is \&quot;ExternalFederation\&quot;, this provides additional configuration values              specific to that type.
  /// </summary>
  [DataContract]
  public class IdentityProviderConfigExternalFederationProperties {
    /// <summary>
    /// The DNS suffix name(s) for which the Pangaea.Data.Transfer.V2.Users.IdentityProviderConfigExternalFederationProperties.FederationMetadata is applicable to.  This value needs to match              the email address suffix of a user that intends to be authenticated. If the federated authentication supports more than              one realm, enter each realm separated by a space, comma, or new line.
    /// </summary>
    /// <value>The DNS suffix name(s) for which the Pangaea.Data.Transfer.V2.Users.IdentityProviderConfigExternalFederationProperties.FederationMetadata is applicable to.  This value needs to match              the email address suffix of a user that intends to be authenticated. If the federated authentication supports more than              one realm, enter each realm separated by a space, comma, or new line.</value>
    [DataMember(Name="Realm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Realm")]
    public string Realm { get; set; }

    /// <summary>
    /// The complete federation metadata Xml of the Identity Provider STS that a user will be redirected to for              authentication.
    /// </summary>
    /// <value>The complete federation metadata Xml of the Identity Provider STS that a user will be redirected to for              authentication.</value>
    [DataMember(Name="FederationMetadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FederationMetadata")]
    public string FederationMetadata { get; set; }

    /// <summary>
    /// The {RequestedAuthnContext} in a SAML2 request, asking the IdP to authenticate the user with              a specified authentication mechanism. For example, {urn:oasis:names:tc:SAML:2.0:ac:classes:PasswordProtectedTransport}.              If specified, use one or more of the allowed context class URIs from the saml-authn-context-2.0-os.pdf              (https://docs.oasis-open.org/security/saml/v2.0/saml-authn-context-2.0-os.pdf), section 3.4 Schemas.              Specify multiple values by separating the strings with a space or comma.
    /// </summary>
    /// <value>The {RequestedAuthnContext} in a SAML2 request, asking the IdP to authenticate the user with              a specified authentication mechanism. For example, {urn:oasis:names:tc:SAML:2.0:ac:classes:PasswordProtectedTransport}.              If specified, use one or more of the allowed context class URIs from the saml-authn-context-2.0-os.pdf              (https://docs.oasis-open.org/security/saml/v2.0/saml-authn-context-2.0-os.pdf), section 3.4 Schemas.              Specify multiple values by separating the strings with a space or comma.</value>
    [DataMember(Name="AuthnContextClasses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthnContextClasses")]
    public string AuthnContextClasses { get; set; }

    /// <summary>
    /// Gets or Sets AuthnContextComparison
    /// </summary>
    [DataMember(Name="AuthnContextComparison", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthnContextComparison")]
    public AuthnContextComparison AuthnContextComparison { get; set; }

    /// <summary>
    /// The {Format} attribute of the {NameID} element within the {Issuer} element of a              SAML2 AuthnRequest. For example, {urn:oasis:names:tc:SAML:2.0:nameid-format:entity}. If specified,              use one of the allowed name identifier format identifiers as listed in section 8.3 of Assertions and              Protocols for the OASIS Security Assertion Markup Language (SAML) V2.0 – Errata Composite.
    /// </summary>
    /// <value>The {Format} attribute of the {NameID} element within the {Issuer} element of a              SAML2 AuthnRequest. For example, {urn:oasis:names:tc:SAML:2.0:nameid-format:entity}. If specified,              use one of the allowed name identifier format identifiers as listed in section 8.3 of Assertions and              Protocols for the OASIS Security Assertion Markup Language (SAML) V2.0 – Errata Composite.</value>
    [DataMember(Name="NameIDFormat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NameIDFormat")]
    public string NameIDFormat { get; set; }

    /// <summary>
    /// Controls the {ForceAuthn} attribute of a SAML2 AuthnRequest. When set to true, the user              will be required to reenter their credentials on the external federation site, even if they are already              logged in, thus negating any single sign-on benefits, but may be considered more secure.                            If not specified/included in the request when creating a new instance, the default value will be true.
    /// </summary>
    /// <value>Controls the {ForceAuthn} attribute of a SAML2 AuthnRequest. When set to true, the user              will be required to reenter their credentials on the external federation site, even if they are already              logged in, thus negating any single sign-on benefits, but may be considered more secure.                            If not specified/included in the request when creating a new instance, the default value will be true.</value>
    [DataMember(Name="RequireAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequireAuthentication")]
    public bool? RequireAuthentication { get; set; }

    /// <summary>
    /// Override the {Issuer} name value sent in a SAML2 AuthnRequest.
    /// </summary>
    /// <value>Override the {Issuer} name value sent in a SAML2 AuthnRequest.</value>
    [DataMember(Name="ApplicationIdOverride", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationIdOverride")]
    public string ApplicationIdOverride { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentityProviderConfigExternalFederationProperties {\n");
      sb.Append("  Realm: ").Append(Realm).Append("\n");
      sb.Append("  FederationMetadata: ").Append(FederationMetadata).Append("\n");
      sb.Append("  AuthnContextClasses: ").Append(AuthnContextClasses).Append("\n");
      sb.Append("  AuthnContextComparison: ").Append(AuthnContextComparison).Append("\n");
      sb.Append("  NameIDFormat: ").Append(NameIDFormat).Append("\n");
      sb.Append("  RequireAuthentication: ").Append(RequireAuthentication).Append("\n");
      sb.Append("  ApplicationIdOverride: ").Append(ApplicationIdOverride).Append("\n");
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
