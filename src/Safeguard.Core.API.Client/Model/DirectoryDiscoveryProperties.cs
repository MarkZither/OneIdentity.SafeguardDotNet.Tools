using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Properties used when using Directory DiscoveryType
  /// </summary>
  [DataContract]
  public class DirectoryDiscoveryProperties {
    /// <summary>
    /// The directory this job belongs to. Required with 'Directory' discovery type.
    /// </summary>
    /// <value>The directory this job belongs to. Required with 'Directory' discovery type.</value>
    [DataMember(Name="DirectoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryId")]
    public int? DirectoryId { get; set; }

    /// <summary>
    /// Name of the directory this job belongs to (Read-only)
    /// </summary>
    /// <value>Name of the directory this job belongs to (Read-only)</value>
    [DataMember(Name="DirectoryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryName")]
    public string DirectoryName { get; set; }

    /// <summary>
    /// NetworkAddress of the directory this job belongs to (Read-only)
    /// </summary>
    /// <value>NetworkAddress of the directory this job belongs to (Read-only)</value>
    [DataMember(Name="DirectoryNetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryNetworkAddress")]
    public string DirectoryNetworkAddress { get; set; }

    /// <summary>
    /// Platform ID of the directory this job belongs to (Read-only)
    /// </summary>
    /// <value>Platform ID of the directory this job belongs to (Read-only)</value>
    [DataMember(Name="DirectoryPlatformId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryPlatformId")]
    public int? DirectoryPlatformId { get; set; }

    /// <summary>
    /// Gets or Sets DirectoryPlatformType
    /// </summary>
    [DataMember(Name="DirectoryPlatformType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryPlatformType")]
    public PlatformType DirectoryPlatformType { get; set; }

    /// <summary>
    /// Platform display name of the directory this job belongs to (Read-only)
    /// </summary>
    /// <value>Platform display name of the directory this job belongs to (Read-only)</value>
    [DataMember(Name="DirectoryPlatformDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryPlatformDisplayName")]
    public string DirectoryPlatformDisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DirectoryDiscoveryProperties {\n");
      sb.Append("  DirectoryId: ").Append(DirectoryId).Append("\n");
      sb.Append("  DirectoryName: ").Append(DirectoryName).Append("\n");
      sb.Append("  DirectoryNetworkAddress: ").Append(DirectoryNetworkAddress).Append("\n");
      sb.Append("  DirectoryPlatformId: ").Append(DirectoryPlatformId).Append("\n");
      sb.Append("  DirectoryPlatformType: ").Append(DirectoryPlatformType).Append("\n");
      sb.Append("  DirectoryPlatformDisplayName: ").Append(DirectoryPlatformDisplayName).Append("\n");
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
