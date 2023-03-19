using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A password rule used to generate account password during password change automation applied to a partition profile.
  /// </summary>
  [DataContract]
  public class AccountPasswordRule {
    /// <summary>
    /// Database ID of the password rule (Read-only)
    /// </summary>
    /// <value>Database ID of the password rule (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// If owned by the system then this rule cannot be deleted (Read-only)
    /// </summary>
    /// <value>If owned by the system then this rule cannot be deleted (Read-only)</value>
    [DataMember(Name="IsSystemOwned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSystemOwned")]
    public bool? IsSystemOwned { get; set; }

    /// <summary>
    /// Database Identifier of this Password Rule's Associated Asset Partition (Read-only)
    /// </summary>
    /// <value>Database Identifier of this Password Rule's Associated Asset Partition (Read-only)</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of this Password Rule's Associated Asset Partition
    /// </summary>
    /// <value>Name of this Password Rule's Associated Asset Partition</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

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
    /// Name of the password rule
    /// </summary>
    /// <value>Name of the password rule</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of the password rule
    /// </summary>
    /// <value>Description of the password rule</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// The maximum length of the password
    /// </summary>
    /// <value>The maximum length of the password</value>
    [DataMember(Name="MaxCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxCharacters")]
    public int? MaxCharacters { get; set; }

    /// <summary>
    /// The minimum length of the password
    /// </summary>
    /// <value>The minimum length of the password</value>
    [DataMember(Name="MinCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinCharacters")]
    public int? MinCharacters { get; set; }

    /// <summary>
    /// Allow uppercase characters in the password?
    /// </summary>
    /// <value>Allow uppercase characters in the password?</value>
    [DataMember(Name="AllowUppercaseCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowUppercaseCharacters")]
    public bool? AllowUppercaseCharacters { get; set; }

    /// <summary>
    /// If allowed, what is the minimum number of uppercase characters required
    /// </summary>
    /// <value>If allowed, what is the minimum number of uppercase characters required</value>
    [DataMember(Name="MinUppercaseCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinUppercaseCharacters")]
    public int? MinUppercaseCharacters { get; set; }

    /// <summary>
    /// List of uppercase alphabet characters that may not be used.
    /// </summary>
    /// <value>List of uppercase alphabet characters that may not be used.</value>
    [DataMember(Name="InvalidUppercaseCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvalidUppercaseCharacters")]
    public List<string> InvalidUppercaseCharacters { get; set; }

    /// <summary>
    /// If allowed, what is the maximum number of uppercase characters that may be used consecutively
    /// </summary>
    /// <value>If allowed, what is the maximum number of uppercase characters that may be used consecutively</value>
    [DataMember(Name="MaxConsecutiveUppercaseCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxConsecutiveUppercaseCharacters")]
    public int? MaxConsecutiveUppercaseCharacters { get; set; }

    /// <summary>
    /// Allow lowercase characters in the password?
    /// </summary>
    /// <value>Allow lowercase characters in the password?</value>
    [DataMember(Name="AllowLowercaseCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowLowercaseCharacters")]
    public bool? AllowLowercaseCharacters { get; set; }

    /// <summary>
    /// If allowed, what is the minimum number of lowercase characters required
    /// </summary>
    /// <value>If allowed, what is the minimum number of lowercase characters required</value>
    [DataMember(Name="MinLowercaseCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinLowercaseCharacters")]
    public int? MinLowercaseCharacters { get; set; }

    /// <summary>
    /// List of lowercase alphabet characters that may not be used.
    /// </summary>
    /// <value>List of lowercase alphabet characters that may not be used.</value>
    [DataMember(Name="InvalidLowercaseCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvalidLowercaseCharacters")]
    public List<string> InvalidLowercaseCharacters { get; set; }

    /// <summary>
    /// If allowed, what is the maximum number of lowercase characters that may be used consecutively
    /// </summary>
    /// <value>If allowed, what is the maximum number of lowercase characters that may be used consecutively</value>
    [DataMember(Name="MaxConsecutiveLowercaseCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxConsecutiveLowercaseCharacters")]
    public int? MaxConsecutiveLowercaseCharacters { get; set; }

    /// <summary>
    /// Allow numeric characters in the password?
    /// </summary>
    /// <value>Allow numeric characters in the password?</value>
    [DataMember(Name="AllowNumericCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowNumericCharacters")]
    public bool? AllowNumericCharacters { get; set; }

    /// <summary>
    /// If allowed, what is the minimum number of numeric characters required
    /// </summary>
    /// <value>If allowed, what is the minimum number of numeric characters required</value>
    [DataMember(Name="MinNumericCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinNumericCharacters")]
    public int? MinNumericCharacters { get; set; }

    /// <summary>
    /// List of numeric characters that may not be used.
    /// </summary>
    /// <value>List of numeric characters that may not be used.</value>
    [DataMember(Name="InvalidNumericCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvalidNumericCharacters")]
    public List<string> InvalidNumericCharacters { get; set; }

    /// <summary>
    /// If allowed, what is the maximum number of numeric characters that may be used consecutively
    /// </summary>
    /// <value>If allowed, what is the maximum number of numeric characters that may be used consecutively</value>
    [DataMember(Name="MaxConsecutiveNumericCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxConsecutiveNumericCharacters")]
    public int? MaxConsecutiveNumericCharacters { get; set; }

    /// <summary>
    /// Allow non-alphanumeric characters in the password?
    /// </summary>
    /// <value>Allow non-alphanumeric characters in the password?</value>
    [DataMember(Name="AllowNonAlphaNumericCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowNonAlphaNumericCharacters")]
    public bool? AllowNonAlphaNumericCharacters { get; set; }

    /// <summary>
    /// If allowed, the minimum number of non-alphanumeric characters required
    /// </summary>
    /// <value>If allowed, the minimum number of non-alphanumeric characters required</value>
    [DataMember(Name="MinNonAlphaNumericCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinNonAlphaNumericCharacters")]
    public int? MinNonAlphaNumericCharacters { get; set; }

    /// <summary>
    /// Gets or Sets NonAlphaNumericRestrictionType
    /// </summary>
    [DataMember(Name="NonAlphaNumericRestrictionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NonAlphaNumericRestrictionType")]
    public NonAlphaNumericRestrictionType NonAlphaNumericRestrictionType { get; set; }

    /// <summary>
    /// List of non-alphanumeric characters that may be used when NonAlphaNumericRestrictionType is set to 'Include'
    /// </summary>
    /// <value>List of non-alphanumeric characters that may be used when NonAlphaNumericRestrictionType is set to 'Include'</value>
    [DataMember(Name="AllowedNonAlphaNumericCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowedNonAlphaNumericCharacters")]
    public List<string> AllowedNonAlphaNumericCharacters { get; set; }

    /// <summary>
    /// List of numeric characters that may not be used when NonAlphaNumericRestrictionType is set to 'Exclude'  NOTE: Generated passwords will be restricted to the set of printable ascii characters.
    /// </summary>
    /// <value>List of numeric characters that may not be used when NonAlphaNumericRestrictionType is set to 'Exclude'  NOTE: Generated passwords will be restricted to the set of printable ascii characters.</value>
    [DataMember(Name="InvalidNonAlphaNumericCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvalidNonAlphaNumericCharacters")]
    public List<string> InvalidNonAlphaNumericCharacters { get; set; }

    /// <summary>
    /// If allowed, what is the maximum number of non-alphanumeric characters that may be used consecutively
    /// </summary>
    /// <value>If allowed, what is the maximum number of non-alphanumeric characters that may be used consecutively</value>
    [DataMember(Name="MaxConsecutiveNonAlphaNumericCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxConsecutiveNonAlphaNumericCharacters")]
    public int? MaxConsecutiveNonAlphaNumericCharacters { get; set; }

    /// <summary>
    /// Gets or Sets AllowedFirstCharacterType
    /// </summary>
    [DataMember(Name="AllowedFirstCharacterType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowedFirstCharacterType")]
    public PasswordCharacterType AllowedFirstCharacterType { get; set; }

    /// <summary>
    /// Gets or Sets AllowedLastCharacterType
    /// </summary>
    [DataMember(Name="AllowedLastCharacterType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowedLastCharacterType")]
    public PasswordCharacterType AllowedLastCharacterType { get; set; }

    /// <summary>
    /// If upper or lower characters are allowed, what is the maximum number of alphabet characters that may be used consecutively
    /// </summary>
    /// <value>If upper or lower characters are allowed, what is the maximum number of alphabet characters that may be used consecutively</value>
    [DataMember(Name="MaxConsecutiveAlphabeticCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxConsecutiveAlphabeticCharacters")]
    public int? MaxConsecutiveAlphabeticCharacters { get; set; }

    /// <summary>
    /// If upper or lower or numeric characters are allowed, what is the maximum number of alphabet or numeric characters that may be used consecutively
    /// </summary>
    /// <value>If upper or lower or numeric characters are allowed, what is the maximum number of alphabet or numeric characters that may be used consecutively</value>
    [DataMember(Name="MaxConsecutiveAlphaNumericCharacters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxConsecutiveAlphaNumericCharacters")]
    public int? MaxConsecutiveAlphaNumericCharacters { get; set; }

    /// <summary>
    /// Gets or Sets RepeatedCharacterRestriction
    /// </summary>
    [DataMember(Name="RepeatedCharacterRestriction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RepeatedCharacterRestriction")]
    public PasswordCharacterRepeatMode RepeatedCharacterRestriction { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountPasswordRule {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsSystemOwned: ").Append(IsSystemOwned).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  MaxCharacters: ").Append(MaxCharacters).Append("\n");
      sb.Append("  MinCharacters: ").Append(MinCharacters).Append("\n");
      sb.Append("  AllowUppercaseCharacters: ").Append(AllowUppercaseCharacters).Append("\n");
      sb.Append("  MinUppercaseCharacters: ").Append(MinUppercaseCharacters).Append("\n");
      sb.Append("  InvalidUppercaseCharacters: ").Append(InvalidUppercaseCharacters).Append("\n");
      sb.Append("  MaxConsecutiveUppercaseCharacters: ").Append(MaxConsecutiveUppercaseCharacters).Append("\n");
      sb.Append("  AllowLowercaseCharacters: ").Append(AllowLowercaseCharacters).Append("\n");
      sb.Append("  MinLowercaseCharacters: ").Append(MinLowercaseCharacters).Append("\n");
      sb.Append("  InvalidLowercaseCharacters: ").Append(InvalidLowercaseCharacters).Append("\n");
      sb.Append("  MaxConsecutiveLowercaseCharacters: ").Append(MaxConsecutiveLowercaseCharacters).Append("\n");
      sb.Append("  AllowNumericCharacters: ").Append(AllowNumericCharacters).Append("\n");
      sb.Append("  MinNumericCharacters: ").Append(MinNumericCharacters).Append("\n");
      sb.Append("  InvalidNumericCharacters: ").Append(InvalidNumericCharacters).Append("\n");
      sb.Append("  MaxConsecutiveNumericCharacters: ").Append(MaxConsecutiveNumericCharacters).Append("\n");
      sb.Append("  AllowNonAlphaNumericCharacters: ").Append(AllowNonAlphaNumericCharacters).Append("\n");
      sb.Append("  MinNonAlphaNumericCharacters: ").Append(MinNonAlphaNumericCharacters).Append("\n");
      sb.Append("  NonAlphaNumericRestrictionType: ").Append(NonAlphaNumericRestrictionType).Append("\n");
      sb.Append("  AllowedNonAlphaNumericCharacters: ").Append(AllowedNonAlphaNumericCharacters).Append("\n");
      sb.Append("  InvalidNonAlphaNumericCharacters: ").Append(InvalidNonAlphaNumericCharacters).Append("\n");
      sb.Append("  MaxConsecutiveNonAlphaNumericCharacters: ").Append(MaxConsecutiveNonAlphaNumericCharacters).Append("\n");
      sb.Append("  AllowedFirstCharacterType: ").Append(AllowedFirstCharacterType).Append("\n");
      sb.Append("  AllowedLastCharacterType: ").Append(AllowedLastCharacterType).Append("\n");
      sb.Append("  MaxConsecutiveAlphabeticCharacters: ").Append(MaxConsecutiveAlphabeticCharacters).Append("\n");
      sb.Append("  MaxConsecutiveAlphaNumericCharacters: ").Append(MaxConsecutiveAlphaNumericCharacters).Append("\n");
      sb.Append("  RepeatedCharacterRestriction: ").Append(RepeatedCharacterRestriction).Append("\n");
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
