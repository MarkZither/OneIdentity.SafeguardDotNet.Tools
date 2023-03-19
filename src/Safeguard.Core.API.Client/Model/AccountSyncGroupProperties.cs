using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Account sync group properties
  /// </summary>
  [DataContract]
  public class AccountSyncGroupProperties {
    /// <summary>
    /// Unique identifier of sync group this account belongs to if applicable
    /// </summary>
    /// <value>Unique identifier of sync group this account belongs to if applicable</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of sync group this account belongs to if applicable (Read-only)
    /// </summary>
    /// <value>Name of sync group this account belongs to if applicable (Read-only)</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Priority of this account in the sync group
    /// </summary>
    /// <value>Priority of this account in the sync group</value>
    [DataMember(Name="Priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Whether the sync group is disabled
    /// </summary>
    /// <value>Whether the sync group is disabled</value>
    [DataMember(Name="Disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Disabled")]
    public bool? Disabled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountSyncGroupProperties {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
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
