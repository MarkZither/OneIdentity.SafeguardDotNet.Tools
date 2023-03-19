using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A license for the password management module.
  /// </summary>
  [DataContract]
  public class PasswordManagementLicense {
    /// <summary>
    /// Gets or Sets Model
    /// </summary>
    [DataMember(Name="Model", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Model")]
    public PasswordManagementLicenseModel Model { get; set; }

    /// <summary>
    /// The version of SPP licensed
    /// </summary>
    /// <value>The version of SPP licensed</value>
    [DataMember(Name="Version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Version")]
    public int? Version { get; set; }

    /// <summary>
    /// The maximum number of users permitted under this license.
    /// </summary>
    /// <value>The maximum number of users permitted under this license.</value>
    [DataMember(Name="MaxUsers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxUsers")]
    public int? MaxUsers { get; set; }

    /// <summary>
    /// The number of users currently utilized.
    /// </summary>
    /// <value>The number of users currently utilized.</value>
    [DataMember(Name="UsersUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UsersUsed")]
    public int? UsersUsed { get; set; }

    /// <summary>
    /// The number of desktop devices permitted under this license.
    /// </summary>
    /// <value>The number of desktop devices permitted under this license.</value>
    [DataMember(Name="MaxDesktops", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxDesktops")]
    public int? MaxDesktops { get; set; }

    /// <summary>
    /// The number of desktop devices currently managed by the appliance.
    /// </summary>
    /// <value>The number of desktop devices currently managed by the appliance.</value>
    [DataMember(Name="DesktopsUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DesktopsUsed")]
    public int? DesktopsUsed { get; set; }

    /// <summary>
    /// The number of server or other non-desktop devices permitted under this license.
    /// </summary>
    /// <value>The number of server or other non-desktop devices permitted under this license.</value>
    [DataMember(Name="MaxSystems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxSystems")]
    public int? MaxSystems { get; set; }

    /// <summary>
    /// The number of server or other non-desktop devices currently managed by the appliance.
    /// </summary>
    /// <value>The number of server or other non-desktop devices currently managed by the appliance.</value>
    [DataMember(Name="SystemsUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SystemsUsed")]
    public int? SystemsUsed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PasswordManagementLicense {\n");
      sb.Append("  Model: ").Append(Model).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  MaxUsers: ").Append(MaxUsers).Append("\n");
      sb.Append("  UsersUsed: ").Append(UsersUsed).Append("\n");
      sb.Append("  MaxDesktops: ").Append(MaxDesktops).Append("\n");
      sb.Append("  DesktopsUsed: ").Append(DesktopsUsed).Append("\n");
      sb.Append("  MaxSystems: ").Append(MaxSystems).Append("\n");
      sb.Append("  SystemsUsed: ").Append(SystemsUsed).Append("\n");
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
