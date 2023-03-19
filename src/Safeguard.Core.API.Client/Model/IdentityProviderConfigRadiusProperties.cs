using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// When the TypeReferenceName property is \&quot;Radius\&quot;, this provides additional RADIUS-specific  configuration values.
  /// </summary>
  [DataContract]
  public class IdentityProviderConfigRadiusProperties {
    /// <summary>
    /// The IP address or FQDN of the primary RADIUS server. (required for radius providers)
    /// </summary>
    /// <value>The IP address or FQDN of the primary RADIUS server. (required for radius providers)</value>
    [DataMember(Name="ServerAddress1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServerAddress1")]
    public string ServerAddress1 { get; set; }

    /// <summary>
    /// The IP address or FQDN of the backup RADIUS server.
    /// </summary>
    /// <value>The IP address or FQDN of the backup RADIUS server.</value>
    [DataMember(Name="ServerAddress2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServerAddress2")]
    public string ServerAddress2 { get; set; }

    /// <summary>
    /// The port number to use for connections to the RADIUS servers.  (required for radius providers)
    /// </summary>
    /// <value>The port number to use for connections to the RADIUS servers.  (required for radius providers)</value>
    [DataMember(Name="ServerPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServerPort")]
    public int? ServerPort { get; set; }

    /// <summary>
    /// The shared secret used to hash RADIUS user passwords. This value is typically provided by a RADIUS system administrator.  (required for radius providers)
    /// </summary>
    /// <value>The shared secret used to hash RADIUS user passwords. This value is typically provided by a RADIUS system administrator.  (required for radius providers)</value>
    [DataMember(Name="SharedSecret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SharedSecret")]
    public string SharedSecret { get; set; }

    /// <summary>
    /// The time (specified in seconds) to wait for a response from the RADIUS server before retrying.
    /// </summary>
    /// <value>The time (specified in seconds) to wait for a response from the RADIUS server before retrying.</value>
    [DataMember(Name="Timeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Timeout")]
    public int? Timeout { get; set; }

    /// <summary>
    /// The number of times to retry RADIUS server requests before giving up.
    /// </summary>
    /// <value>The number of times to retry RADIUS server requests before giving up.</value>
    [DataMember(Name="Retries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Retries")]
    public int? Retries { get; set; }

    /// <summary>
    /// Indicates whether an Access-Request call containing only the User-Name should be sent to the RADIUS server              prior to the user's authentication attempt.  This is done to inform the RADIUS server of the user's identity so it              can possibly begin the authentication process by starting a challenge/response cycle.  This may be required to seed              the user's state data.  In addition, the RADIUS server's response may include a login message that is to be displayed,              which is specific to that user.  Note, if the RADIUS server is not configured to respond with an Access-Challenge,              then this will cause the log in to fail and the user will be unable to proceed.
    /// </summary>
    /// <value>Indicates whether an Access-Request call containing only the User-Name should be sent to the RADIUS server              prior to the user's authentication attempt.  This is done to inform the RADIUS server of the user's identity so it              can possibly begin the authentication process by starting a challenge/response cycle.  This may be required to seed              the user's state data.  In addition, the RADIUS server's response may include a login message that is to be displayed,              which is specific to that user.  Note, if the RADIUS server is not configured to respond with an Access-Challenge,              then this will cause the log in to fail and the user will be unable to proceed.</value>
    [DataMember(Name="PreAuthenticateForChallengeResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PreAuthenticateForChallengeResponse")]
    public bool? PreAuthenticateForChallengeResponse { get; set; }

    /// <summary>
    /// If enabled, the text box that the user enters their one-time password, or other challenge required by the              RADIUS server, will always be a password style text box in which the user's input is masked, i.e. appears as a series              of dots, not as clear text.  This may be desired when the challenge is not just a one-time password, but also contains              the user's PIN.  This will prevent any passer-by from seeing the private information.  Note, however, that when this              setting is enabled, it will also override the Prompt attribute of the RADIUS server's Access-Challenge response, such              that the user's input will always be masked.
    /// </summary>
    /// <value>If enabled, the text box that the user enters their one-time password, or other challenge required by the              RADIUS server, will always be a password style text box in which the user's input is masked, i.e. appears as a series              of dots, not as clear text.  This may be desired when the challenge is not just a one-time password, but also contains              the user's PIN.  This will prevent any passer-by from seeing the private information.  Note, however, that when this              setting is enabled, it will also override the Prompt attribute of the RADIUS server's Access-Challenge response, such              that the user's input will always be masked.</value>
    [DataMember(Name="AlwaysMaskUserInput", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AlwaysMaskUserInput")]
    public bool? AlwaysMaskUserInput { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentityProviderConfigRadiusProperties {\n");
      sb.Append("  ServerAddress1: ").Append(ServerAddress1).Append("\n");
      sb.Append("  ServerAddress2: ").Append(ServerAddress2).Append("\n");
      sb.Append("  ServerPort: ").Append(ServerPort).Append("\n");
      sb.Append("  SharedSecret: ").Append(SharedSecret).Append("\n");
      sb.Append("  Timeout: ").Append(Timeout).Append("\n");
      sb.Append("  Retries: ").Append(Retries).Append("\n");
      sb.Append("  PreAuthenticateForChallengeResponse: ").Append(PreAuthenticateForChallengeResponse).Append("\n");
      sb.Append("  AlwaysMaskUserInput: ").Append(AlwaysMaskUserInput).Append("\n");
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
