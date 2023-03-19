using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a request for getting a certificate signature from a CA
  /// </summary>
  [DataContract]
  public class ServerCertificateSignatureRequest {
    /// <summary>
    /// The Subject as found on the request: \"Subject\":\"CN=fully.qualified.domain.name, OU=Organizational Unit, O=Company, L=City, S=State, C=Country\"
    /// </summary>
    /// <value>The Subject as found on the request: \"Subject\":\"CN=fully.qualified.domain.name, OU=Organizational Unit, O=Company, L=City, S=State, C=Country\"</value>
    [DataMember(Name="Subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Subject")]
    public string Subject { get; set; }

    /// <summary>
    /// The length of the key  <default>2048</default>
    /// </summary>
    /// <value>The length of the key  <default>2048</default></value>
    [DataMember(Name="KeyLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "KeyLength")]
    public int? KeyLength { get; set; }

    /// <summary>
    /// The resulting request data encode in Base64 (Read-only)
    /// </summary>
    /// <value>The resulting request data encode in Base64 (Read-only)</value>
    [DataMember(Name="Base64RequestData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Base64RequestData")]
    public string Base64RequestData { get; set; }

    /// <summary>
    /// List of alternate DNS names attached to the certificate (Read-only)
    /// </summary>
    /// <value>List of alternate DNS names attached to the certificate (Read-only)</value>
    [DataMember(Name="DnsNames", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DnsNames")]
    public List<string> DnsNames { get; set; }

    /// <summary>
    /// List of alternate IP addressesattached to the certificate (Read-only)
    /// </summary>
    /// <value>List of alternate IP addressesattached to the certificate (Read-only)</value>
    [DataMember(Name="IpAddresses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IpAddresses")]
    public List<string> IpAddresses { get; set; }

    /// <summary>
    /// Thumbprint of the pending certificate (Read-only)
    /// </summary>
    /// <value>Thumbprint of the pending certificate (Read-only)</value>
    [DataMember(Name="Thumbprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Thumbprint")]
    public string Thumbprint { get; set; }

    /// <summary>
    /// who the request was issued by (Read-only)
    /// </summary>
    /// <value>who the request was issued by (Read-only)</value>
    [DataMember(Name="IssuedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IssuedBy")]
    public string IssuedBy { get; set; }

    /// <summary>
    /// When the request becomes valid (Read-only)
    /// </summary>
    /// <value>When the request becomes valid (Read-only)</value>
    [DataMember(Name="NotBefore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NotBefore")]
    public DateTime? NotBefore { get; set; }

    /// <summary>
    /// When the request becomes expired (Read-only)
    /// </summary>
    /// <value>When the request becomes expired (Read-only)</value>
    [DataMember(Name="NotAfter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NotAfter")]
    public DateTime? NotAfter { get; set; }

    /// <summary>
    /// Gets or Sets CertificateType
    /// </summary>
    [DataMember(Name="CertificateType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CertificateType")]
    public ServerCertificateSignatureRequestType CertificateType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServerCertificateSignatureRequest {\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      sb.Append("  KeyLength: ").Append(KeyLength).Append("\n");
      sb.Append("  Base64RequestData: ").Append(Base64RequestData).Append("\n");
      sb.Append("  DnsNames: ").Append(DnsNames).Append("\n");
      sb.Append("  IpAddresses: ").Append(IpAddresses).Append("\n");
      sb.Append("  Thumbprint: ").Append(Thumbprint).Append("\n");
      sb.Append("  IssuedBy: ").Append(IssuedBy).Append("\n");
      sb.Append("  NotBefore: ").Append(NotBefore).Append("\n");
      sb.Append("  NotAfter: ").Append(NotAfter).Append("\n");
      sb.Append("  CertificateType: ").Append(CertificateType).Append("\n");
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
