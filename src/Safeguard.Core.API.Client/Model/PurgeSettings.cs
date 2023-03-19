using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents setting governing how long to retain deleted entities
  /// </summary>
  [DataContract]
  public class PurgeSettings {
    /// <summary>
    /// Whether to automatically purged expired deleted assets
    /// </summary>
    /// <value>Whether to automatically purged expired deleted assets</value>
    [DataMember(Name="AutoPurgeAssets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AutoPurgeAssets")]
    public bool? AutoPurgeAssets { get; set; }

    /// <summary>
    /// How long to retain deleted assets before purging
    /// </summary>
    /// <value>How long to retain deleted assets before purging</value>
    [DataMember(Name="DeletedAssetRetentionInDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeletedAssetRetentionInDays")]
    public int? DeletedAssetRetentionInDays { get; set; }

    /// <summary>
    /// Whether to automatically purged expired deleted asset accounts
    /// </summary>
    /// <value>Whether to automatically purged expired deleted asset accounts</value>
    [DataMember(Name="AutoPurgeAssetAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AutoPurgeAssetAccounts")]
    public bool? AutoPurgeAssetAccounts { get; set; }

    /// <summary>
    /// How long to retain deleted asset accounts before purging
    /// </summary>
    /// <value>How long to retain deleted asset accounts before purging</value>
    [DataMember(Name="DeletedAssetAccountRetentionInDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeletedAssetAccountRetentionInDays")]
    public int? DeletedAssetAccountRetentionInDays { get; set; }

    /// <summary>
    /// Whether to automatically purged expired deleted users
    /// </summary>
    /// <value>Whether to automatically purged expired deleted users</value>
    [DataMember(Name="AutoPurgeUsers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AutoPurgeUsers")]
    public bool? AutoPurgeUsers { get; set; }

    /// <summary>
    /// How long to retain deleted using before purging
    /// </summary>
    /// <value>How long to retain deleted using before purging</value>
    [DataMember(Name="DeletedUserRetentionInDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeletedUserRetentionInDays")]
    public int? DeletedUserRetentionInDays { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PurgeSettings {\n");
      sb.Append("  AutoPurgeAssets: ").Append(AutoPurgeAssets).Append("\n");
      sb.Append("  DeletedAssetRetentionInDays: ").Append(DeletedAssetRetentionInDays).Append("\n");
      sb.Append("  AutoPurgeAssetAccounts: ").Append(AutoPurgeAssetAccounts).Append("\n");
      sb.Append("  DeletedAssetAccountRetentionInDays: ").Append(DeletedAssetAccountRetentionInDays).Append("\n");
      sb.Append("  AutoPurgeUsers: ").Append(AutoPurgeUsers).Append("\n");
      sb.Append("  DeletedUserRetentionInDays: ").Append(DeletedUserRetentionInDays).Append("\n");
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
