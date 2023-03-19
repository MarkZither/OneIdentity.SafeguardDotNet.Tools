using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents the required details to create an access request on behalf of another user.
  /// </summary>
  [DataContract]
  public class RegistrationAccessRequestBroker {
    /// <summary>
    /// The alias registration API key.
    /// </summary>
    /// <value>The alias registration API key.</value>
    [DataMember(Name="ApiKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApiKey")]
    public string ApiKey { get; set; }

    /// <summary>
    /// List of restricted IP addresses
    /// </summary>
    /// <value>List of restricted IP addresses</value>
    [DataMember(Name="IpRestrictions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IpRestrictions")]
    public List<string> IpRestrictions { get; set; }

    /// <summary>
    /// The users for which an access request can be created.
    /// </summary>
    /// <value>The users for which an access request can be created.</value>
    [DataMember(Name="Users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Users")]
    public List<RegistrationAlias> Users { get; set; }

    /// <summary>
    /// The user group for which an access request can be created.
    /// </summary>
    /// <value>The user group for which an access request can be created.</value>
    [DataMember(Name="Groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Groups")]
    public List<RegistrationAliasGroup> Groups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RegistrationAccessRequestBroker {\n");
      sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
      sb.Append("  IpRestrictions: ").Append(IpRestrictions).Append("\n");
      sb.Append("  Users: ").Append(Users).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
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
