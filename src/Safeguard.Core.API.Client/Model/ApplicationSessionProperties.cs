using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Configuration of application session
  /// </summary>
  [DataContract]
  public class ApplicationSessionProperties {
    /// <summary>
    /// Database ID of asset hosting application
    /// </summary>
    /// <value>Database ID of asset hosting application</value>
    [DataMember(Name="ApplicationHostAssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationHostAssetId")]
    public int? ApplicationHostAssetId { get; set; }

    /// <summary>
    /// Name of asset hosting application
    /// </summary>
    /// <value>Name of asset hosting application</value>
    [DataMember(Name="ApplicationHostAssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationHostAssetName")]
    public string ApplicationHostAssetName { get; set; }

    /// <summary>
    /// Network address of asset hosting application
    /// </summary>
    /// <value>Network address of asset hosting application</value>
    [DataMember(Name="ApplicationHostAssetNetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationHostAssetNetworkAddress")]
    public string ApplicationHostAssetNetworkAddress { get; set; }

    /// <summary>
    /// Database ID of login account of application host
    /// </summary>
    /// <value>Database ID of login account of application host</value>
    [DataMember(Name="ApplicationHostAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationHostAccountId")]
    public int? ApplicationHostAccountId { get; set; }

    /// <summary>
    /// Name of login account of application host
    /// </summary>
    /// <value>Name of login account of application host</value>
    [DataMember(Name="ApplicationHostAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationHostAccountName")]
    public string ApplicationHostAccountName { get; set; }

    /// <summary>
    /// Name of application
    /// </summary>
    /// <value>Name of application</value>
    [DataMember(Name="ApplicationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationName")]
    public string ApplicationName { get; set; }

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
      sb.Append("class ApplicationSessionProperties {\n");
      sb.Append("  ApplicationHostAssetId: ").Append(ApplicationHostAssetId).Append("\n");
      sb.Append("  ApplicationHostAssetName: ").Append(ApplicationHostAssetName).Append("\n");
      sb.Append("  ApplicationHostAssetNetworkAddress: ").Append(ApplicationHostAssetNetworkAddress).Append("\n");
      sb.Append("  ApplicationHostAccountId: ").Append(ApplicationHostAccountId).Append("\n");
      sb.Append("  ApplicationHostAccountName: ").Append(ApplicationHostAccountName).Append("\n");
      sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
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
