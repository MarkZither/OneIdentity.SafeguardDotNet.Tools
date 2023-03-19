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
    /// Represents a session module connection to a Safeguard cluster.
    /// </summary>
    [DataContract]
    public partial class SessionModuleConnection : IEquatable<SessionModuleConnection>
    { 
        /// <summary>
        /// Unique Id of the connected session module.
        /// </summary>
        /// <value>Unique Id of the connected session module.</value>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Node Id of the session module.
        /// </summary>
        /// <value>Node Id of the session module.</value>
        [Required]

        [MaxLength(255)]
        [DataMember(Name="NodeId")]
        public string NodeId { get; set; }

        /// <summary>
        /// Description of the session module.
        /// </summary>
        /// <value>Description of the session module.</value>

        [MaxLength(255)]
        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// REST access IP address.
        /// </summary>
        /// <value>REST access IP address.</value>

        [DataMember(Name="SpsNetworkAddress")]
        public string SpsNetworkAddress { get; set; }

        /// <summary>
        /// SPS host name.
        /// </summary>
        /// <value>SPS host name.</value>

        [DataMember(Name="SpsHostName")]
        public string SpsHostName { get; set; }

        /// <summary>
        /// Certificate Signing Request generated by SPS and to be signed by SPP.  The signed certificate will also be  associated with the certificate user created by SPP and used by SPS for authentication.
        /// </summary>
        /// <value>Certificate Signing Request generated by SPS and to be signed by SPP.  The signed certificate will also be  associated with the certificate user created by SPP and used by SPS for authentication.</value>

        [DataMember(Name="CertificateUserCsr")]
        public string CertificateUserCsr { get; set; }

        /// <summary>
        /// Current SSL PEM certificate chain.
        /// </summary>
        /// <value>Current SSL PEM certificate chain.</value>

        [DataMember(Name="SppSslPemEncodedCertificateChain")]
        public string SppSslPemEncodedCertificateChain { get; set; }

        /// <summary>
        /// One time use token used by the linked session module to get the final trust validation.
        /// </summary>
        /// <value>One time use token used by the linked session module to get the final trust validation.</value>

        [DataMember(Name="OneTimeToken")]
        public string OneTimeToken { get; set; }

        /// <summary>
        /// Indicates if the session module connection is trusted.
        /// </summary>
        /// <value>Indicates if the session module connection is trusted.</value>

        [DataMember(Name="Trusted")]
        public bool? Trusted { get; set; }

        /// <summary>
        /// Signed certificate generated from the CertificateUser Csr.
        /// </summary>
        /// <value>Signed certificate generated from the CertificateUser Csr.</value>

        [DataMember(Name="CertificateUserPemEncodedCertificate")]
        public string CertificateUserPemEncodedCertificate { get; set; }

        /// <summary>
        /// The id of the certificate user associated with the session module connection.
        /// </summary>
        /// <value>The id of the certificate user associated with the session module connection.</value>

        [DataMember(Name="CertificateUserId")]
        public int? CertificateUserId { get; set; }

        /// <summary>
        /// Thumbprint associated with the certificate user.
        /// </summary>
        /// <value>Thumbprint associated with the certificate user.</value>

        [DataMember(Name="CertificateUserThumbprint")]
        public string CertificateUserThumbprint { get; set; }

        /// <summary>
        /// The certificate user associated with the linked session module.
        /// </summary>
        /// <value>The certificate user associated with the linked session module.</value>

        [DataMember(Name="CertificateUser")]
        public string CertificateUser { get; set; }

        /// <summary>
        /// Thumbprint associated with the certificate user.
        /// </summary>
        /// <value>Thumbprint associated with the certificate user.</value>

        [DataMember(Name="ClientCertificateThumbprint")]
        public string ClientCertificateThumbprint { get; set; }

        /// <summary>
        /// Use the SPS host name rather than IP address when launching a session.
        /// </summary>
        /// <value>Use the SPS host name rather than IP address when launching a session.</value>

        [DataMember(Name="UseHostNameForLaunch")]
        public bool? UseHostNameForLaunch { get; set; }

        /// <summary>
        /// Firmware version of the SPS appliance.
        /// </summary>
        /// <value>Firmware version of the SPS appliance.</value>

        [DataMember(Name="FirmwareVersion")]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// Date this entity was created (Read-only)
        /// </summary>
        /// <value>Date this entity was created (Read-only)</value>

        [DataMember(Name="CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// The database ID of the user that created this entity (Read-only)
        /// </summary>
        /// <value>The database ID of the user that created this entity (Read-only)</value>

        [DataMember(Name="CreatedByUserId")]
        public int? CreatedByUserId { get; set; }

        /// <summary>
        /// The display name of the user that created this entity (Read-only)
        /// </summary>
        /// <value>The display name of the user that created this entity (Read-only)</value>

        [DataMember(Name="CreatedByUserDisplayName")]
        public string CreatedByUserDisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
            return obj.GetType() == GetType() && Equals((SessionModuleConnection)obj);
        }

        /// <summary>
        /// Returns true if SessionModuleConnection instances are equal
        /// </summary>
        /// <param name="other">Instance of SessionModuleConnection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionModuleConnection other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    NodeId == other.NodeId ||
                    NodeId != null &&
                    NodeId.Equals(other.NodeId)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    SpsNetworkAddress == other.SpsNetworkAddress ||
                    SpsNetworkAddress != null &&
                    SpsNetworkAddress.Equals(other.SpsNetworkAddress)
                ) && 
                (
                    SpsHostName == other.SpsHostName ||
                    SpsHostName != null &&
                    SpsHostName.Equals(other.SpsHostName)
                ) && 
                (
                    CertificateUserCsr == other.CertificateUserCsr ||
                    CertificateUserCsr != null &&
                    CertificateUserCsr.Equals(other.CertificateUserCsr)
                ) && 
                (
                    SppSslPemEncodedCertificateChain == other.SppSslPemEncodedCertificateChain ||
                    SppSslPemEncodedCertificateChain != null &&
                    SppSslPemEncodedCertificateChain.Equals(other.SppSslPemEncodedCertificateChain)
                ) && 
                (
                    OneTimeToken == other.OneTimeToken ||
                    OneTimeToken != null &&
                    OneTimeToken.Equals(other.OneTimeToken)
                ) && 
                (
                    Trusted == other.Trusted ||
                    Trusted != null &&
                    Trusted.Equals(other.Trusted)
                ) && 
                (
                    CertificateUserPemEncodedCertificate == other.CertificateUserPemEncodedCertificate ||
                    CertificateUserPemEncodedCertificate != null &&
                    CertificateUserPemEncodedCertificate.Equals(other.CertificateUserPemEncodedCertificate)
                ) && 
                (
                    CertificateUserId == other.CertificateUserId ||
                    CertificateUserId != null &&
                    CertificateUserId.Equals(other.CertificateUserId)
                ) && 
                (
                    CertificateUserThumbprint == other.CertificateUserThumbprint ||
                    CertificateUserThumbprint != null &&
                    CertificateUserThumbprint.Equals(other.CertificateUserThumbprint)
                ) && 
                (
                    CertificateUser == other.CertificateUser ||
                    CertificateUser != null &&
                    CertificateUser.Equals(other.CertificateUser)
                ) && 
                (
                    ClientCertificateThumbprint == other.ClientCertificateThumbprint ||
                    ClientCertificateThumbprint != null &&
                    ClientCertificateThumbprint.Equals(other.ClientCertificateThumbprint)
                ) && 
                (
                    UseHostNameForLaunch == other.UseHostNameForLaunch ||
                    UseHostNameForLaunch != null &&
                    UseHostNameForLaunch.Equals(other.UseHostNameForLaunch)
                ) && 
                (
                    FirmwareVersion == other.FirmwareVersion ||
                    FirmwareVersion != null &&
                    FirmwareVersion.Equals(other.FirmwareVersion)
                ) && 
                (
                    CreatedDate == other.CreatedDate ||
                    CreatedDate != null &&
                    CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    CreatedByUserId == other.CreatedByUserId ||
                    CreatedByUserId != null &&
                    CreatedByUserId.Equals(other.CreatedByUserId)
                ) && 
                (
                    CreatedByUserDisplayName == other.CreatedByUserDisplayName ||
                    CreatedByUserDisplayName != null &&
                    CreatedByUserDisplayName.Equals(other.CreatedByUserDisplayName)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (NodeId != null)
                    hashCode = hashCode * 59 + NodeId.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (SpsNetworkAddress != null)
                    hashCode = hashCode * 59 + SpsNetworkAddress.GetHashCode();
                    if (SpsHostName != null)
                    hashCode = hashCode * 59 + SpsHostName.GetHashCode();
                    if (CertificateUserCsr != null)
                    hashCode = hashCode * 59 + CertificateUserCsr.GetHashCode();
                    if (SppSslPemEncodedCertificateChain != null)
                    hashCode = hashCode * 59 + SppSslPemEncodedCertificateChain.GetHashCode();
                    if (OneTimeToken != null)
                    hashCode = hashCode * 59 + OneTimeToken.GetHashCode();
                    if (Trusted != null)
                    hashCode = hashCode * 59 + Trusted.GetHashCode();
                    if (CertificateUserPemEncodedCertificate != null)
                    hashCode = hashCode * 59 + CertificateUserPemEncodedCertificate.GetHashCode();
                    if (CertificateUserId != null)
                    hashCode = hashCode * 59 + CertificateUserId.GetHashCode();
                    if (CertificateUserThumbprint != null)
                    hashCode = hashCode * 59 + CertificateUserThumbprint.GetHashCode();
                    if (CertificateUser != null)
                    hashCode = hashCode * 59 + CertificateUser.GetHashCode();
                    if (ClientCertificateThumbprint != null)
                    hashCode = hashCode * 59 + ClientCertificateThumbprint.GetHashCode();
                    if (UseHostNameForLaunch != null)
                    hashCode = hashCode * 59 + UseHostNameForLaunch.GetHashCode();
                    if (FirmwareVersion != null)
                    hashCode = hashCode * 59 + FirmwareVersion.GetHashCode();
                    if (CreatedDate != null)
                    hashCode = hashCode * 59 + CreatedDate.GetHashCode();
                    if (CreatedByUserId != null)
                    hashCode = hashCode * 59 + CreatedByUserId.GetHashCode();
                    if (CreatedByUserDisplayName != null)
                    hashCode = hashCode * 59 + CreatedByUserDisplayName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SessionModuleConnection left, SessionModuleConnection right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SessionModuleConnection left, SessionModuleConnection right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
