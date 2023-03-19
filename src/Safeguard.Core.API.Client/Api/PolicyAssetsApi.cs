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
    public interface IPolicyAssetsApi
    {
        /// <summary>
        /// Gets all asset groups that a specific asset belongs to 
        /// </summary>
        /// <param name="id">Unique identifier of the PolicyAsset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetGroup&gt;</returns>
        List<AssetGroup> PolicyAssetsGetAssetGroupsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of assets that can be assigned to a policy 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyAsset&gt;</returns>
        List<PolicyAsset> PolicyAssetsGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a policy asset 
        /// </summary>
        /// <param name="id">Unique ID of PolicyAsset</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PolicyAsset</returns>
        PolicyAsset PolicyAssetsGetByIdAsync (int? id, string fields);
        /// <summary>
        /// Searches the specified directory 
        /// </summary>
        /// <param name="id">Unique ID of an directory asset</param>
        /// <param name="searchBase">Sets the searchBase for the Ldap query, defaults to base of the domain for ldap, or base of  forest for AD.  Must be in DN Syntax.</param>
        /// <param name="searchScope">Defines the scope of the query, either base, one, or sub, defaults to sub.</param>
        /// <param name="searchType">Either User, Group, or Computer.  Defaults to User.</param>
        /// <param name="searchName">Sets a search constraint on the \&quot;name\&quot; of the object to return.</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DirectoryServiceEntry&gt;</returns>
        List<DirectoryServiceEntry> PolicyAssetsGetEntriesAsync (int? id, string searchBase, SearchScope searchScope, DirectorySearchType searchType, string searchName, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the policies that manage an asset belongs to 
        /// </summary>
        /// <param name="id">Unique identifier of the PolicyAsset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetPolicy&gt;</returns>
        List<AssetPolicy> PolicyAssetsGetPoliciesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PolicyAssetsApi : IPolicyAssetsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyAssetsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PolicyAssetsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyAssetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PolicyAssetsApi(String basePath)
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
        /// Gets all asset groups that a specific asset belongs to 
        /// </summary>
        /// <param name="id">Unique identifier of the PolicyAsset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetGroup&gt;</returns>
        public List<AssetGroup> PolicyAssetsGetAssetGroupsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PolicyAssetsGetAssetGroupsAsync");
    
            var path = "/v4/PolicyAssets/{id}/AssetGroups";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PolicyAssetsGetAssetGroupsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PolicyAssetsGetAssetGroupsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetGroup>) ApiClient.Deserialize(response.Content, typeof(List<AssetGroup>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of assets that can be assigned to a policy 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyAsset&gt;</returns>
        public List<PolicyAsset> PolicyAssetsGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/PolicyAssets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PolicyAssetsGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PolicyAssetsGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyAsset>) ApiClient.Deserialize(response.Content, typeof(List<PolicyAsset>), response.Headers);
        }
    
        /// <summary>
        /// Gets a policy asset 
        /// </summary>
        /// <param name="id">Unique ID of PolicyAsset</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PolicyAsset</returns>
        public PolicyAsset PolicyAssetsGetByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PolicyAssetsGetByIdAsync");
    
            var path = "/v4/PolicyAssets/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PolicyAssetsGetByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PolicyAssetsGetByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PolicyAsset) ApiClient.Deserialize(response.Content, typeof(PolicyAsset), response.Headers);
        }
    
        /// <summary>
        /// Searches the specified directory 
        /// </summary>
        /// <param name="id">Unique ID of an directory asset</param>
        /// <param name="searchBase">Sets the searchBase for the Ldap query, defaults to base of the domain for ldap, or base of  forest for AD.  Must be in DN Syntax.</param>
        /// <param name="searchScope">Defines the scope of the query, either base, one, or sub, defaults to sub.</param>
        /// <param name="searchType">Either User, Group, or Computer.  Defaults to User.</param>
        /// <param name="searchName">Sets a search constraint on the \&quot;name\&quot; of the object to return.</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DirectoryServiceEntry&gt;</returns>
        public List<DirectoryServiceEntry> PolicyAssetsGetEntriesAsync (int? id, string searchBase, SearchScope searchScope, DirectorySearchType searchType, string searchName, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PolicyAssetsGetEntriesAsync");
    
            var path = "/v4/PolicyAssets/{id}/DirectoryServiceEntries";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (searchBase != null) queryParams.Add("searchBase", ApiClient.ParameterToString(searchBase)); // query parameter
 if (searchScope != null) queryParams.Add("searchScope", ApiClient.ParameterToString(searchScope)); // query parameter
 if (searchType != null) queryParams.Add("searchType", ApiClient.ParameterToString(searchType)); // query parameter
 if (searchName != null) queryParams.Add("searchName", ApiClient.ParameterToString(searchName)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling PolicyAssetsGetEntriesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PolicyAssetsGetEntriesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DirectoryServiceEntry>) ApiClient.Deserialize(response.Content, typeof(List<DirectoryServiceEntry>), response.Headers);
        }
    
        /// <summary>
        /// Gets the policies that manage an asset belongs to 
        /// </summary>
        /// <param name="id">Unique identifier of the PolicyAsset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetPolicy&gt;</returns>
        public List<AssetPolicy> PolicyAssetsGetPoliciesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PolicyAssetsGetPoliciesAsync");
    
            var path = "/v4/PolicyAssets/{id}/Policies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PolicyAssetsGetPoliciesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PolicyAssetsGetPoliciesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetPolicy>) ApiClient.Deserialize(response.Content, typeof(List<AssetPolicy>), response.Headers);
        }
    
    }
}
