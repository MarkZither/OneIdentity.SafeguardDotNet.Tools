using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a change to the appliance licenses
  /// </summary>
  [DataContract]
  public class LicenseHistoryLog {
    /// <summary>
    /// Database ID of this log entry
    /// </summary>
    /// <value>Database ID of this log entry</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// Time the change occurred (Read-only)
    /// </summary>
    /// <value>Time the change occurred (Read-only)</value>
    [DataMember(Name="LogTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LogTime")]
    public DateTime? LogTime { get; set; }

    /// <summary>
    /// Unique id of the user that caused the change (Read-only).
    /// </summary>
    /// <value>Unique id of the user that caused the change (Read-only).</value>
    [DataMember(Name="UserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserId")]
    public int? UserId { get; set; }

    /// <summary>
    /// Gets or Sets UserProperties
    /// </summary>
    [DataMember(Name="UserProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserProperties")]
    public UserLogProperties UserProperties { get; set; }

    /// <summary>
    /// Id of appliance
    /// </summary>
    /// <value>Id of appliance</value>
    [DataMember(Name="ApplianceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceId")]
    public string ApplianceId { get; set; }

    /// <summary>
    /// Name of appliance
    /// </summary>
    /// <value>Name of appliance</value>
    [DataMember(Name="ApplianceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceName")]
    public string ApplianceName { get; set; }

    /// <summary>
    /// Gets or Sets EventName
    /// </summary>
    [DataMember(Name="EventName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EventName")]
    public EventName EventName { get; set; }

    /// <summary>
    /// Name of the event
    /// </summary>
    /// <value>Name of the event</value>
    [DataMember(Name="EventDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EventDisplayName")]
    public string EventDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets OperationType
    /// </summary>
    [DataMember(Name="OperationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OperationType")]
    public OperationType OperationType { get; set; }

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
      sb.Append("class LicenseHistoryLog {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LogTime: ").Append(LogTime).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
      sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
      sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
      sb.Append("  EventName: ").Append(EventName).Append("\n");
      sb.Append("  EventDisplayName: ").Append(EventDisplayName).Append("\n");
      sb.Append("  OperationType: ").Append(OperationType).Append("\n");
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
