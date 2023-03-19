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
  public class ShareWithUser {
    /// <summary>
    /// The user's unique ID.  This is a system-assigned value that is generated when a user is first created. (Read-only)
    /// </summary>
    /// <value>The user's unique ID.  This is a system-assigned value that is generated when a user is first created. (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Friendly identifier of the user's identity in Safeguard.  Must be unique per identity provider.
    /// </summary>
    /// <value>Friendly identifier of the user's identity in Safeguard.  Must be unique per identity provider.</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of this user
    /// </summary>
    /// <value>Description of this user</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// The user's display name (Read-only)
    /// </summary>
    /// <value>The user's display name (Read-only)</value>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The user's last name. No double quotes.
    /// </summary>
    /// <value>The user's last name. No double quotes.</value>
    [DataMember(Name="LastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastName")]
    public string LastName { get; set; }

    /// <summary>
    /// The user's first name. No double quotes.
    /// </summary>
    /// <value>The user's first name. No double quotes.</value>
    [DataMember(Name="FirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// The user's email address.
    /// </summary>
    /// <value>The user's email address.</value>
    [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmailAddress")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// The user's work phone number.
    /// </summary>
    /// <value>The user's work phone number.</value>
    [DataMember(Name="WorkPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WorkPhone")]
    public string WorkPhone { get; set; }

    /// <summary>
    /// The user's mobile phone number.
    /// </summary>
    /// <value>The user's mobile phone number.</value>
    [DataMember(Name="MobilePhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MobilePhone")]
    public string MobilePhone { get; set; }

    /// <summary>
    /// Binary photo data. Base64 encoded.  Limited to 64 KB when decoded.  Must be a valid BMP, GIF, JPEG, PNG, or TIFF image.
    /// </summary>
    /// <value>Binary photo data. Base64 encoded.  Limited to 64 KB when decoded.  Must be a valid BMP, GIF, JPEG, PNG, or TIFF image.</value>
    [DataMember(Name="Base64PhotoData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Base64PhotoData")]
    public string Base64PhotoData { get; set; }

    /// <summary>
    /// Gets or Sets DirectoryProperties
    /// </summary>
    [DataMember(Name="DirectoryProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryProperties")]
    public DirectoryObjectProperties DirectoryProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShareWithUser {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
      sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
      sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
      sb.Append("  Base64PhotoData: ").Append(Base64PhotoData).Append("\n");
      sb.Append("  DirectoryProperties: ").Append(DirectoryProperties).Append("\n");
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
