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
  public class UserLogProperties {
    /// <summary>
    /// IP address of the user client that caused the change (Read-only).
    /// </summary>
    /// <value>IP address of the user client that caused the change (Read-only).</value>
    [DataMember(Name="ClientIpAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClientIpAddress")]
    public string ClientIpAddress { get; set; }

    /// <summary>
    /// UserName of the user that caused the change (Read-only).
    /// </summary>
    /// <value>UserName of the user that caused the change (Read-only).</value>
    [DataMember(Name="UserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserName")]
    public string UserName { get; set; }

    /// <summary>
    /// Domain name of the user that caused the change (Read-only).
    /// </summary>
    /// <value>Domain name of the user that caused the change (Read-only).</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// DisplayName of the user that caused the change (Read-only).
    /// </summary>
    /// <value>DisplayName of the user that caused the change (Read-only).</value>
    [DataMember(Name="UserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserDisplayName")]
    public string UserDisplayName { get; set; }

    /// <summary>
    /// Was the user in the GlobalAdmin role at the time of the change? (Read-only).
    /// </summary>
    /// <value>Was the user in the GlobalAdmin role at the time of the change? (Read-only).</value>
    [DataMember(Name="UserWasGlobalAdmin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserWasGlobalAdmin")]
    public bool? UserWasGlobalAdmin { get; set; }

    /// <summary>
    /// Was the user in the DirectoryAdmin role at the time of the change? (Read-only).
    /// </summary>
    /// <value>Was the user in the DirectoryAdmin role at the time of the change? (Read-only).</value>
    [DataMember(Name="UserWasDirectoryAdmin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserWasDirectoryAdmin")]
    public bool? UserWasDirectoryAdmin { get; set; }

    /// <summary>
    /// Was the user in the Auditor role at the time of the change? (Read-only).
    /// </summary>
    /// <value>Was the user in the Auditor role at the time of the change? (Read-only).</value>
    [DataMember(Name="UserWasAuditor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserWasAuditor")]
    public bool? UserWasAuditor { get; set; }

    /// <summary>
    /// Was the user in the ApplicationAuditor role at the time of the change? (Read-only).
    /// </summary>
    /// <value>Was the user in the ApplicationAuditor role at the time of the change? (Read-only).</value>
    [DataMember(Name="UserWasApplicationAuditor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserWasApplicationAuditor")]
    public bool? UserWasApplicationAuditor { get; set; }

    /// <summary>
    /// Was the user in the SystemAuditor role at the time of the change? (Read-only).
    /// </summary>
    /// <value>Was the user in the SystemAuditor role at the time of the change? (Read-only).</value>
    [DataMember(Name="UserWasSystemAuditor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserWasSystemAuditor")]
    public bool? UserWasSystemAuditor { get; set; }

    /// <summary>
    /// Was the user in the AssetAdmin role at the time of the change? (Read-only).
    /// </summary>
    /// <value>Was the user in the AssetAdmin role at the time of the change? (Read-only).</value>
    [DataMember(Name="UserWasAssetAdmin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserWasAssetAdmin")]
    public bool? UserWasAssetAdmin { get; set; }

    /// <summary>
    /// Was the user a partition owner at the time of the change? (Read-only).
    /// </summary>
    /// <value>Was the user a partition owner at the time of the change? (Read-only).</value>
    [DataMember(Name="UserWasPartitionOwner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserWasPartitionOwner")]
    public bool? UserWasPartitionOwner { get; set; }

    /// <summary>
    /// Was the user in the ApplianceAdmin role at the time of the change? (Read-only).
    /// </summary>
    /// <value>Was the user in the ApplianceAdmin role at the time of the change? (Read-only).</value>
    [DataMember(Name="UserWasApplianceAdmin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserWasApplianceAdmin")]
    public bool? UserWasApplianceAdmin { get; set; }

    /// <summary>
    /// Was the user in the PolicyAdmin role at the time of the change? (Read-only).
    /// </summary>
    /// <value>Was the user in the PolicyAdmin role at the time of the change? (Read-only).</value>
    [DataMember(Name="UserWasPolicyAdmin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserWasPolicyAdmin")]
    public bool? UserWasPolicyAdmin { get; set; }

    /// <summary>
    /// Was the user in the UserAdmin role at the time of the change? (Read-only).
    /// </summary>
    /// <value>Was the user in the UserAdmin role at the time of the change? (Read-only).</value>
    [DataMember(Name="UserWasUserAdmin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserWasUserAdmin")]
    public bool? UserWasUserAdmin { get; set; }

    /// <summary>
    /// Was the user in the HelpdeskAdmin role at the time of the change? (Read-only).
    /// </summary>
    /// <value>Was the user in the HelpdeskAdmin role at the time of the change? (Read-only).</value>
    [DataMember(Name="UserWasHelpdeskAdmin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserWasHelpdeskAdmin")]
    public bool? UserWasHelpdeskAdmin { get; set; }

    /// <summary>
    /// Was the user in the OperationsAdmin role at the time of the change? (Read-only).
    /// </summary>
    /// <value>Was the user in the OperationsAdmin role at the time of the change? (Read-only).</value>
    [DataMember(Name="UserWasOperationsAdmin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserWasOperationsAdmin")]
    public bool? UserWasOperationsAdmin { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserLogProperties {\n");
      sb.Append("  ClientIpAddress: ").Append(ClientIpAddress).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  UserDisplayName: ").Append(UserDisplayName).Append("\n");
      sb.Append("  UserWasGlobalAdmin: ").Append(UserWasGlobalAdmin).Append("\n");
      sb.Append("  UserWasDirectoryAdmin: ").Append(UserWasDirectoryAdmin).Append("\n");
      sb.Append("  UserWasAuditor: ").Append(UserWasAuditor).Append("\n");
      sb.Append("  UserWasApplicationAuditor: ").Append(UserWasApplicationAuditor).Append("\n");
      sb.Append("  UserWasSystemAuditor: ").Append(UserWasSystemAuditor).Append("\n");
      sb.Append("  UserWasAssetAdmin: ").Append(UserWasAssetAdmin).Append("\n");
      sb.Append("  UserWasPartitionOwner: ").Append(UserWasPartitionOwner).Append("\n");
      sb.Append("  UserWasApplianceAdmin: ").Append(UserWasApplianceAdmin).Append("\n");
      sb.Append("  UserWasPolicyAdmin: ").Append(UserWasPolicyAdmin).Append("\n");
      sb.Append("  UserWasUserAdmin: ").Append(UserWasUserAdmin).Append("\n");
      sb.Append("  UserWasHelpdeskAdmin: ").Append(UserWasHelpdeskAdmin).Append("\n");
      sb.Append("  UserWasOperationsAdmin: ").Append(UserWasOperationsAdmin).Append("\n");
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
