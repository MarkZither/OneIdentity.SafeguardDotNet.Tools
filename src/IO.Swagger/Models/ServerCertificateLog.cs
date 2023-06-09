/*
 * Safeguard Core API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v4
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// Represents a certificate from a certificate store on the appliance
    /// </summary>
    [DataContract]
    public partial class ServerCertificateLog : IEquatable<ServerCertificateLog>
    { 
        /// <summary>
        /// The Subject of the certificate (Read-only)
        /// </summary>
        /// <value>The Subject of the certificate (Read-only)</value>

        [DataMember(Name="Subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Base64 encoded public certificate DER data (Read-only)
        /// </summary>
        /// <value>Base64 encoded public certificate DER data (Read-only)</value>
        [Required]

        [DataMember(Name="Base64CertificateData")]
        public string Base64CertificateData { get; set; }

        /// <summary>
        /// Whether or not this certificate is a certificate authority (Read-only)
        /// </summary>
        /// <value>Whether or not this certificate is a certificate authority (Read-only)</value>

        [DataMember(Name="IsCertificateAuthority")]
        public bool? IsCertificateAuthority { get; set; }

        /// <summary>
        /// The CA that issued the certificate (Read-only)
        /// </summary>
        /// <value>The CA that issued the certificate (Read-only)</value>

        [DataMember(Name="IssuedBy")]
        public string IssuedBy { get; set; }

        /// <summary>
        /// Base64 encoded certificate DER data for issuing certificates (Read-only)
        /// </summary>
        /// <value>Base64 encoded certificate DER data for issuing certificates (Read-only)</value>

        [DataMember(Name="IssuerCertificates")]
        public List<string> IssuerCertificates { get; set; }

        /// <summary>
        /// List of alternate DNS names attached to the certificate (Read-only)
        /// </summary>
        /// <value>List of alternate DNS names attached to the certificate (Read-only)</value>

        [DataMember(Name="DnsNames")]
        public List<string> DnsNames { get; set; }

        /// <summary>
        /// List of alternate IP addresses attached to the certificate (Read-only)
        /// </summary>
        /// <value>List of alternate IP addresses attached to the certificate (Read-only)</value>

        [DataMember(Name="IpAddresses")]
        public List<string> IpAddresses { get; set; }

        /// <summary>
        /// The date the certificate becomes valid (Read-only)
        /// </summary>
        /// <value>The date the certificate becomes valid (Read-only)</value>

        [DataMember(Name="NotBefore")]
        public DateTime? NotBefore { get; set; }

        /// <summary>
        /// The date the certificate expires (Read-only)
        /// </summary>
        /// <value>The date the certificate expires (Read-only)</value>

        [DataMember(Name="NotAfter")]
        public DateTime? NotAfter { get; set; }

        /// <summary>
        /// The thumbprint of the certificate (Read-only)
        /// </summary>
        /// <value>The thumbprint of the certificate (Read-only)</value>

        [DataMember(Name="Thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// The passphrase for decrypting the certificate (Read-only)
        /// </summary>
        /// <value>The passphrase for decrypting the certificate (Read-only)</value>

        [DataMember(Name="Passphrase")]
        public string Passphrase { get; set; }

        /// <summary>
        /// Gets or Sets CertificateType
        /// </summary>

        [DataMember(Name="CertificateType")]
        public CertificateType CertificateType { get; set; }

        /// <summary>
        /// System owned certificates cannot be deleted (Read-Only)
        /// </summary>
        /// <value>System owned certificates cannot be deleted (Read-Only)</value>

        [DataMember(Name="IsSystemOwned")]
        public bool? IsSystemOwned { get; set; }

        /// <summary>
        /// Whether private key was generated on a secure appliance (Read-Only)
        /// </summary>
        /// <value>Whether private key was generated on a secure appliance (Read-Only)</value>

        [DataMember(Name="SystemOwnedPrivateKey")]
        public bool? SystemOwnedPrivateKey { get; set; }

        /// <summary>
        /// The date the certificate was installed (Read-only)
        /// </summary>
        /// <value>The date the certificate was installed (Read-only)</value>

        [DataMember(Name="InstalledDate")]
        public DateTime? InstalledDate { get; set; }

        /// <summary>
        /// The date the certificate was replaced by a new certificate (Read-only)
        /// </summary>
        /// <value>The date the certificate was replaced by a new certificate (Read-only)</value>

        [DataMember(Name="ReplacedDate")]
        public DateTime? ReplacedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ServerCertificateLog)obj);
        }

        /// <summary>
        /// Returns true if ServerCertificateLog instances are equal
        /// </summary>
        /// <param name="other">Instance of ServerCertificateLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerCertificateLog other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Subject == other.Subject ||
                    Subject != null &&
                    Subject.Equals(other.Subject)
                ) && 
                (
                    Base64CertificateData == other.Base64CertificateData ||
                    Base64CertificateData != null &&
                    Base64CertificateData.Equals(other.Base64CertificateData)
                ) && 
                (
                    IsCertificateAuthority == other.IsCertificateAuthority ||
                    IsCertificateAuthority != null &&
                    IsCertificateAuthority.Equals(other.IsCertificateAuthority)
                ) && 
                (
                    IssuedBy == other.IssuedBy ||
                    IssuedBy != null &&
                    IssuedBy.Equals(other.IssuedBy)
                ) && 
                (
                    IssuerCertificates == other.IssuerCertificates ||
                    IssuerCertificates != null &&
                    IssuerCertificates.SequenceEqual(other.IssuerCertificates)
                ) && 
                (
                    DnsNames == other.DnsNames ||
                    DnsNames != null &&
                    DnsNames.SequenceEqual(other.DnsNames)
                ) && 
                (
                    IpAddresses == other.IpAddresses ||
                    IpAddresses != null &&
                    IpAddresses.SequenceEqual(other.IpAddresses)
                ) && 
                (
                    NotBefore == other.NotBefore ||
                    NotBefore != null &&
                    NotBefore.Equals(other.NotBefore)
                ) && 
                (
                    NotAfter == other.NotAfter ||
                    NotAfter != null &&
                    NotAfter.Equals(other.NotAfter)
                ) && 
                (
                    Thumbprint == other.Thumbprint ||
                    Thumbprint != null &&
                    Thumbprint.Equals(other.Thumbprint)
                ) && 
                (
                    Passphrase == other.Passphrase ||
                    Passphrase != null &&
                    Passphrase.Equals(other.Passphrase)
                ) && 
                (
                    CertificateType == other.CertificateType ||
                    CertificateType != null &&
                    CertificateType.Equals(other.CertificateType)
                ) && 
                (
                    IsSystemOwned == other.IsSystemOwned ||
                    IsSystemOwned != null &&
                    IsSystemOwned.Equals(other.IsSystemOwned)
                ) && 
                (
                    SystemOwnedPrivateKey == other.SystemOwnedPrivateKey ||
                    SystemOwnedPrivateKey != null &&
                    SystemOwnedPrivateKey.Equals(other.SystemOwnedPrivateKey)
                ) && 
                (
                    InstalledDate == other.InstalledDate ||
                    InstalledDate != null &&
                    InstalledDate.Equals(other.InstalledDate)
                ) && 
                (
                    ReplacedDate == other.ReplacedDate ||
                    ReplacedDate != null &&
                    ReplacedDate.Equals(other.ReplacedDate)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Subject != null)
                    hashCode = hashCode * 59 + Subject.GetHashCode();
                    if (Base64CertificateData != null)
                    hashCode = hashCode * 59 + Base64CertificateData.GetHashCode();
                    if (IsCertificateAuthority != null)
                    hashCode = hashCode * 59 + IsCertificateAuthority.GetHashCode();
                    if (IssuedBy != null)
                    hashCode = hashCode * 59 + IssuedBy.GetHashCode();
                    if (IssuerCertificates != null)
                    hashCode = hashCode * 59 + IssuerCertificates.GetHashCode();
                    if (DnsNames != null)
                    hashCode = hashCode * 59 + DnsNames.GetHashCode();
                    if (IpAddresses != null)
                    hashCode = hashCode * 59 + IpAddresses.GetHashCode();
                    if (NotBefore != null)
                    hashCode = hashCode * 59 + NotBefore.GetHashCode();
                    if (NotAfter != null)
                    hashCode = hashCode * 59 + NotAfter.GetHashCode();
                    if (Thumbprint != null)
                    hashCode = hashCode * 59 + Thumbprint.GetHashCode();
                    if (Passphrase != null)
                    hashCode = hashCode * 59 + Passphrase.GetHashCode();
                    if (CertificateType != null)
                    hashCode = hashCode * 59 + CertificateType.GetHashCode();
                    if (IsSystemOwned != null)
                    hashCode = hashCode * 59 + IsSystemOwned.GetHashCode();
                    if (SystemOwnedPrivateKey != null)
                    hashCode = hashCode * 59 + SystemOwnedPrivateKey.GetHashCode();
                    if (InstalledDate != null)
                    hashCode = hashCode * 59 + InstalledDate.GetHashCode();
                    if (ReplacedDate != null)
                    hashCode = hashCode * 59 + ReplacedDate.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ServerCertificateLog left, ServerCertificateLog right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ServerCertificateLog left, ServerCertificateLog right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
