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
    /// When a client application makes a request to the &lt;i&gt;/service/core/v2/Token/LoginResponse&lt;/i&gt; end point, they              should post this object.  Currently, we have only one property, so it could be a single parameter, but this will allow for              future updates without necessarily breaking the clients.
    /// </summary>
    [DataContract]
    public partial class LoginResponseRequestData : IEquatable<LoginResponseRequestData>
    { 
        /// <summary>
        /// The access token obtained from the STS that the client application intends to exchange for a Safeguard token.
        /// </summary>
        /// <value>The access token obtained from the STS that the client application intends to exchange for a Safeguard token.</value>

        [DataMember(Name="StsAccessToken")]
        public string StsAccessToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginResponseRequestData {\n");
            sb.Append("  StsAccessToken: ").Append(StsAccessToken).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LoginResponseRequestData)obj);
        }

        /// <summary>
        /// Returns true if LoginResponseRequestData instances are equal
        /// </summary>
        /// <param name="other">Instance of LoginResponseRequestData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoginResponseRequestData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    StsAccessToken == other.StsAccessToken ||
                    StsAccessToken != null &&
                    StsAccessToken.Equals(other.StsAccessToken)
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
                    if (StsAccessToken != null)
                    hashCode = hashCode * 59 + StsAccessToken.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LoginResponseRequestData left, LoginResponseRequestData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LoginResponseRequestData left, LoginResponseRequestData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
