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
  public class IdentityProviderStarlingProperties {
    /// <summary>
    /// Flag indicating whether there is an API key associated with this identity provider (Read-only)
    /// </summary>
    /// <value>Flag indicating whether there is an API key associated with this identity provider (Read-only)</value>
    [DataMember(Name="HasApiKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasApiKey")]
    public bool? HasApiKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentityProviderStarlingProperties {\n");
      sb.Append("  HasApiKey: ").Append(HasApiKey).Append("\n");
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
