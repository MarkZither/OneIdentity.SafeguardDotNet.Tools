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
  public class DirectoryPropertyConstraintProperties {
    /// <summary>
    /// Filters accounts based on the name of the account (an ANR search is performed for Active Directory). Names can be specified as a regular expression.
    /// </summary>
    /// <value>Filters accounts based on the name of the account (an ANR search is performed for Active Directory). Names can be specified as a regular expression.</value>
    [DataMember(Name="NameFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NameFilter")]
    public string NameFilter { get; set; }

    /// <summary>
    /// Filter accounts based on the names of groups in the directory the account belongs to. Names can be specified as a regular expression.
    /// </summary>
    /// <value>Filter accounts based on the names of groups in the directory the account belongs to. Names can be specified as a regular expression.</value>
    [DataMember(Name="GroupFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupFilter")]
    public string GroupFilter { get; set; }

    /// <summary>
    /// Filter accounts based on their uidNumber attribute (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5
    /// </summary>
    /// <value>Filter accounts based on their uidNumber attribute (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5</value>
    [DataMember(Name="UidFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UidFilter")]
    public List<string> UidFilter { get; set; }

    /// <summary>
    /// Filter accounts based on their Windows relative account ID (last part of objectSid attribute) (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5
    /// </summary>
    /// <value>Filter accounts based on their Windows relative account ID (last part of objectSid attribute) (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5</value>
    [DataMember(Name="RidFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RidFilter")]
    public List<string> RidFilter { get; set; }

    /// <summary>
    /// Filter accounts based on their gidNumber attribute (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5
    /// </summary>
    /// <value>Filter accounts based on their gidNumber attribute (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5</value>
    [DataMember(Name="GidFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GidFilter")]
    public List<string> GidFilter { get; set; }

    /// <summary>
    /// Filter accounts based on their primaryGroupID attribute (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5
    /// </summary>
    /// <value>Filter accounts based on their primaryGroupID attribute (Active Directory only). IDs can be specified as a single ID or a range, e.g. 1 or 3-5</value>
    [DataMember(Name="PrimaryGidFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryGidFilter")]
    public List<string> PrimaryGidFilter { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DirectoryPropertyConstraintProperties {\n");
      sb.Append("  NameFilter: ").Append(NameFilter).Append("\n");
      sb.Append("  GroupFilter: ").Append(GroupFilter).Append("\n");
      sb.Append("  UidFilter: ").Append(UidFilter).Append("\n");
      sb.Append("  RidFilter: ").Append(RidFilter).Append("\n");
      sb.Append("  GidFilter: ").Append(GidFilter).Append("\n");
      sb.Append("  PrimaryGidFilter: ").Append(PrimaryGidFilter).Append("\n");
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
