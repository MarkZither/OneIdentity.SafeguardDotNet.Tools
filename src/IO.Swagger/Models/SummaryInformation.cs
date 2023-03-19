/*
 * Safeguard Core API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v4
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// The count of all tasks
    /// </summary>
    [DataContract]
    public partial class SummaryInformation : IEquatable<SummaryInformation>
    { 
        /// <summary>
        /// Sum of all TaskSummary.Count values for all dates being reported
        /// </summary>
        /// <value>Sum of all TaskSummary.Count values for all dates being reported</value>

        [DataMember(Name="TotalTaskCount")]
        public int? TotalTaskCount { get; set; }

        /// <summary>
        /// List of date buckets
        /// </summary>
        /// <value>List of date buckets</value>

        [DataMember(Name="SummaryDates")]
        public List<DateTasks> SummaryDates { get; set; }

        /// <summary>
        /// Earliest date summarized
        /// </summary>
        /// <value>Earliest date summarized</value>

        [DataMember(Name="MinimumDateTime")]
        public DateTime? MinimumDateTime { get; set; }

        /// <summary>
        /// Latest date summarized
        /// </summary>
        /// <value>Latest date summarized</value>

        [DataMember(Name="MaximumDateTime")]
        public DateTime? MaximumDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummaryInformation {\n");
            sb.Append("  TotalTaskCount: ").Append(TotalTaskCount).Append("\n");
            sb.Append("  SummaryDates: ").Append(SummaryDates).Append("\n");
            sb.Append("  MinimumDateTime: ").Append(MinimumDateTime).Append("\n");
            sb.Append("  MaximumDateTime: ").Append(MaximumDateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((SummaryInformation)obj);
        }

        /// <summary>
        /// Returns true if SummaryInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of SummaryInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SummaryInformation other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TotalTaskCount == other.TotalTaskCount ||
                    TotalTaskCount != null &&
                    TotalTaskCount.Equals(other.TotalTaskCount)
                ) && 
                (
                    SummaryDates == other.SummaryDates ||
                    SummaryDates != null &&
                    SummaryDates.SequenceEqual(other.SummaryDates)
                ) && 
                (
                    MinimumDateTime == other.MinimumDateTime ||
                    MinimumDateTime != null &&
                    MinimumDateTime.Equals(other.MinimumDateTime)
                ) && 
                (
                    MaximumDateTime == other.MaximumDateTime ||
                    MaximumDateTime != null &&
                    MaximumDateTime.Equals(other.MaximumDateTime)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (TotalTaskCount != null)
                    hashCode = hashCode * 59 + TotalTaskCount.GetHashCode();
                    if (SummaryDates != null)
                    hashCode = hashCode * 59 + SummaryDates.GetHashCode();
                    if (MinimumDateTime != null)
                    hashCode = hashCode * 59 + MinimumDateTime.GetHashCode();
                    if (MaximumDateTime != null)
                    hashCode = hashCode * 59 + MaximumDateTime.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SummaryInformation left, SummaryInformation right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SummaryInformation left, SummaryInformation right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
