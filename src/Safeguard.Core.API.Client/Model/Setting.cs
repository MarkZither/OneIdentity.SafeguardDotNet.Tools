using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a setting used to configure the appliance or application
  /// </summary>
  [DataContract]
  public class Setting {
    /// <summary>
    /// The setting's name (Read-only)
    /// </summary>
    /// <value>The setting's name (Read-only)</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// The setting's category (Read-only)
    /// </summary>
    /// <value>The setting's category (Read-only)</value>
    [DataMember(Name="Category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Category")]
    public string Category { get; set; }

    /// <summary>
    /// The setting's current value
    /// </summary>
    /// <value>The setting's current value</value>
    [DataMember(Name="Value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Value")]
    public string Value { get; set; }

    /// <summary>
    /// The setting's default value (Read-only)
    /// </summary>
    /// <value>The setting's default value (Read-only)</value>
    [DataMember(Name="DefaultValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultValue")]
    public string DefaultValue { get; set; }

    /// <summary>
    /// The setting's minimum limit value, if the value is numeric in nature. When null, the value is either non-numeric or there is no minimum limit. (Read-only)
    /// </summary>
    /// <value>The setting's minimum limit value, if the value is numeric in nature. When null, the value is either non-numeric or there is no minimum limit. (Read-only)</value>
    [DataMember(Name="MinValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinValue")]
    public int? MinValue { get; set; }

    /// <summary>
    /// The setting's maximum limit value, if the setting is numeric in nature. When null, the value is either non-numeric or there is no maximum limit. (Read-only)
    /// </summary>
    /// <value>The setting's maximum limit value, if the setting is numeric in nature. When null, the value is either non-numeric or there is no maximum limit. (Read-only)</value>
    [DataMember(Name="MaxValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxValue")]
    public int? MaxValue { get; set; }

    /// <summary>
    /// Valid options for this setting. Empty for many settings. (Read-only)
    /// </summary>
    /// <value>Valid options for this setting. Empty for many settings. (Read-only)</value>
    [DataMember(Name="Options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Options")]
    public List<SettingOption> Options { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Setting {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  MinValue: ").Append(MinValue).Append("\n");
      sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
      sb.Append("  Options: ").Append(Options).Append("\n");
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
