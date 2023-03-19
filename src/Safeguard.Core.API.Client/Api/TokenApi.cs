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
    public interface ITokenApi
    {
        /// <summary>
        /// After obtaining an access token from an STS, a client application must exchange that token for a Safeguard user              token that can then be used to access all API methods.  This method will attempt to authorize the user from the STS and              if successful, will return a new token value. 
        /// </summary>
        /// <param name="body">Currently, just the {access_token} from the OAuth2 protocol is needed.  In the future, other
        /// properties may be added.</param>
        /// <returns>LoginResponse</returns>
        LoginResponse TokenLoginResponseAsync (LoginResponseRequestData body);
        /// <summary>
        /// An explicit logout by an end user to have their Safeguard User Token deleted from the system such that it              cannot be used again. Call this method like any other API method that requires authorization.  Your token must currently be valid.              If your token has already expired or previously been deleted, an Http 401 response will be returned.
        /// </summary>
        /// <param name="timedOut">A value indicating whether the logout was due to inactivity or not. Defaults to false.</param>
        /// <returns></returns>
        void TokenLogoutAsync (bool? timedOut);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TokenApi : ITokenApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TokenApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TokenApi(String basePath)
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
        /// After obtaining an access token from an STS, a client application must exchange that token for a Safeguard user              token that can then be used to access all API methods.  This method will attempt to authorize the user from the STS and              if successful, will return a new token value. 
        /// </summary>
        /// <param name="body">Currently, just the {access_token} from the OAuth2 protocol is needed.  In the future, other
        /// properties may be added.</param>
        /// <returns>LoginResponse</returns>
        public LoginResponse TokenLoginResponseAsync (LoginResponseRequestData body)
        {
    
            var path = "/v4/Token/LoginResponse";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TokenLoginResponseAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TokenLoginResponseAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LoginResponse) ApiClient.Deserialize(response.Content, typeof(LoginResponse), response.Headers);
        }
    
        /// <summary>
        /// An explicit logout by an end user to have their Safeguard User Token deleted from the system such that it              cannot be used again. Call this method like any other API method that requires authorization.  Your token must currently be valid.              If your token has already expired or previously been deleted, an Http 401 response will be returned.
        /// </summary>
        /// <param name="timedOut">A value indicating whether the logout was due to inactivity or not. Defaults to false.</param>
        /// <returns></returns>
        public void TokenLogoutAsync (bool? timedOut)
        {
    
            var path = "/v4/Token/Logout";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (timedOut != null) queryParams.Add("timedOut", ApiClient.ParameterToString(timedOut)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TokenLogoutAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TokenLogoutAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
