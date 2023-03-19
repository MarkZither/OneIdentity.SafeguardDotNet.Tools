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
  public class AccountGroupBatchResponse {
    /// <summary>
    /// Gets or Sets Response
    /// </summary>
    [DataMember(Name="Response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Response")]
    public AccountGroup Response { get; set; }

    /// <summary>
    /// Gets or Sets StatusCode
    /// </summary>
    [DataMember(Name="StatusCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StatusCode")]
    public HttpStatusCode StatusCode { get; set; }

    /// <summary>
    /// Gets or Sets StatusCodeNumber
    /// </summary>
    [DataMember(Name="StatusCodeNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StatusCodeNumber")]
    public int? StatusCodeNumber { get; set; }

    /// <summary>
    /// Gets or Sets IsSuccess
    /// </summary>
    [DataMember(Name="IsSuccess", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSuccess")]
    public bool? IsSuccess { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [DataMember(Name="Error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Error")]
    public ApiError Error { get; set; }

    /// <summary>
    /// Gets or Sets Request
    /// </summary>
    [DataMember(Name="Request", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Request")]
    public AccountGroup Request { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountGroupBatchResponse {\n");
      sb.Append("  Response: ").Append(Response).Append("\n");
      sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
      sb.Append("  StatusCodeNumber: ").Append(StatusCodeNumber).Append("\n");
      sb.Append("  IsSuccess: ").Append(IsSuccess).Append("\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("  Request: ").Append(Request).Append("\n");
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
