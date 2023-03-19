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
    public interface IStarlingSubscriptionsApi
    {
        /// <summary>
        /// Adds the new Starling subscription information. 
        /// </summary>
        /// <param name="body">The Starling subscription information to add.</param>
        /// <returns>StarlingSubscription</returns>
        StarlingSubscription StarlingSubscriptionsCreateEntityAsync (StarlingSubscription body);
        /// <summary>
        /// Remove and unjoin the specified Starling subscription. 
        /// </summary>
        /// <param name="id">The unique id of the Starling subscription to be deleted and removed from the system.</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force the removal of the subscription information              from Safeguard, regardless of whether or not the request to Starling to unjoin was successful.</param>
        /// <returns></returns>
        void StarlingSubscriptionsDeleteAsync (int? id, bool? forceDelete);
        /// <summary>
        /// Get all Starling subscriptions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;StarlingSubscription&gt;</returns>
        List<StarlingSubscription> StarlingSubscriptionsGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the specified Starling subscription information. 
        /// </summary>
        /// <param name="id">Unique id of the Starling subscription to return.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>StarlingSubscription</returns>
        StarlingSubscription StarlingSubscriptionsGetByIdAsync (int? id, string fields);
        /// <summary>
        /// Get the necessary URL used by a client to initiate the Starling join process. 
        /// </summary>
        /// <returns>string</returns>
        string StarlingSubscriptionsGetJoinUrlAsync ();
        /// <summary>
        /// The DNS suffix name(s) for which the Starling authentication provider will be used. This value needs to match  the email address suffix of a user that intends to be authenticated. If the federated authentication supports  more than one realm, enter each realm separated by a space or comma. 
        /// </summary>
        /// <returns>string</returns>
        string StarlingSubscriptionsGetRealmAsync ();
        /// <summary>
        /// Controls the &#x27;ForceAuthn&#x27; attribute of a SAML2 AuthnRequest. When set to true, the user will  be required to reenter their credentials on the external federation site, even if they are already  logged in, thus negating any single sign-on benefits, but may be considered more secure. 
        /// </summary>
        /// <returns>bool?</returns>
        bool? StarlingSubscriptionsGetRequireAuthenticationAsync ();
        /// <summary>
        /// The DNS suffix name(s) for which the Starling authentication provider will be used. This value needs to match  the email address suffix of a user that intends to be authenticated. If the federated authentication supports  more than one realm, enter each realm separated by a space or comma. 
        /// </summary>
        /// <param name="body">The DNS suffix name(s) for which the Starling authentication provider will be used. This
        /// value needs to match the email address suffix of a user that intends to be authenticated. If the federated
        /// authentication supports more than one realm, enter each realm separated by a space or comma.</param>
        /// <returns></returns>
        void StarlingSubscriptionsPutRealmAsync (string body);
        /// <summary>
        /// Controls the &#x27;ForceAuthn&#x27; attribute of a SAML2 AuthnRequest. When set to true, the user will  be required to reenter their credentials on the external federation site, even if they are already  logged in, thus negating any single sign-on benefits, but may be considered more secure. 
        /// </summary>
        /// <param name="body">Set to true to require the user to reenter their credentials on
        /// the external federation site, even if they are already logged in. Set to false to allow the user to
        /// automatically be logged into Safeguard if the external federation site supports SSO.</param>
        /// <returns></returns>
        void StarlingSubscriptionsPutRequireAuthenticationAsync (bool? body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StarlingSubscriptionsApi : IStarlingSubscriptionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StarlingSubscriptionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StarlingSubscriptionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StarlingSubscriptionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StarlingSubscriptionsApi(String basePath)
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
        /// Adds the new Starling subscription information. 
        /// </summary>
        /// <param name="body">The Starling subscription information to add.</param>
        /// <returns>StarlingSubscription</returns>
        public StarlingSubscription StarlingSubscriptionsCreateEntityAsync (StarlingSubscription body)
        {
    
            var path = "/v4/StarlingSubscriptions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsCreateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsCreateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StarlingSubscription) ApiClient.Deserialize(response.Content, typeof(StarlingSubscription), response.Headers);
        }
    
        /// <summary>
        /// Remove and unjoin the specified Starling subscription. 
        /// </summary>
        /// <param name="id">The unique id of the Starling subscription to be deleted and removed from the system.</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force the removal of the subscription information              from Safeguard, regardless of whether or not the request to Starling to unjoin was successful.</param>
        /// <returns></returns>
        public void StarlingSubscriptionsDeleteAsync (int? id, bool? forceDelete)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StarlingSubscriptionsDeleteAsync");
    
            var path = "/v4/StarlingSubscriptions/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (forceDelete != null) queryParams.Add("forceDelete", ApiClient.ParameterToString(forceDelete)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsDeleteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsDeleteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get all Starling subscriptions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;StarlingSubscription&gt;</returns>
        public List<StarlingSubscription> StarlingSubscriptionsGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/StarlingSubscriptions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<StarlingSubscription>) ApiClient.Deserialize(response.Content, typeof(List<StarlingSubscription>), response.Headers);
        }
    
        /// <summary>
        /// Gets the specified Starling subscription information. 
        /// </summary>
        /// <param name="id">Unique id of the Starling subscription to return.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>StarlingSubscription</returns>
        public StarlingSubscription StarlingSubscriptionsGetByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StarlingSubscriptionsGetByIdAsync");
    
            var path = "/v4/StarlingSubscriptions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsGetByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsGetByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (StarlingSubscription) ApiClient.Deserialize(response.Content, typeof(StarlingSubscription), response.Headers);
        }
    
        /// <summary>
        /// Get the necessary URL used by a client to initiate the Starling join process. 
        /// </summary>
        /// <returns>string</returns>
        public string StarlingSubscriptionsGetJoinUrlAsync ()
        {
    
            var path = "/v4/StarlingSubscriptions/JoinUrl";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsGetJoinUrlAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsGetJoinUrlAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// The DNS suffix name(s) for which the Starling authentication provider will be used. This value needs to match  the email address suffix of a user that intends to be authenticated. If the federated authentication supports  more than one realm, enter each realm separated by a space or comma. 
        /// </summary>
        /// <returns>string</returns>
        public string StarlingSubscriptionsGetRealmAsync ()
        {
    
            var path = "/v4/StarlingSubscriptions/Realm";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsGetRealmAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsGetRealmAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Controls the &#x27;ForceAuthn&#x27; attribute of a SAML2 AuthnRequest. When set to true, the user will  be required to reenter their credentials on the external federation site, even if they are already  logged in, thus negating any single sign-on benefits, but may be considered more secure. 
        /// </summary>
        /// <returns>bool?</returns>
        public bool? StarlingSubscriptionsGetRequireAuthenticationAsync ()
        {
    
            var path = "/v4/StarlingSubscriptions/RequireAuthentication";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsGetRequireAuthenticationAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsGetRequireAuthenticationAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
        /// <summary>
        /// The DNS suffix name(s) for which the Starling authentication provider will be used. This value needs to match  the email address suffix of a user that intends to be authenticated. If the federated authentication supports  more than one realm, enter each realm separated by a space or comma. 
        /// </summary>
        /// <param name="body">The DNS suffix name(s) for which the Starling authentication provider will be used. This
        /// value needs to match the email address suffix of a user that intends to be authenticated. If the federated
        /// authentication supports more than one realm, enter each realm separated by a space or comma.</param>
        /// <returns></returns>
        public void StarlingSubscriptionsPutRealmAsync (string body)
        {
    
            var path = "/v4/StarlingSubscriptions/Realm";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsPutRealmAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsPutRealmAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Controls the &#x27;ForceAuthn&#x27; attribute of a SAML2 AuthnRequest. When set to true, the user will  be required to reenter their credentials on the external federation site, even if they are already  logged in, thus negating any single sign-on benefits, but may be considered more secure. 
        /// </summary>
        /// <param name="body">Set to true to require the user to reenter their credentials on
        /// the external federation site, even if they are already logged in. Set to false to allow the user to
        /// automatically be logged into Safeguard if the external federation site supports SSO.</param>
        /// <returns></returns>
        public void StarlingSubscriptionsPutRequireAuthenticationAsync (bool? body)
        {
    
            var path = "/v4/StarlingSubscriptions/RequireAuthentication";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsPutRequireAuthenticationAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StarlingSubscriptionsPutRequireAuthenticationAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
