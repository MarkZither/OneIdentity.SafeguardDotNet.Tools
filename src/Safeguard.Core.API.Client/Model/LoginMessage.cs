using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a Login Message.
  /// </summary>
  [DataContract]
  public class LoginMessage {
    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="Message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Message")]
    public string Message { get; set; }

    /// <summary>
    /// Date this entity was updated (Read-only)
    /// </summary>
    /// <value>Date this entity was updated (Read-only)</value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    /// The database ID of the user that updated this entity (Read-only)
    /// </summary>
    /// <value>The database ID of the user that updated this entity (Read-only)</value>
    [DataMember(Name="UpdatedByUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedByUserId")]
    public int? UpdatedByUserId { get; set; }

    /// <summary>
    /// The display name of the user that updated this entity (Read-only)
    /// </summary>
    /// <value>The display name of the user that updated this entity (Read-only)</value>
    [DataMember(Name="UpdatedByUserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedByUserDisplayName")]
    public string UpdatedByUserDisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LoginMessage {\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
      sb.Append("  UpdatedByUserId: ").Append(UpdatedByUserId).Append("\n");
      sb.Append("  UpdatedByUserDisplayName: ").Append(UpdatedByUserDisplayName).Append("\n");
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
