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
    public partial class ClusterPatchModel : IEquatable<ClusterPatchModel>
    { 
        /// <summary>
        /// Gets or Sets StagingStatus
        /// </summary>

        [DataMember(Name="StagingStatus")]
        public PatchStagingStatus StagingStatus { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>

        [DataMember(Name="Id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NetworkAddress
        /// </summary>

        [DataMember(Name="NetworkAddress")]
        public string NetworkAddress { get; set; }

        /// <summary>
        /// Gets or Sets Isleader
        /// </summary>

        [DataMember(Name="Isleader")]
        public bool? Isleader { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>

        [DataMember(Name="Errors")]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>

        [DataMember(Name="Warnings")]
        public List<string> Warnings { get; set; }

        /// <summary>
        /// Gets or Sets PatchVersion
        /// </summary>

        [DataMember(Name="PatchVersion")]
        public string PatchVersion { get; set; }

        /// <summary>
        /// Gets or Sets TargetOsLevel
        /// </summary>

        [DataMember(Name="TargetOsLevel")]
        public int? TargetOsLevel { get; set; }

        /// <summary>
        /// Gets or Sets IsOsPatch
        /// </summary>

        [DataMember(Name="IsOsPatch")]
        public bool? IsOsPatch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterPatchModel {\n");
            sb.Append("  StagingStatus: ").Append(StagingStatus).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
            sb.Append("  Isleader: ").Append(Isleader).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  PatchVersion: ").Append(PatchVersion).Append("\n");
            sb.Append("  TargetOsLevel: ").Append(TargetOsLevel).Append("\n");
            sb.Append("  IsOsPatch: ").Append(IsOsPatch).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ClusterPatchModel)obj);
        }

        /// <summary>
        /// Returns true if ClusterPatchModel instances are equal
        /// </summary>
        /// <param name="other">Instance of ClusterPatchModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClusterPatchModel other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    StagingStatus == other.StagingStatus ||
                    StagingStatus != null &&
                    StagingStatus.Equals(other.StagingStatus)
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
                    NetworkAddress == other.NetworkAddress ||
                    NetworkAddress != null &&
                    NetworkAddress.Equals(other.NetworkAddress)
                ) && 
                (
                    Isleader == other.Isleader ||
                    Isleader != null &&
                    Isleader.Equals(other.Isleader)
                ) && 
                (
                    Errors == other.Errors ||
                    Errors != null &&
                    Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    Warnings == other.Warnings ||
                    Warnings != null &&
                    Warnings.SequenceEqual(other.Warnings)
                ) && 
                (
                    PatchVersion == other.PatchVersion ||
                    PatchVersion != null &&
                    PatchVersion.Equals(other.PatchVersion)
                ) && 
                (
                    TargetOsLevel == other.TargetOsLevel ||
                    TargetOsLevel != null &&
                    TargetOsLevel.Equals(other.TargetOsLevel)
                ) && 
                (
                    IsOsPatch == other.IsOsPatch ||
                    IsOsPatch != null &&
                    IsOsPatch.Equals(other.IsOsPatch)
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
                    if (StagingStatus != null)
                    hashCode = hashCode * 59 + StagingStatus.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (NetworkAddress != null)
                    hashCode = hashCode * 59 + NetworkAddress.GetHashCode();
                    if (Isleader != null)
                    hashCode = hashCode * 59 + Isleader.GetHashCode();
                    if (Errors != null)
                    hashCode = hashCode * 59 + Errors.GetHashCode();
                    if (Warnings != null)
                    hashCode = hashCode * 59 + Warnings.GetHashCode();
                    if (PatchVersion != null)
                    hashCode = hashCode * 59 + PatchVersion.GetHashCode();
                    if (TargetOsLevel != null)
                    hashCode = hashCode * 59 + TargetOsLevel.GetHashCode();
                    if (IsOsPatch != null)
                    hashCode = hashCode * 59 + IsOsPatch.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ClusterPatchModel left, ClusterPatchModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ClusterPatchModel left, ClusterPatchModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
