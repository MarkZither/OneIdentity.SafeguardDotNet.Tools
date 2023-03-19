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
    public interface IAuthenticationProvidersApi
    {
        /// <summary>
        /// Any authentication provider that was marked as the default will be cleared such that the              system will not have a default provider and the login page will display a drop down list of all              available authentication providers for the user to choose from. 
        /// </summary>
        /// <returns></returns>
        void AuthenticationProvidersClearDefaultAsync ();
        /// <summary>
        /// When set to {true} on a provider, the login page will not display a drop down list              of all available providers. Instead, the end user will be defaulted in to using the specified provider.              Only one provider can be marked as the default at a time. When updating the specified provider,              any previously set default will be cleared.              &lt;br&gt;If a default provider is set and you need to log in using some other provider, like the              Safeguard Local provider in order to log in as a local administrator user, a query string parameter              can be appended to the login page URL, &#x27;primaryProviderID&#x27;, where the value is set to the &#x27;RstsProviderId&#x27;              you need. For example, \&quot;https://&lt;safeguard&gt;/RSTS/Login?response_type&#x3D;token&amp;redirect_uri&#x3D;https%3A%2F%2F&lt;safeguard&gt;%2F&amp;primaryProviderID&#x3D;local\&quot;.&lt;br&gt;You cannot set a provider that is used for two-factor authentication as the default.&lt;br&gt;This functionality is only applicable to web browser based logins, not programmatic API/OAuth2 logins. 
        /// </summary>
        /// <param name="id">Unique ID of the AuthenticationProvider</param>
        /// <returns>AuthenticationProvider</returns>
        AuthenticationProvider AuthenticationProvidersForceAsDefaultAsync (int? id);
        /// <summary>
        /// Gets a queryable list of authentication providers 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AuthenticationProvider&gt;</returns>
        List<AuthenticationProvider> AuthenticationProvidersGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a single authentication provider 
        /// </summary>
        /// <param name="id">Unique ID of AuthenticationProvider</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AuthenticationProvider</returns>
        AuthenticationProvider AuthenticationProvidersGetByIdAsync (int? id, string fields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthenticationProvidersApi : IAuthenticationProvidersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationProvidersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuthenticationProvidersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationProvidersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthenticationProvidersApi(String basePath)
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
        /// Any authentication provider that was marked as the default will be cleared such that the              system will not have a default provider and the login page will display a drop down list of all              available authentication providers for the user to choose from. 
        /// </summary>
        /// <returns></returns>
        public void AuthenticationProvidersClearDefaultAsync ()
        {
    
            var path = "/v4/AuthenticationProviders/ClearDefault";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AuthenticationProvidersClearDefaultAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuthenticationProvidersClearDefaultAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// When set to {true} on a provider, the login page will not display a drop down list              of all available providers. Instead, the end user will be defaulted in to using the specified provider.              Only one provider can be marked as the default at a time. When updating the specified provider,              any previously set default will be cleared.              &lt;br&gt;If a default provider is set and you need to log in using some other provider, like the              Safeguard Local provider in order to log in as a local administrator user, a query string parameter              can be appended to the login page URL, &#x27;primaryProviderID&#x27;, where the value is set to the &#x27;RstsProviderId&#x27;              you need. For example, \&quot;https://&lt;safeguard&gt;/RSTS/Login?response_type&#x3D;token&amp;redirect_uri&#x3D;https%3A%2F%2F&lt;safeguard&gt;%2F&amp;primaryProviderID&#x3D;local\&quot;.&lt;br&gt;You cannot set a provider that is used for two-factor authentication as the default.&lt;br&gt;This functionality is only applicable to web browser based logins, not programmatic API/OAuth2 logins. 
        /// </summary>
        /// <param name="id">Unique ID of the AuthenticationProvider</param>
        /// <returns>AuthenticationProvider</returns>
        public AuthenticationProvider AuthenticationProvidersForceAsDefaultAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuthenticationProvidersForceAsDefaultAsync");
    
            var path = "/v4/AuthenticationProviders/{id}/ForceAsDefault";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AuthenticationProvidersForceAsDefaultAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuthenticationProvidersForceAsDefaultAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AuthenticationProvider) ApiClient.Deserialize(response.Content, typeof(AuthenticationProvider), response.Headers);
        }
    
        /// <summary>
        /// Gets a queryable list of authentication providers 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AuthenticationProvider&gt;</returns>
        public List<AuthenticationProvider> AuthenticationProvidersGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuthenticationProviders";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuthenticationProvidersGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuthenticationProvidersGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AuthenticationProvider>) ApiClient.Deserialize(response.Content, typeof(List<AuthenticationProvider>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single authentication provider 
        /// </summary>
        /// <param name="id">Unique ID of AuthenticationProvider</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AuthenticationProvider</returns>
        public AuthenticationProvider AuthenticationProvidersGetByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuthenticationProvidersGetByIdAsync");
    
            var path = "/v4/AuthenticationProviders/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuthenticationProvidersGetByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuthenticationProvidersGetByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AuthenticationProvider) ApiClient.Deserialize(response.Content, typeof(AuthenticationProvider), response.Headers);
        }
    
    }
}
