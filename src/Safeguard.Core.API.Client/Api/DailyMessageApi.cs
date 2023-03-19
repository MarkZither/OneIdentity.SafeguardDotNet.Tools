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
    public interface IDailyMessageApi
    {
        /// <summary>
        /// Gets the Message of the Day 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>DailyMessage</returns>
        DailyMessage DailyMessageGetAsync (string fields);
        /// <summary>
        /// Updates the Message of the Day 
        /// </summary>
        /// <param name="body">Updated Message of the day</param>
        /// <returns>DailyMessage</returns>
        DailyMessage DailyMessageUpdateEntityAsync (DailyMessage body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DailyMessageApi : IDailyMessageApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DailyMessageApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DailyMessageApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DailyMessageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DailyMessageApi(String basePath)
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
        /// Gets the Message of the Day 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>DailyMessage</returns>
        public DailyMessage DailyMessageGetAsync (string fields)
        {
    
            var path = "/v4/DailyMessage";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DailyMessageGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DailyMessageGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DailyMessage) ApiClient.Deserialize(response.Content, typeof(DailyMessage), response.Headers);
        }
    
        /// <summary>
        /// Updates the Message of the Day 
        /// </summary>
        /// <param name="body">Updated Message of the day</param>
        /// <returns>DailyMessage</returns>
        public DailyMessage DailyMessageUpdateEntityAsync (DailyMessage body)
        {
    
            var path = "/v4/DailyMessage";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DailyMessageUpdateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DailyMessageUpdateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DailyMessage) ApiClient.Deserialize(response.Content, typeof(DailyMessage), response.Headers);
        }
    
    }
}
