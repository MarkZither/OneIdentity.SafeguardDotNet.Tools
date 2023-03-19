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
    public interface IEventSubscribersApi
    {
        /// <summary>
        /// Creates a new event subscriber 
        /// </summary>
        /// <param name="body">EventSubscriber to create</param>
        /// <returns>EventSubscriber</returns>
        EventSubscriber EventSubscribersCreateEventSubscriberAsync (EventSubscriber body);
        /// <summary>
        /// Removes an event subscriber 
        /// </summary>
        /// <param name="id">Unique identifier of the EventSubscriber</param>
        /// <returns></returns>
        void EventSubscribersDeleteEventSubscriberAsync (int? id);
        /// <summary>
        /// Gets an event subscriber 
        /// </summary>
        /// <param name="id">Unique ID of EventSubscriber</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>EventSubscriber</returns>
        EventSubscriber EventSubscribersGetEventSubscriberByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets a list of event subscribers 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;EventSubscriber&gt;</returns>
        List<EventSubscriber> EventSubscribersGetEventSubscribersAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of events subscribed to 
        /// </summary>
        /// <param name="id">Unique identifier of the EventSubscription</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;EventSubscription&gt;</returns>
        List<EventSubscription> EventSubscribersGetEventSubscriptionsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Add/Remove subscriptions to receive notifications for the specified events 
        /// </summary>
        /// <param name="id">Unique identifier of the EventSubscription</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Events to subscribe to</param>
        /// <returns>List&lt;EventSubscription&gt;</returns>
        List<EventSubscription> EventSubscribersModifyEventSubscriptionsAsync (int? id, ListOperation operation, List<ModelEvent> body);
        /// <summary>
        /// Subscribes to receive notifications for the specified events 
        /// </summary>
        /// <param name="id">Unique identifier of the EventSubscription</param>
        /// <param name="body">Events to subscribe to</param>
        /// <returns>List&lt;EventSubscription&gt;</returns>
        List<EventSubscription> EventSubscribersSetEventSubscriptionsAsync (int? id, List<ModelEvent> body);
        /// <summary>
        /// Updates the event subscriber 
        /// </summary>
        /// <param name="id">Unique identifier of the EventSubscriber to update</param>
        /// <param name="body">Updated EventSubscriber</param>
        /// <returns>EventSubscriber</returns>
        EventSubscriber EventSubscribersUpdateSubscriberAsync (int? id, EventSubscriber body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EventSubscribersApi : IEventSubscribersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventSubscribersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EventSubscribersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EventSubscribersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventSubscribersApi(String basePath)
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
        /// Creates a new event subscriber 
        /// </summary>
        /// <param name="body">EventSubscriber to create</param>
        /// <returns>EventSubscriber</returns>
        public EventSubscriber EventSubscribersCreateEventSubscriberAsync (EventSubscriber body)
        {
    
            var path = "/v4/EventSubscribers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersCreateEventSubscriberAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersCreateEventSubscriberAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EventSubscriber) ApiClient.Deserialize(response.Content, typeof(EventSubscriber), response.Headers);
        }
    
        /// <summary>
        /// Removes an event subscriber 
        /// </summary>
        /// <param name="id">Unique identifier of the EventSubscriber</param>
        /// <returns></returns>
        public void EventSubscribersDeleteEventSubscriberAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EventSubscribersDeleteEventSubscriberAsync");
    
            var path = "/v4/EventSubscribers/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersDeleteEventSubscriberAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersDeleteEventSubscriberAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets an event subscriber 
        /// </summary>
        /// <param name="id">Unique ID of EventSubscriber</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>EventSubscriber</returns>
        public EventSubscriber EventSubscribersGetEventSubscriberByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EventSubscribersGetEventSubscriberByIdAsync");
    
            var path = "/v4/EventSubscribers/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersGetEventSubscriberByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersGetEventSubscriberByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EventSubscriber) ApiClient.Deserialize(response.Content, typeof(EventSubscriber), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of event subscribers 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;EventSubscriber&gt;</returns>
        public List<EventSubscriber> EventSubscribersGetEventSubscribersAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/EventSubscribers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersGetEventSubscribersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersGetEventSubscribersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<EventSubscriber>) ApiClient.Deserialize(response.Content, typeof(List<EventSubscriber>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of events subscribed to 
        /// </summary>
        /// <param name="id">Unique identifier of the EventSubscription</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;EventSubscription&gt;</returns>
        public List<EventSubscription> EventSubscribersGetEventSubscriptionsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EventSubscribersGetEventSubscriptionsAsync");
    
            var path = "/v4/EventSubscribers/{id}/Subscriptions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersGetEventSubscriptionsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersGetEventSubscriptionsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<EventSubscription>) ApiClient.Deserialize(response.Content, typeof(List<EventSubscription>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove subscriptions to receive notifications for the specified events 
        /// </summary>
        /// <param name="id">Unique identifier of the EventSubscription</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Events to subscribe to</param>
        /// <returns>List&lt;EventSubscription&gt;</returns>
        public List<EventSubscription> EventSubscribersModifyEventSubscriptionsAsync (int? id, ListOperation operation, List<ModelEvent> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EventSubscribersModifyEventSubscriptionsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling EventSubscribersModifyEventSubscriptionsAsync");
    
            var path = "/v4/EventSubscribers/{id}/Subscriptions/{operation}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "operation" + "}", ApiClient.ParameterToString(operation));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersModifyEventSubscriptionsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersModifyEventSubscriptionsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<EventSubscription>) ApiClient.Deserialize(response.Content, typeof(List<EventSubscription>), response.Headers);
        }
    
        /// <summary>
        /// Subscribes to receive notifications for the specified events 
        /// </summary>
        /// <param name="id">Unique identifier of the EventSubscription</param>
        /// <param name="body">Events to subscribe to</param>
        /// <returns>List&lt;EventSubscription&gt;</returns>
        public List<EventSubscription> EventSubscribersSetEventSubscriptionsAsync (int? id, List<ModelEvent> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EventSubscribersSetEventSubscriptionsAsync");
    
            var path = "/v4/EventSubscribers/{id}/Subscriptions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersSetEventSubscriptionsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersSetEventSubscriptionsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<EventSubscription>) ApiClient.Deserialize(response.Content, typeof(List<EventSubscription>), response.Headers);
        }
    
        /// <summary>
        /// Updates the event subscriber 
        /// </summary>
        /// <param name="id">Unique identifier of the EventSubscriber to update</param>
        /// <param name="body">Updated EventSubscriber</param>
        /// <returns>EventSubscriber</returns>
        public EventSubscriber EventSubscribersUpdateSubscriberAsync (int? id, EventSubscriber body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EventSubscribersUpdateSubscriberAsync");
    
            var path = "/v4/EventSubscribers/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersUpdateSubscriberAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EventSubscribersUpdateSubscriberAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EventSubscriber) ApiClient.Deserialize(response.Content, typeof(EventSubscriber), response.Headers);
        }
    
    }
}
