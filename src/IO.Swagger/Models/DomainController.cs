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
    /// Represents a directory domain controller
    /// </summary>
    [DataContract]
    public partial class DomainController : IEquatable<DomainController>
    { 
        /// <summary>
        /// Network DNS name or IP address used to connect to the machine over the network
        /// </summary>
        /// <value>Network DNS name or IP address used to connect to the machine over the network</value>
        [Required]

        [MaxLength(255)]
        [DataMember(Name="NetworkAddress")]
        public string NetworkAddress { get; set; }

        /// <summary>
        /// The domain that is managed
        /// </summary>
        /// <value>The domain that is managed</value>

        [DataMember(Name="DomainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Whether this is a read-only domain controller or not
        /// </summary>
        /// <value>Whether this is a read-only domain controller or not</value>

        [DataMember(Name="IsWritable")]
        public bool? IsWritable { get; set; }

        /// <summary>
        /// Gets or Sets ServerType
        /// </summary>

        [DataMember(Name="ServerType")]
        public DirectoryServerType ServerType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainController {\n");
            sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  IsWritable: ").Append(IsWritable).Append("\n");
            sb.Append("  ServerType: ").Append(ServerType).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DomainController)obj);
        }

        /// <summary>
        /// Returns true if DomainController instances are equal
        /// </summary>
        /// <param name="other">Instance of DomainController to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainController other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NetworkAddress == other.NetworkAddress ||
                    NetworkAddress != null &&
                    NetworkAddress.Equals(other.NetworkAddress)
                ) && 
                (
                    DomainName == other.DomainName ||
                    DomainName != null &&
                    DomainName.Equals(other.DomainName)
                ) && 
                (
                    IsWritable == other.IsWritable ||
                    IsWritable != null &&
                    IsWritable.Equals(other.IsWritable)
                ) && 
                (
                    ServerType == other.ServerType ||
                    ServerType != null &&
                    ServerType.Equals(other.ServerType)
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
                    if (NetworkAddress != null)
                    hashCode = hashCode * 59 + NetworkAddress.GetHashCode();
                    if (DomainName != null)
                    hashCode = hashCode * 59 + DomainName.GetHashCode();
                    if (IsWritable != null)
                    hashCode = hashCode * 59 + IsWritable.GetHashCode();
                    if (ServerType != null)
                    hashCode = hashCode * 59 + ServerType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DomainController left, DomainController right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DomainController left, DomainController right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
