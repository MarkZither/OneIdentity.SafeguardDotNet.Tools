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
    /// Represents the required details to create an access request on behalf of another user.
    /// </summary>
    [DataContract]
    public partial class RegistrationAccessRequestBroker : IEquatable<RegistrationAccessRequestBroker>
    { 
        /// <summary>
        /// The alias registration API key.
        /// </summary>
        /// <value>The alias registration API key.</value>

        [DataMember(Name="ApiKey")]
        public string ApiKey { get; private set; }

        /// <summary>
        /// List of restricted IP addresses
        /// </summary>
        /// <value>List of restricted IP addresses</value>

        [DataMember(Name="IpRestrictions")]
        public List<string> IpRestrictions { get; set; }

        /// <summary>
        /// The users for which an access request can be created.
        /// </summary>
        /// <value>The users for which an access request can be created.</value>

        [DataMember(Name="Users")]
        public List<RegistrationAlias> Users { get; set; }

        /// <summary>
        /// The user group for which an access request can be created.
        /// </summary>
        /// <value>The user group for which an access request can be created.</value>

        [DataMember(Name="Groups")]
        public List<RegistrationAliasGroup> Groups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegistrationAccessRequestBroker {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  IpRestrictions: ").Append(IpRestrictions).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RegistrationAccessRequestBroker)obj);
        }

        /// <summary>
        /// Returns true if RegistrationAccessRequestBroker instances are equal
        /// </summary>
        /// <param name="other">Instance of RegistrationAccessRequestBroker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegistrationAccessRequestBroker other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ApiKey == other.ApiKey ||
                    ApiKey != null &&
                    ApiKey.Equals(other.ApiKey)
                ) && 
                (
                    IpRestrictions == other.IpRestrictions ||
                    IpRestrictions != null &&
                    IpRestrictions.SequenceEqual(other.IpRestrictions)
                ) && 
                (
                    Users == other.Users ||
                    Users != null &&
                    Users.SequenceEqual(other.Users)
                ) && 
                (
                    Groups == other.Groups ||
                    Groups != null &&
                    Groups.SequenceEqual(other.Groups)
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
                    if (ApiKey != null)
                    hashCode = hashCode * 59 + ApiKey.GetHashCode();
                    if (IpRestrictions != null)
                    hashCode = hashCode * 59 + IpRestrictions.GetHashCode();
                    if (Users != null)
                    hashCode = hashCode * 59 + Users.GetHashCode();
                    if (Groups != null)
                    hashCode = hashCode * 59 + Groups.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RegistrationAccessRequestBroker left, RegistrationAccessRequestBroker right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RegistrationAccessRequestBroker left, RegistrationAccessRequestBroker right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}