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
    public interface IPlatformsApi
    {
        /// <summary>
        /// Create a starling connect or custom platform 
        /// </summary>
        /// <param name="body">Platform to create</param>
        /// <returns>Platform</returns>
        Platform PlatformsCreatePlatformAsync (Platform body);
        /// <summary>
        /// Removes a Platform 
        /// </summary>
        /// <param name="id">Unique identifier of the Platform</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        void PlatformsDeletePlatformAsync (int? id, bool? forceDelete);
        /// <summary>
        /// Removes script for the custom platform 
        /// </summary>
        /// <param name="id">Unique ID of Platform</param>
        /// <returns></returns>
        void PlatformsDeleteScriptAsync (int? id);
        /// <summary>
        /// Gets a specific platform 
        /// </summary>
        /// <param name="id">Unique ID of Platform</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Platform</returns>
        Platform PlatformsGetPlatformByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets the script associated with a custom platform 
        /// </summary>
        /// <param name="id">Unique ID of Platform</param>
        /// <returns>string</returns>
        string PlatformsGetPlatformScriptAsync (int? id);
        /// <summary>
        /// Gets the script associated with a custom platform in raw format 
        /// </summary>
        /// <param name="id">Unique ID of Platform</param>
        /// <returns>byte[]</returns>
        byte[] PlatformsGetPlatformScriptRawAsync (int? id);
        /// <summary>
        /// Gets a list of platforms 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Platform&gt;</returns>
        List<Platform> PlatformsGetPlatformsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Updates script for the custom platform in raw format. This receives an httpStream of the file contents of the platform script file. 
        /// </summary>
        /// <param name="id">Unique ID of Platform</param>
        /// <param name="body"></param>
        /// <returns>Platform</returns>
        Platform PlatformsPutRawScriptAsync (int? id, ScriptRawBody body);
        /// <summary>
        /// Updates script for the custom platform in base64 format 
        /// </summary>
        /// <param name="id">Unique ID of Platform</param>
        /// <param name="body">Updated base64 platform script</param>
        /// <returns>Platform</returns>
        Platform PlatformsPutScriptAsync (int? id, string body);
        /// <summary>
        /// Updates a custom platform 
        /// </summary>
        /// <param name="id">Unique identifier of the Platform</param>
        /// <param name="body">Updated Platform</param>
        /// <returns>Platform</returns>
        Platform PlatformsUpdatePlatformAsync (int? id, Platform body);
        /// <summary>
        /// Validates script for the custom platform in raw format. This receives an httpStream of the file contents of the platform script file. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Platform</returns>
        Platform PlatformsValidateRawScriptAsync (ValidateScriptRawBody body);
        /// <summary>
        /// Validates script for the custom platform in base64 format 
        /// </summary>
        /// <param name="body">Updated base64 platform script</param>
        /// <returns>Platform</returns>
        Platform PlatformsValidateScriptAsync (string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PlatformsApi : IPlatformsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PlatformsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PlatformsApi(String basePath)
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
        /// Create a starling connect or custom platform 
        /// </summary>
        /// <param name="body">Platform to create</param>
        /// <returns>Platform</returns>
        public Platform PlatformsCreatePlatformAsync (Platform body)
        {
    
            var path = "/v4/Platforms";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsCreatePlatformAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsCreatePlatformAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Platform) ApiClient.Deserialize(response.Content, typeof(Platform), response.Headers);
        }
    
        /// <summary>
        /// Removes a Platform 
        /// </summary>
        /// <param name="id">Unique identifier of the Platform</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        public void PlatformsDeletePlatformAsync (int? id, bool? forceDelete)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PlatformsDeletePlatformAsync");
    
            var path = "/v4/Platforms/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsDeletePlatformAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsDeletePlatformAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes script for the custom platform 
        /// </summary>
        /// <param name="id">Unique ID of Platform</param>
        /// <returns></returns>
        public void PlatformsDeleteScriptAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PlatformsDeleteScriptAsync");
    
            var path = "/v4/Platforms/{id}/Script";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsDeleteScriptAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsDeleteScriptAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a specific platform 
        /// </summary>
        /// <param name="id">Unique ID of Platform</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Platform</returns>
        public Platform PlatformsGetPlatformByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PlatformsGetPlatformByIdAsync");
    
            var path = "/v4/Platforms/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsGetPlatformByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsGetPlatformByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Platform) ApiClient.Deserialize(response.Content, typeof(Platform), response.Headers);
        }
    
        /// <summary>
        /// Gets the script associated with a custom platform 
        /// </summary>
        /// <param name="id">Unique ID of Platform</param>
        /// <returns>string</returns>
        public string PlatformsGetPlatformScriptAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PlatformsGetPlatformScriptAsync");
    
            var path = "/v4/Platforms/{id}/Script";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsGetPlatformScriptAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsGetPlatformScriptAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Gets the script associated with a custom platform in raw format 
        /// </summary>
        /// <param name="id">Unique ID of Platform</param>
        /// <returns>byte[]</returns>
        public byte[] PlatformsGetPlatformScriptRawAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PlatformsGetPlatformScriptRawAsync");
    
            var path = "/v4/Platforms/{id}/Script/Raw";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsGetPlatformScriptRawAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsGetPlatformScriptRawAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of platforms 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Platform&gt;</returns>
        public List<Platform> PlatformsGetPlatformsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Platforms";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsGetPlatformsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsGetPlatformsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Platform>) ApiClient.Deserialize(response.Content, typeof(List<Platform>), response.Headers);
        }
    
        /// <summary>
        /// Updates script for the custom platform in raw format. This receives an httpStream of the file contents of the platform script file. 
        /// </summary>
        /// <param name="id">Unique ID of Platform</param>
        /// <param name="body"></param>
        /// <returns>Platform</returns>
        public Platform PlatformsPutRawScriptAsync (int? id, ScriptRawBody body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PlatformsPutRawScriptAsync");
    
            var path = "/v4/Platforms/{id}/Script/Raw";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsPutRawScriptAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsPutRawScriptAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Platform) ApiClient.Deserialize(response.Content, typeof(Platform), response.Headers);
        }
    
        /// <summary>
        /// Updates script for the custom platform in base64 format 
        /// </summary>
        /// <param name="id">Unique ID of Platform</param>
        /// <param name="body">Updated base64 platform script</param>
        /// <returns>Platform</returns>
        public Platform PlatformsPutScriptAsync (int? id, string body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PlatformsPutScriptAsync");
    
            var path = "/v4/Platforms/{id}/Script";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsPutScriptAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsPutScriptAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Platform) ApiClient.Deserialize(response.Content, typeof(Platform), response.Headers);
        }
    
        /// <summary>
        /// Updates a custom platform 
        /// </summary>
        /// <param name="id">Unique identifier of the Platform</param>
        /// <param name="body">Updated Platform</param>
        /// <returns>Platform</returns>
        public Platform PlatformsUpdatePlatformAsync (int? id, Platform body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PlatformsUpdatePlatformAsync");
    
            var path = "/v4/Platforms/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsUpdatePlatformAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsUpdatePlatformAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Platform) ApiClient.Deserialize(response.Content, typeof(Platform), response.Headers);
        }
    
        /// <summary>
        /// Validates script for the custom platform in raw format. This receives an httpStream of the file contents of the platform script file. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Platform</returns>
        public Platform PlatformsValidateRawScriptAsync (ValidateScriptRawBody body)
        {
    
            var path = "/v4/Platforms/ValidateScript/Raw";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsValidateRawScriptAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsValidateRawScriptAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Platform) ApiClient.Deserialize(response.Content, typeof(Platform), response.Headers);
        }
    
        /// <summary>
        /// Validates script for the custom platform in base64 format 
        /// </summary>
        /// <param name="body">Updated base64 platform script</param>
        /// <returns>Platform</returns>
        public Platform PlatformsValidateScriptAsync (string body)
        {
    
            var path = "/v4/Platforms/ValidateScript";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsValidateScriptAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlatformsValidateScriptAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Platform) ApiClient.Deserialize(response.Content, typeof(Platform), response.Headers);
        }
    
    }
}
