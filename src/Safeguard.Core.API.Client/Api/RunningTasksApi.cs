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
    public interface IRunningTasksApi
    {
        /// <summary>
        /// Cancels the queued or running task, whenever possible 
        /// </summary>
        /// <param name="taskName">Name of tasks to filter by. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="id">Unique identifier of the Task</param>
        /// <returns></returns>
        void RunningTasksCancelPlatformTaskAsync (TaskNames taskName, string id);
        /// <summary>
        /// Gets a list of running tasks 
        /// </summary>
        /// <param name="startDate">Log time range start. Default 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Log time range end (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;RunningTask&gt;</returns>
        List<RunningTask> RunningTasksGetAsync (DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a single running task 
        /// </summary>
        /// <param name="taskName">Name of tasks to filter by. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="id">Unique identifier of the Task</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>RunningTask</returns>
        RunningTask RunningTasksGetByIdAsync (TaskNames taskName, string id, string fields);
        /// <summary>
        /// Gets a list of running tasks by task name 
        /// </summary>
        /// <param name="taskName">Name of tasks to filter by. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="startDate">Log time range start. Default 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Log time range end (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;RunningTask&gt;</returns>
        List<RunningTask> RunningTasksGetByNameAsync (TaskNames taskName, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RunningTasksApi : IRunningTasksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunningTasksApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RunningTasksApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RunningTasksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RunningTasksApi(String basePath)
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
        /// Cancels the queued or running task, whenever possible 
        /// </summary>
        /// <param name="taskName">Name of tasks to filter by. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="id">Unique identifier of the Task</param>
        /// <returns></returns>
        public void RunningTasksCancelPlatformTaskAsync (TaskNames taskName, string id)
        {
            // verify the required parameter 'taskName' is set
            if (taskName == null) throw new ApiException(400, "Missing required parameter 'taskName' when calling RunningTasksCancelPlatformTaskAsync");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RunningTasksCancelPlatformTaskAsync");
    
            var path = "/v4/RunningTasks/{taskName}/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "taskName" + "}", ApiClient.ParameterToString(taskName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling RunningTasksCancelPlatformTaskAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RunningTasksCancelPlatformTaskAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a list of running tasks 
        /// </summary>
        /// <param name="startDate">Log time range start. Default 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Log time range end (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;RunningTask&gt;</returns>
        public List<RunningTask> RunningTasksGetAsync (DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/RunningTasks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling RunningTasksGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RunningTasksGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RunningTask>) ApiClient.Deserialize(response.Content, typeof(List<RunningTask>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single running task 
        /// </summary>
        /// <param name="taskName">Name of tasks to filter by. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="id">Unique identifier of the Task</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>RunningTask</returns>
        public RunningTask RunningTasksGetByIdAsync (TaskNames taskName, string id, string fields)
        {
            // verify the required parameter 'taskName' is set
            if (taskName == null) throw new ApiException(400, "Missing required parameter 'taskName' when calling RunningTasksGetByIdAsync");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RunningTasksGetByIdAsync");
    
            var path = "/v4/RunningTasks/{taskName}/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "taskName" + "}", ApiClient.ParameterToString(taskName));
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
                throw new ApiException ((int)response.StatusCode, "Error calling RunningTasksGetByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RunningTasksGetByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (RunningTask) ApiClient.Deserialize(response.Content, typeof(RunningTask), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of running tasks by task name 
        /// </summary>
        /// <param name="taskName">Name of tasks to filter by. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="startDate">Log time range start. Default 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Log time range end (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;RunningTask&gt;</returns>
        public List<RunningTask> RunningTasksGetByNameAsync (TaskNames taskName, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'taskName' is set
            if (taskName == null) throw new ApiException(400, "Missing required parameter 'taskName' when calling RunningTasksGetByNameAsync");
    
            var path = "/v4/RunningTasks/{taskName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "taskName" + "}", ApiClient.ParameterToString(taskName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling RunningTasksGetByNameAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RunningTasksGetByNameAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<RunningTask>) ApiClient.Deserialize(response.Content, typeof(List<RunningTask>), response.Headers);
        }
    
    }
}
