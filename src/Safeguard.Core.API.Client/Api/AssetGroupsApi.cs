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
    public interface IAssetGroupsApi
    {
        /// <summary>
        /// Creates an AssetGroup 
        /// </summary>
        /// <param name="body">AssetGroup to create</param>
        /// <returns>AssetGroup</returns>
        AssetGroup AssetGroupsCreateAssetGroupAsync (AssetGroup body);
        /// <summary>
        /// Processes multiple new asset groups 
        /// </summary>
        /// <param name="body">New asset groups to process</param>
        /// <returns>List&lt;AssetGroupBatchResponse&gt;</returns>
        List<AssetGroupBatchResponse> AssetGroupsCreateMultipleAsync (List<AssetGroup> body);
        /// <summary>
        /// Removes an AssetGroup 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        void AssetGroupsDeleteAsync (int? id, bool? forceDelete);
        /// <summary>
        /// Processes multiple asset groups to delete 
        /// </summary>
        /// <param name="body">asset groups to process</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns>List&lt;AssetGroupBatchResult&gt;</returns>
        List<AssetGroupBatchResult> AssetGroupsDeleteMultipleAsync (List<int?> body, bool? forceDelete);
        /// <summary>
        /// Gets a single asset group 
        /// </summary>
        /// <param name="id">Unique ID of asset group</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AssetGroup</returns>
        AssetGroup AssetGroupsGetAssetGroupByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets a list of asset group entities 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetGroup&gt;</returns>
        List<AssetGroup> AssetGroupsGetAssetGroupsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all PolicyAssets that belong to an AssetGroup 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyAsset&gt;</returns>
        List<PolicyAsset> AssetGroupsGetAssetsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets information about policies that this asset group is assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetGroupPolicy&gt;</returns>
        List<AssetGroupPolicy> AssetGroupsGetPoliciesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Add/Remove assets assigned to this group 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Assets to assign to the AssetGroup</param>
        /// <returns>List&lt;PolicyAsset&gt;</returns>
        List<PolicyAsset> AssetGroupsModifyAssetsAsync (int? id, ListOperation operation, List<PolicyAsset> body);
        /// <summary>
        /// Sets the policies this group is assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup to update</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Policies to assign the AssetGroup to</param>
        /// <returns>List&lt;AssetGroupPolicy&gt;</returns>
        List<AssetGroupPolicy> AssetGroupsModifyPoliciesAsync (int? id, ListOperation operation, List<AssetGroupPolicy> body);
        /// <summary>
        /// Sets the assets assigned to this group 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup</param>
        /// <param name="body">Assets to assign to the AssetGroup</param>
        /// <returns>List&lt;PolicyAsset&gt;</returns>
        List<PolicyAsset> AssetGroupsSetAssetsAsync (int? id, List<PolicyAsset> body);
        /// <summary>
        /// Sets the policies this group is assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup to update</param>
        /// <param name="body">Policies to assign the AssetGroup to</param>
        /// <returns>List&lt;AssetGroupPolicy&gt;</returns>
        List<AssetGroupPolicy> AssetGroupsSetPoliciesAsync (int? id, List<AssetGroupPolicy> body);
        /// <summary>
        /// Tests a dynamic grouping rule 
        /// </summary>
        /// <param name="body">Dynamic grouping rule to test</param>
        /// <param name="id">Unique identifier of the asset group</param>
        /// <param name="operationalOnly">Do not return no-op results</param>
        /// <param name="limit">Limit response to this number of results, default 200</param>
        /// <returns>List&lt;DynamicGroupingRuleTestResult&gt;</returns>
        List<DynamicGroupingRuleTestResult> AssetGroupsTestRuleAsync (TaggingGroupingRule body, int? id, bool? operationalOnly, int? limit);
        /// <summary>
        /// Updates an AssetGroup 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup</param>
        /// <param name="body">Updated AssetGroup</param>
        /// <returns>AssetGroup</returns>
        AssetGroup AssetGroupsUpdateAssetGroupAsync (int? id, AssetGroup body);
        /// <summary>
        /// Processes multiple asset groups to update 
        /// </summary>
        /// <param name="body">asset groups to process</param>
        /// <returns>List&lt;AssetGroupBatchResponse&gt;</returns>
        List<AssetGroupBatchResponse> AssetGroupsUpdateMultipleAsync (List<AssetGroup> body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AssetGroupsApi : IAssetGroupsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetGroupsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AssetGroupsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetGroupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AssetGroupsApi(String basePath)
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
        /// Creates an AssetGroup 
        /// </summary>
        /// <param name="body">AssetGroup to create</param>
        /// <returns>AssetGroup</returns>
        public AssetGroup AssetGroupsCreateAssetGroupAsync (AssetGroup body)
        {
    
            var path = "/v4/AssetGroups";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsCreateAssetGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsCreateAssetGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetGroup) ApiClient.Deserialize(response.Content, typeof(AssetGroup), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple new asset groups 
        /// </summary>
        /// <param name="body">New asset groups to process</param>
        /// <returns>List&lt;AssetGroupBatchResponse&gt;</returns>
        public List<AssetGroupBatchResponse> AssetGroupsCreateMultipleAsync (List<AssetGroup> body)
        {
    
            var path = "/v4/AssetGroups/BatchCreate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsCreateMultipleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsCreateMultipleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetGroupBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<AssetGroupBatchResponse>), response.Headers);
        }
    
        /// <summary>
        /// Removes an AssetGroup 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        public void AssetGroupsDeleteAsync (int? id, bool? forceDelete)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetGroupsDeleteAsync");
    
            var path = "/v4/AssetGroups/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsDeleteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsDeleteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Processes multiple asset groups to delete 
        /// </summary>
        /// <param name="body">asset groups to process</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns>List&lt;AssetGroupBatchResult&gt;</returns>
        public List<AssetGroupBatchResult> AssetGroupsDeleteMultipleAsync (List<int?> body, bool? forceDelete)
        {
    
            var path = "/v4/AssetGroups/BatchDelete";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsDeleteMultipleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsDeleteMultipleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetGroupBatchResult>) ApiClient.Deserialize(response.Content, typeof(List<AssetGroupBatchResult>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single asset group 
        /// </summary>
        /// <param name="id">Unique ID of asset group</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AssetGroup</returns>
        public AssetGroup AssetGroupsGetAssetGroupByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetGroupsGetAssetGroupByIdAsync");
    
            var path = "/v4/AssetGroups/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsGetAssetGroupByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsGetAssetGroupByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetGroup) ApiClient.Deserialize(response.Content, typeof(AssetGroup), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of asset group entities 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetGroup&gt;</returns>
        public List<AssetGroup> AssetGroupsGetAssetGroupsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetGroups";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsGetAssetGroupsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsGetAssetGroupsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetGroup>) ApiClient.Deserialize(response.Content, typeof(List<AssetGroup>), response.Headers);
        }
    
        /// <summary>
        /// Gets all PolicyAssets that belong to an AssetGroup 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyAsset&gt;</returns>
        public List<PolicyAsset> AssetGroupsGetAssetsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetGroupsGetAssetsAsync");
    
            var path = "/v4/AssetGroups/{id}/Assets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsGetAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsGetAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyAsset>) ApiClient.Deserialize(response.Content, typeof(List<PolicyAsset>), response.Headers);
        }
    
        /// <summary>
        /// Gets information about policies that this asset group is assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetGroupPolicy&gt;</returns>
        public List<AssetGroupPolicy> AssetGroupsGetPoliciesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetGroupsGetPoliciesAsync");
    
            var path = "/v4/AssetGroups/{id}/Policies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsGetPoliciesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsGetPoliciesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetGroupPolicy>) ApiClient.Deserialize(response.Content, typeof(List<AssetGroupPolicy>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove assets assigned to this group 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Assets to assign to the AssetGroup</param>
        /// <returns>List&lt;PolicyAsset&gt;</returns>
        public List<PolicyAsset> AssetGroupsModifyAssetsAsync (int? id, ListOperation operation, List<PolicyAsset> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetGroupsModifyAssetsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetGroupsModifyAssetsAsync");
    
            var path = "/v4/AssetGroups/{id}/Assets/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsModifyAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsModifyAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyAsset>) ApiClient.Deserialize(response.Content, typeof(List<PolicyAsset>), response.Headers);
        }
    
        /// <summary>
        /// Sets the policies this group is assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup to update</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Policies to assign the AssetGroup to</param>
        /// <returns>List&lt;AssetGroupPolicy&gt;</returns>
        public List<AssetGroupPolicy> AssetGroupsModifyPoliciesAsync (int? id, ListOperation operation, List<AssetGroupPolicy> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetGroupsModifyPoliciesAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetGroupsModifyPoliciesAsync");
    
            var path = "/v4/AssetGroups/{id}/Policies/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsModifyPoliciesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsModifyPoliciesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetGroupPolicy>) ApiClient.Deserialize(response.Content, typeof(List<AssetGroupPolicy>), response.Headers);
        }
    
        /// <summary>
        /// Sets the assets assigned to this group 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup</param>
        /// <param name="body">Assets to assign to the AssetGroup</param>
        /// <returns>List&lt;PolicyAsset&gt;</returns>
        public List<PolicyAsset> AssetGroupsSetAssetsAsync (int? id, List<PolicyAsset> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetGroupsSetAssetsAsync");
    
            var path = "/v4/AssetGroups/{id}/Assets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsSetAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsSetAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyAsset>) ApiClient.Deserialize(response.Content, typeof(List<PolicyAsset>), response.Headers);
        }
    
        /// <summary>
        /// Sets the policies this group is assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup to update</param>
        /// <param name="body">Policies to assign the AssetGroup to</param>
        /// <returns>List&lt;AssetGroupPolicy&gt;</returns>
        public List<AssetGroupPolicy> AssetGroupsSetPoliciesAsync (int? id, List<AssetGroupPolicy> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetGroupsSetPoliciesAsync");
    
            var path = "/v4/AssetGroups/{id}/Policies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsSetPoliciesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsSetPoliciesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetGroupPolicy>) ApiClient.Deserialize(response.Content, typeof(List<AssetGroupPolicy>), response.Headers);
        }
    
        /// <summary>
        /// Tests a dynamic grouping rule 
        /// </summary>
        /// <param name="body">Dynamic grouping rule to test</param>
        /// <param name="id">Unique identifier of the asset group</param>
        /// <param name="operationalOnly">Do not return no-op results</param>
        /// <param name="limit">Limit response to this number of results, default 200</param>
        /// <returns>List&lt;DynamicGroupingRuleTestResult&gt;</returns>
        public List<DynamicGroupingRuleTestResult> AssetGroupsTestRuleAsync (TaggingGroupingRule body, int? id, bool? operationalOnly, int? limit)
        {
    
            var path = "/v4/AssetGroups/TestAssetRule";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsTestRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsTestRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DynamicGroupingRuleTestResult>) ApiClient.Deserialize(response.Content, typeof(List<DynamicGroupingRuleTestResult>), response.Headers);
        }
    
        /// <summary>
        /// Updates an AssetGroup 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetGroup</param>
        /// <param name="body">Updated AssetGroup</param>
        /// <returns>AssetGroup</returns>
        public AssetGroup AssetGroupsUpdateAssetGroupAsync (int? id, AssetGroup body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetGroupsUpdateAssetGroupAsync");
    
            var path = "/v4/AssetGroups/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsUpdateAssetGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsUpdateAssetGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetGroup) ApiClient.Deserialize(response.Content, typeof(AssetGroup), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple asset groups to update 
        /// </summary>
        /// <param name="body">asset groups to process</param>
        /// <returns>List&lt;AssetGroupBatchResponse&gt;</returns>
        public List<AssetGroupBatchResponse> AssetGroupsUpdateMultipleAsync (List<AssetGroup> body)
        {
    
            var path = "/v4/AssetGroups/BatchUpdate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsUpdateMultipleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetGroupsUpdateMultipleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetGroupBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<AssetGroupBatchResponse>), response.Headers);
        }
    
    }
}
