using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Authentication provider information for a user
  /// </summary>
  [DataContract]
  public class UserPrimaryAuthenticationProvider {
    /// <summary>
    /// The id of the user's primary authentication provider.
    /// </summary>
    /// <value>The id of the user's primary authentication provider.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the user's primary authentication provider (Read-only)
    /// </summary>
    /// <value>The name of the user's primary authentication provider (Read-only)</value>
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
    /// The value required to authenticate the user against the specified authentication provider.  Often this will be  what the user enters when logging in.  However, for some providers such as External Federation, it needs to match  the provider's Name Claim that is returned.  This value must be unique per authentication provider.  For Active  Directory and LDAP, you may specify the 'samAccountName' or 'Username' attribute when creating a user, but the  value will be overwritten with the 'objectGUID' or 'entryUuid', respectively.
    /// </summary>
    /// <value>The value required to authenticate the user against the specified authentication provider.  Often this will be  what the user enters when logging in.  However, for some providers such as External Federation, it needs to match  the provider's Name Claim that is returned.  This value must be unique per authentication provider.  For Active  Directory and LDAP, you may specify the 'samAccountName' or 'Username' attribute when creating a user, but the  value will be overwritten with the 'objectGUID' or 'entryUuid', respectively.</value>
    [DataMember(Name="Identity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Identity")]
    public string Identity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserPrimaryAuthenticationProvider {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  TypeReferenceName: ").Append(TypeReferenceName).Append("\n");
      sb.Append("  Identity: ").Append(Identity).Append("\n");
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
