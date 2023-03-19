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
  public class MeEntitlementAccount {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets DomainName
    /// </summary>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets HasPassword
    /// </summary>
    [DataMember(Name="HasPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasPassword")]
    public bool? HasPassword { get; set; }

    /// <summary>
    /// Gets or Sets HasSshKey
    /// </summary>
    [DataMember(Name="HasSshKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasSshKey")]
    public bool? HasSshKey { get; set; }

    /// <summary>
    /// Gets or Sets Disabled
    /// </summary>
    [DataMember(Name="Disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Gets or Sets AssetId
    /// </summary>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Gets or Sets AssetName
    /// </summary>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Gets or Sets AssetNetworkAddress
    /// </summary>
    [DataMember(Name="AssetNetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetNetworkAddress")]
    public string AssetNetworkAddress { get; set; }

    /// <summary>
    /// Gets or Sets AllowPasswordRequest
    /// </summary>
    [DataMember(Name="AllowPasswordRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowPasswordRequest")]
    public bool? AllowPasswordRequest { get; set; }

    /// <summary>
    /// Gets or Sets AllowSessionRequest
    /// </summary>
    [DataMember(Name="AllowSessionRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSessionRequest")]
    public bool? AllowSessionRequest { get; set; }

    /// <summary>
    /// Gets or Sets AllowSshKeyRequest
    /// </summary>
    [DataMember(Name="AllowSshKeyRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSshKeyRequest")]
    public bool? AllowSshKeyRequest { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MeEntitlementAccount {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  HasPassword: ").Append(HasPassword).Append("\n");
      sb.Append("  HasSshKey: ").Append(HasSshKey).Append("\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  AssetNetworkAddress: ").Append(AssetNetworkAddress).Append("\n");
      sb.Append("  AllowPasswordRequest: ").Append(AllowPasswordRequest).Append("\n");
      sb.Append("  AllowSessionRequest: ").Append(AllowSessionRequest).Append("\n");
      sb.Append("  AllowSshKeyRequest: ").Append(AllowSshKeyRequest).Append("\n");
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
