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
    /// Set of property constraints to match against discovered assets
    /// </summary>
    [DataContract]
    public partial class AssetDiscoveryPropertyConstraint : IEquatable<AssetDiscoveryPropertyConstraint>
    { 
        /// <summary>
        /// Gets or Sets PropertyName
        /// </summary>
        [Required]

        [DataMember(Name="PropertyName")]
        public DiscoveredAssetProperty PropertyName { get; set; }

        /// <summary>
        /// Gets or Sets _Operator
        /// </summary>
        [Required]

        [DataMember(Name="Operator")]
        public DiscoveredAssetPropertyConstraintOperator _Operator { get; set; }

        /// <summary>
        /// Value to match against
        /// </summary>
        /// <value>Value to match against</value>

        [MaxLength(255)]
        [DataMember(Name="Value")]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetDiscoveryPropertyConstraint {\n");
            sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AssetDiscoveryPropertyConstraint)obj);
        }

        /// <summary>
        /// Returns true if AssetDiscoveryPropertyConstraint instances are equal
        /// </summary>
        /// <param name="other">Instance of AssetDiscoveryPropertyConstraint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetDiscoveryPropertyConstraint other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PropertyName == other.PropertyName ||
                    PropertyName != null &&
                    PropertyName.Equals(other.PropertyName)
                ) && 
                (
                    _Operator == other._Operator ||
                    _Operator != null &&
                    _Operator.Equals(other._Operator)
                ) && 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
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
                    if (PropertyName != null)
                    hashCode = hashCode * 59 + PropertyName.GetHashCode();
                    if (_Operator != null)
                    hashCode = hashCode * 59 + _Operator.GetHashCode();
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AssetDiscoveryPropertyConstraint left, AssetDiscoveryPropertyConstraint right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AssetDiscoveryPropertyConstraint left, AssetDiscoveryPropertyConstraint right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
