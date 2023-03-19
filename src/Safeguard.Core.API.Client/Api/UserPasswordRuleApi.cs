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
    public interface IUserPasswordRuleApi
    {
        /// <summary>
        /// Generates a random password using this rule 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>string</returns>
        string UserPasswordRuleGeneratePasswordAsync (UserPasswordRule body);
        /// <summary>
        /// Gets the user password rule 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>UserPasswordRule</returns>
        UserPasswordRule UserPasswordRuleGetUserPasswordRuleAsync (string fields);
        /// <summary>
        /// Updates the user password rule 
        /// </summary>
        /// <param name="body">Updated PasswordRule</param>
        /// <returns>UserPasswordRule</returns>
        UserPasswordRule UserPasswordRuleUpdateUserPasswordRuleAsync (UserPasswordRule body);
        /// <summary>
        /// Validates a proposed password against this rule 
        /// </summary>
        /// <param name="body">Password to validate against this rule</param>
        /// <returns>bool?</returns>
        bool? UserPasswordRuleValidateUserPasswordAsync (string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserPasswordRuleApi : IUserPasswordRuleApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPasswordRuleApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserPasswordRuleApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPasswordRuleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserPasswordRuleApi(String basePath)
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
        /// Generates a random password using this rule 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>string</returns>
        public string UserPasswordRuleGeneratePasswordAsync (UserPasswordRule body)
        {
    
            var path = "/v4/UserPasswordRule/GeneratePassword";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserPasswordRuleGeneratePasswordAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserPasswordRuleGeneratePasswordAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Gets the user password rule 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>UserPasswordRule</returns>
        public UserPasswordRule UserPasswordRuleGetUserPasswordRuleAsync (string fields)
        {
    
            var path = "/v4/UserPasswordRule";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserPasswordRuleGetUserPasswordRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserPasswordRuleGetUserPasswordRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserPasswordRule) ApiClient.Deserialize(response.Content, typeof(UserPasswordRule), response.Headers);
        }
    
        /// <summary>
        /// Updates the user password rule 
        /// </summary>
        /// <param name="body">Updated PasswordRule</param>
        /// <returns>UserPasswordRule</returns>
        public UserPasswordRule UserPasswordRuleUpdateUserPasswordRuleAsync (UserPasswordRule body)
        {
    
            var path = "/v4/UserPasswordRule";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserPasswordRuleUpdateUserPasswordRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserPasswordRuleUpdateUserPasswordRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserPasswordRule) ApiClient.Deserialize(response.Content, typeof(UserPasswordRule), response.Headers);
        }
    
        /// <summary>
        /// Validates a proposed password against this rule 
        /// </summary>
        /// <param name="body">Password to validate against this rule</param>
        /// <returns>bool?</returns>
        public bool? UserPasswordRuleValidateUserPasswordAsync (string body)
        {
    
            var path = "/v4/UserPasswordRule/ValidatePassword";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserPasswordRuleValidateUserPasswordAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserPasswordRuleValidateUserPasswordAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
    }
}
