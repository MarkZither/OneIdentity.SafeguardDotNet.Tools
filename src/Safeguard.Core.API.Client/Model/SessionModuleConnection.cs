using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a session module connection to a Safeguard cluster.
  /// </summary>
  [DataContract]
  public class SessionModuleConnection {
    /// <summary>
    /// Unique Id of the connected session module.
    /// </summary>
    /// <value>Unique Id of the connected session module.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Node Id of the session module.
    /// </summary>
    /// <value>Node Id of the session module.</value>
    [DataMember(Name="NodeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NodeId")]
    public string NodeId { get; set; }

    /// <summary>
    /// Description of the session module.
    /// </summary>
    /// <value>Description of the session module.</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// REST access IP address.
    /// </summary>
    /// <value>REST access IP address.</value>
    [DataMember(Name="SpsNetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpsNetworkAddress")]
    public string SpsNetworkAddress { get; set; }

    /// <summary>
    /// SPS host name.
    /// </summary>
    /// <value>SPS host name.</value>
    [DataMember(Name="SpsHostName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpsHostName")]
    public string SpsHostName { get; set; }

    /// <summary>
    /// Certificate Signing Request generated by SPS and to be signed by SPP.  The signed certificate will also be  associated with the certificate user created by SPP and used by SPS for authentication.
    /// </summary>
    /// <value>Certificate Signing Request generated by SPS and to be signed by SPP.  The signed certificate will also be  associated with the certificate user created by SPP and used by SPS for authentication.</value>
    [DataMember(Name="CertificateUserCsr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CertificateUserCsr")]
    public string CertificateUserCsr { get; set; }

    /// <summary>
    /// Current SSL PEM certificate chain.
    /// </summary>
    /// <value>Current SSL PEM certificate chain.</value>
    [DataMember(Name="SppSslPemEncodedCertificateChain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SppSslPemEncodedCertificateChain")]
    public string SppSslPemEncodedCertificateChain { get; set; }

    /// <summary>
    /// One time use token used by the linked session module to get the final trust validation.
    /// </summary>
    /// <value>One time use token used by the linked session module to get the final trust validation.</value>
    [DataMember(Name="OneTimeToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OneTimeToken")]
    public string OneTimeToken { get; set; }

    /// <summary>
    /// Indicates if the session module connection is trusted.
    /// </summary>
    /// <value>Indicates if the session module connection is trusted.</value>
    [DataMember(Name="Trusted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Trusted")]
    public bool? Trusted { get; set; }

    /// <summary>
    /// Signed certificate generated from the CertificateUser Csr.
    /// </summary>
    /// <value>Signed certificate generated from the CertificateUser Csr.</value>
    [DataMember(Name="CertificateUserPemEncodedCertificate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CertificateUserPemEncodedCertificate")]
    public string CertificateUserPemEncodedCertificate { get; set; }

    /// <summary>
    /// The id of the certificate user associated with the session module connection.
    /// </summary>
    /// <value>The id of the certificate user associated with the session module connection.</value>
    [DataMember(Name="CertificateUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CertificateUserId")]
    public int? CertificateUserId { get; set; }

    /// <summary>
    /// Thumbprint associated with the certificate user.
    /// </summary>
    /// <value>Thumbprint associated with the certificate user.</value>
    [DataMember(Name="CertificateUserThumbprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CertificateUserThumbprint")]
    public string CertificateUserThumbprint { get; set; }

    /// <summary>
    /// The certificate user associated with the linked session module.
    /// </summary>
    /// <value>The certificate user associated with the linked session module.</value>
    [DataMember(Name="CertificateUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CertificateUser")]
    public string CertificateUser { get; set; }

    /// <summary>
    /// Thumbprint associated with the certificate user.
    /// </summary>
    /// <value>Thumbprint associated with the certificate user.</value>
    [DataMember(Name="ClientCertificateThumbprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClientCertificateThumbprint")]
    public string ClientCertificateThumbprint { get; set; }

    /// <summary>
    /// Use the SPS host name rather than IP address when launching a session.
    /// </summary>
    /// <value>Use the SPS host name rather than IP address when launching a session.</value>
    [DataMember(Name="UseHostNameForLaunch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseHostNameForLaunch")]
    public bool? UseHostNameForLaunch { get; set; }

    /// <summary>
    /// Firmware version of the SPS appliance.
    /// </summary>
    /// <value>Firmware version of the SPS appliance.</value>
    [DataMember(Name="FirmwareVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirmwareVersion")]
    public string FirmwareVersion { get; set; }

    /// <summary>
    /// Date this entity was created (Read-only)
    /// </summary>
    /// <value>Date this entity was created (Read-only)</value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The database ID of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The database ID of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserId")]
    public int? CreatedByUserId { get; set; }

    /// <summary>
    /// The display name of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The display name of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserDisplayName")]
    public string CreatedByUserDisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SessionModuleConnection {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  SpsNetworkAddress: ").Append(SpsNetworkAddress).Append("\n");
      sb.Append("  SpsHostName: ").Append(SpsHostName).Append("\n");
      sb.Append("  CertificateUserCsr: ").Append(CertificateUserCsr).Append("\n");
      sb.Append("  SppSslPemEncodedCertificateChain: ").Append(SppSslPemEncodedCertificateChain).Append("\n");
      sb.Append("  OneTimeToken: ").Append(OneTimeToken).Append("\n");
      sb.Append("  Trusted: ").Append(Trusted).Append("\n");
      sb.Append("  CertificateUserPemEncodedCertificate: ").Append(CertificateUserPemEncodedCertificate).Append("\n");
      sb.Append("  CertificateUserId: ").Append(CertificateUserId).Append("\n");
      sb.Append("  CertificateUserThumbprint: ").Append(CertificateUserThumbprint).Append("\n");
      sb.Append("  CertificateUser: ").Append(CertificateUser).Append("\n");
      sb.Append("  ClientCertificateThumbprint: ").Append(ClientCertificateThumbprint).Append("\n");
      sb.Append("  UseHostNameForLaunch: ").Append(UseHostNameForLaunch).Append("\n");
      sb.Append("  FirmwareVersion: ").Append(FirmwareVersion).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
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
