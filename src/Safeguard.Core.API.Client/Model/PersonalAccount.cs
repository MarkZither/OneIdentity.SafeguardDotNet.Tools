using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an personal password account.
  /// </summary>
  [DataContract]
  public class PersonalAccount {
    /// <summary>
    /// The personal account's unique id.  This is a system-assigned value that is generated when an account is first created. (Read-only)
    /// </summary>
    /// <value>The personal account's unique id.  This is a system-assigned value that is generated when an account is first created. (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// The descriptive name for the personal account.
    /// </summary>
    /// <value>The descriptive name for the personal account.</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// The personal account name.
    /// </summary>
    /// <value>The personal account name.</value>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// The URL that is associated with the personal account.
    /// </summary>
    /// <value>The URL that is associated with the personal account.</value>
    [DataMember(Name="Url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Url")]
    public string Url { get; set; }

    /// <summary>
    /// The notes that are associated with the password account.
    /// </summary>
    /// <value>The notes that are associated with the password account.</value>
    [DataMember(Name="Notes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Notes")]
    public string Notes { get; set; }

    /// <summary>
    /// Expiration date of the personal account password
    /// </summary>
    /// <value>Expiration date of the personal account password</value>
    [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExpirationDate")]
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// The date that the personal password was changed (Read-only)
    /// </summary>
    /// <value>The date that the personal password was changed (Read-only)</value>
    [DataMember(Name="LastChangeDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastChangeDate")]
    public DateTime? LastChangeDate { get; set; }

    /// <summary>
    /// A flag indicating whether or not expiration notifications should be sent to the owner of the personal account.
    /// </summary>
    /// <value>A flag indicating whether or not expiration notifications should be sent to the owner of the personal account.</value>
    [DataMember(Name="DisableNotifications", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisableNotifications")]
    public bool? DisableNotifications { get; set; }

    /// <summary>
    /// Owner Id of the personal account. (Read-Only)
    /// </summary>
    /// <value>Owner Id of the personal account. (Read-Only)</value>
    [DataMember(Name="OwnerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OwnerId")]
    public int? OwnerId { get; set; }

    /// <summary>
    /// The display name of the owner of the personal account. (Read-only)
    /// </summary>
    /// <value>The display name of the owner of the personal account. (Read-only)</value>
    [DataMember(Name="OwnerDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OwnerDisplayName")]
    public string OwnerDisplayName { get; set; }

    /// <summary>
    /// The email address of the owner of the personal account. (Read-only)
    /// </summary>
    /// <value>The email address of the owner of the personal account. (Read-only)</value>
    [DataMember(Name="OwnerEmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OwnerEmailAddress")]
    public string OwnerEmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets SharedWithUser
    /// </summary>
    [DataMember(Name="SharedWithUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SharedWithUser")]
    public ShareWithUser SharedWithUser { get; set; }

    /// <summary>
    /// Id of the user with whom the personal account is shared.
    /// </summary>
    /// <value>Id of the user with whom the personal account is shared.</value>
    [DataMember(Name="SharedWithId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SharedWithId")]
    public int? SharedWithId { get; set; }

    /// <summary>
    /// Expiration date of the personal account share
    /// </summary>
    /// <value>Expiration date of the personal account share</value>
    [DataMember(Name="ShareExpirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShareExpirationDate")]
    public DateTime? ShareExpirationDate { get; set; }

    /// <summary>
    /// A flag indicating whether the personal account is owned by the current user.
    /// </summary>
    /// <value>A flag indicating whether the personal account is owned by the current user.</value>
    [DataMember(Name="IsOwnedByMe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsOwnedByMe")]
    public bool? IsOwnedByMe { get; set; }

    /// <summary>
    /// A flag indicating whether the personal account is currently being shared.
    /// </summary>
    /// <value>A flag indicating whether the personal account is currently being shared.</value>
    [DataMember(Name="IsSharedByMe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSharedByMe")]
    public bool? IsSharedByMe { get; set; }

    /// <summary>
    /// A flag indicating whether the personal account is currently shareable.
    /// </summary>
    /// <value>A flag indicating whether the personal account is currently shareable.</value>
    [DataMember(Name="IsShareable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsShareable")]
    public bool? IsShareable { get; set; }

    /// <summary>
    /// Date this entity was created (Read-only)
    /// </summary>
    /// <value>Date this entity was created (Read-only)</value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PersonalAccount {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Notes: ").Append(Notes).Append("\n");
      sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
      sb.Append("  LastChangeDate: ").Append(LastChangeDate).Append("\n");
      sb.Append("  DisableNotifications: ").Append(DisableNotifications).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  OwnerDisplayName: ").Append(OwnerDisplayName).Append("\n");
      sb.Append("  OwnerEmailAddress: ").Append(OwnerEmailAddress).Append("\n");
      sb.Append("  SharedWithUser: ").Append(SharedWithUser).Append("\n");
      sb.Append("  SharedWithId: ").Append(SharedWithId).Append("\n");
      sb.Append("  ShareExpirationDate: ").Append(ShareExpirationDate).Append("\n");
      sb.Append("  IsOwnedByMe: ").Append(IsOwnedByMe).Append("\n");
      sb.Append("  IsSharedByMe: ").Append(IsSharedByMe).Append("\n");
      sb.Append("  IsShareable: ").Append(IsShareable).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
