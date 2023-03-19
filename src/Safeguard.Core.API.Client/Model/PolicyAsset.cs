using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an remote asset available for request. A PolicyAsset is an   alternate view of an asset that is used for AccessPolicies, AssetGroups,  and UserFavorites. The asset must have a password and have AllowSessionRequests set to true  in order to be used in UserFavorites or to be able to request a session on the asset.
  /// </summary>
  [DataContract]
  public class PolicyAsset {
    /// <summary>
    /// A short description of the asset. (Read-only)
    /// </summary>
    /// <value>A short description of the asset. (Read-only)</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// The database key of the asset (Read-only)
    /// </summary>
    /// <value>The database key of the asset (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the asset (Read-only)
    /// </summary>
    /// <value>The name of the asset (Read-only)</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets AssetType
    /// </summary>
    [DataMember(Name="AssetType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetType")]
    public AssetType AssetType { get; set; }

    /// <summary>
    /// The network address of the asset (Read-only)
    /// </summary>
    /// <value>The network address of the asset (Read-only)</value>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

    /// <summary>
    /// Database ID of partition asset belongs to
    /// </summary>
    /// <value>Database ID of partition asset belongs to</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of partition asset belongs to
    /// </summary>
    /// <value>Name of partition asset belongs to</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// The domain name that the asset belongs to. (Read-only)
    /// </summary>
    /// <value>The domain name that the asset belongs to. (Read-only)</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// Whether this asset has been disabled. Prevent it from being used for access requests and automated password tasks (Read-only)
    /// </summary>
    /// <value>Whether this asset has been disabled. Prevent it from being used for access requests and automated password tasks (Read-only)</value>
    [DataMember(Name="Disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Gets or Sets Platform
    /// </summary>
    [DataMember(Name="Platform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Platform")]
    public PolicyAssetPlatformProperties Platform { get; set; }

    /// <summary>
    /// Gets or Sets SshHostKey
    /// </summary>
    [DataMember(Name="SshHostKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshHostKey")]
    public AssetSshHostKey SshHostKey { get; set; }

    /// <summary>
    /// Gets or Sets SessionAccessProperties
    /// </summary>
    [DataMember(Name="SessionAccessProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionAccessProperties")]
    public AssetSessionAccessProperties SessionAccessProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PolicyAsset {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  AssetType: ").Append(AssetType).Append("\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
      sb.Append("  Platform: ").Append(Platform).Append("\n");
      sb.Append("  SshHostKey: ").Append(SshHostKey).Append("\n");
      sb.Append("  SessionAccessProperties: ").Append(SessionAccessProperties).Append("\n");
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
