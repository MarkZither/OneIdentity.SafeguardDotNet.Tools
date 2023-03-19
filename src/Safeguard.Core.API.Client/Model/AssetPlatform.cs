using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a set of platform specific properties for an asset
  /// </summary>
  [DataContract]
  public class AssetPlatform {
    /// <summary>
    /// The database ID of the platform version (Read-only)
    /// </summary>
    /// <value>The database ID of the platform version (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

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
    /// Display name for the platform (Read-only)
    /// </summary>
    /// <value>Display name for the platform (Read-only)</value>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Name of the platform (Read-only)
    /// </summary>
    /// <value>Name of the platform (Read-only)</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of the platform (Read-only)
    /// </summary>
    /// <value>Description of the platform (Read-only)</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Version of platform
    /// </summary>
    /// <value>Version of platform</value>
    [DataMember(Name="Version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Version")]
    public string Version { get; set; }

    /// <summary>
    /// Architecture of platform
    /// </summary>
    /// <value>Architecture of platform</value>
    [DataMember(Name="Architecture", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Architecture")]
    public string Architecture { get; set; }

    /// <summary>
    /// Gets or Sets DeviceClass
    /// </summary>
    [DataMember(Name="DeviceClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeviceClass")]
    public DeviceClass DeviceClass { get; set; }

    /// <summary>
    /// Does the platform require case sensitive account names? (Read-only)
    /// </summary>
    /// <value>Does the platform require case sensitive account names? (Read-only)</value>
    [DataMember(Name="IsAcctNameCaseSensitive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsAcctNameCaseSensitive")]
    public bool? IsAcctNameCaseSensitive { get; set; }

    /// <summary>
    /// Gets or Sets LicenseClass
    /// </summary>
    [DataMember(Name="LicenseClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LicenseClass")]
    public LicenseClass LicenseClass { get; set; }

    /// <summary>
    /// If system owned then this platform cannot be modified or deleted (Read-only)
    /// </summary>
    /// <value>If system owned then this platform cannot be modified or deleted (Read-only)</value>
    [DataMember(Name="IsSystemOwned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSystemOwned")]
    public bool? IsSystemOwned { get; set; }

    /// <summary>
    /// Operations this custom platform supports (Read-only)
    /// </summary>
    /// <value>Operations this custom platform supports (Read-only)</value>
    [DataMember(Name="SupportedOperations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportedOperations")]
    public List<TaskNames> SupportedOperations { get; set; }

    /// <summary>
    /// Gets or Sets ConnectionProperties
    /// </summary>
    [DataMember(Name="ConnectionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConnectionProperties")]
    public PlatformConnectionProperties ConnectionProperties { get; set; }

    /// <summary>
    /// Gets or Sets PasswordFeatureProperties
    /// </summary>
    [DataMember(Name="PasswordFeatureProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordFeatureProperties")]
    public PlatformPasswordFeatureProperties PasswordFeatureProperties { get; set; }

    /// <summary>
    /// Gets or Sets SessionFeatureProperties
    /// </summary>
    [DataMember(Name="SessionFeatureProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionFeatureProperties")]
    public PlatformSessionFeatureProperties SessionFeatureProperties { get; set; }

    /// <summary>
    /// Gets or Sets CustomScriptProperties
    /// </summary>
    [DataMember(Name="CustomScriptProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomScriptProperties")]
    public PlatformCustomScriptProperties CustomScriptProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetPlatform {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
      sb.Append("  PlatformFamily: ").Append(PlatformFamily).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  Architecture: ").Append(Architecture).Append("\n");
      sb.Append("  DeviceClass: ").Append(DeviceClass).Append("\n");
      sb.Append("  IsAcctNameCaseSensitive: ").Append(IsAcctNameCaseSensitive).Append("\n");
      sb.Append("  LicenseClass: ").Append(LicenseClass).Append("\n");
      sb.Append("  IsSystemOwned: ").Append(IsSystemOwned).Append("\n");
      sb.Append("  SupportedOperations: ").Append(SupportedOperations).Append("\n");
      sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
      sb.Append("  PasswordFeatureProperties: ").Append(PasswordFeatureProperties).Append("\n");
      sb.Append("  SessionFeatureProperties: ").Append(SessionFeatureProperties).Append("\n");
      sb.Append("  CustomScriptProperties: ").Append(CustomScriptProperties).Append("\n");
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
