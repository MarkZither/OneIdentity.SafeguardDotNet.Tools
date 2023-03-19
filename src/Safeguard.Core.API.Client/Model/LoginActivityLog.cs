using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// User authentication events
  /// </summary>
  [DataContract]
  public class LoginActivityLog {
    /// <summary>
    /// The unique id of this log entry
    /// </summary>
    /// <value>The unique id of this log entry</value>
    [DataMember(Name="LogId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LogId")]
    public string LogId { get; set; }

    /// <summary>
    /// Time of authentication
    /// </summary>
    /// <value>Time of authentication</value>
    [DataMember(Name="LogTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LogTime")]
    public DateTime? LogTime { get; set; }

    /// <summary>
    /// Unique id of the user that authenticated.
    /// </summary>
    /// <value>Unique id of the user that authenticated.</value>
    [DataMember(Name="UserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserId")]
    public int? UserId { get; set; }

    /// <summary>
    /// Gets or Sets UserProperties
    /// </summary>
    [DataMember(Name="UserProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserProperties")]
    public UserLogProperties UserProperties { get; set; }

    /// <summary>
    /// Gets or Sets EventName
    /// </summary>
    [DataMember(Name="EventName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EventName")]
    public EventName EventName { get; set; }

    /// <summary>
    /// Name of the event
    /// </summary>
    /// <value>Name of the event</value>
    [DataMember(Name="EventDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EventDisplayName")]
    public string EventDisplayName { get; set; }

    /// <summary>
    /// Id of appliance to which user authenticated
    /// </summary>
    /// <value>Id of appliance to which user authenticated</value>
    [DataMember(Name="ApplianceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceId")]
    public string ApplianceId { get; set; }

    /// <summary>
    /// Name of appliance to which user authenticated
    /// </summary>
    /// <value>Name of appliance to which user authenticated</value>
    [DataMember(Name="ApplianceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceName")]
    public string ApplianceName { get; set; }

    /// <summary>
    /// Gets or Sets ErrorType
    /// </summary>
    [DataMember(Name="ErrorType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ErrorType")]
    public AuthenticationErrorType ErrorType { get; set; }

    /// <summary>
    /// The id of the user's primary authentication provider.
    /// </summary>
    /// <value>The id of the user's primary authentication provider.</value>
    [DataMember(Name="PrimaryAuthenticationProviderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryAuthenticationProviderId")]
    public int? PrimaryAuthenticationProviderId { get; set; }

    /// <summary>
    /// The name of the user's primary authentication provider
    /// </summary>
    /// <value>The name of the user's primary authentication provider</value>
    [DataMember(Name="PrimaryAuthenticationProviderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryAuthenticationProviderName")]
    public string PrimaryAuthenticationProviderName { get; set; }

    /// <summary>
    /// The id of the user's secondary authentication provider.  If this property is not set then the user is not subject to secondary authentication.
    /// </summary>
    /// <value>The id of the user's secondary authentication provider.  If this property is not set then the user is not subject to secondary authentication.</value>
    [DataMember(Name="SecondaryAuthenticationProviderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecondaryAuthenticationProviderId")]
    public int? SecondaryAuthenticationProviderId { get; set; }

    /// <summary>
    /// The name of the user's secondary authentication provider. (Read-only)
    /// </summary>
    /// <value>The name of the user's secondary authentication provider. (Read-only)</value>
    [DataMember(Name="SecondaryAuthenticationProviderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecondaryAuthenticationProviderName")]
    public string SecondaryAuthenticationProviderName { get; set; }

    /// <summary>
    /// Reason for failure
    /// </summary>
    /// <value>Reason for failure</value>
    [DataMember(Name="Reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Reason")]
    public string Reason { get; set; }

    /// <summary>
    /// Gets or Sets LoginTime
    /// </summary>
    [DataMember(Name="LoginTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LoginTime")]
    public DateTime? LoginTime { get; set; }

    /// <summary>
    /// Gets or Sets LoginDuration
    /// </summary>
    [DataMember(Name="LoginDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LoginDuration")]
    public TimeInterval LoginDuration { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LoginActivityLog {\n");
      sb.Append("  LogId: ").Append(LogId).Append("\n");
      sb.Append("  LogTime: ").Append(LogTime).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
      sb.Append("  EventName: ").Append(EventName).Append("\n");
      sb.Append("  EventDisplayName: ").Append(EventDisplayName).Append("\n");
      sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
      sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
      sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
      sb.Append("  PrimaryAuthenticationProviderId: ").Append(PrimaryAuthenticationProviderId).Append("\n");
      sb.Append("  PrimaryAuthenticationProviderName: ").Append(PrimaryAuthenticationProviderName).Append("\n");
      sb.Append("  SecondaryAuthenticationProviderId: ").Append(SecondaryAuthenticationProviderId).Append("\n");
      sb.Append("  SecondaryAuthenticationProviderName: ").Append(SecondaryAuthenticationProviderName).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  LoginTime: ").Append(LoginTime).Append("\n");
      sb.Append("  LoginDuration: ").Append(LoginDuration).Append("\n");
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
