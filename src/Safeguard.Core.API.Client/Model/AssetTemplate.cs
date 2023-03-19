using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Asset template for discovered assets
  /// </summary>
  [DataContract]
  public class AssetTemplate {
    /// <summary>
    /// Gets or Sets PasswordProfile
    /// </summary>
    [DataMember(Name="PasswordProfile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordProfile")]
    public AssetPasswordProfileProperties PasswordProfile { get; set; }

    /// <summary>
    /// Gets or Sets SshKeyProfile
    /// </summary>
    [DataMember(Name="SshKeyProfile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyProfile")]
    public AssetSshKeyProfileProperties SshKeyProfile { get; set; }

    /// <summary>
    /// Account discovery schedule to assign to discovered assets
    /// </summary>
    /// <value>Account discovery schedule to assign to discovered assets</value>
    [DataMember(Name="AccountDiscoveryScheduleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDiscoveryScheduleId")]
    public int? AccountDiscoveryScheduleId { get; set; }

    /// <summary>
    /// Name of the Account discovery schedule to assign to discovered assets (Read-only)
    /// </summary>
    /// <value>Name of the Account discovery schedule to assign to discovered assets (Read-only)</value>
    [DataMember(Name="AccountDiscoveryScheduleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDiscoveryScheduleName")]
    public string AccountDiscoveryScheduleName { get; set; }

    /// <summary>
    /// Database ID of the managed network this asset is explicitly assigned to. If null then   managed network will be calculated dynamically.
    /// </summary>
    /// <value>Database ID of the managed network this asset is explicitly assigned to. If null then   managed network will be calculated dynamically.</value>
    [DataMember(Name="ManagedNetworkId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ManagedNetworkId")]
    public int? ManagedNetworkId { get; set; }

    /// <summary>
    /// Display name managed network (Read-only)
    /// </summary>
    /// <value>Display name managed network (Read-only)</value>
    [DataMember(Name="ManagedNetworkName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ManagedNetworkName")]
    public string ManagedNetworkName { get; set; }

    /// <summary>
    /// Platform type to assign to assets discovered by this rule.  If null then the platform will be derived from discovered properties.
    /// </summary>
    /// <value>Platform type to assign to assets discovered by this rule.  If null then the platform will be derived from discovered properties.</value>
    [DataMember(Name="PlatformId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformId")]
    public int? PlatformId { get; set; }

    /// <summary>
    /// Gets or Sets PlatformType
    /// </summary>
    [DataMember(Name="PlatformType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformType")]
    public PlatformType PlatformType { get; set; }

    /// <summary>
    /// Gets or Sets PlatformFamily
    /// </summary>
    [DataMember(Name="PlatformFamily", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformFamily")]
    public PlatformFamily PlatformFamily { get; set; }

    /// <summary>
    /// Display name of assigned platform (Read-only)
    /// </summary>
    /// <value>Display name of assigned platform (Read-only)</value>
    [DataMember(Name="PlatformDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformDisplayName")]
    public string PlatformDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ConnectionProperties
    /// </summary>
    [DataMember(Name="ConnectionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConnectionProperties")]
    public AssetConnectionProperties ConnectionProperties { get; set; }

    /// <summary>
    /// Gets or Sets SessionAccessProperties
    /// </summary>
    [DataMember(Name="SessionAccessProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionAccessProperties")]
    public AssetSessionAccessProperties SessionAccessProperties { get; set; }

    /// <summary>
    /// The tags to be associated with the asset
    /// </summary>
    /// <value>The tags to be associated with the asset</value>
    [DataMember(Name="Tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Tags")]
    public List<Tag> Tags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetTemplate {\n");
      sb.Append("  PasswordProfile: ").Append(PasswordProfile).Append("\n");
      sb.Append("  SshKeyProfile: ").Append(SshKeyProfile).Append("\n");
      sb.Append("  AccountDiscoveryScheduleId: ").Append(AccountDiscoveryScheduleId).Append("\n");
      sb.Append("  AccountDiscoveryScheduleName: ").Append(AccountDiscoveryScheduleName).Append("\n");
      sb.Append("  ManagedNetworkId: ").Append(ManagedNetworkId).Append("\n");
      sb.Append("  ManagedNetworkName: ").Append(ManagedNetworkName).Append("\n");
      sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
      sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
      sb.Append("  PlatformFamily: ").Append(PlatformFamily).Append("\n");
      sb.Append("  PlatformDisplayName: ").Append(PlatformDisplayName).Append("\n");
      sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
      sb.Append("  SessionAccessProperties: ").Append(SessionAccessProperties).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
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
