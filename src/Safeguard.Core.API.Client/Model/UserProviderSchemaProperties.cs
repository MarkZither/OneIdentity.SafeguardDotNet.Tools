using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Directory attribute mappings for users
  /// </summary>
  [DataContract]
  public class UserProviderSchemaProperties {
    /// <summary>
    /// LDAP objects that have all of the specified objectClass types will be treated as users.  These objectClass types will also be used to validate the attributes mapped to user properties.
    /// </summary>
    /// <value>LDAP objects that have all of the specified objectClass types will be treated as users.  These objectClass types will also be used to validate the attributes mapped to user properties.</value>
    [DataMember(Name="UserClassType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserClassType")]
    public List<string> UserClassType { get; set; }

    /// <summary>
    /// Name of user name schema attribute
    /// </summary>
    /// <value>Name of user name schema attribute</value>
    [DataMember(Name="UserNameAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserNameAttribute")]
    public string UserNameAttribute { get; set; }

    /// <summary>
    /// Name of first name schema attribute
    /// </summary>
    /// <value>Name of first name schema attribute</value>
    [DataMember(Name="FirstNameAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirstNameAttribute")]
    public string FirstNameAttribute { get; set; }

    /// <summary>
    /// Name of last name schema attribute
    /// </summary>
    /// <value>Name of last name schema attribute</value>
    [DataMember(Name="LastNameAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastNameAttribute")]
    public string LastNameAttribute { get; set; }

    /// <summary>
    /// Name of description schema attribute
    /// </summary>
    /// <value>Name of description schema attribute</value>
    [DataMember(Name="DescriptionAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DescriptionAttribute")]
    public string DescriptionAttribute { get; set; }

    /// <summary>
    /// Name of mail schema attribute
    /// </summary>
    /// <value>Name of mail schema attribute</value>
    [DataMember(Name="MailAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MailAttribute")]
    public string MailAttribute { get; set; }

    /// <summary>
    /// Name of phone schema attribute
    /// </summary>
    /// <value>Name of phone schema attribute</value>
    [DataMember(Name="PhoneAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PhoneAttribute")]
    public string PhoneAttribute { get; set; }

    /// <summary>
    /// Name of mobile schema attribute
    /// </summary>
    /// <value>Name of mobile schema attribute</value>
    [DataMember(Name="MobileAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MobileAttribute")]
    public string MobileAttribute { get; set; }

    /// <summary>
    /// Name of attribute used while adding users of a directory user group from which the imported user's primary              authentication identity (email address or name claim) will come from when an external federation provider has been              chosen as that group's means of authentication.
    /// </summary>
    /// <value>Name of attribute used while adding users of a directory user group from which the imported user's primary              authentication identity (email address or name claim) will come from when an external federation provider has been              chosen as that group's means of authentication.</value>
    [DataMember(Name="DirectoryGroupSyncAttributeForExternalFederationAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryGroupSyncAttributeForExternalFederationAuthentication")]
    public string DirectoryGroupSyncAttributeForExternalFederationAuthentication { get; set; }

    /// <summary>
    /// Name of attribute used while adding users of a directory user group from which the imported user's primary              or secondary authentication identity will come from when a RADIUS provider has been chosen as that group's means of              primary or secondary authentication.
    /// </summary>
    /// <value>Name of attribute used while adding users of a directory user group from which the imported user's primary              or secondary authentication identity will come from when a RADIUS provider has been chosen as that group's means of              primary or secondary authentication.</value>
    [DataMember(Name="DirectoryGroupSyncAttributeForRadiusAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryGroupSyncAttributeForRadiusAuthentication")]
    public string DirectoryGroupSyncAttributeForRadiusAuthentication { get; set; }

    /// <summary>
    /// Name of attribute used while adding users of a directory user group from which the imported user's linked              accounts will automatically be associated to their Safeguard user.
    /// </summary>
    /// <value>Name of attribute used while adding users of a directory user group from which the imported user's linked              accounts will automatically be associated to their Safeguard user.</value>
    [DataMember(Name="DirectoryGroupSyncAttributeForManagedObjects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryGroupSyncAttributeForManagedObjects")]
    public string DirectoryGroupSyncAttributeForManagedObjects { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserProviderSchemaProperties {\n");
      sb.Append("  UserClassType: ").Append(UserClassType).Append("\n");
      sb.Append("  UserNameAttribute: ").Append(UserNameAttribute).Append("\n");
      sb.Append("  FirstNameAttribute: ").Append(FirstNameAttribute).Append("\n");
      sb.Append("  LastNameAttribute: ").Append(LastNameAttribute).Append("\n");
      sb.Append("  DescriptionAttribute: ").Append(DescriptionAttribute).Append("\n");
      sb.Append("  MailAttribute: ").Append(MailAttribute).Append("\n");
      sb.Append("  PhoneAttribute: ").Append(PhoneAttribute).Append("\n");
      sb.Append("  MobileAttribute: ").Append(MobileAttribute).Append("\n");
      sb.Append("  DirectoryGroupSyncAttributeForExternalFederationAuthentication: ").Append(DirectoryGroupSyncAttributeForExternalFederationAuthentication).Append("\n");
      sb.Append("  DirectoryGroupSyncAttributeForRadiusAuthentication: ").Append(DirectoryGroupSyncAttributeForRadiusAuthentication).Append("\n");
      sb.Append("  DirectoryGroupSyncAttributeForManagedObjects: ").Append(DirectoryGroupSyncAttributeForManagedObjects).Append("\n");
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
