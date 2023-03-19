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
    public interface ITicketSystemsApi
    {
        /// <summary>
        /// Creates a new ticket system 
        /// </summary>
        /// <param name="body">ticket system to create</param>
        /// <returns>TicketSystem</returns>
        TicketSystem TicketSystemsCreateEntityAsync (TicketSystem body);
        /// <summary>
        /// Removes a ticket system 
        /// </summary>
        /// <param name="id">Unique identifier of the ticket system</param>
        /// <returns></returns>
        void TicketSystemsDeleteAsync (int? id);
        /// <summary>
        /// Gets a list of all ticket systems 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;TicketSystem&gt;</returns>
        List<TicketSystem> TicketSystemsGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a ticket system 
        /// </summary>
        /// <param name="id">Unique ID of ticket system</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>TicketSystem</returns>
        TicketSystem TicketSystemsGetByIdAsync (int? id, string fields);
        /// <summary>
        /// Test connection parameters to a ticket system 
        /// </summary>
        /// <param name="body">ticket system configuration to test</param>
        /// <returns></returns>
        void TicketSystemsTestConnectionAsync (TicketSystemTestConnectionParameters body);
        /// <summary>
        /// Test connection parameters to a ticket system 
        /// </summary>
        /// <param name="id">Unique identifier of the ticket system</param>
        /// <returns></returns>
        void TicketSystemsTestConnectionByIdAsync (int? id);
        /// <summary>
        /// Updates an existing ticket system 
        /// </summary>
        /// <param name="id">Unique identifier of the ticket system</param>
        /// <param name="body">Updated ticket system</param>
        /// <returns>TicketSystem</returns>
        TicketSystem TicketSystemsUpdateEntityAsync (int? id, TicketSystem body);
        /// <summary>
        /// Validate ticket number against all the ticket systems 
        /// </summary>
        /// <param name="ticket">Ticket number from ticket system</param>
        /// <returns>bool?</returns>
        bool? TicketSystemsValidateAnyTicketAsync (string ticket);
        /// <summary>
        /// Validate ticket number against the ticket system 
        /// </summary>
        /// <param name="id">Unique identifier of the ticket system</param>
        /// <param name="ticket">Ticket number from ticket system</param>
        /// <returns></returns>
        void TicketSystemsValidateTicketAsync (int? id, string ticket);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TicketSystemsApi : ITicketSystemsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TicketSystemsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TicketSystemsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TicketSystemsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TicketSystemsApi(String basePath)
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
        /// Creates a new ticket system 
        /// </summary>
        /// <param name="body">ticket system to create</param>
        /// <returns>TicketSystem</returns>
        public TicketSystem TicketSystemsCreateEntityAsync (TicketSystem body)
        {
    
            var path = "/v4/TicketSystems";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsCreateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsCreateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TicketSystem) ApiClient.Deserialize(response.Content, typeof(TicketSystem), response.Headers);
        }
    
        /// <summary>
        /// Removes a ticket system 
        /// </summary>
        /// <param name="id">Unique identifier of the ticket system</param>
        /// <returns></returns>
        public void TicketSystemsDeleteAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TicketSystemsDeleteAsync");
    
            var path = "/v4/TicketSystems/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsDeleteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsDeleteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a list of all ticket systems 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;TicketSystem&gt;</returns>
        public List<TicketSystem> TicketSystemsGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/TicketSystems";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TicketSystem>) ApiClient.Deserialize(response.Content, typeof(List<TicketSystem>), response.Headers);
        }
    
        /// <summary>
        /// Gets a ticket system 
        /// </summary>
        /// <param name="id">Unique ID of ticket system</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>TicketSystem</returns>
        public TicketSystem TicketSystemsGetByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TicketSystemsGetByIdAsync");
    
            var path = "/v4/TicketSystems/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsGetByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsGetByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TicketSystem) ApiClient.Deserialize(response.Content, typeof(TicketSystem), response.Headers);
        }
    
        /// <summary>
        /// Test connection parameters to a ticket system 
        /// </summary>
        /// <param name="body">ticket system configuration to test</param>
        /// <returns></returns>
        public void TicketSystemsTestConnectionAsync (TicketSystemTestConnectionParameters body)
        {
    
            var path = "/v4/TicketSystems/TestConnection";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsTestConnectionAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsTestConnectionAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Test connection parameters to a ticket system 
        /// </summary>
        /// <param name="id">Unique identifier of the ticket system</param>
        /// <returns></returns>
        public void TicketSystemsTestConnectionByIdAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TicketSystemsTestConnectionByIdAsync");
    
            var path = "/v4/TicketSystems/{id}/TestConnection";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsTestConnectionByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsTestConnectionByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates an existing ticket system 
        /// </summary>
        /// <param name="id">Unique identifier of the ticket system</param>
        /// <param name="body">Updated ticket system</param>
        /// <returns>TicketSystem</returns>
        public TicketSystem TicketSystemsUpdateEntityAsync (int? id, TicketSystem body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TicketSystemsUpdateEntityAsync");
    
            var path = "/v4/TicketSystems/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsUpdateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsUpdateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TicketSystem) ApiClient.Deserialize(response.Content, typeof(TicketSystem), response.Headers);
        }
    
        /// <summary>
        /// Validate ticket number against all the ticket systems 
        /// </summary>
        /// <param name="ticket">Ticket number from ticket system</param>
        /// <returns>bool?</returns>
        public bool? TicketSystemsValidateAnyTicketAsync (string ticket)
        {
            // verify the required parameter 'ticket' is set
            if (ticket == null) throw new ApiException(400, "Missing required parameter 'ticket' when calling TicketSystemsValidateAnyTicketAsync");
    
            var path = "/v4/TicketSystems/ValidateTicket/{ticket}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ticket" + "}", ApiClient.ParameterToString(ticket));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsValidateAnyTicketAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsValidateAnyTicketAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
        /// <summary>
        /// Validate ticket number against the ticket system 
        /// </summary>
        /// <param name="id">Unique identifier of the ticket system</param>
        /// <param name="ticket">Ticket number from ticket system</param>
        /// <returns></returns>
        public void TicketSystemsValidateTicketAsync (int? id, string ticket)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TicketSystemsValidateTicketAsync");
            // verify the required parameter 'ticket' is set
            if (ticket == null) throw new ApiException(400, "Missing required parameter 'ticket' when calling TicketSystemsValidateTicketAsync");
    
            var path = "/v4/TicketSystems/{id}/ValidateTicket/{ticket}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "ticket" + "}", ApiClient.ParameterToString(ticket));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsValidateTicketAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TicketSystemsValidateTicketAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
