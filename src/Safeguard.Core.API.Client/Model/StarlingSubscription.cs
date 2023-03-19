using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class StarlingSubscription {
    /// <summary>
    /// Unique Id of the Starling subscription information. Read-only.
    /// </summary>
    /// <value>Unique Id of the Starling subscription information. Read-only.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// User supplied friendly name for the Starling subscription.
    /// </summary>
    /// <value>User supplied friendly name for the Starling subscription.</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Value returned from the Starling join process to be used when authenticating against the Starling API.              It is a colon delimited string of the client_id and client_secret to be used as the client credentials in an              OAuth2 Client Credentials Flow authentication request.
    /// </summary>
    /// <value>Value returned from the Starling join process to be used when authenticating against the Starling API.              It is a colon delimited string of the client_id and client_secret to be used as the client credentials in an              OAuth2 Client Credentials Flow authentication request.</value>
    [DataMember(Name="ClientCredentials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClientCredentials")]
    public string ClientCredentials { get; set; }

    /// <summary>
    /// Value returned from the Starling join process indicating the Url to use when authenticating.
    /// </summary>
    /// <value>Value returned from the Starling join process indicating the Url to use when authenticating.</value>
    [DataMember(Name="TokenEndpoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TokenEndpoint")]
    public string TokenEndpoint { get; set; }

    /// <summary>
    /// A copy of the Url that was used to initiate the Starling join process.  Parts will be used to unjoin              if necessary.
    /// </summary>
    /// <value>A copy of the Url that was used to initiate the Starling join process.  Parts will be used to unjoin              if necessary.</value>
    [DataMember(Name="JoinUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "JoinUrl")]
    public string JoinUrl { get; set; }

    /// <summary>
    /// Available when the customer has subscribed to Starling Cloud Assistant.
    /// </summary>
    /// <value>Available when the customer has subscribed to Starling Cloud Assistant.</value>
    [DataMember(Name="CloudAssistantSenderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CloudAssistantSenderId")]
    public string CloudAssistantSenderId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StarlingSubscription {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ClientCredentials: ").Append(ClientCredentials).Append("\n");
      sb.Append("  TokenEndpoint: ").Append(TokenEndpoint).Append("\n");
      sb.Append("  JoinUrl: ").Append(JoinUrl).Append("\n");
      sb.Append("  CloudAssistantSenderId: ").Append(CloudAssistantSenderId).Append("\n");
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
