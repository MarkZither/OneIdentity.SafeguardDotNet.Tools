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
    public interface IA2ARegistrationsApi
    {
        /// <summary>
        /// Creates a new registration 
        /// </summary>
        /// <param name="body">Registration to create</param>
        /// <returns>Registration</returns>
        Registration A2ARegistrationsCreateEntityAsync (Registration body);
        /// <summary>
        /// Remove an application registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <returns></returns>
        void A2ARegistrationsDeleteAsync (int? id);
        /// <summary>
        /// Remove the access request broker information for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="accountId">Unique identifier of the retrievable account that is associated with the registration</param>
        /// <returns></returns>
        void A2ARegistrationsDeleteRegistrationRetrievableAccountAsync (int? id, int? accountId);
        /// <summary>
        /// Gets a list of registrations 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Registration&gt;</returns>
        List<Registration> A2ARegistrationsGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a registration 
        /// </summary>
        /// <param name="id">Unique ID of Registration</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Registration</returns>
        Registration A2ARegistrationsGetByIdAsync (int? id, string fields);
        /// <summary>
        /// Get the API key for the access request broker for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <returns>string</returns>
        string A2ARegistrationsGetRegistrationAccessRequestBrokerApiKeyAsync (int? id);
        /// <summary>
        /// Get the access request broker information for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>RegistrationAccessRequestBroker</returns>
        RegistrationAccessRequestBroker A2ARegistrationsGetRegistrationAccessRequestBrokerAsync (int? id, string fields);
        /// <summary>
        /// Get the API key for a retrievable account for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="accountId">Unique identifier of the retrievable account that is associated with the registration</param>
        /// <returns>string</returns>
        string A2ARegistrationsGetRegistrationRetrievableAccountApiKeyAsync (int? id, int? accountId);
        /// <summary>
        /// Get a retrievable account for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="accountId">Unique identifier of the retrievable account that is associated with the registration</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>RegistrationRetrievableAccount</returns>
        RegistrationRetrievableAccount A2ARegistrationsGetRegistrationRetrievableAccountAsync (int? id, int? accountId, string fields);
        /// <summary>
        /// Get the retrievable accounts for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;RegistrationRetrievableAccount&gt;</returns>
        List<RegistrationRetrievableAccount> A2ARegistrationsGetRegistrationRetrievableAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Add a retrievable account for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="body">Updated retrievable account</param>
        /// <returns>RegistrationRetrievableAccount</returns>
        RegistrationRetrievableAccount A2ARegistrationsPostRegistrationRetrievableAccountAsync (int? id, RegistrationRetrievableAccount body);
        /// <summary>
        /// Update a retrievable account for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="accountId">Unique identifier of the retrievable account that is associated with the registration</param>
        /// <param name="body">Updated retrievable account</param>
        /// <returns>RegistrationRetrievableAccount</returns>
        RegistrationRetrievableAccount A2ARegistrationsPutRegistrationRetrievableAccountAsync (int? id, int? accountId, RegistrationRetrievableAccount body);
        /// <summary>
        /// Regenerate the API key for the access request broker for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <returns>string</returns>
        string A2ARegistrationsRegenerateRegistrationAccessRequestBrokerApiKeyAsync (int? id);
        /// <summary>
        /// Regenerate the API key for a retrievable account for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="accountId">Unique identifier of the retrievable account that is associated with the registration</param>
        /// <returns>string</returns>
        string A2ARegistrationsRegenerateRegistrationRetrievableAccountApiKeyAsync (int? id, int? accountId);
        /// <summary>
        /// Remove the access request broker information for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <returns></returns>
        void A2ARegistrationsRemoveRegistrationAccessRequestBrokerAsync (int? id);
        /// <summary>
        /// Updates an existing application registration 
        /// </summary>
        /// <param name="id">Unique identifier of the Registration</param>
        /// <param name="body">Updated Registration</param>
        /// <returns>Registration</returns>
        Registration A2ARegistrationsUpdateEntityAsync (int? id, Registration body);
        /// <summary>
        /// Update the access request broker information for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="body">Registration access request broker information</param>
        /// <returns>RegistrationAccessRequestBroker</returns>
        RegistrationAccessRequestBroker A2ARegistrationsUpdateRegistrationAccessRequestBrokerAsync (int? id, RegistrationAccessRequestBroker body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class A2ARegistrationsApi : IA2ARegistrationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="A2ARegistrationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public A2ARegistrationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="A2ARegistrationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public A2ARegistrationsApi(String basePath)
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
        /// Creates a new registration 
        /// </summary>
        /// <param name="body">Registration to create</param>
        /// <returns>Registration</returns>
        public Registration A2ARegistrationsCreateEntityAsync (Registration body)
        {
    
            var path = "/v4/A2ARegistrations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsCreateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsCreateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Registration) ApiClient.Deserialize(response.Content, typeof(Registration), response.Headers);
        }
    
        /// <summary>
        /// Remove an application registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <returns></returns>
        public void A2ARegistrationsDeleteAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling A2ARegistrationsDeleteAsync");
    
            var path = "/v4/A2ARegistrations/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsDeleteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsDeleteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove the access request broker information for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="accountId">Unique identifier of the retrievable account that is associated with the registration</param>
        /// <returns></returns>
        public void A2ARegistrationsDeleteRegistrationRetrievableAccountAsync (int? id, int? accountId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling A2ARegistrationsDeleteRegistrationRetrievableAccountAsync");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling A2ARegistrationsDeleteRegistrationRetrievableAccountAsync");
    
            var path = "/v4/A2ARegistrations/{id}/RetrievableAccounts/{accountId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsDeleteRegistrationRetrievableAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsDeleteRegistrationRetrievableAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a list of registrations 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Registration&gt;</returns>
        public List<Registration> A2ARegistrationsGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/A2ARegistrations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Registration>) ApiClient.Deserialize(response.Content, typeof(List<Registration>), response.Headers);
        }
    
        /// <summary>
        /// Gets a registration 
        /// </summary>
        /// <param name="id">Unique ID of Registration</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Registration</returns>
        public Registration A2ARegistrationsGetByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling A2ARegistrationsGetByIdAsync");
    
            var path = "/v4/A2ARegistrations/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsGetByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsGetByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Registration) ApiClient.Deserialize(response.Content, typeof(Registration), response.Headers);
        }
    
        /// <summary>
        /// Get the API key for the access request broker for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <returns>string</returns>
        public string A2ARegistrationsGetRegistrationAccessRequestBrokerApiKeyAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling A2ARegistrationsGetRegistrationAccessRequestBrokerApiKeyAsync");
    
            var path = "/v4/A2ARegistrations/{id}/AccessRequestBroker/ApiKey";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsGetRegistrationAccessRequestBrokerApiKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsGetRegistrationAccessRequestBrokerApiKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Get the access request broker information for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>RegistrationAccessRequestBroker</returns>
        public RegistrationAccessRequestBroker A2ARegistrationsGetRegistrationAccessRequestBrokerAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling A2ARegistrationsGetRegistrationAccessRequestBrokerAsync");
    
            var path = "/v4/A2ARegistrations/{id}/AccessRequestBroker";
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsGetRegistrationAccessRequestBrokerAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsGetRegistrationAccessRequestBrokerAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RegistrationAccessRequestBroker) ApiClient.Deserialize(response.Content, typeof(RegistrationAccessRequestBroker), response.Headers);
        }
    
        /// <summary>
        /// Get the API key for a retrievable account for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="accountId">Unique identifier of the retrievable account that is associated with the registration</param>
        /// <returns>string</returns>
        public string A2ARegistrationsGetRegistrationRetrievableAccountApiKeyAsync (int? id, int? accountId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling A2ARegistrationsGetRegistrationRetrievableAccountApiKeyAsync");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling A2ARegistrationsGetRegistrationRetrievableAccountApiKeyAsync");
    
            var path = "/v4/A2ARegistrations/{id}/RetrievableAccounts/{accountId}/ApiKey";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsGetRegistrationRetrievableAccountApiKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsGetRegistrationRetrievableAccountApiKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Get a retrievable account for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="accountId">Unique identifier of the retrievable account that is associated with the registration</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>RegistrationRetrievableAccount</returns>
        public RegistrationRetrievableAccount A2ARegistrationsGetRegistrationRetrievableAccountAsync (int? id, int? accountId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling A2ARegistrationsGetRegistrationRetrievableAccountAsync");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling A2ARegistrationsGetRegistrationRetrievableAccountAsync");
    
            var path = "/v4/A2ARegistrations/{id}/RetrievableAccounts/{accountId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsGetRegistrationRetrievableAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsGetRegistrationRetrievableAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RegistrationRetrievableAccount) ApiClient.Deserialize(response.Content, typeof(RegistrationRetrievableAccount), response.Headers);
        }
    
        /// <summary>
        /// Get the retrievable accounts for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;RegistrationRetrievableAccount&gt;</returns>
        public List<RegistrationRetrievableAccount> A2ARegistrationsGetRegistrationRetrievableAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling A2ARegistrationsGetRegistrationRetrievableAccountsAsync");
    
            var path = "/v4/A2ARegistrations/{id}/RetrievableAccounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsGetRegistrationRetrievableAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsGetRegistrationRetrievableAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RegistrationRetrievableAccount>) ApiClient.Deserialize(response.Content, typeof(List<RegistrationRetrievableAccount>), response.Headers);
        }
    
        /// <summary>
        /// Add a retrievable account for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="body">Updated retrievable account</param>
        /// <returns>RegistrationRetrievableAccount</returns>
        public RegistrationRetrievableAccount A2ARegistrationsPostRegistrationRetrievableAccountAsync (int? id, RegistrationRetrievableAccount body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling A2ARegistrationsPostRegistrationRetrievableAccountAsync");
    
            var path = "/v4/A2ARegistrations/{id}/RetrievableAccounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsPostRegistrationRetrievableAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsPostRegistrationRetrievableAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RegistrationRetrievableAccount) ApiClient.Deserialize(response.Content, typeof(RegistrationRetrievableAccount), response.Headers);
        }
    
        /// <summary>
        /// Update a retrievable account for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="accountId">Unique identifier of the retrievable account that is associated with the registration</param>
        /// <param name="body">Updated retrievable account</param>
        /// <returns>RegistrationRetrievableAccount</returns>
        public RegistrationRetrievableAccount A2ARegistrationsPutRegistrationRetrievableAccountAsync (int? id, int? accountId, RegistrationRetrievableAccount body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling A2ARegistrationsPutRegistrationRetrievableAccountAsync");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling A2ARegistrationsPutRegistrationRetrievableAccountAsync");
    
            var path = "/v4/A2ARegistrations/{id}/RetrievableAccounts/{accountId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsPutRegistrationRetrievableAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsPutRegistrationRetrievableAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RegistrationRetrievableAccount) ApiClient.Deserialize(response.Content, typeof(RegistrationRetrievableAccount), response.Headers);
        }
    
        /// <summary>
        /// Regenerate the API key for the access request broker for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <returns>string</returns>
        public string A2ARegistrationsRegenerateRegistrationAccessRequestBrokerApiKeyAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling A2ARegistrationsRegenerateRegistrationAccessRequestBrokerApiKeyAsync");
    
            var path = "/v4/A2ARegistrations/{id}/AccessRequestBroker/ApiKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsRegenerateRegistrationAccessRequestBrokerApiKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsRegenerateRegistrationAccessRequestBrokerApiKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Regenerate the API key for a retrievable account for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="accountId">Unique identifier of the retrievable account that is associated with the registration</param>
        /// <returns>string</returns>
        public string A2ARegistrationsRegenerateRegistrationRetrievableAccountApiKeyAsync (int? id, int? accountId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling A2ARegistrationsRegenerateRegistrationRetrievableAccountApiKeyAsync");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling A2ARegistrationsRegenerateRegistrationRetrievableAccountApiKeyAsync");
    
            var path = "/v4/A2ARegistrations/{id}/RetrievableAccounts/{accountId}/ApiKey";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsRegenerateRegistrationRetrievableAccountApiKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsRegenerateRegistrationRetrievableAccountApiKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Remove the access request broker information for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <returns></returns>
        public void A2ARegistrationsRemoveRegistrationAccessRequestBrokerAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling A2ARegistrationsRemoveRegistrationAccessRequestBrokerAsync");
    
            var path = "/v4/A2ARegistrations/{id}/AccessRequestBroker";
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsRemoveRegistrationAccessRequestBrokerAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsRemoveRegistrationAccessRequestBrokerAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates an existing application registration 
        /// </summary>
        /// <param name="id">Unique identifier of the Registration</param>
        /// <param name="body">Updated Registration</param>
        /// <returns>Registration</returns>
        public Registration A2ARegistrationsUpdateEntityAsync (int? id, Registration body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling A2ARegistrationsUpdateEntityAsync");
    
            var path = "/v4/A2ARegistrations/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsUpdateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsUpdateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Registration) ApiClient.Deserialize(response.Content, typeof(Registration), response.Headers);
        }
    
        /// <summary>
        /// Update the access request broker information for the registration 
        /// </summary>
        /// <param name="id">Unique identifier of the registration</param>
        /// <param name="body">Registration access request broker information</param>
        /// <returns>RegistrationAccessRequestBroker</returns>
        public RegistrationAccessRequestBroker A2ARegistrationsUpdateRegistrationAccessRequestBrokerAsync (int? id, RegistrationAccessRequestBroker body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling A2ARegistrationsUpdateRegistrationAccessRequestBrokerAsync");
    
            var path = "/v4/A2ARegistrations/{id}/AccessRequestBroker";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsUpdateRegistrationAccessRequestBrokerAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling A2ARegistrationsUpdateRegistrationAccessRequestBrokerAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RegistrationAccessRequestBroker) ApiClient.Deserialize(response.Content, typeof(RegistrationAccessRequestBroker), response.Headers);
        }
    
    }
}
