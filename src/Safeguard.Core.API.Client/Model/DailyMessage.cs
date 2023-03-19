using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a Message of the Day.
  /// </summary>
  [DataContract]
  public class DailyMessage {
    /// <summary>
    /// Flag for whether to use the Address field to access an RSS feed [true] or to access the Subject and Message fields from settings [false]
    /// </summary>
    /// <value>Flag for whether to use the Address field to access an RSS feed [true] or to access the Subject and Message fields from settings [false]</value>
    [DataMember(Name="UseRss", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseRss")]
    public bool? UseRss { get; set; }

    /// <summary>
    /// Web Address of an RSS feed.
    /// </summary>
    /// <value>Web Address of an RSS feed.</value>
    [DataMember(Name="Address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Address")]
    public string Address { get; set; }

    /// <summary>
    /// Subject line of a Daily Message.
    /// </summary>
    /// <value>Subject line of a Daily Message.</value>
    [DataMember(Name="Subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Subject")]
    public string Subject { get; set; }

    /// <summary>
    /// Content of a Daily Message.
    /// </summary>
    /// <value>Content of a Daily Message.</value>
    [DataMember(Name="Message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Message")]
    public string Message { get; set; }

    /// <summary>
    /// Date this entity was updated (Read-only)
    /// </summary>
    /// <value>Date this entity was updated (Read-only)</value>
    [DataMember(Name="UpdatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedDate")]
    public DateTime? UpdatedDate { get; set; }

    /// <summary>
    /// The database ID of the user that updated this entity (Read-only)
    /// </summary>
    /// <value>The database ID of the user that updated this entity (Read-only)</value>
    [DataMember(Name="UpdatedByUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedByUserId")]
    public int? UpdatedByUserId { get; set; }

    /// <summary>
    /// The display name of the user that updated this entity (Read-only)
    /// </summary>
    /// <value>The display name of the user that updated this entity (Read-only)</value>
    [DataMember(Name="UpdatedByUserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdatedByUserDisplayName")]
    public string UpdatedByUserDisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DailyMessage {\n");
      sb.Append("  UseRss: ").Append(UseRss).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
      sb.Append("  UpdatedByUserId: ").Append(UpdatedByUserId).Append("\n");
      sb.Append("  UpdatedByUserDisplayName: ").Append(UpdatedByUserDisplayName).Append("\n");
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
