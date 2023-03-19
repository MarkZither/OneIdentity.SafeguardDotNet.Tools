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
    public interface IUsersApi
    {
        /// <summary>
        /// Processes multiple new users 
        /// </summary>
        /// <param name="body">New users to process</param>
        /// <returns>List&lt;UserBatchResponse&gt;</returns>
        List<UserBatchResponse> UsersCreateMultipleUsersAsync (List<User> body);
        /// <summary>
        /// Creates a new application user 
        /// </summary>
        /// <param name="body">User to create</param>
        /// <returns>User</returns>
        User UsersCreateUserAsync (User body);
        /// <summary>
        /// Removes a User Include &#x27;X-Force-Delete&#x27; header to force delete despite dependencies when given 50104 error
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        void UsersDeleteAsync (int? id, bool? forceDelete);
        /// <summary>
        /// Processes multiple users to delete 
        /// </summary>
        /// <param name="body">User Ids to process</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns>List&lt;UserBatchResult&gt;</returns>
        List<UserBatchResult> UsersDeleteMultipleUsersAsync (List<int?> body, bool? forceDelete);
        /// <summary>
        /// Removes an application user photo 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <returns></returns>
        void UsersDeletePhotoAsync (int? id);
        /// <summary>
        /// Removes a preference for the given user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="name">Unique identifier of the UserPreference</param>
        /// <returns></returns>
        void UsersDeleteUserPreferenceAsync (int? id, string name);
        /// <summary>
        /// Disable an event subscriber for this user 
        /// </summary>
        /// <param name="id">Unique identifier of the User to update</param>
        /// <param name="subscriberId">Unique ID of the event subscriber</param>
        /// <returns>EventSubscriberUser</returns>
        EventSubscriberUser UsersDisableUserEventSubscriberAsync (int? id, int? subscriberId);
        /// <summary>
        /// Enable an event subscriber for this user 
        /// </summary>
        /// <param name="id">Unique identifier of the User to update</param>
        /// <param name="subscriberId">Unique ID of the event subscriber</param>
        /// <returns>EventSubscriberUser</returns>
        EventSubscriberUser UsersEnableUserEventSubscriberAsync (int? id, int? subscriberId);
        /// <summary>
        /// Get policy accounts that have been linked to this user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyAccount&gt;</returns>
        List<PolicyAccount> UsersGetLinkedAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the user&#x27;s photo 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <returns>UserPhoto</returns>
        UserPhoto UsersGetPhotoAsync (int? id);
        /// <summary>
        /// Gets the user&#x27;s photo in raw format (64K max size) 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <returns>byte[]</returns>
        byte[] UsersGetRawPhotoAsync (int? id);
        /// <summary>
        /// Gets information about roles this user belongs to 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserRole&gt;</returns>
        List<UserRole> UsersGetRolesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a single user 
        /// </summary>
        /// <param name="id">Unique ID of User</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>User</returns>
        User UsersGetUserByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets the user&#x27;s group memberships 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserGroup&gt;</returns>
        List<UserGroup> UsersGetUserGroupsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets information about assets, partitions, accounts this user owns 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnership&gt;</returns>
        List<UserOwnership> UsersGetUserOwnershipAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets information about partitions this user owns 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetPartition&gt;</returns>
        List<AssetPartition> UsersGetUserPartitionsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific preference for the given user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="name">Unique identifier of the UserPreference</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>UserPreference</returns>
        UserPreference UsersGetUserPreferenceAsync (int? id, string name, string fields);
        /// <summary>
        /// Gets all preferences for the given user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserPreference&gt;</returns>
        List<UserPreference> UsersGetUserPreferencesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a single subscriber for this user 
        /// </summary>
        /// <param name="id">Unique ID of an User</param>
        /// <param name="subscriberId">Unique ID of the event subscriber</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>EventSubscriberUser</returns>
        EventSubscriberUser UsersGetUserSubscriberByIdAsync (int? id, int? subscriberId, string fields);
        /// <summary>
        /// Gets a list of subscriptions for a user 
        /// </summary>
        /// <param name="id">Unique ID of the user</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;EventSubscriberUser&gt;</returns>
        List<EventSubscriberUser> UsersGetUserSubscribersAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of users 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;User&gt;</returns>
        List<User> UsersGetUsersAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Add/Remove user linked accounts 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">List of accounts to be linked</param>
        /// <returns>List&lt;PolicyAccount&gt;</returns>
        List<PolicyAccount> UsersModifyLinkedAccountsAsync (int? id, ListOperation operation, List<PolicyAccount> body);
        /// <summary>
        /// Add/Remove roles a user should be assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Role to assign the User to</param>
        /// <returns>List&lt;UserRole&gt;</returns>
        List<UserRole> UsersModifyRolesAsync (int? id, ListOperation operation, List<UserRole> body);
        /// <summary>
        /// Updates an existing application user&#x27;s photo in binary form 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UsersPutRawPhotoAsync (int? id, PhotoRawBody1 body);
        /// <summary>
        /// Updates set of accounts linked to this user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="body">List of accounts to be linked</param>
        /// <returns>List&lt;PolicyAccount&gt;</returns>
        List<PolicyAccount> UsersSaveLinkedAccountsAsync (int? id, List<PolicyAccount> body);
        /// <summary>
        /// Sets the password of the local user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="body">Password to set for this user</param>
        /// <param name="changePasswordAtNextLogin">Force user to change password at next login</param>
        /// <returns>ValidationError</returns>
        ValidationError UsersSetPasswordAsync (int? id, string body, bool? changePasswordAtNextLogin);
        /// <summary>
        /// Specifies which roles a user should be assigned to explicitly 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="body">Roles to assign the User to</param>
        /// <returns>List&lt;UserRole&gt;</returns>
        List<UserRole> UsersSetRolesAsync (int? id, List<UserRole> body);
        /// <summary>
        /// Updates or create a preference for the given user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="name">Unique identifier of the UserPreference</param>
        /// <param name="body">Value to set for this preference</param>
        /// <returns>UserPreference</returns>
        UserPreference UsersSetUserPreferenceAsync (int? id, string name, UserPreference body);
        /// <summary>
        /// Unlocks the specified user account 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <returns></returns>
        void UsersUnlockAsync (int? id);
        /// <summary>
        /// Processes multiple users to update 
        /// </summary>
        /// <param name="body">Users to process</param>
        /// <returns>List&lt;UserBatchResponse&gt;</returns>
        List<UserBatchResponse> UsersUpdateMultipleUsersAsync (List<User> body);
        /// <summary>
        /// Updates an existing application user&#x27;s photo 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="body">Updated Photo (64K max size)</param>
        /// <returns></returns>
        void UsersUpdatePhotoAsync (int? id, UserPhoto body);
        /// <summary>
        /// Updates an existing application user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="body">Updated User</param>
        /// <returns>User</returns>
        User UsersUpdateUserAsync (int? id, User body);
        /// <summary>
        /// Validates that a password meets requirements 
        /// </summary>
        /// <param name="body">Password to validate</param>
        /// <returns>bool?</returns>
        bool? UsersValidatePasswordAsync (string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
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
        /// Processes multiple new users 
        /// </summary>
        /// <param name="body">New users to process</param>
        /// <returns>List&lt;UserBatchResponse&gt;</returns>
        public List<UserBatchResponse> UsersCreateMultipleUsersAsync (List<User> body)
        {
    
            var path = "/v4/Users/BatchCreate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersCreateMultipleUsersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersCreateMultipleUsersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<UserBatchResponse>), response.Headers);
        }
    
        /// <summary>
        /// Creates a new application user 
        /// </summary>
        /// <param name="body">User to create</param>
        /// <returns>User</returns>
        public User UsersCreateUserAsync (User body)
        {
    
            var path = "/v4/Users";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersCreateUserAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersCreateUserAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (User) ApiClient.Deserialize(response.Content, typeof(User), response.Headers);
        }
    
        /// <summary>
        /// Removes a User Include &#x27;X-Force-Delete&#x27; header to force delete despite dependencies when given 50104 error
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        public void UsersDeleteAsync (int? id, bool? forceDelete)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersDeleteAsync");
    
            var path = "/v4/Users/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDeleteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDeleteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Processes multiple users to delete 
        /// </summary>
        /// <param name="body">User Ids to process</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns>List&lt;UserBatchResult&gt;</returns>
        public List<UserBatchResult> UsersDeleteMultipleUsersAsync (List<int?> body, bool? forceDelete)
        {
    
            var path = "/v4/Users/BatchDelete";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDeleteMultipleUsersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDeleteMultipleUsersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserBatchResult>) ApiClient.Deserialize(response.Content, typeof(List<UserBatchResult>), response.Headers);
        }
    
        /// <summary>
        /// Removes an application user photo 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <returns></returns>
        public void UsersDeletePhotoAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersDeletePhotoAsync");
    
            var path = "/v4/Users/{id}/Photo";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDeletePhotoAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDeletePhotoAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a preference for the given user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="name">Unique identifier of the UserPreference</param>
        /// <returns></returns>
        public void UsersDeleteUserPreferenceAsync (int? id, string name)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersDeleteUserPreferenceAsync");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling UsersDeleteUserPreferenceAsync");
    
            var path = "/v4/Users/{id}/Preferences/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDeleteUserPreferenceAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDeleteUserPreferenceAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Disable an event subscriber for this user 
        /// </summary>
        /// <param name="id">Unique identifier of the User to update</param>
        /// <param name="subscriberId">Unique ID of the event subscriber</param>
        /// <returns>EventSubscriberUser</returns>
        public EventSubscriberUser UsersDisableUserEventSubscriberAsync (int? id, int? subscriberId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersDisableUserEventSubscriberAsync");
            // verify the required parameter 'subscriberId' is set
            if (subscriberId == null) throw new ApiException(400, "Missing required parameter 'subscriberId' when calling UsersDisableUserEventSubscriberAsync");
    
            var path = "/v4/Users/{id}/Subscribers/{subscriberId}/Disable";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "subscriberId" + "}", ApiClient.ParameterToString(subscriberId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDisableUserEventSubscriberAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDisableUserEventSubscriberAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EventSubscriberUser) ApiClient.Deserialize(response.Content, typeof(EventSubscriberUser), response.Headers);
        }
    
        /// <summary>
        /// Enable an event subscriber for this user 
        /// </summary>
        /// <param name="id">Unique identifier of the User to update</param>
        /// <param name="subscriberId">Unique ID of the event subscriber</param>
        /// <returns>EventSubscriberUser</returns>
        public EventSubscriberUser UsersEnableUserEventSubscriberAsync (int? id, int? subscriberId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersEnableUserEventSubscriberAsync");
            // verify the required parameter 'subscriberId' is set
            if (subscriberId == null) throw new ApiException(400, "Missing required parameter 'subscriberId' when calling UsersEnableUserEventSubscriberAsync");
    
            var path = "/v4/Users/{id}/Subscribers/{subscriberId}/Enable";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "subscriberId" + "}", ApiClient.ParameterToString(subscriberId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersEnableUserEventSubscriberAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersEnableUserEventSubscriberAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EventSubscriberUser) ApiClient.Deserialize(response.Content, typeof(EventSubscriberUser), response.Headers);
        }
    
        /// <summary>
        /// Get policy accounts that have been linked to this user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyAccount&gt;</returns>
        public List<PolicyAccount> UsersGetLinkedAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersGetLinkedAccountsAsync");
    
            var path = "/v4/Users/{id}/LinkedPolicyAccounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetLinkedAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetLinkedAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyAccount>) ApiClient.Deserialize(response.Content, typeof(List<PolicyAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets the user&#x27;s photo 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <returns>UserPhoto</returns>
        public UserPhoto UsersGetPhotoAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersGetPhotoAsync");
    
            var path = "/v4/Users/{id}/Photo";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetPhotoAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetPhotoAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserPhoto) ApiClient.Deserialize(response.Content, typeof(UserPhoto), response.Headers);
        }
    
        /// <summary>
        /// Gets the user&#x27;s photo in raw format (64K max size) 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <returns>byte[]</returns>
        public byte[] UsersGetRawPhotoAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersGetRawPhotoAsync");
    
            var path = "/v4/Users/{id}/Photo/Raw";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetRawPhotoAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetRawPhotoAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Gets information about roles this user belongs to 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserRole&gt;</returns>
        public List<UserRole> UsersGetRolesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersGetRolesAsync");
    
            var path = "/v4/Users/{id}/Roles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetRolesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetRolesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserRole>) ApiClient.Deserialize(response.Content, typeof(List<UserRole>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single user 
        /// </summary>
        /// <param name="id">Unique ID of User</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>User</returns>
        public User UsersGetUserByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersGetUserByIdAsync");
    
            var path = "/v4/Users/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (User) ApiClient.Deserialize(response.Content, typeof(User), response.Headers);
        }
    
        /// <summary>
        /// Gets the user&#x27;s group memberships 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserGroup&gt;</returns>
        public List<UserGroup> UsersGetUserGroupsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersGetUserGroupsAsync");
    
            var path = "/v4/Users/{id}/UserGroups";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserGroupsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserGroupsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserGroup>) ApiClient.Deserialize(response.Content, typeof(List<UserGroup>), response.Headers);
        }
    
        /// <summary>
        /// Gets information about assets, partitions, accounts this user owns 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnership&gt;</returns>
        public List<UserOwnership> UsersGetUserOwnershipAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersGetUserOwnershipAsync");
    
            var path = "/v4/Users/{id}/Ownership";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserOwnershipAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserOwnershipAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserOwnership>) ApiClient.Deserialize(response.Content, typeof(List<UserOwnership>), response.Headers);
        }
    
        /// <summary>
        /// Gets information about partitions this user owns 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetPartition&gt;</returns>
        public List<AssetPartition> UsersGetUserPartitionsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersGetUserPartitionsAsync");
    
            var path = "/v4/Users/{id}/OwnedPartitions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserPartitionsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserPartitionsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetPartition>) ApiClient.Deserialize(response.Content, typeof(List<AssetPartition>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific preference for the given user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="name">Unique identifier of the UserPreference</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>UserPreference</returns>
        public UserPreference UsersGetUserPreferenceAsync (int? id, string name, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersGetUserPreferenceAsync");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling UsersGetUserPreferenceAsync");
    
            var path = "/v4/Users/{id}/Preferences/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserPreferenceAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserPreferenceAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserPreference) ApiClient.Deserialize(response.Content, typeof(UserPreference), response.Headers);
        }
    
        /// <summary>
        /// Gets all preferences for the given user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserPreference&gt;</returns>
        public List<UserPreference> UsersGetUserPreferencesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersGetUserPreferencesAsync");
    
            var path = "/v4/Users/{id}/Preferences";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserPreferencesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserPreferencesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserPreference>) ApiClient.Deserialize(response.Content, typeof(List<UserPreference>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single subscriber for this user 
        /// </summary>
        /// <param name="id">Unique ID of an User</param>
        /// <param name="subscriberId">Unique ID of the event subscriber</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>EventSubscriberUser</returns>
        public EventSubscriberUser UsersGetUserSubscriberByIdAsync (int? id, int? subscriberId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersGetUserSubscriberByIdAsync");
            // verify the required parameter 'subscriberId' is set
            if (subscriberId == null) throw new ApiException(400, "Missing required parameter 'subscriberId' when calling UsersGetUserSubscriberByIdAsync");
    
            var path = "/v4/Users/{id}/Subscribers/{subscriberId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "subscriberId" + "}", ApiClient.ParameterToString(subscriberId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserSubscriberByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserSubscriberByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EventSubscriberUser) ApiClient.Deserialize(response.Content, typeof(EventSubscriberUser), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of subscriptions for a user 
        /// </summary>
        /// <param name="id">Unique ID of the user</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;EventSubscriberUser&gt;</returns>
        public List<EventSubscriberUser> UsersGetUserSubscribersAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersGetUserSubscribersAsync");
    
            var path = "/v4/Users/{id}/Subscribers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserSubscribersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUserSubscribersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<EventSubscriberUser>) ApiClient.Deserialize(response.Content, typeof(List<EventSubscriberUser>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of users 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;User&gt;</returns>
        public List<User> UsersGetUsersAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Users";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUsersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetUsersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<User>) ApiClient.Deserialize(response.Content, typeof(List<User>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove user linked accounts 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">List of accounts to be linked</param>
        /// <returns>List&lt;PolicyAccount&gt;</returns>
        public List<PolicyAccount> UsersModifyLinkedAccountsAsync (int? id, ListOperation operation, List<PolicyAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersModifyLinkedAccountsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling UsersModifyLinkedAccountsAsync");
    
            var path = "/v4/Users/{id}/LinkedPolicyAccounts/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersModifyLinkedAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersModifyLinkedAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyAccount>) ApiClient.Deserialize(response.Content, typeof(List<PolicyAccount>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove roles a user should be assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Role to assign the User to</param>
        /// <returns>List&lt;UserRole&gt;</returns>
        public List<UserRole> UsersModifyRolesAsync (int? id, ListOperation operation, List<UserRole> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersModifyRolesAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling UsersModifyRolesAsync");
    
            var path = "/v4/Users/{id}/Roles/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersModifyRolesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersModifyRolesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserRole>) ApiClient.Deserialize(response.Content, typeof(List<UserRole>), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing application user&#x27;s photo in binary form 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="body"></param>
        /// <returns></returns>
        public void UsersPutRawPhotoAsync (int? id, PhotoRawBody1 body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersPutRawPhotoAsync");
    
            var path = "/v4/Users/{id}/Photo/Raw";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersPutRawPhotoAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersPutRawPhotoAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates set of accounts linked to this user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="body">List of accounts to be linked</param>
        /// <returns>List&lt;PolicyAccount&gt;</returns>
        public List<PolicyAccount> UsersSaveLinkedAccountsAsync (int? id, List<PolicyAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersSaveLinkedAccountsAsync");
    
            var path = "/v4/Users/{id}/LinkedPolicyAccounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersSaveLinkedAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersSaveLinkedAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyAccount>) ApiClient.Deserialize(response.Content, typeof(List<PolicyAccount>), response.Headers);
        }
    
        /// <summary>
        /// Sets the password of the local user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="body">Password to set for this user</param>
        /// <param name="changePasswordAtNextLogin">Force user to change password at next login</param>
        /// <returns>ValidationError</returns>
        public ValidationError UsersSetPasswordAsync (int? id, string body, bool? changePasswordAtNextLogin)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersSetPasswordAsync");
    
            var path = "/v4/Users/{id}/Password";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (changePasswordAtNextLogin != null) queryParams.Add("changePasswordAtNextLogin", ApiClient.ParameterToString(changePasswordAtNextLogin)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersSetPasswordAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersSetPasswordAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ValidationError) ApiClient.Deserialize(response.Content, typeof(ValidationError), response.Headers);
        }
    
        /// <summary>
        /// Specifies which roles a user should be assigned to explicitly 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="body">Roles to assign the User to</param>
        /// <returns>List&lt;UserRole&gt;</returns>
        public List<UserRole> UsersSetRolesAsync (int? id, List<UserRole> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersSetRolesAsync");
    
            var path = "/v4/Users/{id}/Roles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersSetRolesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersSetRolesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserRole>) ApiClient.Deserialize(response.Content, typeof(List<UserRole>), response.Headers);
        }
    
        /// <summary>
        /// Updates or create a preference for the given user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="name">Unique identifier of the UserPreference</param>
        /// <param name="body">Value to set for this preference</param>
        /// <returns>UserPreference</returns>
        public UserPreference UsersSetUserPreferenceAsync (int? id, string name, UserPreference body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersSetUserPreferenceAsync");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling UsersSetUserPreferenceAsync");
    
            var path = "/v4/Users/{id}/Preferences/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersSetUserPreferenceAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersSetUserPreferenceAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserPreference) ApiClient.Deserialize(response.Content, typeof(UserPreference), response.Headers);
        }
    
        /// <summary>
        /// Unlocks the specified user account 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <returns></returns>
        public void UsersUnlockAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersUnlockAsync");
    
            var path = "/v4/Users/{id}/Unlock";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersUnlockAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersUnlockAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Processes multiple users to update 
        /// </summary>
        /// <param name="body">Users to process</param>
        /// <returns>List&lt;UserBatchResponse&gt;</returns>
        public List<UserBatchResponse> UsersUpdateMultipleUsersAsync (List<User> body)
        {
    
            var path = "/v4/Users/BatchUpdate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersUpdateMultipleUsersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersUpdateMultipleUsersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<UserBatchResponse>), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing application user&#x27;s photo 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="body">Updated Photo (64K max size)</param>
        /// <returns></returns>
        public void UsersUpdatePhotoAsync (int? id, UserPhoto body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersUpdatePhotoAsync");
    
            var path = "/v4/Users/{id}/Photo";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersUpdatePhotoAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersUpdatePhotoAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates an existing application user 
        /// </summary>
        /// <param name="id">Unique identifier of the User</param>
        /// <param name="body">Updated User</param>
        /// <returns>User</returns>
        public User UsersUpdateUserAsync (int? id, User body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UsersUpdateUserAsync");
    
            var path = "/v4/Users/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersUpdateUserAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersUpdateUserAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (User) ApiClient.Deserialize(response.Content, typeof(User), response.Headers);
        }
    
        /// <summary>
        /// Validates that a password meets requirements 
        /// </summary>
        /// <param name="body">Password to validate</param>
        /// <returns>bool?</returns>
        public bool? UsersValidatePasswordAsync (string body)
        {
    
            var path = "/v4/Users/ValidatePassword";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersValidatePasswordAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersValidatePasswordAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
    }
}
