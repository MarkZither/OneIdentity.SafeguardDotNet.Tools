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
  public class BackupProtectionSettings {
    /// <summary>
    /// System set guid string when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Password
    /// </summary>
    /// <value>System set guid string when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Password</value>
    [DataMember(Name="BackupPasswordIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BackupPasswordIdentifier")]
    public string BackupPasswordIdentifier { get; set; }

    /// <summary>
    /// Gets or Sets BackupProtectionType
    /// </summary>
    [DataMember(Name="BackupProtectionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BackupProtectionType")]
    public BackupProtectionType BackupProtectionType { get; set; }

    /// <summary>
    /// User defined password when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Password
    /// </summary>
    /// <value>User defined password when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Password</value>
    [DataMember(Name="BackupPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BackupPassword")]
    public string BackupPassword { get; set; }

    /// <summary>
    /// User specified GPG public key name when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Gpg
    /// </summary>
    /// <value>User specified GPG public key name when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Gpg</value>
    [DataMember(Name="BackupGpgPublicKeyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BackupGpgPublicKeyName")]
    public string BackupGpgPublicKeyName { get; set; }

    /// <summary>
    /// User specified GPG public key data when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Gpg
    /// </summary>
    /// <value>User specified GPG public key data when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Gpg</value>
    [DataMember(Name="BackupGpgPublicKeyData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BackupGpgPublicKeyData")]
    public string BackupGpgPublicKeyData { get; set; }

    /// <summary>
    /// User specified GPG public key fingerprint when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Gpg
    /// </summary>
    /// <value>User specified GPG public key fingerprint when Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionSettings.BackupProtectionType is Pangaea.Data.Transfer.V3.BackupRestore.BackupProtectionType.Gpg</value>
    [DataMember(Name="BackupGpgPublicKeyFingerprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BackupGpgPublicKeyFingerprint")]
    public string BackupGpgPublicKeyFingerprint { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BackupProtectionSettings {\n");
      sb.Append("  BackupPasswordIdentifier: ").Append(BackupPasswordIdentifier).Append("\n");
      sb.Append("  BackupProtectionType: ").Append(BackupProtectionType).Append("\n");
      sb.Append("  BackupPassword: ").Append(BackupPassword).Append("\n");
      sb.Append("  BackupGpgPublicKeyName: ").Append(BackupGpgPublicKeyName).Append("\n");
      sb.Append("  BackupGpgPublicKeyData: ").Append(BackupGpgPublicKeyData).Append("\n");
      sb.Append("  BackupGpgPublicKeyFingerprint: ").Append(BackupGpgPublicKeyFingerprint).Append("\n");
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
