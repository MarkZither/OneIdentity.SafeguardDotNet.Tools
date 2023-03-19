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
    public interface IAssetAccountsApi
    {
        /// <summary>
        /// Changes account password on the remote system 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AssetAccountsChangePasswordAsync (int? id, bool? extendedLogging);
        /// <summary>
        /// Changes account SSH key on the remote system 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AssetAccountsChangeSshKeyAsync (int? id, bool? extendedLogging);
        /// <summary>
        /// Checks if account password matches stored password 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AssetAccountsCheckPasswordAsync (int? id, bool? extendedLogging);
        /// <summary>
        /// Checks if account SSH key matches stored password 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AssetAccountsCheckSshKeyAsync (int? id, bool? extendedLogging);
        /// <summary>
        /// Adds a new asset account to the appliance 
        /// </summary>
        /// <param name="body">AssetAccount to create</param>
        /// <returns>AssetAccount</returns>
        AssetAccount AssetAccountsCreateAssetAccountAsync (AssetAccount body);
        /// <summary>
        /// Processes multiple new asset accounts 
        /// </summary>
        /// <param name="body">New asset accounts to process</param>
        /// <returns>List&lt;AssetAccountBatchResponse&gt;</returns>
        List<AssetAccountBatchResponse> AssetAccountsCreateMultipleAccountsAsync (List<AssetAccount> body);
        /// <summary>
        /// Removes an account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to remove</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        void AssetAccountsDeleteAssetAccountAsync (int? id, bool? forceDelete);
        /// <summary>
        /// Processes multiple asset account deletes 
        /// </summary>
        /// <param name="body">asset accounts to process</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns>List&lt;AssetAccountBatchResult&gt;</returns>
        List<AssetAccountBatchResult> AssetAccountsDeleteMultipleAsync (List<int?> body, bool? forceDelete);
        /// <summary>
        /// Disable account from automated platform tasks and requests 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <returns>AssetAccount</returns>
        AssetAccount AssetAccountsDisableAssetAccountAsync (int? id);
        /// <summary>
        /// Discovers authorized keys for the account on the remote system 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>SshKeyDiscoveryLog</returns>
        SshKeyDiscoveryLog AssetAccountsDiscoverSshKeysAsync (int? id, bool? extendedLogging);
        /// <summary>
        /// Enable account from automated platform tasks and requests 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <returns>AssetAccount</returns>
        AssetAccount AssetAccountsEnableAssetAccountAsync (int? id);
        /// <summary>
        /// Generate sample password using password rule assigned to this account 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <returns>string</returns>
        string AssetAccountsGeneratePasswordAsync (int? id);
        /// <summary>
        /// Gets an account&#x27;s tags 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, in, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Tag&gt;</returns>
        List<Tag> AssetAccountsGetAccountTagsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of accounts across all partitions 
        /// </summary>
        /// <param name="tagNames">List of comma-separated tag IDs by which to filter results. Preferred over using filter.</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetAccountsGetAllAccountsAsync (string tagNames, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets an asset account 
        /// </summary>
        /// <param name="id">Unique ID of an AssetAccount</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AssetAccount</returns>
        AssetAccount AssetAccountsGetAssetAccountByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets all effective owners of the specified account 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;EffectiveIdentity&gt;</returns>
        List<EffectiveIdentity> AssetAccountsGetAssetAccountEffectiveManagedByAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all owners of the specified account 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> AssetAccountsGetAssetAccountManagedByAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets systems that are dependent on this directory account 
        /// </summary>
        /// <param name="id">Unique identifier of the directory account</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, in, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyAsset&gt;</returns>
        List<PolicyAsset> AssetAccountsGetDependentSystemsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the discovered SSH keys for this account 
        /// </summary>
        /// <param name="id">Unique ID of the account</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredSshKey&gt;</returns>
        List<DiscoveredSshKey> AssetAccountsGetDiscoveredSshKeysAsync (int? id, SshKeyFormat keyFormat, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Get the SSH key assigned to this account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="keyFormat">The format of the SSH public key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <returns>AccountSshKey</returns>
        AccountSshKey AssetAccountsGetSshKeyAsync (int? id, string fields, SshKeyFormat keyFormat);
        /// <summary>
        /// Gets SSH keys previously assigned to the account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to set password for</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <param name="startDate">Get past passwords that were active after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get past passwords that were active before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountSshKeyHistory&gt;</returns>
        List<AccountSshKeyHistory> AssetAccountsGetSshKeyHistoryAsync (int? id, SshKeyFormat keyFormat, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all Tasks that have been executed against this account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to get tasks for</param>
        /// <param name="startDate">Log time range start. Default 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Log time range end (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordActivityLog&gt;</returns>
        List<PasswordActivityLog> AssetAccountsGetTasksAsync (int? id, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Installs the SSH key assigned to the account on the remote system 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AssetAccountsInstallSshKeyAsync (int? id, bool? extendedLogging);
        /// <summary>
        /// Add/Remove tags on this account 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">List of tags to assign to this account</param>
        /// <returns>List&lt;Tag&gt;</returns>
        List<Tag> AssetAccountsModifyAccountTagsAsync (int? id, ListOperation operation, List<Tag> body);
        /// <summary>
        /// Add/Remove assigned owners of this account 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">List of owners to assign to this account</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> AssetAccountsModifyManagedByAsync (int? id, ListOperation operation, List<Identity> body);
        /// <summary>
        /// Unassign the SSH key assigned to this account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        void AssetAccountsRemoveSshKeyAsync (int? id, bool? forceDelete);
        /// <summary>
        /// Restore the account on the remote system 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AssetAccountsRestoreAccountAsync (int? id, bool? extendedLogging);
        /// <summary>
        /// Gets passwords previously assigned to the account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to set password for</param>
        /// <param name="startDate">Get past passwords that were active after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get past passwords that were active before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountPassword&gt;</returns>
        List<AccountPassword> AssetAccountsRetrievePastPasswordsAsync (int? id, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Revokes a discovered SSH authorized key by removing it from the authorized key store on the asset for this account 
        /// </summary>
        /// <param name="id">Unique ID of the account</param>
        /// <param name="fingerprint">Fingerprint of the SSH key to be removed</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AssetAccountsRevokeSshKeyAsync (int? id, string fingerprint, bool? extendedLogging);
        /// <summary>
        /// Updates the assigned owners of this account 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <param name="body">List of owners to assign to this account</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> AssetAccountsSetAssetAccountManagedByAsync (int? id, List<Identity> body);
        /// <summary>
        /// Sets the account password 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to set password for</param>
        /// <param name="body">Password to set for this account. Maximum length is 1 MB.</param>
        /// <returns></returns>
        void AssetAccountsSetPasswordAsync (int? id, string body);
        /// <summary>
        /// Assign a specific SSH key to this account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="body">SSH key to assign to account. If no PrivateKey is provided a new key will be generated.</param>
        /// <param name="keyFormat">The format of the SSH public key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <returns>AccountSshKey</returns>
        AccountSshKey AssetAccountsSetSshKeyAsync (int? id, AccountSshKey body, SshKeyFormat keyFormat);
        /// <summary>
        /// Suspend the account on the remote system 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AssetAccountsSuspendAccountAsync (int? id, bool? extendedLogging);
        /// <summary>
        /// Updates an account&#x27;s tags 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <param name="body">List of tags to associate with the account</param>
        /// <returns>List&lt;Tag&gt;</returns>
        List<Tag> AssetAccountsUpdateAccountTagsAsync (int? id, List<Tag> body);
        /// <summary>
        /// Updates an existing asset account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to update</param>
        /// <param name="body">Updated AssetAccount</param>
        /// <returns>AssetAccount</returns>
        AssetAccount AssetAccountsUpdateAssetAccountAsync (int? id, AssetAccount body);
        /// <summary>
        /// Processes multiple asset account updates 
        /// </summary>
        /// <param name="body">asset accounts to process</param>
        /// <returns>List&lt;AssetAccountBatchResponse&gt;</returns>
        List<AssetAccountBatchResponse> AssetAccountsUpdateMultipleAccountsAsync (List<AssetAccount> body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AssetAccountsApi : IAssetAccountsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetAccountsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AssetAccountsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetAccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AssetAccountsApi(String basePath)
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
        /// Changes account password on the remote system 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AssetAccountsChangePasswordAsync (int? id, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsChangePasswordAsync");
    
            var path = "/v4/AssetAccounts/{id}/ChangePassword";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsChangePasswordAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsChangePasswordAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Changes account SSH key on the remote system 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AssetAccountsChangeSshKeyAsync (int? id, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsChangeSshKeyAsync");
    
            var path = "/v4/AssetAccounts/{id}/ChangeSshKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsChangeSshKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsChangeSshKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Checks if account password matches stored password 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AssetAccountsCheckPasswordAsync (int? id, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsCheckPasswordAsync");
    
            var path = "/v4/AssetAccounts/{id}/CheckPassword";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsCheckPasswordAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsCheckPasswordAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Checks if account SSH key matches stored password 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AssetAccountsCheckSshKeyAsync (int? id, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsCheckSshKeyAsync");
    
            var path = "/v4/AssetAccounts/{id}/CheckSshKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsCheckSshKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsCheckSshKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Adds a new asset account to the appliance 
        /// </summary>
        /// <param name="body">AssetAccount to create</param>
        /// <returns>AssetAccount</returns>
        public AssetAccount AssetAccountsCreateAssetAccountAsync (AssetAccount body)
        {
    
            var path = "/v4/AssetAccounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsCreateAssetAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsCreateAssetAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetAccount) ApiClient.Deserialize(response.Content, typeof(AssetAccount), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple new asset accounts 
        /// </summary>
        /// <param name="body">New asset accounts to process</param>
        /// <returns>List&lt;AssetAccountBatchResponse&gt;</returns>
        public List<AssetAccountBatchResponse> AssetAccountsCreateMultipleAccountsAsync (List<AssetAccount> body)
        {
    
            var path = "/v4/AssetAccounts/BatchCreate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsCreateMultipleAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsCreateMultipleAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccountBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccountBatchResponse>), response.Headers);
        }
    
        /// <summary>
        /// Removes an account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to remove</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        public void AssetAccountsDeleteAssetAccountAsync (int? id, bool? forceDelete)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsDeleteAssetAccountAsync");
    
            var path = "/v4/AssetAccounts/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsDeleteAssetAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsDeleteAssetAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Processes multiple asset account deletes 
        /// </summary>
        /// <param name="body">asset accounts to process</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns>List&lt;AssetAccountBatchResult&gt;</returns>
        public List<AssetAccountBatchResult> AssetAccountsDeleteMultipleAsync (List<int?> body, bool? forceDelete)
        {
    
            var path = "/v4/AssetAccounts/BatchDelete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (forceDelete != null) queryParams.Add("forceDelete", ApiClient.ParameterToString(forceDelete)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsDeleteMultipleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsDeleteMultipleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccountBatchResult>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccountBatchResult>), response.Headers);
        }
    
        /// <summary>
        /// Disable account from automated platform tasks and requests 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <returns>AssetAccount</returns>
        public AssetAccount AssetAccountsDisableAssetAccountAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsDisableAssetAccountAsync");
    
            var path = "/v4/AssetAccounts/{id}/Disable";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsDisableAssetAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsDisableAssetAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetAccount) ApiClient.Deserialize(response.Content, typeof(AssetAccount), response.Headers);
        }
    
        /// <summary>
        /// Discovers authorized keys for the account on the remote system 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>SshKeyDiscoveryLog</returns>
        public SshKeyDiscoveryLog AssetAccountsDiscoverSshKeysAsync (int? id, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsDiscoverSshKeysAsync");
    
            var path = "/v4/AssetAccounts/{id}/DiscoverSshKeys";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsDiscoverSshKeysAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsDiscoverSshKeysAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyDiscoveryLog) ApiClient.Deserialize(response.Content, typeof(SshKeyDiscoveryLog), response.Headers);
        }
    
        /// <summary>
        /// Enable account from automated platform tasks and requests 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <returns>AssetAccount</returns>
        public AssetAccount AssetAccountsEnableAssetAccountAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsEnableAssetAccountAsync");
    
            var path = "/v4/AssetAccounts/{id}/Enable";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsEnableAssetAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsEnableAssetAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetAccount) ApiClient.Deserialize(response.Content, typeof(AssetAccount), response.Headers);
        }
    
        /// <summary>
        /// Generate sample password using password rule assigned to this account 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <returns>string</returns>
        public string AssetAccountsGeneratePasswordAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsGeneratePasswordAsync");
    
            var path = "/v4/AssetAccounts/{id}/GeneratePassword";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGeneratePasswordAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGeneratePasswordAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Gets an account&#x27;s tags 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, in, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Tag&gt;</returns>
        public List<Tag> AssetAccountsGetAccountTagsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsGetAccountTagsAsync");
    
            var path = "/v4/AssetAccounts/{id}/Tags";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetAccountTagsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetAccountTagsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Tag>) ApiClient.Deserialize(response.Content, typeof(List<Tag>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of accounts across all partitions 
        /// </summary>
        /// <param name="tagNames">List of comma-separated tag IDs by which to filter results. Preferred over using filter.</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetAccountsGetAllAccountsAsync (string tagNames, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetAccounts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (tagNames != null) queryParams.Add("tagNames", ApiClient.ParameterToString(tagNames)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetAllAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetAllAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets an asset account 
        /// </summary>
        /// <param name="id">Unique ID of an AssetAccount</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AssetAccount</returns>
        public AssetAccount AssetAccountsGetAssetAccountByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsGetAssetAccountByIdAsync");
    
            var path = "/v4/AssetAccounts/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetAssetAccountByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetAssetAccountByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetAccount) ApiClient.Deserialize(response.Content, typeof(AssetAccount), response.Headers);
        }
    
        /// <summary>
        /// Gets all effective owners of the specified account 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;EffectiveIdentity&gt;</returns>
        public List<EffectiveIdentity> AssetAccountsGetAssetAccountEffectiveManagedByAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsGetAssetAccountEffectiveManagedByAsync");
    
            var path = "/v4/AssetAccounts/{id}/EffectiveManagedBy";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetAssetAccountEffectiveManagedByAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetAssetAccountEffectiveManagedByAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<EffectiveIdentity>) ApiClient.Deserialize(response.Content, typeof(List<EffectiveIdentity>), response.Headers);
        }
    
        /// <summary>
        /// Gets all owners of the specified account 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> AssetAccountsGetAssetAccountManagedByAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsGetAssetAccountManagedByAsync");
    
            var path = "/v4/AssetAccounts/{id}/ManagedBy";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetAssetAccountManagedByAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetAssetAccountManagedByAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Gets systems that are dependent on this directory account 
        /// </summary>
        /// <param name="id">Unique identifier of the directory account</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, in, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyAsset&gt;</returns>
        public List<PolicyAsset> AssetAccountsGetDependentSystemsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsGetDependentSystemsAsync");
    
            var path = "/v4/AssetAccounts/{id}/DependentSystems";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetDependentSystemsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetDependentSystemsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyAsset>) ApiClient.Deserialize(response.Content, typeof(List<PolicyAsset>), response.Headers);
        }
    
        /// <summary>
        /// Gets the discovered SSH keys for this account 
        /// </summary>
        /// <param name="id">Unique ID of the account</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredSshKey&gt;</returns>
        public List<DiscoveredSshKey> AssetAccountsGetDiscoveredSshKeysAsync (int? id, SshKeyFormat keyFormat, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsGetDiscoveredSshKeysAsync");
    
            var path = "/v4/AssetAccounts/{id}/DiscoveredSshKeys";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (keyFormat != null) queryParams.Add("keyFormat", ApiClient.ParameterToString(keyFormat)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetDiscoveredSshKeysAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetDiscoveredSshKeysAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredSshKey>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredSshKey>), response.Headers);
        }
    
        /// <summary>
        /// Get the SSH key assigned to this account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="keyFormat">The format of the SSH public key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <returns>AccountSshKey</returns>
        public AccountSshKey AssetAccountsGetSshKeyAsync (int? id, string fields, SshKeyFormat keyFormat)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsGetSshKeyAsync");
    
            var path = "/v4/AssetAccounts/{id}/SshKey";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (keyFormat != null) queryParams.Add("keyFormat", ApiClient.ParameterToString(keyFormat)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetSshKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetSshKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountSshKey) ApiClient.Deserialize(response.Content, typeof(AccountSshKey), response.Headers);
        }
    
        /// <summary>
        /// Gets SSH keys previously assigned to the account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to set password for</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <param name="startDate">Get past passwords that were active after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get past passwords that were active before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountSshKeyHistory&gt;</returns>
        public List<AccountSshKeyHistory> AssetAccountsGetSshKeyHistoryAsync (int? id, SshKeyFormat keyFormat, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsGetSshKeyHistoryAsync");
    
            var path = "/v4/AssetAccounts/{id}/SshKeys";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (keyFormat != null) queryParams.Add("keyFormat", ApiClient.ParameterToString(keyFormat)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetSshKeyHistoryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetSshKeyHistoryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountSshKeyHistory>) ApiClient.Deserialize(response.Content, typeof(List<AccountSshKeyHistory>), response.Headers);
        }
    
        /// <summary>
        /// Gets all Tasks that have been executed against this account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to get tasks for</param>
        /// <param name="startDate">Log time range start. Default 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Log time range end (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordActivityLog&gt;</returns>
        public List<PasswordActivityLog> AssetAccountsGetTasksAsync (int? id, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsGetTasksAsync");
    
            var path = "/v4/AssetAccounts/{id}/Tasks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetTasksAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsGetTasksAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PasswordActivityLog>) ApiClient.Deserialize(response.Content, typeof(List<PasswordActivityLog>), response.Headers);
        }
    
        /// <summary>
        /// Installs the SSH key assigned to the account on the remote system 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AssetAccountsInstallSshKeyAsync (int? id, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsInstallSshKeyAsync");
    
            var path = "/v4/AssetAccounts/{id}/InstallSshKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsInstallSshKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsInstallSshKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove tags on this account 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">List of tags to assign to this account</param>
        /// <returns>List&lt;Tag&gt;</returns>
        public List<Tag> AssetAccountsModifyAccountTagsAsync (int? id, ListOperation operation, List<Tag> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsModifyAccountTagsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetAccountsModifyAccountTagsAsync");
    
            var path = "/v4/AssetAccounts/{id}/Tags/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsModifyAccountTagsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsModifyAccountTagsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Tag>) ApiClient.Deserialize(response.Content, typeof(List<Tag>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove assigned owners of this account 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">List of owners to assign to this account</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> AssetAccountsModifyManagedByAsync (int? id, ListOperation operation, List<Identity> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsModifyManagedByAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetAccountsModifyManagedByAsync");
    
            var path = "/v4/AssetAccounts/{id}/ManagedBy/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsModifyManagedByAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsModifyManagedByAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Unassign the SSH key assigned to this account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        public void AssetAccountsRemoveSshKeyAsync (int? id, bool? forceDelete)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsRemoveSshKeyAsync");
    
            var path = "/v4/AssetAccounts/{id}/SshKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsRemoveSshKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsRemoveSshKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Restore the account on the remote system 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AssetAccountsRestoreAccountAsync (int? id, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsRestoreAccountAsync");
    
            var path = "/v4/AssetAccounts/{id}/RestoreAccount";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsRestoreAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsRestoreAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Gets passwords previously assigned to the account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to set password for</param>
        /// <param name="startDate">Get past passwords that were active after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get past passwords that were active before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountPassword&gt;</returns>
        public List<AccountPassword> AssetAccountsRetrievePastPasswordsAsync (int? id, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsRetrievePastPasswordsAsync");
    
            var path = "/v4/AssetAccounts/{id}/Passwords";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsRetrievePastPasswordsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsRetrievePastPasswordsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountPassword>) ApiClient.Deserialize(response.Content, typeof(List<AccountPassword>), response.Headers);
        }
    
        /// <summary>
        /// Revokes a discovered SSH authorized key by removing it from the authorized key store on the asset for this account 
        /// </summary>
        /// <param name="id">Unique ID of the account</param>
        /// <param name="fingerprint">Fingerprint of the SSH key to be removed</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AssetAccountsRevokeSshKeyAsync (int? id, string fingerprint, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsRevokeSshKeyAsync");
            // verify the required parameter 'fingerprint' is set
            if (fingerprint == null) throw new ApiException(400, "Missing required parameter 'fingerprint' when calling AssetAccountsRevokeSshKeyAsync");
    
            var path = "/v4/AssetAccounts/{id}/DiscoveredSshKeys/{fingerprint}/Revoke";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "fingerprint" + "}", ApiClient.ParameterToString(fingerprint));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsRevokeSshKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsRevokeSshKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Updates the assigned owners of this account 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <param name="body">List of owners to assign to this account</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> AssetAccountsSetAssetAccountManagedByAsync (int? id, List<Identity> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsSetAssetAccountManagedByAsync");
    
            var path = "/v4/AssetAccounts/{id}/ManagedBy";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsSetAssetAccountManagedByAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsSetAssetAccountManagedByAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Sets the account password 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to set password for</param>
        /// <param name="body">Password to set for this account. Maximum length is 1 MB.</param>
        /// <returns></returns>
        public void AssetAccountsSetPasswordAsync (int? id, string body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsSetPasswordAsync");
    
            var path = "/v4/AssetAccounts/{id}/Password";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsSetPasswordAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsSetPasswordAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Assign a specific SSH key to this account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="body">SSH key to assign to account. If no PrivateKey is provided a new key will be generated.</param>
        /// <param name="keyFormat">The format of the SSH public key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <returns>AccountSshKey</returns>
        public AccountSshKey AssetAccountsSetSshKeyAsync (int? id, AccountSshKey body, SshKeyFormat keyFormat)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsSetSshKeyAsync");
    
            var path = "/v4/AssetAccounts/{id}/SshKey";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (keyFormat != null) queryParams.Add("keyFormat", ApiClient.ParameterToString(keyFormat)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsSetSshKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsSetSshKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountSshKey) ApiClient.Deserialize(response.Content, typeof(AccountSshKey), response.Headers);
        }
    
        /// <summary>
        /// Suspend the account on the remote system 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AssetAccountsSuspendAccountAsync (int? id, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsSuspendAccountAsync");
    
            var path = "/v4/AssetAccounts/{id}/SuspendAccount";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsSuspendAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsSuspendAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Updates an account&#x27;s tags 
        /// </summary>
        /// <param name="id">Unique identifier of the account</param>
        /// <param name="body">List of tags to associate with the account</param>
        /// <returns>List&lt;Tag&gt;</returns>
        public List<Tag> AssetAccountsUpdateAccountTagsAsync (int? id, List<Tag> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsUpdateAccountTagsAsync");
    
            var path = "/v4/AssetAccounts/{id}/Tags";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsUpdateAccountTagsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsUpdateAccountTagsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Tag>) ApiClient.Deserialize(response.Content, typeof(List<Tag>), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing asset account 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to update</param>
        /// <param name="body">Updated AssetAccount</param>
        /// <returns>AssetAccount</returns>
        public AssetAccount AssetAccountsUpdateAssetAccountAsync (int? id, AssetAccount body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetAccountsUpdateAssetAccountAsync");
    
            var path = "/v4/AssetAccounts/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsUpdateAssetAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsUpdateAssetAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetAccount) ApiClient.Deserialize(response.Content, typeof(AssetAccount), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple asset account updates 
        /// </summary>
        /// <param name="body">asset accounts to process</param>
        /// <returns>List&lt;AssetAccountBatchResponse&gt;</returns>
        public List<AssetAccountBatchResponse> AssetAccountsUpdateMultipleAccountsAsync (List<AssetAccount> body)
        {
    
            var path = "/v4/AssetAccounts/BatchUpdate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsUpdateMultipleAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetAccountsUpdateMultipleAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccountBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccountBatchResponse>), response.Headers);
        }
    
    }
}
