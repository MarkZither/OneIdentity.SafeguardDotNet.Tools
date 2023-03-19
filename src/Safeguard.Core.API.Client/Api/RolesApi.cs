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
    public interface IRolesApi
    {
        /// <summary>
        /// Checks if the current name is unique prior to create/update 
        /// </summary>
        /// <param name="id">Unique identifier of the role</param>
        /// <param name="body">Parameters for checking for unique name</param>
        /// <returns>bool?</returns>
        bool? RolesCheckUniquePolicyNameAsync (int? id, UniqueNameParameters body);
        /// <summary>
        /// Creates a new role 
        /// </summary>
        /// <param name="body">Role to create</param>
        /// <returns>Role</returns>
        Role RolesCreateEntityAsync (Role body);
        /// <summary>
        /// Removes an application role 
        /// </summary>
        /// <param name="id">Unique identifier of the Role</param>
        /// <returns></returns>
        void RolesDeleteAsync (int? id);
        /// <summary>
        /// Gets a list of roles 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Role&gt;</returns>
        List<Role> RolesGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a role 
        /// </summary>
        /// <param name="id">Unique ID of Role</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Role</returns>
        Role RolesGetByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets the membership included in the role 
        /// </summary>
        /// <param name="id">Unique identifier of the Role</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> RolesGetMembersAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the policies of the role 
        /// </summary>
        /// <param name="id">Unique identifier of the Role</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessPolicy&gt;</returns>
        List<AccessPolicy> RolesGetPasswordPoliciesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the policy priorities assigned to this role 
        /// </summary>
        /// <param name="id">Unique identifier of the Role</param>
        /// <returns>List&lt;Priority&gt;</returns>
        List<Priority> RolesGetPolicyPrioritiesAsync (int? id);
        /// <summary>
        /// Gets the role priorities 
        /// </summary>
        /// <returns>List&lt;Priority&gt;</returns>
        List<Priority> RolesGetRolePrioritiesAsync ();
        /// <summary>
        /// Add/Remove accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> RolesModifyMembersAsync (int? id, ListOperation operation, List<Identity> body);
        /// <summary>
        /// Sets the accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> RolesSetMembersAsync (int? id, List<Identity> body);
        /// <summary>
        /// Sets the priorities of a list of policies for a given role. All policies belonging to the specified role must  be included. 
        /// </summary>
        /// <param name="id">Unique identifier of the role</param>
        /// <param name="body">Set the priorities of the policies in the specified role</param>
        /// <returns>List&lt;Priority&gt;</returns>
        List<Priority> RolesSetPolicyPrioritiesAsync (int? id, List<Priority> body);
        /// <summary>
        /// Updates all role priorities. All roles must be included. 
        /// </summary>
        /// <param name="body">Priorities of all roles</param>
        /// <returns>List&lt;Priority&gt;</returns>
        List<Priority> RolesSetRolePrioritiesAsync (List<Priority> body);
        /// <summary>
        /// Updates an existing application role 
        /// </summary>
        /// <param name="id">Unique identifier of the Role</param>
        /// <param name="body">Updated Role</param>
        /// <returns>Role</returns>
        Role RolesUpdateEntityAsync (int? id, Role body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RolesApi : IRolesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RolesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RolesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RolesApi(String basePath)
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
        /// Checks if the current name is unique prior to create/update 
        /// </summary>
        /// <param name="id">Unique identifier of the role</param>
        /// <param name="body">Parameters for checking for unique name</param>
        /// <returns>bool?</returns>
        public bool? RolesCheckUniquePolicyNameAsync (int? id, UniqueNameParameters body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RolesCheckUniquePolicyNameAsync");
    
            var path = "/v4/Roles/{id}/CheckUniquePolicyName";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesCheckUniquePolicyNameAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesCheckUniquePolicyNameAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
        /// <summary>
        /// Creates a new role 
        /// </summary>
        /// <param name="body">Role to create</param>
        /// <returns>Role</returns>
        public Role RolesCreateEntityAsync (Role body)
        {
    
            var path = "/v4/Roles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RolesCreateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesCreateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Role) ApiClient.Deserialize(response.Content, typeof(Role), response.Headers);
        }
    
        /// <summary>
        /// Removes an application role 
        /// </summary>
        /// <param name="id">Unique identifier of the Role</param>
        /// <returns></returns>
        public void RolesDeleteAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RolesDeleteAsync");
    
            var path = "/v4/Roles/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RolesDeleteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesDeleteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a list of roles 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Role&gt;</returns>
        public List<Role> RolesGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Roles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RolesGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Role>) ApiClient.Deserialize(response.Content, typeof(List<Role>), response.Headers);
        }
    
        /// <summary>
        /// Gets a role 
        /// </summary>
        /// <param name="id">Unique ID of Role</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Role</returns>
        public Role RolesGetByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RolesGetByIdAsync");
    
            var path = "/v4/Roles/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RolesGetByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesGetByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Role) ApiClient.Deserialize(response.Content, typeof(Role), response.Headers);
        }
    
        /// <summary>
        /// Gets the membership included in the role 
        /// </summary>
        /// <param name="id">Unique identifier of the Role</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> RolesGetMembersAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RolesGetMembersAsync");
    
            var path = "/v4/Roles/{id}/Members";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RolesGetMembersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesGetMembersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Gets the policies of the role 
        /// </summary>
        /// <param name="id">Unique identifier of the Role</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessPolicy&gt;</returns>
        public List<AccessPolicy> RolesGetPasswordPoliciesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RolesGetPasswordPoliciesAsync");
    
            var path = "/v4/Roles/{id}/Policies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RolesGetPasswordPoliciesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesGetPasswordPoliciesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessPolicy>) ApiClient.Deserialize(response.Content, typeof(List<AccessPolicy>), response.Headers);
        }
    
        /// <summary>
        /// Gets the policy priorities assigned to this role 
        /// </summary>
        /// <param name="id">Unique identifier of the Role</param>
        /// <returns>List&lt;Priority&gt;</returns>
        public List<Priority> RolesGetPolicyPrioritiesAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RolesGetPolicyPrioritiesAsync");
    
            var path = "/v4/Roles/{id}/PolicyPriorities";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RolesGetPolicyPrioritiesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesGetPolicyPrioritiesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Priority>) ApiClient.Deserialize(response.Content, typeof(List<Priority>), response.Headers);
        }
    
        /// <summary>
        /// Gets the role priorities 
        /// </summary>
        /// <returns>List&lt;Priority&gt;</returns>
        public List<Priority> RolesGetRolePrioritiesAsync ()
        {
    
            var path = "/v4/Roles/Priorities";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling RolesGetRolePrioritiesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesGetRolePrioritiesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Priority>) ApiClient.Deserialize(response.Content, typeof(List<Priority>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> RolesModifyMembersAsync (int? id, ListOperation operation, List<Identity> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RolesModifyMembersAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling RolesModifyMembersAsync");
    
            var path = "/v4/Roles/{id}/Members/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RolesModifyMembersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesModifyMembersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Sets the accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> RolesSetMembersAsync (int? id, List<Identity> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RolesSetMembersAsync");
    
            var path = "/v4/Roles/{id}/Members";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RolesSetMembersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesSetMembersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Sets the priorities of a list of policies for a given role. All policies belonging to the specified role must  be included. 
        /// </summary>
        /// <param name="id">Unique identifier of the role</param>
        /// <param name="body">Set the priorities of the policies in the specified role</param>
        /// <returns>List&lt;Priority&gt;</returns>
        public List<Priority> RolesSetPolicyPrioritiesAsync (int? id, List<Priority> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RolesSetPolicyPrioritiesAsync");
    
            var path = "/v4/Roles/{id}/PolicyPriorities";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RolesSetPolicyPrioritiesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesSetPolicyPrioritiesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Priority>) ApiClient.Deserialize(response.Content, typeof(List<Priority>), response.Headers);
        }
    
        /// <summary>
        /// Updates all role priorities. All roles must be included. 
        /// </summary>
        /// <param name="body">Priorities of all roles</param>
        /// <returns>List&lt;Priority&gt;</returns>
        public List<Priority> RolesSetRolePrioritiesAsync (List<Priority> body)
        {
    
            var path = "/v4/Roles/Priorities";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesSetRolePrioritiesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesSetRolePrioritiesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Priority>) ApiClient.Deserialize(response.Content, typeof(List<Priority>), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing application role 
        /// </summary>
        /// <param name="id">Unique identifier of the Role</param>
        /// <param name="body">Updated Role</param>
        /// <returns>Role</returns>
        public Role RolesUpdateEntityAsync (int? id, Role body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RolesUpdateEntityAsync");
    
            var path = "/v4/Roles/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RolesUpdateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RolesUpdateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Role) ApiClient.Deserialize(response.Content, typeof(Role), response.Headers);
        }
    
    }
}
