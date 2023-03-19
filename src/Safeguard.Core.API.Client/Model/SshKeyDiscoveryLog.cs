using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a task that may run on a remote machine
  /// </summary>
  [DataContract]
  public class SshKeyDiscoveryLog {
    /// <summary>
    /// ID of the task (Read-only)
    /// </summary>
    /// <value>ID of the task (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// The date the task was created
    /// </summary>
    /// <value>The date the task was created</value>
    [DataMember(Name="LogTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LogTime")]
    public DateTime? LogTime { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public TaskNames Name { get; set; }

    /// <summary>
    /// Gets or Sets EventName
    /// </summary>
    [DataMember(Name="EventName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EventName")]
    public EventName EventName { get; set; }

    /// <summary>
    /// Display Name of the event (Read-only)
    /// </summary>
    /// <value>Display Name of the event (Read-only)</value>
    [DataMember(Name="EventDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EventDisplayName")]
    public string EventDisplayName { get; set; }

    /// <summary>
    /// Database ID of the asset or directory to execute this task on
    /// </summary>
    /// <value>Database ID of the asset or directory to execute this task on</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Name of the asset or directory name the task was executed against (Read-only)
    /// </summary>
    /// <value>Name of the asset or directory name the task was executed against (Read-only)</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// The database ID of the platform of the asset.
    /// </summary>
    /// <value>The database ID of the platform of the asset.</value>
    [DataMember(Name="PlatformId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformId")]
    public int? PlatformId { get; set; }

    /// <summary>
    /// Gets or Sets PlatformType
    /// </summary>
    [DataMember(Name="PlatformType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformType")]
    public PlatformType PlatformType { get; set; }

    /// <summary>
    /// Display Name of the platform of the asset (Read-only)
    /// </summary>
    /// <value>Display Name of the platform of the asset (Read-only)</value>
    [DataMember(Name="PlatformDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformDisplayName")]
    public string PlatformDisplayName { get; set; }

    /// <summary>
    /// Whether this is a directory platform (Read-only)
    /// </summary>
    /// <value>Whether this is a directory platform (Read-only)</value>
    [DataMember(Name="IsDirectory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsDirectory")]
    public bool? IsDirectory { get; set; }

    /// <summary>
    /// Network DNS name or IP address used to connect to the machine over the network.
    /// </summary>
    /// <value>Network DNS name or IP address used to connect to the machine over the network.</value>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

    /// <summary>
    /// Account to run this task for
    /// </summary>
    /// <value>Account to run this task for</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Name of the account this task is for (Read-only)
    /// </summary>
    /// <value>Name of the account this task is for (Read-only)</value>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Domain name the account is from (Read-only)
    /// </summary>
    /// <value>Domain name the account is from (Read-only)</value>
    [DataMember(Name="AccountDomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDomainName")]
    public string AccountDomainName { get; set; }

    /// <summary>
    /// Netbios name of the domain of the account (Read-only)
    /// </summary>
    /// <value>Netbios name of the domain of the account (Read-only)</value>
    [DataMember(Name="AccountNetBiosName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountNetBiosName")]
    public string AccountNetBiosName { get; set; }

    /// <summary>
    /// Distinguished name of the account (Read-only)
    /// </summary>
    /// <value>Distinguished name of the account (Read-only)</value>
    [DataMember(Name="AccountDistinguishedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDistinguishedName")]
    public string AccountDistinguishedName { get; set; }

    /// <summary>
    /// The database ID of the asset partition this account belongs to (Read-only)
    /// </summary>
    /// <value>The database ID of the asset partition this account belongs to (Read-only)</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of the asset partition this account belongs to (Read-only)
    /// </summary>
    /// <value>Name of the asset partition this account belongs to (Read-only)</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// The database ID of the profile explicitly set on this account or inherited from the AssetPartition this asaccountset belongs to (Read-only)
    /// </summary>
    /// <value>The database ID of the profile explicitly set on this account or inherited from the AssetPartition this asaccountset belongs to (Read-only)</value>
    [DataMember(Name="ProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProfileId")]
    public int? ProfileId { get; set; }

    /// <summary>
    /// Name of the profile explicitly set on this account or inherited from the AssetPartition this account belongs to (Read-only)
    /// </summary>
    /// <value>Name of the profile explicitly set on this account or inherited from the AssetPartition this account belongs to (Read-only)</value>
    [DataMember(Name="ProfileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProfileName")]
    public string ProfileName { get; set; }

    /// <summary>
    /// The database ID of the SSH key profile explicitly set on this account or inherited from the AssetPartition this account belongs to (Read-only)
    /// </summary>
    /// <value>The database ID of the SSH key profile explicitly set on this account or inherited from the AssetPartition this account belongs to (Read-only)</value>
    [DataMember(Name="SshKeyProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyProfileId")]
    public int? SshKeyProfileId { get; set; }

    /// <summary>
    /// Name of the SSH key profile explicitly set on this account or inherited from the AssetPartition this account belongs to (Read-only)
    /// </summary>
    /// <value>Name of the SSH key profile explicitly set on this account or inherited from the AssetPartition this account belongs to (Read-only)</value>
    [DataMember(Name="SshKeyProfileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyProfileName")]
    public string SshKeyProfileName { get; set; }

    /// <summary>
    /// ID of the user that requested the task (Read-only)
    /// </summary>
    /// <value>ID of the user that requested the task (Read-only)</value>
    [DataMember(Name="UserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserId")]
    public int? UserId { get; set; }

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
    /// Gets or Sets RequestStatus
    /// </summary>
    [DataMember(Name="RequestStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestStatus")]
    public RequestStatus RequestStatus { get; set; }

    /// <summary>
    /// Detailed log of task execution. Only populated in results from the Tasks resource (Read-only)
    /// </summary>
    /// <value>Detailed log of task execution. Only populated in results from the Tasks resource (Read-only)</value>
    [DataMember(Name="Log", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Log")]
    public List<TaskLog> Log { get; set; }

    /// <summary>
    /// Gets or Sets ConnectionProperties
    /// </summary>
    [DataMember(Name="ConnectionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConnectionProperties")]
    public AssetConnectionProperties ConnectionProperties { get; set; }

    /// <summary>
    /// Gets or Sets UserProperties
    /// </summary>
    [DataMember(Name="UserProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserProperties")]
    public UserLogProperties UserProperties { get; set; }

    /// <summary>
    /// Accounts discovered by this task
    /// </summary>
    /// <value>Accounts discovered by this task</value>
    [DataMember(Name="DiscoveredSshKeys", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredSshKeys")]
    public List<DiscoveredSshKeyLog> DiscoveredSshKeys { get; set; }

    /// <summary>
    /// Set of parameters passed to custom platform script
    /// </summary>
    /// <value>Set of parameters passed to custom platform script</value>
    [DataMember(Name="CustomScriptParameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomScriptParameters")]
    public List<TaskCustomScriptParameter> CustomScriptParameters { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SshKeyDiscoveryLog {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LogTime: ").Append(LogTime).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  EventName: ").Append(EventName).Append("\n");
      sb.Append("  EventDisplayName: ").Append(EventDisplayName).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
      sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
      sb.Append("  PlatformDisplayName: ").Append(PlatformDisplayName).Append("\n");
      sb.Append("  IsDirectory: ").Append(IsDirectory).Append("\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
      sb.Append("  AccountNetBiosName: ").Append(AccountNetBiosName).Append("\n");
      sb.Append("  AccountDistinguishedName: ").Append(AccountDistinguishedName).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
      sb.Append("  ProfileName: ").Append(ProfileName).Append("\n");
      sb.Append("  SshKeyProfileId: ").Append(SshKeyProfileId).Append("\n");
      sb.Append("  SshKeyProfileName: ").Append(SshKeyProfileName).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
      sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
      sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
      sb.Append("  Log: ").Append(Log).Append("\n");
      sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
      sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
      sb.Append("  DiscoveredSshKeys: ").Append(DiscoveredSshKeys).Append("\n");
      sb.Append("  CustomScriptParameters: ").Append(CustomScriptParameters).Append("\n");
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
