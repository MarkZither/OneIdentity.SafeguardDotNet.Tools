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
    public interface IAccessPoliciesApi
    {
        /// <summary>
        /// Creates a new access policy 
        /// </summary>
        /// <param name="body">AccessPolicy to create</param>
        /// <returns>AccessPolicy</returns>
        AccessPolicy AccessPoliciesCreateAccessPolicyAsync (AccessPolicy body);
        /// <summary>
        /// Removes an access policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <returns></returns>
        void AccessPoliciesDeleteAsync (int? id);
        /// <summary>
        /// Gets a list of access policies 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessPolicy&gt;</returns>
        List<AccessPolicy> AccessPoliciesGetAccessPoliciesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets an access policy 
        /// </summary>
        /// <param name="id">Unique ID of AccessPolicy</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccessPolicy</returns>
        AccessPolicy AccessPoliciesGetAccessPolicyByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets the sets of identities that may approve access requests using this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ApproverSet&gt;</returns>
        List<ApproverSet> AccessPoliciesGetApproverSetsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all NotificationContacts configured for this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;NotificationContact&gt;</returns>
        List<NotificationContact> AccessPoliciesGetNotificationContactsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the reason codes assigned to this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ReasonCode&gt;</returns>
        List<ReasonCode> AccessPoliciesGetReasonCodesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the reviewers assigned to this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> AccessPoliciesGetReviewersAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the set of account groups that are explicitly assigned to this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyScopeItem&gt;</returns>
        List<PolicyScopeItem> AccessPoliciesGetScopeItemsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Add/Remove who can approve access requests for this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">sets of identities to assign as approvers</param>
        /// <returns>List&lt;ApproverSet&gt;</returns>
        List<ApproverSet> AccessPoliciesModifyApproverSetsAsync (int? id, ListOperation operation, List<ApproverSet> body);
        /// <summary>
        /// Add/Remove notification contacts associated with request events for this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Contacts to assign to this policy</param>
        /// <returns>List&lt;NotificationContact&gt;</returns>
        List<NotificationContact> AccessPoliciesModifyNotificationContactsAsync (int? id, ListOperation operation, List<NotificationContact> body);
        /// <summary>
        /// Add/Remove reason codes that may be used to make access requests managed by this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">ReasonCodes to assign to this policy</param>
        /// <returns>List&lt;ReasonCode&gt;</returns>
        List<ReasonCode> AccessPoliciesModifyReasonCodesAsync (int? id, ListOperation operation, List<ReasonCode> body);
        /// <summary>
        /// Add/Remove who can review access requests for this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Identities to assign as reviewers</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> AccessPoliciesModifyReviewersAsync (int? id, ListOperation operation, List<Identity> body);
        /// <summary>
        /// Add/remove accounts, assets, account groups, and asset groups that are explicitly assigned to this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">PolicyScopeItems to manage with this policy</param>
        /// <returns>List&lt;PolicyScopeItem&gt;</returns>
        List<PolicyScopeItem> AccessPoliciesModifyScopeItemsAsync (int? id, ListOperation operation, List<PolicyScopeItem> body);
        /// <summary>
        /// Sets who can approve access requests for this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="body">sets of identities to assign as approvers</param>
        /// <returns>List&lt;ApproverSet&gt;</returns>
        List<ApproverSet> AccessPoliciesSetApproverSetsAsync (int? id, List<ApproverSet> body);
        /// <summary>
        /// Sets the list of notification contacts associated with request events for this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="body">Contacts to assign to this policy</param>
        /// <returns>List&lt;NotificationContact&gt;</returns>
        List<NotificationContact> AccessPoliciesSetNotificationContactsAsync (int? id, List<NotificationContact> body);
        /// <summary>
        /// Sets the list of reason codes that may be used to make access requests managed by this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="body">ReasonCodes to assign to this policy</param>
        /// <returns>List&lt;ReasonCode&gt;</returns>
        List<ReasonCode> AccessPoliciesSetReasonCodeAsync (int? id, List<ReasonCode> body);
        /// <summary>
        /// Sets who can review access requests for this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="body">Identities to assign as reviewers</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> AccessPoliciesSetReviewersAsync (int? id, List<Identity> body);
        /// <summary>
        /// Sets the list of accounts, assets, account groups, and asset groups that are explicitly assigned to this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="body">PolicyScopeItems to manage with this policy</param>
        /// <returns>List&lt;PolicyScopeItem&gt;</returns>
        List<PolicyScopeItem> AccessPoliciesSetScopeItemsAsync (int? id, List<PolicyScopeItem> body);
        /// <summary>
        /// Updates an existing application access policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="body">Updated AccessPolicy</param>
        /// <returns>AccessPolicy</returns>
        AccessPolicy AccessPoliciesUpdateAccessPolicyAsync (int? id, AccessPolicy body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccessPoliciesApi : IAccessPoliciesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPoliciesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccessPoliciesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPoliciesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccessPoliciesApi(String basePath)
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
        /// Creates a new access policy 
        /// </summary>
        /// <param name="body">AccessPolicy to create</param>
        /// <returns>AccessPolicy</returns>
        public AccessPolicy AccessPoliciesCreateAccessPolicyAsync (AccessPolicy body)
        {
    
            var path = "/v4/AccessPolicies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesCreateAccessPolicyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesCreateAccessPolicyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessPolicy) ApiClient.Deserialize(response.Content, typeof(AccessPolicy), response.Headers);
        }
    
        /// <summary>
        /// Removes an access policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <returns></returns>
        public void AccessPoliciesDeleteAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesDeleteAsync");
    
            var path = "/v4/AccessPolicies/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesDeleteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesDeleteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a list of access policies 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessPolicy&gt;</returns>
        public List<AccessPolicy> AccessPoliciesGetAccessPoliciesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AccessPolicies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesGetAccessPoliciesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesGetAccessPoliciesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessPolicy>) ApiClient.Deserialize(response.Content, typeof(List<AccessPolicy>), response.Headers);
        }
    
        /// <summary>
        /// Gets an access policy 
        /// </summary>
        /// <param name="id">Unique ID of AccessPolicy</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccessPolicy</returns>
        public AccessPolicy AccessPoliciesGetAccessPolicyByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesGetAccessPolicyByIdAsync");
    
            var path = "/v4/AccessPolicies/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesGetAccessPolicyByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesGetAccessPolicyByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessPolicy) ApiClient.Deserialize(response.Content, typeof(AccessPolicy), response.Headers);
        }
    
        /// <summary>
        /// Gets the sets of identities that may approve access requests using this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ApproverSet&gt;</returns>
        public List<ApproverSet> AccessPoliciesGetApproverSetsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesGetApproverSetsAsync");
    
            var path = "/v4/AccessPolicies/{id}/ApproverSets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesGetApproverSetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesGetApproverSetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ApproverSet>) ApiClient.Deserialize(response.Content, typeof(List<ApproverSet>), response.Headers);
        }
    
        /// <summary>
        /// Gets all NotificationContacts configured for this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;NotificationContact&gt;</returns>
        public List<NotificationContact> AccessPoliciesGetNotificationContactsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesGetNotificationContactsAsync");
    
            var path = "/v4/AccessPolicies/{id}/NotificationContacts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesGetNotificationContactsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesGetNotificationContactsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NotificationContact>) ApiClient.Deserialize(response.Content, typeof(List<NotificationContact>), response.Headers);
        }
    
        /// <summary>
        /// Gets the reason codes assigned to this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ReasonCode&gt;</returns>
        public List<ReasonCode> AccessPoliciesGetReasonCodesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesGetReasonCodesAsync");
    
            var path = "/v4/AccessPolicies/{id}/ReasonCodes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesGetReasonCodesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesGetReasonCodesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ReasonCode>) ApiClient.Deserialize(response.Content, typeof(List<ReasonCode>), response.Headers);
        }
    
        /// <summary>
        /// Gets the reviewers assigned to this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> AccessPoliciesGetReviewersAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesGetReviewersAsync");
    
            var path = "/v4/AccessPolicies/{id}/Reviewers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesGetReviewersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesGetReviewersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Gets the set of account groups that are explicitly assigned to this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyScopeItem&gt;</returns>
        public List<PolicyScopeItem> AccessPoliciesGetScopeItemsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesGetScopeItemsAsync");
    
            var path = "/v4/AccessPolicies/{id}/ScopeItems";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesGetScopeItemsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesGetScopeItemsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyScopeItem>) ApiClient.Deserialize(response.Content, typeof(List<PolicyScopeItem>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove who can approve access requests for this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">sets of identities to assign as approvers</param>
        /// <returns>List&lt;ApproverSet&gt;</returns>
        public List<ApproverSet> AccessPoliciesModifyApproverSetsAsync (int? id, ListOperation operation, List<ApproverSet> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesModifyApproverSetsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AccessPoliciesModifyApproverSetsAsync");
    
            var path = "/v4/AccessPolicies/{id}/ApproverSets/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesModifyApproverSetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesModifyApproverSetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ApproverSet>) ApiClient.Deserialize(response.Content, typeof(List<ApproverSet>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove notification contacts associated with request events for this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Contacts to assign to this policy</param>
        /// <returns>List&lt;NotificationContact&gt;</returns>
        public List<NotificationContact> AccessPoliciesModifyNotificationContactsAsync (int? id, ListOperation operation, List<NotificationContact> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesModifyNotificationContactsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AccessPoliciesModifyNotificationContactsAsync");
    
            var path = "/v4/AccessPolicies/{id}/NotificationContacts/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesModifyNotificationContactsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesModifyNotificationContactsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NotificationContact>) ApiClient.Deserialize(response.Content, typeof(List<NotificationContact>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove reason codes that may be used to make access requests managed by this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">ReasonCodes to assign to this policy</param>
        /// <returns>List&lt;ReasonCode&gt;</returns>
        public List<ReasonCode> AccessPoliciesModifyReasonCodesAsync (int? id, ListOperation operation, List<ReasonCode> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesModifyReasonCodesAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AccessPoliciesModifyReasonCodesAsync");
    
            var path = "/v4/AccessPolicies/{id}/ReasonCodes/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesModifyReasonCodesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesModifyReasonCodesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ReasonCode>) ApiClient.Deserialize(response.Content, typeof(List<ReasonCode>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove who can review access requests for this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Identities to assign as reviewers</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> AccessPoliciesModifyReviewersAsync (int? id, ListOperation operation, List<Identity> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesModifyReviewersAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AccessPoliciesModifyReviewersAsync");
    
            var path = "/v4/AccessPolicies/{id}/Reviewers/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesModifyReviewersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesModifyReviewersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Add/remove accounts, assets, account groups, and asset groups that are explicitly assigned to this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">PolicyScopeItems to manage with this policy</param>
        /// <returns>List&lt;PolicyScopeItem&gt;</returns>
        public List<PolicyScopeItem> AccessPoliciesModifyScopeItemsAsync (int? id, ListOperation operation, List<PolicyScopeItem> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesModifyScopeItemsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AccessPoliciesModifyScopeItemsAsync");
    
            var path = "/v4/AccessPolicies/{id}/ScopeItems/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesModifyScopeItemsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesModifyScopeItemsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyScopeItem>) ApiClient.Deserialize(response.Content, typeof(List<PolicyScopeItem>), response.Headers);
        }
    
        /// <summary>
        /// Sets who can approve access requests for this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="body">sets of identities to assign as approvers</param>
        /// <returns>List&lt;ApproverSet&gt;</returns>
        public List<ApproverSet> AccessPoliciesSetApproverSetsAsync (int? id, List<ApproverSet> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesSetApproverSetsAsync");
    
            var path = "/v4/AccessPolicies/{id}/ApproverSets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesSetApproverSetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesSetApproverSetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ApproverSet>) ApiClient.Deserialize(response.Content, typeof(List<ApproverSet>), response.Headers);
        }
    
        /// <summary>
        /// Sets the list of notification contacts associated with request events for this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="body">Contacts to assign to this policy</param>
        /// <returns>List&lt;NotificationContact&gt;</returns>
        public List<NotificationContact> AccessPoliciesSetNotificationContactsAsync (int? id, List<NotificationContact> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesSetNotificationContactsAsync");
    
            var path = "/v4/AccessPolicies/{id}/NotificationContacts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesSetNotificationContactsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesSetNotificationContactsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NotificationContact>) ApiClient.Deserialize(response.Content, typeof(List<NotificationContact>), response.Headers);
        }
    
        /// <summary>
        /// Sets the list of reason codes that may be used to make access requests managed by this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="body">ReasonCodes to assign to this policy</param>
        /// <returns>List&lt;ReasonCode&gt;</returns>
        public List<ReasonCode> AccessPoliciesSetReasonCodeAsync (int? id, List<ReasonCode> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesSetReasonCodeAsync");
    
            var path = "/v4/AccessPolicies/{id}/ReasonCodes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesSetReasonCodeAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesSetReasonCodeAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ReasonCode>) ApiClient.Deserialize(response.Content, typeof(List<ReasonCode>), response.Headers);
        }
    
        /// <summary>
        /// Sets who can review access requests for this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="body">Identities to assign as reviewers</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> AccessPoliciesSetReviewersAsync (int? id, List<Identity> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesSetReviewersAsync");
    
            var path = "/v4/AccessPolicies/{id}/Reviewers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesSetReviewersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesSetReviewersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Sets the list of accounts, assets, account groups, and asset groups that are explicitly assigned to this policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="body">PolicyScopeItems to manage with this policy</param>
        /// <returns>List&lt;PolicyScopeItem&gt;</returns>
        public List<PolicyScopeItem> AccessPoliciesSetScopeItemsAsync (int? id, List<PolicyScopeItem> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesSetScopeItemsAsync");
    
            var path = "/v4/AccessPolicies/{id}/ScopeItems";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesSetScopeItemsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesSetScopeItemsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyScopeItem>) ApiClient.Deserialize(response.Content, typeof(List<PolicyScopeItem>), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing application access policy 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessPolicy</param>
        /// <param name="body">Updated AccessPolicy</param>
        /// <returns>AccessPolicy</returns>
        public AccessPolicy AccessPoliciesUpdateAccessPolicyAsync (int? id, AccessPolicy body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessPoliciesUpdateAccessPolicyAsync");
    
            var path = "/v4/AccessPolicies/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesUpdateAccessPolicyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessPoliciesUpdateAccessPolicyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessPolicy) ApiClient.Deserialize(response.Content, typeof(AccessPolicy), response.Headers);
        }
    
    }
}
