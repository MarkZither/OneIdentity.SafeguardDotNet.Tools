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
    public partial class DirectoryPropertyConstraintProperties : IEquatable<DirectoryPropertyConstraintProperties>
    { 
        /// <summary>
        /// Filters accounts based on the name of the account (an ANR search is performed for Active Directory). Names can be specified as a regular expression.
        /// </summary>
        /// <value>Filters accounts based on the name of the account (an ANR search is performed for Active Directory). Names can be specified as a regular expression.</value>

        [MaxLength(255)]
        [DataMember(Name="NameFilter")]
        public string NameFilter { get; set; }

        /// <summary>
        /// Filter accounts based on the names of groups in the directory the account belongs to. Names can be specified as a regular expression.
        /// </summary>
        /// <value>Filter accounts based on the names of groups in the directory the account belongs to. Names can be specified as a regular expression.</value>

        [MaxLength(255)]
        [DataMember(Name="GroupFilter")]
        public string GroupFilter { get; set; }

        /// <summary>
        /// Filter accounts based on their uidNumber attribute (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5
        /// </summary>
        /// <value>Filter accounts based on their uidNumber attribute (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5</value>

        [DataMember(Name="UidFilter")]
        public List<string> UidFilter { get; set; }

        /// <summary>
        /// Filter accounts based on their Windows relative account ID (last part of objectSid attribute) (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5
        /// </summary>
        /// <value>Filter accounts based on their Windows relative account ID (last part of objectSid attribute) (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5</value>

        [DataMember(Name="RidFilter")]
        public List<string> RidFilter { get; set; }

        /// <summary>
        /// Filter accounts based on their gidNumber attribute (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5
        /// </summary>
        /// <value>Filter accounts based on their gidNumber attribute (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5</value>

        [DataMember(Name="GidFilter")]
        public List<string> GidFilter { get; set; }

        /// <summary>
        /// Filter accounts based on their primaryGroupID attribute (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5
        /// </summary>
        /// <value>Filter accounts based on their primaryGroupID attribute (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5</value>

        [DataMember(Name="PrimaryGidFilter")]
        public List<string> PrimaryGidFilter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DirectoryPropertyConstraintProperties {\n");
            sb.Append("  NameFilter: ").Append(NameFilter).Append("\n");
            sb.Append("  GroupFilter: ").Append(GroupFilter).Append("\n");
            sb.Append("  UidFilter: ").Append(UidFilter).Append("\n");
            sb.Append("  RidFilter: ").Append(RidFilter).Append("\n");
            sb.Append("  GidFilter: ").Append(GidFilter).Append("\n");
            sb.Append("  PrimaryGidFilter: ").Append(PrimaryGidFilter).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DirectoryPropertyConstraintProperties)obj);
        }

        /// <summary>
        /// Returns true if DirectoryPropertyConstraintProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of DirectoryPropertyConstraintProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DirectoryPropertyConstraintProperties other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NameFilter == other.NameFilter ||
                    NameFilter != null &&
                    NameFilter.Equals(other.NameFilter)
                ) && 
                (
                    GroupFilter == other.GroupFilter ||
                    GroupFilter != null &&
                    GroupFilter.Equals(other.GroupFilter)
                ) && 
                (
                    UidFilter == other.UidFilter ||
                    UidFilter != null &&
                    UidFilter.SequenceEqual(other.UidFilter)
                ) && 
                (
                    RidFilter == other.RidFilter ||
                    RidFilter != null &&
                    RidFilter.SequenceEqual(other.RidFilter)
                ) && 
                (
                    GidFilter == other.GidFilter ||
                    GidFilter != null &&
                    GidFilter.SequenceEqual(other.GidFilter)
                ) && 
                (
                    PrimaryGidFilter == other.PrimaryGidFilter ||
                    PrimaryGidFilter != null &&
                    PrimaryGidFilter.SequenceEqual(other.PrimaryGidFilter)
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
                    if (NameFilter != null)
                    hashCode = hashCode * 59 + NameFilter.GetHashCode();
                    if (GroupFilter != null)
                    hashCode = hashCode * 59 + GroupFilter.GetHashCode();
                    if (UidFilter != null)
                    hashCode = hashCode * 59 + UidFilter.GetHashCode();
                    if (RidFilter != null)
                    hashCode = hashCode * 59 + RidFilter.GetHashCode();
                    if (GidFilter != null)
                    hashCode = hashCode * 59 + GidFilter.GetHashCode();
                    if (PrimaryGidFilter != null)
                    hashCode = hashCode * 59 + PrimaryGidFilter.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DirectoryPropertyConstraintProperties left, DirectoryPropertyConstraintProperties right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DirectoryPropertyConstraintProperties left, DirectoryPropertyConstraintProperties right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
