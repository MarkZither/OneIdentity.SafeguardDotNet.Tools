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
  public class TestEmailClientConfig {
    /// <summary>
    /// Email address used to send a test email to
    /// </summary>
    /// <value>Email address used to send a test email to</value>
    [DataMember(Name="ToEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ToEmail")]
    public string ToEmail { get; set; }

    /// <summary>
    /// IP address or FQDN of the email server
    /// </summary>
    /// <value>IP address or FQDN of the email server</value>
    [DataMember(Name="ServerAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServerAddress")]
    public string ServerAddress { get; set; }

    /// <summary>
    /// TCP port number for the email service
    /// </summary>
    /// <value>TCP port number for the email service</value>
    [DataMember(Name="PortNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PortNumber")]
    public int? PortNumber { get; set; }

    /// <summary>
    /// Email address used as the From address for all email originating from the appliance. Required when an email server address is configured.
    /// </summary>
    /// <value>Email address used as the From address for all email originating from the appliance. Required when an email server address is configured.</value>
    [DataMember(Name="SenderEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SenderEmail")]
    public string SenderEmail { get; set; }

    /// <summary>
    /// Determines whether TLS is required by the SMTP server. (STARTTLS)
    /// </summary>
    /// <value>Determines whether TLS is required by the SMTP server. (STARTTLS)</value>
    [DataMember(Name="RequireTlsFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequireTlsFlag")]
    public bool? RequireTlsFlag { get; set; }

    /// <summary>
    /// Determines whether SMTPS is required by the SMTP server.  Setting this also sets RequireTlsFlag
    /// </summary>
    /// <value>Determines whether SMTPS is required by the SMTP server.  Setting this also sets RequireTlsFlag</value>
    [DataMember(Name="RequireSmtpsFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequireSmtpsFlag")]
    public bool? RequireSmtpsFlag { get; set; }

    /// <summary>
    /// Determines whether the server certificate needs validation when RequireTlsFlag is set to true
    /// </summary>
    /// <value>Determines whether the server certificate needs validation when RequireTlsFlag is set to true</value>
    [DataMember(Name="VerifySslCertificate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VerifySslCertificate")]
    public bool? VerifySslCertificate { get; set; }

    /// <summary>
    /// Determines whether the SMTP server requires account/password authentication
    /// </summary>
    /// <value>Determines whether the SMTP server requires account/password authentication</value>
    [DataMember(Name="RequireUserAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequireUserAuthentication")]
    public bool? RequireUserAuthentication { get; set; }

    /// <summary>
    /// Indicate if the client certificate is required for the connection to remote SMTP server
    /// </summary>
    /// <value>Indicate if the client certificate is required for the connection to remote SMTP server</value>
    [DataMember(Name="UseClientCertificate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseClientCertificate")]
    public bool? UseClientCertificate { get; set; }

    /// <summary>
    /// Seconds to wait after the test email has begun delivery to see if the delivery fails (max 255 seconds).
    /// </summary>
    /// <value>Seconds to wait after the test email has begun delivery to see if the delivery fails (max 255 seconds).</value>
    [DataMember(Name="TimeoutSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>
    /// Gets or Sets ConnectionProperties
    /// </summary>
    [DataMember(Name="ConnectionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConnectionProperties")]
    public EmailClientConfigConnectionProperties ConnectionProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TestEmailClientConfig {\n");
      sb.Append("  ToEmail: ").Append(ToEmail).Append("\n");
      sb.Append("  ServerAddress: ").Append(ServerAddress).Append("\n");
      sb.Append("  PortNumber: ").Append(PortNumber).Append("\n");
      sb.Append("  SenderEmail: ").Append(SenderEmail).Append("\n");
      sb.Append("  RequireTlsFlag: ").Append(RequireTlsFlag).Append("\n");
      sb.Append("  RequireSmtpsFlag: ").Append(RequireSmtpsFlag).Append("\n");
      sb.Append("  VerifySslCertificate: ").Append(VerifySslCertificate).Append("\n");
      sb.Append("  RequireUserAuthentication: ").Append(RequireUserAuthentication).Append("\n");
      sb.Append("  UseClientCertificate: ").Append(UseClientCertificate).Append("\n");
      sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
      sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
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
