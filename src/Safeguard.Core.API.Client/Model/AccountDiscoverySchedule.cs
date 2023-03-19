using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Account Discovery Schedule belonging to a Partition
  /// </summary>
  [DataContract]
  public class AccountDiscoverySchedule {
    /// <summary>
    /// Name of this schedule
    /// </summary>
    /// <value>Name of this schedule</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// The asset partition this change schedule is applied to
    /// </summary>
    /// <value>The asset partition this change schedule is applied to</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of the asset partition this change schedule is applied to (Read-only)
    /// </summary>
    /// <value>Name of the asset partition this change schedule is applied to (Read-only)</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// Gets or Sets DiscoveryType
    /// </summary>
    [DataMember(Name="DiscoveryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveryType")]
    public AccountDiscoveryScheduleType DiscoveryType { get; set; }

    /// <summary>
    /// The ID of the directory this schedule applies to if it has a Directory discovery type
    /// </summary>
    /// <value>The ID of the directory this schedule applies to if it has a Directory discovery type</value>
    [DataMember(Name="DirectoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryId")]
    public int? DirectoryId { get; set; }

    /// <summary>
    /// The name of the directory this schedule applies to if it has a Directory discovery type (Read-only)
    /// </summary>
    /// <value>The name of the directory this schedule applies to if it has a Directory discovery type (Read-only)</value>
    [DataMember(Name="DirectoryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryName")]
    public string DirectoryName { get; set; }

    /// <summary>
    /// Number of assets assigned to this discovery schedule (Read-only)
    /// </summary>
    /// <value>Number of assets assigned to this discovery schedule (Read-only)</value>
    [DataMember(Name="AssetsCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetsCount")]
    public int? AssetsCount { get; set; }

    /// <summary>
    /// Gets or Sets ScheduleDiscoverServices
    /// </summary>
    [DataMember(Name="ScheduleDiscoverServices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduleDiscoverServices")]
    public bool? ScheduleDiscoverServices { get; set; }

    /// <summary>
    /// Gets or Sets AutoConfigureDependentSystems
    /// </summary>
    [DataMember(Name="AutoConfigureDependentSystems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AutoConfigureDependentSystems")]
    public bool? AutoConfigureDependentSystems { get; set; }

    /// <summary>
    /// Gets or Sets AccountDiscoveryRules
    /// </summary>
    [DataMember(Name="AccountDiscoveryRules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDiscoveryRules")]
    public List<AccountDiscoveryRule> AccountDiscoveryRules { get; set; }

    /// <summary>
    /// Database ID of the schedule (Read-only)
    /// </summary>
    /// <value>Database ID of the schedule (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Description of this schedule
    /// </summary>
    /// <value>Description of this schedule</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

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
    /// Gets or Sets ScheduleType
    /// </summary>
    [DataMember(Name="ScheduleType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduleType")]
    public ScheduleType ScheduleType { get; set; }

    /// <summary>
    /// The timezone in which the schedule should run. Required when ScheduleType is not Never.
    /// </summary>
    /// <value>The timezone in which the schedule should run. Required when ScheduleType is not Never.</value>
    [DataMember(Name="TimeZoneId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeZoneId")]
    public string TimeZoneId { get; set; }

    /// <summary>
    /// The description of the timezone in which the schedule should run (Read-only)
    /// </summary>
    /// <value>The description of the timezone in which the schedule should run (Read-only)</value>
    [DataMember(Name="TimeZoneDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeZoneDisplayName")]
    public string TimeZoneDisplayName { get; set; }

    /// <summary>
    /// How frequently to run. Units are based on ScheduleType.   e.g. every 2 days, every 3 months, every 4 weeks
    /// </summary>
    /// <value>How frequently to run. Units are based on ScheduleType.   e.g. every 2 days, every 3 months, every 4 weeks</value>
    [DataMember(Name="RepeatInterval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RepeatInterval")]
    public int? RepeatInterval { get; set; }

    /// <summary>
    /// Gets or Sets RepeatMonthlyScheduleType
    /// </summary>
    [DataMember(Name="RepeatMonthlyScheduleType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RepeatMonthlyScheduleType")]
    public MonthlyScheduleType RepeatMonthlyScheduleType { get; set; }

    /// <summary>
    /// Gets or Sets RepeatWeekOfMonth
    /// </summary>
    [DataMember(Name="RepeatWeekOfMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RepeatWeekOfMonth")]
    public WeekOfMonth RepeatWeekOfMonth { get; set; }

    /// <summary>
    /// Gets or Sets RepeatDayOfWeek
    /// </summary>
    [DataMember(Name="RepeatDayOfWeek", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RepeatDayOfWeek")]
    public DayOfWeek RepeatDayOfWeek { get; set; }

    /// <summary>
    /// Which day of the month the schedule should run. Only valid when RepeatMonthlyScheduleType is DayOfMonth
    /// </summary>
    /// <value>Which day of the month the schedule should run. Only valid when RepeatMonthlyScheduleType is DayOfMonth</value>
    [DataMember(Name="RepeatDayOfMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RepeatDayOfMonth")]
    public int? RepeatDayOfMonth { get; set; }

    /// <summary>
    /// Which days of the week the schedule should run. Only valid when ScheduleType is Weekly
    /// </summary>
    /// <value>Which days of the week the schedule should run. Only valid when ScheduleType is Weekly</value>
    [DataMember(Name="RepeatDaysOfWeek", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RepeatDaysOfWeek")]
    public List<DayOfWeek> RepeatDaysOfWeek { get; set; }

    /// <summary>
    /// Gets or Sets TimeOfDayType
    /// </summary>
    [DataMember(Name="TimeOfDayType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeOfDayType")]
    public TimeOfDayType TimeOfDayType { get; set; }

    /// <summary>
    /// The hour of the day that the schedule will run (not applicable for 'Hour' or 'Minute' schedule type)
    /// </summary>
    /// <value>The hour of the day that the schedule will run (not applicable for 'Hour' or 'Minute' schedule type)</value>
    [DataMember(Name="StartHour", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartHour")]
    public int? StartHour { get; set; }

    /// <summary>
    /// The minute of the hour of the day that the schedule will run (not applicable for 'Minute' schedule type)
    /// </summary>
    /// <value>The minute of the hour of the day that the schedule will run (not applicable for 'Minute' schedule type)</value>
    [DataMember(Name="StartMinute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartMinute")]
    public int? StartMinute { get; set; }

    /// <summary>
    /// Configuration of intervals of time in a day where tasks can be executed.
    /// </summary>
    /// <value>Configuration of intervals of time in a day where tasks can be executed.</value>
    [DataMember(Name="TimeOfDayIntervals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeOfDayIntervals")]
    public List<ScheduleInterval> TimeOfDayIntervals { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountDiscoverySchedule {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  DiscoveryType: ").Append(DiscoveryType).Append("\n");
      sb.Append("  DirectoryId: ").Append(DirectoryId).Append("\n");
      sb.Append("  DirectoryName: ").Append(DirectoryName).Append("\n");
      sb.Append("  AssetsCount: ").Append(AssetsCount).Append("\n");
      sb.Append("  ScheduleDiscoverServices: ").Append(ScheduleDiscoverServices).Append("\n");
      sb.Append("  AutoConfigureDependentSystems: ").Append(AutoConfigureDependentSystems).Append("\n");
      sb.Append("  AccountDiscoveryRules: ").Append(AccountDiscoveryRules).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
      sb.Append("  ScheduleType: ").Append(ScheduleType).Append("\n");
      sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
      sb.Append("  TimeZoneDisplayName: ").Append(TimeZoneDisplayName).Append("\n");
      sb.Append("  RepeatInterval: ").Append(RepeatInterval).Append("\n");
      sb.Append("  RepeatMonthlyScheduleType: ").Append(RepeatMonthlyScheduleType).Append("\n");
      sb.Append("  RepeatWeekOfMonth: ").Append(RepeatWeekOfMonth).Append("\n");
      sb.Append("  RepeatDayOfWeek: ").Append(RepeatDayOfWeek).Append("\n");
      sb.Append("  RepeatDayOfMonth: ").Append(RepeatDayOfMonth).Append("\n");
      sb.Append("  RepeatDaysOfWeek: ").Append(RepeatDaysOfWeek).Append("\n");
      sb.Append("  TimeOfDayType: ").Append(TimeOfDayType).Append("\n");
      sb.Append("  StartHour: ").Append(StartHour).Append("\n");
      sb.Append("  StartMinute: ").Append(StartMinute).Append("\n");
      sb.Append("  TimeOfDayIntervals: ").Append(TimeOfDayIntervals).Append("\n");
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
