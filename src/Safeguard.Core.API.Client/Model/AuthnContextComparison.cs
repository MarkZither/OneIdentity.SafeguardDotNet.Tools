using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// From Assertions and Protocols for the OASIS Security Assertion Markup Language (SAML) V2.0 – Errata Composite              section 3.3.2.2.1. Specifies the comparison method used to evaluate the requested context              classes or statements, one of \&quot;exact\&quot;, \&quot;minimum\&quot;, \&quot;maximum\&quot;, or \&quot;better\&quot;.
  /// </summary>
  [DataContract]
  public class AuthnContextComparison {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthnContextComparison {\n");
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
