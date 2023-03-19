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
    public interface IServicesConfigApi
    {
        /// <summary>
        /// Gets the status of the services configuration 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ServicesConfig</returns>
        ServicesConfig ServicesConfigGetAsync (string fields);
        /// <summary>
        /// Gets the status of the specified services configuration 
        /// </summary>
        /// <param name="serviceName">Name of service to check if enabled</param>
        /// <returns>bool?</returns>
        bool? ServicesConfigGetServiceAsync (ServiceEnabled serviceName);
        /// <summary>
        /// Updates the services configuration 
        /// </summary>
        /// <param name="body">Updated ServicesConfig</param>
        /// <returns>ServicesConfig</returns>
        ServicesConfig ServicesConfigUpdateEntityAsync (ServicesConfig body);
        /// <summary>
        /// Updates the specified services configuration 
        /// </summary>
        /// <param name="serviceName">Name of service to set enabled</param>
        /// <param name="body">Whether service is enabled</param>
        /// <returns>bool?</returns>
        bool? ServicesConfigUpdateServiceAsync (ServiceEnabled serviceName, bool? body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ServicesConfigApi : IServicesConfigApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesConfigApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ServicesConfigApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesConfigApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServicesConfigApi(String basePath)
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
        /// Gets the status of the services configuration 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ServicesConfig</returns>
        public ServicesConfig ServicesConfigGetAsync (string fields)
        {
    
            var path = "/v4/ServicesConfig";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServicesConfigGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServicesConfigGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServicesConfig) ApiClient.Deserialize(response.Content, typeof(ServicesConfig), response.Headers);
        }
    
        /// <summary>
        /// Gets the status of the specified services configuration 
        /// </summary>
        /// <param name="serviceName">Name of service to check if enabled</param>
        /// <returns>bool?</returns>
        public bool? ServicesConfigGetServiceAsync (ServiceEnabled serviceName)
        {
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling ServicesConfigGetServiceAsync");
    
            var path = "/v4/ServicesConfig/{serviceName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServicesConfigGetServiceAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServicesConfigGetServiceAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
        /// <summary>
        /// Updates the services configuration 
        /// </summary>
        /// <param name="body">Updated ServicesConfig</param>
        /// <returns>ServicesConfig</returns>
        public ServicesConfig ServicesConfigUpdateEntityAsync (ServicesConfig body)
        {
    
            var path = "/v4/ServicesConfig";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServicesConfigUpdateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServicesConfigUpdateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServicesConfig) ApiClient.Deserialize(response.Content, typeof(ServicesConfig), response.Headers);
        }
    
        /// <summary>
        /// Updates the specified services configuration 
        /// </summary>
        /// <param name="serviceName">Name of service to set enabled</param>
        /// <param name="body">Whether service is enabled</param>
        /// <returns>bool?</returns>
        public bool? ServicesConfigUpdateServiceAsync (ServiceEnabled serviceName, bool? body)
        {
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling ServicesConfigUpdateServiceAsync");
    
            var path = "/v4/ServicesConfig/{serviceName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServicesConfigUpdateServiceAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServicesConfigUpdateServiceAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
    }
}
