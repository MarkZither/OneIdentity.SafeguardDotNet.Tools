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
  public class NodeHealth {
    /// <summary>
    /// Unique hardware-specific identifier of this node
    /// </summary>
    /// <value>Unique hardware-specific identifier of this node</value>
    [DataMember(Name="ApplianceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceId")]
    public string ApplianceId { get; set; }

    /// <summary>
    /// Gets or Sets AuditLog
    /// </summary>
    [DataMember(Name="AuditLog", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuditLog")]
    public HealthDetail AuditLog { get; set; }

    /// <summary>
    /// The UTC date/time of this health check
    /// </summary>
    /// <value>The UTC date/time of this health check</value>
    [DataMember(Name="CheckDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CheckDate")]
    public DateTime? CheckDate { get; set; }

    /// <summary>
    /// Gets or Sets CheckDuration
    /// </summary>
    [DataMember(Name="CheckDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CheckDuration")]
    public TimeInterval CheckDuration { get; set; }

    /// <summary>
    /// Gets or Sets ClusterCommunication
    /// </summary>
    [DataMember(Name="ClusterCommunication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClusterCommunication")]
    public HealthDetail ClusterCommunication { get; set; }

    /// <summary>
    /// Gets or Sets ClusterConnectivity
    /// </summary>
    [DataMember(Name="ClusterConnectivity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClusterConnectivity")]
    public ClusterConnectivityHealthDetail ClusterConnectivity { get; set; }

    /// <summary>
    /// Appliance name of this node
    /// </summary>
    /// <value>Appliance name of this node</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets NetworkInformation
    /// </summary>
    [DataMember(Name="NetworkInformation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkInformation")]
    public NodeNetworkInformation NetworkInformation { get; set; }

    /// <summary>
    /// Gets or Sets AccessWorkflow
    /// </summary>
    [DataMember(Name="AccessWorkflow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessWorkflow")]
    public HealthDetail AccessWorkflow { get; set; }

    /// <summary>
    /// Gets or Sets PolicyData
    /// </summary>
    [DataMember(Name="PolicyData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyData")]
    public HealthDetail PolicyData { get; set; }

    /// <summary>
    /// Gets or Sets ResourceUsage
    /// </summary>
    [DataMember(Name="ResourceUsage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ResourceUsage")]
    public NodeResourceHealthDetail ResourceUsage { get; set; }

    /// <summary>
    /// Hardware serial number of this appliance node
    /// </summary>
    /// <value>Hardware serial number of this appliance node</value>
    [DataMember(Name="SerialNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SerialNumber")]
    public string SerialNumber { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="State", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "State")]
    public ApplianceState State { get; set; }

    /// <summary>
    /// Gets or Sets UpTime
    /// </summary>
    [DataMember(Name="UpTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpTime")]
    public TimeInterval UpTime { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="Version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Version")]
    public ProductVersion Version { get; set; }

    /// <summary>
    /// Gets or Sets SessionsModule
    /// </summary>
    [DataMember(Name="SessionsModule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionsModule")]
    public HealthDetail SessionsModule { get; set; }

    /// <summary>
    /// Gets or Sets HardwareSecurityModule
    /// </summary>
    [DataMember(Name="HardwareSecurityModule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HardwareSecurityModule")]
    public HealthDetail HardwareSecurityModule { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeHealth {\n");
      sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
      sb.Append("  AuditLog: ").Append(AuditLog).Append("\n");
      sb.Append("  CheckDate: ").Append(CheckDate).Append("\n");
      sb.Append("  CheckDuration: ").Append(CheckDuration).Append("\n");
      sb.Append("  ClusterCommunication: ").Append(ClusterCommunication).Append("\n");
      sb.Append("  ClusterConnectivity: ").Append(ClusterConnectivity).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NetworkInformation: ").Append(NetworkInformation).Append("\n");
      sb.Append("  AccessWorkflow: ").Append(AccessWorkflow).Append("\n");
      sb.Append("  PolicyData: ").Append(PolicyData).Append("\n");
      sb.Append("  ResourceUsage: ").Append(ResourceUsage).Append("\n");
      sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  UpTime: ").Append(UpTime).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  SessionsModule: ").Append(SessionsModule).Append("\n");
      sb.Append("  HardwareSecurityModule: ").Append(HardwareSecurityModule).Append("\n");
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
