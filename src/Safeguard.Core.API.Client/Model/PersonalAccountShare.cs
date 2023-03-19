using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a shared personal password account.
  /// </summary>
  [DataContract]
  public class PersonalAccountShare {
    /// <summary>
    /// The Id of the user with whom the personal account is shared.
    /// </summary>
    /// <value>The Id of the user with whom the personal account is shared.</value>
    [DataMember(Name="SharedWithId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SharedWithId")]
    public int? SharedWithId { get; set; }

    /// <summary>
    /// Expiration date of the personal account share.
    /// </summary>
    /// <value>Expiration date of the personal account share.</value>
    [DataMember(Name="ShareExpirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShareExpirationDate")]
    public DateTime? ShareExpirationDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PersonalAccountShare {\n");
      sb.Append("  SharedWithId: ").Append(SharedWithId).Append("\n");
      sb.Append("  ShareExpirationDate: ").Append(ShareExpirationDate).Append("\n");
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
