using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a user that an application can impersonate.
  /// </summary>
  [DataContract]
  public class RegistrationAlias {
    /// <summary>
    /// User ID.
    /// </summary>
    /// <value>User ID.</value>
    [DataMember(Name="UserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserId")]
    public int? UserId { get; set; }

    /// <summary>
    /// User first name.
    /// </summary>
    /// <value>User first name.</value>
    [DataMember(Name="FirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// User last name.
    /// </summary>
    /// <value>User last name.</value>
    [DataMember(Name="LastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastName")]
    public string LastName { get; set; }

    /// <summary>
    /// User display name.
    /// </summary>
    /// <value>User display name.</value>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// User disabled flag.
    /// </summary>
    /// <value>User disabled flag.</value>
    [DataMember(Name="Disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Disabled")]
    public int? Disabled { get; set; }

    /// <summary>
    /// Directory name.
    /// </summary>
    /// <value>Directory name.</value>
    [DataMember(Name="DirectoryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryName")]
    public string DirectoryName { get; set; }

    /// <summary>
    /// Domain name.
    /// </summary>
    /// <value>Domain name.</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// User name.
    /// </summary>
    /// <value>User name.</value>
    [DataMember(Name="UserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserName")]
    public string UserName { get; set; }

    /// <summary>
    /// Provider name.
    /// </summary>
    /// <value>Provider name.</value>
    [DataMember(Name="ProviderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProviderName")]
    public string ProviderName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RegistrationAlias {\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
      sb.Append("  DirectoryName: ").Append(DirectoryName).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
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
