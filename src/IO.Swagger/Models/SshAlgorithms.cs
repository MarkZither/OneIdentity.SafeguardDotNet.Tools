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
    /// Represents the available algorithms when establishing an SSH connection through the sessions module, or to an archive server. The list order determines the priority in which the algorithms are negotiated with the SSHD server.
    /// </summary>
    [DataContract]
    public partial class SshAlgorithms : IEquatable<SshAlgorithms>
    { 
        /// <summary>
        /// Public Key Algorithms.
        /// </summary>
        /// <value>Public Key Algorithms.</value>

        [DataMember(Name="PublicKey")]
        public List<string> PublicKey { get; set; }

        /// <summary>
        /// Cipher Algorithms.
        /// </summary>
        /// <value>Cipher Algorithms.</value>

        [DataMember(Name="Cipher")]
        public List<string> Cipher { get; set; }

        /// <summary>
        /// KEX Algorithms.
        /// </summary>
        /// <value>KEX Algorithms.</value>

        [DataMember(Name="Kex")]
        public List<string> Kex { get; set; }

        /// <summary>
        /// MAC Algorithms.
        /// </summary>
        /// <value>MAC Algorithms.</value>

        [DataMember(Name="Mac")]
        public List<string> Mac { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SshAlgorithms {\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  Cipher: ").Append(Cipher).Append("\n");
            sb.Append("  Kex: ").Append(Kex).Append("\n");
            sb.Append("  Mac: ").Append(Mac).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SshAlgorithms)obj);
        }

        /// <summary>
        /// Returns true if SshAlgorithms instances are equal
        /// </summary>
        /// <param name="other">Instance of SshAlgorithms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SshAlgorithms other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PublicKey == other.PublicKey ||
                    PublicKey != null &&
                    PublicKey.SequenceEqual(other.PublicKey)
                ) && 
                (
                    Cipher == other.Cipher ||
                    Cipher != null &&
                    Cipher.SequenceEqual(other.Cipher)
                ) && 
                (
                    Kex == other.Kex ||
                    Kex != null &&
                    Kex.SequenceEqual(other.Kex)
                ) && 
                (
                    Mac == other.Mac ||
                    Mac != null &&
                    Mac.SequenceEqual(other.Mac)
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
                    if (PublicKey != null)
                    hashCode = hashCode * 59 + PublicKey.GetHashCode();
                    if (Cipher != null)
                    hashCode = hashCode * 59 + Cipher.GetHashCode();
                    if (Kex != null)
                    hashCode = hashCode * 59 + Kex.GetHashCode();
                    if (Mac != null)
                    hashCode = hashCode * 59 + Mac.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SshAlgorithms left, SshAlgorithms right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SshAlgorithms left, SshAlgorithms right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
