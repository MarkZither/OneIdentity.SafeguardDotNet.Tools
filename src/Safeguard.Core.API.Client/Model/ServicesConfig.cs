using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents the service configuration on the appliance
  /// </summary>
  [DataContract]
  public class ServicesConfig {
    /// <summary>
    /// Password change enabled
    /// </summary>
    /// <value>Password change enabled</value>
    [DataMember(Name="PasswordChangeEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordChangeEnabled")]
    public bool? PasswordChangeEnabled { get; set; }

    /// <summary>
    /// Password check enabled
    /// </summary>
    /// <value>Password check enabled</value>
    [DataMember(Name="PasswordCheckEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordCheckEnabled")]
    public bool? PasswordCheckEnabled { get; set; }

    /// <summary>
    /// Password requests enabled
    /// </summary>
    /// <value>Password requests enabled</value>
    [DataMember(Name="PasswordRequestsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordRequestsEnabled")]
    public bool? PasswordRequestsEnabled { get; set; }

    /// <summary>
    /// Session requests enabled
    /// </summary>
    /// <value>Session requests enabled</value>
    [DataMember(Name="SessionRequestsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionRequestsEnabled")]
    public bool? SessionRequestsEnabled { get; set; }

    /// <summary>
    /// SSH Key requests enabled
    /// </summary>
    /// <value>SSH Key requests enabled</value>
    [DataMember(Name="SshKeyRequestsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyRequestsEnabled")]
    public bool? SshKeyRequestsEnabled { get; set; }

    /// <summary>
    /// Asset discovery enabled
    /// </summary>
    /// <value>Asset discovery enabled</value>
    [DataMember(Name="AssetDiscoveryEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetDiscoveryEnabled")]
    public bool? AssetDiscoveryEnabled { get; set; }

    /// <summary>
    /// Directory sync enabled
    /// </summary>
    /// <value>Directory sync enabled</value>
    [DataMember(Name="DirectorySyncEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectorySyncEnabled")]
    public bool? DirectorySyncEnabled { get; set; }

    /// <summary>
    /// SSH key enabled
    /// </summary>
    /// <value>SSH key enabled</value>
    [DataMember(Name="SshKeyCheckEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyCheckEnabled")]
    public bool? SshKeyCheckEnabled { get; set; }

    /// <summary>
    /// SSH key change enabled
    /// </summary>
    /// <value>SSH key change enabled</value>
    [DataMember(Name="SshKeyChangeEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyChangeEnabled")]
    public bool? SshKeyChangeEnabled { get; set; }

    /// <summary>
    /// SSH key discovery enabled
    /// </summary>
    /// <value>SSH key discovery enabled</value>
    [DataMember(Name="SshKeyDiscoveryEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyDiscoveryEnabled")]
    public bool? SshKeyDiscoveryEnabled { get; set; }

    /// <summary>
    /// Discover accounts enabled
    /// </summary>
    /// <value>Discover accounts enabled</value>
    [DataMember(Name="DiscoverAccountsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoverAccountsEnabled")]
    public bool? DiscoverAccountsEnabled { get; set; }

    /// <summary>
    /// Discover services enabled
    /// </summary>
    /// <value>Discover services enabled</value>
    [DataMember(Name="DiscoverServicesEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoverServicesEnabled")]
    public bool? DiscoverServicesEnabled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServicesConfig {\n");
      sb.Append("  PasswordChangeEnabled: ").Append(PasswordChangeEnabled).Append("\n");
      sb.Append("  PasswordCheckEnabled: ").Append(PasswordCheckEnabled).Append("\n");
      sb.Append("  PasswordRequestsEnabled: ").Append(PasswordRequestsEnabled).Append("\n");
      sb.Append("  SessionRequestsEnabled: ").Append(SessionRequestsEnabled).Append("\n");
      sb.Append("  SshKeyRequestsEnabled: ").Append(SshKeyRequestsEnabled).Append("\n");
      sb.Append("  AssetDiscoveryEnabled: ").Append(AssetDiscoveryEnabled).Append("\n");
      sb.Append("  DirectorySyncEnabled: ").Append(DirectorySyncEnabled).Append("\n");
      sb.Append("  SshKeyCheckEnabled: ").Append(SshKeyCheckEnabled).Append("\n");
      sb.Append("  SshKeyChangeEnabled: ").Append(SshKeyChangeEnabled).Append("\n");
      sb.Append("  SshKeyDiscoveryEnabled: ").Append(SshKeyDiscoveryEnabled).Append("\n");
      sb.Append("  DiscoverAccountsEnabled: ").Append(DiscoverAccountsEnabled).Append("\n");
      sb.Append("  DiscoverServicesEnabled: ").Append(DiscoverServicesEnabled).Append("\n");
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
