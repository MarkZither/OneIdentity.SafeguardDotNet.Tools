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
    public interface IAssetsApi
    {
        /// <summary>
        /// Checks if the current account name is unique for this asset prior to create/update 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">Parameters for checking for unique name</param>
        /// <returns>bool?</returns>
        bool? AssetsCheckAccountNameAsync (int? id, UniqueNameParameters body);
        /// <summary>
        /// Checks if the current name is unique prior to create/update 
        /// </summary>
        /// <param name="body">Parameters for checking for unique name</param>
        /// <returns>bool?</returns>
        bool? AssetsCheckAssetNameAsync (UniqueNameParameters body);
        /// <summary>
        /// Adds a new Asset 
        /// </summary>
        /// <param name="body">Asset to create</param>
        /// <returns>Asset</returns>
        Asset AssetsCreateAssetAsync (Asset body);
        /// <summary>
        /// Processes multiple new assets 
        /// </summary>
        /// <param name="body">New assets to process</param>
        /// <returns>List&lt;AssetBatchResponse&gt;</returns>
        List<AssetBatchResponse> AssetsCreateMultipleAssetsAsync (List<Asset> body);
        /// <summary>
        /// Removes an Asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset to remove</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        void AssetsDeleteAsync (int? id, bool? forceDelete);
        /// <summary>
        /// Processes multiple asset deletes 
        /// </summary>
        /// <param name="body">Asset IDs to process</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns>List&lt;AssetBatchResult&gt;</returns>
        List<AssetBatchResult> AssetsDeleteMultipleAsync (List<int?> body, bool? forceDelete);
        /// <summary>
        /// Disable asset and its accounts from automated platform tasks 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <returns>Asset</returns>
        Asset AssetsDisableAssetAsync (int? id);
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
        List<DirectorySchema> AssetsDiscoverSchemaAsync (AssetSchemaParameters body, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Discovers the available schema attributes using provided domain credentials for a specific object class 
        /// </summary>
        /// <param name="objectClassName">Name of object class to discover schema for</param>
        /// <param name="body">Credentials for authenticating to active directory</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>List&lt;DirectorySchema&gt;</returns>
        List<DirectorySchema> AssetsDiscoverSchemaByClassAsync (string objectClassName, AssetSchemaParameters body, string fields);
        /// <summary>
        /// Gets the ssh host key for an asset 
        /// </summary>
        /// <param name="body">Optionally override asset connection settings</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>AssetSshHostKey</returns>
        AssetSshHostKey AssetsDiscoverSshHostKeyAsync (DiscoverSshHostKeyParameters body, bool? extendedLogging);
        /// <summary>
        /// Tests the configured connection to this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">Optionally override asset connection settings</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>AssetSshHostKey</returns>
        AssetSshHostKey AssetsDiscoverSshHostKeyByIdAsync (int? id, AssetDiscoverSshHostKeyParameters body, bool? extendedLogging);
        /// <summary>
        /// Enable asset and its accounts from automated platform tasks 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <returns>Asset</returns>
        Asset AssetsEnableAssetAsync (int? id);
        /// <summary>
        /// Gets a list of assets across all accessible partitions 
        /// </summary>
        /// <param name="tagNames">List of comma-separated tag IDs by which to filter results. Preferred over using filter.</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Asset&gt;</returns>
        List<Asset> AssetsGetAllAssetsAsync (string tagNames, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets list of accounts that belong to this Asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetsGetAssetAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a single Asset entity 
        /// </summary>
        /// <param name="id">Unique ID of an Asset</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Asset</returns>
        Asset AssetsGetAssetByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets list of directory accounts that this asset is dependent on 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetsGetAssetDependentAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all effective owners of the specified asset 
        /// </summary>
        /// <param name="id">Unique identifier of the asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;EffectiveIdentity&gt;</returns>
        List<EffectiveIdentity> AssetsGetAssetEffectiveManagedByAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all owners of the specified asset 
        /// </summary>
        /// <param name="id">Unique identifier of the asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> AssetsGetAssetManagedByAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the SshHostKey identifying this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AssetSshHostKey</returns>
        AssetSshHostKey AssetsGetAssetSshHostKeyAsync (int? id, string fields);
        /// <summary>
        /// Gets an asset&#x27;s tags 
        /// </summary>
        /// <param name="id">Unique identifier of the asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, in, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Tag&gt;</returns>
        List<Tag> AssetsGetAssetTagsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Get default schema for directory provider 
        /// </summary>
        /// <param name="platformType">Identity provider type name</param>
        /// <returns>DefaultAssetLdapSchema</returns>
        DefaultAssetLdapSchema AssetsGetDefaultSchema (PlatformType platformType);
        /// <summary>
        /// Gets a discovered account 
        /// </summary>
        /// <param name="id">Unique ID of a asset</param>
        /// <param name="accountName">Name of a DiscoveredAssetAccount</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>DiscoveredAssetAccount</returns>
        DiscoveredAssetAccount AssetsGetDiscoveredAccountAsync (int? id, string accountName, string fields);
        /// <summary>
        /// Gets an asset&#x27;s discovered accounts 
        /// </summary>
        /// <param name="id">Unique ID of an Asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredAssetAccount&gt;</returns>
        List<DiscoveredAssetAccount> AssetsGetDiscoveredAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets an asset&#x27;s discovered services 
        /// </summary>
        /// <param name="id">Unique ID of an Asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredService&gt;</returns>
        List<DiscoveredService> AssetsGetDiscoveredServicesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Searches the specified directory 
        /// </summary>
        /// <param name="id">Unique ID of an Asset</param>
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
        List<DirectoryServiceEntry> AssetsGetEntriesAsync (int? id, string searchBase, SearchScope searchScope, DirectorySearchType searchType, string searchName, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets platform information for specified asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Platform</returns>
        Platform AssetsGetPlatformAsync (int? id, string fields);
        /// <summary>
        /// Installs an SSH key for the service account 
        /// </summary>
        /// <param name="body">Information about which asset to install an SSH key for the service account</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AssetsInstallSshKeyAsync (AssetInstallSshKeyParameters body, bool? extendedLogging);
        /// <summary>
        /// Installs an SSH key for the service account 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">Database ID of SSH Key to install (optional - will be generated if not specified). Also option to override existing asset connection settings.</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AssetsInstallSshKeyByIdAsync (int? id, InstallSshKeyParameters body, bool? extendedLogging);
        /// <summary>
        /// Add/Remove directory accounts running services on this asset Only applicable to Windows (&#x27;win&#x27;) assets
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">List of directory accounts to assign to this asset</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetsModifyAssetDependentAccountsAsync (int? id, ListOperation operation, List<AssetAccount> body);
        /// <summary>
        /// Add/Remove tags on this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">List of tags to assign to this asset</param>
        /// <returns>List&lt;Tag&gt;</returns>
        List<Tag> AssetsModifyAssetTagsAsync (int? id, ListOperation operation, List<Tag> body);
        /// <summary>
        /// Add/Remove assigned owners of this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">List of owners to assign to this asset</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> AssetsModifyManagedByAsync (int? id, ListOperation operation, List<Identity> body);
        /// <summary>
        /// Removes the ssh host id of this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <returns></returns>
        void AssetsRemoveSshHostKeyAsync (int? id);
        /// <summary>
        /// Retrieve Ssh Host Key of the asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>AssetSshHostKey</returns>
        AssetSshHostKey AssetsRetrieveSshHostKeyByIdAsync (int? id, bool? extendedLogging);
        /// <summary>
        /// Runs Discovery on the given asset 
        /// </summary>
        /// <param name="id">id of the asset to run discovery on</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>AccountDiscoveryLog</returns>
        AccountDiscoveryLog AssetsRunDiscoveryAsync (int? id, bool? extendedLogging);
        /// <summary>
        /// Runs Service Discovery on the given asset 
        /// </summary>
        /// <param name="id">id of the asset to run service discovery on</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>ServiceDiscoveryLog</returns>
        ServiceDiscoveryLog AssetsRunServiceDiscoveryAsync (int? id, bool? extendedLogging);
        /// <summary>
        /// Searches the specified directory for User objects as DirectoryAccounts 
        /// </summary>
        /// <param name="id">Unique ID of an Asset</param>
        /// <param name="searchBase">Sets the searchBase for the Ldap query, defaults to base of the domain for ldap, or base of  forest for AD.  Must be in DN Syntax.</param>
        /// <param name="searchScope">Defines the scope of the query, either base, one, or sub, defaults to sub.</param>
        /// <param name="searchName">Sets a search constraint on the \&quot;name\&quot; of the object to return.</param>
        /// <param name="includeGroups">Whether to look up directory group information</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetsSearchDirectoryAccountsAsync (int? id, string searchBase, SearchScope searchScope, string searchName, bool? includeGroups, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Searches the specified directory for Computer objects as Assets 
        /// </summary>
        /// <param name="id">Unique ID of an Asset</param>
        /// <param name="searchBase">Sets the searchBase for the Ldap query, defaults to base of the domain for ldap, or base of  forest for AD.  Must be in DN Syntax.</param>
        /// <param name="searchScope">Defines the scope of the query, either base, one, or sub, defaults to sub.</param>
        /// <param name="searchName">Sets a search constraint on the \&quot;name\&quot; of the object to return.</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Asset&gt;</returns>
        List<Asset> AssetsSearchDirectoryAssetsAsync (int? id, string searchBase, SearchScope searchScope, string searchName, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Updates the set of directory accounts running services on this asset Only applicable to Windows (&#x27;win&#x27;) assets
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">List of directory accounts to assign to this asset</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetsSetAssetDependentAccountsAsync (int? id, List<AssetAccount> body);
        /// <summary>
        /// Updates the assigned owners of this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">List of owners to assign to this asset</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> AssetsSetAssetManagedByAsync (int? id, List<Identity> body);
        /// <summary>
        /// Updates the ssh host id of this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">SSH host id to assign to this asset</param>
        /// <returns>AssetSshHostKey</returns>
        AssetSshHostKey AssetsSetAssetSshHostKeyAsync (int? id, AssetSshHostKey body);
        /// <summary>
        /// Synchronize all directory related objects with the remote server 
        /// </summary>
        /// <param name="id">Unique ID of asset</param>
        /// <param name="fullSync">Whether to sync all entities imported from this directory or just those that have been modified</param>
        /// <returns>DirectorySyncActivityLog</returns>
        DirectorySyncActivityLog AssetsSynchronizeAsync (int? id, bool? fullSync);
        /// <summary>
        /// Tests the configured connection to this asset 
        /// </summary>
        /// <param name="body">Information about which asset to test the connection with</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AssetsTestConnectionAsync (AssetTestConnectionParameters body, bool? extendedLogging);
        /// <summary>
        /// Tests the configured connection to this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">Optionally override asset connection settings</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AssetsTestConnectionByIdAsync (int? id, TestConnectionParameters body, bool? extendedLogging);
        /// <summary>
        /// Check which managed network the specified asset would be assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <returns></returns>
        void AssetsTestNetworkAddressAsync (int? id);
        /// <summary>
        /// Updates an Asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset to update</param>
        /// <param name="body">Updated Asset</param>
        /// <returns>Asset</returns>
        Asset AssetsUpdateAssetAsync (int? id, Asset body);
        /// <summary>
        /// Updates an asset&#x27;s tags 
        /// </summary>
        /// <param name="id">Unique identifier of the asset</param>
        /// <param name="body">List of tags to associate with the Asset</param>
        /// <returns>List&lt;Tag&gt;</returns>
        List<Tag> AssetsUpdateAssetTagsAsync (int? id, List<Tag> body);
        /// <summary>
        /// Update account password for services and tasks on this assets based on current profile settings 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">Parameters needed to run platform task</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AssetsUpdateDependentServicesAsync (int? id, UpdateDependentAssetParameters body, bool? extendedLogging);
        /// <summary>
        /// Processes multiple asset updates 
        /// </summary>
        /// <param name="body">assets to process</param>
        /// <returns>List&lt;AssetBatchResponse&gt;</returns>
        List<AssetBatchResponse> AssetsUpdateMultipleAssetsAsync (List<Asset> body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AssetsApi : IAssetsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AssetsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AssetsApi(String basePath)
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
        /// Checks if the current account name is unique for this asset prior to create/update 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">Parameters for checking for unique name</param>
        /// <returns>bool?</returns>
        public bool? AssetsCheckAccountNameAsync (int? id, UniqueNameParameters body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsCheckAccountNameAsync");
    
            var path = "/v4/Assets/{id}/CheckUniqueAccountName";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsCheckAccountNameAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsCheckAccountNameAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
        /// <summary>
        /// Checks if the current name is unique prior to create/update 
        /// </summary>
        /// <param name="body">Parameters for checking for unique name</param>
        /// <returns>bool?</returns>
        public bool? AssetsCheckAssetNameAsync (UniqueNameParameters body)
        {
    
            var path = "/v4/Assets/CheckUniqueName";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsCheckAssetNameAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsCheckAssetNameAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
        /// <summary>
        /// Adds a new Asset 
        /// </summary>
        /// <param name="body">Asset to create</param>
        /// <returns>Asset</returns>
        public Asset AssetsCreateAssetAsync (Asset body)
        {
    
            var path = "/v4/Assets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsCreateAssetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsCreateAssetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Asset) ApiClient.Deserialize(response.Content, typeof(Asset), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple new assets 
        /// </summary>
        /// <param name="body">New assets to process</param>
        /// <returns>List&lt;AssetBatchResponse&gt;</returns>
        public List<AssetBatchResponse> AssetsCreateMultipleAssetsAsync (List<Asset> body)
        {
    
            var path = "/v4/Assets/BatchCreate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsCreateMultipleAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsCreateMultipleAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<AssetBatchResponse>), response.Headers);
        }
    
        /// <summary>
        /// Removes an Asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset to remove</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        public void AssetsDeleteAsync (int? id, bool? forceDelete)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsDeleteAsync");
    
            var path = "/v4/Assets/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsDeleteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsDeleteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Processes multiple asset deletes 
        /// </summary>
        /// <param name="body">Asset IDs to process</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns>List&lt;AssetBatchResult&gt;</returns>
        public List<AssetBatchResult> AssetsDeleteMultipleAsync (List<int?> body, bool? forceDelete)
        {
    
            var path = "/v4/Assets/BatchDelete";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsDeleteMultipleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsDeleteMultipleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetBatchResult>) ApiClient.Deserialize(response.Content, typeof(List<AssetBatchResult>), response.Headers);
        }
    
        /// <summary>
        /// Disable asset and its accounts from automated platform tasks 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <returns>Asset</returns>
        public Asset AssetsDisableAssetAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsDisableAssetAsync");
    
            var path = "/v4/Assets/{id}/Disable";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsDisableAssetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsDisableAssetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Asset) ApiClient.Deserialize(response.Content, typeof(Asset), response.Headers);
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
        public List<DirectorySchema> AssetsDiscoverSchemaAsync (AssetSchemaParameters body, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Assets/DiscoverSchema";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsDiscoverSchemaAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsDiscoverSchemaAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DirectorySchema>) ApiClient.Deserialize(response.Content, typeof(List<DirectorySchema>), response.Headers);
        }
    
        /// <summary>
        /// Discovers the available schema attributes using provided domain credentials for a specific object class 
        /// </summary>
        /// <param name="objectClassName">Name of object class to discover schema for</param>
        /// <param name="body">Credentials for authenticating to active directory</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>List&lt;DirectorySchema&gt;</returns>
        public List<DirectorySchema> AssetsDiscoverSchemaByClassAsync (string objectClassName, AssetSchemaParameters body, string fields)
        {
            // verify the required parameter 'objectClassName' is set
            if (objectClassName == null) throw new ApiException(400, "Missing required parameter 'objectClassName' when calling AssetsDiscoverSchemaByClassAsync");
    
            var path = "/v4/Assets/DiscoverSchema/{objectClassName}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsDiscoverSchemaByClassAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsDiscoverSchemaByClassAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DirectorySchema>) ApiClient.Deserialize(response.Content, typeof(List<DirectorySchema>), response.Headers);
        }
    
        /// <summary>
        /// Gets the ssh host key for an asset 
        /// </summary>
        /// <param name="body">Optionally override asset connection settings</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>AssetSshHostKey</returns>
        public AssetSshHostKey AssetsDiscoverSshHostKeyAsync (DiscoverSshHostKeyParameters body, bool? extendedLogging)
        {
    
            var path = "/v4/Assets/DiscoverSshHostKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsDiscoverSshHostKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsDiscoverSshHostKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetSshHostKey) ApiClient.Deserialize(response.Content, typeof(AssetSshHostKey), response.Headers);
        }
    
        /// <summary>
        /// Tests the configured connection to this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">Optionally override asset connection settings</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>AssetSshHostKey</returns>
        public AssetSshHostKey AssetsDiscoverSshHostKeyByIdAsync (int? id, AssetDiscoverSshHostKeyParameters body, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsDiscoverSshHostKeyByIdAsync");
    
            var path = "/v4/Assets/{id}/DiscoverSshHostKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsDiscoverSshHostKeyByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsDiscoverSshHostKeyByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetSshHostKey) ApiClient.Deserialize(response.Content, typeof(AssetSshHostKey), response.Headers);
        }
    
        /// <summary>
        /// Enable asset and its accounts from automated platform tasks 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <returns>Asset</returns>
        public Asset AssetsEnableAssetAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsEnableAssetAsync");
    
            var path = "/v4/Assets/{id}/Enable";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsEnableAssetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsEnableAssetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Asset) ApiClient.Deserialize(response.Content, typeof(Asset), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of assets across all accessible partitions 
        /// </summary>
        /// <param name="tagNames">List of comma-separated tag IDs by which to filter results. Preferred over using filter.</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Asset&gt;</returns>
        public List<Asset> AssetsGetAllAssetsAsync (string tagNames, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Assets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAllAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAllAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Asset>) ApiClient.Deserialize(response.Content, typeof(List<Asset>), response.Headers);
        }
    
        /// <summary>
        /// Gets list of accounts that belong to this Asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetsGetAssetAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsGetAssetAccountsAsync");
    
            var path = "/v4/Assets/{id}/Accounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAssetAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAssetAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single Asset entity 
        /// </summary>
        /// <param name="id">Unique ID of an Asset</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Asset</returns>
        public Asset AssetsGetAssetByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsGetAssetByIdAsync");
    
            var path = "/v4/Assets/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAssetByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAssetByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Asset) ApiClient.Deserialize(response.Content, typeof(Asset), response.Headers);
        }
    
        /// <summary>
        /// Gets list of directory accounts that this asset is dependent on 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetsGetAssetDependentAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsGetAssetDependentAccountsAsync");
    
            var path = "/v4/Assets/{id}/DependentAccounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAssetDependentAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAssetDependentAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets all effective owners of the specified asset 
        /// </summary>
        /// <param name="id">Unique identifier of the asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;EffectiveIdentity&gt;</returns>
        public List<EffectiveIdentity> AssetsGetAssetEffectiveManagedByAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsGetAssetEffectiveManagedByAsync");
    
            var path = "/v4/Assets/{id}/EffectiveManagedBy";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAssetEffectiveManagedByAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAssetEffectiveManagedByAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<EffectiveIdentity>) ApiClient.Deserialize(response.Content, typeof(List<EffectiveIdentity>), response.Headers);
        }
    
        /// <summary>
        /// Gets all owners of the specified asset 
        /// </summary>
        /// <param name="id">Unique identifier of the asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> AssetsGetAssetManagedByAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsGetAssetManagedByAsync");
    
            var path = "/v4/Assets/{id}/ManagedBy";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAssetManagedByAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAssetManagedByAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Gets the SshHostKey identifying this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AssetSshHostKey</returns>
        public AssetSshHostKey AssetsGetAssetSshHostKeyAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsGetAssetSshHostKeyAsync");
    
            var path = "/v4/Assets/{id}/SshHostKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAssetSshHostKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAssetSshHostKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetSshHostKey) ApiClient.Deserialize(response.Content, typeof(AssetSshHostKey), response.Headers);
        }
    
        /// <summary>
        /// Gets an asset&#x27;s tags 
        /// </summary>
        /// <param name="id">Unique identifier of the asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, in, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Tag&gt;</returns>
        public List<Tag> AssetsGetAssetTagsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsGetAssetTagsAsync");
    
            var path = "/v4/Assets/{id}/Tags";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAssetTagsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetAssetTagsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Tag>) ApiClient.Deserialize(response.Content, typeof(List<Tag>), response.Headers);
        }
    
        /// <summary>
        /// Get default schema for directory provider 
        /// </summary>
        /// <param name="platformType">Identity provider type name</param>
        /// <returns>DefaultAssetLdapSchema</returns>
        public DefaultAssetLdapSchema AssetsGetDefaultSchema (PlatformType platformType)
        {
            // verify the required parameter 'platformType' is set
            if (platformType == null) throw new ApiException(400, "Missing required parameter 'platformType' when calling AssetsGetDefaultSchema");
    
            var path = "/v4/Assets/DefaultSchema/{platformType}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platformType" + "}", ApiClient.ParameterToString(platformType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetDefaultSchema: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetDefaultSchema: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DefaultAssetLdapSchema) ApiClient.Deserialize(response.Content, typeof(DefaultAssetLdapSchema), response.Headers);
        }
    
        /// <summary>
        /// Gets a discovered account 
        /// </summary>
        /// <param name="id">Unique ID of a asset</param>
        /// <param name="accountName">Name of a DiscoveredAssetAccount</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>DiscoveredAssetAccount</returns>
        public DiscoveredAssetAccount AssetsGetDiscoveredAccountAsync (int? id, string accountName, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsGetDiscoveredAccountAsync");
            // verify the required parameter 'accountName' is set
            if (accountName == null) throw new ApiException(400, "Missing required parameter 'accountName' when calling AssetsGetDiscoveredAccountAsync");
    
            var path = "/v4/Assets/{id}/DiscoveredAccounts/{accountName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "accountName" + "}", ApiClient.ParameterToString(accountName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetDiscoveredAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetDiscoveredAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DiscoveredAssetAccount) ApiClient.Deserialize(response.Content, typeof(DiscoveredAssetAccount), response.Headers);
        }
    
        /// <summary>
        /// Gets an asset&#x27;s discovered accounts 
        /// </summary>
        /// <param name="id">Unique ID of an Asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredAssetAccount&gt;</returns>
        public List<DiscoveredAssetAccount> AssetsGetDiscoveredAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsGetDiscoveredAccountsAsync");
    
            var path = "/v4/Assets/{id}/DiscoveredAccounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetDiscoveredAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetDiscoveredAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredAssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredAssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets an asset&#x27;s discovered services 
        /// </summary>
        /// <param name="id">Unique ID of an Asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredService&gt;</returns>
        public List<DiscoveredService> AssetsGetDiscoveredServicesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsGetDiscoveredServicesAsync");
    
            var path = "/v4/Assets/{id}/DiscoveredServices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetDiscoveredServicesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetDiscoveredServicesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredService>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredService>), response.Headers);
        }
    
        /// <summary>
        /// Searches the specified directory 
        /// </summary>
        /// <param name="id">Unique ID of an Asset</param>
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
        public List<DirectoryServiceEntry> AssetsGetEntriesAsync (int? id, string searchBase, SearchScope searchScope, DirectorySearchType searchType, string searchName, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsGetEntriesAsync");
    
            var path = "/v4/Assets/{id}/DirectoryServiceEntries";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetEntriesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetEntriesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DirectoryServiceEntry>) ApiClient.Deserialize(response.Content, typeof(List<DirectoryServiceEntry>), response.Headers);
        }
    
        /// <summary>
        /// Gets platform information for specified asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Platform</returns>
        public Platform AssetsGetPlatformAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsGetPlatformAsync");
    
            var path = "/v4/Assets/{id}/Platform";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetPlatformAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsGetPlatformAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Platform) ApiClient.Deserialize(response.Content, typeof(Platform), response.Headers);
        }
    
        /// <summary>
        /// Installs an SSH key for the service account 
        /// </summary>
        /// <param name="body">Information about which asset to install an SSH key for the service account</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AssetsInstallSshKeyAsync (AssetInstallSshKeyParameters body, bool? extendedLogging)
        {
    
            var path = "/v4/Assets/InstallSshKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsInstallSshKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsInstallSshKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Installs an SSH key for the service account 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">Database ID of SSH Key to install (optional - will be generated if not specified). Also option to override existing asset connection settings.</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AssetsInstallSshKeyByIdAsync (int? id, InstallSshKeyParameters body, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsInstallSshKeyByIdAsync");
    
            var path = "/v4/Assets/{id}/InstallSshKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsInstallSshKeyByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsInstallSshKeyByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove directory accounts running services on this asset Only applicable to Windows (&#x27;win&#x27;) assets
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">List of directory accounts to assign to this asset</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetsModifyAssetDependentAccountsAsync (int? id, ListOperation operation, List<AssetAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsModifyAssetDependentAccountsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetsModifyAssetDependentAccountsAsync");
    
            var path = "/v4/Assets/{id}/DependentAccounts/{operation}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsModifyAssetDependentAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsModifyAssetDependentAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove tags on this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">List of tags to assign to this asset</param>
        /// <returns>List&lt;Tag&gt;</returns>
        public List<Tag> AssetsModifyAssetTagsAsync (int? id, ListOperation operation, List<Tag> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsModifyAssetTagsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetsModifyAssetTagsAsync");
    
            var path = "/v4/Assets/{id}/Tags/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsModifyAssetTagsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsModifyAssetTagsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Tag>) ApiClient.Deserialize(response.Content, typeof(List<Tag>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove assigned owners of this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">List of owners to assign to this asset</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> AssetsModifyManagedByAsync (int? id, ListOperation operation, List<Identity> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsModifyManagedByAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetsModifyManagedByAsync");
    
            var path = "/v4/Assets/{id}/ManagedBy/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsModifyManagedByAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsModifyManagedByAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Removes the ssh host id of this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <returns></returns>
        public void AssetsRemoveSshHostKeyAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsRemoveSshHostKeyAsync");
    
            var path = "/v4/Assets/{id}/SshHostKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsRemoveSshHostKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsRemoveSshHostKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Retrieve Ssh Host Key of the asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>AssetSshHostKey</returns>
        public AssetSshHostKey AssetsRetrieveSshHostKeyByIdAsync (int? id, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsRetrieveSshHostKeyByIdAsync");
    
            var path = "/v4/Assets/{id}/RetrieveSshHostKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsRetrieveSshHostKeyByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsRetrieveSshHostKeyByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetSshHostKey) ApiClient.Deserialize(response.Content, typeof(AssetSshHostKey), response.Headers);
        }
    
        /// <summary>
        /// Runs Discovery on the given asset 
        /// </summary>
        /// <param name="id">id of the asset to run discovery on</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>AccountDiscoveryLog</returns>
        public AccountDiscoveryLog AssetsRunDiscoveryAsync (int? id, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsRunDiscoveryAsync");
    
            var path = "/v4/Assets/{id}/DiscoverAccounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsRunDiscoveryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsRunDiscoveryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountDiscoveryLog) ApiClient.Deserialize(response.Content, typeof(AccountDiscoveryLog), response.Headers);
        }
    
        /// <summary>
        /// Runs Service Discovery on the given asset 
        /// </summary>
        /// <param name="id">id of the asset to run service discovery on</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>ServiceDiscoveryLog</returns>
        public ServiceDiscoveryLog AssetsRunServiceDiscoveryAsync (int? id, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsRunServiceDiscoveryAsync");
    
            var path = "/v4/Assets/{id}/DiscoverServices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsRunServiceDiscoveryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsRunServiceDiscoveryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServiceDiscoveryLog) ApiClient.Deserialize(response.Content, typeof(ServiceDiscoveryLog), response.Headers);
        }
    
        /// <summary>
        /// Searches the specified directory for User objects as DirectoryAccounts 
        /// </summary>
        /// <param name="id">Unique ID of an Asset</param>
        /// <param name="searchBase">Sets the searchBase for the Ldap query, defaults to base of the domain for ldap, or base of  forest for AD.  Must be in DN Syntax.</param>
        /// <param name="searchScope">Defines the scope of the query, either base, one, or sub, defaults to sub.</param>
        /// <param name="searchName">Sets a search constraint on the \&quot;name\&quot; of the object to return.</param>
        /// <param name="includeGroups">Whether to look up directory group information</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetsSearchDirectoryAccountsAsync (int? id, string searchBase, SearchScope searchScope, string searchName, bool? includeGroups, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsSearchDirectoryAccountsAsync");
    
            var path = "/v4/Assets/{id}/DirectoryAccounts";
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
 if (includeGroups != null) queryParams.Add("includeGroups", ApiClient.ParameterToString(includeGroups)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsSearchDirectoryAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsSearchDirectoryAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Searches the specified directory for Computer objects as Assets 
        /// </summary>
        /// <param name="id">Unique ID of an Asset</param>
        /// <param name="searchBase">Sets the searchBase for the Ldap query, defaults to base of the domain for ldap, or base of  forest for AD.  Must be in DN Syntax.</param>
        /// <param name="searchScope">Defines the scope of the query, either base, one, or sub, defaults to sub.</param>
        /// <param name="searchName">Sets a search constraint on the \&quot;name\&quot; of the object to return.</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Asset&gt;</returns>
        public List<Asset> AssetsSearchDirectoryAssetsAsync (int? id, string searchBase, SearchScope searchScope, string searchName, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsSearchDirectoryAssetsAsync");
    
            var path = "/v4/Assets/{id}/DirectoryAssets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsSearchDirectoryAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsSearchDirectoryAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Asset>) ApiClient.Deserialize(response.Content, typeof(List<Asset>), response.Headers);
        }
    
        /// <summary>
        /// Updates the set of directory accounts running services on this asset Only applicable to Windows (&#x27;win&#x27;) assets
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">List of directory accounts to assign to this asset</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetsSetAssetDependentAccountsAsync (int? id, List<AssetAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsSetAssetDependentAccountsAsync");
    
            var path = "/v4/Assets/{id}/DependentAccounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsSetAssetDependentAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsSetAssetDependentAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Updates the assigned owners of this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">List of owners to assign to this asset</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> AssetsSetAssetManagedByAsync (int? id, List<Identity> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsSetAssetManagedByAsync");
    
            var path = "/v4/Assets/{id}/ManagedBy";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsSetAssetManagedByAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsSetAssetManagedByAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Updates the ssh host id of this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">SSH host id to assign to this asset</param>
        /// <returns>AssetSshHostKey</returns>
        public AssetSshHostKey AssetsSetAssetSshHostKeyAsync (int? id, AssetSshHostKey body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsSetAssetSshHostKeyAsync");
    
            var path = "/v4/Assets/{id}/SshHostKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsSetAssetSshHostKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsSetAssetSshHostKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetSshHostKey) ApiClient.Deserialize(response.Content, typeof(AssetSshHostKey), response.Headers);
        }
    
        /// <summary>
        /// Synchronize all directory related objects with the remote server 
        /// </summary>
        /// <param name="id">Unique ID of asset</param>
        /// <param name="fullSync">Whether to sync all entities imported from this directory or just those that have been modified</param>
        /// <returns>DirectorySyncActivityLog</returns>
        public DirectorySyncActivityLog AssetsSynchronizeAsync (int? id, bool? fullSync)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsSynchronizeAsync");
    
            var path = "/v4/Assets/{id}/Synchronize";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsSynchronizeAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsSynchronizeAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DirectorySyncActivityLog) ApiClient.Deserialize(response.Content, typeof(DirectorySyncActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Tests the configured connection to this asset 
        /// </summary>
        /// <param name="body">Information about which asset to test the connection with</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AssetsTestConnectionAsync (AssetTestConnectionParameters body, bool? extendedLogging)
        {
    
            var path = "/v4/Assets/TestConnection";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsTestConnectionAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsTestConnectionAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Tests the configured connection to this asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">Optionally override asset connection settings</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AssetsTestConnectionByIdAsync (int? id, TestConnectionParameters body, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsTestConnectionByIdAsync");
    
            var path = "/v4/Assets/{id}/TestConnection";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsTestConnectionByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsTestConnectionByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Check which managed network the specified asset would be assigned to 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <returns></returns>
        public void AssetsTestNetworkAddressAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsTestNetworkAddressAsync");
    
            var path = "/v4/Assets/{id}/EffectiveManagedNetwork";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsTestNetworkAddressAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsTestNetworkAddressAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates an Asset 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset to update</param>
        /// <param name="body">Updated Asset</param>
        /// <returns>Asset</returns>
        public Asset AssetsUpdateAssetAsync (int? id, Asset body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsUpdateAssetAsync");
    
            var path = "/v4/Assets/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsUpdateAssetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsUpdateAssetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Asset) ApiClient.Deserialize(response.Content, typeof(Asset), response.Headers);
        }
    
        /// <summary>
        /// Updates an asset&#x27;s tags 
        /// </summary>
        /// <param name="id">Unique identifier of the asset</param>
        /// <param name="body">List of tags to associate with the Asset</param>
        /// <returns>List&lt;Tag&gt;</returns>
        public List<Tag> AssetsUpdateAssetTagsAsync (int? id, List<Tag> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsUpdateAssetTagsAsync");
    
            var path = "/v4/Assets/{id}/Tags";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsUpdateAssetTagsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsUpdateAssetTagsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Tag>) ApiClient.Deserialize(response.Content, typeof(List<Tag>), response.Headers);
        }
    
        /// <summary>
        /// Update account password for services and tasks on this assets based on current profile settings 
        /// </summary>
        /// <param name="id">Unique identifier of the Asset</param>
        /// <param name="body">Parameters needed to run platform task</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AssetsUpdateDependentServicesAsync (int? id, UpdateDependentAssetParameters body, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetsUpdateDependentServicesAsync");
    
            var path = "/v4/Assets/{id}/UpdateDependentAsset";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsUpdateDependentServicesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsUpdateDependentServicesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple asset updates 
        /// </summary>
        /// <param name="body">assets to process</param>
        /// <returns>List&lt;AssetBatchResponse&gt;</returns>
        public List<AssetBatchResponse> AssetsUpdateMultipleAssetsAsync (List<Asset> body)
        {
    
            var path = "/v4/Assets/BatchUpdate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsUpdateMultipleAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetsUpdateMultipleAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<AssetBatchResponse>), response.Headers);
        }
    
    }
}
