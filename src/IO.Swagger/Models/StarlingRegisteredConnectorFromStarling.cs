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
    public partial class StarlingRegisteredConnectorFromStarling : IEquatable<StarlingRegisteredConnectorFromStarling>
    { 
        /// <summary>
        /// Gets or Sets RegisteredConnectorId
        /// </summary>

        [DataMember(Name="RegisteredConnectorId")]
        public string RegisteredConnectorId { get; set; }

        /// <summary>
        /// Gets or Sets ConnectorId
        /// </summary>

        [DataMember(Name="ConnectorId")]
        public string ConnectorId { get; set; }

        /// <summary>
        /// Gets or Sets ConnectorDisplayName
        /// </summary>

        [DataMember(Name="ConnectorDisplayName")]
        public string ConnectorDisplayName { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>

        [DataMember(Name="SubscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>

        [DataMember(Name="DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets AvailableVersions
        /// </summary>

        [DataMember(Name="AvailableVersions")]
        public List<string> AvailableVersions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StarlingRegisteredConnectorFromStarling {\n");
            sb.Append("  RegisteredConnectorId: ").Append(RegisteredConnectorId).Append("\n");
            sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
            sb.Append("  ConnectorDisplayName: ").Append(ConnectorDisplayName).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  AvailableVersions: ").Append(AvailableVersions).Append("\n");
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
            return obj.GetType() == GetType() && Equals((StarlingRegisteredConnectorFromStarling)obj);
        }

        /// <summary>
        /// Returns true if StarlingRegisteredConnectorFromStarling instances are equal
        /// </summary>
        /// <param name="other">Instance of StarlingRegisteredConnectorFromStarling to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StarlingRegisteredConnectorFromStarling other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    RegisteredConnectorId == other.RegisteredConnectorId ||
                    RegisteredConnectorId != null &&
                    RegisteredConnectorId.Equals(other.RegisteredConnectorId)
                ) && 
                (
                    ConnectorId == other.ConnectorId ||
                    ConnectorId != null &&
                    ConnectorId.Equals(other.ConnectorId)
                ) && 
                (
                    ConnectorDisplayName == other.ConnectorDisplayName ||
                    ConnectorDisplayName != null &&
                    ConnectorDisplayName.Equals(other.ConnectorDisplayName)
                ) && 
                (
                    SubscriptionId == other.SubscriptionId ||
                    SubscriptionId != null &&
                    SubscriptionId.Equals(other.SubscriptionId)
                ) && 
                (
                    DisplayName == other.DisplayName ||
                    DisplayName != null &&
                    DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    AvailableVersions == other.AvailableVersions ||
                    AvailableVersions != null &&
                    AvailableVersions.SequenceEqual(other.AvailableVersions)
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
                    if (RegisteredConnectorId != null)
                    hashCode = hashCode * 59 + RegisteredConnectorId.GetHashCode();
                    if (ConnectorId != null)
                    hashCode = hashCode * 59 + ConnectorId.GetHashCode();
                    if (ConnectorDisplayName != null)
                    hashCode = hashCode * 59 + ConnectorDisplayName.GetHashCode();
                    if (SubscriptionId != null)
                    hashCode = hashCode * 59 + SubscriptionId.GetHashCode();
                    if (DisplayName != null)
                    hashCode = hashCode * 59 + DisplayName.GetHashCode();
                    if (AvailableVersions != null)
                    hashCode = hashCode * 59 + AvailableVersions.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(StarlingRegisteredConnectorFromStarling left, StarlingRegisteredConnectorFromStarling right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StarlingRegisteredConnectorFromStarling left, StarlingRegisteredConnectorFromStarling right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
