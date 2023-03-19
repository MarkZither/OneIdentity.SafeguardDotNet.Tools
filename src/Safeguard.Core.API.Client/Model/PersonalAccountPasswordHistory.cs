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
  public class PersonalAccountPasswordHistory {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Owner Id of the personal account. (Read-Only)
    /// </summary>
    /// <value>Owner Id of the personal account. (Read-Only)</value>
    [DataMember(Name="OwnerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OwnerId")]
    public int? OwnerId { get; set; }

    /// <summary>
    /// Password for the personal account. (Read-Only)
    /// </summary>
    /// <value>Password for the personal account. (Read-Only)</value>
    [DataMember(Name="Password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Password")]
    public string Password { get; set; }

    /// <summary>
    /// Time validity start for personal account password. (Read-Only)
    /// </summary>
    /// <value>Time validity start for personal account password. (Read-Only)</value>
    [DataMember(Name="TimeStarted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeStarted")]
    public DateTime? TimeStarted { get; set; }

    /// <summary>
    /// Time validity end for personal account password. (Read-Only)
    /// </summary>
    /// <value>Time validity end for personal account password. (Read-Only)</value>
    [DataMember(Name="TimeEnded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeEnded")]
    public DateTime? TimeEnded { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PersonalAccountPasswordHistory {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  TimeStarted: ").Append(TimeStarted).Append("\n");
      sb.Append("  TimeEnded: ").Append(TimeEnded).Append("\n");
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
