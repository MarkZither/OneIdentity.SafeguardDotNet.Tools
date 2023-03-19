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
    public interface ILoginMessageApi
    {
        /// <summary>
        /// Gets the Login Message 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>LoginMessage</returns>
        LoginMessage LoginMessageGetAsync (string fields);
        /// <summary>
        /// Updates the Login Message 
        /// </summary>
        /// <param name="body">Updated Login Message</param>
        /// <returns>LoginMessage</returns>
        LoginMessage LoginMessageUpdateEntityAsync (LoginMessage body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LoginMessageApi : ILoginMessageApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginMessageApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LoginMessageApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginMessageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoginMessageApi(String basePath)
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
        /// Gets the Login Message 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>LoginMessage</returns>
        public LoginMessage LoginMessageGetAsync (string fields)
        {
    
            var path = "/v4/LoginMessage";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LoginMessageGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LoginMessageGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LoginMessage) ApiClient.Deserialize(response.Content, typeof(LoginMessage), response.Headers);
        }
    
        /// <summary>
        /// Updates the Login Message 
        /// </summary>
        /// <param name="body">Updated Login Message</param>
        /// <returns>LoginMessage</returns>
        public LoginMessage LoginMessageUpdateEntityAsync (LoginMessage body)
        {
    
            var path = "/v4/LoginMessage";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LoginMessageUpdateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LoginMessageUpdateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LoginMessage) ApiClient.Deserialize(response.Content, typeof(LoginMessage), response.Headers);
        }
    
    }
}
