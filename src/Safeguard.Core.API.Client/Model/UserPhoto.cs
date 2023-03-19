using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an application user&#x27;s photo.
  /// </summary>
  [DataContract]
  public class UserPhoto {
    /// <summary>
    /// Binary photo data. Base64 encoded. Limited to 100KB when decoded.  Must be a valid BMP, GIF, JPEG, PNG, or TIFF image.
    /// </summary>
    /// <value>Binary photo data. Base64 encoded. Limited to 100KB when decoded.  Must be a valid BMP, GIF, JPEG, PNG, or TIFF image.</value>
    [DataMember(Name="Base64PhotoData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Base64PhotoData")]
    public string Base64PhotoData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserPhoto {\n");
      sb.Append("  Base64PhotoData: ").Append(Base64PhotoData).Append("\n");
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
