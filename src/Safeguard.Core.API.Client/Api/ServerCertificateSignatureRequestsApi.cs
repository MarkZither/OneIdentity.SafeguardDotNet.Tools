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
    public interface IServerCertificateSignatureRequestsApi
    {
        /// <summary>
        /// Creates a new certificate signing request 
        /// </summary>
        /// <param name="body">ServerCertificateSignatureRequest to create</param>
        /// <returns>ServerCertificateSignatureRequest</returns>
        ServerCertificateSignatureRequest ServerCertificateSignatureRequestsCreateEntityAsync (ServerCertificateSignatureRequest body);
        /// <summary>
        /// Removes a certificate signing request 
        /// </summary>
        /// <param name="id">Unique identifier of the ServerCertificateSignatureRequest</param>
        /// <returns></returns>
        void ServerCertificateSignatureRequestsDeleteAsync (string id);
        /// <summary>
        /// Gets a queryable list of certificate signing requests 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ServerCertificateSignatureRequest&gt;</returns>
        List<ServerCertificateSignatureRequest> ServerCertificateSignatureRequestsGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a certificate signing request 
        /// </summary>
        /// <param name="id">Thumbprint of ServerCertificateSignatureRequest</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ServerCertificateSignatureRequest</returns>
        ServerCertificateSignatureRequest ServerCertificateSignatureRequestsGetByIdAsync (string id, string fields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ServerCertificateSignatureRequestsApi : IServerCertificateSignatureRequestsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerCertificateSignatureRequestsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ServerCertificateSignatureRequestsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerCertificateSignatureRequestsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServerCertificateSignatureRequestsApi(String basePath)
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
        /// Creates a new certificate signing request 
        /// </summary>
        /// <param name="body">ServerCertificateSignatureRequest to create</param>
        /// <returns>ServerCertificateSignatureRequest</returns>
        public ServerCertificateSignatureRequest ServerCertificateSignatureRequestsCreateEntityAsync (ServerCertificateSignatureRequest body)
        {
    
            var path = "/v4/ServerCertificateSignatureRequests";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServerCertificateSignatureRequestsCreateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServerCertificateSignatureRequestsCreateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServerCertificateSignatureRequest) ApiClient.Deserialize(response.Content, typeof(ServerCertificateSignatureRequest), response.Headers);
        }
    
        /// <summary>
        /// Removes a certificate signing request 
        /// </summary>
        /// <param name="id">Unique identifier of the ServerCertificateSignatureRequest</param>
        /// <returns></returns>
        public void ServerCertificateSignatureRequestsDeleteAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ServerCertificateSignatureRequestsDeleteAsync");
    
            var path = "/v4/ServerCertificateSignatureRequests/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServerCertificateSignatureRequestsDeleteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServerCertificateSignatureRequestsDeleteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a queryable list of certificate signing requests 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ServerCertificateSignatureRequest&gt;</returns>
        public List<ServerCertificateSignatureRequest> ServerCertificateSignatureRequestsGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/ServerCertificateSignatureRequests";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServerCertificateSignatureRequestsGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServerCertificateSignatureRequestsGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ServerCertificateSignatureRequest>) ApiClient.Deserialize(response.Content, typeof(List<ServerCertificateSignatureRequest>), response.Headers);
        }
    
        /// <summary>
        /// Gets a certificate signing request 
        /// </summary>
        /// <param name="id">Thumbprint of ServerCertificateSignatureRequest</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ServerCertificateSignatureRequest</returns>
        public ServerCertificateSignatureRequest ServerCertificateSignatureRequestsGetByIdAsync (string id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ServerCertificateSignatureRequestsGetByIdAsync");
    
            var path = "/v4/ServerCertificateSignatureRequests/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServerCertificateSignatureRequestsGetByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServerCertificateSignatureRequestsGetByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServerCertificateSignatureRequest) ApiClient.Deserialize(response.Content, typeof(ServerCertificateSignatureRequest), response.Headers);
        }
    
    }
}
