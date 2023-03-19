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
    public partial class DiscoveredAsset : IEquatable<DiscoveredAsset>
    { 
        /// <summary>
        /// Asset ID if added to database
        /// </summary>
        /// <value>Asset ID if added to database</value>

        [DataMember(Name="Id")]
        public int? Id { get; set; }

        /// <summary>
        /// Name of the discovered asset
        /// </summary>
        /// <value>Name of the discovered asset</value>

        [DataMember(Name="Name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the discovered asset
        /// </summary>
        /// <value>Description of the discovered asset</value>

        [DataMember(Name="Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets PasswordProfile
        /// </summary>

        [DataMember(Name="PasswordProfile")]
        public DiscoveredAssetPasswordProfileProperties PasswordProfile { get; set; }

        /// <summary>
        /// Gets or Sets SshKeyProfile
        /// </summary>

        [DataMember(Name="SshKeyProfile")]
        public DiscoveredAssetSshKeyProfileProperties SshKeyProfile { get; set; }

        /// <summary>
        /// Gets or Sets DirectoryProperties
        /// </summary>

        [DataMember(Name="DirectoryProperties")]
        public DirectoryObjectProperties DirectoryProperties { get; set; }

        /// <summary>
        /// Platform of the discovered asset
        /// </summary>
        /// <value>Platform of the discovered asset</value>

        [DataMember(Name="Platform")]
        public string Platform { get; set; }

        /// <summary>
        /// Network address of the discovered asset
        /// </summary>
        /// <value>Network address of the discovered asset</value>

        [DataMember(Name="NetworkAddress")]
        public string NetworkAddress { get; set; }

        /// <summary>
        /// Relative id of the discovered asset
        /// </summary>
        /// <value>Relative id of the discovered asset</value>

        [DataMember(Name="RelativeId")]
        public string RelativeId { get; set; }

        /// <summary>
        /// Distinguished name of the discovered asset
        /// </summary>
        /// <value>Distinguished name of the discovered asset</value>

        [DataMember(Name="DistinguishedName")]
        public string DistinguishedName { get; set; }

        /// <summary>
        /// Discovered operating system
        /// </summary>
        /// <value>Discovered operating system</value>

        [DataMember(Name="OperatingSystemName")]
        public string OperatingSystemName { get; set; }

        /// <summary>
        /// Database ID of Platform that was assigned to asset
        /// </summary>
        /// <value>Database ID of Platform that was assigned to asset</value>

        [DataMember(Name="PlatformId")]
        public int? PlatformId { get; set; }

        /// <summary>
        /// Platform display name that was assigned to asset
        /// </summary>
        /// <value>Platform display name that was assigned to asset</value>

        [DataMember(Name="PlatformDisplayName")]
        public string PlatformDisplayName { get; set; }

        /// <summary>
        /// Discovered operating system version
        /// </summary>
        /// <value>Discovered operating system version</value>

        [DataMember(Name="OperatingSystemVersion")]
        public string OperatingSystemVersion { get; set; }

        /// <summary>
        /// The date the asset was discovered
        /// </summary>
        /// <value>The date the asset was discovered</value>

        [DataMember(Name="DiscoveredDate")]
        public DateTime? DiscoveredDate { get; set; }

        /// <summary>
        /// Domain name where the asset was discovered
        /// </summary>
        /// <value>Domain name where the asset was discovered</value>

        [DataMember(Name="DomainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Architecture of the discovered asset
        /// </summary>
        /// <value>Architecture of the discovered asset</value>

        [DataMember(Name="Architecture")]
        public string Architecture { get; set; }

        /// <summary>
        /// Location of the discovered asset
        /// </summary>
        /// <value>Location of the discovered asset</value>

        [DataMember(Name="Location")]
        public string Location { get; set; }

        /// <summary>
        /// Database ID of test connection task log
        /// </summary>
        /// <value>Database ID of test connection task log</value>

        [DataMember(Name="TestConnectionLogId")]
        public string TestConnectionLogId { get; set; }

        /// <summary>
        /// Gets or Sets TestConnectionState
        /// </summary>

        [DataMember(Name="TestConnectionState")]
        public RequestState TestConnectionState { get; set; }

        /// <summary>
        /// Result message from test connection attempt
        /// </summary>
        /// <value>Result message from test connection attempt</value>

        [DataMember(Name="TestConnectionMessage")]
        public string TestConnectionMessage { get; set; }

        /// <summary>
        /// The rule that discovered this asset
        /// </summary>
        /// <value>The rule that discovered this asset</value>

        [DataMember(Name="RuleName")]
        public string RuleName { get; set; }

        /// <summary>
        /// The category of the discovered asset
        /// </summary>
        /// <value>The category of the discovered asset</value>

        [DataMember(Name="ComputerCategory")]
        public string ComputerCategory { get; set; }

        /// <summary>
        /// The unique id of the discovered asset
        /// </summary>
        /// <value>The unique id of the discovered asset</value>

        [DataMember(Name="ObjectGuid")]
        public string ObjectGuid { get; set; }

        /// <summary>
        /// The sid of the discovered asset
        /// </summary>
        /// <value>The sid of the discovered asset</value>

        [DataMember(Name="ObjectSid")]
        public string ObjectSid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscoveredAsset {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PasswordProfile: ").Append(PasswordProfile).Append("\n");
            sb.Append("  SshKeyProfile: ").Append(SshKeyProfile).Append("\n");
            sb.Append("  DirectoryProperties: ").Append(DirectoryProperties).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
            sb.Append("  RelativeId: ").Append(RelativeId).Append("\n");
            sb.Append("  DistinguishedName: ").Append(DistinguishedName).Append("\n");
            sb.Append("  OperatingSystemName: ").Append(OperatingSystemName).Append("\n");
            sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
            sb.Append("  PlatformDisplayName: ").Append(PlatformDisplayName).Append("\n");
            sb.Append("  OperatingSystemVersion: ").Append(OperatingSystemVersion).Append("\n");
            sb.Append("  DiscoveredDate: ").Append(DiscoveredDate).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  Architecture: ").Append(Architecture).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  TestConnectionLogId: ").Append(TestConnectionLogId).Append("\n");
            sb.Append("  TestConnectionState: ").Append(TestConnectionState).Append("\n");
            sb.Append("  TestConnectionMessage: ").Append(TestConnectionMessage).Append("\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
            sb.Append("  ComputerCategory: ").Append(ComputerCategory).Append("\n");
            sb.Append("  ObjectGuid: ").Append(ObjectGuid).Append("\n");
            sb.Append("  ObjectSid: ").Append(ObjectSid).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DiscoveredAsset)obj);
        }

        /// <summary>
        /// Returns true if DiscoveredAsset instances are equal
        /// </summary>
        /// <param name="other">Instance of DiscoveredAsset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscoveredAsset other)
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
                    PasswordProfile == other.PasswordProfile ||
                    PasswordProfile != null &&
                    PasswordProfile.Equals(other.PasswordProfile)
                ) && 
                (
                    SshKeyProfile == other.SshKeyProfile ||
                    SshKeyProfile != null &&
                    SshKeyProfile.Equals(other.SshKeyProfile)
                ) && 
                (
                    DirectoryProperties == other.DirectoryProperties ||
                    DirectoryProperties != null &&
                    DirectoryProperties.Equals(other.DirectoryProperties)
                ) && 
                (
                    Platform == other.Platform ||
                    Platform != null &&
                    Platform.Equals(other.Platform)
                ) && 
                (
                    NetworkAddress == other.NetworkAddress ||
                    NetworkAddress != null &&
                    NetworkAddress.Equals(other.NetworkAddress)
                ) && 
                (
                    RelativeId == other.RelativeId ||
                    RelativeId != null &&
                    RelativeId.Equals(other.RelativeId)
                ) && 
                (
                    DistinguishedName == other.DistinguishedName ||
                    DistinguishedName != null &&
                    DistinguishedName.Equals(other.DistinguishedName)
                ) && 
                (
                    OperatingSystemName == other.OperatingSystemName ||
                    OperatingSystemName != null &&
                    OperatingSystemName.Equals(other.OperatingSystemName)
                ) && 
                (
                    PlatformId == other.PlatformId ||
                    PlatformId != null &&
                    PlatformId.Equals(other.PlatformId)
                ) && 
                (
                    PlatformDisplayName == other.PlatformDisplayName ||
                    PlatformDisplayName != null &&
                    PlatformDisplayName.Equals(other.PlatformDisplayName)
                ) && 
                (
                    OperatingSystemVersion == other.OperatingSystemVersion ||
                    OperatingSystemVersion != null &&
                    OperatingSystemVersion.Equals(other.OperatingSystemVersion)
                ) && 
                (
                    DiscoveredDate == other.DiscoveredDate ||
                    DiscoveredDate != null &&
                    DiscoveredDate.Equals(other.DiscoveredDate)
                ) && 
                (
                    DomainName == other.DomainName ||
                    DomainName != null &&
                    DomainName.Equals(other.DomainName)
                ) && 
                (
                    Architecture == other.Architecture ||
                    Architecture != null &&
                    Architecture.Equals(other.Architecture)
                ) && 
                (
                    Location == other.Location ||
                    Location != null &&
                    Location.Equals(other.Location)
                ) && 
                (
                    TestConnectionLogId == other.TestConnectionLogId ||
                    TestConnectionLogId != null &&
                    TestConnectionLogId.Equals(other.TestConnectionLogId)
                ) && 
                (
                    TestConnectionState == other.TestConnectionState ||
                    TestConnectionState != null &&
                    TestConnectionState.Equals(other.TestConnectionState)
                ) && 
                (
                    TestConnectionMessage == other.TestConnectionMessage ||
                    TestConnectionMessage != null &&
                    TestConnectionMessage.Equals(other.TestConnectionMessage)
                ) && 
                (
                    RuleName == other.RuleName ||
                    RuleName != null &&
                    RuleName.Equals(other.RuleName)
                ) && 
                (
                    ComputerCategory == other.ComputerCategory ||
                    ComputerCategory != null &&
                    ComputerCategory.Equals(other.ComputerCategory)
                ) && 
                (
                    ObjectGuid == other.ObjectGuid ||
                    ObjectGuid != null &&
                    ObjectGuid.Equals(other.ObjectGuid)
                ) && 
                (
                    ObjectSid == other.ObjectSid ||
                    ObjectSid != null &&
                    ObjectSid.Equals(other.ObjectSid)
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
                    if (PasswordProfile != null)
                    hashCode = hashCode * 59 + PasswordProfile.GetHashCode();
                    if (SshKeyProfile != null)
                    hashCode = hashCode * 59 + SshKeyProfile.GetHashCode();
                    if (DirectoryProperties != null)
                    hashCode = hashCode * 59 + DirectoryProperties.GetHashCode();
                    if (Platform != null)
                    hashCode = hashCode * 59 + Platform.GetHashCode();
                    if (NetworkAddress != null)
                    hashCode = hashCode * 59 + NetworkAddress.GetHashCode();
                    if (RelativeId != null)
                    hashCode = hashCode * 59 + RelativeId.GetHashCode();
                    if (DistinguishedName != null)
                    hashCode = hashCode * 59 + DistinguishedName.GetHashCode();
                    if (OperatingSystemName != null)
                    hashCode = hashCode * 59 + OperatingSystemName.GetHashCode();
                    if (PlatformId != null)
                    hashCode = hashCode * 59 + PlatformId.GetHashCode();
                    if (PlatformDisplayName != null)
                    hashCode = hashCode * 59 + PlatformDisplayName.GetHashCode();
                    if (OperatingSystemVersion != null)
                    hashCode = hashCode * 59 + OperatingSystemVersion.GetHashCode();
                    if (DiscoveredDate != null)
                    hashCode = hashCode * 59 + DiscoveredDate.GetHashCode();
                    if (DomainName != null)
                    hashCode = hashCode * 59 + DomainName.GetHashCode();
                    if (Architecture != null)
                    hashCode = hashCode * 59 + Architecture.GetHashCode();
                    if (Location != null)
                    hashCode = hashCode * 59 + Location.GetHashCode();
                    if (TestConnectionLogId != null)
                    hashCode = hashCode * 59 + TestConnectionLogId.GetHashCode();
                    if (TestConnectionState != null)
                    hashCode = hashCode * 59 + TestConnectionState.GetHashCode();
                    if (TestConnectionMessage != null)
                    hashCode = hashCode * 59 + TestConnectionMessage.GetHashCode();
                    if (RuleName != null)
                    hashCode = hashCode * 59 + RuleName.GetHashCode();
                    if (ComputerCategory != null)
                    hashCode = hashCode * 59 + ComputerCategory.GetHashCode();
                    if (ObjectGuid != null)
                    hashCode = hashCode * 59 + ObjectGuid.GetHashCode();
                    if (ObjectSid != null)
                    hashCode = hashCode * 59 + ObjectSid.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DiscoveredAsset left, DiscoveredAsset right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DiscoveredAsset left, DiscoveredAsset right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
