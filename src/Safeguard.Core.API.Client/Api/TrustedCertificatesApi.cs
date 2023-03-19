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
    public interface ITrustedCertificatesApi
    {
        /// <summary>
        /// Installs a new certificate authority certificate chain 
        /// </summary>
        /// <param name="body">Base-64 encoded DER data for certificate chain</param>
        /// <returns>List&lt;ServerCertificate&gt;</returns>
        List<ServerCertificate> TrustedCertificatesAddCertChainAsync (string body);
        /// <summary>
        /// Installs a new certificate authority certificate 
        /// </summary>
        /// <param name="body">ServerCertificate to create</param>
        /// <returns>ServerCertificate</returns>
        ServerCertificate TrustedCertificatesCreateEntityAsync (ServerCertificate body);
        /// <summary>
        /// Removes a trusted certificate 
        /// </summary>
        /// <param name="id">Unique identifier of the ServerCertificate</param>
        /// <returns></returns>
        void TrustedCertificatesDeleteAsync (string id);
        /// <summary>
        /// Gets a queryable list of trusted certificates 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ServerCertificate&gt;</returns>
        List<ServerCertificate> TrustedCertificatesGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a trusted certificate 
        /// </summary>
        /// <param name="id">Unique ID of ServerCertificate</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ServerCertificate</returns>
        ServerCertificate TrustedCertificatesGetByIdAsync (string id, string fields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TrustedCertificatesApi : ITrustedCertificatesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustedCertificatesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TrustedCertificatesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustedCertificatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TrustedCertificatesApi(String basePath)
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
        /// Installs a new certificate authority certificate chain 
        /// </summary>
        /// <param name="body">Base-64 encoded DER data for certificate chain</param>
        /// <returns>List&lt;ServerCertificate&gt;</returns>
        public List<ServerCertificate> TrustedCertificatesAddCertChainAsync (string body)
        {
    
            var path = "/v4/TrustedCertificates/Chain";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TrustedCertificatesAddCertChainAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrustedCertificatesAddCertChainAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ServerCertificate>) ApiClient.Deserialize(response.Content, typeof(List<ServerCertificate>), response.Headers);
        }
    
        /// <summary>
        /// Installs a new certificate authority certificate 
        /// </summary>
        /// <param name="body">ServerCertificate to create</param>
        /// <returns>ServerCertificate</returns>
        public ServerCertificate TrustedCertificatesCreateEntityAsync (ServerCertificate body)
        {
    
            var path = "/v4/TrustedCertificates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TrustedCertificatesCreateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrustedCertificatesCreateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServerCertificate) ApiClient.Deserialize(response.Content, typeof(ServerCertificate), response.Headers);
        }
    
        /// <summary>
        /// Removes a trusted certificate 
        /// </summary>
        /// <param name="id">Unique identifier of the ServerCertificate</param>
        /// <returns></returns>
        public void TrustedCertificatesDeleteAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TrustedCertificatesDeleteAsync");
    
            var path = "/v4/TrustedCertificates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TrustedCertificatesDeleteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrustedCertificatesDeleteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a queryable list of trusted certificates 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ServerCertificate&gt;</returns>
        public List<ServerCertificate> TrustedCertificatesGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/TrustedCertificates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TrustedCertificatesGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrustedCertificatesGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ServerCertificate>) ApiClient.Deserialize(response.Content, typeof(List<ServerCertificate>), response.Headers);
        }
    
        /// <summary>
        /// Gets a trusted certificate 
        /// </summary>
        /// <param name="id">Unique ID of ServerCertificate</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ServerCertificate</returns>
        public ServerCertificate TrustedCertificatesGetByIdAsync (string id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TrustedCertificatesGetByIdAsync");
    
            var path = "/v4/TrustedCertificates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TrustedCertificatesGetByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrustedCertificatesGetByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServerCertificate) ApiClient.Deserialize(response.Content, typeof(ServerCertificate), response.Headers);
        }
    
    }
}
