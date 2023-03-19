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
    public interface IClusterApi
    {
        /// <summary>
        /// Promotes this appliance from StandaloneReadOnly to Online./&gt; 
        /// </summary>
        /// <returns></returns>
        void ClusterActivatePrimaryAsync ();
        /// <summary>
        /// Add/Remove network configuration assignments for this managed host member. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="memberId">Unique ID of the member</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Network configurations to assign this managed host member</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        List<NetworkMember> ClusterAddRemoveManagedNetworkBySessionModuleAndMemberIdAsync (int? id, string memberId, ListOperation operation, List<ManagedNetwork> body);
        /// <summary>
        /// Assigns this managed host member to a set of managed network configurations. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="memberId">Unique ID of the member</param>
        /// <param name="body">Network configurations to assign this managed host member</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        List<NetworkMember> ClusterAssignManagedNetworkBySessionModuleAndMemberIdAsync (int? id, string memberId, List<ManagedNetwork> body);
        /// <summary>
        /// Returns precondition errors and warnings from the currently staged patch for the entire cluster. 
        /// </summary>
        /// <returns>ClusterPatchPreconditionResult</returns>
        ClusterPatchPreconditionResult ClusterCheckPreconditionsAsync ();
        /// <summary>
        /// Starts the trust to create a session connection to link an external session module to this cluster.  Note: This will only be invoked from SPS. They don&#x27;t know about ApiError so it is best  to keep the response simple. 
        /// </summary>
        /// <param name="body">Connection information for the new external session module</param>
        /// <returns>SessionModuleConnection</returns>
        SessionModuleConnection ClusterConnectSessionModuleAsync (SessionModuleConnection body);
        /// <summary>
        /// Creates a managed network configuration 
        /// </summary>
        /// <param name="body">Entity to create</param>
        /// <returns>ManagedNetwork</returns>
        ManagedNetwork ClusterCreateEntityAsync (ManagedNetwork body);
        /// <summary>
        /// Deletes all existing challenge requests 
        /// </summary>
        /// <returns></returns>
        void ClusterDeleteAllChallengeRequestsAsync ();
        /// <summary>
        /// Removes a managed network configuration. Appliances and assets will be assigned to the default network 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <returns></returns>
        void ClusterDeleteAsync (int? id);
        /// <summary>
        /// Unjoin a specific member, by id, from the cluster. 
        /// </summary>
        /// <param name="id">id of the member to be removed</param>
        /// <returns></returns>
        void ClusterDeleteMemberAsync (string id);
        /// <summary>
        /// Disconnect a specific external session module from the cluster. 
        /// </summary>
        /// <param name="id">ID of the session module to be disconnected</param>
        /// <returns></returns>
        void ClusterDeleteSessionModuleConnectionAsync (int? id);
        /// <summary>
        /// Revokes the VM Compatible Backup Authorization 
        /// </summary>
        /// <returns>VMCompatibleBackupAuthorizationSetting</returns>
        VMCompatibleBackupAuthorizationSetting ClusterDeleteVMCompatibleAuthorizationAsync ();
        /// <summary>
        /// Enrolls a new member in this cluster. 
        /// </summary>
        /// <param name="body">Information about the appliance enrolling</param>
        /// <returns></returns>
        void ClusterEnrollMemberAsync (EnrollNewClusterMember body);
        /// <summary>
        /// Force the current cluster operation to complete. 
        /// </summary>
        /// <returns></returns>
        void ClusterForceCompleteAsync ();
        /// <summary>
        /// Force the cluster configuration on this appliance to reset to a single  appliance operating as a primary. After resetting the cluster configuration  the appliance will come online in a deactivated mode to avoid conflicts with  password check/change operations. 
        /// </summary>
        /// <returns></returns>
        void ClusterForceResetAsync ();
        /// <summary>
        /// List of possible cluster actions 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> ClusterGet ();
        /// <summary>
        /// Gets the access request broker. 
        /// </summary>
        /// <returns>AccessRequestBroker</returns>
        AccessRequestBroker ClusterGetAccessRequestBrokerAsync ();
        /// <summary>
        /// Gets the list of cluster certificates 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output.</param>
        /// <returns>List&lt;ServerCertificate&gt;</returns>
        List<ServerCertificate> ClusterGetAllClusterCertificatesAsync (string fields);
        /// <summary>
        /// Return a list of all cluster members. 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        List<NetworkMember> ClusterGetAllClusterNodesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Returns the list of applications. 
        /// </summary>
        /// <returns>List&lt;Application&gt;</returns>
        List<Application> ClusterGetApplicationsAsync ();
        /// <summary>
        /// Returns Backup Protection Settings 
        /// </summary>
        /// <returns>BackupProtectionSettings</returns>
        BackupProtectionSettings ClusterGetBackupProtectionSettingsAsync ();
        /// <summary>
        /// Gets a specific managed network configuration 
        /// </summary>
        /// <param name="id">Unique ID of entity</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ManagedNetwork</returns>
        ManagedNetwork ClusterGetByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets the public information for a cluster certificate by type 
        /// </summary>
        /// <param name="type">Certificate type to get. Supported types are ClusterRoot, SecureTokenService, AuditLogSigning.</param>
        /// <param name="fields">List of property names to include in entity output.</param>
        /// <returns>ServerCertificate</returns>
        ServerCertificate ClusterGetClusterCertificateAsync (CertificateType type, string fields);
        /// <summary>
        /// Gets all network configurations managed by this cluster member 
        /// </summary>
        /// <param name="id">Unique identifier of the cluster member</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ManagedNetwork&gt;</returns>
        List<ManagedNetwork> ClusterGetClusterMemberNetworksAsync (string id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Return whether the cluster is configured to use external session modules. 
        /// </summary>
        /// <returns>bool?</returns>
        bool? ClusterGetExternalSessionModuleStateAsync ();
        /// <summary>
        /// Get information about platform tasks load 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PlatformTaskLoadStatus</returns>
        PlatformTaskLoadStatus ClusterGetLoadStatusAsync (string fields);
        /// <summary>
        /// Return the managed networks by session module and member id. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="memberId">Unique ID of the member</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        List<NetworkMember> ClusterGetManagedNetworksBySessionModuleAndMemberIdAsync (int? id, string memberId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Return information about a specific appliance in this cluster. 
        /// </summary>
        /// <param name="id">Unique ID of cluster member</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ClusterMember</returns>
        ClusterMember ClusterGetMemberByIdAsync (string id, string fields);
        /// <summary>
        /// Return information about all appliances in this cluster. 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ClusterMember&gt;</returns>
        List<ClusterMember> ClusterGetMembersAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all assets that have been explicitly assigned to the managed network configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the managed network</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Asset&gt;</returns>
        List<Asset> ClusterGetNetworkAssetsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all members that have been assigned to the managed network configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the managed network</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        List<NetworkMember> ClusterGetNetworkMembersAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of managed networks configuration 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ManagedNetwork&gt;</returns>
        List<ManagedNetwork> ClusterGetNetworksAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Get currently scheduled tasks 
        /// </summary>
        /// <param name="taskName">Type of scheduled tasks to find</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ScheduledTask&gt;</returns>
        List<ScheduledTask> ClusterGetScheduledPlatformTasksAsync (ScheduledTaskNames taskName, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Get summarized counts of currently scheduled tasks based on an interval 
        /// </summary>
        /// <param name="summaryIntervalMinutes">Interval to summarize tasks. Minimum 30 minutes. (Default &#x3D; 30 minutes)</param>
        /// <param name="taskNames">A comma-separated list of task names to include in entity output. (Default &#x3D; all)</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SummaryInformation</returns>
        SummaryInformation ClusterGetScheduledPlatformTasksSummariesAsync (int? summaryIntervalMinutes, string taskNames, string fields);
        /// <summary>
        /// Force a health check and return cluster information for this node 
        /// </summary>
        /// <returns>ClusterMember</returns>
        ClusterMember ClusterGetSelfAsync ();
        /// <summary>
        /// Return a managed host member by session module and member id. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="memberId">Unique ID of the member</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>NetworkMember</returns>
        NetworkMember ClusterGetSessionModuleClusterNodeByIdAsync (int? id, string memberId, string fields);
        /// <summary>
        /// Return a list of the managed host members by session module. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        List<NetworkMember> ClusterGetSessionModuleClusterNodesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Return information about a connected session module for this cluster. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SessionModuleConnection</returns>
        SessionModuleConnection ClusterGetSessionModuleConnectionByIdAsync (int? id, string fields);
        /// <summary>
        /// Return a list of connection policies from the connected session modules in the cluster. 
        /// </summary>
        /// <param name="protocol">Filter the results by protocol (RDP | SSH (default))</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <param name="refresh">Force a refresh of the session connection policies.</param>
        /// <returns>List&lt;SessionModuleConnectionPolicy&gt;</returns>
        List<SessionModuleConnectionPolicy> ClusterGetSessionModuleConnectionPoliciesAsync (SessionModuleConnectionProtocol protocol, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q, bool? refresh);
        /// <summary>
        /// Return a list of connection policies by session module. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="protocol">Filter the results by protocol (RDP | SSH (default))</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <param name="refresh">Force a refresh of the session connection policies.</param>
        /// <returns>List&lt;SessionModuleConnectionPolicy&gt;</returns>
        List<SessionModuleConnectionPolicy> ClusterGetSessionModuleConnectionPoliciesByIdAsync (int? id, SessionModuleConnectionProtocol protocol, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q, bool? refresh);
        /// <summary>
        /// Return a connection policy by session module. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="policyId">Unique ID of the session module</param>
        /// <param name="protocol">Filter the results by protocol (RDP | SSH (default))</param>
        /// <param name="refresh">Force a refresh of the session connection policies.</param>
        /// <returns>SessionModuleConnectionPolicy</returns>
        SessionModuleConnectionPolicy ClusterGetSessionModuleConnectionPolicyByIdAsync (int? id, string policyId, SessionModuleConnectionProtocol protocol, bool? refresh);
        /// <summary>
        /// Return information about all of the connected session modules for this cluster. 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <param name="includeDisconnected">Include disconnected session modules</param>
        /// <returns>List&lt;SessionModuleConnection&gt;</returns>
        List<SessionModuleConnection> ClusterGetSessionModuleConnectionsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q, bool? includeDisconnected);
        /// <summary>
        /// Returns the cluster lock status. 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ClusterOperationStatus</returns>
        ClusterOperationStatus ClusterGetStatusAsync (string fields);
        /// <summary>
        /// Gets the VM Compatible Backup Authorization Setting 
        /// </summary>
        /// <returns>VMCompatibleBackupAuthorizationSetting</returns>
        VMCompatibleBackupAuthorizationSetting ClusterGetVMCompatibleAuthorization ();
        /// <summary>
        /// Isolate the appliance to be available for access requests despite its inability  to communicate with the rest of the cluster. 
        /// </summary>
        /// <returns></returns>
        void ClusterIsolateAsync ();
        /// <summary>
        /// Add/Remove network configuration assignments for this cluster member 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Network configurations to assign this cluster member to</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        List<NetworkMember> ClusterModifyClusterMemberNetworksAsync (string id, ListOperation operation, List<ManagedNetwork> body);
        /// <summary>
        /// Add/Remove members assigned to this managed network configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Member members to assign</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        List<NetworkMember> ClusterModifyMembersAsync (int? id, ListOperation operation, List<NetworkMember> body);
        /// <summary>
        /// Add/Remove assets assigned to this managed network configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Assets to assign</param>
        /// <returns>List&lt;Asset&gt;</returns>
        List<Asset> ClusterModifySystemsAsync (int? id, ListOperation operation, List<Asset> body);
        /// <summary>
        /// Gets the status of the patch distribution in cluster 
        /// </summary>
        /// <returns>PatchDistributionModel</returns>
        PatchDistributionModel ClusterPatchDistributionAsync ();
        /// <summary>
        /// Generates a OneIdentity Challenge to authorize VM Compatible Backup download. 
        /// </summary>
        /// <param name="userIdentifier">The user who is requesting the challenge.</param>
        /// <param name="invalidateExistingChallengeRequest">Specify true if you wish to invalidate the existing request and use this one.</param>
        /// <returns>string</returns>
        string ClusterPostVmCompatibleAuthorizationRequestAsync (string userIdentifier, bool? invalidateExistingChallengeRequest);
        /// <summary>
        /// Reverts the Isolate and reintegrates the appliance back in the cluster. 
        /// </summary>
        /// <returns></returns>
        void ClusterReintegrateAsync ();
        /// <summary>
        /// Resets the cluster configuration regardless of consensus. 
        /// </summary>
        /// <param name="body">New cluster configuration.</param>
        /// <returns></returns>
        void ClusterResetMemberAsync (ClusterConfiguration body);
        /// <summary>
        /// Sets the Backup Protection Settings 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>BackupProtectionSettings</returns>
        BackupProtectionSettings ClusterSetBackupProtectionSettingsAsync (BackupProtectionSettings body);
        /// <summary>
        /// Assigns this cluster member to a set of managed network configurations 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <param name="body">Network configurations to assign this cluster member to</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        List<NetworkMember> ClusterSetClusterMemberNetworksAsync (string id, List<ManagedNetwork> body);
        /// <summary>
        /// Designates a particular cluster member as the cluster leader. 
        /// </summary>
        /// <param name="id">id of the cluster member to promote</param>
        /// <returns>ClusterMember</returns>
        ClusterMember ClusterSetLeaderAsync (string id);
        /// <summary>
        /// Sets the members assigned to this managed network configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <param name="body">Cluster members to assign</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        List<NetworkMember> ClusterSetNetworkMembersAsync (int? id, List<NetworkMember> body);
        /// <summary>
        /// Explicitly assign a set of assets to this managed network configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <param name="body">Assets to assign</param>
        /// <returns>List&lt;Asset&gt;</returns>
        List<Asset> ClusterSetNetworkSystemsAsync (int? id, List<Asset> body);
        /// <summary>
        /// Check which managed network the specified network address would be assigned to 
        /// </summary>
        /// <param name="body">Network address to test</param>
        /// <returns>ManagedNetwork</returns>
        ManagedNetwork ClusterTestNetworkAddressAsync (string body);
        /// <summary>
        /// Update the access request broker. 
        /// </summary>
        /// <param name="body">Access request broker</param>
        /// <returns>AccessRequestBroker</returns>
        AccessRequestBroker ClusterUpdateAccessRequestBrokerAsync (AccessRequestBroker body);
        /// <summary>
        /// Update the connection information for a specific session module in this cluster. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="body">Connection information for the external session module.  Only the description and IP address can be modified.</param>
        /// <returns>SessionModuleConnection</returns>
        SessionModuleConnection ClusterUpdateConnectedSessionModuleAsync (int? id, SessionModuleConnection body);
        /// <summary>
        /// Updates a managed network configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <param name="body">Updated entity</param>
        /// <returns>ManagedNetwork</returns>
        ManagedNetwork ClusterUpdateEntityAsync (int? id, ManagedNetwork body);
        /// <summary>
        /// Using a OneIdentity Challenge Response json string, authorize download of VM compatible backups for the cluster. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void ClusterVmCompatibleAuthorizationResponseAsync (string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ClusterApi : IClusterApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ClusterApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClusterApi(String basePath)
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
        /// Promotes this appliance from StandaloneReadOnly to Online./&gt; 
        /// </summary>
        /// <returns></returns>
        public void ClusterActivatePrimaryAsync ()
        {
    
            var path = "/v4/Cluster/Members/ActivatePrimary";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterActivatePrimaryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterActivatePrimaryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add/Remove network configuration assignments for this managed host member. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="memberId">Unique ID of the member</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Network configurations to assign this managed host member</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        public List<NetworkMember> ClusterAddRemoveManagedNetworkBySessionModuleAndMemberIdAsync (int? id, string memberId, ListOperation operation, List<ManagedNetwork> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterAddRemoveManagedNetworkBySessionModuleAndMemberIdAsync");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ClusterAddRemoveManagedNetworkBySessionModuleAndMemberIdAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling ClusterAddRemoveManagedNetworkBySessionModuleAndMemberIdAsync");
    
            var path = "/v4/Cluster/SessionModules/{id}/Members/{memberId}/ManagedNetworks/{operation}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "memberId" + "}", ApiClient.ParameterToString(memberId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterAddRemoveManagedNetworkBySessionModuleAndMemberIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterAddRemoveManagedNetworkBySessionModuleAndMemberIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NetworkMember>) ApiClient.Deserialize(response.Content, typeof(List<NetworkMember>), response.Headers);
        }
    
        /// <summary>
        /// Assigns this managed host member to a set of managed network configurations. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="memberId">Unique ID of the member</param>
        /// <param name="body">Network configurations to assign this managed host member</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        public List<NetworkMember> ClusterAssignManagedNetworkBySessionModuleAndMemberIdAsync (int? id, string memberId, List<ManagedNetwork> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterAssignManagedNetworkBySessionModuleAndMemberIdAsync");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ClusterAssignManagedNetworkBySessionModuleAndMemberIdAsync");
    
            var path = "/v4/Cluster/SessionModules/{id}/Members/{memberId}/ManagedNetworks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "memberId" + "}", ApiClient.ParameterToString(memberId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterAssignManagedNetworkBySessionModuleAndMemberIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterAssignManagedNetworkBySessionModuleAndMemberIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NetworkMember>) ApiClient.Deserialize(response.Content, typeof(List<NetworkMember>), response.Headers);
        }
    
        /// <summary>
        /// Returns precondition errors and warnings from the currently staged patch for the entire cluster. 
        /// </summary>
        /// <returns>ClusterPatchPreconditionResult</returns>
        public ClusterPatchPreconditionResult ClusterCheckPreconditionsAsync ()
        {
    
            var path = "/v4/Cluster/Patch/PreconditionCheck";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterCheckPreconditionsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterCheckPreconditionsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClusterPatchPreconditionResult) ApiClient.Deserialize(response.Content, typeof(ClusterPatchPreconditionResult), response.Headers);
        }
    
        /// <summary>
        /// Starts the trust to create a session connection to link an external session module to this cluster.  Note: This will only be invoked from SPS. They don&#x27;t know about ApiError so it is best  to keep the response simple. 
        /// </summary>
        /// <param name="body">Connection information for the new external session module</param>
        /// <returns>SessionModuleConnection</returns>
        public SessionModuleConnection ClusterConnectSessionModuleAsync (SessionModuleConnection body)
        {
    
            var path = "/v4/Cluster/SessionModules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterConnectSessionModuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterConnectSessionModuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SessionModuleConnection) ApiClient.Deserialize(response.Content, typeof(SessionModuleConnection), response.Headers);
        }
    
        /// <summary>
        /// Creates a managed network configuration 
        /// </summary>
        /// <param name="body">Entity to create</param>
        /// <returns>ManagedNetwork</returns>
        public ManagedNetwork ClusterCreateEntityAsync (ManagedNetwork body)
        {
    
            var path = "/v4/Cluster/ManagedNetworks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterCreateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterCreateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagedNetwork) ApiClient.Deserialize(response.Content, typeof(ManagedNetwork), response.Headers);
        }
    
        /// <summary>
        /// Deletes all existing challenge requests 
        /// </summary>
        /// <returns></returns>
        public void ClusterDeleteAllChallengeRequestsAsync ()
        {
    
            var path = "/v4/Cluster/VMCompatibleBackup/ChallengeRequest";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterDeleteAllChallengeRequestsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterDeleteAllChallengeRequestsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a managed network configuration. Appliances and assets will be assigned to the default network 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <returns></returns>
        public void ClusterDeleteAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterDeleteAsync");
    
            var path = "/v4/Cluster/ManagedNetworks/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterDeleteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterDeleteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Unjoin a specific member, by id, from the cluster. 
        /// </summary>
        /// <param name="id">id of the member to be removed</param>
        /// <returns></returns>
        public void ClusterDeleteMemberAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterDeleteMemberAsync");
    
            var path = "/v4/Cluster/Members/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterDeleteMemberAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterDeleteMemberAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Disconnect a specific external session module from the cluster. 
        /// </summary>
        /// <param name="id">ID of the session module to be disconnected</param>
        /// <returns></returns>
        public void ClusterDeleteSessionModuleConnectionAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterDeleteSessionModuleConnectionAsync");
    
            var path = "/v4/Cluster/SessionModules/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterDeleteSessionModuleConnectionAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterDeleteSessionModuleConnectionAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Revokes the VM Compatible Backup Authorization 
        /// </summary>
        /// <returns>VMCompatibleBackupAuthorizationSetting</returns>
        public VMCompatibleBackupAuthorizationSetting ClusterDeleteVMCompatibleAuthorizationAsync ()
        {
    
            var path = "/v4/Cluster/VMCompatibleBackup/Authorization";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterDeleteVMCompatibleAuthorizationAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterDeleteVMCompatibleAuthorizationAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VMCompatibleBackupAuthorizationSetting) ApiClient.Deserialize(response.Content, typeof(VMCompatibleBackupAuthorizationSetting), response.Headers);
        }
    
        /// <summary>
        /// Enrolls a new member in this cluster. 
        /// </summary>
        /// <param name="body">Information about the appliance enrolling</param>
        /// <returns></returns>
        public void ClusterEnrollMemberAsync (EnrollNewClusterMember body)
        {
    
            var path = "/v4/Cluster/Members";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterEnrollMemberAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterEnrollMemberAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Force the current cluster operation to complete. 
        /// </summary>
        /// <returns></returns>
        public void ClusterForceCompleteAsync ()
        {
    
            var path = "/v4/Cluster/Status/ForceComplete";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterForceCompleteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterForceCompleteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Force the cluster configuration on this appliance to reset to a single  appliance operating as a primary. After resetting the cluster configuration  the appliance will come online in a deactivated mode to avoid conflicts with  password check/change operations. 
        /// </summary>
        /// <returns></returns>
        public void ClusterForceResetAsync ()
        {
    
            var path = "/v4/Cluster/Members/ForceReset";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterForceResetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterForceResetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// List of possible cluster actions 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> ClusterGet ()
        {
    
            var path = "/v4/Cluster";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Gets the access request broker. 
        /// </summary>
        /// <returns>AccessRequestBroker</returns>
        public AccessRequestBroker ClusterGetAccessRequestBrokerAsync ()
        {
    
            var path = "/v4/Cluster/SessionModules/AccessRequestBroker";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetAccessRequestBrokerAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetAccessRequestBrokerAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequestBroker) ApiClient.Deserialize(response.Content, typeof(AccessRequestBroker), response.Headers);
        }
    
        /// <summary>
        /// Gets the list of cluster certificates 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output.</param>
        /// <returns>List&lt;ServerCertificate&gt;</returns>
        public List<ServerCertificate> ClusterGetAllClusterCertificatesAsync (string fields)
        {
    
            var path = "/v4/Cluster/Certificates";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetAllClusterCertificatesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetAllClusterCertificatesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ServerCertificate>) ApiClient.Deserialize(response.Content, typeof(List<ServerCertificate>), response.Headers);
        }
    
        /// <summary>
        /// Return a list of all cluster members. 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        public List<NetworkMember> ClusterGetAllClusterNodesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Cluster/SessionModules/Members";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetAllClusterNodesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetAllClusterNodesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NetworkMember>) ApiClient.Deserialize(response.Content, typeof(List<NetworkMember>), response.Headers);
        }
    
        /// <summary>
        /// Returns the list of applications. 
        /// </summary>
        /// <returns>List&lt;Application&gt;</returns>
        public List<Application> ClusterGetApplicationsAsync ()
        {
    
            var path = "/v4/Cluster/Applications";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetApplicationsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetApplicationsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Application>) ApiClient.Deserialize(response.Content, typeof(List<Application>), response.Headers);
        }
    
        /// <summary>
        /// Returns Backup Protection Settings 
        /// </summary>
        /// <returns>BackupProtectionSettings</returns>
        public BackupProtectionSettings ClusterGetBackupProtectionSettingsAsync ()
        {
    
            var path = "/v4/Cluster/BackupProtectionSettings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetBackupProtectionSettingsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetBackupProtectionSettingsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BackupProtectionSettings) ApiClient.Deserialize(response.Content, typeof(BackupProtectionSettings), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific managed network configuration 
        /// </summary>
        /// <param name="id">Unique ID of entity</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ManagedNetwork</returns>
        public ManagedNetwork ClusterGetByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterGetByIdAsync");
    
            var path = "/v4/Cluster/ManagedNetworks/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagedNetwork) ApiClient.Deserialize(response.Content, typeof(ManagedNetwork), response.Headers);
        }
    
        /// <summary>
        /// Gets the public information for a cluster certificate by type 
        /// </summary>
        /// <param name="type">Certificate type to get. Supported types are ClusterRoot, SecureTokenService, AuditLogSigning.</param>
        /// <param name="fields">List of property names to include in entity output.</param>
        /// <returns>ServerCertificate</returns>
        public ServerCertificate ClusterGetClusterCertificateAsync (CertificateType type, string fields)
        {
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling ClusterGetClusterCertificateAsync");
    
            var path = "/v4/Cluster/Certificates/{type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetClusterCertificateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetClusterCertificateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServerCertificate) ApiClient.Deserialize(response.Content, typeof(ServerCertificate), response.Headers);
        }
    
        /// <summary>
        /// Gets all network configurations managed by this cluster member 
        /// </summary>
        /// <param name="id">Unique identifier of the cluster member</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ManagedNetwork&gt;</returns>
        public List<ManagedNetwork> ClusterGetClusterMemberNetworksAsync (string id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterGetClusterMemberNetworksAsync");
    
            var path = "/v4/Cluster/Members/{id}/ManagedNetworks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetClusterMemberNetworksAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetClusterMemberNetworksAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ManagedNetwork>) ApiClient.Deserialize(response.Content, typeof(List<ManagedNetwork>), response.Headers);
        }
    
        /// <summary>
        /// Return whether the cluster is configured to use external session modules. 
        /// </summary>
        /// <returns>bool?</returns>
        public bool? ClusterGetExternalSessionModuleStateAsync ()
        {
    
            var path = "/v4/Cluster/SessionModules/UsingExternal";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetExternalSessionModuleStateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetExternalSessionModuleStateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
        /// <summary>
        /// Get information about platform tasks load 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PlatformTaskLoadStatus</returns>
        public PlatformTaskLoadStatus ClusterGetLoadStatusAsync (string fields)
        {
    
            var path = "/v4/Cluster/Status/PlatformTaskLoadStatus";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetLoadStatusAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetLoadStatusAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PlatformTaskLoadStatus) ApiClient.Deserialize(response.Content, typeof(PlatformTaskLoadStatus), response.Headers);
        }
    
        /// <summary>
        /// Return the managed networks by session module and member id. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="memberId">Unique ID of the member</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        public List<NetworkMember> ClusterGetManagedNetworksBySessionModuleAndMemberIdAsync (int? id, string memberId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterGetManagedNetworksBySessionModuleAndMemberIdAsync");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ClusterGetManagedNetworksBySessionModuleAndMemberIdAsync");
    
            var path = "/v4/Cluster/SessionModules/{id}/Members/{memberId}/ManagedNetworks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "memberId" + "}", ApiClient.ParameterToString(memberId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetManagedNetworksBySessionModuleAndMemberIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetManagedNetworksBySessionModuleAndMemberIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NetworkMember>) ApiClient.Deserialize(response.Content, typeof(List<NetworkMember>), response.Headers);
        }
    
        /// <summary>
        /// Return information about a specific appliance in this cluster. 
        /// </summary>
        /// <param name="id">Unique ID of cluster member</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ClusterMember</returns>
        public ClusterMember ClusterGetMemberByIdAsync (string id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterGetMemberByIdAsync");
    
            var path = "/v4/Cluster/Members/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetMemberByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetMemberByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClusterMember) ApiClient.Deserialize(response.Content, typeof(ClusterMember), response.Headers);
        }
    
        /// <summary>
        /// Return information about all appliances in this cluster. 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ClusterMember&gt;</returns>
        public List<ClusterMember> ClusterGetMembersAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Cluster/Members";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetMembersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetMembersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ClusterMember>) ApiClient.Deserialize(response.Content, typeof(List<ClusterMember>), response.Headers);
        }
    
        /// <summary>
        /// Gets all assets that have been explicitly assigned to the managed network configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the managed network</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Asset&gt;</returns>
        public List<Asset> ClusterGetNetworkAssetsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterGetNetworkAssetsAsync");
    
            var path = "/v4/Cluster/ManagedNetworks/{id}/Assets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetNetworkAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetNetworkAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Asset>) ApiClient.Deserialize(response.Content, typeof(List<Asset>), response.Headers);
        }
    
        /// <summary>
        /// Gets all members that have been assigned to the managed network configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the managed network</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        public List<NetworkMember> ClusterGetNetworkMembersAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterGetNetworkMembersAsync");
    
            var path = "/v4/Cluster/ManagedNetworks/{id}/Members";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetNetworkMembersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetNetworkMembersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NetworkMember>) ApiClient.Deserialize(response.Content, typeof(List<NetworkMember>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of managed networks configuration 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ManagedNetwork&gt;</returns>
        public List<ManagedNetwork> ClusterGetNetworksAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Cluster/ManagedNetworks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetNetworksAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetNetworksAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ManagedNetwork>) ApiClient.Deserialize(response.Content, typeof(List<ManagedNetwork>), response.Headers);
        }
    
        /// <summary>
        /// Get currently scheduled tasks 
        /// </summary>
        /// <param name="taskName">Type of scheduled tasks to find</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ScheduledTask&gt;</returns>
        public List<ScheduledTask> ClusterGetScheduledPlatformTasksAsync (ScheduledTaskNames taskName, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'taskName' is set
            if (taskName == null) throw new ApiException(400, "Missing required parameter 'taskName' when calling ClusterGetScheduledPlatformTasksAsync");
    
            var path = "/v4/Cluster/Status/PlatformTaskLoadStatus/{taskName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "taskName" + "}", ApiClient.ParameterToString(taskName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetScheduledPlatformTasksAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetScheduledPlatformTasksAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ScheduledTask>) ApiClient.Deserialize(response.Content, typeof(List<ScheduledTask>), response.Headers);
        }
    
        /// <summary>
        /// Get summarized counts of currently scheduled tasks based on an interval 
        /// </summary>
        /// <param name="summaryIntervalMinutes">Interval to summarize tasks. Minimum 30 minutes. (Default &#x3D; 30 minutes)</param>
        /// <param name="taskNames">A comma-separated list of task names to include in entity output. (Default &#x3D; all)</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SummaryInformation</returns>
        public SummaryInformation ClusterGetScheduledPlatformTasksSummariesAsync (int? summaryIntervalMinutes, string taskNames, string fields)
        {
    
            var path = "/v4/Cluster/Status/PlatformTaskLoadStatus/Summaries";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (summaryIntervalMinutes != null) queryParams.Add("summaryIntervalMinutes", ApiClient.ParameterToString(summaryIntervalMinutes)); // query parameter
 if (taskNames != null) queryParams.Add("taskNames", ApiClient.ParameterToString(taskNames)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetScheduledPlatformTasksSummariesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetScheduledPlatformTasksSummariesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SummaryInformation) ApiClient.Deserialize(response.Content, typeof(SummaryInformation), response.Headers);
        }
    
        /// <summary>
        /// Force a health check and return cluster information for this node 
        /// </summary>
        /// <returns>ClusterMember</returns>
        public ClusterMember ClusterGetSelfAsync ()
        {
    
            var path = "/v4/Cluster/Members/Self";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSelfAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSelfAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClusterMember) ApiClient.Deserialize(response.Content, typeof(ClusterMember), response.Headers);
        }
    
        /// <summary>
        /// Return a managed host member by session module and member id. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="memberId">Unique ID of the member</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>NetworkMember</returns>
        public NetworkMember ClusterGetSessionModuleClusterNodeByIdAsync (int? id, string memberId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterGetSessionModuleClusterNodeByIdAsync");
            // verify the required parameter 'memberId' is set
            if (memberId == null) throw new ApiException(400, "Missing required parameter 'memberId' when calling ClusterGetSessionModuleClusterNodeByIdAsync");
    
            var path = "/v4/Cluster/SessionModules/{id}/Members/{memberId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "memberId" + "}", ApiClient.ParameterToString(memberId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSessionModuleClusterNodeByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSessionModuleClusterNodeByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (NetworkMember) ApiClient.Deserialize(response.Content, typeof(NetworkMember), response.Headers);
        }
    
        /// <summary>
        /// Return a list of the managed host members by session module. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        public List<NetworkMember> ClusterGetSessionModuleClusterNodesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterGetSessionModuleClusterNodesAsync");
    
            var path = "/v4/Cluster/SessionModules/{id}/Members";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSessionModuleClusterNodesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSessionModuleClusterNodesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NetworkMember>) ApiClient.Deserialize(response.Content, typeof(List<NetworkMember>), response.Headers);
        }
    
        /// <summary>
        /// Return information about a connected session module for this cluster. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SessionModuleConnection</returns>
        public SessionModuleConnection ClusterGetSessionModuleConnectionByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterGetSessionModuleConnectionByIdAsync");
    
            var path = "/v4/Cluster/SessionModules/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSessionModuleConnectionByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSessionModuleConnectionByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SessionModuleConnection) ApiClient.Deserialize(response.Content, typeof(SessionModuleConnection), response.Headers);
        }
    
        /// <summary>
        /// Return a list of connection policies from the connected session modules in the cluster. 
        /// </summary>
        /// <param name="protocol">Filter the results by protocol (RDP | SSH (default))</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <param name="refresh">Force a refresh of the session connection policies.</param>
        /// <returns>List&lt;SessionModuleConnectionPolicy&gt;</returns>
        public List<SessionModuleConnectionPolicy> ClusterGetSessionModuleConnectionPoliciesAsync (SessionModuleConnectionProtocol protocol, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q, bool? refresh)
        {
    
            var path = "/v4/Cluster/SessionModules/ConnectionPolicies";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (protocol != null) queryParams.Add("protocol", ApiClient.ParameterToString(protocol)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
 if (refresh != null) queryParams.Add("refresh", ApiClient.ParameterToString(refresh)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSessionModuleConnectionPoliciesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSessionModuleConnectionPoliciesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SessionModuleConnectionPolicy>) ApiClient.Deserialize(response.Content, typeof(List<SessionModuleConnectionPolicy>), response.Headers);
        }
    
        /// <summary>
        /// Return a list of connection policies by session module. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="protocol">Filter the results by protocol (RDP | SSH (default))</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <param name="refresh">Force a refresh of the session connection policies.</param>
        /// <returns>List&lt;SessionModuleConnectionPolicy&gt;</returns>
        public List<SessionModuleConnectionPolicy> ClusterGetSessionModuleConnectionPoliciesByIdAsync (int? id, SessionModuleConnectionProtocol protocol, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q, bool? refresh)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterGetSessionModuleConnectionPoliciesByIdAsync");
    
            var path = "/v4/Cluster/SessionModules/{id}/ConnectionPolicies";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (protocol != null) queryParams.Add("protocol", ApiClient.ParameterToString(protocol)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
 if (refresh != null) queryParams.Add("refresh", ApiClient.ParameterToString(refresh)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSessionModuleConnectionPoliciesByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSessionModuleConnectionPoliciesByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SessionModuleConnectionPolicy>) ApiClient.Deserialize(response.Content, typeof(List<SessionModuleConnectionPolicy>), response.Headers);
        }
    
        /// <summary>
        /// Return a connection policy by session module. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="policyId">Unique ID of the session module</param>
        /// <param name="protocol">Filter the results by protocol (RDP | SSH (default))</param>
        /// <param name="refresh">Force a refresh of the session connection policies.</param>
        /// <returns>SessionModuleConnectionPolicy</returns>
        public SessionModuleConnectionPolicy ClusterGetSessionModuleConnectionPolicyByIdAsync (int? id, string policyId, SessionModuleConnectionProtocol protocol, bool? refresh)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterGetSessionModuleConnectionPolicyByIdAsync");
            // verify the required parameter 'policyId' is set
            if (policyId == null) throw new ApiException(400, "Missing required parameter 'policyId' when calling ClusterGetSessionModuleConnectionPolicyByIdAsync");
    
            var path = "/v4/Cluster/SessionModules/{id}/ConnectionPolicies/{policyId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "policyId" + "}", ApiClient.ParameterToString(policyId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (protocol != null) queryParams.Add("protocol", ApiClient.ParameterToString(protocol)); // query parameter
 if (refresh != null) queryParams.Add("refresh", ApiClient.ParameterToString(refresh)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSessionModuleConnectionPolicyByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSessionModuleConnectionPolicyByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SessionModuleConnectionPolicy) ApiClient.Deserialize(response.Content, typeof(SessionModuleConnectionPolicy), response.Headers);
        }
    
        /// <summary>
        /// Return information about all of the connected session modules for this cluster. 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <param name="includeDisconnected">Include disconnected session modules</param>
        /// <returns>List&lt;SessionModuleConnection&gt;</returns>
        public List<SessionModuleConnection> ClusterGetSessionModuleConnectionsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q, bool? includeDisconnected)
        {
    
            var path = "/v4/Cluster/SessionModules";
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
 if (includeDisconnected != null) queryParams.Add("includeDisconnected", ApiClient.ParameterToString(includeDisconnected)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSessionModuleConnectionsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetSessionModuleConnectionsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SessionModuleConnection>) ApiClient.Deserialize(response.Content, typeof(List<SessionModuleConnection>), response.Headers);
        }
    
        /// <summary>
        /// Returns the cluster lock status. 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ClusterOperationStatus</returns>
        public ClusterOperationStatus ClusterGetStatusAsync (string fields)
        {
    
            var path = "/v4/Cluster/Status";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetStatusAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetStatusAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClusterOperationStatus) ApiClient.Deserialize(response.Content, typeof(ClusterOperationStatus), response.Headers);
        }
    
        /// <summary>
        /// Gets the VM Compatible Backup Authorization Setting 
        /// </summary>
        /// <returns>VMCompatibleBackupAuthorizationSetting</returns>
        public VMCompatibleBackupAuthorizationSetting ClusterGetVMCompatibleAuthorization ()
        {
    
            var path = "/v4/Cluster/VMCompatibleBackup/Authorization";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetVMCompatibleAuthorization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterGetVMCompatibleAuthorization: " + response.ErrorMessage, response.ErrorMessage);
    
            return (VMCompatibleBackupAuthorizationSetting) ApiClient.Deserialize(response.Content, typeof(VMCompatibleBackupAuthorizationSetting), response.Headers);
        }
    
        /// <summary>
        /// Isolate the appliance to be available for access requests despite its inability  to communicate with the rest of the cluster. 
        /// </summary>
        /// <returns></returns>
        public void ClusterIsolateAsync ()
        {
    
            var path = "/v4/Cluster/Status/Isolate";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterIsolateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterIsolateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add/Remove network configuration assignments for this cluster member 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Network configurations to assign this cluster member to</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        public List<NetworkMember> ClusterModifyClusterMemberNetworksAsync (string id, ListOperation operation, List<ManagedNetwork> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterModifyClusterMemberNetworksAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling ClusterModifyClusterMemberNetworksAsync");
    
            var path = "/v4/Cluster/Members/{id}/ManagedNetworks/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterModifyClusterMemberNetworksAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterModifyClusterMemberNetworksAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NetworkMember>) ApiClient.Deserialize(response.Content, typeof(List<NetworkMember>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove members assigned to this managed network configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Member members to assign</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        public List<NetworkMember> ClusterModifyMembersAsync (int? id, ListOperation operation, List<NetworkMember> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterModifyMembersAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling ClusterModifyMembersAsync");
    
            var path = "/v4/Cluster/ManagedNetworks/{id}/Members/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterModifyMembersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterModifyMembersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NetworkMember>) ApiClient.Deserialize(response.Content, typeof(List<NetworkMember>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove assets assigned to this managed network configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Assets to assign</param>
        /// <returns>List&lt;Asset&gt;</returns>
        public List<Asset> ClusterModifySystemsAsync (int? id, ListOperation operation, List<Asset> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterModifySystemsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling ClusterModifySystemsAsync");
    
            var path = "/v4/Cluster/ManagedNetworks/{id}/Assets/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterModifySystemsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterModifySystemsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Asset>) ApiClient.Deserialize(response.Content, typeof(List<Asset>), response.Headers);
        }
    
        /// <summary>
        /// Gets the status of the patch distribution in cluster 
        /// </summary>
        /// <returns>PatchDistributionModel</returns>
        public PatchDistributionModel ClusterPatchDistributionAsync ()
        {
    
            var path = "/v4/Cluster/Status/PatchDistribution";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterPatchDistributionAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterPatchDistributionAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PatchDistributionModel) ApiClient.Deserialize(response.Content, typeof(PatchDistributionModel), response.Headers);
        }
    
        /// <summary>
        /// Generates a OneIdentity Challenge to authorize VM Compatible Backup download. 
        /// </summary>
        /// <param name="userIdentifier">The user who is requesting the challenge.</param>
        /// <param name="invalidateExistingChallengeRequest">Specify true if you wish to invalidate the existing request and use this one.</param>
        /// <returns>string</returns>
        public string ClusterPostVmCompatibleAuthorizationRequestAsync (string userIdentifier, bool? invalidateExistingChallengeRequest)
        {
    
            var path = "/v4/Cluster/VMCompatibleBackup/ChallengeRequest";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userIdentifier != null) queryParams.Add("userIdentifier", ApiClient.ParameterToString(userIdentifier)); // query parameter
 if (invalidateExistingChallengeRequest != null) queryParams.Add("invalidateExistingChallengeRequest", ApiClient.ParameterToString(invalidateExistingChallengeRequest)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterPostVmCompatibleAuthorizationRequestAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterPostVmCompatibleAuthorizationRequestAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Reverts the Isolate and reintegrates the appliance back in the cluster. 
        /// </summary>
        /// <returns></returns>
        public void ClusterReintegrateAsync ()
        {
    
            var path = "/v4/Cluster/Status/Reintegrate";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterReintegrateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterReintegrateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Resets the cluster configuration regardless of consensus. 
        /// </summary>
        /// <param name="body">New cluster configuration.</param>
        /// <returns></returns>
        public void ClusterResetMemberAsync (ClusterConfiguration body)
        {
    
            var path = "/v4/Cluster/Members/Reset";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterResetMemberAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterResetMemberAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sets the Backup Protection Settings 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>BackupProtectionSettings</returns>
        public BackupProtectionSettings ClusterSetBackupProtectionSettingsAsync (BackupProtectionSettings body)
        {
    
            var path = "/v4/Cluster/BackupProtectionSettings";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterSetBackupProtectionSettingsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterSetBackupProtectionSettingsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BackupProtectionSettings) ApiClient.Deserialize(response.Content, typeof(BackupProtectionSettings), response.Headers);
        }
    
        /// <summary>
        /// Assigns this cluster member to a set of managed network configurations 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <param name="body">Network configurations to assign this cluster member to</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        public List<NetworkMember> ClusterSetClusterMemberNetworksAsync (string id, List<ManagedNetwork> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterSetClusterMemberNetworksAsync");
    
            var path = "/v4/Cluster/Members/{id}/ManagedNetworks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterSetClusterMemberNetworksAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterSetClusterMemberNetworksAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NetworkMember>) ApiClient.Deserialize(response.Content, typeof(List<NetworkMember>), response.Headers);
        }
    
        /// <summary>
        /// Designates a particular cluster member as the cluster leader. 
        /// </summary>
        /// <param name="id">id of the cluster member to promote</param>
        /// <returns>ClusterMember</returns>
        public ClusterMember ClusterSetLeaderAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterSetLeaderAsync");
    
            var path = "/v4/Cluster/Members/{id}/Promote";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterSetLeaderAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterSetLeaderAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ClusterMember) ApiClient.Deserialize(response.Content, typeof(ClusterMember), response.Headers);
        }
    
        /// <summary>
        /// Sets the members assigned to this managed network configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <param name="body">Cluster members to assign</param>
        /// <returns>List&lt;NetworkMember&gt;</returns>
        public List<NetworkMember> ClusterSetNetworkMembersAsync (int? id, List<NetworkMember> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterSetNetworkMembersAsync");
    
            var path = "/v4/Cluster/ManagedNetworks/{id}/Members";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterSetNetworkMembersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterSetNetworkMembersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<NetworkMember>) ApiClient.Deserialize(response.Content, typeof(List<NetworkMember>), response.Headers);
        }
    
        /// <summary>
        /// Explicitly assign a set of assets to this managed network configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <param name="body">Assets to assign</param>
        /// <returns>List&lt;Asset&gt;</returns>
        public List<Asset> ClusterSetNetworkSystemsAsync (int? id, List<Asset> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterSetNetworkSystemsAsync");
    
            var path = "/v4/Cluster/ManagedNetworks/{id}/Assets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterSetNetworkSystemsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterSetNetworkSystemsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Asset>) ApiClient.Deserialize(response.Content, typeof(List<Asset>), response.Headers);
        }
    
        /// <summary>
        /// Check which managed network the specified network address would be assigned to 
        /// </summary>
        /// <param name="body">Network address to test</param>
        /// <returns>ManagedNetwork</returns>
        public ManagedNetwork ClusterTestNetworkAddressAsync (string body)
        {
    
            var path = "/v4/Cluster/ManagedNetworks/TestAddress";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterTestNetworkAddressAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterTestNetworkAddressAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagedNetwork) ApiClient.Deserialize(response.Content, typeof(ManagedNetwork), response.Headers);
        }
    
        /// <summary>
        /// Update the access request broker. 
        /// </summary>
        /// <param name="body">Access request broker</param>
        /// <returns>AccessRequestBroker</returns>
        public AccessRequestBroker ClusterUpdateAccessRequestBrokerAsync (AccessRequestBroker body)
        {
    
            var path = "/v4/Cluster/SessionModules/AccessRequestBroker";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterUpdateAccessRequestBrokerAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterUpdateAccessRequestBrokerAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequestBroker) ApiClient.Deserialize(response.Content, typeof(AccessRequestBroker), response.Headers);
        }
    
        /// <summary>
        /// Update the connection information for a specific session module in this cluster. 
        /// </summary>
        /// <param name="id">Unique ID of the session module</param>
        /// <param name="body">Connection information for the external session module.  Only the description and IP address can be modified.</param>
        /// <returns>SessionModuleConnection</returns>
        public SessionModuleConnection ClusterUpdateConnectedSessionModuleAsync (int? id, SessionModuleConnection body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterUpdateConnectedSessionModuleAsync");
    
            var path = "/v4/Cluster/SessionModules/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterUpdateConnectedSessionModuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterUpdateConnectedSessionModuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SessionModuleConnection) ApiClient.Deserialize(response.Content, typeof(SessionModuleConnection), response.Headers);
        }
    
        /// <summary>
        /// Updates a managed network configuration 
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <param name="body">Updated entity</param>
        /// <returns>ManagedNetwork</returns>
        public ManagedNetwork ClusterUpdateEntityAsync (int? id, ManagedNetwork body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ClusterUpdateEntityAsync");
    
            var path = "/v4/Cluster/ManagedNetworks/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterUpdateEntityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterUpdateEntityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ManagedNetwork) ApiClient.Deserialize(response.Content, typeof(ManagedNetwork), response.Headers);
        }
    
        /// <summary>
        /// Using a OneIdentity Challenge Response json string, authorize download of VM compatible backups for the cluster. 
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public void ClusterVmCompatibleAuthorizationResponseAsync (string body)
        {
    
            var path = "/v4/Cluster/VMCompatibleBackup/ChallengeResponse";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterVmCompatibleAuthorizationResponseAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ClusterVmCompatibleAuthorizationResponseAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
