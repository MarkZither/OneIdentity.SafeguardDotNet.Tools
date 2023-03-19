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
    /// Directory property mappings used when importing and synchronizing entities
    /// </summary>
    [DataContract]
    public partial class AssetLdapSchema : IEquatable<AssetLdapSchema>
    { 
        /// <summary>
        /// Gets or Sets UserProperties
        /// </summary>

        [DataMember(Name="UserProperties")]
        public UserAssetSchemaProperties UserProperties { get; set; }

        /// <summary>
        /// Gets or Sets GroupProperties
        /// </summary>

        [DataMember(Name="GroupProperties")]
        public GroupAssetSchemaProperties GroupProperties { get; set; }

        /// <summary>
        /// Gets or Sets ComputerProperties
        /// </summary>

        [DataMember(Name="ComputerProperties")]
        public ComputerSchemaProperties ComputerProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetLdapSchema {\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
            sb.Append("  GroupProperties: ").Append(GroupProperties).Append("\n");
            sb.Append("  ComputerProperties: ").Append(ComputerProperties).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AssetLdapSchema)obj);
        }

        /// <summary>
        /// Returns true if AssetLdapSchema instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetLdapSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetLdapSchema other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    UserProperties == other.UserProperties ||
                    UserProperties != null &&
                    UserProperties.Equals(other.UserProperties)
                ) && 
                (
                    GroupProperties == other.GroupProperties ||
                    GroupProperties != null &&
                    GroupProperties.Equals(other.GroupProperties)
                ) && 
                (
                    ComputerProperties == other.ComputerProperties ||
                    ComputerProperties != null &&
                    ComputerProperties.Equals(other.ComputerProperties)
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
                    if (UserProperties != null)
                    hashCode = hashCode * 59 + UserProperties.GetHashCode();
                    if (GroupProperties != null)
                    hashCode = hashCode * 59 + GroupProperties.GetHashCode();
                    if (ComputerProperties != null)
                    hashCode = hashCode * 59 + ComputerProperties.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AssetLdapSchema left, AssetLdapSchema right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AssetLdapSchema left, AssetLdapSchema right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
