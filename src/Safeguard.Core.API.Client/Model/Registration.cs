using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an application to application registration.
  /// </summary>
  [DataContract]
  public class Registration {
    /// <summary>
    /// The registration's unique id.  This is a system-assigned value that is generated when a registration is first created. (Read-only)
    /// </summary>
    /// <value>The registration's unique id.  This is a system-assigned value that is generated when a registration is first created. (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// The applications's name.
    /// </summary>
    /// <value>The applications's name.</value>
    [DataMember(Name="AppName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AppName")]
    public string AppName { get; set; }

    /// <summary>
    /// Description of the application
    /// </summary>
    /// <value>Description of the application</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// A flag indicating whether or not the application registration is disabled. Will be disabled if certificate user is disabled.
    /// </summary>
    /// <value>A flag indicating whether or not the application registration is disabled. Will be disabled if certificate user is disabled.</value>
    [DataMember(Name="Disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// A flag indicating whether or not the application self discovery is enabled for the cert user.
    /// </summary>
    /// <value>A flag indicating whether or not the application self discovery is enabled for the cert user.</value>
    [DataMember(Name="VisibleToCertificateUsers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VisibleToCertificateUsers")]
    public bool? VisibleToCertificateUsers { get; set; }

    /// <summary>
    /// The id of the certificate user associated with the registration.
    /// </summary>
    /// <value>The id of the certificate user associated with the registration.</value>
    [DataMember(Name="CertificateUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CertificateUserId")]
    public int? CertificateUserId { get; set; }

    /// <summary>
    /// Thumbprint associated with the certificate user.
    /// </summary>
    /// <value>Thumbprint associated with the certificate user.</value>
    [DataMember(Name="CertificateUserThumbPrint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CertificateUserThumbPrint")]
    public string CertificateUserThumbPrint { get; set; }

    /// <summary>
    /// The accounts for which the credentials can be retrieved.
    /// </summary>
    /// <value>The accounts for which the credentials can be retrieved.</value>
    [DataMember(Name="CertificateUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CertificateUser")]
    public string CertificateUser { get; set; }

    /// <summary>
    /// Date this entity was created (Read-only)
    /// </summary>
    /// <value>Date this entity was created (Read-only)</value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The database ID of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The database ID of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserId")]
    public int? CreatedByUserId { get; set; }

    /// <summary>
    /// The display name of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The display name of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserDisplayName")]
    public string CreatedByUserDisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Registration {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  AppName: ").Append(AppName).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
      sb.Append("  VisibleToCertificateUsers: ").Append(VisibleToCertificateUsers).Append("\n");
      sb.Append("  CertificateUserId: ").Append(CertificateUserId).Append("\n");
      sb.Append("  CertificateUserThumbPrint: ").Append(CertificateUserThumbPrint).Append("\n");
      sb.Append("  CertificateUser: ").Append(CertificateUser).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
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
