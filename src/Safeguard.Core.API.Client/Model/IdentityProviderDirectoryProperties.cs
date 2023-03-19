using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Configuration settings for when the TypeReferenceName property is &#x27;ActiveDirectory&#x27; or &#x27;Ldap&#x27;
  /// </summary>
  [DataContract]
  public class IdentityProviderDirectoryProperties {
    /// <summary>
    /// The name of the forest root domain (Read-only)
    /// </summary>
    /// <value>The name of the forest root domain (Read-only)</value>
    [DataMember(Name="ForestRootDomain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ForestRootDomain")]
    public string ForestRootDomain { get; set; }

    /// <summary>
    /// How frequently data imported from this direcory should be synchronized with changes made in AD (in minutes)
    /// </summary>
    /// <value>How frequently data imported from this direcory should be synchronized with changes made in AD (in minutes)</value>
    [DataMember(Name="SynchronizationIntervalMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SynchronizationIntervalMinutes")]
    public int? SynchronizationIntervalMinutes { get; set; }

    /// <summary>
    /// The time this directory was last synchronized and account discovery was run (Read-only)
    /// </summary>
    /// <value>The time this directory was last synchronized and account discovery was run (Read-only)</value>
    [DataMember(Name="LastSynchronizedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSynchronizedDate")]
    public DateTime? LastSynchronizedDate { get; set; }

    /// <summary>
    /// The next time this directory will synchronize and run account discovery (Read-only)
    /// </summary>
    /// <value>The next time this directory will synchronize and run account discovery (Read-only)</value>
    [DataMember(Name="NextSynchronizedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextSynchronizedDate")]
    public DateTime? NextSynchronizedDate { get; set; }

    /// <summary>
    /// How frequently this directory should be checked for deleted objects in AD (in minutes)
    /// </summary>
    /// <value>How frequently this directory should be checked for deleted objects in AD (in minutes)</value>
    [DataMember(Name="DeleteSyncIntervalMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeleteSyncIntervalMinutes")]
    public int? DeleteSyncIntervalMinutes { get; set; }

    /// <summary>
    /// The last time the directory was last checked for deleted objects (Read-only)
    /// </summary>
    /// <value>The last time the directory was last checked for deleted objects (Read-only)</value>
    [DataMember(Name="LastDeleteSyncDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastDeleteSyncDate")]
    public DateTime? LastDeleteSyncDate { get; set; }

    /// <summary>
    /// The time this directory will synchronize deletions (Read-only)
    /// </summary>
    /// <value>The time this directory will synchronize deletions (Read-only)</value>
    [DataMember(Name="NextDeleteSyncDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextDeleteSyncDate")]
    public DateTime? NextDeleteSyncDate { get; set; }

    /// <summary>
    /// The time this directory was last successfully synchronized (Read-only)
    /// </summary>
    /// <value>The time this directory was last successfully synchronized (Read-only)</value>
    [DataMember(Name="LastSuccessSynchronizedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessSynchronizedDate")]
    public DateTime? LastSuccessSynchronizedDate { get; set; }

    /// <summary>
    /// The time this directory last failed to synchronize (Read-only)
    /// </summary>
    /// <value>The time this directory last failed to synchronize (Read-only)</value>
    [DataMember(Name="LastFailureSynchronizedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureSynchronizedDate")]
    public DateTime? LastFailureSynchronizedDate { get; set; }

    /// <summary>
    /// Number of subsequent failed sync attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed sync attempts since last success (Read-only)</value>
    [DataMember(Name="FailedSyncAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedSyncAttempts")]
    public int? FailedSyncAttempts { get; set; }

    /// <summary>
    /// The time this directory was last successfully synchronized deletions (Read-only)
    /// </summary>
    /// <value>The time this directory was last successfully synchronized deletions (Read-only)</value>
    [DataMember(Name="LastSuccessDeleteSyncDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessDeleteSyncDate")]
    public DateTime? LastSuccessDeleteSyncDate { get; set; }

    /// <summary>
    /// The time this directory last failed to synchronize deletions (Read-only)
    /// </summary>
    /// <value>The time this directory last failed to synchronize deletions (Read-only)</value>
    [DataMember(Name="LastFailureDeleteSyncDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureDeleteSyncDate")]
    public DateTime? LastFailureDeleteSyncDate { get; set; }

    /// <summary>
    /// Number of subsequent failed delete sync attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed delete sync attempts since last success (Read-only)</value>
    [DataMember(Name="FailedDeleteSyncAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedDeleteSyncAttempts")]
    public int? FailedDeleteSyncAttempts { get; set; }

    /// <summary>
    /// List of available domains that can be search from IdentityProviders representing a directory (Read-only)
    /// </summary>
    /// <value>List of available domains that can be search from IdentityProviders representing a directory (Read-only)</value>
    [DataMember(Name="Domains", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Domains")]
    public List<DomainInfo> Domains { get; set; }

    /// <summary>
    /// List of available domain controllers. If this list is empty then DNS will be used instead.
    /// </summary>
    /// <value>List of available domain controllers. If this list is empty then DNS will be used instead.</value>
    [DataMember(Name="DomainControllers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainControllers")]
    public List<DomainController> DomainControllers { get; set; }

    /// <summary>
    /// Gets or Sets SchemaProperties
    /// </summary>
    [DataMember(Name="SchemaProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SchemaProperties")]
    public IdentityProviderLdapSchema SchemaProperties { get; set; }

    /// <summary>
    /// Gets or Sets ConnectionProperties
    /// </summary>
    [DataMember(Name="ConnectionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConnectionProperties")]
    public DirectoryConnectionProperties ConnectionProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentityProviderDirectoryProperties {\n");
      sb.Append("  ForestRootDomain: ").Append(ForestRootDomain).Append("\n");
      sb.Append("  SynchronizationIntervalMinutes: ").Append(SynchronizationIntervalMinutes).Append("\n");
      sb.Append("  LastSynchronizedDate: ").Append(LastSynchronizedDate).Append("\n");
      sb.Append("  NextSynchronizedDate: ").Append(NextSynchronizedDate).Append("\n");
      sb.Append("  DeleteSyncIntervalMinutes: ").Append(DeleteSyncIntervalMinutes).Append("\n");
      sb.Append("  LastDeleteSyncDate: ").Append(LastDeleteSyncDate).Append("\n");
      sb.Append("  NextDeleteSyncDate: ").Append(NextDeleteSyncDate).Append("\n");
      sb.Append("  LastSuccessSynchronizedDate: ").Append(LastSuccessSynchronizedDate).Append("\n");
      sb.Append("  LastFailureSynchronizedDate: ").Append(LastFailureSynchronizedDate).Append("\n");
      sb.Append("  FailedSyncAttempts: ").Append(FailedSyncAttempts).Append("\n");
      sb.Append("  LastSuccessDeleteSyncDate: ").Append(LastSuccessDeleteSyncDate).Append("\n");
      sb.Append("  LastFailureDeleteSyncDate: ").Append(LastFailureDeleteSyncDate).Append("\n");
      sb.Append("  FailedDeleteSyncAttempts: ").Append(FailedDeleteSyncAttempts).Append("\n");
      sb.Append("  Domains: ").Append(Domains).Append("\n");
      sb.Append("  DomainControllers: ").Append(DomainControllers).Append("\n");
      sb.Append("  SchemaProperties: ").Append(SchemaProperties).Append("\n");
      sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
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
