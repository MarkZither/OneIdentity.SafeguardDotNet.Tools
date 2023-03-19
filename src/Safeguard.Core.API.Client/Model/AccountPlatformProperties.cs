using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Account platform properties
  /// </summary>
  [DataContract]
  public class AccountPlatformProperties {
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
    /// Does the platform require case sensitive account names?
    /// </summary>
    /// <value>Does the platform require case sensitive account names?</value>
    [DataMember(Name="IsAcctNameCaseSensitive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsAcctNameCaseSensitive")]
    public bool? IsAcctNameCaseSensitive { get; set; }

    /// <summary>
    /// Does the platform support sessions?
    /// </summary>
    /// <value>Does the platform support sessions?</value>
    [DataMember(Name="SupportsSessionManagement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsSessionManagement")]
    public bool? SupportsSessionManagement { get; set; }

    /// <summary>
    /// Gets or Sets PlatformFamily
    /// </summary>
    [DataMember(Name="PlatformFamily", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformFamily")]
    public PlatformFamily PlatformFamily { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountPlatformProperties {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  IsAcctNameCaseSensitive: ").Append(IsAcctNameCaseSensitive).Append("\n");
      sb.Append("  SupportsSessionManagement: ").Append(SupportsSessionManagement).Append("\n");
      sb.Append("  PlatformFamily: ").Append(PlatformFamily).Append("\n");
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
