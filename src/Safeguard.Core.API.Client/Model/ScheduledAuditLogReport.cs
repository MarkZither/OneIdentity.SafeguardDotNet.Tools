using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ScheduledAuditLogReport {
    /// <summary>
    /// Database ID of the search (Read-only)
    /// </summary>
    /// <value>Database ID of the search (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of this search
    /// </summary>
    /// <value>Name of this search</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of this search
    /// </summary>
    /// <value>Description of this search</value>
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
    /// Gets or Sets SerializationFormat
    /// </summary>
    [DataMember(Name="SerializationFormat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SerializationFormat")]
    public SupportedReportDataSerializationFormat SerializationFormat { get; set; }

    /// <summary>
    /// Gets or Sets CategoryOption
    /// </summary>
    [DataMember(Name="CategoryOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CategoryOption")]
    public AuditLogCategory CategoryOption { get; set; }

    /// <summary>
    /// Gets or Sets DateRangeType
    /// </summary>
    [DataMember(Name="DateRangeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DateRangeType")]
    public DateRangeType DateRangeType { get; set; }

    /// <summary>
    /// Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over filter)
    /// </summary>
    /// <value>Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over filter)</value>
    [DataMember(Name="StartDateOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartDateOption")]
    public DateTime? StartDateOption { get; set; }

    /// <summary>
    /// Get activity that occurred before this date. Defaults to now. (Preferred over filter)
    /// </summary>
    /// <value>Get activity that occurred before this date. Defaults to now. (Preferred over filter)</value>
    [DataMember(Name="EndDateOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndDateOption")]
    public DateTime? EndDateOption { get; set; }

    /// <summary>
    /// Get activity that occurred for a specific user (Preferred over filter)
    /// </summary>
    /// <value>Get activity that occurred for a specific user (Preferred over filter)</value>
    [DataMember(Name="UserIdOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserIdOption")]
    public int? UserIdOption { get; set; }

    /// <summary>
    /// Display name for user ID option
    /// </summary>
    /// <value>Display name for user ID option</value>
    [DataMember(Name="UserIdOptionDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserIdOptionDisplayName")]
    public string UserIdOptionDisplayName { get; set; }

    /// <summary>
    /// Get activity that occurred for a specific asset (Preferred over filter)
    /// </summary>
    /// <value>Get activity that occurred for a specific asset (Preferred over filter)</value>
    [DataMember(Name="AssetIdOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetIdOption")]
    public int? AssetIdOption { get; set; }

    /// <summary>
    /// Display name for asset ID option
    /// </summary>
    /// <value>Display name for asset ID option</value>
    [DataMember(Name="AssetIdOptionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetIdOptionName")]
    public string AssetIdOptionName { get; set; }

    /// <summary>
    /// Get activity that occurred for a specific account (Preferred over filter)
    /// </summary>
    /// <value>Get activity that occurred for a specific account (Preferred over filter)</value>
    [DataMember(Name="AccountIdOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountIdOption")]
    public int? AccountIdOption { get; set; }

    /// <summary>
    /// Display name for account ID option
    /// </summary>
    /// <value>Display name for account ID option</value>
    [DataMember(Name="AccountIdOptionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountIdOptionName")]
    public string AccountIdOptionName { get; set; }

    /// <summary>
    /// Report all activity details as opposed to a summary view. Only valid when CategoryOption is specified.
    /// </summary>
    /// <value>Report all activity details as opposed to a summary view. Only valid when CategoryOption is specified.</value>
    [DataMember(Name="IncludeDetailsOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IncludeDetailsOption")]
    public bool? IncludeDetailsOption { get; set; }

    /// <summary>
    /// Filter results. Only V3 DTO properties are supported. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()
    /// </summary>
    /// <value>Filter results. Only V3 DTO properties are supported. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</value>
    [DataMember(Name="FilterOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FilterOption")]
    public string FilterOption { get; set; }

    /// <summary>
    /// Which page (starting with 0) of data to return
    /// </summary>
    /// <value>Which page (starting with 0) of data to return</value>
    [DataMember(Name="PageOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PageOption")]
    public int? PageOption { get; set; }

    /// <summary>
    /// The size of a page of data
    /// </summary>
    /// <value>The size of a page of data</value>
    [DataMember(Name="LimitOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LimitOption")]
    public int? LimitOption { get; set; }

    /// <summary>
    /// When specified, the method will return a single integer value representing the total number of items that match the given filter criteria.   If specified, the fields and orderby parameter values are ignored.
    /// </summary>
    /// <value>When specified, the method will return a single integer value representing the total number of items that match the given filter criteria.   If specified, the fields and orderby parameter values are ignored.</value>
    [DataMember(Name="CountOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountOption")]
    public bool? CountOption { get; set; }

    /// <summary>
    /// List of property names (comma-separated) to include in entity output. Only V3 DTO properties are supported.
    /// </summary>
    /// <value>List of property names (comma-separated) to include in entity output. Only V3 DTO properties are supported.</value>
    [DataMember(Name="FieldsOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FieldsOption")]
    public string FieldsOption { get; set; }

    /// <summary>
    /// List of property names (comma-separated) to sort entities by. Only V3 DTO properties are supported. Prepend properties with - for descending.
    /// </summary>
    /// <value>List of property names (comma-separated) to sort entities by. Only V3 DTO properties are supported. Prepend properties with - for descending.</value>
    [DataMember(Name="OrderbyOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OrderbyOption")]
    public string OrderbyOption { get; set; }

    /// <summary>
    /// Search all string fields for the specified value
    /// </summary>
    /// <value>Search all string fields for the specified value</value>
    [DataMember(Name="QueryStringOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueryStringOption")]
    public string QueryStringOption { get; set; }

    /// <summary>
    /// The last time this report was executed
    /// </summary>
    /// <value>The last time this report was executed</value>
    [DataMember(Name="LastScheduledExecution", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastScheduledExecution")]
    public DateTime? LastScheduledExecution { get; set; }

    /// <summary>
    /// The next time this report will be executed
    /// </summary>
    /// <value>The next time this report will be executed</value>
    [DataMember(Name="NextScheduledExecution", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextScheduledExecution")]
    public DateTime? NextScheduledExecution { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScheduledAuditLogReport {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
      sb.Append("  SerializationFormat: ").Append(SerializationFormat).Append("\n");
      sb.Append("  CategoryOption: ").Append(CategoryOption).Append("\n");
      sb.Append("  DateRangeType: ").Append(DateRangeType).Append("\n");
      sb.Append("  StartDateOption: ").Append(StartDateOption).Append("\n");
      sb.Append("  EndDateOption: ").Append(EndDateOption).Append("\n");
      sb.Append("  UserIdOption: ").Append(UserIdOption).Append("\n");
      sb.Append("  UserIdOptionDisplayName: ").Append(UserIdOptionDisplayName).Append("\n");
      sb.Append("  AssetIdOption: ").Append(AssetIdOption).Append("\n");
      sb.Append("  AssetIdOptionName: ").Append(AssetIdOptionName).Append("\n");
      sb.Append("  AccountIdOption: ").Append(AccountIdOption).Append("\n");
      sb.Append("  AccountIdOptionName: ").Append(AccountIdOptionName).Append("\n");
      sb.Append("  IncludeDetailsOption: ").Append(IncludeDetailsOption).Append("\n");
      sb.Append("  FilterOption: ").Append(FilterOption).Append("\n");
      sb.Append("  PageOption: ").Append(PageOption).Append("\n");
      sb.Append("  LimitOption: ").Append(LimitOption).Append("\n");
      sb.Append("  CountOption: ").Append(CountOption).Append("\n");
      sb.Append("  FieldsOption: ").Append(FieldsOption).Append("\n");
      sb.Append("  OrderbyOption: ").Append(OrderbyOption).Append("\n");
      sb.Append("  QueryStringOption: ").Append(QueryStringOption).Append("\n");
      sb.Append("  LastScheduledExecution: ").Append(LastScheduledExecution).Append("\n");
      sb.Append("  NextScheduledExecution: ").Append(NextScheduledExecution).Append("\n");
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
