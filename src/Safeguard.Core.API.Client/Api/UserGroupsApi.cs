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
    public interface IUserGroupsApi
    {
        /// <summary>
        /// Processes multiple new user groups 
        /// </summary>
        /// <param name="body">New user groups to process</param>
        /// <returns>List&lt;UserGroupBatchResponse&gt;</returns>
        List<UserGroupBatchResponse> UserGroupsCreateMultipleUserGroupsAsync (List<UserGroup> body);
        /// <summary>
        /// Creates a new group of users 
        /// </summary>
        /// <param name="body">UserGroup to create</param>
        /// <returns>UserGroup</returns>
        UserGroup UserGroupsCreateUserGroupAsync (UserGroup body);
        /// <summary>
        /// Processes multiple user groups deletes 
        /// </summary>
        /// <param name="body">user groups to process</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns>List&lt;UserGroupBatchResult&gt;</returns>
        List<UserGroupBatchResult> UserGroupsDeleteMultipleUserGroupsAsync (List<int?> body, bool? forceDelete);
        /// <summary>
        /// Removes an user group 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        void UserGroupsDeleteUserGroupAsync (int? id, bool? forceDelete);
        /// <summary>
        /// Gets a user group 
        /// </summary>
        /// <param name="id">Unique ID of UserGroup</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>UserGroup</returns>
        UserGroup UserGroupsGetUserGroupByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets the members of a user group 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;User&gt;</returns>
        List<User> UserGroupsGetUserGroupMembersAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the security roles the user group belongs to 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserGroupRole&gt;</returns>
        List<UserGroupRole> UserGroupsGetUserGroupRolesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of user groups 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserGroup&gt;</returns>
        List<UserGroup> UserGroupsGetUserGroupsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Add/Remove members to an existing group 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Users to assign to the UserGroup</param>
        /// <returns>List&lt;User&gt;</returns>
        List<User> UserGroupsModifyUserGroupMembersAsync (int? id, ListOperation operation, List<User> body);
        /// <summary>
        /// Add/Remove roles a user group should be assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Role to assign the UserGroup to</param>
        /// <returns>List&lt;UserGroupRole&gt;</returns>
        List<UserGroupRole> UserGroupsModifyUserGroupRolesAsync (int? id, ListOperation operation, List<UserGroupRole> body);
        /// <summary>
        /// Sets an existing group&#x27;s membership 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="body">Users to assign to the UserGroup</param>
        /// <returns>List&lt;User&gt;</returns>
        List<User> UserGroupsSetUserGroupMembersAsync (int? id, List<User> body);
        /// <summary>
        /// Specifies which roles a user group should be assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="body">Role to assign the UserGroup to</param>
        /// <returns>List&lt;UserGroupRole&gt;</returns>
        List<UserGroupRole> UserGroupsSetUserGroupRolesAsync (int? id, List<UserGroupRole> body);
        /// <summary>
        /// Directory Groups: If you ever change the primary or secondary authentication providers of a directory based User Group, those changes  will not be reflected on existing users within Safeguard.  A user that was added to Safeguard via a directory group will only  ever have their authentication providers set when the user object is first created in Safeguard.  Subsequent background  synchronizations and changes to the User Group won&#x27;t effect those existing user&#x27;s authentication provider settings.  If,  however, you do need to force the authentication providers to be updated on existing users, then you must call this method.  Local Groups:  Call this to simply synchronize a local group with its members to ensure AdminRoles on the members are correct. 
        /// </summary>
        /// <param name="id">Unique ID of UserGroup</param>
        /// <returns>UserGroup</returns>
        UserGroup UserGroupsSynchronizeAndUpdateProvidersAsync (int? id);
        /// <summary>
        /// Processes multiple user groups updates 
        /// </summary>
        /// <param name="body">user groups to process</param>
        /// <returns>List&lt;UserGroupBatchResponse&gt;</returns>
        List<UserGroupBatchResponse> UserGroupsUpdateMultipleUserGroupsAsync (List<UserGroup> body);
        /// <summary>
        /// Updates an existing user group 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="body">Updated UserGroup</param>
        /// <returns>UserGroup</returns>
        UserGroup UserGroupsUpdateUserGroupAsync (int? id, UserGroup body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserGroupsApi : IUserGroupsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGroupsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserGroupsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGroupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserGroupsApi(String basePath)
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
        /// Processes multiple new user groups 
        /// </summary>
        /// <param name="body">New user groups to process</param>
        /// <returns>List&lt;UserGroupBatchResponse&gt;</returns>
        public List<UserGroupBatchResponse> UserGroupsCreateMultipleUserGroupsAsync (List<UserGroup> body)
        {
    
            var path = "/v4/UserGroups/BatchCreate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsCreateMultipleUserGroupsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsCreateMultipleUserGroupsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserGroupBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<UserGroupBatchResponse>), response.Headers);
        }
    
        /// <summary>
        /// Creates a new group of users 
        /// </summary>
        /// <param name="body">UserGroup to create</param>
        /// <returns>UserGroup</returns>
        public UserGroup UserGroupsCreateUserGroupAsync (UserGroup body)
        {
    
            var path = "/v4/UserGroups";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsCreateUserGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsCreateUserGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserGroup) ApiClient.Deserialize(response.Content, typeof(UserGroup), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple user groups deletes 
        /// </summary>
        /// <param name="body">user groups to process</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns>List&lt;UserGroupBatchResult&gt;</returns>
        public List<UserGroupBatchResult> UserGroupsDeleteMultipleUserGroupsAsync (List<int?> body, bool? forceDelete)
        {
    
            var path = "/v4/UserGroups/BatchDelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (forceDelete != null) queryParams.Add("forceDelete", ApiClient.ParameterToString(forceDelete)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsDeleteMultipleUserGroupsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsDeleteMultipleUserGroupsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserGroupBatchResult>) ApiClient.Deserialize(response.Content, typeof(List<UserGroupBatchResult>), response.Headers);
        }
    
        /// <summary>
        /// Removes an user group 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        public void UserGroupsDeleteUserGroupAsync (int? id, bool? forceDelete)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserGroupsDeleteUserGroupAsync");
    
            var path = "/v4/UserGroups/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (forceDelete != null) queryParams.Add("forceDelete", ApiClient.ParameterToString(forceDelete)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsDeleteUserGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsDeleteUserGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a user group 
        /// </summary>
        /// <param name="id">Unique ID of UserGroup</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>UserGroup</returns>
        public UserGroup UserGroupsGetUserGroupByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserGroupsGetUserGroupByIdAsync");
    
            var path = "/v4/UserGroups/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsGetUserGroupByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsGetUserGroupByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserGroup) ApiClient.Deserialize(response.Content, typeof(UserGroup), response.Headers);
        }
    
        /// <summary>
        /// Gets the members of a user group 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;User&gt;</returns>
        public List<User> UserGroupsGetUserGroupMembersAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserGroupsGetUserGroupMembersAsync");
    
            var path = "/v4/UserGroups/{id}/Members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsGetUserGroupMembersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsGetUserGroupMembersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<User>) ApiClient.Deserialize(response.Content, typeof(List<User>), response.Headers);
        }
    
        /// <summary>
        /// Gets the security roles the user group belongs to 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserGroupRole&gt;</returns>
        public List<UserGroupRole> UserGroupsGetUserGroupRolesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserGroupsGetUserGroupRolesAsync");
    
            var path = "/v4/UserGroups/{id}/Roles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsGetUserGroupRolesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsGetUserGroupRolesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserGroupRole>) ApiClient.Deserialize(response.Content, typeof(List<UserGroupRole>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of user groups 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserGroup&gt;</returns>
        public List<UserGroup> UserGroupsGetUserGroupsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/UserGroups";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsGetUserGroupsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsGetUserGroupsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserGroup>) ApiClient.Deserialize(response.Content, typeof(List<UserGroup>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove members to an existing group 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Users to assign to the UserGroup</param>
        /// <returns>List&lt;User&gt;</returns>
        public List<User> UserGroupsModifyUserGroupMembersAsync (int? id, ListOperation operation, List<User> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserGroupsModifyUserGroupMembersAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling UserGroupsModifyUserGroupMembersAsync");
    
            var path = "/v4/UserGroups/{id}/Members/{operation}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "operation" + "}", ApiClient.ParameterToString(operation));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsModifyUserGroupMembersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsModifyUserGroupMembersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<User>) ApiClient.Deserialize(response.Content, typeof(List<User>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove roles a user group should be assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Role to assign the UserGroup to</param>
        /// <returns>List&lt;UserGroupRole&gt;</returns>
        public List<UserGroupRole> UserGroupsModifyUserGroupRolesAsync (int? id, ListOperation operation, List<UserGroupRole> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserGroupsModifyUserGroupRolesAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling UserGroupsModifyUserGroupRolesAsync");
    
            var path = "/v4/UserGroups/{id}/Roles/{operation}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "operation" + "}", ApiClient.ParameterToString(operation));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsModifyUserGroupRolesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsModifyUserGroupRolesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserGroupRole>) ApiClient.Deserialize(response.Content, typeof(List<UserGroupRole>), response.Headers);
        }
    
        /// <summary>
        /// Sets an existing group&#x27;s membership 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="body">Users to assign to the UserGroup</param>
        /// <returns>List&lt;User&gt;</returns>
        public List<User> UserGroupsSetUserGroupMembersAsync (int? id, List<User> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserGroupsSetUserGroupMembersAsync");
    
            var path = "/v4/UserGroups/{id}/Members";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsSetUserGroupMembersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsSetUserGroupMembersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<User>) ApiClient.Deserialize(response.Content, typeof(List<User>), response.Headers);
        }
    
        /// <summary>
        /// Specifies which roles a user group should be assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="body">Role to assign the UserGroup to</param>
        /// <returns>List&lt;UserGroupRole&gt;</returns>
        public List<UserGroupRole> UserGroupsSetUserGroupRolesAsync (int? id, List<UserGroupRole> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserGroupsSetUserGroupRolesAsync");
    
            var path = "/v4/UserGroups/{id}/Roles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsSetUserGroupRolesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsSetUserGroupRolesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserGroupRole>) ApiClient.Deserialize(response.Content, typeof(List<UserGroupRole>), response.Headers);
        }
    
        /// <summary>
        /// Directory Groups: If you ever change the primary or secondary authentication providers of a directory based User Group, those changes  will not be reflected on existing users within Safeguard.  A user that was added to Safeguard via a directory group will only  ever have their authentication providers set when the user object is first created in Safeguard.  Subsequent background  synchronizations and changes to the User Group won&#x27;t effect those existing user&#x27;s authentication provider settings.  If,  however, you do need to force the authentication providers to be updated on existing users, then you must call this method.  Local Groups:  Call this to simply synchronize a local group with its members to ensure AdminRoles on the members are correct. 
        /// </summary>
        /// <param name="id">Unique ID of UserGroup</param>
        /// <returns>UserGroup</returns>
        public UserGroup UserGroupsSynchronizeAndUpdateProvidersAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserGroupsSynchronizeAndUpdateProvidersAsync");
    
            var path = "/v4/UserGroups/{id}/SynchronizeAndUpdateProviders";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsSynchronizeAndUpdateProvidersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsSynchronizeAndUpdateProvidersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserGroup) ApiClient.Deserialize(response.Content, typeof(UserGroup), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple user groups updates 
        /// </summary>
        /// <param name="body">user groups to process</param>
        /// <returns>List&lt;UserGroupBatchResponse&gt;</returns>
        public List<UserGroupBatchResponse> UserGroupsUpdateMultipleUserGroupsAsync (List<UserGroup> body)
        {
    
            var path = "/v4/UserGroups/BatchUpdate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsUpdateMultipleUserGroupsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsUpdateMultipleUserGroupsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserGroupBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<UserGroupBatchResponse>), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing user group 
        /// </summary>
        /// <param name="id">Unique identifier of the UserGroup</param>
        /// <param name="body">Updated UserGroup</param>
        /// <returns>UserGroup</returns>
        public UserGroup UserGroupsUpdateUserGroupAsync (int? id, UserGroup body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserGroupsUpdateUserGroupAsync");
    
            var path = "/v4/UserGroups/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsUpdateUserGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserGroupsUpdateUserGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserGroup) ApiClient.Deserialize(response.Content, typeof(UserGroup), response.Headers);
        }
    
    }
}
