using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A group of saved requests
  /// </summary>
  [DataContract]
  public class UserRequestFavorite {
    /// <summary>
    /// Database ID of the favorite
    /// </summary>
    /// <value>Database ID of the favorite</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// Name of the favorite
    /// </summary>
    /// <value>Name of the favorite</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of the favorite
    /// </summary>
    /// <value>Description of the favorite</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// User specified category of this request favorite
    /// </summary>
    /// <value>User specified category of this request favorite</value>
    [DataMember(Name="Category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Category")]
    public int? Category { get; set; }

    /// <summary>
    /// Saved requests associated with this group
    /// </summary>
    /// <value>Saved requests associated with this group</value>
    [DataMember(Name="Requests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Requests")]
    public List<SavedAccessRequest> Requests { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserRequestFavorite {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Requests: ").Append(Requests).Append("\n");
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
