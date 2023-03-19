using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Profile information for accounts
  /// </summary>
  [DataContract]
  public class AccountProfileProperties {
    /// <summary>
    /// Database ID of profile explicitly assigned to this account
    /// </summary>
    /// <value>Database ID of profile explicitly assigned to this account</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of the profile explicitly assigned to the account (Read-only)
    /// </summary>
    /// <value>Name of the profile explicitly assigned to the account (Read-only)</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Database ID of the profile to be used by this account. If Id is null this is inherited from the asset or partition it belongs to (Read-only)
    /// </summary>
    /// <value>Database ID of the profile to be used by this account. If Id is null this is inherited from the asset or partition it belongs to (Read-only)</value>
    [DataMember(Name="EffectiveId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveId")]
    public int? EffectiveId { get; set; }

    /// <summary>
    /// Name of the profile to be used this account. If Name is null this is inherited from the asset or partition it belongs to (Read-only)
    /// </summary>
    /// <value>Name of the profile to be used this account. If Name is null this is inherited from the asset or partition it belongs to (Read-only)</value>
    [DataMember(Name="EffectiveName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveName")]
    public string EffectiveName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountProfileProperties {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  EffectiveId: ").Append(EffectiveId).Append("\n");
      sb.Append("  EffectiveName: ").Append(EffectiveName).Append("\n");
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
