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
    public interface IArchiveServersApi
    {
        /// <summary>
        /// Creates an ArchiveServer configuration 
        /// </summary>
        /// <param name="body">ArchiveServer to create</param>
        /// <returns>ArchiveServer</returns>
        ArchiveServer ArchiveServersCreateEntityAsync (ArchiveServer body);
        /// <summary>
        /// Removes an ArchiveServer configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the ArchiveServer</param>
        /// <returns></returns>
        void ArchiveServersDeleteAsync (int? id);
        /// <summary>
        /// Gets the SSH host key for the target server 
        /// </summary>
        /// <param name="body">Configuration of target server</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>ArchiveServerSshHostKey</returns>
        ArchiveServerSshHostKey ArchiveServersDiscoverSshHostKeyAsync (ArchiveDiscoverSshHostKeyParameters body, bool? extendedLogging);
        /// <summary>
        /// Gets the SSH host key for the target server 
        /// </summary>
        /// <param name="id">Unique ID of ArchiveServer to check</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>ArchiveServerSshHostKey</returns>
        ArchiveServerSshHostKey ArchiveServersDiscoverSshHostKeyByIdAsync (int? id, bool? extendedLogging);
        /// <summary>
        /// Gets a list of all archive servers 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ArchiveServer&gt;</returns>
        List<ArchiveServer> ArchiveServersGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a single archive server 
        /// </summary>
        /// <param name="id">Unique ID of account group</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ArchiveServer</returns>
        ArchiveServer ArchiveServersGetByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets the SshHostKey identifying this archive server 
        /// </summary>
        /// <param name="id">Unique identifier of the archive server</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ArchiveServerSshHostKey</returns>
        ArchiveServerSshHostKey ArchiveServersGetSshHostKeyAsync (int? id, string fields);
        /// <summary>
        /// Installs an SSH key for the service account 
        /// </summary>
        /// <param name="body">Information about which asset to install an SSH key for the service account</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog ArchiveServersInstallSshKeyAsync (ArchiveServerCustomInstallSshKeyParameters body, bool? extendedLogging);
        /// <summary>
        /// Installs an SSH key for the service account 
        /// </summary>
        /// <param name="id">Unique identifier of the ArchiveServer</param>
        /// <param name="body">Database ID of SSH Key to install (optional - will be generated if not specified). Also option to override existing asset connection settings.</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog ArchiveServersInstallSshKeyByIdAsync (int? id, ArchiveServerSshKeyParameters body, bool? extendedLogging);
        /// <summary>
        /// Removes the ssh host id of this archive server 
        /// </summary>
        /// <param name="id">Unique identifier of the archive server</param>
        /// <returns></returns>
        void ArchiveServersRemoveSshHostKeyAsync (int? id);
        /// <summary>
        /// Updates the ssh host id of this archive server 
        /// </summary>
        /// <param name="id">Unique identifier of the archive server</param>
        /// <param name="body">SSH host id to assign to this asset</param>
        /// <returns>ArchiveServerSshHostKey</returns>
        ArchiveServerSshHostKey ArchiveServersSetSshHostKeyAsync (int? id, ArchiveServerSshHostKey body);
        /// <summary>
        /// Tests an ArchiveServer configuration 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>ArchiveActivityLog</returns>
        ArchiveActivityLog ArchiveServersTestConnectionAsync (ArchiveCustomTestConnectionParameters body);
        /// <summary>
        /// Tests an existing ArchiveServer configuration 
        /// </summary>
        /// <param name="id">Unique ID of ArchiveServer to test</param>
        /// <param name="body">Options for testing the connection</param>
        /// <returns>ArchiveActivityLog</returns>
        ArchiveActivityLog ArchiveServersTestConnectionByIdAsync (int? id, ArchiveTestConnectionParameters body);
        /// <summary>
        /// Updates an existing ArchiveServer configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the ArchiveServer</param>
        /// <param name="body">ArchiveServer to create</param>
        /// <returns>ArchiveServer</returns>
        ArchiveServer ArchiveServersUpdateEntityAsync (int? id, ArchiveServer body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ArchiveServersApi : IArchiveServersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveServersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ArchiveServersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveServersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ArchiveServersApi(String basePath)
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
        /// Creates an ArchiveServer configuration 
        /// </summary>
        /// <param name="body">ArchiveServer to create</param>
        /// <returns>ArchiveServer</returns>
        public ArchiveServer ArchiveServersCreateEntityAsync (ArchiveServer body)
        {
    
            var path = "/v4/ArchiveServers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersCreateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersCreateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ArchiveServer) ApiClient.Deserialize(response.Content, typeof(ArchiveServer), response.Headers);
        }
    
        /// <summary>
        /// Removes an ArchiveServer configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the ArchiveServer</param>
        /// <returns></returns>
        public void ArchiveServersDeleteAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchiveServersDeleteAsync");
    
            var path = "/v4/ArchiveServers/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersDeleteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersDeleteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the SSH host key for the target server 
        /// </summary>
        /// <param name="body">Configuration of target server</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>ArchiveServerSshHostKey</returns>
        public ArchiveServerSshHostKey ArchiveServersDiscoverSshHostKeyAsync (ArchiveDiscoverSshHostKeyParameters body, bool? extendedLogging)
        {
    
            var path = "/v4/ArchiveServers/DiscoverSshHostKey";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (extendedLogging != null) queryParams.Add("extendedLogging", ApiClient.ParameterToString(extendedLogging)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersDiscoverSshHostKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersDiscoverSshHostKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ArchiveServerSshHostKey) ApiClient.Deserialize(response.Content, typeof(ArchiveServerSshHostKey), response.Headers);
        }
    
        /// <summary>
        /// Gets the SSH host key for the target server 
        /// </summary>
        /// <param name="id">Unique ID of ArchiveServer to check</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>ArchiveServerSshHostKey</returns>
        public ArchiveServerSshHostKey ArchiveServersDiscoverSshHostKeyByIdAsync (int? id, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchiveServersDiscoverSshHostKeyByIdAsync");
    
            var path = "/v4/ArchiveServers/{id}/DiscoverSshHostKey";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (extendedLogging != null) queryParams.Add("extendedLogging", ApiClient.ParameterToString(extendedLogging)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersDiscoverSshHostKeyByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersDiscoverSshHostKeyByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ArchiveServerSshHostKey) ApiClient.Deserialize(response.Content, typeof(ArchiveServerSshHostKey), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of all archive servers 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ArchiveServer&gt;</returns>
        public List<ArchiveServer> ArchiveServersGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/ArchiveServers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ArchiveServer>) ApiClient.Deserialize(response.Content, typeof(List<ArchiveServer>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single archive server 
        /// </summary>
        /// <param name="id">Unique ID of account group</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ArchiveServer</returns>
        public ArchiveServer ArchiveServersGetByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchiveServersGetByIdAsync");
    
            var path = "/v4/ArchiveServers/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersGetByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersGetByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ArchiveServer) ApiClient.Deserialize(response.Content, typeof(ArchiveServer), response.Headers);
        }
    
        /// <summary>
        /// Gets the SshHostKey identifying this archive server 
        /// </summary>
        /// <param name="id">Unique identifier of the archive server</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ArchiveServerSshHostKey</returns>
        public ArchiveServerSshHostKey ArchiveServersGetSshHostKeyAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchiveServersGetSshHostKeyAsync");
    
            var path = "/v4/ArchiveServers/{id}/SshHostKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersGetSshHostKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersGetSshHostKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ArchiveServerSshHostKey) ApiClient.Deserialize(response.Content, typeof(ArchiveServerSshHostKey), response.Headers);
        }
    
        /// <summary>
        /// Installs an SSH key for the service account 
        /// </summary>
        /// <param name="body">Information about which asset to install an SSH key for the service account</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog ArchiveServersInstallSshKeyAsync (ArchiveServerCustomInstallSshKeyParameters body, bool? extendedLogging)
        {
    
            var path = "/v4/ArchiveServers/InstallSshKey";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (extendedLogging != null) queryParams.Add("extendedLogging", ApiClient.ParameterToString(extendedLogging)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersInstallSshKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersInstallSshKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Installs an SSH key for the service account 
        /// </summary>
        /// <param name="id">Unique identifier of the ArchiveServer</param>
        /// <param name="body">Database ID of SSH Key to install (optional - will be generated if not specified). Also option to override existing asset connection settings.</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog ArchiveServersInstallSshKeyByIdAsync (int? id, ArchiveServerSshKeyParameters body, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchiveServersInstallSshKeyByIdAsync");
    
            var path = "/v4/ArchiveServers/{id}/InstallSshKey";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (extendedLogging != null) queryParams.Add("extendedLogging", ApiClient.ParameterToString(extendedLogging)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersInstallSshKeyByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersInstallSshKeyByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Removes the ssh host id of this archive server 
        /// </summary>
        /// <param name="id">Unique identifier of the archive server</param>
        /// <returns></returns>
        public void ArchiveServersRemoveSshHostKeyAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchiveServersRemoveSshHostKeyAsync");
    
            var path = "/v4/ArchiveServers/{id}/SshHostKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersRemoveSshHostKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersRemoveSshHostKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the ssh host id of this archive server 
        /// </summary>
        /// <param name="id">Unique identifier of the archive server</param>
        /// <param name="body">SSH host id to assign to this asset</param>
        /// <returns>ArchiveServerSshHostKey</returns>
        public ArchiveServerSshHostKey ArchiveServersSetSshHostKeyAsync (int? id, ArchiveServerSshHostKey body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchiveServersSetSshHostKeyAsync");
    
            var path = "/v4/ArchiveServers/{id}/SshHostKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersSetSshHostKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersSetSshHostKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ArchiveServerSshHostKey) ApiClient.Deserialize(response.Content, typeof(ArchiveServerSshHostKey), response.Headers);
        }
    
        /// <summary>
        /// Tests an ArchiveServer configuration 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>ArchiveActivityLog</returns>
        public ArchiveActivityLog ArchiveServersTestConnectionAsync (ArchiveCustomTestConnectionParameters body)
        {
    
            var path = "/v4/ArchiveServers/TestConnection";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersTestConnectionAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersTestConnectionAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ArchiveActivityLog) ApiClient.Deserialize(response.Content, typeof(ArchiveActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Tests an existing ArchiveServer configuration 
        /// </summary>
        /// <param name="id">Unique ID of ArchiveServer to test</param>
        /// <param name="body">Options for testing the connection</param>
        /// <returns>ArchiveActivityLog</returns>
        public ArchiveActivityLog ArchiveServersTestConnectionByIdAsync (int? id, ArchiveTestConnectionParameters body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchiveServersTestConnectionByIdAsync");
    
            var path = "/v4/ArchiveServers/{id}/TestConnection";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersTestConnectionByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersTestConnectionByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ArchiveActivityLog) ApiClient.Deserialize(response.Content, typeof(ArchiveActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing ArchiveServer configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the ArchiveServer</param>
        /// <param name="body">ArchiveServer to create</param>
        /// <returns>ArchiveServer</returns>
        public ArchiveServer ArchiveServersUpdateEntityAsync (int? id, ArchiveServer body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ArchiveServersUpdateEntityAsync");
    
            var path = "/v4/ArchiveServers/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersUpdateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ArchiveServersUpdateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ArchiveServer) ApiClient.Deserialize(response.Content, typeof(ArchiveServer), response.Headers);
        }
    
    }
}
