using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Platform properties for policy asset
  /// </summary>
  [DataContract]
  public class PolicyAssetPlatformProperties {
    /// <summary>
    /// The database ID of the type of platform (Read-only)
    /// </summary>
    /// <value>The database ID of the type of platform (Read-only)</value>
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
    /// The display name of the type of platform (Read-only)
    /// </summary>
    /// <value>The display name of the type of platform (Read-only)</value>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Whether this asset supports session access
    /// </summary>
    /// <value>Whether this asset supports session access</value>
    [DataMember(Name="SupportsSessionManagement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsSessionManagement")]
    public bool? SupportsSessionManagement { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PolicyAssetPlatformProperties {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  SupportsSessionManagement: ").Append(SupportsSessionManagement).Append("\n");
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
