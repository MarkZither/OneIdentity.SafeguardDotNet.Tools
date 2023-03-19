using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Information about a license
  /// </summary>
  [DataContract]
  public class ProductLicense {
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public LicenseStatus Status { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public LicenseType Type { get; set; }

    /// <summary>
    /// The license key.
    /// </summary>
    /// <value>The license key.</value>
    [DataMember(Name="Key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Key")]
    public string Key { get; set; }

    /// <summary>
    /// Is this an enterprise license.
    /// </summary>
    /// <value>Is this an enterprise license.</value>
    [DataMember(Name="IsEnterprise", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsEnterprise")]
    public bool? IsEnterprise { get; set; }

    /// <summary>
    /// Is the license valid.
    /// </summary>
    /// <value>Is the license valid.</value>
    [DataMember(Name="IsValid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsValid")]
    public bool? IsValid { get; set; }

    /// <summary>
    /// Gets or Sets Module
    /// </summary>
    [DataMember(Name="Module", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Module")]
    public LicensableModule Module { get; set; }

    /// <summary>
    /// The date and time that the license expires, or null  if the license is a perpetual license.
    /// </summary>
    /// <value>The date and time that the license expires, or null  if the license is a perpetual license.</value>
    [DataMember(Name="Expires", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Expires")]
    public DateTime? Expires { get; set; }

    /// <summary>
    /// The number of days remaining until the license expires, or  null if the license is perpetual. Will be negative if the  license is already expired.
    /// </summary>
    /// <value>The number of days remaining until the license expires, or  null if the license is perpetual. Will be negative if the  license is already expired.</value>
    [DataMember(Name="DaysRemaining", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DaysRemaining")]
    public int? DaysRemaining { get; set; }

    /// <summary>
    /// For a trial license, the date by which it must be installed.  If no start-by date is present, this will return null.
    /// </summary>
    /// <value>For a trial license, the date by which it must be installed.  If no start-by date is present, this will return null.</value>
    [DataMember(Name="InstallByDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InstallByDate")]
    public DateTime? InstallByDate { get; set; }

    /// <summary>
    /// For a trial license, the number of days following installation that  the license remains valid. Null if not present.
    /// </summary>
    /// <value>For a trial license, the number of days following installation that  the license remains valid. Null if not present.</value>
    [DataMember(Name="TrialDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TrialDays")]
    public long? TrialDays { get; set; }

    /// <summary>
    /// Is the license expired.
    /// </summary>
    /// <value>Is the license expired.</value>
    [DataMember(Name="IsExpired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsExpired")]
    public bool? IsExpired { get; set; }

    /// <summary>
    /// The name of the user that installed the license, or  null for a license that is not installed.
    /// </summary>
    /// <value>The name of the user that installed the license, or  null for a license that is not installed.</value>
    [DataMember(Name="ChangedByUserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangedByUserDisplayName")]
    public string ChangedByUserDisplayName { get; set; }

    /// <summary>
    /// The id of the user that installed the license, or  null for a license that is not installed.
    /// </summary>
    /// <value>The id of the user that installed the license, or  null for a license that is not installed.</value>
    [DataMember(Name="ChangedByUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangedByUserId")]
    public int? ChangedByUserId { get; set; }

    /// <summary>
    /// The date and time that the license was installed, or  null if the license is not installed.
    /// </summary>
    /// <value>The date and time that the license was installed, or  null if the license is not installed.</value>
    [DataMember(Name="ChangedByDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChangedByDate")]
    public DateTime? ChangedByDate { get; set; }

    /// <summary>
    /// Gets or Sets PasswordManagementLicense
    /// </summary>
    [DataMember(Name="PasswordManagementLicense", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordManagementLicense")]
    public PasswordManagementLicense PasswordManagementLicense { get; set; }

    /// <summary>
    /// Gets or Sets SecretsBrokerLicense
    /// </summary>
    [DataMember(Name="SecretsBrokerLicense", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecretsBrokerLicense")]
    public SecretsBrokerLicense SecretsBrokerLicense { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductLicense {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  IsEnterprise: ").Append(IsEnterprise).Append("\n");
      sb.Append("  IsValid: ").Append(IsValid).Append("\n");
      sb.Append("  Module: ").Append(Module).Append("\n");
      sb.Append("  Expires: ").Append(Expires).Append("\n");
      sb.Append("  DaysRemaining: ").Append(DaysRemaining).Append("\n");
      sb.Append("  InstallByDate: ").Append(InstallByDate).Append("\n");
      sb.Append("  TrialDays: ").Append(TrialDays).Append("\n");
      sb.Append("  IsExpired: ").Append(IsExpired).Append("\n");
      sb.Append("  ChangedByUserDisplayName: ").Append(ChangedByUserDisplayName).Append("\n");
      sb.Append("  ChangedByUserId: ").Append(ChangedByUserId).Append("\n");
      sb.Append("  ChangedByDate: ").Append(ChangedByDate).Append("\n");
      sb.Append("  PasswordManagementLicense: ").Append(PasswordManagementLicense).Append("\n");
      sb.Append("  SecretsBrokerLicense: ").Append(SecretsBrokerLicense).Append("\n");
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
