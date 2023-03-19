using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// When the TypeReferenceName property is \&quot;Fido2\&quot;, this provides additional FIDO2-specific              configuration values.
  /// </summary>
  [DataContract]
  public class IdentityProviderConfigFido2Properties {
    /// <summary>
    /// A valid domain string that identifies the WebAuthn Relying Party on whose behalf a given registration              or authentication ceremony is being performed.  A public key credential can only be used for authentication              with the same entity (as identified by this value) it was registered with.  However, this value may be just a              valid registrable domain suffix of what appears in the user's browser when registering.  For example, you may              enter just \"contoso.com\" here, which would allow you to register against a server at https://www.contoso.com,              or https://node1.contoso.com, and later use the same authenticator security key to authenticate at either of              those locations.
    /// </summary>
    /// <value>A valid domain string that identifies the WebAuthn Relying Party on whose behalf a given registration              or authentication ceremony is being performed.  A public key credential can only be used for authentication              with the same entity (as identified by this value) it was registered with.  However, this value may be just a              valid registrable domain suffix of what appears in the user's browser when registering.  For example, you may              enter just \"contoso.com\" here, which would allow you to register against a server at https://www.contoso.com,              or https://node1.contoso.com, and later use the same authenticator security key to authenticate at either of              those locations.</value>
    [DataMember(Name="DomainSuffix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainSuffix")]
    public string DomainSuffix { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentityProviderConfigFido2Properties {\n");
      sb.Append("  DomainSuffix: ").Append(DomainSuffix).Append("\n");
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
