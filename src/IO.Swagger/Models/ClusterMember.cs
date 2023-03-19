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
    /// 
    /// </summary>
    [DataContract]
    public partial class ClusterMember : IEquatable<ClusterMember>
    { 
        /// <summary>
        /// Gets or Sets Health
        /// </summary>

        [DataMember(Name="Health")]
        public NodeHealth Health { get; set; }

        /// <summary>
        /// Unique Id of the cluster member
        /// </summary>
        /// <value>Unique Id of the cluster member</value>

        [DataMember(Name="Id")]
        public string Id { get; set; }

        /// <summary>
        /// Flag indicating whether the member is the cluster leader
        /// </summary>
        /// <value>Flag indicating whether the member is the cluster leader</value>

        [DataMember(Name="IsLeader")]
        public bool? IsLeader { get; set; }

        /// <summary>
        /// Name of the cluster member
        /// </summary>
        /// <value>Name of the cluster member</value>

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// HostDnsSuffix of the cluster member
        /// </summary>
        /// <value>HostDnsSuffix of the cluster member</value>

        [DataMember(Name="HostDnsSuffix")]
        public string HostDnsSuffix { get; set; }

        /// <summary>
        /// The Ipv4 address of the cluster member
        /// </summary>
        /// <value>The Ipv4 address of the cluster member</value>

        [DataMember(Name="Ipv4Address")]
        public string Ipv4Address { get; set; }

        /// <summary>
        /// The Ipv6 address of the cluster member
        /// </summary>
        /// <value>The Ipv6 address of the cluster member</value>

        [DataMember(Name="Ipv6Address")]
        public string Ipv6Address { get; set; }

        /// <summary>
        /// The thumbprint of the certificate used for SSL
        /// </summary>
        /// <value>The thumbprint of the certificate used for SSL</value>

        [DataMember(Name="SslCertificateThumbprint")]
        public string SslCertificateThumbprint { get; set; }

        /// <summary>
        /// The timestamp when this member was enrolled in the cluster
        /// </summary>
        /// <value>The timestamp when this member was enrolled in the cluster</value>

        [DataMember(Name="EnrolledSince")]
        public DateTime? EnrolledSince { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterMember {\n");
            sb.Append("  Health: ").Append(Health).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsLeader: ").Append(IsLeader).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HostDnsSuffix: ").Append(HostDnsSuffix).Append("\n");
            sb.Append("  Ipv4Address: ").Append(Ipv4Address).Append("\n");
            sb.Append("  Ipv6Address: ").Append(Ipv6Address).Append("\n");
            sb.Append("  SslCertificateThumbprint: ").Append(SslCertificateThumbprint).Append("\n");
            sb.Append("  EnrolledSince: ").Append(EnrolledSince).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ClusterMember)obj);
        }

        /// <summary>
        /// Returns true if ClusterMember instances are equal
        /// </summary>
        /// <param name="other">Instance of ClusterMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterMember other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Health == other.Health ||
                    Health != null &&
                    Health.Equals(other.Health)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    IsLeader == other.IsLeader ||
                    IsLeader != null &&
                    IsLeader.Equals(other.IsLeader)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    HostDnsSuffix == other.HostDnsSuffix ||
                    HostDnsSuffix != null &&
                    HostDnsSuffix.Equals(other.HostDnsSuffix)
                ) && 
                (
                    Ipv4Address == other.Ipv4Address ||
                    Ipv4Address != null &&
                    Ipv4Address.Equals(other.Ipv4Address)
                ) && 
                (
                    Ipv6Address == other.Ipv6Address ||
                    Ipv6Address != null &&
                    Ipv6Address.Equals(other.Ipv6Address)
                ) && 
                (
                    SslCertificateThumbprint == other.SslCertificateThumbprint ||
                    SslCertificateThumbprint != null &&
                    SslCertificateThumbprint.Equals(other.SslCertificateThumbprint)
                ) && 
                (
                    EnrolledSince == other.EnrolledSince ||
                    EnrolledSince != null &&
                    EnrolledSince.Equals(other.EnrolledSince)
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
                    if (Health != null)
                    hashCode = hashCode * 59 + Health.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (IsLeader != null)
                    hashCode = hashCode * 59 + IsLeader.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (HostDnsSuffix != null)
                    hashCode = hashCode * 59 + HostDnsSuffix.GetHashCode();
                    if (Ipv4Address != null)
                    hashCode = hashCode * 59 + Ipv4Address.GetHashCode();
                    if (Ipv6Address != null)
                    hashCode = hashCode * 59 + Ipv6Address.GetHashCode();
                    if (SslCertificateThumbprint != null)
                    hashCode = hashCode * 59 + SslCertificateThumbprint.GetHashCode();
                    if (EnrolledSince != null)
                    hashCode = hashCode * 59 + EnrolledSince.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ClusterMember left, ClusterMember right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ClusterMember left, ClusterMember right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
