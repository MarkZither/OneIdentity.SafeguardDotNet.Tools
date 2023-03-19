using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents the email client configuration on the appliance.
  /// </summary>
  [DataContract]
  public class EmailClientConfigConnectionProperties {
    /// <summary>
    /// Database ID of an asset account for connecting to the asset. Overrides ServiceAccountName.
    /// </summary>
    /// <value>Database ID of an asset account for connecting to the asset. Overrides ServiceAccountName.</value>
    [DataMember(Name="ServiceAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountId")]
    public int? ServiceAccountId { get; set; }

    /// <summary>
    /// The name of an account for connecting to the SMTP server.
    /// </summary>
    /// <value>The name of an account for connecting to the SMTP server.</value>
    [DataMember(Name="ServiceAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountName")]
    public string ServiceAccountName { get; set; }

    /// <summary>
    /// The domain name of the service account if the SMTP authentication uses a Directory Account (Read-only)
    /// </summary>
    /// <value>The domain name of the service account if the SMTP authentication uses a Directory Account (Read-only)</value>
    [DataMember(Name="ServiceAccountDomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountDomainName")]
    public string ServiceAccountDomainName { get; set; }

    /// <summary>
    /// Service account password may be set via this property. (write-only)
    /// </summary>
    /// <value>Service account password may be set via this property. (write-only)</value>
    [DataMember(Name="ServiceAccountPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountPassword")]
    public string ServiceAccountPassword { get; set; }

    /// <summary>
    /// The effective service account name (Read-only)
    /// </summary>
    /// <value>The effective service account name (Read-only)</value>
    [DataMember(Name="EffectiveServiceAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveServiceAccountName")]
    public string EffectiveServiceAccountName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailClientConfigConnectionProperties {\n");
      sb.Append("  ServiceAccountId: ").Append(ServiceAccountId).Append("\n");
      sb.Append("  ServiceAccountName: ").Append(ServiceAccountName).Append("\n");
      sb.Append("  ServiceAccountDomainName: ").Append(ServiceAccountDomainName).Append("\n");
      sb.Append("  ServiceAccountPassword: ").Append(ServiceAccountPassword).Append("\n");
      sb.Append("  EffectiveServiceAccountName: ").Append(EffectiveServiceAccountName).Append("\n");
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
