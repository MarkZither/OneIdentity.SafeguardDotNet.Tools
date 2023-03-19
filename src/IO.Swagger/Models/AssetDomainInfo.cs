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
    /// Represents information about available domains that can be searched in an Directory
    /// </summary>
    [DataContract]
    public partial class AssetDomainInfo : IEquatable<AssetDomainInfo>
    { 
        /// <summary>
        /// Name of the domain
        /// </summary>
        /// <value>Name of the domain</value>

        [DataMember(Name="DomainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Netbios name of the domain
        /// </summary>
        /// <value>Netbios name of the domain</value>

        [DataMember(Name="NetBiosName")]
        public string NetBiosName { get; set; }

        /// <summary>
        /// Sid of the Domain
        /// </summary>
        /// <value>Sid of the Domain</value>

        [DataMember(Name="DomainUniqueId")]
        public string DomainUniqueId { get; set; }

        /// <summary>
        /// Default Naming Context for the Domain
        /// </summary>
        /// <value>Default Naming Context for the Domain</value>

        [DataMember(Name="NamingContext")]
        public string NamingContext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetDomainInfo {\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  NetBiosName: ").Append(NetBiosName).Append("\n");
            sb.Append("  DomainUniqueId: ").Append(DomainUniqueId).Append("\n");
            sb.Append("  NamingContext: ").Append(NamingContext).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AssetDomainInfo)obj);
        }

        /// <summary>
        /// Returns true if AssetDomainInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetDomainInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetDomainInfo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DomainName == other.DomainName ||
                    DomainName != null &&
                    DomainName.Equals(other.DomainName)
                ) && 
                (
                    NetBiosName == other.NetBiosName ||
                    NetBiosName != null &&
                    NetBiosName.Equals(other.NetBiosName)
                ) && 
                (
                    DomainUniqueId == other.DomainUniqueId ||
                    DomainUniqueId != null &&
                    DomainUniqueId.Equals(other.DomainUniqueId)
                ) && 
                (
                    NamingContext == other.NamingContext ||
                    NamingContext != null &&
                    NamingContext.Equals(other.NamingContext)
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
                    if (DomainName != null)
                    hashCode = hashCode * 59 + DomainName.GetHashCode();
                    if (NetBiosName != null)
                    hashCode = hashCode * 59 + NetBiosName.GetHashCode();
                    if (DomainUniqueId != null)
                    hashCode = hashCode * 59 + DomainUniqueId.GetHashCode();
                    if (NamingContext != null)
                    hashCode = hashCode * 59 + NamingContext.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AssetDomainInfo left, AssetDomainInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AssetDomainInfo left, AssetDomainInfo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}