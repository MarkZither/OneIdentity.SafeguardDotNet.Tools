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
    public interface ITaskLogsApi
    {
        /// <summary>
        /// Fetch a list of Task Ids for which there are task logs available 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> TaskLogsGetAsync ();
        /// <summary>
        /// Fetch a list of logs available for the Task identified by the given Id 
        /// </summary>
        /// <param name="taskId">Task Guid</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> TaskLogsGetLogsForTaskIdAsync (string taskId);
        /// <summary>
        /// Return all events from the named log for the given Task 
        /// </summary>
        /// <param name="taskId">Task Guid</param>
        /// <param name="logName">Log name</param>
        /// <returns>List&lt;Entry&gt;</returns>
        List<Entry> TaskLogsGetTaskLogAsync (string taskId, string logName);
        /// <summary>
        /// Remove all extended debug logging for platform tasks 
        /// </summary>
        /// <returns></returns>
        void TaskLogsRemoveAllLogsAsync ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TaskLogsApi : ITaskLogsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskLogsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TaskLogsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskLogsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TaskLogsApi(String basePath)
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
        /// Fetch a list of Task Ids for which there are task logs available 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> TaskLogsGetAsync ()
        {
    
            var path = "/v4/TaskLogs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TaskLogsGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TaskLogsGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Fetch a list of logs available for the Task identified by the given Id 
        /// </summary>
        /// <param name="taskId">Task Guid</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> TaskLogsGetLogsForTaskIdAsync (string taskId)
        {
            // verify the required parameter 'taskId' is set
            if (taskId == null) throw new ApiException(400, "Missing required parameter 'taskId' when calling TaskLogsGetLogsForTaskIdAsync");
    
            var path = "/v4/TaskLogs/{taskId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "taskId" + "}", ApiClient.ParameterToString(taskId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling TaskLogsGetLogsForTaskIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TaskLogsGetLogsForTaskIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Return all events from the named log for the given Task 
        /// </summary>
        /// <param name="taskId">Task Guid</param>
        /// <param name="logName">Log name</param>
        /// <returns>List&lt;Entry&gt;</returns>
        public List<Entry> TaskLogsGetTaskLogAsync (string taskId, string logName)
        {
            // verify the required parameter 'taskId' is set
            if (taskId == null) throw new ApiException(400, "Missing required parameter 'taskId' when calling TaskLogsGetTaskLogAsync");
            // verify the required parameter 'logName' is set
            if (logName == null) throw new ApiException(400, "Missing required parameter 'logName' when calling TaskLogsGetTaskLogAsync");
    
            var path = "/v4/TaskLogs/{taskId}/{logName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "taskId" + "}", ApiClient.ParameterToString(taskId));
path = path.Replace("{" + "logName" + "}", ApiClient.ParameterToString(logName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling TaskLogsGetTaskLogAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TaskLogsGetTaskLogAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Entry>) ApiClient.Deserialize(response.Content, typeof(List<Entry>), response.Headers);
        }
    
        /// <summary>
        /// Remove all extended debug logging for platform tasks 
        /// </summary>
        /// <returns></returns>
        public void TaskLogsRemoveAllLogsAsync ()
        {
    
            var path = "/v4/TaskLogs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TaskLogsRemoveAllLogsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TaskLogsRemoveAllLogsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
