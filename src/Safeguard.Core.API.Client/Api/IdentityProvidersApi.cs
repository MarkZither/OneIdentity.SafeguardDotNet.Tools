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
    public interface IIdentityProvidersApi
    {
        /// <summary>
        /// Creates a new identity provider 
        /// </summary>
        /// <param name="body">IdentityProvider to create</param>
        /// <returns>IdentityProvider</returns>
        IdentityProvider IdentityProvidersCreateIdentityProviderAsync (IdentityProvider body);
        /// <summary>
        /// Removes an identity provider 
        /// </summary>
        /// <param name="id">Unique identifier of the IdentityProvider</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        void IdentityProvidersDeleteIdentityProviderAsync (int? id, bool? forceDelete);
        /// <summary>
        /// Discovers the available domains using provided domain credentials 
        /// </summary>
        /// <param name="body">Credentials for authenticating to the directory</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DomainInfo&gt;</returns>
        List<DomainInfo> IdentityProvidersDiscoverDomainsAsync (IdentityProviderSchemaParameters body, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Discovers the available schema attributes using provided domain credentials 
        /// </summary>
        /// <param name="body">Credentials for authenticating to the directory</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DirectorySchema&gt;</returns>
        List<DirectorySchema> IdentityProvidersDiscoverSchemaAsync (IdentityProviderSchemaParameters body, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Discovers the available schema attributes using provided domain credentials for a specific object class 
        /// </summary>
        /// <param name="objectClassName">Name of object class to discover schema for</param>
        /// <param name="body">Credentials for authenticating to active directory</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>List&lt;DirectorySchema&gt;</returns>
        List<DirectorySchema> IdentityProvidersDiscoverSchemaByClassAsync (string objectClassName, IdentityProviderSchemaParameters body, string fields);
        /// <summary>
        /// Get default schema for directory provider 
        /// </summary>
        /// <param name="typeRefName">Identity provider type name</param>
        /// <returns>DefaultProviderLdapSchema</returns>
        DefaultProviderLdapSchema IdentityProvidersGetDefaultSchema (IdentityProviderTypeReferenceName typeRefName);
        /// <summary>
        /// Searches the specified directory 
        /// </summary>
        /// <param name="id">Unique ID of a Directory IdentityProvider</param>
        /// <param name="searchBase">Sets the searchBase for the Ldap query, defaults to base of the domain for ldap, or base of  forest for AD.  Must be in DN Syntax.</param>
        /// <param name="searchScope">Defines the scope of the query, either base, one, or sub, defaults to sub.</param>
        /// <param name="searchType">Either User, Group, or Computer.  Defaults to User.</param>
        /// <param name="searchName">Sets a search constraint on the \&quot;name\&quot; of the object to return.</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DirectoryServiceEntry&gt;</returns>
        List<DirectoryServiceEntry> IdentityProvidersGetEntriesAsync (int? id, string searchBase, SearchScope searchScope, DirectoryProviderSearchType searchType, string searchName, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific identity provider 
        /// </summary>
        /// <param name="id">Unique ID of IdentityProvider</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>IdentityProvider</returns>
        IdentityProvider IdentityProvidersGetIdentityProviderByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets a queryable list of identity providers 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;IdentityProvider&gt;</returns>
        List<IdentityProvider> IdentityProvidersGetIdentityProvidersAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the identity provider type associated with this provider 
        /// </summary>
        /// <param name="id">Unique identifier of the IdentityProvider</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>IdentityProviderType</returns>
        IdentityProviderType IdentityProvidersGetProviderTypeAsync (int? id, string fields);
        /// <summary>
        /// Searches the specified directory for Group objects as UserGroups 
        /// </summary>
        /// <param name="id">Unique ID of a Directory IdentityProvider</param>
        /// <param name="searchBase">Sets the searchBase for the Ldap query, defaults to base of the domain for ldap, or base of  forest for AD.  Must be in DN Syntax.</param>
        /// <param name="searchScope">Defines the scope of the query, either base, one, or sub, defaults to sub.</param>
        /// <param name="searchName">Sets a search constraint on the \&quot;name\&quot; of the object to return.</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserGroup&gt;</returns>
        List<UserGroup> IdentityProvidersSearchUserGroupsAsync (int? id, string searchBase, SearchScope searchScope, string searchName, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Searches the specified directory for User objects as Users 
        /// </summary>
        /// <param name="id">Unique ID of a Directory IdentityProvider</param>
        /// <param name="searchBase">Sets the searchBase for the Ldap query, defaults to base of the domain for ldap, or base of  forest for AD.  Must be in DN Syntax.</param>
        /// <param name="searchScope">Defines the scope of the query, either base, one, or sub, defaults to sub.</param>
        /// <param name="searchName">Sets a search constraint on the \&quot;name\&quot; of the object to return.</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;User&gt;</returns>
        List<User> IdentityProvidersSearchUsersAsync (int? id, string searchBase, SearchScope searchScope, string searchName, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Synchronize all directory related objects with the remote server 
        /// </summary>
        /// <param name="id">Unique ID of the directory</param>
        /// <param name="fullSync">Whether to sync all entities imported from this directory or just those that have been modified</param>
        /// <returns>DirectorySyncActivityLog</returns>
        DirectorySyncActivityLog IdentityProvidersSynchronizeAsync (int? id, bool? fullSync);
        /// <summary>
        /// Updates an existing identity provider 
        /// </summary>
        /// <param name="id">Unique identifier of the IdentityProvider</param>
        /// <param name="body">Updated IdentityProvider</param>
        /// <returns>IdentityProvider</returns>
        IdentityProvider IdentityProvidersUpdateIdentityProviderAsync (int? id, IdentityProvider body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class IdentityProvidersApi : IIdentityProvidersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProvidersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public IdentityProvidersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProvidersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IdentityProvidersApi(String basePath)
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
        /// Creates a new identity provider 
        /// </summary>
        /// <param name="body">IdentityProvider to create</param>
        /// <returns>IdentityProvider</returns>
        public IdentityProvider IdentityProvidersCreateIdentityProviderAsync (IdentityProvider body)
        {
    
            var path = "/v4/IdentityProviders";
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
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersCreateIdentityProviderAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersCreateIdentityProviderAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IdentityProvider) ApiClient.Deserialize(response.Content, typeof(IdentityProvider), response.Headers);
        }
    
        /// <summary>
        /// Removes an identity provider 
        /// </summary>
        /// <param name="id">Unique identifier of the IdentityProvider</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        public void IdentityProvidersDeleteIdentityProviderAsync (int? id, bool? forceDelete)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling IdentityProvidersDeleteIdentityProviderAsync");
    
            var path = "/v4/IdentityProviders/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersDeleteIdentityProviderAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersDeleteIdentityProviderAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Discovers the available domains using provided domain credentials 
        /// </summary>
        /// <param name="body">Credentials for authenticating to the directory</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DomainInfo&gt;</returns>
        public List<DomainInfo> IdentityProvidersDiscoverDomainsAsync (IdentityProviderSchemaParameters body, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/IdentityProviders/DiscoverDomains";
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
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersDiscoverDomainsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersDiscoverDomainsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DomainInfo>) ApiClient.Deserialize(response.Content, typeof(List<DomainInfo>), response.Headers);
        }
    
        /// <summary>
        /// Discovers the available schema attributes using provided domain credentials 
        /// </summary>
        /// <param name="body">Credentials for authenticating to the directory</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DirectorySchema&gt;</returns>
        public List<DirectorySchema> IdentityProvidersDiscoverSchemaAsync (IdentityProviderSchemaParameters body, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/IdentityProviders/DiscoverSchema";
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
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersDiscoverSchemaAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersDiscoverSchemaAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DirectorySchema>) ApiClient.Deserialize(response.Content, typeof(List<DirectorySchema>), response.Headers);
        }
    
        /// <summary>
        /// Discovers the available schema attributes using provided domain credentials for a specific object class 
        /// </summary>
        /// <param name="objectClassName">Name of object class to discover schema for</param>
        /// <param name="body">Credentials for authenticating to active directory</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>List&lt;DirectorySchema&gt;</returns>
        public List<DirectorySchema> IdentityProvidersDiscoverSchemaByClassAsync (string objectClassName, IdentityProviderSchemaParameters body, string fields)
        {
            // verify the required parameter 'objectClassName' is set
            if (objectClassName == null) throw new ApiException(400, "Missing required parameter 'objectClassName' when calling IdentityProvidersDiscoverSchemaByClassAsync");
    
            var path = "/v4/IdentityProviders/DiscoverSchema/{objectClassName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "objectClassName" + "}", ApiClient.ParameterToString(objectClassName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersDiscoverSchemaByClassAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersDiscoverSchemaByClassAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DirectorySchema>) ApiClient.Deserialize(response.Content, typeof(List<DirectorySchema>), response.Headers);
        }
    
        /// <summary>
        /// Get default schema for directory provider 
        /// </summary>
        /// <param name="typeRefName">Identity provider type name</param>
        /// <returns>DefaultProviderLdapSchema</returns>
        public DefaultProviderLdapSchema IdentityProvidersGetDefaultSchema (IdentityProviderTypeReferenceName typeRefName)
        {
            // verify the required parameter 'typeRefName' is set
            if (typeRefName == null) throw new ApiException(400, "Missing required parameter 'typeRefName' when calling IdentityProvidersGetDefaultSchema");
    
            var path = "/v4/IdentityProviders/DefaultSchema/{typeRefName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "typeRefName" + "}", ApiClient.ParameterToString(typeRefName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersGetDefaultSchema: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersGetDefaultSchema: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DefaultProviderLdapSchema) ApiClient.Deserialize(response.Content, typeof(DefaultProviderLdapSchema), response.Headers);
        }
    
        /// <summary>
        /// Searches the specified directory 
        /// </summary>
        /// <param name="id">Unique ID of a Directory IdentityProvider</param>
        /// <param name="searchBase">Sets the searchBase for the Ldap query, defaults to base of the domain for ldap, or base of  forest for AD.  Must be in DN Syntax.</param>
        /// <param name="searchScope">Defines the scope of the query, either base, one, or sub, defaults to sub.</param>
        /// <param name="searchType">Either User, Group, or Computer.  Defaults to User.</param>
        /// <param name="searchName">Sets a search constraint on the \&quot;name\&quot; of the object to return.</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DirectoryServiceEntry&gt;</returns>
        public List<DirectoryServiceEntry> IdentityProvidersGetEntriesAsync (int? id, string searchBase, SearchScope searchScope, DirectoryProviderSearchType searchType, string searchName, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling IdentityProvidersGetEntriesAsync");
    
            var path = "/v4/IdentityProviders/{id}/DirectoryServiceEntries";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (searchBase != null) queryParams.Add("searchBase", ApiClient.ParameterToString(searchBase)); // query parameter
 if (searchScope != null) queryParams.Add("searchScope", ApiClient.ParameterToString(searchScope)); // query parameter
 if (searchType != null) queryParams.Add("searchType", ApiClient.ParameterToString(searchType)); // query parameter
 if (searchName != null) queryParams.Add("searchName", ApiClient.ParameterToString(searchName)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersGetEntriesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersGetEntriesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DirectoryServiceEntry>) ApiClient.Deserialize(response.Content, typeof(List<DirectoryServiceEntry>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific identity provider 
        /// </summary>
        /// <param name="id">Unique ID of IdentityProvider</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>IdentityProvider</returns>
        public IdentityProvider IdentityProvidersGetIdentityProviderByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling IdentityProvidersGetIdentityProviderByIdAsync");
    
            var path = "/v4/IdentityProviders/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersGetIdentityProviderByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersGetIdentityProviderByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IdentityProvider) ApiClient.Deserialize(response.Content, typeof(IdentityProvider), response.Headers);
        }
    
        /// <summary>
        /// Gets a queryable list of identity providers 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;IdentityProvider&gt;</returns>
        public List<IdentityProvider> IdentityProvidersGetIdentityProvidersAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/IdentityProviders";
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
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersGetIdentityProvidersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersGetIdentityProvidersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<IdentityProvider>) ApiClient.Deserialize(response.Content, typeof(List<IdentityProvider>), response.Headers);
        }
    
        /// <summary>
        /// Gets the identity provider type associated with this provider 
        /// </summary>
        /// <param name="id">Unique identifier of the IdentityProvider</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>IdentityProviderType</returns>
        public IdentityProviderType IdentityProvidersGetProviderTypeAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling IdentityProvidersGetProviderTypeAsync");
    
            var path = "/v4/IdentityProviders/{id}/Type";
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
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersGetProviderTypeAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersGetProviderTypeAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IdentityProviderType) ApiClient.Deserialize(response.Content, typeof(IdentityProviderType), response.Headers);
        }
    
        /// <summary>
        /// Searches the specified directory for Group objects as UserGroups 
        /// </summary>
        /// <param name="id">Unique ID of a Directory IdentityProvider</param>
        /// <param name="searchBase">Sets the searchBase for the Ldap query, defaults to base of the domain for ldap, or base of  forest for AD.  Must be in DN Syntax.</param>
        /// <param name="searchScope">Defines the scope of the query, either base, one, or sub, defaults to sub.</param>
        /// <param name="searchName">Sets a search constraint on the \&quot;name\&quot; of the object to return.</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserGroup&gt;</returns>
        public List<UserGroup> IdentityProvidersSearchUserGroupsAsync (int? id, string searchBase, SearchScope searchScope, string searchName, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling IdentityProvidersSearchUserGroupsAsync");
    
            var path = "/v4/IdentityProviders/{id}/DirectoryUserGroups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (searchBase != null) queryParams.Add("searchBase", ApiClient.ParameterToString(searchBase)); // query parameter
 if (searchScope != null) queryParams.Add("searchScope", ApiClient.ParameterToString(searchScope)); // query parameter
 if (searchName != null) queryParams.Add("searchName", ApiClient.ParameterToString(searchName)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersSearchUserGroupsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersSearchUserGroupsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserGroup>) ApiClient.Deserialize(response.Content, typeof(List<UserGroup>), response.Headers);
        }
    
        /// <summary>
        /// Searches the specified directory for User objects as Users 
        /// </summary>
        /// <param name="id">Unique ID of a Directory IdentityProvider</param>
        /// <param name="searchBase">Sets the searchBase for the Ldap query, defaults to base of the domain for ldap, or base of  forest for AD.  Must be in DN Syntax.</param>
        /// <param name="searchScope">Defines the scope of the query, either base, one, or sub, defaults to sub.</param>
        /// <param name="searchName">Sets a search constraint on the \&quot;name\&quot; of the object to return.</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;User&gt;</returns>
        public List<User> IdentityProvidersSearchUsersAsync (int? id, string searchBase, SearchScope searchScope, string searchName, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling IdentityProvidersSearchUsersAsync");
    
            var path = "/v4/IdentityProviders/{id}/DirectoryUsers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (searchBase != null) queryParams.Add("searchBase", ApiClient.ParameterToString(searchBase)); // query parameter
 if (searchScope != null) queryParams.Add("searchScope", ApiClient.ParameterToString(searchScope)); // query parameter
 if (searchName != null) queryParams.Add("searchName", ApiClient.ParameterToString(searchName)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersSearchUsersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersSearchUsersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<User>) ApiClient.Deserialize(response.Content, typeof(List<User>), response.Headers);
        }
    
        /// <summary>
        /// Synchronize all directory related objects with the remote server 
        /// </summary>
        /// <param name="id">Unique ID of the directory</param>
        /// <param name="fullSync">Whether to sync all entities imported from this directory or just those that have been modified</param>
        /// <returns>DirectorySyncActivityLog</returns>
        public DirectorySyncActivityLog IdentityProvidersSynchronizeAsync (int? id, bool? fullSync)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling IdentityProvidersSynchronizeAsync");
    
            var path = "/v4/IdentityProviders/{id}/Synchronize";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fullSync != null) queryParams.Add("fullSync", ApiClient.ParameterToString(fullSync)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersSynchronizeAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersSynchronizeAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DirectorySyncActivityLog) ApiClient.Deserialize(response.Content, typeof(DirectorySyncActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing identity provider 
        /// </summary>
        /// <param name="id">Unique identifier of the IdentityProvider</param>
        /// <param name="body">Updated IdentityProvider</param>
        /// <returns>IdentityProvider</returns>
        public IdentityProvider IdentityProvidersUpdateIdentityProviderAsync (int? id, IdentityProvider body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling IdentityProvidersUpdateIdentityProviderAsync");
    
            var path = "/v4/IdentityProviders/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersUpdateIdentityProviderAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IdentityProvidersUpdateIdentityProviderAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (IdentityProvider) ApiClient.Deserialize(response.Content, typeof(IdentityProvider), response.Headers);
        }
    
    }
}
