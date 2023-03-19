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
    /// Represents a syslog server where data and events can be sent
    /// </summary>
    [DataContract]
    public partial class SyslogServer : IEquatable<SyslogServer>
    { 
        /// <summary>
        /// Unique database ID of this server configuration
        /// </summary>
        /// <value>Unique database ID of this server configuration</value>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Name of this server
        /// </summary>
        /// <value>Name of this server</value>
        [Required]

        [MaxLength(50)]
        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Network address of syslog server
        /// </summary>
        /// <value>Network address of syslog server</value>
        [Required]

        [MaxLength(255)]
        [DataMember(Name="NetworkAddress")]
        public string NetworkAddress { get; set; }

        /// <summary>
        /// Port to connect to syslog server
        /// </summary>
        /// <value>Port to connect to syslog server</value>

        [Range(1, 32767)]
        [DataMember(Name="Port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>

        [DataMember(Name="Protocol")]
        public SyslogProtocol Protocol { get; set; }

        /// <summary>
        /// Whether to encrypt data with SSL. Only valid when using TCP protocol.
        /// </summary>
        /// <value>Whether to encrypt data with SSL. Only valid when using TCP protocol.</value>

        [DataMember(Name="UseSslEncryption")]
        public bool? UseSslEncryption { get; set; }

        /// <summary>
        /// Whether to authenticate to syslog server with client certificate. Requires that SyslogClientCertificate is configured. Only valid when using SSL encryption
        /// </summary>
        /// <value>Whether to authenticate to syslog server with client certificate. Requires that SyslogClientCertificate is configured. Only valid when using SSL encryption</value>

        [DataMember(Name="UseClientCertificate")]
        public bool? UseClientCertificate { get; set; }

        /// <summary>
        /// Verify SSL certificate if using SSL. Only valid when using SSL encryption
        /// </summary>
        /// <value>Verify SSL certificate if using SSL. Only valid when using SSL encryption</value>

        [DataMember(Name="VerifySslCertificate")]
        public bool? VerifySslCertificate { get; set; }

        /// <summary>
        /// Gets or Sets TcpFraming
        /// </summary>

        [DataMember(Name="TcpFraming")]
        public SyslogTcpFraming TcpFraming { get; set; }

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
            sb.Append("class SyslogServer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  UseSslEncryption: ").Append(UseSslEncryption).Append("\n");
            sb.Append("  UseClientCertificate: ").Append(UseClientCertificate).Append("\n");
            sb.Append("  VerifySslCertificate: ").Append(VerifySslCertificate).Append("\n");
            sb.Append("  TcpFraming: ").Append(TcpFraming).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SyslogServer)obj);
        }

        /// <summary>
        /// Returns true if SyslogServer instances are equal
        /// </summary>
        /// <param name="other">Instance of SyslogServer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyslogServer other)
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
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    NetworkAddress == other.NetworkAddress ||
                    NetworkAddress != null &&
                    NetworkAddress.Equals(other.NetworkAddress)
                ) && 
                (
                    Port == other.Port ||
                    Port != null &&
                    Port.Equals(other.Port)
                ) && 
                (
                    Protocol == other.Protocol ||
                    Protocol != null &&
                    Protocol.Equals(other.Protocol)
                ) && 
                (
                    UseSslEncryption == other.UseSslEncryption ||
                    UseSslEncryption != null &&
                    UseSslEncryption.Equals(other.UseSslEncryption)
                ) && 
                (
                    UseClientCertificate == other.UseClientCertificate ||
                    UseClientCertificate != null &&
                    UseClientCertificate.Equals(other.UseClientCertificate)
                ) && 
                (
                    VerifySslCertificate == other.VerifySslCertificate ||
                    VerifySslCertificate != null &&
                    VerifySslCertificate.Equals(other.VerifySslCertificate)
                ) && 
                (
                    TcpFraming == other.TcpFraming ||
                    TcpFraming != null &&
                    TcpFraming.Equals(other.TcpFraming)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (NetworkAddress != null)
                    hashCode = hashCode * 59 + NetworkAddress.GetHashCode();
                    if (Port != null)
                    hashCode = hashCode * 59 + Port.GetHashCode();
                    if (Protocol != null)
                    hashCode = hashCode * 59 + Protocol.GetHashCode();
                    if (UseSslEncryption != null)
                    hashCode = hashCode * 59 + UseSslEncryption.GetHashCode();
                    if (UseClientCertificate != null)
                    hashCode = hashCode * 59 + UseClientCertificate.GetHashCode();
                    if (VerifySslCertificate != null)
                    hashCode = hashCode * 59 + VerifySslCertificate.GetHashCode();
                    if (TcpFraming != null)
                    hashCode = hashCode * 59 + TcpFraming.GetHashCode();
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

        public static bool operator ==(SyslogServer left, SyslogServer right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SyslogServer left, SyslogServer right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
