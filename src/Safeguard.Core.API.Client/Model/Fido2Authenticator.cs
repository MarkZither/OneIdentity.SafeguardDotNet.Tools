using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Details about an individual FIDO2 authenticator (or &#x27;token&#x27; or &#x27;security key&#x27;) that has been registered with our              system.  A user can, and should, have at least two authenticators registered and associated with their account at all times              in case they ever loose or break one, they will have a backup.
  /// </summary>
  [DataContract]
  public class Fido2Authenticator {
    /// <summary>
    /// The unique identifier for this authenticator against this site and user.  It will be set when the authenticator              is first registered, then never changed.
    /// </summary>
    /// <value>The unique identifier for this authenticator against this site and user.  It will be set when the authenticator              is first registered, then never changed.</value>
    [DataMember(Name="CredentialId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CredentialId")]
    public string CredentialId { get; set; }

    /// <summary>
    /// When the authenticator was first registered in our system.  Afterwards, this value should never change.
    /// </summary>
    /// <value>When the authenticator was first registered in our system.  Afterwards, this value should never change.</value>
    [DataMember(Name="DateRegistered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DateRegistered")]
    public DateTime? DateRegistered { get; set; }

    /// <summary>
    /// Updated every time the authenticator is used when logging in.
    /// </summary>
    /// <value>Updated every time the authenticator is used when logging in.</value>
    [DataMember(Name="DateLastAuthenticated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DateLastAuthenticated")]
    public DateTime? DateLastAuthenticated { get; set; }

    /// <summary>
    /// A user supplied, friendly name, given to the authenticator after it has been registered in the system.
    /// </summary>
    /// <value>A user supplied, friendly name, given to the authenticator after it has been registered in the system.</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Fido2Authenticator {\n");
      sb.Append("  CredentialId: ").Append(CredentialId).Append("\n");
      sb.Append("  DateRegistered: ").Append(DateRegistered).Append("\n");
      sb.Append("  DateLastAuthenticated: ").Append(DateLastAuthenticated).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
