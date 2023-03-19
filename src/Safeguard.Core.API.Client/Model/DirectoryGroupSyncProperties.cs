using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// When a User Group is imported into Safeguard from a directory such as Active Directory or OpenLDAP, you can              configure certain properties of the imported users to be set based upon the value(s) of specified directory attributes              of that user.  For example, you can set the Safeguard user&#x27;s primary authentication provider to be something other              than the directory itself, and then set the Safeguard user&#x27;s primary authentication login name to the value of the              &#x27;employeeID&#x27; attribute in the directory.
  /// </summary>
  [DataContract]
  public class DirectoryGroupSyncProperties {
    /// <summary>
    /// Specify the primary authentication provider that all members will use to authenticate when accessing              Safeguard.  Note, this will only be applied to new users being added to Safeguard at the time the group is saved.              That is, if a member of a directory group already has a corresponding Safeguard user, then that user's              authentication settings will not change.  This behavior can be overridden by calling the /UserGroups/{id}/SynchronizeDirectoryGroupAndUpdateAuthenticationProvidersOnExistingUsers              API method.
    /// </summary>
    /// <value>Specify the primary authentication provider that all members will use to authenticate when accessing              Safeguard.  Note, this will only be applied to new users being added to Safeguard at the time the group is saved.              That is, if a member of a directory group already has a corresponding Safeguard user, then that user's              authentication settings will not change.  This behavior can be overridden by calling the /UserGroups/{id}/SynchronizeDirectoryGroupAndUpdateAuthenticationProvidersOnExistingUsers              API method.</value>
    [DataMember(Name="PrimaryAuthenticationProviderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryAuthenticationProviderId")]
    public int? PrimaryAuthenticationProviderId { get; set; }

    /// <summary>
    /// Gets or Sets PrimaryAuthenticationProviderTypeReferenceName
    /// </summary>
    [DataMember(Name="PrimaryAuthenticationProviderTypeReferenceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryAuthenticationProviderTypeReferenceName")]
    public IdentityProviderTypeReferenceName PrimaryAuthenticationProviderTypeReferenceName { get; set; }

    /// <summary>
    /// The friendly display name of the specified primary authentication provider.  (Read-only)
    /// </summary>
    /// <value>The friendly display name of the specified primary authentication provider.  (Read-only)</value>
    [DataMember(Name="PrimaryAuthenticationProviderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryAuthenticationProviderName")]
    public string PrimaryAuthenticationProviderName { get; set; }

    /// <summary>
    /// If set to {true}, then the user must authenticate with a client certificate. If they attempt to login              with a username and password, for example, if they are using their Active Directory account, access will be denied.              Cannot be disabled if enforced by Active Directory.  This is only applicable when Active Directory is being used              to authenticate a user.
    /// </summary>
    /// <value>If set to {true}, then the user must authenticate with a client certificate. If they attempt to login              with a username and password, for example, if they are using their Active Directory account, access will be denied.              Cannot be disabled if enforced by Active Directory.  This is only applicable when Active Directory is being used              to authenticate a user.</value>
    [DataMember(Name="RequireCertificateAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequireCertificateAuthentication")]
    public bool? RequireCertificateAuthentication { get; set; }

    /// <summary>
    /// Specify the secondary authentication provider that all members will use when authenticating against              Safeguard.  Note, this will only be applied to new users being added to Safeguard at the time the group is saved.              That is, if a member of a directory group already has a corresponding Safeguard user, then that user's              authentication settings will not change.  This behavior can be overridden by calling the /UserGroups/{id}/SynchronizeDirectoryGroupAndUpdateAuthenticationProvidersOnExistingUsers              API method.
    /// </summary>
    /// <value>Specify the secondary authentication provider that all members will use when authenticating against              Safeguard.  Note, this will only be applied to new users being added to Safeguard at the time the group is saved.              That is, if a member of a directory group already has a corresponding Safeguard user, then that user's              authentication settings will not change.  This behavior can be overridden by calling the /UserGroups/{id}/SynchronizeDirectoryGroupAndUpdateAuthenticationProvidersOnExistingUsers              API method.</value>
    [DataMember(Name="SecondaryAuthenticationProviderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecondaryAuthenticationProviderId")]
    public int? SecondaryAuthenticationProviderId { get; set; }

    /// <summary>
    /// Gets or Sets SecondaryAuthenticationProviderTypeReferenceName
    /// </summary>
    [DataMember(Name="SecondaryAuthenticationProviderTypeReferenceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecondaryAuthenticationProviderTypeReferenceName")]
    public IdentityProviderTypeReferenceName SecondaryAuthenticationProviderTypeReferenceName { get; set; }

    /// <summary>
    /// The friendly display name of the specified secondary authentication provider.  (Read-only)
    /// </summary>
    /// <value>The friendly display name of the specified secondary authentication provider.  (Read-only)</value>
    [DataMember(Name="SecondaryAuthenticationProviderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecondaryAuthenticationProviderName")]
    public string SecondaryAuthenticationProviderName { get; set; }

    /// <summary>
    /// When set to {true}, if the directory user has any managed objects in the directory that also exist              as Directory Accounts in Safeguard, then those Directory Accounts in Safeguard will automatically be assigned as              a Linked Account to the user in Safeguard.  Safeguard will look at the directory user's attribute specified in the              schema attributes, for example, 'managedObjects' in Active Directory by default, to get the list of possible accounts.              This includes flattening any directory security groups or organizational units.
    /// </summary>
    /// <value>When set to {true}, if the directory user has any managed objects in the directory that also exist              as Directory Accounts in Safeguard, then those Directory Accounts in Safeguard will automatically be assigned as              a Linked Account to the user in Safeguard.  Safeguard will look at the directory user's attribute specified in the              schema attributes, for example, 'managedObjects' in Active Directory by default, to get the list of possible accounts.              This includes flattening any directory security groups or organizational units.</value>
    [DataMember(Name="LinkDirectoryAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LinkDirectoryAccounts")]
    public bool? LinkDirectoryAccounts { get; set; }

    /// <summary>
    /// When set to {true}, will let the directory user create personal accounts              in Safeguard.
    /// </summary>
    /// <value>When set to {true}, will let the directory user create personal accounts              in Safeguard.</value>
    [DataMember(Name="AllowPersonalAccounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowPersonalAccounts")]
    public bool? AllowPersonalAccounts { get; set; }

    /// <summary>
    /// Administrative roles that each imported user of the group will be granted. e.g. GlobalAdmin, DirectoryAdmin,              Auditor, AssetAdmin, ApplianceAdmin, PolicyAdmin, UserAdmin, HelpdeskAdmin, OperationsAdmin.
    /// </summary>
    /// <value>Administrative roles that each imported user of the group will be granted. e.g. GlobalAdmin, DirectoryAdmin,              Auditor, AssetAdmin, ApplianceAdmin, PolicyAdmin, UserAdmin, HelpdeskAdmin, OperationsAdmin.</value>
    [DataMember(Name="AdminRoles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdminRoles")]
    public List<AdminRoleName> AdminRoles { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DirectoryGroupSyncProperties {\n");
      sb.Append("  PrimaryAuthenticationProviderId: ").Append(PrimaryAuthenticationProviderId).Append("\n");
      sb.Append("  PrimaryAuthenticationProviderTypeReferenceName: ").Append(PrimaryAuthenticationProviderTypeReferenceName).Append("\n");
      sb.Append("  PrimaryAuthenticationProviderName: ").Append(PrimaryAuthenticationProviderName).Append("\n");
      sb.Append("  RequireCertificateAuthentication: ").Append(RequireCertificateAuthentication).Append("\n");
      sb.Append("  SecondaryAuthenticationProviderId: ").Append(SecondaryAuthenticationProviderId).Append("\n");
      sb.Append("  SecondaryAuthenticationProviderTypeReferenceName: ").Append(SecondaryAuthenticationProviderTypeReferenceName).Append("\n");
      sb.Append("  SecondaryAuthenticationProviderName: ").Append(SecondaryAuthenticationProviderName).Append("\n");
      sb.Append("  LinkDirectoryAccounts: ").Append(LinkDirectoryAccounts).Append("\n");
      sb.Append("  AllowPersonalAccounts: ").Append(AllowPersonalAccounts).Append("\n");
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
