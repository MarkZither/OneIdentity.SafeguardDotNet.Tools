using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Used by client applications to exchange an STS token for a Safeguard user token that will then be used by the              application for all future API requests.  A client application should make a request to the &lt;i&gt;/service/core/v2/Token/LoginResponse&lt;/i&gt;              end point, passing the &lt;i&gt;access token&lt;/i&gt; they got from the STS.  Authorization will be performed on the authenticated user              and if successful, this Pangaea.Data.Transfer.V2.Users.LoginResponse object will be returned with a new token value in              Pangaea.Data.Transfer.V2.Users.LoginResponse.UserToken.
  /// </summary>
  [DataContract]
  public class LoginResponse {
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public LoginResponseStatus Status { get; set; }

    /// <summary>
    /// Upon successful authorization, a new access token will be granted that is to be used for all future API              requests by the client application.  Currently, the lifetime of this token is one day.
    /// </summary>
    /// <value>Upon successful authorization, a new access token will be granted that is to be used for all future API              requests by the client application.  Currently, the lifetime of this token is one day.</value>
    [DataMember(Name="UserToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserToken")]
    public string UserToken { get; set; }

    /// <summary>
    /// If the <i>access token</i> from the STS represents a user that requires two-factor authentication, then the              client application will have to redirect the user back to the STS, requesting that factor of authentication.  This              property will contain what directory service provider the user initially authenticated against.  It will need to be              included in the redirect back to the STS.
    /// </summary>
    /// <value>If the <i>access token</i> from the STS represents a user that requires two-factor authentication, then the              client application will have to redirect the user back to the STS, requesting that factor of authentication.  This              property will contain what directory service provider the user initially authenticated against.  It will need to be              included in the redirect back to the STS.</value>
    [DataMember(Name="PrimaryProviderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryProviderId")]
    public string PrimaryProviderId { get; set; }

    /// <summary>
    /// If the <i>access token</i> from the STS represents a user that requires two-factor authentication, then the              client application will have to redirect the user back to the STS, requesting that factor of authentication.  This              property will contain what directory service provider the user needs for two-factor authentication.  It will need to be              included in the redirect back to the STS.
    /// </summary>
    /// <value>If the <i>access token</i> from the STS represents a user that requires two-factor authentication, then the              client application will have to redirect the user back to the STS, requesting that factor of authentication.  This              property will contain what directory service provider the user needs for two-factor authentication.  It will need to be              included in the redirect back to the STS.</value>
    [DataMember(Name="SecondaryProviderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecondaryProviderId")]
    public string SecondaryProviderId { get; set; }

    /// <summary>
    /// This is the amount of time in minutes the web client can sit idle before its session will time out.
    /// </summary>
    /// <value>This is the amount of time in minutes the web client can sit idle before its session will time out.</value>
    [DataMember(Name="WebClientInactivityTimeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WebClientInactivityTimeout")]
    public int? WebClientInactivityTimeout { get; set; }

    /// <summary>
    /// This is the amount of time in minutes the desktop client can sit idle before its session will time out.
    /// </summary>
    /// <value>This is the amount of time in minutes the desktop client can sit idle before its session will time out.</value>
    [DataMember(Name="DesktopClientInactivityTimeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DesktopClientInactivityTimeout")]
    public int? DesktopClientInactivityTimeout { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LoginResponse {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  UserToken: ").Append(UserToken).Append("\n");
      sb.Append("  PrimaryProviderId: ").Append(PrimaryProviderId).Append("\n");
      sb.Append("  SecondaryProviderId: ").Append(SecondaryProviderId).Append("\n");
      sb.Append("  WebClientInactivityTimeout: ").Append(WebClientInactivityTimeout).Append("\n");
      sb.Append("  DesktopClientInactivityTimeout: ").Append(DesktopClientInactivityTimeout).Append("\n");
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
