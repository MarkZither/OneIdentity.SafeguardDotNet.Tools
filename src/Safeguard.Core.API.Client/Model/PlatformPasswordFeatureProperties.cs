using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Settings related to password management features
  /// </summary>
  [DataContract]
  public class PlatformPasswordFeatureProperties {
    /// <summary>
    /// Whether this platform supports automated management of account passwords
    /// </summary>
    /// <value>Whether this platform supports automated management of account passwords</value>
    [DataMember(Name="SupportsPasswordManagement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsPasswordManagement")]
    public bool? SupportsPasswordManagement { get; set; }

    /// <summary>
    /// Whether this platform supports automated management of account SSH keys
    /// </summary>
    /// <value>Whether this platform supports automated management of account SSH keys</value>
    [DataMember(Name="SupportsSshKeyManagement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsSshKeyManagement")]
    public bool? SupportsSshKeyManagement { get; set; }

    /// <summary>
    /// Whether this platform supports account discovery
    /// </summary>
    /// <value>Whether this platform supports account discovery</value>
    [DataMember(Name="SupportsAccountDiscovery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsAccountDiscovery")]
    public bool? SupportsAccountDiscovery { get; set; }

    /// <summary>
    /// Whether this platform allows local service/task updates of directory account passwords
    /// </summary>
    /// <value>Whether this platform allows local service/task updates of directory account passwords</value>
    [DataMember(Name="SupportsDependentSystemTasks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsDependentSystemTasks")]
    public bool? SupportsDependentSystemTasks { get; set; }

    /// <summary>
    /// Whether this platform supports use of the current account password when managing passwords
    /// </summary>
    /// <value>Whether this platform supports use of the current account password when managing passwords</value>
    [DataMember(Name="AllowRequireCurrentPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowRequireCurrentPassword")]
    public bool? AllowRequireCurrentPassword { get; set; }

    /// <summary>
    /// Whether a network address is required for this platform
    /// </summary>
    /// <value>Whether a network address is required for this platform</value>
    [DataMember(Name="RequireNetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequireNetworkAddress")]
    public bool? RequireNetworkAddress { get; set; }

    /// <summary>
    /// Whether this platform supports service discovery
    /// </summary>
    /// <value>Whether this platform supports service discovery</value>
    [DataMember(Name="SupportsServiceDiscovery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsServiceDiscovery")]
    public bool? SupportsServiceDiscovery { get; set; }

    /// <summary>
    /// Set to true if this platform is a directory that supports password hashing management itself (read-only)
    /// </summary>
    /// <value>Set to true if this platform is a directory that supports password hashing management itself (read-only)</value>
    [DataMember(Name="SupportsUsePasswordHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsUsePasswordHash")]
    public bool? SupportsUsePasswordHash { get; set; }

    /// <summary>
    /// Whether this platform allows accounts to be suspended/restored (disabled/enabled)
    /// </summary>
    /// <value>Whether this platform allows accounts to be suspended/restored (disabled/enabled)</value>
    [DataMember(Name="SupportsSuspendRestoreAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsSuspendRestoreAccount")]
    public bool? SupportsSuspendRestoreAccount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PlatformPasswordFeatureProperties {\n");
      sb.Append("  SupportsPasswordManagement: ").Append(SupportsPasswordManagement).Append("\n");
      sb.Append("  SupportsSshKeyManagement: ").Append(SupportsSshKeyManagement).Append("\n");
      sb.Append("  SupportsAccountDiscovery: ").Append(SupportsAccountDiscovery).Append("\n");
      sb.Append("  SupportsDependentSystemTasks: ").Append(SupportsDependentSystemTasks).Append("\n");
      sb.Append("  AllowRequireCurrentPassword: ").Append(AllowRequireCurrentPassword).Append("\n");
      sb.Append("  RequireNetworkAddress: ").Append(RequireNetworkAddress).Append("\n");
      sb.Append("  SupportsServiceDiscovery: ").Append(SupportsServiceDiscovery).Append("\n");
      sb.Append("  SupportsUsePasswordHash: ").Append(SupportsUsePasswordHash).Append("\n");
      sb.Append("  SupportsSuspendRestoreAccount: ").Append(SupportsSuspendRestoreAccount).Append("\n");
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
