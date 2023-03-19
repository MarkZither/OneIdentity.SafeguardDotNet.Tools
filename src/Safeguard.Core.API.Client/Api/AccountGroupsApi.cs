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
    public interface IAccountGroupsApi
    {
        /// <summary>
        /// Checks if the current name is unique prior to create/update 
        /// </summary>
        /// <param name="body">Parameters for checking for unique name</param>
        /// <returns>bool?</returns>
        bool? AccountGroupsCheckUniqueNameAsync (UniqueNameParameters body);
        /// <summary>
        /// Creates an AccountGroup 
        /// </summary>
        /// <param name="body">AccountGroup to create</param>
        /// <returns>AccountGroup</returns>
        AccountGroup AccountGroupsCreateAccountGroupAsync (AccountGroup body);
        /// <summary>
        /// Processes multiple new account groups 
        /// </summary>
        /// <param name="body">New account groups to process</param>
        /// <returns>List&lt;AccountGroupBatchResponse&gt;</returns>
        List<AccountGroupBatchResponse> AccountGroupsCreateMultipleAsync (List<AccountGroup> body);
        /// <summary>
        /// Removes an AccountGroup 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        void AccountGroupsDeleteAsync (int? id, bool? forceDelete);
        /// <summary>
        /// Processes multiple account groups to delete 
        /// </summary>
        /// <param name="body">account groups to process</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns>List&lt;AccountGroupBatchResult&gt;</returns>
        List<AccountGroupBatchResult> AccountGroupsDeleteMultipleAsync (List<int?> body, bool? forceDelete);
        /// <summary>
        /// Gets a single account group 
        /// </summary>
        /// <param name="id">Unique ID of account group</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccountGroup</returns>
        AccountGroup AccountGroupsGetAccountGroupByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets a list of account group entities 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountGroup&gt;</returns>
        List<AccountGroup> AccountGroupsGetAccountGroupsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all PolicyAccounts that belong to an AccountGroup 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyAccount&gt;</returns>
        List<PolicyAccount> AccountGroupsGetAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets information about policies that this account group is assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;GroupPolicies&gt;</returns>
        List<GroupPolicies> AccountGroupsGetPoliciesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Add/Remove accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;PolicyAccount&gt;</returns>
        List<PolicyAccount> AccountGroupsModifyAccountsAsync (int? id, ListOperation operation, List<PolicyAccount> body);
        /// <summary>
        /// Add/Remove policies this group is assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup to update</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Policies to assign the AccountGroup to</param>
        /// <returns>List&lt;GroupPolicies&gt;</returns>
        List<GroupPolicies> AccountGroupsModifyPoliciesAsync (int? id, ListOperation operation, List<GroupPolicies> body);
        /// <summary>
        /// Sets the accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;PolicyAccount&gt;</returns>
        List<PolicyAccount> AccountGroupsSetAccountsAsync (int? id, List<PolicyAccount> body);
        /// <summary>
        /// Sets the policies this group is assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup to update</param>
        /// <param name="body">Policies to assign the AccountGroup to</param>
        /// <returns>List&lt;GroupPolicies&gt;</returns>
        List<GroupPolicies> AccountGroupsSetPoliciesAsync (int? id, List<GroupPolicies> body);
        /// <summary>
        /// Tests a dynamic grouping rule 
        /// </summary>
        /// <param name="body">Dynamic grouping rule to test</param>
        /// <param name="id">Unique ID of the account group</param>
        /// <param name="operationalOnly">Do not return no-op results</param>
        /// <param name="limit">Limit response to this number of results</param>
        /// <returns>List&lt;DynamicGroupingRuleTestResult&gt;</returns>
        List<DynamicGroupingRuleTestResult> AccountGroupsTestRuleAsync (TaggingGroupingRule body, int? id, bool? operationalOnly, int? limit);
        /// <summary>
        /// Updates an AccountGroup 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="body">Updated AccountGroup</param>
        /// <returns>AccountGroup</returns>
        AccountGroup AccountGroupsUpdateAccountGroupAsync (int? id, AccountGroup body);
        /// <summary>
        /// Processes multiple account groups to update 
        /// </summary>
        /// <param name="body">account groups to process</param>
        /// <returns>List&lt;AccountGroupBatchResponse&gt;</returns>
        List<AccountGroupBatchResponse> AccountGroupsUpdateMultipleAsync (List<AccountGroup> body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccountGroupsApi : IAccountGroupsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGroupsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccountGroupsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountGroupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountGroupsApi(String basePath)
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
        /// <param name="body">Parameters for checking for unique name</param>
        /// <returns>bool?</returns>
        public bool? AccountGroupsCheckUniqueNameAsync (UniqueNameParameters body)
        {
    
            var path = "/v4/AccountGroups/CheckUniqueName";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsCheckUniqueNameAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsCheckUniqueNameAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
        /// <summary>
        /// Creates an AccountGroup 
        /// </summary>
        /// <param name="body">AccountGroup to create</param>
        /// <returns>AccountGroup</returns>
        public AccountGroup AccountGroupsCreateAccountGroupAsync (AccountGroup body)
        {
    
            var path = "/v4/AccountGroups";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsCreateAccountGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsCreateAccountGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountGroup) ApiClient.Deserialize(response.Content, typeof(AccountGroup), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple new account groups 
        /// </summary>
        /// <param name="body">New account groups to process</param>
        /// <returns>List&lt;AccountGroupBatchResponse&gt;</returns>
        public List<AccountGroupBatchResponse> AccountGroupsCreateMultipleAsync (List<AccountGroup> body)
        {
    
            var path = "/v4/AccountGroups/BatchCreate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsCreateMultipleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsCreateMultipleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountGroupBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<AccountGroupBatchResponse>), response.Headers);
        }
    
        /// <summary>
        /// Removes an AccountGroup 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        public void AccountGroupsDeleteAsync (int? id, bool? forceDelete)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccountGroupsDeleteAsync");
    
            var path = "/v4/AccountGroups/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsDeleteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsDeleteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Processes multiple account groups to delete 
        /// </summary>
        /// <param name="body">account groups to process</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns>List&lt;AccountGroupBatchResult&gt;</returns>
        public List<AccountGroupBatchResult> AccountGroupsDeleteMultipleAsync (List<int?> body, bool? forceDelete)
        {
    
            var path = "/v4/AccountGroups/BatchDelete";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsDeleteMultipleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsDeleteMultipleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountGroupBatchResult>) ApiClient.Deserialize(response.Content, typeof(List<AccountGroupBatchResult>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single account group 
        /// </summary>
        /// <param name="id">Unique ID of account group</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccountGroup</returns>
        public AccountGroup AccountGroupsGetAccountGroupByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccountGroupsGetAccountGroupByIdAsync");
    
            var path = "/v4/AccountGroups/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsGetAccountGroupByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsGetAccountGroupByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountGroup) ApiClient.Deserialize(response.Content, typeof(AccountGroup), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of account group entities 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountGroup&gt;</returns>
        public List<AccountGroup> AccountGroupsGetAccountGroupsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AccountGroups";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsGetAccountGroupsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsGetAccountGroupsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountGroup>) ApiClient.Deserialize(response.Content, typeof(List<AccountGroup>), response.Headers);
        }
    
        /// <summary>
        /// Gets all PolicyAccounts that belong to an AccountGroup 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyAccount&gt;</returns>
        public List<PolicyAccount> AccountGroupsGetAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccountGroupsGetAccountsAsync");
    
            var path = "/v4/AccountGroups/{id}/Accounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsGetAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsGetAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyAccount>) ApiClient.Deserialize(response.Content, typeof(List<PolicyAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets information about policies that this account group is assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;GroupPolicies&gt;</returns>
        public List<GroupPolicies> AccountGroupsGetPoliciesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccountGroupsGetPoliciesAsync");
    
            var path = "/v4/AccountGroups/{id}/Policies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsGetPoliciesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsGetPoliciesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GroupPolicies>) ApiClient.Deserialize(response.Content, typeof(List<GroupPolicies>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;PolicyAccount&gt;</returns>
        public List<PolicyAccount> AccountGroupsModifyAccountsAsync (int? id, ListOperation operation, List<PolicyAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccountGroupsModifyAccountsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AccountGroupsModifyAccountsAsync");
    
            var path = "/v4/AccountGroups/{id}/Accounts/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsModifyAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsModifyAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyAccount>) ApiClient.Deserialize(response.Content, typeof(List<PolicyAccount>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove policies this group is assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup to update</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Policies to assign the AccountGroup to</param>
        /// <returns>List&lt;GroupPolicies&gt;</returns>
        public List<GroupPolicies> AccountGroupsModifyPoliciesAsync (int? id, ListOperation operation, List<GroupPolicies> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccountGroupsModifyPoliciesAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AccountGroupsModifyPoliciesAsync");
    
            var path = "/v4/AccountGroups/{id}/Policies/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsModifyPoliciesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsModifyPoliciesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GroupPolicies>) ApiClient.Deserialize(response.Content, typeof(List<GroupPolicies>), response.Headers);
        }
    
        /// <summary>
        /// Sets the accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;PolicyAccount&gt;</returns>
        public List<PolicyAccount> AccountGroupsSetAccountsAsync (int? id, List<PolicyAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccountGroupsSetAccountsAsync");
    
            var path = "/v4/AccountGroups/{id}/Accounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsSetAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsSetAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyAccount>) ApiClient.Deserialize(response.Content, typeof(List<PolicyAccount>), response.Headers);
        }
    
        /// <summary>
        /// Sets the policies this group is assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup to update</param>
        /// <param name="body">Policies to assign the AccountGroup to</param>
        /// <returns>List&lt;GroupPolicies&gt;</returns>
        public List<GroupPolicies> AccountGroupsSetPoliciesAsync (int? id, List<GroupPolicies> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccountGroupsSetPoliciesAsync");
    
            var path = "/v4/AccountGroups/{id}/Policies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsSetPoliciesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsSetPoliciesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<GroupPolicies>) ApiClient.Deserialize(response.Content, typeof(List<GroupPolicies>), response.Headers);
        }
    
        /// <summary>
        /// Tests a dynamic grouping rule 
        /// </summary>
        /// <param name="body">Dynamic grouping rule to test</param>
        /// <param name="id">Unique ID of the account group</param>
        /// <param name="operationalOnly">Do not return no-op results</param>
        /// <param name="limit">Limit response to this number of results</param>
        /// <returns>List&lt;DynamicGroupingRuleTestResult&gt;</returns>
        public List<DynamicGroupingRuleTestResult> AccountGroupsTestRuleAsync (TaggingGroupingRule body, int? id, bool? operationalOnly, int? limit)
        {
    
            var path = "/v4/AccountGroups/TestRule";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (operationalOnly != null) queryParams.Add("operationalOnly", ApiClient.ParameterToString(operationalOnly)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsTestRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsTestRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DynamicGroupingRuleTestResult>) ApiClient.Deserialize(response.Content, typeof(List<DynamicGroupingRuleTestResult>), response.Headers);
        }
    
        /// <summary>
        /// Updates an AccountGroup 
        /// </summary>
        /// <param name="id">Unique identifier of the AccountGroup</param>
        /// <param name="body">Updated AccountGroup</param>
        /// <returns>AccountGroup</returns>
        public AccountGroup AccountGroupsUpdateAccountGroupAsync (int? id, AccountGroup body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccountGroupsUpdateAccountGroupAsync");
    
            var path = "/v4/AccountGroups/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsUpdateAccountGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsUpdateAccountGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountGroup) ApiClient.Deserialize(response.Content, typeof(AccountGroup), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple account groups to update 
        /// </summary>
        /// <param name="body">account groups to process</param>
        /// <returns>List&lt;AccountGroupBatchResponse&gt;</returns>
        public List<AccountGroupBatchResponse> AccountGroupsUpdateMultipleAsync (List<AccountGroup> body)
        {
    
            var path = "/v4/AccountGroups/BatchUpdate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsUpdateMultipleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccountGroupsUpdateMultipleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountGroupBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<AccountGroupBatchResponse>), response.Headers);
        }
    
    }
}
