using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Descriptors for user schema properties
  /// </summary>
  [DataContract]
  public class UserProviderSchemaDescriptors {
    /// <summary>
    /// Gets or Sets UserClassTypeDescriptor
    /// </summary>
    [DataMember(Name="UserClassTypeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserClassTypeDescriptor")]
    public SchemaDescriptor UserClassTypeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets UserNameAttributeDescriptor
    /// </summary>
    [DataMember(Name="UserNameAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserNameAttributeDescriptor")]
    public SchemaDescriptor UserNameAttributeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets FirstNameAttributeDescriptor
    /// </summary>
    [DataMember(Name="FirstNameAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirstNameAttributeDescriptor")]
    public SchemaDescriptor FirstNameAttributeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets LastNameAttributeDescriptor
    /// </summary>
    [DataMember(Name="LastNameAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastNameAttributeDescriptor")]
    public SchemaDescriptor LastNameAttributeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets DescriptionAttributeDescriptor
    /// </summary>
    [DataMember(Name="DescriptionAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DescriptionAttributeDescriptor")]
    public SchemaDescriptor DescriptionAttributeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets MailAttributeDescriptor
    /// </summary>
    [DataMember(Name="MailAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MailAttributeDescriptor")]
    public SchemaDescriptor MailAttributeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets PhoneAttributeDescriptor
    /// </summary>
    [DataMember(Name="PhoneAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PhoneAttributeDescriptor")]
    public SchemaDescriptor PhoneAttributeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets MobileAttributeDescriptor
    /// </summary>
    [DataMember(Name="MobileAttributeDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MobileAttributeDescriptor")]
    public SchemaDescriptor MobileAttributeDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets DirectoryGroupSyncAttributeForExternalFederationAuthenticationDescriptor
    /// </summary>
    [DataMember(Name="DirectoryGroupSyncAttributeForExternalFederationAuthenticationDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryGroupSyncAttributeForExternalFederationAuthenticationDescriptor")]
    public SchemaDescriptor DirectoryGroupSyncAttributeForExternalFederationAuthenticationDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets DirectoryGroupSyncAttributeForRadiusAuthenticationDescriptor
    /// </summary>
    [DataMember(Name="DirectoryGroupSyncAttributeForRadiusAuthenticationDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryGroupSyncAttributeForRadiusAuthenticationDescriptor")]
    public SchemaDescriptor DirectoryGroupSyncAttributeForRadiusAuthenticationDescriptor { get; set; }

    /// <summary>
    /// Gets or Sets DirectoryGroupSyncAttributeForManagedObjectsDescriptor
    /// </summary>
    [DataMember(Name="DirectoryGroupSyncAttributeForManagedObjectsDescriptor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryGroupSyncAttributeForManagedObjectsDescriptor")]
    public SchemaDescriptor DirectoryGroupSyncAttributeForManagedObjectsDescriptor { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserProviderSchemaDescriptors {\n");
      sb.Append("  UserClassTypeDescriptor: ").Append(UserClassTypeDescriptor).Append("\n");
      sb.Append("  UserNameAttributeDescriptor: ").Append(UserNameAttributeDescriptor).Append("\n");
      sb.Append("  FirstNameAttributeDescriptor: ").Append(FirstNameAttributeDescriptor).Append("\n");
      sb.Append("  LastNameAttributeDescriptor: ").Append(LastNameAttributeDescriptor).Append("\n");
      sb.Append("  DescriptionAttributeDescriptor: ").Append(DescriptionAttributeDescriptor).Append("\n");
      sb.Append("  MailAttributeDescriptor: ").Append(MailAttributeDescriptor).Append("\n");
      sb.Append("  PhoneAttributeDescriptor: ").Append(PhoneAttributeDescriptor).Append("\n");
      sb.Append("  MobileAttributeDescriptor: ").Append(MobileAttributeDescriptor).Append("\n");
      sb.Append("  DirectoryGroupSyncAttributeForExternalFederationAuthenticationDescriptor: ").Append(DirectoryGroupSyncAttributeForExternalFederationAuthenticationDescriptor).Append("\n");
      sb.Append("  DirectoryGroupSyncAttributeForRadiusAuthenticationDescriptor: ").Append(DirectoryGroupSyncAttributeForRadiusAuthenticationDescriptor).Append("\n");
      sb.Append("  DirectoryGroupSyncAttributeForManagedObjectsDescriptor: ").Append(DirectoryGroupSyncAttributeForManagedObjectsDescriptor).Append("\n");
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
