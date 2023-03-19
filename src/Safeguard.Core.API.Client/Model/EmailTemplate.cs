using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Template used when generating email-oriented event notifications
  /// </summary>
  [DataContract]
  public class EmailTemplate {
    /// <summary>
    /// Gets or Sets EventName
    /// </summary>
    [DataMember(Name="EventName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EventName")]
    public EventName EventName { get; set; }

    /// <summary>
    /// The Reply-To address to use when generating email notifications from this template.
    /// </summary>
    /// <value>The Reply-To address to use when generating email notifications from this template.</value>
    [DataMember(Name="ReplyToEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReplyToEmail")]
    public string ReplyToEmail { get; set; }

    /// <summary>
    /// The subject line template. Mustache-style tags are supported for insertion of event property data. See also Event for definitions of event property data.
    /// </summary>
    /// <value>The subject line template. Mustache-style tags are supported for insertion of event property data. See also Event for definitions of event property data.</value>
    [DataMember(Name="SubjectTemplate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubjectTemplate")]
    public string SubjectTemplate { get; set; }

    /// <summary>
    /// The body template. Mustache-style tags are supported for insertion of event property data. See also Event for definitions of event property data.
    /// </summary>
    /// <value>The body template. Mustache-style tags are supported for insertion of event property data. See also Event for definitions of event property data.</value>
    [DataMember(Name="BodyTemplate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BodyTemplate")]
    public string BodyTemplate { get; set; }

    /// <summary>
    /// Mark this email template as modified, typically BodyTemplate or SubjectTemplate, and is used for (Read-only).
    /// </summary>
    /// <value>Mark this email template as modified, typically BodyTemplate or SubjectTemplate, and is used for (Read-only).</value>
    [DataMember(Name="IsModified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsModified")]
    public bool? IsModified { get; set; }

    /// <summary>
    /// Gets or Sets _Event
    /// </summary>
    [DataMember(Name="Event", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Event")]
    public ModelEvent _Event { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailTemplate {\n");
      sb.Append("  EventName: ").Append(EventName).Append("\n");
      sb.Append("  ReplyToEmail: ").Append(ReplyToEmail).Append("\n");
      sb.Append("  SubjectTemplate: ").Append(SubjectTemplate).Append("\n");
      sb.Append("  BodyTemplate: ").Append(BodyTemplate).Append("\n");
      sb.Append("  IsModified: ").Append(IsModified).Append("\n");
      sb.Append("  _Event: ").Append(_Event).Append("\n");
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
