using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsApi
    {
        /// <summary>
        /// Gets all of the application&#x27;s settings &lt;table&gt;    &lt;tr&gt;      &lt;th&gt;Setting Name&lt;/th&gt;      &lt;th&gt;Description&lt;/th&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Inform User of Bad Password&lt;/td&gt;      &lt;td&gt;During login, using the Local provider, display a friendly error message if the user&#x27;s password is incorrect.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Inform User of Disabled Account&lt;/td&gt;      &lt;td&gt;During login, using the Local provider, display a friendly error message if the user&#x27;s account is disabled.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Inform User of Locked Account&lt;/td&gt;      &lt;td&gt;During login, using the Local provider, display a friendly error message if the user&#x27;s account is locked.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Inform User of Invalid Token&lt;/td&gt;      &lt;td&gt;Return a friendly error message and reason when an invalid or expired authentication token is used when making an API request.  Otherwise, a generic \&quot;Access denied\&quot; error will be returned.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;User Lockout Duration&lt;/td&gt;      &lt;td&gt;The amount of time, in minutes, when using the Local provider for which a locked user will not be able to log in.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;User Lockout Threshold&lt;/td&gt;      &lt;td&gt;The number of consecutive failed log in attempts before the user is marked as locked.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;User Lockout Window&lt;/td&gt;      &lt;td&gt;The amount of time, in minutes, when using the Local provider for which the User Lockout Threshold will be accumulated.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Disable After Inactive for n Days&lt;/td&gt;      &lt;td&gt;The amount of time, in days, when using the Local provider after which a user will be marked as disabled and cannot log in.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Maximum Password Age&lt;/td&gt;      &lt;td&gt;The amount of time, in days, when using the Local provider after which the user must change their password.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Minimum Password Age&lt;/td&gt;      &lt;td&gt;The amount of time, in days, when using the Local provider for which a user cannot change their password.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Password History&lt;/td&gt;      &lt;td&gt;When using the Local provider, the number of unique new passwords that must be used when a user changes their password before an old password can be reused.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Password Grace Period&lt;/td&gt;      &lt;td&gt;During login, using the Local provider, display a password expiration reminder this many days before a user&#x27;s password will expire.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Token Lifetime&lt;/td&gt;      &lt;td&gt;The amount of time, in seconds, for which an API authentication token is valid for.  This also corresponds to the amount of time you can remain logged into the Safeguard Desktop Client application before being logged out.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Change Password Url&lt;/td&gt;      &lt;td&gt;Not used.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Inform User of Expired Password&lt;/td&gt;      &lt;td&gt;During login, using the Local provider, display a friendly error message if the user&#x27;s password is expired.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Maximum Notification Recipients&lt;/td&gt;      &lt;td&gt;Each set of approvers, reviewers, and emergency contacts can have up to this many recipients.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Expiration Warning Duration Days&lt;/td&gt;      &lt;td&gt;The number of days before an Access Request Policy is set to expire at which a PolicyAdmin will receive a reminder.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Default User Timezone&lt;/td&gt;      &lt;td&gt;Available time zones that can be assigned to users as their default time zone.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Max Platform Task Retries&lt;/td&gt;      &lt;td&gt;The number of retries that will be attempted on a platform task, such as Change Password.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Web Client Inactivity Timeout&lt;/td&gt;      &lt;td&gt;The amount of idle time, in minutes, after which a user will be automatically logged out of the Safeguard web site.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Use Fine Grained UserGroup Permissions&lt;/td&gt;      &lt;td&gt;Use fine grained UserGroup permissions, allowing more Admins to perform CRUD operations on UserGroups.  Set to false to revert to previous behavior.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Show Friendly Authentication Error Messages&lt;/td&gt;      &lt;td&gt;When set to true, users authenticating against Active Directory or LDAP will have friendly, specific error messages displayed when the login attempt fails. This includes individual messages for \&quot;Invalid password\&quot; or \&quot;Unknown username\&quot;, as well as other possibilities, depending on the provider, like \&quot;The specified account has been locked\&quot;. When set to false, only a generic error message of \&quot;Invalid username or bad password\&quot; will ever be displayed on the login page.&lt;/td&gt;    &lt;/tr&gt;  &lt;/table&gt;
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Setting&gt;</returns>
        List<Setting> SettingsGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets an application setting 
        /// </summary>
        /// <param name="id">Unique ID of Setting</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Setting</returns>
        Setting SettingsGetByIdAsync (string id, string fields);
        /// <summary>
        /// Updates a setting&#x27;s value 
        /// </summary>
        /// <param name="id">Unique identifier of the Setting to update</param>
        /// <param name="body">Updated Setting</param>
        /// <returns>Setting</returns>
        Setting SettingsUpdateEntityAsync (string id, Setting body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SettingsApi : ISettingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SettingsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SettingsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Gets all of the application&#x27;s settings &lt;table&gt;    &lt;tr&gt;      &lt;th&gt;Setting Name&lt;/th&gt;      &lt;th&gt;Description&lt;/th&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Inform User of Bad Password&lt;/td&gt;      &lt;td&gt;During login, using the Local provider, display a friendly error message if the user&#x27;s password is incorrect.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Inform User of Disabled Account&lt;/td&gt;      &lt;td&gt;During login, using the Local provider, display a friendly error message if the user&#x27;s account is disabled.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Inform User of Locked Account&lt;/td&gt;      &lt;td&gt;During login, using the Local provider, display a friendly error message if the user&#x27;s account is locked.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Inform User of Invalid Token&lt;/td&gt;      &lt;td&gt;Return a friendly error message and reason when an invalid or expired authentication token is used when making an API request.  Otherwise, a generic \&quot;Access denied\&quot; error will be returned.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;User Lockout Duration&lt;/td&gt;      &lt;td&gt;The amount of time, in minutes, when using the Local provider for which a locked user will not be able to log in.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;User Lockout Threshold&lt;/td&gt;      &lt;td&gt;The number of consecutive failed log in attempts before the user is marked as locked.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;User Lockout Window&lt;/td&gt;      &lt;td&gt;The amount of time, in minutes, when using the Local provider for which the User Lockout Threshold will be accumulated.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Disable After Inactive for n Days&lt;/td&gt;      &lt;td&gt;The amount of time, in days, when using the Local provider after which a user will be marked as disabled and cannot log in.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Maximum Password Age&lt;/td&gt;      &lt;td&gt;The amount of time, in days, when using the Local provider after which the user must change their password.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Minimum Password Age&lt;/td&gt;      &lt;td&gt;The amount of time, in days, when using the Local provider for which a user cannot change their password.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Password History&lt;/td&gt;      &lt;td&gt;When using the Local provider, the number of unique new passwords that must be used when a user changes their password before an old password can be reused.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Password Grace Period&lt;/td&gt;      &lt;td&gt;During login, using the Local provider, display a password expiration reminder this many days before a user&#x27;s password will expire.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Token Lifetime&lt;/td&gt;      &lt;td&gt;The amount of time, in seconds, for which an API authentication token is valid for.  This also corresponds to the amount of time you can remain logged into the Safeguard Desktop Client application before being logged out.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Change Password Url&lt;/td&gt;      &lt;td&gt;Not used.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Inform User of Expired Password&lt;/td&gt;      &lt;td&gt;During login, using the Local provider, display a friendly error message if the user&#x27;s password is expired.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Maximum Notification Recipients&lt;/td&gt;      &lt;td&gt;Each set of approvers, reviewers, and emergency contacts can have up to this many recipients.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Expiration Warning Duration Days&lt;/td&gt;      &lt;td&gt;The number of days before an Access Request Policy is set to expire at which a PolicyAdmin will receive a reminder.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Default User Timezone&lt;/td&gt;      &lt;td&gt;Available time zones that can be assigned to users as their default time zone.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Max Platform Task Retries&lt;/td&gt;      &lt;td&gt;The number of retries that will be attempted on a platform task, such as Change Password.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Web Client Inactivity Timeout&lt;/td&gt;      &lt;td&gt;The amount of idle time, in minutes, after which a user will be automatically logged out of the Safeguard web site.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Use Fine Grained UserGroup Permissions&lt;/td&gt;      &lt;td&gt;Use fine grained UserGroup permissions, allowing more Admins to perform CRUD operations on UserGroups.  Set to false to revert to previous behavior.&lt;/td&gt;    &lt;/tr&gt;    &lt;tr&gt;      &lt;td&gt;Show Friendly Authentication Error Messages&lt;/td&gt;      &lt;td&gt;When set to true, users authenticating against Active Directory or LDAP will have friendly, specific error messages displayed when the login attempt fails. This includes individual messages for \&quot;Invalid password\&quot; or \&quot;Unknown username\&quot;, as well as other possibilities, depending on the provider, like \&quot;The specified account has been locked\&quot;. When set to false, only a generic error message of \&quot;Invalid username or bad password\&quot; will ever be displayed on the login page.&lt;/td&gt;    &lt;/tr&gt;  &lt;/table&gt;
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Setting&gt;</returns>
        public List<Setting> SettingsGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Settings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SettingsGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SettingsGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Setting>) ApiClient.Deserialize(response.Content, typeof(List<Setting>), response.Headers);
        }
    
        /// <summary>
        /// Gets an application setting 
        /// </summary>
        /// <param name="id">Unique ID of Setting</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Setting</returns>
        public Setting SettingsGetByIdAsync (string id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SettingsGetByIdAsync");
    
            var path = "/v4/Settings/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SettingsGetByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SettingsGetByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Setting) ApiClient.Deserialize(response.Content, typeof(Setting), response.Headers);
        }
    
        /// <summary>
        /// Updates a setting&#x27;s value 
        /// </summary>
        /// <param name="id">Unique identifier of the Setting to update</param>
        /// <param name="body">Updated Setting</param>
        /// <returns>Setting</returns>
        public Setting SettingsUpdateEntityAsync (string id, Setting body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SettingsUpdateEntityAsync");
    
            var path = "/v4/Settings/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SettingsUpdateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SettingsUpdateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Setting) ApiClient.Deserialize(response.Content, typeof(Setting), response.Headers);
        }
    
    }
}
