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
  public class TicketSystemTestConnectionParameters {
    /// <summary>
    /// Base URL location of the ticket system
    /// </summary>
    /// <value>Base URL location of the ticket system</value>
    [DataMember(Name="ApplicationUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplicationUrl")]
    public string ApplicationUrl { get; set; }

    /// <summary>
    /// Gets or Sets TicketSystemType
    /// </summary>
    [DataMember(Name="TicketSystemType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TicketSystemType")]
    public TicketSystemType TicketSystemType { get; set; }

    /// <summary>
    /// Login name for ticket system
    /// </summary>
    /// <value>Login name for ticket system</value>
    [DataMember(Name="UserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserName")]
    public string UserName { get; set; }

    /// <summary>
    /// Password for ticket system
    /// </summary>
    /// <value>Password for ticket system</value>
    [DataMember(Name="Password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Password")]
    public string Password { get; set; }

    /// <summary>
    /// Gets or Sets ServiceNowProperties
    /// </summary>
    [DataMember(Name="ServiceNowProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceNowProperties")]
    public ServiceNowProperties ServiceNowProperties { get; set; }

    /// <summary>
    /// Gets or Sets RemedyProperties
    /// </summary>
    [DataMember(Name="RemedyProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RemedyProperties")]
    public RemedyProperties RemedyProperties { get; set; }

    /// <summary>
    /// TicketRegularExpression string used to validate format of ticket
    /// </summary>
    /// <value>TicketRegularExpression string used to validate format of ticket</value>
    [DataMember(Name="TicketRegularExpression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TicketRegularExpression")]
    public string TicketRegularExpression { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TicketSystemTestConnectionParameters {\n");
      sb.Append("  ApplicationUrl: ").Append(ApplicationUrl).Append("\n");
      sb.Append("  TicketSystemType: ").Append(TicketSystemType).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  ServiceNowProperties: ").Append(ServiceNowProperties).Append("\n");
      sb.Append("  RemedyProperties: ").Append(RemedyProperties).Append("\n");
      sb.Append("  TicketRegularExpression: ").Append(TicketRegularExpression).Append("\n");
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
