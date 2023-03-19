using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a certificate from a certificate store on the appliance
  /// </summary>
  [DataContract]
  public class ServerCertificateLog {
    /// <summary>
    /// The Subject of the certificate (Read-only)
    /// </summary>
    /// <value>The Subject of the certificate (Read-only)</value>
    [DataMember(Name="Subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Subject")]
    public string Subject { get; set; }

    /// <summary>
    /// Base64 encoded public certificate DER data (Read-only)
    /// </summary>
    /// <value>Base64 encoded public certificate DER data (Read-only)</value>
    [DataMember(Name="Base64CertificateData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Base64CertificateData")]
    public string Base64CertificateData { get; set; }

    /// <summary>
    /// Whether or not this certificate is a certificate authority (Read-only)
    /// </summary>
    /// <value>Whether or not this certificate is a certificate authority (Read-only)</value>
    [DataMember(Name="IsCertificateAuthority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsCertificateAuthority")]
    public bool? IsCertificateAuthority { get; set; }

    /// <summary>
    /// The CA that issued the certificate (Read-only)
    /// </summary>
    /// <value>The CA that issued the certificate (Read-only)</value>
    [DataMember(Name="IssuedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IssuedBy")]
    public string IssuedBy { get; set; }

    /// <summary>
    /// Base64 encoded certificate DER data for issuing certificates (Read-only)
    /// </summary>
    /// <value>Base64 encoded certificate DER data for issuing certificates (Read-only)</value>
    [DataMember(Name="IssuerCertificates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IssuerCertificates")]
    public List<string> IssuerCertificates { get; set; }

    /// <summary>
    /// List of alternate DNS names attached to the certificate (Read-only)
    /// </summary>
    /// <value>List of alternate DNS names attached to the certificate (Read-only)</value>
    [DataMember(Name="DnsNames", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DnsNames")]
    public List<string> DnsNames { get; set; }

    /// <summary>
    /// List of alternate IP addresses attached to the certificate (Read-only)
    /// </summary>
    /// <value>List of alternate IP addresses attached to the certificate (Read-only)</value>
    [DataMember(Name="IpAddresses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IpAddresses")]
    public List<string> IpAddresses { get; set; }

    /// <summary>
    /// The date the certificate becomes valid (Read-only)
    /// </summary>
    /// <value>The date the certificate becomes valid (Read-only)</value>
    [DataMember(Name="NotBefore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NotBefore")]
    public DateTime? NotBefore { get; set; }

    /// <summary>
    /// The date the certificate expires (Read-only)
    /// </summary>
    /// <value>The date the certificate expires (Read-only)</value>
    [DataMember(Name="NotAfter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NotAfter")]
    public DateTime? NotAfter { get; set; }

    /// <summary>
    /// The thumbprint of the certificate (Read-only)
    /// </summary>
    /// <value>The thumbprint of the certificate (Read-only)</value>
    [DataMember(Name="Thumbprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Thumbprint")]
    public string Thumbprint { get; set; }

    /// <summary>
    /// The passphrase for decrypting the certificate (Read-only)
    /// </summary>
    /// <value>The passphrase for decrypting the certificate (Read-only)</value>
    [DataMember(Name="Passphrase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Passphrase")]
    public string Passphrase { get; set; }

    /// <summary>
    /// Gets or Sets CertificateType
    /// </summary>
    [DataMember(Name="CertificateType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CertificateType")]
    public CertificateType CertificateType { get; set; }

    /// <summary>
    /// System owned certificates cannot be deleted (Read-Only)
    /// </summary>
    /// <value>System owned certificates cannot be deleted (Read-Only)</value>
    [DataMember(Name="IsSystemOwned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSystemOwned")]
    public bool? IsSystemOwned { get; set; }

    /// <summary>
    /// Whether private key was generated on a secure appliance (Read-Only)
    /// </summary>
    /// <value>Whether private key was generated on a secure appliance (Read-Only)</value>
    [DataMember(Name="SystemOwnedPrivateKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SystemOwnedPrivateKey")]
    public bool? SystemOwnedPrivateKey { get; set; }

    /// <summary>
    /// The date the certificate was installed (Read-only)
    /// </summary>
    /// <value>The date the certificate was installed (Read-only)</value>
    [DataMember(Name="InstalledDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InstalledDate")]
    public DateTime? InstalledDate { get; set; }

    /// <summary>
    /// The date the certificate was replaced by a new certificate (Read-only)
    /// </summary>
    /// <value>The date the certificate was replaced by a new certificate (Read-only)</value>
    [DataMember(Name="ReplacedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReplacedDate")]
    public DateTime? ReplacedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServerCertificateLog {\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      sb.Append("  Base64CertificateData: ").Append(Base64CertificateData).Append("\n");
      sb.Append("  IsCertificateAuthority: ").Append(IsCertificateAuthority).Append("\n");
      sb.Append("  IssuedBy: ").Append(IssuedBy).Append("\n");
      sb.Append("  IssuerCertificates: ").Append(IssuerCertificates).Append("\n");
      sb.Append("  DnsNames: ").Append(DnsNames).Append("\n");
      sb.Append("  IpAddresses: ").Append(IpAddresses).Append("\n");
      sb.Append("  NotBefore: ").Append(NotBefore).Append("\n");
      sb.Append("  NotAfter: ").Append(NotAfter).Append("\n");
      sb.Append("  Thumbprint: ").Append(Thumbprint).Append("\n");
      sb.Append("  Passphrase: ").Append(Passphrase).Append("\n");
      sb.Append("  CertificateType: ").Append(CertificateType).Append("\n");
      sb.Append("  IsSystemOwned: ").Append(IsSystemOwned).Append("\n");
      sb.Append("  SystemOwnedPrivateKey: ").Append(SystemOwnedPrivateKey).Append("\n");
      sb.Append("  InstalledDate: ").Append(InstalledDate).Append("\n");
      sb.Append("  ReplacedDate: ").Append(ReplacedDate).Append("\n");
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
