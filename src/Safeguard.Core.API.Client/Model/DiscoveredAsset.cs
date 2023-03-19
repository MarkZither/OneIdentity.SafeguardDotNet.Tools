using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DiscoveredAsset {
    /// <summary>
    /// Asset ID if added to database
    /// </summary>
    /// <value>Asset ID if added to database</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of the discovered asset
    /// </summary>
    /// <value>Name of the discovered asset</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of the discovered asset
    /// </summary>
    /// <value>Description of the discovered asset</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets PasswordProfile
    /// </summary>
    [DataMember(Name="PasswordProfile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordProfile")]
    public DiscoveredAssetPasswordProfileProperties PasswordProfile { get; set; }

    /// <summary>
    /// Gets or Sets SshKeyProfile
    /// </summary>
    [DataMember(Name="SshKeyProfile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyProfile")]
    public DiscoveredAssetSshKeyProfileProperties SshKeyProfile { get; set; }

    /// <summary>
    /// Gets or Sets DirectoryProperties
    /// </summary>
    [DataMember(Name="DirectoryProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryProperties")]
    public DirectoryObjectProperties DirectoryProperties { get; set; }

    /// <summary>
    /// Platform of the discovered asset
    /// </summary>
    /// <value>Platform of the discovered asset</value>
    [DataMember(Name="Platform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Platform")]
    public string Platform { get; set; }

    /// <summary>
    /// Network address of the discovered asset
    /// </summary>
    /// <value>Network address of the discovered asset</value>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

    /// <summary>
    /// Relative id of the discovered asset
    /// </summary>
    /// <value>Relative id of the discovered asset</value>
    [DataMember(Name="RelativeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RelativeId")]
    public string RelativeId { get; set; }

    /// <summary>
    /// Distinguished name of the discovered asset
    /// </summary>
    /// <value>Distinguished name of the discovered asset</value>
    [DataMember(Name="DistinguishedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DistinguishedName")]
    public string DistinguishedName { get; set; }

    /// <summary>
    /// Discovered operating system
    /// </summary>
    /// <value>Discovered operating system</value>
    [DataMember(Name="OperatingSystemName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OperatingSystemName")]
    public string OperatingSystemName { get; set; }

    /// <summary>
    /// Database ID of Platform that was assigned to asset
    /// </summary>
    /// <value>Database ID of Platform that was assigned to asset</value>
    [DataMember(Name="PlatformId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformId")]
    public int? PlatformId { get; set; }

    /// <summary>
    /// Platform display name that was assigned to asset
    /// </summary>
    /// <value>Platform display name that was assigned to asset</value>
    [DataMember(Name="PlatformDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformDisplayName")]
    public string PlatformDisplayName { get; set; }

    /// <summary>
    /// Discovered operating system version
    /// </summary>
    /// <value>Discovered operating system version</value>
    [DataMember(Name="OperatingSystemVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OperatingSystemVersion")]
    public string OperatingSystemVersion { get; set; }

    /// <summary>
    /// The date the asset was discovered
    /// </summary>
    /// <value>The date the asset was discovered</value>
    [DataMember(Name="DiscoveredDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredDate")]
    public DateTime? DiscoveredDate { get; set; }

    /// <summary>
    /// Domain name where the asset was discovered
    /// </summary>
    /// <value>Domain name where the asset was discovered</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// Architecture of the discovered asset
    /// </summary>
    /// <value>Architecture of the discovered asset</value>
    [DataMember(Name="Architecture", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Architecture")]
    public string Architecture { get; set; }

    /// <summary>
    /// Location of the discovered asset
    /// </summary>
    /// <value>Location of the discovered asset</value>
    [DataMember(Name="Location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Location")]
    public string Location { get; set; }

    /// <summary>
    /// Database ID of test connection task log
    /// </summary>
    /// <value>Database ID of test connection task log</value>
    [DataMember(Name="TestConnectionLogId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TestConnectionLogId")]
    public string TestConnectionLogId { get; set; }

    /// <summary>
    /// Gets or Sets TestConnectionState
    /// </summary>
    [DataMember(Name="TestConnectionState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TestConnectionState")]
    public RequestState TestConnectionState { get; set; }

    /// <summary>
    /// Result message from test connection attempt
    /// </summary>
    /// <value>Result message from test connection attempt</value>
    [DataMember(Name="TestConnectionMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TestConnectionMessage")]
    public string TestConnectionMessage { get; set; }

    /// <summary>
    /// The rule that discovered this asset
    /// </summary>
    /// <value>The rule that discovered this asset</value>
    [DataMember(Name="RuleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RuleName")]
    public string RuleName { get; set; }

    /// <summary>
    /// The category of the discovered asset
    /// </summary>
    /// <value>The category of the discovered asset</value>
    [DataMember(Name="ComputerCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ComputerCategory")]
    public string ComputerCategory { get; set; }

    /// <summary>
    /// The unique id of the discovered asset
    /// </summary>
    /// <value>The unique id of the discovered asset</value>
    [DataMember(Name="ObjectGuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectGuid")]
    public string ObjectGuid { get; set; }

    /// <summary>
    /// The sid of the discovered asset
    /// </summary>
    /// <value>The sid of the discovered asset</value>
    [DataMember(Name="ObjectSid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectSid")]
    public string ObjectSid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
