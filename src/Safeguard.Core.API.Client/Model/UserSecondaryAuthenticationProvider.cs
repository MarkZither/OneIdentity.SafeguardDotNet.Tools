using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Information about user secondary auth provider
  /// </summary>
  [DataContract]
  public class UserSecondaryAuthenticationProvider {
    /// <summary>
    /// The id of the user's secondary authentication provider.  If this property is not set then the user is not subject to secondary authentication.
    /// </summary>
    /// <value>The id of the user's secondary authentication provider.  If this property is not set then the user is not subject to secondary authentication.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the user's secondary authentication provider. (Read-only)
    /// </summary>
    /// <value>The name of the user's secondary authentication provider. (Read-only)</value>
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
    /// The value required to authenticate the user against the specified secondary authentication provider.  Often this will be  what the user enters when logging in.
    /// </summary>
    /// <value>The value required to authenticate the user against the specified secondary authentication provider.  Often this will be  what the user enters when logging in.</value>
    [DataMember(Name="Identity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Identity")]
    public string Identity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserSecondaryAuthenticationProvider {\n");
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
