using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A resource representing the contact info of people associated with different roles in the password policy
  /// </summary>
  [DataContract]
  public class NotificationContact {
    /// <summary>
    /// The contact adress, e.g. bob@example.com (Read-only)
    /// </summary>
    /// <value>The contact adress, e.g. bob@example.com (Read-only)</value>
    [DataMember(Name="ContactAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContactAddress")]
    public string ContactAddress { get; set; }

    /// <summary>
    /// Gets or Sets ContactType
    /// </summary>
    [DataMember(Name="ContactType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContactType")]
    public NotificationContactType ContactType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NotificationContact {\n");
      sb.Append("  ContactAddress: ").Append(ContactAddress).Append("\n");
      sb.Append("  ContactType: ").Append(ContactType).Append("\n");
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
