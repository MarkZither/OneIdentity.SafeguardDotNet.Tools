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
    public interface IAccessRequestsApi
    {
        /// <summary>
        /// Acknowledges requests that have been denied/revoked/expired 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="body">Brief description of why action is justified</param>
        /// <returns>AccessRequest</returns>
        AccessRequest AccessRequestsAcknowledgeAsync (string id, string body);
        /// <summary>
        /// Approves the AccessRequest 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="body">Brief description of why action is justified</param>
        /// <returns>AccessRequest</returns>
        AccessRequest AccessRequestsApproveAsync (string id, string body);
        /// <summary>
        /// Processes multiple access request approvals 
        /// </summary>
        /// <param name="body">Approval requests to process</param>
        /// <returns>List&lt;AccessRequestApprovalBatchResponse&gt;</returns>
        List<AccessRequestApprovalBatchResponse> AccessRequestsApproveMultipleAsync (List<ApproveRequest> body);
        /// <summary>
        /// Cancels the AccessRequest 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="body">Brief description of why action is justified</param>
        /// <returns>AccessRequest</returns>
        AccessRequest AccessRequestsCancelAsync (string id, string body);
        /// <summary>
        /// Returns control of the session/password and finish AccessRequest 
        /// </summary>
        /// <param name="id">Unique identifier of the access request</param>
        /// <returns>AccessRequest</returns>
        AccessRequest AccessRequestsCheckInAsync (string id);
        /// <summary>
        /// Releases the password for this asset request if the request is approved and active 
        /// </summary>
        /// <param name="id">Unique identifier of the access request</param>
        /// <returns>string</returns>
        string AccessRequestsCheckOutPasswordAsync (string id);
        /// <summary>
        /// Releases the SSH key information for this asset request if the request is approved and active 
        /// </summary>
        /// <param name="id">Unique identifier of the access request</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <returns>SshKeyData</returns>
        SshKeyData AccessRequestsCheckOutSshKeyAsync (string id, SshKeyFormat keyFormat);
        /// <summary>
        /// Closes a AccessRequest pending review. Used by an admin when a review cannot be completed. 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="body">Brief description of why action is justified</param>
        /// <returns>AccessRequest</returns>
        AccessRequest AccessRequestsCloseAsync (string id, string body);
        /// <summary>
        /// Adds a new NewAccessRequest to the appliance 
        /// </summary>
        /// <param name="body">NewAccessRequest to create</param>
        /// <returns>AccessRequest</returns>
        AccessRequest AccessRequestsCreateAsync (NewAccessRequest body);
        /// <summary>
        /// Processes multiple new access requests 
        /// </summary>
        /// <param name="body">New access requests to process</param>
        /// <returns>List&lt;AccessRequestBatchResponse&gt;</returns>
        List<AccessRequestBatchResponse> AccessRequestsCreateMultipleAsync (List<NewAccessRequest> body);
        /// <summary>
        /// Denies the AccessRequest 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="body">Brief description of why action is justified</param>
        /// <returns>AccessRequest</returns>
        AccessRequest AccessRequestsDenyAsync (string id, string body);
        /// <summary>
        /// Processes multiple access request denials 
        /// </summary>
        /// <param name="body">Denial requests to process</param>
        /// <returns>List&lt;AccessRequestDenyBatchResponse&gt;</returns>
        List<AccessRequestDenyBatchResponse> AccessRequestsDenyMultipleAsync (List<DenyRequest> body);
        /// <summary>
        /// Gets all active sessions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ActiveSession&gt;</returns>
        List<ActiveSession> AccessRequestsGetActiveSessionsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets Approver Set of a single AccessRequest 
        /// </summary>
        /// <param name="id">Unique ID of AccessRequest</param>
        /// <returns>List&lt;AccessRequestApproverSet&gt;</returns>
        List<AccessRequestApproverSet> AccessRequestsGetApproverSetAsync (string id);
        /// <summary>
        /// Gets a list of AccessRequest entities for the currently authenticated user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequest&gt;</returns>
        List<AccessRequest> AccessRequestsGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a single AccessRequest 
        /// </summary>
        /// <param name="id">Unique ID of AccessRequest</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccessRequest</returns>
        AccessRequest AccessRequestsGetByIdAsync (string id, string fields);
        /// <summary>
        /// Gets a specific session of an AccessRequest 
        /// </summary>
        /// <param name="id">Unique ID of AccessRequest</param>
        /// <param name="sessionId">Unique ID of the session</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccessRequestSession</returns>
        AccessRequestSession AccessRequestsGetSessionByIdAsync (string id, int? sessionId, string fields);
        /// <summary>
        /// Retrieve the session playback data required to replay the session recording matching this session id. 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="sessionId">Unique ID of the session to replay</param>
        /// <returns>SessionPlaybackData</returns>
        SessionPlaybackData AccessRequestsGetSessionPlaybackDataAsync (string id, int? sessionId);
        /// <summary>
        /// Gets all sessions for a specific AccessRequest 
        /// </summary>
        /// <param name="id">Unique ID of AccessRequest</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequestSession&gt;</returns>
        List<AccessRequestSession> AccessRequestsGetSessionsAsync (string id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Initiate the session 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="body">Configuration for initiating session</param>
        /// <returns>SessionsLaunchData</returns>
        SessionsLaunchData AccessRequestsInitializeSessionAsync (string id, InitiateSessionParameters body);
        /// <summary>
        /// Reviews the AccessRequest release 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="body">Brief description of why action is justified</param>
        /// <returns>AccessRequest</returns>
        AccessRequest AccessRequestsReviewAsync (string id, string body);
        /// <summary>
        /// Processes multiple access request reviews 
        /// </summary>
        /// <param name="body">Review requests to process</param>
        /// <returns>List&lt;AccessRequestReviewBatchResponse&gt;</returns>
        List<AccessRequestReviewBatchResponse> AccessRequestsReviewMultipleAsync (List<ReviewRequest> body);
        /// <summary>
        /// Terminate the session 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="sessionId">Unique ID of the session to replay</param>
        /// <returns></returns>
        void AccessRequestsTerminateSessionAsync (string id, int? sessionId);
        /// <summary>
        /// Terminates the specified sessions 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>List&lt;AccessRequestSession&gt;</returns>
        List<AccessRequestSession> AccessRequestsTerminateSessionsAsync (List<RequestSessionId> body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccessRequestsApi : IAccessRequestsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRequestsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccessRequestsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRequestsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccessRequestsApi(String basePath)
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
        /// Acknowledges requests that have been denied/revoked/expired 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="body">Brief description of why action is justified</param>
        /// <returns>AccessRequest</returns>
        public AccessRequest AccessRequestsAcknowledgeAsync (string id, string body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsAcknowledgeAsync");
    
            var path = "/v4/AccessRequests/{id}/Acknowledge";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsAcknowledgeAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsAcknowledgeAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequest) ApiClient.Deserialize(response.Content, typeof(AccessRequest), response.Headers);
        }
    
        /// <summary>
        /// Approves the AccessRequest 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="body">Brief description of why action is justified</param>
        /// <returns>AccessRequest</returns>
        public AccessRequest AccessRequestsApproveAsync (string id, string body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsApproveAsync");
    
            var path = "/v4/AccessRequests/{id}/Approve";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsApproveAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsApproveAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequest) ApiClient.Deserialize(response.Content, typeof(AccessRequest), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple access request approvals 
        /// </summary>
        /// <param name="body">Approval requests to process</param>
        /// <returns>List&lt;AccessRequestApprovalBatchResponse&gt;</returns>
        public List<AccessRequestApprovalBatchResponse> AccessRequestsApproveMultipleAsync (List<ApproveRequest> body)
        {
    
            var path = "/v4/AccessRequests/BatchApprove";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsApproveMultipleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsApproveMultipleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessRequestApprovalBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<AccessRequestApprovalBatchResponse>), response.Headers);
        }
    
        /// <summary>
        /// Cancels the AccessRequest 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="body">Brief description of why action is justified</param>
        /// <returns>AccessRequest</returns>
        public AccessRequest AccessRequestsCancelAsync (string id, string body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsCancelAsync");
    
            var path = "/v4/AccessRequests/{id}/Cancel";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsCancelAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsCancelAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequest) ApiClient.Deserialize(response.Content, typeof(AccessRequest), response.Headers);
        }
    
        /// <summary>
        /// Returns control of the session/password and finish AccessRequest 
        /// </summary>
        /// <param name="id">Unique identifier of the access request</param>
        /// <returns>AccessRequest</returns>
        public AccessRequest AccessRequestsCheckInAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsCheckInAsync");
    
            var path = "/v4/AccessRequests/{id}/CheckIn";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsCheckInAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsCheckInAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequest) ApiClient.Deserialize(response.Content, typeof(AccessRequest), response.Headers);
        }
    
        /// <summary>
        /// Releases the password for this asset request if the request is approved and active 
        /// </summary>
        /// <param name="id">Unique identifier of the access request</param>
        /// <returns>string</returns>
        public string AccessRequestsCheckOutPasswordAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsCheckOutPasswordAsync");
    
            var path = "/v4/AccessRequests/{id}/CheckOutPassword";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsCheckOutPasswordAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsCheckOutPasswordAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Releases the SSH key information for this asset request if the request is approved and active 
        /// </summary>
        /// <param name="id">Unique identifier of the access request</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <returns>SshKeyData</returns>
        public SshKeyData AccessRequestsCheckOutSshKeyAsync (string id, SshKeyFormat keyFormat)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsCheckOutSshKeyAsync");
    
            var path = "/v4/AccessRequests/{id}/CheckOutSshKey";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (keyFormat != null) queryParams.Add("keyFormat", ApiClient.ParameterToString(keyFormat)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsCheckOutSshKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsCheckOutSshKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyData) ApiClient.Deserialize(response.Content, typeof(SshKeyData), response.Headers);
        }
    
        /// <summary>
        /// Closes a AccessRequest pending review. Used by an admin when a review cannot be completed. 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="body">Brief description of why action is justified</param>
        /// <returns>AccessRequest</returns>
        public AccessRequest AccessRequestsCloseAsync (string id, string body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsCloseAsync");
    
            var path = "/v4/AccessRequests/{id}/Close";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsCloseAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsCloseAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequest) ApiClient.Deserialize(response.Content, typeof(AccessRequest), response.Headers);
        }
    
        /// <summary>
        /// Adds a new NewAccessRequest to the appliance 
        /// </summary>
        /// <param name="body">NewAccessRequest to create</param>
        /// <returns>AccessRequest</returns>
        public AccessRequest AccessRequestsCreateAsync (NewAccessRequest body)
        {
    
            var path = "/v4/AccessRequests";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsCreateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsCreateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequest) ApiClient.Deserialize(response.Content, typeof(AccessRequest), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple new access requests 
        /// </summary>
        /// <param name="body">New access requests to process</param>
        /// <returns>List&lt;AccessRequestBatchResponse&gt;</returns>
        public List<AccessRequestBatchResponse> AccessRequestsCreateMultipleAsync (List<NewAccessRequest> body)
        {
    
            var path = "/v4/AccessRequests/BatchCreate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsCreateMultipleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsCreateMultipleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessRequestBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<AccessRequestBatchResponse>), response.Headers);
        }
    
        /// <summary>
        /// Denies the AccessRequest 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="body">Brief description of why action is justified</param>
        /// <returns>AccessRequest</returns>
        public AccessRequest AccessRequestsDenyAsync (string id, string body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsDenyAsync");
    
            var path = "/v4/AccessRequests/{id}/Deny";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsDenyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsDenyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequest) ApiClient.Deserialize(response.Content, typeof(AccessRequest), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple access request denials 
        /// </summary>
        /// <param name="body">Denial requests to process</param>
        /// <returns>List&lt;AccessRequestDenyBatchResponse&gt;</returns>
        public List<AccessRequestDenyBatchResponse> AccessRequestsDenyMultipleAsync (List<DenyRequest> body)
        {
    
            var path = "/v4/AccessRequests/BatchDeny";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsDenyMultipleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsDenyMultipleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessRequestDenyBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<AccessRequestDenyBatchResponse>), response.Headers);
        }
    
        /// <summary>
        /// Gets all active sessions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ActiveSession&gt;</returns>
        public List<ActiveSession> AccessRequestsGetActiveSessionsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AccessRequests/ActiveSessions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsGetActiveSessionsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsGetActiveSessionsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ActiveSession>) ApiClient.Deserialize(response.Content, typeof(List<ActiveSession>), response.Headers);
        }
    
        /// <summary>
        /// Gets Approver Set of a single AccessRequest 
        /// </summary>
        /// <param name="id">Unique ID of AccessRequest</param>
        /// <returns>List&lt;AccessRequestApproverSet&gt;</returns>
        public List<AccessRequestApproverSet> AccessRequestsGetApproverSetAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsGetApproverSetAsync");
    
            var path = "/v4/AccessRequests/{id}/ApproverSet";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsGetApproverSetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsGetApproverSetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessRequestApproverSet>) ApiClient.Deserialize(response.Content, typeof(List<AccessRequestApproverSet>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of AccessRequest entities for the currently authenticated user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequest&gt;</returns>
        public List<AccessRequest> AccessRequestsGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AccessRequests";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessRequest>) ApiClient.Deserialize(response.Content, typeof(List<AccessRequest>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single AccessRequest 
        /// </summary>
        /// <param name="id">Unique ID of AccessRequest</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccessRequest</returns>
        public AccessRequest AccessRequestsGetByIdAsync (string id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsGetByIdAsync");
    
            var path = "/v4/AccessRequests/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsGetByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsGetByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequest) ApiClient.Deserialize(response.Content, typeof(AccessRequest), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific session of an AccessRequest 
        /// </summary>
        /// <param name="id">Unique ID of AccessRequest</param>
        /// <param name="sessionId">Unique ID of the session</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccessRequestSession</returns>
        public AccessRequestSession AccessRequestsGetSessionByIdAsync (string id, int? sessionId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsGetSessionByIdAsync");
            // verify the required parameter 'sessionId' is set
            if (sessionId == null) throw new ApiException(400, "Missing required parameter 'sessionId' when calling AccessRequestsGetSessionByIdAsync");
    
            var path = "/v4/AccessRequests/{id}/Sessions/{sessionId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "sessionId" + "}", ApiClient.ParameterToString(sessionId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsGetSessionByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsGetSessionByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequestSession) ApiClient.Deserialize(response.Content, typeof(AccessRequestSession), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the session playback data required to replay the session recording matching this session id. 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="sessionId">Unique ID of the session to replay</param>
        /// <returns>SessionPlaybackData</returns>
        public SessionPlaybackData AccessRequestsGetSessionPlaybackDataAsync (string id, int? sessionId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsGetSessionPlaybackDataAsync");
            // verify the required parameter 'sessionId' is set
            if (sessionId == null) throw new ApiException(400, "Missing required parameter 'sessionId' when calling AccessRequestsGetSessionPlaybackDataAsync");
    
            var path = "/v4/AccessRequests/{id}/Sessions/{sessionId}/Playback";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "sessionId" + "}", ApiClient.ParameterToString(sessionId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsGetSessionPlaybackDataAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsGetSessionPlaybackDataAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SessionPlaybackData) ApiClient.Deserialize(response.Content, typeof(SessionPlaybackData), response.Headers);
        }
    
        /// <summary>
        /// Gets all sessions for a specific AccessRequest 
        /// </summary>
        /// <param name="id">Unique ID of AccessRequest</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequestSession&gt;</returns>
        public List<AccessRequestSession> AccessRequestsGetSessionsAsync (string id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsGetSessionsAsync");
    
            var path = "/v4/AccessRequests/{id}/Sessions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsGetSessionsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsGetSessionsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessRequestSession>) ApiClient.Deserialize(response.Content, typeof(List<AccessRequestSession>), response.Headers);
        }
    
        /// <summary>
        /// Initiate the session 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="body">Configuration for initiating session</param>
        /// <returns>SessionsLaunchData</returns>
        public SessionsLaunchData AccessRequestsInitializeSessionAsync (string id, InitiateSessionParameters body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsInitializeSessionAsync");
    
            var path = "/v4/AccessRequests/{id}/InitializeSession";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsInitializeSessionAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsInitializeSessionAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SessionsLaunchData) ApiClient.Deserialize(response.Content, typeof(SessionsLaunchData), response.Headers);
        }
    
        /// <summary>
        /// Reviews the AccessRequest release 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="body">Brief description of why action is justified</param>
        /// <returns>AccessRequest</returns>
        public AccessRequest AccessRequestsReviewAsync (string id, string body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsReviewAsync");
    
            var path = "/v4/AccessRequests/{id}/Review";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsReviewAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsReviewAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequest) ApiClient.Deserialize(response.Content, typeof(AccessRequest), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple access request reviews 
        /// </summary>
        /// <param name="body">Review requests to process</param>
        /// <returns>List&lt;AccessRequestReviewBatchResponse&gt;</returns>
        public List<AccessRequestReviewBatchResponse> AccessRequestsReviewMultipleAsync (List<ReviewRequest> body)
        {
    
            var path = "/v4/AccessRequests/BatchReview";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsReviewMultipleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsReviewMultipleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessRequestReviewBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<AccessRequestReviewBatchResponse>), response.Headers);
        }
    
        /// <summary>
        /// Terminate the session 
        /// </summary>
        /// <param name="id">Unique identifier of the AccessRequest</param>
        /// <param name="sessionId">Unique ID of the session to replay</param>
        /// <returns></returns>
        public void AccessRequestsTerminateSessionAsync (string id, int? sessionId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AccessRequestsTerminateSessionAsync");
            // verify the required parameter 'sessionId' is set
            if (sessionId == null) throw new ApiException(400, "Missing required parameter 'sessionId' when calling AccessRequestsTerminateSessionAsync");
    
            var path = "/v4/AccessRequests/{id}/Sessions/{sessionId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "sessionId" + "}", ApiClient.ParameterToString(sessionId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsTerminateSessionAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsTerminateSessionAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Terminates the specified sessions 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>List&lt;AccessRequestSession&gt;</returns>
        public List<AccessRequestSession> AccessRequestsTerminateSessionsAsync (List<RequestSessionId> body)
        {
    
            var path = "/v4/AccessRequests/ActiveSessions/Terminate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsTerminateSessionsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccessRequestsTerminateSessionsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessRequestSession>) ApiClient.Deserialize(response.Content, typeof(List<AccessRequestSession>), response.Headers);
        }
    
    }
}
