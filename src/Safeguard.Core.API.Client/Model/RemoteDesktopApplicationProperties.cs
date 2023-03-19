using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Configuration specific to Remote Desktop application sessions
  /// </summary>
  [DataContract]
  public class RemoteDesktopApplicationProperties {
    /// <summary>
    /// Database ID fo the application host asset
    /// </summary>
    /// <value>Database ID fo the application host asset</value>
    [DataMember(Name="ApplicationHostAssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationHostAssetId")]
    public int? ApplicationHostAssetId { get; set; }

    /// <summary>
    /// Gets or Sets ApplicationHostAsset
    /// </summary>
    [DataMember(Name="ApplicationHostAsset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationHostAsset")]
    public PolicyAsset ApplicationHostAsset { get; set; }

    /// <summary>
    /// Database ID fo the application host asset login account
    /// </summary>
    /// <value>Database ID fo the application host asset login account</value>
    [DataMember(Name="ApplicationHostAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationHostAccountId")]
    public int? ApplicationHostAccountId { get; set; }

    /// <summary>
    /// Gets or Sets ApplicationHostLoginAccount
    /// </summary>
    [DataMember(Name="ApplicationHostLoginAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationHostLoginAccount")]
    public PolicyAccount ApplicationHostLoginAccount { get; set; }

    /// <summary>
    /// Remote application display name
    /// </summary>
    /// <value>Remote application display name</value>
    [DataMember(Name="ApplicationDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationDisplayName")]
    public string ApplicationDisplayName { get; set; }

    /// <summary>
    /// Remote application alias
    /// </summary>
    /// <value>Remote application alias</value>
    [DataMember(Name="ApplicationAlias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationAlias")]
    public string ApplicationAlias { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RemoteDesktopApplicationProperties {\n");
      sb.Append("  ApplicationHostAssetId: ").Append(ApplicationHostAssetId).Append("\n");
      sb.Append("  ApplicationHostAsset: ").Append(ApplicationHostAsset).Append("\n");
      sb.Append("  ApplicationHostAccountId: ").Append(ApplicationHostAccountId).Append("\n");
      sb.Append("  ApplicationHostLoginAccount: ").Append(ApplicationHostLoginAccount).Append("\n");
      sb.Append("  ApplicationDisplayName: ").Append(ApplicationDisplayName).Append("\n");
      sb.Append("  ApplicationAlias: ").Append(ApplicationAlias).Append("\n");
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
