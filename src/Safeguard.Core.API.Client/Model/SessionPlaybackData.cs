using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// SRS file definition used to playback session recordings from player
  /// </summary>
  [DataContract]
  public class SessionPlaybackData {
    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public int? Version { get; set; }

    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    [DataMember(Name="download_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "download_url")]
    public string DownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets TerminateUrl
    /// </summary>
    [DataMember(Name="terminate_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "terminate_url")]
    public string TerminateUrl { get; set; }

    /// <summary>
    /// Client must replace this with their authentication token
    /// </summary>
    /// <value>Client must replace this with their authentication token</value>
    [DataMember(Name="authorization_header", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorization_header")]
    public string AuthorizationHeader { get; set; }

    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }

    /// <summary>
    /// Gets or Sets Password
    /// </summary>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }

    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets ArchiveServerAddress
    /// </summary>
    [DataMember(Name="archive_server_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archive_server_address")]
    public string ArchiveServerAddress { get; set; }

    /// <summary>
    /// Gets or Sets ArchiveShareName
    /// </summary>
    [DataMember(Name="archive_share_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archive_share_name")]
    public string ArchiveShareName { get; set; }

    /// <summary>
    /// Gets or Sets SessionRecording
    /// </summary>
    [DataMember(Name="session_recording", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "session_recording")]
    public string SessionRecording { get; set; }

    /// <summary>
    /// Gets or Sets PermaLink
    /// </summary>
    [DataMember(Name="perma_link", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perma_link")]
    public string PermaLink { get; set; }

    /// <summary>
    /// Gets or Sets PlaybackUrl
    /// </summary>
    [DataMember(Name="playback_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "playback_url")]
    public string PlaybackUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SessionPlaybackData {\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
      sb.Append("  TerminateUrl: ").Append(TerminateUrl).Append("\n");
      sb.Append("  AuthorizationHeader: ").Append(AuthorizationHeader).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  ArchiveServerAddress: ").Append(ArchiveServerAddress).Append("\n");
      sb.Append("  ArchiveShareName: ").Append(ArchiveShareName).Append("\n");
      sb.Append("  SessionRecording: ").Append(SessionRecording).Append("\n");
      sb.Append("  PermaLink: ").Append(PermaLink).Append("\n");
      sb.Append("  PlaybackUrl: ").Append(PlaybackUrl).Append("\n");
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
