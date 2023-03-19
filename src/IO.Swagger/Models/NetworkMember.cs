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
    /// Represents an appliance that has been assigned to a managed network
    /// </summary>
    [DataContract]
    public partial class NetworkMember : IEquatable<NetworkMember>
    { 
        /// <summary>
        /// Gets or Sets SessionMemberStatus
        /// </summary>

        [DataMember(Name="SessionMemberStatus")]
        public SessionMemberStatus SessionMemberStatus { get; set; }

        /// <summary>
        /// Roles assigned to the sessions member
        /// </summary>
        /// <value>Roles assigned to the sessions member</value>

        [DataMember(Name="SessionMemberRoles")]
        public List<string> SessionMemberRoles { get; set; }

        /// <summary>
        /// The unique ID of the appliance
        /// </summary>
        /// <value>The unique ID of the appliance</value>
        [Required]

        [DataMember(Name="Id")]
        public string Id { get; set; }

        /// <summary>
        /// The display name of the appliance
        /// </summary>
        /// <value>The display name of the appliance</value>

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// The Host Dns Suffix of the appliance
        /// </summary>
        /// <value>The Host Dns Suffix of the appliance</value>

        [DataMember(Name="HostDnsSuffix")]
        public string HostDnsSuffix { get; set; }

        /// <summary>
        /// The IPv4 address of this appliance
        /// </summary>
        /// <value>The IPv4 address of this appliance</value>

        [DataMember(Name="Ipv4Address")]
        public string Ipv4Address { get; set; }

        /// <summary>
        /// The IPv6 address of this appliance
        /// </summary>
        /// <value>The IPv6 address of this appliance</value>

        [DataMember(Name="Ipv6Address")]
        public string Ipv6Address { get; set; }

        /// <summary>
        /// Determines if the member is a sessions appliance
        /// </summary>
        /// <value>Determines if the member is a sessions appliance</value>

        [DataMember(Name="IsSessionMember")]
        public bool? IsSessionMember { get; private set; }

        /// <summary>
        /// Configuration sync status to the sessions member
        /// </summary>
        /// <value>Configuration sync status to the sessions member</value>

        [DataMember(Name="SyncStatus")]
        public string SyncStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkMember {\n");
            sb.Append("  SessionMemberStatus: ").Append(SessionMemberStatus).Append("\n");
            sb.Append("  SessionMemberRoles: ").Append(SessionMemberRoles).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HostDnsSuffix: ").Append(HostDnsSuffix).Append("\n");
            sb.Append("  Ipv4Address: ").Append(Ipv4Address).Append("\n");
            sb.Append("  Ipv6Address: ").Append(Ipv6Address).Append("\n");
            sb.Append("  IsSessionMember: ").Append(IsSessionMember).Append("\n");
            sb.Append("  SyncStatus: ").Append(SyncStatus).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NetworkMember)obj);
        }

        /// <summary>
        /// Returns true if NetworkMember instances are equal
        /// </summary>
        /// <param name="other">Instance of NetworkMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkMember other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SessionMemberStatus == other.SessionMemberStatus ||
                    SessionMemberStatus != null &&
                    SessionMemberStatus.Equals(other.SessionMemberStatus)
                ) && 
                (
                    SessionMemberRoles == other.SessionMemberRoles ||
                    SessionMemberRoles != null &&
                    SessionMemberRoles.SequenceEqual(other.SessionMemberRoles)
                ) && 
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
                    IsSessionMember == other.IsSessionMember ||
                    IsSessionMember != null &&
                    IsSessionMember.Equals(other.IsSessionMember)
                ) && 
                (
                    SyncStatus == other.SyncStatus ||
                    SyncStatus != null &&
                    SyncStatus.Equals(other.SyncStatus)
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
                    if (SessionMemberStatus != null)
                    hashCode = hashCode * 59 + SessionMemberStatus.GetHashCode();
                    if (SessionMemberRoles != null)
                    hashCode = hashCode * 59 + SessionMemberRoles.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (HostDnsSuffix != null)
                    hashCode = hashCode * 59 + HostDnsSuffix.GetHashCode();
                    if (Ipv4Address != null)
                    hashCode = hashCode * 59 + Ipv4Address.GetHashCode();
                    if (Ipv6Address != null)
                    hashCode = hashCode * 59 + Ipv6Address.GetHashCode();
                    if (IsSessionMember != null)
                    hashCode = hashCode * 59 + IsSessionMember.GetHashCode();
                    if (SyncStatus != null)
                    hashCode = hashCode * 59 + SyncStatus.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NetworkMember left, NetworkMember right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NetworkMember left, NetworkMember right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
