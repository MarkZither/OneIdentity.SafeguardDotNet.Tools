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
    /// Represents a file transfer protocol used by archive servers
    /// </summary>
    [DataContract]
    public partial class TransferProtocol : IEquatable<TransferProtocol>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="Id")]
        public TransferProtocolType Id { get; set; }

        /// <summary>
        /// Name of this protocol (Read-only)
        /// </summary>
        /// <value>Name of this protocol (Read-only)</value>

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of this protocol (Read-only)
        /// </summary>
        /// <value>Description of this protocol (Read-only)</value>

        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// Protocol supports using a custom port
        /// </summary>
        /// <value>Protocol supports using a custom port</value>

        [DataMember(Name="SupportsCustomPort")]
        public bool? SupportsCustomPort { get; set; }

        /// <summary>
        /// Protocol supports password username/authentication
        /// </summary>
        /// <value>Protocol supports password username/authentication</value>

        [DataMember(Name="SupportsPassword")]
        public bool? SupportsPassword { get; set; }

        /// <summary>
        /// Protocol supports SSH username/key authentication
        /// </summary>
        /// <value>Protocol supports SSH username/key authentication</value>

        [DataMember(Name="SupportsSshKey")]
        public bool? SupportsSshKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferProtocol {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SupportsCustomPort: ").Append(SupportsCustomPort).Append("\n");
            sb.Append("  SupportsPassword: ").Append(SupportsPassword).Append("\n");
            sb.Append("  SupportsSshKey: ").Append(SupportsSshKey).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TransferProtocol)obj);
        }

        /// <summary>
        /// Returns true if TransferProtocol instances are equal
        /// </summary>
        /// <param name="other">Instance of TransferProtocol to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferProtocol other)
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
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    SupportsCustomPort == other.SupportsCustomPort ||
                    SupportsCustomPort != null &&
                    SupportsCustomPort.Equals(other.SupportsCustomPort)
                ) && 
                (
                    SupportsPassword == other.SupportsPassword ||
                    SupportsPassword != null &&
                    SupportsPassword.Equals(other.SupportsPassword)
                ) && 
                (
                    SupportsSshKey == other.SupportsSshKey ||
                    SupportsSshKey != null &&
                    SupportsSshKey.Equals(other.SupportsSshKey)
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
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (SupportsCustomPort != null)
                    hashCode = hashCode * 59 + SupportsCustomPort.GetHashCode();
                    if (SupportsPassword != null)
                    hashCode = hashCode * 59 + SupportsPassword.GetHashCode();
                    if (SupportsSshKey != null)
                    hashCode = hashCode * 59 + SupportsSshKey.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TransferProtocol left, TransferProtocol right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TransferProtocol left, TransferProtocol right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
