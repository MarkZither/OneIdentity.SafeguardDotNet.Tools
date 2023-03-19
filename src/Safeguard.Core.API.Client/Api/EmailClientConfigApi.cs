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
    public interface IEmailClientConfigApi
    {
        /// <summary>
        /// Gets the email client authentication certificate 
        /// </summary>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>ServerCertificate</returns>
        ServerCertificate EmailClientConfigGetAuthenticationCertificateAsync (string fields);
        /// <summary>
        /// Gets the email client authentication certificate history 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ServerCertificateLog&gt;</returns>
        List<ServerCertificateLog> EmailClientConfigGetAuthenticationCertificateHistoryAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the email client configuration 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>EmailClientConfig</returns>
        EmailClientConfig EmailClientConfigGetEmailConfigAsync (string fields);
        /// <summary>
        /// Reset the email client authentication certificate 
        /// </summary>
        /// <returns>ServerCertificate</returns>
        ServerCertificate EmailClientConfigResetAuthenticationCertificateAsync ();
        /// <summary>
        /// Update the email client authentication certificate 
        /// </summary>
        /// <param name="body">Settings to save</param>
        /// <returns>ServerCertificate</returns>
        ServerCertificate EmailClientConfigSaveAuthenticationCertificateAsync (ServerCertificate body);
        /// <summary>
        /// Sends an email via an SMTP server 
        /// </summary>
        /// <param name="body">Email configuration overrides for test email</param>
        /// <returns></returns>
        void EmailClientConfigSendTestEmailAsync (TestEmailClientConfig body);
        /// <summary>
        /// Updates the email client configuration 
        /// </summary>
        /// <param name="body">Updated EmailClientConfig</param>
        /// <returns>EmailClientConfig</returns>
        EmailClientConfig EmailClientConfigUpdateEntityAsync (EmailClientConfig body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EmailClientConfigApi : IEmailClientConfigApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientConfigApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EmailClientConfigApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailClientConfigApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmailClientConfigApi(String basePath)
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
        /// Gets the email client authentication certificate 
        /// </summary>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>ServerCertificate</returns>
        public ServerCertificate EmailClientConfigGetAuthenticationCertificateAsync (string fields)
        {
    
            var path = "/v4/EmailClientConfig/ClientCertificate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailClientConfigGetAuthenticationCertificateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailClientConfigGetAuthenticationCertificateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServerCertificate) ApiClient.Deserialize(response.Content, typeof(ServerCertificate), response.Headers);
        }
    
        /// <summary>
        /// Gets the email client authentication certificate history 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ServerCertificateLog&gt;</returns>
        public List<ServerCertificateLog> EmailClientConfigGetAuthenticationCertificateHistoryAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/EmailClientConfig/ClientCertificate/History";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailClientConfigGetAuthenticationCertificateHistoryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailClientConfigGetAuthenticationCertificateHistoryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ServerCertificateLog>) ApiClient.Deserialize(response.Content, typeof(List<ServerCertificateLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets the email client configuration 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>EmailClientConfig</returns>
        public EmailClientConfig EmailClientConfigGetEmailConfigAsync (string fields)
        {
    
            var path = "/v4/EmailClientConfig";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailClientConfigGetEmailConfigAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailClientConfigGetEmailConfigAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EmailClientConfig) ApiClient.Deserialize(response.Content, typeof(EmailClientConfig), response.Headers);
        }
    
        /// <summary>
        /// Reset the email client authentication certificate 
        /// </summary>
        /// <returns>ServerCertificate</returns>
        public ServerCertificate EmailClientConfigResetAuthenticationCertificateAsync ()
        {
    
            var path = "/v4/EmailClientConfig/ClientCertificate";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailClientConfigResetAuthenticationCertificateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailClientConfigResetAuthenticationCertificateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServerCertificate) ApiClient.Deserialize(response.Content, typeof(ServerCertificate), response.Headers);
        }
    
        /// <summary>
        /// Update the email client authentication certificate 
        /// </summary>
        /// <param name="body">Settings to save</param>
        /// <returns>ServerCertificate</returns>
        public ServerCertificate EmailClientConfigSaveAuthenticationCertificateAsync (ServerCertificate body)
        {
    
            var path = "/v4/EmailClientConfig/ClientCertificate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailClientConfigSaveAuthenticationCertificateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailClientConfigSaveAuthenticationCertificateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServerCertificate) ApiClient.Deserialize(response.Content, typeof(ServerCertificate), response.Headers);
        }
    
        /// <summary>
        /// Sends an email via an SMTP server 
        /// </summary>
        /// <param name="body">Email configuration overrides for test email</param>
        /// <returns></returns>
        public void EmailClientConfigSendTestEmailAsync (TestEmailClientConfig body)
        {
    
            var path = "/v4/EmailClientConfig/SendTestEmail";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailClientConfigSendTestEmailAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailClientConfigSendTestEmailAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the email client configuration 
        /// </summary>
        /// <param name="body">Updated EmailClientConfig</param>
        /// <returns>EmailClientConfig</returns>
        public EmailClientConfig EmailClientConfigUpdateEntityAsync (EmailClientConfig body)
        {
    
            var path = "/v4/EmailClientConfig";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailClientConfigUpdateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailClientConfigUpdateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EmailClientConfig) ApiClient.Deserialize(response.Content, typeof(EmailClientConfig), response.Headers);
        }
    
    }
}
