using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Attribute that can be set on a directory entry
  /// </summary>
  [DataContract]
  public class DirectorySchemaAttribute {
    /// <summary>
    /// The name of the schame attribute
    /// </summary>
    /// <value>The name of the schame attribute</value>
    [DataMember(Name="LdapDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LdapDisplayName")]
    public string LdapDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets AttributeSyntax
    /// </summary>
    [DataMember(Name="AttributeSyntax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AttributeSyntax")]
    public DirectorySchemaSyntaxType AttributeSyntax { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DirectorySchemaAttribute {\n");
      sb.Append("  LdapDisplayName: ").Append(LdapDisplayName).Append("\n");
      sb.Append("  AttributeSyntax: ").Append(AttributeSyntax).Append("\n");
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
