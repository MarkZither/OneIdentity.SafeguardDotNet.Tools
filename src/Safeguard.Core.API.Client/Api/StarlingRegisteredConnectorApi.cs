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
    public interface IStarlingRegisteredConnectorApi
    {
        /// <summary>
        /// Create a starling registered connector 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>StarlingRegisteredConnector</returns>
        StarlingRegisteredConnector StarlingRegisteredConnectorCreateStarlingRegisteredConnectorsAsync (StarlingRegisteredConnector body);
        /// <summary>
        /// Delete a starling registered connector 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void StarlingRegisteredConnectorDeleteStarlingRegisteredConnectorsAsync (int? id);
        /// <summary>
        /// Get a list of registered connectors from starling 
        /// </summary>
        /// <returns>List&lt;StarlingRegisteredConnectorFromStarling&gt;</returns>
        List<StarlingRegisteredConnectorFromStarling> StarlingRegisteredConnectorGetRegisteredConnectorsFromStarlingAsync ();
        /// <summary>
        /// Get a starling registered connector from safeguard 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>StarlingRegisteredConnector</returns>
        StarlingRegisteredConnector StarlingRegisteredConnectorGetStarlingRegisteredConnectorAsync (int? id);
        /// <summary>
        /// Get a list of starling registered connectors from safeguard 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;StarlingRegisteredConnector&gt;</returns>
        List<StarlingRegisteredConnector> StarlingRegisteredConnectorGetStarlingRegisteredConnectorsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// update a starling registered connector 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <returns>StarlingRegisteredConnector</returns>
        StarlingRegisteredConnector StarlingRegisteredConnectorUpdateStarlingRegisteredConnectorsAsync (int? id, StarlingRegisteredConnector body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StarlingRegisteredConnectorApi : IStarlingRegisteredConnectorApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StarlingRegisteredConnectorApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StarlingRegisteredConnectorApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StarlingRegisteredConnectorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StarlingRegisteredConnectorApi(String basePath)
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
        /// Create a starling registered connector 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>StarlingRegisteredConnector</returns>
        public StarlingRegisteredConnector StarlingRegisteredConnectorCreateStarlingRegisteredConnectorsAsync (StarlingRegisteredConnector body)
        {
    
            var path = "/v4/StarlingRegisteredConnector";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingRegisteredConnectorCreateStarlingRegisteredConnectorsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingRegisteredConnectorCreateStarlingRegisteredConnectorsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StarlingRegisteredConnector) ApiClient.Deserialize(response.Content, typeof(StarlingRegisteredConnector), response.Headers);
        }
    
        /// <summary>
        /// Delete a starling registered connector 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void StarlingRegisteredConnectorDeleteStarlingRegisteredConnectorsAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StarlingRegisteredConnectorDeleteStarlingRegisteredConnectorsAsync");
    
            var path = "/v4/StarlingRegisteredConnector/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingRegisteredConnectorDeleteStarlingRegisteredConnectorsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingRegisteredConnectorDeleteStarlingRegisteredConnectorsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a list of registered connectors from starling 
        /// </summary>
        /// <returns>List&lt;StarlingRegisteredConnectorFromStarling&gt;</returns>
        public List<StarlingRegisteredConnectorFromStarling> StarlingRegisteredConnectorGetRegisteredConnectorsFromStarlingAsync ()
        {
    
            var path = "/v4/StarlingRegisteredConnector/FromStarling";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingRegisteredConnectorGetRegisteredConnectorsFromStarlingAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingRegisteredConnectorGetRegisteredConnectorsFromStarlingAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<StarlingRegisteredConnectorFromStarling>) ApiClient.Deserialize(response.Content, typeof(List<StarlingRegisteredConnectorFromStarling>), response.Headers);
        }
    
        /// <summary>
        /// Get a starling registered connector from safeguard 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>StarlingRegisteredConnector</returns>
        public StarlingRegisteredConnector StarlingRegisteredConnectorGetStarlingRegisteredConnectorAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StarlingRegisteredConnectorGetStarlingRegisteredConnectorAsync");
    
            var path = "/v4/StarlingRegisteredConnector/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingRegisteredConnectorGetStarlingRegisteredConnectorAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingRegisteredConnectorGetStarlingRegisteredConnectorAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StarlingRegisteredConnector) ApiClient.Deserialize(response.Content, typeof(StarlingRegisteredConnector), response.Headers);
        }
    
        /// <summary>
        /// Get a list of starling registered connectors from safeguard 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;StarlingRegisteredConnector&gt;</returns>
        public List<StarlingRegisteredConnector> StarlingRegisteredConnectorGetStarlingRegisteredConnectorsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/StarlingRegisteredConnector";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingRegisteredConnectorGetStarlingRegisteredConnectorsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingRegisteredConnectorGetStarlingRegisteredConnectorsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<StarlingRegisteredConnector>) ApiClient.Deserialize(response.Content, typeof(List<StarlingRegisteredConnector>), response.Headers);
        }
    
        /// <summary>
        /// update a starling registered connector 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <returns>StarlingRegisteredConnector</returns>
        public StarlingRegisteredConnector StarlingRegisteredConnectorUpdateStarlingRegisteredConnectorsAsync (int? id, StarlingRegisteredConnector body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StarlingRegisteredConnectorUpdateStarlingRegisteredConnectorsAsync");
    
            var path = "/v4/StarlingRegisteredConnector/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingRegisteredConnectorUpdateStarlingRegisteredConnectorsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingRegisteredConnectorUpdateStarlingRegisteredConnectorsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StarlingRegisteredConnector) ApiClient.Deserialize(response.Content, typeof(StarlingRegisteredConnector), response.Headers);
        }
    
    }
}
