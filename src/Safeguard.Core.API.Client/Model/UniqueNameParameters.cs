using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Parameters for checking uniqueness of entity names
  /// </summary>
  [DataContract]
  public class UniqueNameParameters {
    /// <summary>
    /// Name to check for uniqueness
    /// </summary>
    /// <value>Name to check for uniqueness</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Id of existing entity to exclude from check (for updates)
    /// </summary>
    /// <value>Id of existing entity to exclude from check (for updates)</value>
    [DataMember(Name="ExcludeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExcludeId")]
    public int? ExcludeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UniqueNameParameters {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ExcludeId: ").Append(ExcludeId).Append("\n");
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
