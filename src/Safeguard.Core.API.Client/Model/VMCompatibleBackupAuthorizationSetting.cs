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
  public class VMCompatibleBackupAuthorizationSetting {
    /// <summary>
    /// True if the cluster is authorized to download backups from hardware  as a backup that can restore to a virtual appliance.
    /// </summary>
    /// <value>True if the cluster is authorized to download backups from hardware  as a backup that can restore to a virtual appliance.</value>
    [DataMember(Name="Authorized", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Authorized")]
    public bool? Authorized { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VMCompatibleBackupAuthorizationSetting {\n");
      sb.Append("  Authorized: ").Append(Authorized).Append("\n");
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
