using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a deleted safeguard user.
  /// </summary>
  [DataContract]
  public class DeletedUser {
    /// <summary>
    /// The user's unique id.  This is a system-assigned value that is generated when a user is first created. (Read-only)
    /// </summary>
    /// <value>The user's unique id.  This is a system-assigned value that is generated when a user is first created. (Read-only)</value>
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
    /// A flag indicating whether or not the user is disabled. Read-only for directory users   for which this will be synchronized with the directory.
    /// </summary>
    /// <value>A flag indicating whether or not the user is disabled. Read-only for directory users   for which this will be synchronized with the directory.</value>
    [DataMember(Name="Disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// The id of the user's timezone.
    /// </summary>
    /// <value>The id of the user's timezone.</value>
    [DataMember(Name="TimeZoneId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeZoneId")]
    public string TimeZoneId { get; set; }

    /// <summary>
    /// The description of the user's timezone (Read-only)
    /// </summary>
    /// <value>The description of the user's timezone (Read-only)</value>
    [DataMember(Name="TimeZoneDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeZoneDisplayName")]
    public string TimeZoneDisplayName { get; set; }

    /// <summary>
    /// The IANA name of the user's timezone (Read-only)
    /// </summary>
    /// <value>The IANA name of the user's timezone (Read-only)</value>
    [DataMember(Name="TimeZoneIanaName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeZoneIanaName")]
    public string TimeZoneIanaName { get; set; }

    /// <summary>
    /// Whether this user owns any partitions (Read-only)
    /// </summary>
    /// <value>Whether this user owns any partitions (Read-only)</value>
    [DataMember(Name="IsPartitionOwner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPartitionOwner")]
    public bool? IsPartitionOwner { get; set; }

    /// <summary>
    /// Gets or Sets DirectoryProperties
    /// </summary>
    [DataMember(Name="DirectoryProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryProperties")]
    public DirectoryObjectProperties DirectoryProperties { get; set; }

    /// <summary>
    /// Gets or Sets PrimaryAuthenticationProvider
    /// </summary>
    [DataMember(Name="PrimaryAuthenticationProvider", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryAuthenticationProvider")]
    public UserPrimaryAuthenticationProvider PrimaryAuthenticationProvider { get; set; }

    /// <summary>
    /// Gets or Sets SecondaryAuthenticationProvider
    /// </summary>
    [DataMember(Name="SecondaryAuthenticationProvider", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecondaryAuthenticationProvider")]
    public UserSecondaryAuthenticationProvider SecondaryAuthenticationProvider { get; set; }

    /// <summary>
    /// Gets or Sets IdentityProvider
    /// </summary>
    [DataMember(Name="IdentityProvider", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IdentityProvider")]
    public UserIdentityProvider IdentityProvider { get; set; }

    /// <summary>
    /// A read-only flag indicating that the user's account is locked.  A locked user account may be unlocked by an administrator. (Read-only)
    /// </summary>
    /// <value>A read-only flag indicating that the user's account is locked.  A locked user account may be unlocked by an administrator. (Read-only)</value>
    [DataMember(Name="Locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Locked")]
    public bool? Locked { get; set; }

    /// <summary>
    /// A flag indicating that the user's password never expires. Only meaningful for users whose PrimaryAuthenticationType is 'loc'.
    /// </summary>
    /// <value>A flag indicating that the user's password never expires. Only meaningful for users whose PrimaryAuthenticationType is 'loc'.</value>
    [DataMember(Name="PasswordNeverExpires", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordNeverExpires")]
    public bool? PasswordNeverExpires { get; set; }

    /// <summary>
    /// Binary photo data. Base64 encoded.  Limited to 64 KB when decoded.  Must be a valid BMP, GIF, JPEG, PNG, or TIFF image.
    /// </summary>
    /// <value>Binary photo data. Base64 encoded.  Limited to 64 KB when decoded.  Must be a valid BMP, GIF, JPEG, PNG, or TIFF image.</value>
    [DataMember(Name="Base64PhotoData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Base64PhotoData")]
    public string Base64PhotoData { get; set; }

    /// <summary>
    /// Whether this is a built-in user that cannot be modified (Read-only)
    /// </summary>
    /// <value>Whether this is a built-in user that cannot be modified (Read-only)</value>
    [DataMember(Name="IsSystemOwned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSystemOwned")]
    public bool? IsSystemOwned { get; set; }

    /// <summary>
    /// Date and Time when the user last successfully logged in (Read-only)
    /// </summary>
    /// <value>Date and Time when the user last successfully logged in (Read-only)</value>
    [DataMember(Name="LastLoginDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastLoginDate")]
    public DateTime? LastLoginDate { get; set; }

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
    /// Date this entity was deleted (Read-only)
    /// </summary>
    /// <value>Date this entity was deleted (Read-only)</value>
    [DataMember(Name="DeletedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeletedDate")]
    public DateTime? DeletedDate { get; set; }

    /// <summary>
    /// The database ID of the user that deleted this entity (Read-only)
    /// </summary>
    /// <value>The database ID of the user that deleted this entity (Read-only)</value>
    [DataMember(Name="DeletedByUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeletedByUserId")]
    public int? DeletedByUserId { get; set; }

    /// <summary>
    /// The display name of the user that deleted this entity (Read-only)
    /// </summary>
    /// <value>The display name of the user that deleted this entity (Read-only)</value>
    [DataMember(Name="DeletedByUserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeletedByUserDisplayName")]
    public string DeletedByUserDisplayName { get; set; }

    /// <summary>
    /// If set to {true}, then the user must authenticate with a client certificate.  If they attempt to login with a username and  password, for example, if they are using their Active Directory account, access will be denied. Cannot be disabled if enforced  by Active Directory.
    /// </summary>
    /// <value>If set to {true}, then the user must authenticate with a client certificate.  If they attempt to login with a username and  password, for example, if they are using their Active Directory account, access will be denied. Cannot be disabled if enforced  by Active Directory.</value>
    [DataMember(Name="RequireCertificateAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequireCertificateAuthentication")]
    public bool? RequireCertificateAuthentication { get; set; }

    /// <summary>
    /// If this is an AD user then this will represent the 'Require Smart Card' attribute of the user in AD. If this is true then   RequireCertificateAuthentication will also be set to true
    /// </summary>
    /// <value>If this is an AD user then this will represent the 'Require Smart Card' attribute of the user in AD. If this is true then   RequireCertificateAuthentication will also be set to true</value>
    [DataMember(Name="DirectoryRequireCertificateAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryRequireCertificateAuthentication")]
    public bool? DirectoryRequireCertificateAuthentication { get; set; }

    /// <summary>
    /// If the user is able to create the personal accounts
    /// </summary>
    /// <value>If the user is able to create the personal accounts</value>
    [DataMember(Name="AllowPersonalAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowPersonalAccounts")]
    public bool? AllowPersonalAccounts { get; set; }

    /// <summary>
    /// If set to {true}, then the user must change their password at their  next login.
    /// </summary>
    /// <value>If set to {true}, then the user must change their password at their  next login.</value>
    [DataMember(Name="ChangePasswordAtNextLogin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangePasswordAtNextLogin")]
    public bool? ChangePasswordAtNextLogin { get; set; }

    /// <summary>
    /// Administrative roles this user has been granted. e.g. GlobalAdmin, Auditor, ApplicationAuditor, SystemAuditor, AssetAdmin, ApplianceAdmin, PolicyAdmin, UserAdmin, HelpdeskAdmin, OperationsAdmin
    /// </summary>
    /// <value>Administrative roles this user has been granted. e.g. GlobalAdmin, Auditor, ApplicationAuditor, SystemAuditor, AssetAdmin, ApplianceAdmin, PolicyAdmin, UserAdmin, HelpdeskAdmin, OperationsAdmin</value>
    [DataMember(Name="AdminRoles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdminRoles")]
    public List<AdminRoleName> AdminRoles { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DeletedUser {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
      sb.Append("  WorkPhone: ").Append(WorkPhone).Append("\n");
      sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
      sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
      sb.Append("  TimeZoneDisplayName: ").Append(TimeZoneDisplayName).Append("\n");
      sb.Append("  TimeZoneIanaName: ").Append(TimeZoneIanaName).Append("\n");
      sb.Append("  IsPartitionOwner: ").Append(IsPartitionOwner).Append("\n");
      sb.Append("  DirectoryProperties: ").Append(DirectoryProperties).Append("\n");
      sb.Append("  PrimaryAuthenticationProvider: ").Append(PrimaryAuthenticationProvider).Append("\n");
      sb.Append("  SecondaryAuthenticationProvider: ").Append(SecondaryAuthenticationProvider).Append("\n");
      sb.Append("  IdentityProvider: ").Append(IdentityProvider).Append("\n");
      sb.Append("  Locked: ").Append(Locked).Append("\n");
      sb.Append("  PasswordNeverExpires: ").Append(PasswordNeverExpires).Append("\n");
      sb.Append("  Base64PhotoData: ").Append(Base64PhotoData).Append("\n");
      sb.Append("  IsSystemOwned: ").Append(IsSystemOwned).Append("\n");
      sb.Append("  LastLoginDate: ").Append(LastLoginDate).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
      sb.Append("  DeletedDate: ").Append(DeletedDate).Append("\n");
      sb.Append("  DeletedByUserId: ").Append(DeletedByUserId).Append("\n");
      sb.Append("  DeletedByUserDisplayName: ").Append(DeletedByUserDisplayName).Append("\n");
      sb.Append("  RequireCertificateAuthentication: ").Append(RequireCertificateAuthentication).Append("\n");
      sb.Append("  DirectoryRequireCertificateAuthentication: ").Append(DirectoryRequireCertificateAuthentication).Append("\n");
      sb.Append("  AllowPersonalAccounts: ").Append(AllowPersonalAccounts).Append("\n");
      sb.Append("  ChangePasswordAtNextLogin: ").Append(ChangePasswordAtNextLogin).Append("\n");
      sb.Append("  AdminRoles: ").Append(AdminRoles).Append("\n");
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
