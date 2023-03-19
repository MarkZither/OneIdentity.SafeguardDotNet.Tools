using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// When the TypeReferenceName property is \&quot;OneLoginMfa\&quot;, this provides additional configuration  values specific to that provider type.
  /// </summary>
  [DataContract]
  public class IdentityProviderConfigOneLoginMfaProperties {
    /// <summary>
    /// The full DNS host name of the OneLogin subscription. Typically this will be <subdomain>.onelogin.com.  Where <subdomain> is the name chosen by you when first signing up.
    /// </summary>
    /// <value>The full DNS host name of the OneLogin subscription. Typically this will be <subdomain>.onelogin.com.  Where <subdomain> is the name chosen by you when first signing up.</value>
    [DataMember(Name="DnsHostName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DnsHostName")]
    public string DnsHostName { get; set; }

    /// <summary>
    /// The Client ID of your OneLogin API Credential pair. Obtained by creating API Credentials on your  OneLogin administration site. The credential must be given the \"Manage All\" scope/permission.
    /// </summary>
    /// <value>The Client ID of your OneLogin API Credential pair. Obtained by creating API Credentials on your  OneLogin administration site. The credential must be given the \"Manage All\" scope/permission.</value>
    [DataMember(Name="ClientId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClientId")]
    public string ClientId { get; set; }

    /// <summary>
    /// The Client Secret of your OneLogin API Credential pair. Obtained by creating API Credentials on  your OneLogin administration site. The credential must be given the \"Manage All\" scope/permission.  This value is considered write-only and cannot be obtained after being set.
    /// </summary>
    /// <value>The Client Secret of your OneLogin API Credential pair. Obtained by creating API Credentials on  your OneLogin administration site. The credential must be given the \"Manage All\" scope/permission.  This value is considered write-only and cannot be obtained after being set.</value>
    [DataMember(Name="ClientSecret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClientSecret")]
    public string ClientSecret { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IdentityProviderConfigOneLoginMfaProperties {\n");
      sb.Append("  DnsHostName: ").Append(DnsHostName).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
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
