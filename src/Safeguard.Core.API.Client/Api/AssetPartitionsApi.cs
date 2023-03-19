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
    public interface IAssetPartitionsApi
    {
        /// <summary>
        /// Checks if the current name is unique prior to create/update 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetPartition</param>
        /// <param name="body">Parameters for checking for unique name</param>
        /// <returns>bool?</returns>
        bool? AssetPartitionsCheckUniqueProfileNameAsync (int? id, UniqueNameParameters body);
        /// <summary>
        /// Checks if the current name is unique prior to create/update 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetPartition</param>
        /// <param name="body">Parameters for checking for unique name</param>
        /// <returns>bool?</returns>
        bool? AssetPartitionsCheckUniqueSshKeyProfileNameAsync (int? id, UniqueNameParameters body);
        /// <summary>
        /// Creates a new PartitionProfileAccountDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">PartitionProfileAccountDiscoverySchedule to create</param>
        /// <returns>AccountDiscoverySchedule</returns>
        AccountDiscoverySchedule AssetPartitionsCreateAccountDiscoveryAsync (int? id, AccountDiscoverySchedule body);
        /// <summary>
        /// Adds a new AssetPartition 
        /// </summary>
        /// <param name="body">AssetPartition to create</param>
        /// <returns>AssetPartition</returns>
        AssetPartition AssetPartitionsCreateAssetPartitionAsync (AssetPartition body);
        /// <summary>
        /// Adds a new PartitionProfileChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">The entity to create</param>
        /// <returns>PasswordChangeSchedule</returns>
        PasswordChangeSchedule AssetPartitionsCreateChangeScheduleAsync (int? id, PasswordChangeSchedule body);
        /// <summary>
        /// Adds a new PartitionProfileCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">PartitionProfileCheckSchedule to create</param>
        /// <returns>PasswordCheckSchedule</returns>
        PasswordCheckSchedule AssetPartitionsCreateCheckScheduleAsync (int? id, PasswordCheckSchedule body);
        /// <summary>
        /// Creates an asset discovery job 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="body">AssetDiscoveryJob to create</param>
        /// <returns>AssetDiscoveryJob</returns>
        AssetDiscoveryJob AssetPartitionsCreateDiscoveryJobAsync (int? id, AssetDiscoveryJob body);
        /// <summary>
        /// Creates a new password rule 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="body">AccountGroup to create</param>
        /// <returns>AccountPasswordRule</returns>
        AccountPasswordRule AssetPartitionsCreatePasswordRuleAsync (int? id, AccountPasswordRule body);
        /// <summary>
        /// Creates a new asset configuration profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">PartitionProfile to create</param>
        /// <returns>PasswordProfile</returns>
        PasswordProfile AssetPartitionsCreateProfileAsync (int? id, PasswordProfile body);
        /// <summary>
        /// Adds a new SshKeyChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">The entity to create</param>
        /// <returns>SshKeyChangeSchedule</returns>
        SshKeyChangeSchedule AssetPartitionsCreateSshKeyChangeScheduleAsync (int? id, SshKeyChangeSchedule body);
        /// <summary>
        /// Adds a new SshKeyCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">SshKeyCheckSchedule to create</param>
        /// <returns>SshKeyCheckSchedule</returns>
        SshKeyCheckSchedule AssetPartitionsCreateSshKeyCheckScheduleAsync (int? id, SshKeyCheckSchedule body);
        /// <summary>
        /// Adds a new SshKeyDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">The entity to create</param>
        /// <returns>SshKeyDiscoverySchedule</returns>
        SshKeyDiscoverySchedule AssetPartitionsCreateSshKeyDiscoveryScheduleAsync (int? id, SshKeyDiscoverySchedule body);
        /// <summary>
        /// Creates a new SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">SshKeyProfile to create</param>
        /// <returns>SshKeyProfile</returns>
        SshKeyProfile AssetPartitionsCreateSshKeyProfileAsync (int? id, SshKeyProfile body);
        /// <summary>
        /// Creates a new profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="body">SshKeySyncGroup to create</param>
        /// <returns>SshKeySyncGroup</returns>
        SshKeySyncGroup AssetPartitionsCreateSshKeySyncGroupAsync (int? id, int? profileId, SshKeySyncGroup body);
        /// <summary>
        /// Creates a new profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="body">PasswordSyncGroup to create</param>
        /// <returns>PasswordSyncGroup</returns>
        PasswordSyncGroup AssetPartitionsCreateSyncGroupAsync (int? id, int? profileId, PasswordSyncGroup body);
        /// <summary>
        /// Creates a new partition tag 
        /// </summary>
        /// <param name="id">Unique ID of partition</param>
        /// <param name="body">Tag to create</param>
        /// <returns>PartitionTag</returns>
        PartitionTag AssetPartitionsCreateTagAsync (int? id, PartitionTag body);
        /// <summary>
        /// Removes a PartitionProfileAccountDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the PartitionProfileAccountDiscoverySchedule</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        void AssetPartitionsDeleteAccountDiscoveryAsync (int? id, int? scheduleId, bool? forceDelete);
        /// <summary>
        /// Deletes all SSH keys discovered for a specific account 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountId">Unique ID of an account</param>
        /// <returns></returns>
        void AssetPartitionsDeleteAssetAccountDiscoveredSshKeysAsync (int? id, int? assetId, int? accountId);
        /// <summary>
        /// Marks all asset discovered account as deleted 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <returns></returns>
        void AssetPartitionsDeleteAssetDiscoveredAccountsAsync (int? id, int? assetId);
        /// <summary>
        /// Deletes all services discovered for a specific asset 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <returns></returns>
        void AssetPartitionsDeleteAssetDiscoveredServicesAsync (int? id, int? assetId);
        /// <summary>
        /// Deletes all SSH keys discovered for a specific asset 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <returns></returns>
        void AssetPartitionsDeleteAssetDiscoveredSshKeysAsync (int? id, int? assetId);
        /// <summary>
        /// Removes an AssetPartition 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetPartition to remove</param>
        /// <param name="failoverPartitionId">Database ID of the partition that assets should be moved to</param>
        /// <returns></returns>
        void AssetPartitionsDeleteAssetPartitionAsync (int? id, int? failoverPartitionId);
        /// <summary>
        /// Removes a PartitionProfileChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the PartitionProfileChangeSchedule to remove</param>
        /// <returns></returns>
        void AssetPartitionsDeleteChangeScheduleAsync (int? id, int? scheduleId);
        /// <summary>
        /// Removes a PartitionProfileCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the PartitionProfileCheckSchedule to remove</param>
        /// <returns></returns>
        void AssetPartitionsDeleteCheckScheduleAsync (int? id, int? scheduleId);
        /// <summary>
        /// Marks a discovered account as deleted 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="serviceName">Name of a discovered account. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <returns></returns>
        void AssetPartitionsDeleteDiscoveredServiceAsync (int? id, int? assetId, string serviceName);
        /// <summary>
        /// Marks a discovered SSH key as deleted 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountId">Unique ID of an account</param>
        /// <param name="fingerprint">MD5 fingerprint of the SSH key</param>
        /// <returns></returns>
        void AssetPartitionsDeleteDiscoveredSshKeyAsync (int? id, int? assetId, int? accountId, string fingerprint);
        /// <summary>
        /// Removes an asset discovery job 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="jobId">Unique identifier of the AssetDiscoveryJob</param>
        /// <returns></returns>
        void AssetPartitionsDeleteDiscoveryJobAsync (int? id, int? jobId);
        /// <summary>
        /// Marks a discovered account as deleted 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountName">Name of a discovered account. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <returns></returns>
        void AssetPartitionsDeletePartitionDiscoveredAccountAsync (int? id, int? assetId, string accountName);
        /// <summary>
        /// Marks all partition discovered accounts as deleted 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <returns></returns>
        void AssetPartitionsDeletePartitionDiscoveredAccountsAsync (int? id);
        /// <summary>
        /// Deletes all services discovered for a specific partition 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <returns></returns>
        void AssetPartitionsDeletePartitionDiscoveredServicesAsync (int? id);
        /// <summary>
        /// Deletes all SSH keys discovered for a specific partition 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <returns></returns>
        void AssetPartitionsDeletePartitionDiscoveredSshKeysAsync (int? id);
        /// <summary>
        /// Removes a password rule 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="ruleId">Unique identifier of the PartitionAccountPasswordRule to remove</param>
        /// <returns></returns>
        void AssetPartitionsDeletePasswordRuleAsync (int? id, int? ruleId);
        /// <summary>
        /// Removes an application asset configuration profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <returns></returns>
        void AssetPartitionsDeleteProfileAsync (int? id, int? profileId);
        /// <summary>
        /// Removes a SshKeyChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the SshKeyChangeSchedule to remove</param>
        /// <returns></returns>
        void AssetPartitionsDeleteSshKeyChangeScheduleAsync (int? id, int? scheduleId);
        /// <summary>
        /// Removes a SshKeyCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the SshKeyCheckSchedule to remove</param>
        /// <returns></returns>
        void AssetPartitionsDeleteSshKeyCheckScheduleAsync (int? id, int? scheduleId);
        /// <summary>
        /// Removes a SshKeyDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the SshKeyDiscoverySchedule to remove</param>
        /// <returns></returns>
        void AssetPartitionsDeleteSshKeyDiscoveryScheduleAsync (int? id, int? scheduleId);
        /// <summary>
        /// Removes an application asset configuration SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <returns></returns>
        void AssetPartitionsDeleteSshKeyProfileAsync (int? id, int? profileId);
        /// <summary>
        /// Removes a profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <returns></returns>
        void AssetPartitionsDeleteSshKeySyncGroupAsync (int? id, int? profileId, int? syncGroupId);
        /// <summary>
        /// Removes a profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <returns></returns>
        void AssetPartitionsDeleteSyncGroupAsync (int? id, int? profileId, int? syncGroupId);
        /// <summary>
        /// Removes a partition tag 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="tagId">Unique identifier of the tag</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        void AssetPartitionsDeleteTagAsync (int? id, int? tagId, bool? forceDelete);
        /// <summary>
        /// Disables an existing profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <returns>SshKeySyncGroup</returns>
        SshKeySyncGroup AssetPartitionsDisableSshKeySyncGroupAsync (int? id, int? profileId, int? syncGroupId);
        /// <summary>
        /// Disables an existing profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <returns>PasswordSyncGroup</returns>
        PasswordSyncGroup AssetPartitionsDisableSyncGroupAsync (int? id, int? profileId, int? syncGroupId);
        /// <summary>
        /// Enables an existing profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <returns>SshKeySyncGroup</returns>
        SshKeySyncGroup AssetPartitionsEnableSshKeySyncGroupAsync (int? id, int? profileId, int? syncGroupId);
        /// <summary>
        /// Enables an existing profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <returns>PasswordSyncGroup</returns>
        PasswordSyncGroup AssetPartitionsEnableSyncGroupAsync (int? id, int? profileId, int? syncGroupId);
        /// <summary>
        /// Generates a random password using this rule 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>string</returns>
        string AssetPartitionsGeneratePasswordFromCustomRuleAsync (AccountPasswordRule body);
        /// <summary>
        /// Generates a random password using this rule 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="ruleId">Unique identifier of the PartitionAccountPasswordRule to generate password from</param>
        /// <returns>string</returns>
        string AssetPartitionsGeneratePasswordFromRuleAsync (int? id, int? ruleId);
        /// <summary>
        /// Gets assets that the specified schedule is assigned to 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Asset&gt;</returns>
        List<Asset> AssetPartitionsGetAccountDiscoveryAssetsAsync (int? id, int? scheduleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets account discovery rules from an existing profile schedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountDiscoveryRule&gt;</returns>
        List<AccountDiscoveryRule> AssetPartitionsGetAccountDiscoveryRulesAsync (int? id, int? scheduleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a PartitionProfileAccountDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of PartitionProfileAccountDiscoverySchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccountDiscoverySchedule</returns>
        AccountDiscoverySchedule AssetPartitionsGetAccountDiscoveryScheduleByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets a list of PartitionProfileAccountDiscoverySchedules 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountDiscoverySchedule&gt;</returns>
        List<AccountDiscoverySchedule> AssetPartitionsGetAllAccountDiscoveryAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of partition change schedules across all partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordChangeSchedule&gt;</returns>
        List<PasswordChangeSchedule> AssetPartitionsGetAllChangeSchedulesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of partition password check schedules 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordCheckSchedule&gt;</returns>
        List<PasswordCheckSchedule> AssetPartitionsGetAllCheckSchedulesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all asset partition&#x27;s discovered accounts 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredAssetAccount&gt;</returns>
        List<DiscoveredAssetAccount> AssetPartitionsGetAllDiscoveredAccountsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all asset partition&#x27;s discovered services 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredService&gt;</returns>
        List<DiscoveredService> AssetPartitionsGetAllDiscoveredServicesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the discovered SSH keys for all asset partitions 
        /// </summary>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredSshKey&gt;</returns>
        List<DiscoveredSshKey> AssetPartitionsGetAllDiscoveredSshKeysAsync (SshKeyFormat keyFormat, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of asset discovery jobs 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetDiscoveryJob&gt;</returns>
        List<AssetDiscoveryJob> AssetPartitionsGetAllDiscoveryJobsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of password rules across all partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountPasswordRule&gt;</returns>
        List<AccountPasswordRule> AssetPartitionsGetAllPasswordRulesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of profiles 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordProfile&gt;</returns>
        List<PasswordProfile> AssetPartitionsGetAllProfilesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a summary of all profiles schedules across all partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AllProfileSchedulesSummary&gt;</returns>
        List<AllProfileSchedulesSummary> AssetPartitionsGetAllScheduleSummariesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of partition change schedules across all partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyChangeSchedule&gt;</returns>
        List<SshKeyChangeSchedule> AssetPartitionsGetAllSshKeyChangeSchedulesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of partition SSH key check schedules 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyCheckSchedule&gt;</returns>
        List<SshKeyCheckSchedule> AssetPartitionsGetAllSshKeyCheckSchedulesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of partition Discovery schedules across all partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyDiscoverySchedule&gt;</returns>
        List<SshKeyDiscoverySchedule> AssetPartitionsGetAllSshKeyDiscoverySchedulesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets an SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of SshKeyProfile</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyProfile</returns>
        SshKeyProfile AssetPartitionsGetAllSshKeyProfileByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets a list of SSH key profiles across all partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyProfile&gt;</returns>
        List<SshKeyProfile> AssetPartitionsGetAllSshKeyProfilesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of all SSH key sync groups 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeySyncGroup&gt;</returns>
        List<SshKeySyncGroup> AssetPartitionsGetAllSshKeySyncGroupsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific SSH key sync group 
        /// </summary>
        /// <param name="id">Unique ID of the SSH key sync group</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeySyncGroup</returns>
        SshKeySyncGroup AssetPartitionsGetAllSshKeySyncGroupsByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets a list of all partition sync groups 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordSyncGroup&gt;</returns>
        List<PasswordSyncGroup> AssetPartitionsGetAllSyncGroupsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of partition tags across partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, in, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PartitionTag&gt;</returns>
        List<PartitionTag> AssetPartitionsGetAllTagsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all accounts belonging to assets assigned to this partition 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetPartition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetPartitionsGetAssetAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a single AssetPartition entity 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AssetPartition</returns>
        AssetPartition AssetPartitionsGetAssetPartitionByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets a list of asset partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetPartition&gt;</returns>
        List<AssetPartition> AssetPartitionsGetAssetPartitionsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all assets that belong to the specified partition 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to get tasks for</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Asset&gt;</returns>
        List<Asset> AssetPartitionsGetAssetsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets accounts that the specified schedule is assigned to 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetPartitionsGetChangeScheduleAccountsAsync (int? id, int? scheduleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a single PartitionProfileChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of a PartitionProfileChangeSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordChangeSchedule</returns>
        PasswordChangeSchedule AssetPartitionsGetChangeScheduleByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets accounts that the specified schedule is assigned to 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetPartitionsGetCheckScheduleAccountsAsync (int? id, int? scheduleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a single PartitionProfileCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of a PartitionProfileCheckSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordCheckSchedule</returns>
        PasswordCheckSchedule AssetPartitionsGetCheckScheduleByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets an asset partition&#x27;s discovered services 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredService&gt;</returns>
        List<DiscoveredService> AssetPartitionsGetDiscoveredServicesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets an asset&#x27;s discovered services 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredService&gt;</returns>
        List<DiscoveredService> AssetPartitionsGetDiscoveredServicesByAssetAsync (int? id, int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets an asset&#x27;s discovered services 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="serviceName">Name of a discovered service. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <returns>List&lt;DiscoveredService&gt;</returns>
        List<DiscoveredService> AssetPartitionsGetDiscoveredServicesByServiceNameAsync (int? id, int? assetId, string serviceName, string fields);
        /// <summary>
        /// Gets an discovered SSH key 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountId">Unique ID of an account</param>
        /// <param name="fingerprint">MD5 fingerprint of SSH Key</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <returns>DiscoveredSshKey</returns>
        DiscoveredSshKey AssetPartitionsGetDiscoveredSshKeyByFingerprintAsync (int? id, int? assetId, int? accountId, string fingerprint, SshKeyFormat keyFormat, string fields);
        /// <summary>
        /// Gets the discovered SSH keys for an asset partition 
        /// </summary>
        /// <param name="id">Unique ID of the asset</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredSshKey&gt;</returns>
        List<DiscoveredSshKey> AssetPartitionsGetDiscoveredSshKeysAsync (int? id, SshKeyFormat keyFormat, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets discovered SSH keys for an account 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountId">Unique ID of an account</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredSshKey&gt;</returns>
        List<DiscoveredSshKey> AssetPartitionsGetDiscoveredSshKeysByAccountAsync (int? id, int? assetId, int? accountId, SshKeyFormat keyFormat, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets discovered SSH keys for an asset 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredSshKey&gt;</returns>
        List<DiscoveredSshKey> AssetPartitionsGetDiscoveredSshKeysByAssetAsync (int? id, int? assetId, SshKeyFormat keyFormat, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific asset discovery job 
        /// </summary>
        /// <param name="id">Unique ID of the asset discovery job</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AssetDiscoveryJob</returns>
        AssetDiscoveryJob AssetPartitionsGetDiscoveryJobByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets all rules that belong to an asset discovery rule 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="jobId">Unique identifier of the AssetDiscoveryJob</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetDiscoveryRule&gt;</returns>
        List<AssetDiscoveryRule> AssetPartitionsGetDiscoveryJobRulesAsync (int? id, int? jobId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the tagged objects 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="tagId">Unique ID of the tag</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, in, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ObjectWithTag&gt;</returns>
        List<ObjectWithTag> AssetPartitionsGetObjectsWithTagAsync (int? id, int? tagId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of PartitionProfileAccountDiscoverySchedules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountDiscoverySchedule&gt;</returns>
        List<AccountDiscoverySchedule> AssetPartitionsGetPartitionAccountDiscoveryAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a PartitionProfileAccountDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique ID of PartitionProfileAccountDiscoverySchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccountDiscoverySchedule</returns>
        AccountDiscoverySchedule AssetPartitionsGetPartitionAccountDiscoveryScheduleByIdAsync (int? id, int? scheduleId, string fields);
        /// <summary>
        /// Gets a single PartitionProfileChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique ID of a PartitionProfileChangeSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordChangeSchedule</returns>
        PasswordChangeSchedule AssetPartitionsGetPartitionChangeScheduleByIdAsync (int? id, int? scheduleId, string fields);
        /// <summary>
        /// Gets a list of partition change schedules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordChangeSchedule&gt;</returns>
        List<PasswordChangeSchedule> AssetPartitionsGetPartitionChangeSchedulesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a single PartitionProfileCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique ID of a PartitionProfileCheckSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordCheckSchedule</returns>
        PasswordCheckSchedule AssetPartitionsGetPartitionCheckScheduleByIdAsync (int? id, int? scheduleId, string fields);
        /// <summary>
        /// Gets a list of partition password check schedules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordCheckSchedule&gt;</returns>
        List<PasswordCheckSchedule> AssetPartitionsGetPartitionCheckSchedulesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a discovered account 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountName">Name of a discovered account. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>DiscoveredAssetAccount</returns>
        DiscoveredAssetAccount AssetPartitionsGetPartitionDiscoveredAccountAsync (int? id, int? assetId, string accountName, string fields);
        /// <summary>
        /// Gets an asset partition&#x27;s discovered accounts 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredAssetAccount&gt;</returns>
        List<DiscoveredAssetAccount> AssetPartitionsGetPartitionDiscoveredAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets an asset&#x27;s discovered accounts 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredAssetAccount&gt;</returns>
        List<DiscoveredAssetAccount> AssetPartitionsGetPartitionDiscoveredAccountsByAssetAsync (int? id, int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific asset discovery job 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="jobId">Unique ID of the asset discovery job</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AssetDiscoveryJob</returns>
        AssetDiscoveryJob AssetPartitionsGetPartitionDiscoveryJobAsync (int? id, int? jobId, string fields);
        /// <summary>
        /// Gets a list of asset discovery jobs 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetDiscoveryJob&gt;</returns>
        List<AssetDiscoveryJob> AssetPartitionsGetPartitionDiscoveryJobsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all owners of the specified partition 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to get tasks for</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> AssetPartitionsGetPartitionManagedByAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of PartitionProfile</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordProfile</returns>
        PasswordProfile AssetPartitionsGetPartitionProfileByIdAsync (int? id, int? profileId, string fields);
        /// <summary>
        /// Gets a list of profiles for a specific partition 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordProfile&gt;</returns>
        List<PasswordProfile> AssetPartitionsGetPartitionProfilesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a single SshKeyChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique ID of a SshKeyChangeSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyChangeSchedule</returns>
        SshKeyChangeSchedule AssetPartitionsGetPartitionSshKeyChangeScheduleByIdAsync (int? id, int? scheduleId, string fields);
        /// <summary>
        /// Gets a list of partition change schedules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyChangeSchedule&gt;</returns>
        List<SshKeyChangeSchedule> AssetPartitionsGetPartitionSshKeyChangeSchedulesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a single SshKeyCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique ID of a SshKeyCheckSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyCheckSchedule</returns>
        SshKeyCheckSchedule AssetPartitionsGetPartitionSshKeyCheckScheduleByIdAsync (int? id, int? scheduleId, string fields);
        /// <summary>
        /// Gets a single SshKeyDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique ID of a SshKeyDiscoverySchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyDiscoverySchedule</returns>
        SshKeyDiscoverySchedule AssetPartitionsGetPartitionSshKeyDiscoveryScheduleByIdAsync (int? id, int? scheduleId, string fields);
        /// <summary>
        /// Gets a list of partition Discovery schedules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyDiscoverySchedule&gt;</returns>
        List<SshKeyDiscoverySchedule> AssetPartitionsGetPartitionSshKeyDiscoverySchedulesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a partition tag 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="tagId">Unique ID of the tag</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PartitionTag</returns>
        PartitionTag AssetPartitionsGetPartitionTagByIdAsync (int? id, int? tagId, string fields);
        /// <summary>
        /// Gets a partition tag managed by 
        /// </summary>
        /// <param name="id">Unique ID of the tag</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> AssetPartitionsGetPartitionTagManagedByAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of partition tags 
        /// </summary>
        /// <param name="id">Unique ID of partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, in, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PartitionTag&gt;</returns>
        List<PartitionTag> AssetPartitionsGetPartitionTagsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets accounts that the specified rule is assigned to 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="ruleId">Unique identifier of the password rule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetPartitionsGetPasswordRuleAccountsAsync (int? id, int? ruleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific password rule 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="ruleId">Unique ID of a PasswordRule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccountPasswordRule</returns>
        AccountPasswordRule AssetPartitionsGetPasswordRuleAsync (int? id, int? ruleId, string fields);
        /// <summary>
        /// Gets a specific password rule 
        /// </summary>
        /// <param name="ruleId">Unique ID of a PasswordRule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccountPasswordRule</returns>
        AccountPasswordRule AssetPartitionsGetPasswordRuleByIdAsync (int? ruleId, string fields);
        /// <summary>
        /// Gets a list of password rules 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountPasswordRule&gt;</returns>
        List<AccountPasswordRule> AssetPartitionsGetPasswordRulesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the account password rule on the selected partition profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <returns>AccountPasswordRule</returns>
        AccountPasswordRule AssetPartitionsGetProfileAccountPasswordRuleAsync (int? id, int? profileId);
        /// <summary>
        /// Gets the accounts that are explicitly using this profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetPartitionsGetProfileAssetAccountsAsync (int? id, int? profileId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the Assets that are explicitly using this profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Asset&gt;</returns>
        List<Asset> AssetPartitionsGetProfileAssetsAsync (int? id, int? profileId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a profile 
        /// </summary>
        /// <param name="id">Unique ID of PartitionProfile</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordProfile</returns>
        PasswordProfile AssetPartitionsGetProfileByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets the change schedule on the selected partition profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <returns>PasswordChangeSchedule</returns>
        PasswordChangeSchedule AssetPartitionsGetProfileChangeScheduleAsync (int? id, int? profileId);
        /// <summary>
        /// Gets the check schedule on the selected partition profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <returns>PasswordCheckSchedule</returns>
        PasswordCheckSchedule AssetPartitionsGetProfileCheckScheduleAsync (int? id, int? profileId);
        /// <summary>
        /// Gets a specific profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordSyncGroup</returns>
        PasswordSyncGroup AssetPartitionsGetProfileSyncGroupByIdAsync (int? id, int? profileId, int? syncGroupId, string fields);
        /// <summary>
        /// Gets a list of sync groups for a specific profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordSyncGroup&gt;</returns>
        List<PasswordSyncGroup> AssetPartitionsGetProfileSyncGroupsAsync (int? id, int? profileId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets accounts that the specified schedule is assigned to 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetPartitionsGetSshKeyChangeScheduleAccountsAsync (int? id, int? scheduleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the change schedule on the selected partition profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <returns>SshKeyChangeSchedule</returns>
        SshKeyChangeSchedule AssetPartitionsGetSshKeyChangeScheduleAsync (int? id, int? profileId);
        /// <summary>
        /// Gets a single SshKeyChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of a SshKeyChangeSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyChangeSchedule</returns>
        SshKeyChangeSchedule AssetPartitionsGetSshKeyChangeScheduleByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets accounts that the specified schedule is assigned to 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetPartitionsGetSshKeyCheckScheduleAccountsAsync (int? id, int? scheduleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the check schedule on the selected partition profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <returns>SshKeyCheckSchedule</returns>
        SshKeyCheckSchedule AssetPartitionsGetSshKeyCheckScheduleAsync (int? id, int? profileId);
        /// <summary>
        /// Gets a single SshKeyCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of a SshKeyCheckSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyCheckSchedule</returns>
        SshKeyCheckSchedule AssetPartitionsGetSshKeyCheckScheduleByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets a list of partition SSH key check schedules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyCheckSchedule&gt;</returns>
        List<SshKeyCheckSchedule> AssetPartitionsGetSshKeyCheckSchedulesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets accounts that the specified schedule is assigned to 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetPartitionsGetSshKeyDiscoveryScheduleAccountsAsync (int? id, int? scheduleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a single SshKeyDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of a SshKeyDiscoverySchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyDiscoverySchedule</returns>
        SshKeyDiscoverySchedule AssetPartitionsGetSshKeyDiscoveryScheduleByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets the accounts that are explicitly using this SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetPartitionsGetSshKeyProfileAssetAccountsAsync (int? id, int? profileId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the Assets that are explicitly using this SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Asset&gt;</returns>
        List<Asset> AssetPartitionsGetSshKeyProfileAssetsAsync (int? id, int? profileId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets an SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of SshKeyProfile</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyProfile</returns>
        SshKeyProfile AssetPartitionsGetSshKeyProfileByIdAsync (int? id, int? profileId, string fields);
        /// <summary>
        /// Gets the discovery schedule on the selected partition profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <returns>SshKeyDiscoverySchedule</returns>
        SshKeyDiscoverySchedule AssetPartitionsGetSshKeyProfileDiscoveryScheduleAsync (int? id, int? profileId);
        /// <summary>
        /// Gets a list of SSH key profiles for a specific partition 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyProfile&gt;</returns>
        List<SshKeyProfile> AssetPartitionsGetSshKeyProfilesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all accounts that belong to a profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeySyncGroupAccount&gt;</returns>
        List<SshKeySyncGroupAccount> AssetPartitionsGetSshKeySyncGroupAccountsAsync (int? id, int? profileId, int? syncGroupId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeySyncGroup</returns>
        SshKeySyncGroup AssetPartitionsGetSshKeySyncGroupByIdAsync (int? id, int? profileId, int? syncGroupId, string fields);
        /// <summary>
        /// Gets a list of sync groups for a specific profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeySyncGroup&gt;</returns>
        List<SshKeySyncGroup> AssetPartitionsGetSshKeySyncGroupsAsync (int? id, int? profileId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all accounts that belong to a profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SyncGroupAccount&gt;</returns>
        List<SyncGroupAccount> AssetPartitionsGetSyncGroupAccountsAsync (int? id, int? profileId, int? syncGroupId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of the sync group</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordSyncGroup</returns>
        PasswordSyncGroup AssetPartitionsGetSyncGroupsByIdAsync (int? id, string fields);
        /// <summary>
        /// Gets a partition tag 
        /// </summary>
        /// <param name="id">Unique ID of the tag</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PartitionTag</returns>
        PartitionTag AssetPartitionsGetTagByIdAsync (int? id, string fields);
        /// <summary>
        /// Marks a discovered service as ignored 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="serviceName">Name of a discovered service. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <returns>DiscoveredService</returns>
        DiscoveredService AssetPartitionsIgnoreDiscoveredServiceAsync (int? id, int? assetId, string serviceName);
        /// <summary>
        /// Processes multiple asset account ignore requests 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="body">Discovered asset accounts to process</param>
        /// <returns>List&lt;DiscoveredAssetAccountBatchResponse&gt;</returns>
        List<DiscoveredAssetAccountBatchResponse> AssetPartitionsIgnoreMultipleAccountsAsync (int? id, List<DiscoveredAssetAccount> body);
        /// <summary>
        /// Marks a discovered account as ignored 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountName">Name of a discovered account. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <returns>DiscoveredAssetAccount</returns>
        DiscoveredAssetAccount AssetPartitionsIgnorePartitionDiscoveredAccountAsync (int? id, int? assetId, string accountName);
        /// <summary>
        /// Processes multiple asset account manage requests 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="body">Parameters for managing multiple discovered accounts</param>
        /// <returns>List&lt;ManagedDiscoveredAssetAccountBatchResponse&gt;</returns>
        List<ManagedDiscoveredAssetAccountBatchResponse> AssetPartitionsManageMultipleAccountsAsync (int? id, BatchManageParameters body);
        /// <summary>
        /// Brings a discovered account under management 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountName">Name of a discovered account. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <param name="body">Additional optional parameters for configuring the new account</param>
        /// <returns>AssetAccount</returns>
        AssetAccount AssetPartitionsManagePartitionDiscoveredAccountAsync (int? id, int? assetId, string accountName, AccountTemplate body);
        /// <summary>
        /// Add/Remove assets assigned to an existing account discovery schedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the account discovery schedule</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Users to assign to the account discovery schedule</param>
        /// <returns>List&lt;Asset&gt;</returns>
        List<Asset> AssetPartitionsModifyAccountDiscoveryAssetsAsync (int? id, int? scheduleId, ListOperation operation, List<Asset> body);
        /// <summary>
        /// Add/Remove profile schedule&#x27;s rules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">rules to assign to the profile schedule</param>
        /// <returns>List&lt;AccountDiscoveryRule&gt;</returns>
        List<AccountDiscoveryRule> AssetPartitionsModifyAccountDiscoveryRulesAsync (int? id, int? scheduleId, ListOperation operation, List<AccountDiscoveryRule> body);
        /// <summary>
        /// Add/Remove accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;SyncGroupAccount&gt;</returns>
        List<SyncGroupAccount> AssetPartitionsModifyAccountsAsync (int? id, int? profileId, int? syncGroupId, ListOperation operation, List<SyncGroupAccount> body);
        /// <summary>
        /// Add/Remove rules assigned to an asset discovery job 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="jobId">Unique identifier of the AssetDiscoveryJob</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Accounts to assign to the AssetDiscoveryJob</param>
        /// <returns>List&lt;AssetDiscoveryRule&gt;</returns>
        List<AssetDiscoveryRule> AssetPartitionsModifyDiscoveryJobRulesAsync (int? id, int? jobId, ListOperation operation, List<AssetDiscoveryRule> body);
        /// <summary>
        /// Add/Remove assigned owners of this partition 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetPartition</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">List of owners to assign to this partition</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> AssetPartitionsModifyManagedByAsync (int? id, ListOperation operation, List<Identity> body);
        /// <summary>
        /// Add/Remove accounts to an existing profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetPartitionsModifyProfileAssetAccountsAsync (int? id, int? profileId, ListOperation operation, List<AssetAccount> body);
        /// <summary>
        /// Add/Remove assets to an existing profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;Asset&gt;</returns>
        List<Asset> AssetPartitionsModifyProfileAssetsAsync (int? id, int? profileId, ListOperation operation, List<Asset> body);
        /// <summary>
        /// Add/Remove accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;SshKeySyncGroupAccount&gt;</returns>
        List<SshKeySyncGroupAccount> AssetPartitionsModifySshKeyAccountsAsync (int? id, int? profileId, int? syncGroupId, ListOperation operation, List<SshKeySyncGroupAccount> body);
        /// <summary>
        /// Add/Remove accounts to an existing SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetPartitionsModifySshKeyProfileAssetAccountsAsync (int? id, int? profileId, ListOperation operation, List<AssetAccount> body);
        /// <summary>
        /// Add/Remove accounts to an existing SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;Asset&gt;</returns>
        List<Asset> AssetPartitionsModifySshKeyProfileAssetsAsync (int? id, int? profileId, ListOperation operation, List<Asset> body);
        /// <summary>
        /// Run asset discovery job now 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="jobId">Database ID of asset discovery job</param>
        /// <param name="extendedLogging">Whether to include extended logging for the platform operation</param>
        /// <returns>AssetDiscoveryLog</returns>
        AssetDiscoveryLog AssetPartitionsRunDiscoveryJobAsync (int? id, int? jobId, bool? extendedLogging);
        /// <summary>
        /// Sets the assets that are assigned to this account discovery schedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the account discovery schedule</param>
        /// <param name="body">Users to assign to the account discovery schedule</param>
        /// <returns>List&lt;Asset&gt;</returns>
        List<Asset> AssetPartitionsSetAccountDiscoveryAssetsAsync (int? id, int? scheduleId, List<Asset> body);
        /// <summary>
        /// Sets the accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;SyncGroupAccount&gt;</returns>
        List<SyncGroupAccount> AssetPartitionsSetAccountsAsync (int? id, int? profileId, int? syncGroupId, List<SyncGroupAccount> body);
        /// <summary>
        /// Sets the rules assigned to an asset discovery job 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="jobId">Unique identifier of the AssetDiscoveryJob</param>
        /// <param name="body">Accounts to assign to the AssetDiscoveryJob</param>
        /// <returns>List&lt;AssetDiscoveryRule&gt;</returns>
        List<AssetDiscoveryRule> AssetPartitionsSetDiscoveryJobRulesAsync (int? id, int? jobId, List<AssetDiscoveryRule> body);
        /// <summary>
        /// Updates the assigned owners of this partition 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetPartition</param>
        /// <param name="body">List of owners to assign to this partition</param>
        /// <returns>List&lt;Identity&gt;</returns>
        List<Identity> AssetPartitionsSetPartitionManagedByAsync (int? id, List<Identity> body);
        /// <summary>
        /// Sets the sync group password 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="body">Password to set for this sync group</param>
        /// <returns></returns>
        void AssetPartitionsSetPasswordAsync (int? id, int? profileId, int? syncGroupId, string body);
        /// <summary>
        /// Sets the accounts that are explicitly using this profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetPartitionsSetProfileAssetAccountsAsync (int? id, int? profileId, List<AssetAccount> body);
        /// <summary>
        /// Sets the assets that are explicitly using this profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;Asset&gt;</returns>
        List<Asset> AssetPartitionsSetProfileAssetsAsync (int? id, int? profileId, List<Asset> body);
        /// <summary>
        /// Sets the accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;SshKeySyncGroupAccount&gt;</returns>
        List<SshKeySyncGroupAccount> AssetPartitionsSetSshKeyAccountsAsync (int? id, int? profileId, int? syncGroupId, List<SshKeySyncGroupAccount> body);
        /// <summary>
        /// Sets the sync group SSH key 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="body">SSH keyto set for this sync group</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <returns></returns>
        void AssetPartitionsSetSshKeyAsync (int? id, int? profileId, int? syncGroupId, AccountSshKey body, SshKeyFormat keyFormat);
        /// <summary>
        /// Sets the accounts that are explicitly using this SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        List<AssetAccount> AssetPartitionsSetSshKeyProfileAssetAccountsAsync (int? id, int? profileId, List<AssetAccount> body);
        /// <summary>
        /// Sets the assets that are explicitly using this SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;Asset&gt;</returns>
        List<Asset> AssetPartitionsSetSshKeyProfileAssetsAsync (int? id, int? profileId, List<Asset> body);
        /// <summary>
        /// Marks a discovered service as visible 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="serviceName">Name of a discovered service. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <returns>DiscoveredService</returns>
        DiscoveredService AssetPartitionsShowDiscoveredServiceAsync (int? id, int? assetId, string serviceName);
        /// <summary>
        /// Processes multiple asset account show requests 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="body">Discovered asset accounts to process</param>
        /// <returns>List&lt;DiscoveredAssetAccountBatchResponse&gt;</returns>
        List<DiscoveredAssetAccountBatchResponse> AssetPartitionsShowMultipleAccountsAsync (int? id, List<DiscoveredAssetAccount> body);
        /// <summary>
        /// Marks a discovered account as visible 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountName">Name of a discovered account. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <returns>DiscoveredAssetAccount</returns>
        DiscoveredAssetAccount AssetPartitionsShowPartitionDiscoveredAccountAsync (int? id, int? assetId, string accountName);
        /// <summary>
        /// Sync credentials for all accounts in sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AssetPartitionsSyncAccountsAsync (int? id, int? profileId, int? syncGroupId, bool? extendedLogging);
        /// <summary>
        /// Sync credentials for all accounts in sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AssetPartitionsSyncSshKeyAccountsAsync (int? id, int? profileId, int? syncGroupId, bool? extendedLogging);
        /// <summary>
        /// Runs Discovery on the given PartitionProfileAccountDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">Discovery parameters</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>AccountDiscoveryLog</returns>
        AccountDiscoveryLog AssetPartitionsTestAccountDiscoveryAsync (int? id, CustomPartitionDiscoverAccountsParameters body, bool? extendedLogging);
        /// <summary>
        /// Tests an asset account partition tagging rule change against partition asset accounts 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="body">Tagging rule to test</param>
        /// <param name="operationalOnly">Do not return no-op results</param>
        /// <param name="limit">Limit response to this number of results</param>
        /// <returns>List&lt;DynamicTaggingRuleTestResult&gt;</returns>
        List<DynamicTaggingRuleTestResult> AssetPartitionsTestAssetAccountRuleAsync (int? id, TaggingGroupingRule body, bool? operationalOnly, int? limit);
        /// <summary>
        /// Tests an asset partition tagging rule change against partition assets 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="body">Tagging rule to test</param>
        /// <param name="operationalOnly">Do not return no-op results</param>
        /// <param name="limit">Limit response to this number of results</param>
        /// <returns>List&lt;DynamicTaggingRuleTestResult&gt;</returns>
        List<DynamicTaggingRuleTestResult> AssetPartitionsTestAssetRuleAsync (int? id, TaggingGroupingRule body, bool? operationalOnly, int? limit);
        /// <summary>
        /// Tests the set of specific asset discovery conditions. Assets will only be discovered but not added to the database. 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="body">Parameters for testing asset discovery conditions</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>AssetDiscoveryLog</returns>
        AssetDiscoveryLog AssetPartitionsTestDiscoveryAsync (int? id, TestAssetDiscoveryParameters body, bool? extendedLogging);
        /// <summary>
        /// Runs Service Discovery on the given PartitionProfileAccountDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">Discovery parameters</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>ServiceDiscoveryLog</returns>
        ServiceDiscoveryLog AssetPartitionsTestServiceDiscoveryAsync (int? id, CustomPartitionDiscoverAccountsParameters body, bool? extendedLogging);
        /// <summary>
        /// Tests an asset account partition tagging rule change against partition asset accounts 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="tagId">Unique ID of the partition tag</param>
        /// <param name="body">Tagging rule to test</param>
        /// <param name="operationalOnly">Do not return no-op results</param>
        /// <param name="limit">Limit response to this number of results</param>
        /// <returns>List&lt;DynamicTaggingRuleTestResult&gt;</returns>
        List<DynamicTaggingRuleTestResult> AssetPartitionsTestTagAssetAccountRuleAsync (int? id, int? tagId, TaggingGroupingRule body, bool? operationalOnly, int? limit);
        /// <summary>
        /// Tests an asset partition tagging rule change against partition assets 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="tagId">Unique ID of the partition tag</param>
        /// <param name="body">Tagging rule to test</param>
        /// <param name="operationalOnly">Do not return no-op results</param>
        /// <param name="limit">Limit response to this number of results</param>
        /// <returns>List&lt;DynamicTaggingRuleTestResult&gt;</returns>
        List<DynamicTaggingRuleTestResult> AssetPartitionsTestTagAssetRuleAsync (int? id, int? tagId, TaggingGroupingRule body, bool? operationalOnly, int? limit);
        /// <summary>
        /// Updates an existing PartitionProfileAccountDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the PartitionProfileAccountDiscoverySchedule</param>
        /// <param name="body">Updated PartitionProfileAccountDiscoverySchedule</param>
        /// <returns>AccountDiscoverySchedule</returns>
        AccountDiscoverySchedule AssetPartitionsUpdateAccountDiscoveryAsync (int? id, int? scheduleId, AccountDiscoverySchedule body);
        /// <summary>
        /// Sets an existing profile schedule&#x27;s rules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="body">rules to assign to the profile schedule</param>
        /// <returns>List&lt;AccountDiscoveryRule&gt;</returns>
        List<AccountDiscoveryRule> AssetPartitionsUpdateAccountDiscoveryRulesAsync (int? id, int? scheduleId, List<AccountDiscoveryRule> body);
        /// <summary>
        /// Updates an AssetPartition 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetPartition to update</param>
        /// <param name="body">Updated AssetPartition</param>
        /// <returns>AssetPartition</returns>
        AssetPartition AssetPartitionsUpdateAssetPartitionAsync (int? id, AssetPartition body);
        /// <summary>
        /// Updates a PartitionProfileChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the PartitionProfileChangeSchedule to update</param>
        /// <param name="body">Updated PartitionProfileChangeSchedule</param>
        /// <returns>PasswordChangeSchedule</returns>
        PasswordChangeSchedule AssetPartitionsUpdateChangeScheduleAsync (int? id, int? scheduleId, PasswordChangeSchedule body);
        /// <summary>
        /// Updates a PartitionProfileCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the PartitionProfileCheckSchedule to update</param>
        /// <param name="body">Updated PartitionProfileCheckSchedule</param>
        /// <returns>PasswordCheckSchedule</returns>
        PasswordCheckSchedule AssetPartitionsUpdateCheckScheduleAsync (int? id, int? scheduleId, PasswordCheckSchedule body);
        /// <summary>
        /// Updates an asset discovery job 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="jobId">Unique identifier of the AssetDiscoveryJob</param>
        /// <param name="body">Updated AssetDiscoveryJob</param>
        /// <returns>AssetDiscoveryJob</returns>
        AssetDiscoveryJob AssetPartitionsUpdateDiscoveryJobAsync (int? id, int? jobId, AssetDiscoveryJob body);
        /// <summary>
        /// Updates an existing password rule 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="ruleId">Unique identifier of the AccountPasswordRule to update</param>
        /// <param name="body">Updated AccountPasswordRule</param>
        /// <returns>AccountPasswordRule</returns>
        AccountPasswordRule AssetPartitionsUpdatePasswordRuleAsync (int? id, int? ruleId, AccountPasswordRule body);
        /// <summary>
        /// Updates an existing application asset configuration profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="body">Updated PartitionProfile</param>
        /// <returns>PasswordProfile</returns>
        PasswordProfile AssetPartitionsUpdateProfileAsync (int? id, int? profileId, PasswordProfile body);
        /// <summary>
        /// Updates a SshKeyChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the SshKeyChangeSchedule to update</param>
        /// <param name="body">Updated SshKeyChangeSchedule</param>
        /// <returns>SshKeyChangeSchedule</returns>
        SshKeyChangeSchedule AssetPartitionsUpdateSshKeyChangeScheduleAsync (int? id, int? scheduleId, SshKeyChangeSchedule body);
        /// <summary>
        /// Updates a SshKeyCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the SshKeyCheckSchedule to update</param>
        /// <param name="body">Updated SshKeyCheckSchedule</param>
        /// <returns>SshKeyCheckSchedule</returns>
        SshKeyCheckSchedule AssetPartitionsUpdateSshKeyCheckScheduleAsync (int? id, int? scheduleId, SshKeyCheckSchedule body);
        /// <summary>
        /// Updates a SshKeyDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the SshKeyDiscoverySchedule to update</param>
        /// <param name="body">Updated SshKeyDiscoverySchedule</param>
        /// <returns>SshKeyDiscoverySchedule</returns>
        SshKeyDiscoverySchedule AssetPartitionsUpdateSshKeyDiscoveryScheduleAsync (int? id, int? scheduleId, SshKeyDiscoverySchedule body);
        /// <summary>
        /// Updates an existing SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <param name="body">Updated SshKeyProfile</param>
        /// <returns>SshKeyProfile</returns>
        SshKeyProfile AssetPartitionsUpdateSshKeyProfileAsync (int? id, int? profileId, SshKeyProfile body);
        /// <summary>
        /// Updates an existing profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="body">Updated SshKeySyncGroup</param>
        /// <returns>SshKeySyncGroup</returns>
        SshKeySyncGroup AssetPartitionsUpdateSshKeySyncGroupAsync (int? id, int? profileId, int? syncGroupId, SshKeySyncGroup body);
        /// <summary>
        /// Updates an existing profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="body">Updated PasswordSyncGroup</param>
        /// <returns>PasswordSyncGroup</returns>
        PasswordSyncGroup AssetPartitionsUpdateSyncGroupAsync (int? id, int? profileId, int? syncGroupId, PasswordSyncGroup body);
        /// <summary>
        /// Updates a partition tag 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="tagId">Unique identifier of the tag</param>
        /// <param name="body">Updated Tag</param>
        /// <returns>PartitionTag</returns>
        PartitionTag AssetPartitionsUpdateTagAsync (int? id, int? tagId, PartitionTag body);
        /// <summary>
        /// Validates a proposed password against the given rule 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="ruleId">Unique identifier of the PartitionAccountPasswordRule to update</param>
        /// <param name="body">Password to validate against this rule</param>
        /// <returns>bool?</returns>
        bool? AssetPartitionsValidateAccountPasswordByRuleAsync (int? id, int? ruleId, string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AssetPartitionsApi : IAssetPartitionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetPartitionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AssetPartitionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetPartitionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AssetPartitionsApi(String basePath)
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
        /// Checks if the current name is unique prior to create/update 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetPartition</param>
        /// <param name="body">Parameters for checking for unique name</param>
        /// <returns>bool?</returns>
        public bool? AssetPartitionsCheckUniqueProfileNameAsync (int? id, UniqueNameParameters body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsCheckUniqueProfileNameAsync");
    
            var path = "/v4/AssetPartitions/{id}/CheckUniqueProfileName";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCheckUniqueProfileNameAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCheckUniqueProfileNameAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
        /// <summary>
        /// Checks if the current name is unique prior to create/update 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetPartition</param>
        /// <param name="body">Parameters for checking for unique name</param>
        /// <returns>bool?</returns>
        public bool? AssetPartitionsCheckUniqueSshKeyProfileNameAsync (int? id, UniqueNameParameters body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsCheckUniqueSshKeyProfileNameAsync");
    
            var path = "/v4/AssetPartitions/{id}/CheckUniqueSshKeyProfileName";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCheckUniqueSshKeyProfileNameAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCheckUniqueSshKeyProfileNameAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
        /// <summary>
        /// Creates a new PartitionProfileAccountDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">PartitionProfileAccountDiscoverySchedule to create</param>
        /// <returns>AccountDiscoverySchedule</returns>
        public AccountDiscoverySchedule AssetPartitionsCreateAccountDiscoveryAsync (int? id, AccountDiscoverySchedule body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsCreateAccountDiscoveryAsync");
    
            var path = "/v4/AssetPartitions/{id}/AccountDiscoverySchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateAccountDiscoveryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateAccountDiscoveryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountDiscoverySchedule) ApiClient.Deserialize(response.Content, typeof(AccountDiscoverySchedule), response.Headers);
        }
    
        /// <summary>
        /// Adds a new AssetPartition 
        /// </summary>
        /// <param name="body">AssetPartition to create</param>
        /// <returns>AssetPartition</returns>
        public AssetPartition AssetPartitionsCreateAssetPartitionAsync (AssetPartition body)
        {
    
            var path = "/v4/AssetPartitions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateAssetPartitionAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateAssetPartitionAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetPartition) ApiClient.Deserialize(response.Content, typeof(AssetPartition), response.Headers);
        }
    
        /// <summary>
        /// Adds a new PartitionProfileChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">The entity to create</param>
        /// <returns>PasswordChangeSchedule</returns>
        public PasswordChangeSchedule AssetPartitionsCreateChangeScheduleAsync (int? id, PasswordChangeSchedule body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsCreateChangeScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/ChangeSchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateChangeScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateChangeScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordChangeSchedule) ApiClient.Deserialize(response.Content, typeof(PasswordChangeSchedule), response.Headers);
        }
    
        /// <summary>
        /// Adds a new PartitionProfileCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">PartitionProfileCheckSchedule to create</param>
        /// <returns>PasswordCheckSchedule</returns>
        public PasswordCheckSchedule AssetPartitionsCreateCheckScheduleAsync (int? id, PasswordCheckSchedule body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsCreateCheckScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/CheckSchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateCheckScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateCheckScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordCheckSchedule) ApiClient.Deserialize(response.Content, typeof(PasswordCheckSchedule), response.Headers);
        }
    
        /// <summary>
        /// Creates an asset discovery job 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="body">AssetDiscoveryJob to create</param>
        /// <returns>AssetDiscoveryJob</returns>
        public AssetDiscoveryJob AssetPartitionsCreateDiscoveryJobAsync (int? id, AssetDiscoveryJob body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsCreateDiscoveryJobAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveryJobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateDiscoveryJobAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateDiscoveryJobAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetDiscoveryJob) ApiClient.Deserialize(response.Content, typeof(AssetDiscoveryJob), response.Headers);
        }
    
        /// <summary>
        /// Creates a new password rule 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="body">AccountGroup to create</param>
        /// <returns>AccountPasswordRule</returns>
        public AccountPasswordRule AssetPartitionsCreatePasswordRuleAsync (int? id, AccountPasswordRule body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsCreatePasswordRuleAsync");
    
            var path = "/v4/AssetPartitions/{id}/PasswordRules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreatePasswordRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreatePasswordRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountPasswordRule) ApiClient.Deserialize(response.Content, typeof(AccountPasswordRule), response.Headers);
        }
    
        /// <summary>
        /// Creates a new asset configuration profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">PartitionProfile to create</param>
        /// <returns>PasswordProfile</returns>
        public PasswordProfile AssetPartitionsCreateProfileAsync (int? id, PasswordProfile body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsCreateProfileAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateProfileAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateProfileAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordProfile) ApiClient.Deserialize(response.Content, typeof(PasswordProfile), response.Headers);
        }
    
        /// <summary>
        /// Adds a new SshKeyChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">The entity to create</param>
        /// <returns>SshKeyChangeSchedule</returns>
        public SshKeyChangeSchedule AssetPartitionsCreateSshKeyChangeScheduleAsync (int? id, SshKeyChangeSchedule body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsCreateSshKeyChangeScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyChangeSchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateSshKeyChangeScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateSshKeyChangeScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyChangeSchedule) ApiClient.Deserialize(response.Content, typeof(SshKeyChangeSchedule), response.Headers);
        }
    
        /// <summary>
        /// Adds a new SshKeyCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">SshKeyCheckSchedule to create</param>
        /// <returns>SshKeyCheckSchedule</returns>
        public SshKeyCheckSchedule AssetPartitionsCreateSshKeyCheckScheduleAsync (int? id, SshKeyCheckSchedule body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsCreateSshKeyCheckScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyCheckSchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateSshKeyCheckScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateSshKeyCheckScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyCheckSchedule) ApiClient.Deserialize(response.Content, typeof(SshKeyCheckSchedule), response.Headers);
        }
    
        /// <summary>
        /// Adds a new SshKeyDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">The entity to create</param>
        /// <returns>SshKeyDiscoverySchedule</returns>
        public SshKeyDiscoverySchedule AssetPartitionsCreateSshKeyDiscoveryScheduleAsync (int? id, SshKeyDiscoverySchedule body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsCreateSshKeyDiscoveryScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyDiscoverySchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateSshKeyDiscoveryScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateSshKeyDiscoveryScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyDiscoverySchedule) ApiClient.Deserialize(response.Content, typeof(SshKeyDiscoverySchedule), response.Headers);
        }
    
        /// <summary>
        /// Creates a new SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">SshKeyProfile to create</param>
        /// <returns>SshKeyProfile</returns>
        public SshKeyProfile AssetPartitionsCreateSshKeyProfileAsync (int? id, SshKeyProfile body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsCreateSshKeyProfileAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateSshKeyProfileAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateSshKeyProfileAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyProfile) ApiClient.Deserialize(response.Content, typeof(SshKeyProfile), response.Headers);
        }
    
        /// <summary>
        /// Creates a new profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="body">SshKeySyncGroup to create</param>
        /// <returns>SshKeySyncGroup</returns>
        public SshKeySyncGroup AssetPartitionsCreateSshKeySyncGroupAsync (int? id, int? profileId, SshKeySyncGroup body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsCreateSshKeySyncGroupAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsCreateSshKeySyncGroupAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/SshKeySyncGroups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateSshKeySyncGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateSshKeySyncGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeySyncGroup) ApiClient.Deserialize(response.Content, typeof(SshKeySyncGroup), response.Headers);
        }
    
        /// <summary>
        /// Creates a new profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="body">PasswordSyncGroup to create</param>
        /// <returns>PasswordSyncGroup</returns>
        public PasswordSyncGroup AssetPartitionsCreateSyncGroupAsync (int? id, int? profileId, PasswordSyncGroup body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsCreateSyncGroupAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsCreateSyncGroupAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/SyncGroups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateSyncGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateSyncGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordSyncGroup) ApiClient.Deserialize(response.Content, typeof(PasswordSyncGroup), response.Headers);
        }
    
        /// <summary>
        /// Creates a new partition tag 
        /// </summary>
        /// <param name="id">Unique ID of partition</param>
        /// <param name="body">Tag to create</param>
        /// <returns>PartitionTag</returns>
        public PartitionTag AssetPartitionsCreateTagAsync (int? id, PartitionTag body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsCreateTagAsync");
    
            var path = "/v4/AssetPartitions/{id}/Tags";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateTagAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsCreateTagAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PartitionTag) ApiClient.Deserialize(response.Content, typeof(PartitionTag), response.Headers);
        }
    
        /// <summary>
        /// Removes a PartitionProfileAccountDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the PartitionProfileAccountDiscoverySchedule</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteAccountDiscoveryAsync (int? id, int? scheduleId, bool? forceDelete)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteAccountDiscoveryAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsDeleteAccountDiscoveryAsync");
    
            var path = "/v4/AssetPartitions/{id}/AccountDiscoverySchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteAccountDiscoveryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteAccountDiscoveryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes all SSH keys discovered for a specific account 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountId">Unique ID of an account</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteAssetAccountDiscoveredSshKeysAsync (int? id, int? assetId, int? accountId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteAssetAccountDiscoveredSshKeysAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsDeleteAssetAccountDiscoveredSshKeysAsync");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling AssetPartitionsDeleteAssetAccountDiscoveredSshKeysAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredSshKeys/{assetId}/{accountId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteAssetAccountDiscoveredSshKeysAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteAssetAccountDiscoveredSshKeysAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Marks all asset discovered account as deleted 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteAssetDiscoveredAccountsAsync (int? id, int? assetId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteAssetDiscoveredAccountsAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsDeleteAssetDiscoveredAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredAccounts/{assetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteAssetDiscoveredAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteAssetDiscoveredAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes all services discovered for a specific asset 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteAssetDiscoveredServicesAsync (int? id, int? assetId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteAssetDiscoveredServicesAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsDeleteAssetDiscoveredServicesAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredServices/{assetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteAssetDiscoveredServicesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteAssetDiscoveredServicesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes all SSH keys discovered for a specific asset 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteAssetDiscoveredSshKeysAsync (int? id, int? assetId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteAssetDiscoveredSshKeysAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsDeleteAssetDiscoveredSshKeysAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredSshKeys/{assetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteAssetDiscoveredSshKeysAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteAssetDiscoveredSshKeysAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes an AssetPartition 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetPartition to remove</param>
        /// <param name="failoverPartitionId">Database ID of the partition that assets should be moved to</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteAssetPartitionAsync (int? id, int? failoverPartitionId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteAssetPartitionAsync");
    
            var path = "/v4/AssetPartitions/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (failoverPartitionId != null) queryParams.Add("failoverPartitionId", ApiClient.ParameterToString(failoverPartitionId)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteAssetPartitionAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteAssetPartitionAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a PartitionProfileChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the PartitionProfileChangeSchedule to remove</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteChangeScheduleAsync (int? id, int? scheduleId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteChangeScheduleAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsDeleteChangeScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/ChangeSchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteChangeScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteChangeScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a PartitionProfileCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the PartitionProfileCheckSchedule to remove</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteCheckScheduleAsync (int? id, int? scheduleId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteCheckScheduleAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsDeleteCheckScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/CheckSchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteCheckScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteCheckScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Marks a discovered account as deleted 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="serviceName">Name of a discovered account. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteDiscoveredServiceAsync (int? id, int? assetId, string serviceName)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteDiscoveredServiceAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsDeleteDiscoveredServiceAsync");
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling AssetPartitionsDeleteDiscoveredServiceAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredServices/{assetId}/{serviceName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteDiscoveredServiceAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteDiscoveredServiceAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Marks a discovered SSH key as deleted 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountId">Unique ID of an account</param>
        /// <param name="fingerprint">MD5 fingerprint of the SSH key</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteDiscoveredSshKeyAsync (int? id, int? assetId, int? accountId, string fingerprint)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteDiscoveredSshKeyAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsDeleteDiscoveredSshKeyAsync");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling AssetPartitionsDeleteDiscoveredSshKeyAsync");
            // verify the required parameter 'fingerprint' is set
            if (fingerprint == null) throw new ApiException(400, "Missing required parameter 'fingerprint' when calling AssetPartitionsDeleteDiscoveredSshKeyAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredSshKeys/{assetId}/{accountId}/{fingerprint}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
path = path.Replace("{" + "fingerprint" + "}", ApiClient.ParameterToString(fingerprint));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteDiscoveredSshKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteDiscoveredSshKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes an asset discovery job 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="jobId">Unique identifier of the AssetDiscoveryJob</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteDiscoveryJobAsync (int? id, int? jobId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteDiscoveryJobAsync");
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling AssetPartitionsDeleteDiscoveryJobAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveryJobs/{jobId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "jobId" + "}", ApiClient.ParameterToString(jobId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteDiscoveryJobAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteDiscoveryJobAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Marks a discovered account as deleted 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountName">Name of a discovered account. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <returns></returns>
        public void AssetPartitionsDeletePartitionDiscoveredAccountAsync (int? id, int? assetId, string accountName)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeletePartitionDiscoveredAccountAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsDeletePartitionDiscoveredAccountAsync");
            // verify the required parameter 'accountName' is set
            if (accountName == null) throw new ApiException(400, "Missing required parameter 'accountName' when calling AssetPartitionsDeletePartitionDiscoveredAccountAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredAccounts/{assetId}/{accountName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
path = path.Replace("{" + "accountName" + "}", ApiClient.ParameterToString(accountName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeletePartitionDiscoveredAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeletePartitionDiscoveredAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Marks all partition discovered accounts as deleted 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <returns></returns>
        public void AssetPartitionsDeletePartitionDiscoveredAccountsAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeletePartitionDiscoveredAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredAccounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeletePartitionDiscoveredAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeletePartitionDiscoveredAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes all services discovered for a specific partition 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <returns></returns>
        public void AssetPartitionsDeletePartitionDiscoveredServicesAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeletePartitionDiscoveredServicesAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredServices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeletePartitionDiscoveredServicesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeletePartitionDiscoveredServicesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes all SSH keys discovered for a specific partition 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <returns></returns>
        public void AssetPartitionsDeletePartitionDiscoveredSshKeysAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeletePartitionDiscoveredSshKeysAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredSshKeys";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeletePartitionDiscoveredSshKeysAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeletePartitionDiscoveredSshKeysAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a password rule 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="ruleId">Unique identifier of the PartitionAccountPasswordRule to remove</param>
        /// <returns></returns>
        public void AssetPartitionsDeletePasswordRuleAsync (int? id, int? ruleId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeletePasswordRuleAsync");
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling AssetPartitionsDeletePasswordRuleAsync");
    
            var path = "/v4/AssetPartitions/{id}/PasswordRules/{ruleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "ruleId" + "}", ApiClient.ParameterToString(ruleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeletePasswordRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeletePasswordRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes an application asset configuration profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteProfileAsync (int? id, int? profileId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteProfileAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsDeleteProfileAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteProfileAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteProfileAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a SshKeyChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the SshKeyChangeSchedule to remove</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteSshKeyChangeScheduleAsync (int? id, int? scheduleId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteSshKeyChangeScheduleAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsDeleteSshKeyChangeScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyChangeSchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteSshKeyChangeScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteSshKeyChangeScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a SshKeyCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the SshKeyCheckSchedule to remove</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteSshKeyCheckScheduleAsync (int? id, int? scheduleId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteSshKeyCheckScheduleAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsDeleteSshKeyCheckScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyCheckSchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteSshKeyCheckScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteSshKeyCheckScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a SshKeyDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the SshKeyDiscoverySchedule to remove</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteSshKeyDiscoveryScheduleAsync (int? id, int? scheduleId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteSshKeyDiscoveryScheduleAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsDeleteSshKeyDiscoveryScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyDiscoverySchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteSshKeyDiscoveryScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteSshKeyDiscoveryScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes an application asset configuration SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteSshKeyProfileAsync (int? id, int? profileId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteSshKeyProfileAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsDeleteSshKeyProfileAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteSshKeyProfileAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteSshKeyProfileAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteSshKeySyncGroupAsync (int? id, int? profileId, int? syncGroupId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteSshKeySyncGroupAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsDeleteSshKeySyncGroupAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsDeleteSshKeySyncGroupAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/SshKeySyncGroups/{syncGroupId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteSshKeySyncGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteSshKeySyncGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteSyncGroupAsync (int? id, int? profileId, int? syncGroupId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteSyncGroupAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsDeleteSyncGroupAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsDeleteSyncGroupAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/SyncGroups/{syncGroupId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteSyncGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteSyncGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a partition tag 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="tagId">Unique identifier of the tag</param>
        /// <param name="forceDelete">Include &#x27;X-Force-Delete&#x27; HTTP header or this query string parameter set to true to force delete despite dependencies when given 50104  error</param>
        /// <returns></returns>
        public void AssetPartitionsDeleteTagAsync (int? id, int? tagId, bool? forceDelete)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDeleteTagAsync");
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling AssetPartitionsDeleteTagAsync");
    
            var path = "/v4/AssetPartitions/{id}/Tags/{tagId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "tagId" + "}", ApiClient.ParameterToString(tagId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteTagAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDeleteTagAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Disables an existing profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <returns>SshKeySyncGroup</returns>
        public SshKeySyncGroup AssetPartitionsDisableSshKeySyncGroupAsync (int? id, int? profileId, int? syncGroupId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDisableSshKeySyncGroupAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsDisableSshKeySyncGroupAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsDisableSshKeySyncGroupAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/SshKeySyncGroups/{syncGroupId}/Disable";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDisableSshKeySyncGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDisableSshKeySyncGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeySyncGroup) ApiClient.Deserialize(response.Content, typeof(SshKeySyncGroup), response.Headers);
        }
    
        /// <summary>
        /// Disables an existing profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <returns>PasswordSyncGroup</returns>
        public PasswordSyncGroup AssetPartitionsDisableSyncGroupAsync (int? id, int? profileId, int? syncGroupId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsDisableSyncGroupAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsDisableSyncGroupAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsDisableSyncGroupAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/SyncGroups/{syncGroupId}/Disable";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDisableSyncGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsDisableSyncGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordSyncGroup) ApiClient.Deserialize(response.Content, typeof(PasswordSyncGroup), response.Headers);
        }
    
        /// <summary>
        /// Enables an existing profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <returns>SshKeySyncGroup</returns>
        public SshKeySyncGroup AssetPartitionsEnableSshKeySyncGroupAsync (int? id, int? profileId, int? syncGroupId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsEnableSshKeySyncGroupAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsEnableSshKeySyncGroupAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsEnableSshKeySyncGroupAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/SshKeySyncGroups/{syncGroupId}/Enable";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsEnableSshKeySyncGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsEnableSshKeySyncGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeySyncGroup) ApiClient.Deserialize(response.Content, typeof(SshKeySyncGroup), response.Headers);
        }
    
        /// <summary>
        /// Enables an existing profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <returns>PasswordSyncGroup</returns>
        public PasswordSyncGroup AssetPartitionsEnableSyncGroupAsync (int? id, int? profileId, int? syncGroupId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsEnableSyncGroupAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsEnableSyncGroupAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsEnableSyncGroupAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/SyncGroups/{syncGroupId}/Enable";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsEnableSyncGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsEnableSyncGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordSyncGroup) ApiClient.Deserialize(response.Content, typeof(PasswordSyncGroup), response.Headers);
        }
    
        /// <summary>
        /// Generates a random password using this rule 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>string</returns>
        public string AssetPartitionsGeneratePasswordFromCustomRuleAsync (AccountPasswordRule body)
        {
    
            var path = "/v4/AssetPartitions/PasswordRules/GeneratePassword";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGeneratePasswordFromCustomRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGeneratePasswordFromCustomRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Generates a random password using this rule 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="ruleId">Unique identifier of the PartitionAccountPasswordRule to generate password from</param>
        /// <returns>string</returns>
        public string AssetPartitionsGeneratePasswordFromRuleAsync (int? id, int? ruleId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGeneratePasswordFromRuleAsync");
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling AssetPartitionsGeneratePasswordFromRuleAsync");
    
            var path = "/v4/AssetPartitions/{id}/PasswordRules/{ruleId}/GeneratePassword";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "ruleId" + "}", ApiClient.ParameterToString(ruleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGeneratePasswordFromRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGeneratePasswordFromRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Gets assets that the specified schedule is assigned to 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Asset&gt;</returns>
        public List<Asset> AssetPartitionsGetAccountDiscoveryAssetsAsync (int? id, int? scheduleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetAccountDiscoveryAssetsAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsGetAccountDiscoveryAssetsAsync");
    
            var path = "/v4/AssetPartitions/{id}/AccountDiscoverySchedules/{scheduleId}/Assets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAccountDiscoveryAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAccountDiscoveryAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Asset>) ApiClient.Deserialize(response.Content, typeof(List<Asset>), response.Headers);
        }
    
        /// <summary>
        /// Gets account discovery rules from an existing profile schedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountDiscoveryRule&gt;</returns>
        public List<AccountDiscoveryRule> AssetPartitionsGetAccountDiscoveryRulesAsync (int? id, int? scheduleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetAccountDiscoveryRulesAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsGetAccountDiscoveryRulesAsync");
    
            var path = "/v4/AssetPartitions/{id}/AccountDiscoverySchedules/{scheduleId}/Rules";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAccountDiscoveryRulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAccountDiscoveryRulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountDiscoveryRule>) ApiClient.Deserialize(response.Content, typeof(List<AccountDiscoveryRule>), response.Headers);
        }
    
        /// <summary>
        /// Gets a PartitionProfileAccountDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of PartitionProfileAccountDiscoverySchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccountDiscoverySchedule</returns>
        public AccountDiscoverySchedule AssetPartitionsGetAccountDiscoveryScheduleByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetAccountDiscoveryScheduleByIdAsync");
    
            var path = "/v4/AssetPartitions/AccountDiscoverySchedules/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAccountDiscoveryScheduleByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAccountDiscoveryScheduleByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountDiscoverySchedule) ApiClient.Deserialize(response.Content, typeof(AccountDiscoverySchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of PartitionProfileAccountDiscoverySchedules 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountDiscoverySchedule&gt;</returns>
        public List<AccountDiscoverySchedule> AssetPartitionsGetAllAccountDiscoveryAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/AccountDiscoverySchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllAccountDiscoveryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllAccountDiscoveryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountDiscoverySchedule>) ApiClient.Deserialize(response.Content, typeof(List<AccountDiscoverySchedule>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of partition change schedules across all partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordChangeSchedule&gt;</returns>
        public List<PasswordChangeSchedule> AssetPartitionsGetAllChangeSchedulesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/ChangeSchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllChangeSchedulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllChangeSchedulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PasswordChangeSchedule>) ApiClient.Deserialize(response.Content, typeof(List<PasswordChangeSchedule>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of partition password check schedules 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordCheckSchedule&gt;</returns>
        public List<PasswordCheckSchedule> AssetPartitionsGetAllCheckSchedulesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/CheckSchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllCheckSchedulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllCheckSchedulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PasswordCheckSchedule>) ApiClient.Deserialize(response.Content, typeof(List<PasswordCheckSchedule>), response.Headers);
        }
    
        /// <summary>
        /// Gets all asset partition&#x27;s discovered accounts 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredAssetAccount&gt;</returns>
        public List<DiscoveredAssetAccount> AssetPartitionsGetAllDiscoveredAccountsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/DiscoveredAccounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllDiscoveredAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllDiscoveredAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredAssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredAssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets all asset partition&#x27;s discovered services 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredService&gt;</returns>
        public List<DiscoveredService> AssetPartitionsGetAllDiscoveredServicesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/DiscoveredServices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllDiscoveredServicesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllDiscoveredServicesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredService>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredService>), response.Headers);
        }
    
        /// <summary>
        /// Gets the discovered SSH keys for all asset partitions 
        /// </summary>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredSshKey&gt;</returns>
        public List<DiscoveredSshKey> AssetPartitionsGetAllDiscoveredSshKeysAsync (SshKeyFormat keyFormat, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/DiscoveredSshKeys";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllDiscoveredSshKeysAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllDiscoveredSshKeysAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredSshKey>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredSshKey>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of asset discovery jobs 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetDiscoveryJob&gt;</returns>
        public List<AssetDiscoveryJob> AssetPartitionsGetAllDiscoveryJobsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/DiscoveryJobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllDiscoveryJobsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllDiscoveryJobsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetDiscoveryJob>) ApiClient.Deserialize(response.Content, typeof(List<AssetDiscoveryJob>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of password rules across all partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountPasswordRule&gt;</returns>
        public List<AccountPasswordRule> AssetPartitionsGetAllPasswordRulesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/PasswordRules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllPasswordRulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllPasswordRulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountPasswordRule>) ApiClient.Deserialize(response.Content, typeof(List<AccountPasswordRule>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of profiles 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordProfile&gt;</returns>
        public List<PasswordProfile> AssetPartitionsGetAllProfilesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/Profiles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllProfilesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllProfilesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PasswordProfile>) ApiClient.Deserialize(response.Content, typeof(List<PasswordProfile>), response.Headers);
        }
    
        /// <summary>
        /// Gets a summary of all profiles schedules across all partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AllProfileSchedulesSummary&gt;</returns>
        public List<AllProfileSchedulesSummary> AssetPartitionsGetAllScheduleSummariesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/ScheduleSummaries";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllScheduleSummariesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllScheduleSummariesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AllProfileSchedulesSummary>) ApiClient.Deserialize(response.Content, typeof(List<AllProfileSchedulesSummary>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of partition change schedules across all partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyChangeSchedule&gt;</returns>
        public List<SshKeyChangeSchedule> AssetPartitionsGetAllSshKeyChangeSchedulesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/SshKeyChangeSchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSshKeyChangeSchedulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSshKeyChangeSchedulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SshKeyChangeSchedule>) ApiClient.Deserialize(response.Content, typeof(List<SshKeyChangeSchedule>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of partition SSH key check schedules 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyCheckSchedule&gt;</returns>
        public List<SshKeyCheckSchedule> AssetPartitionsGetAllSshKeyCheckSchedulesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/SshKeyCheckSchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSshKeyCheckSchedulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSshKeyCheckSchedulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SshKeyCheckSchedule>) ApiClient.Deserialize(response.Content, typeof(List<SshKeyCheckSchedule>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of partition Discovery schedules across all partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyDiscoverySchedule&gt;</returns>
        public List<SshKeyDiscoverySchedule> AssetPartitionsGetAllSshKeyDiscoverySchedulesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/SshKeyDiscoverySchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSshKeyDiscoverySchedulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSshKeyDiscoverySchedulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SshKeyDiscoverySchedule>) ApiClient.Deserialize(response.Content, typeof(List<SshKeyDiscoverySchedule>), response.Headers);
        }
    
        /// <summary>
        /// Gets an SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of SshKeyProfile</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyProfile</returns>
        public SshKeyProfile AssetPartitionsGetAllSshKeyProfileByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetAllSshKeyProfileByIdAsync");
    
            var path = "/v4/AssetPartitions/SshKeyProfiles/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSshKeyProfileByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSshKeyProfileByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyProfile) ApiClient.Deserialize(response.Content, typeof(SshKeyProfile), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of SSH key profiles across all partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyProfile&gt;</returns>
        public List<SshKeyProfile> AssetPartitionsGetAllSshKeyProfilesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/SshKeyProfiles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSshKeyProfilesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSshKeyProfilesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SshKeyProfile>) ApiClient.Deserialize(response.Content, typeof(List<SshKeyProfile>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of all SSH key sync groups 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeySyncGroup&gt;</returns>
        public List<SshKeySyncGroup> AssetPartitionsGetAllSshKeySyncGroupsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/SshKeySyncGroups";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSshKeySyncGroupsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSshKeySyncGroupsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SshKeySyncGroup>) ApiClient.Deserialize(response.Content, typeof(List<SshKeySyncGroup>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific SSH key sync group 
        /// </summary>
        /// <param name="id">Unique ID of the SSH key sync group</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeySyncGroup</returns>
        public SshKeySyncGroup AssetPartitionsGetAllSshKeySyncGroupsByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetAllSshKeySyncGroupsByIdAsync");
    
            var path = "/v4/AssetPartitions/SshKeySyncGroups/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSshKeySyncGroupsByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSshKeySyncGroupsByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeySyncGroup) ApiClient.Deserialize(response.Content, typeof(SshKeySyncGroup), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of all partition sync groups 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordSyncGroup&gt;</returns>
        public List<PasswordSyncGroup> AssetPartitionsGetAllSyncGroupsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/SyncGroups";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSyncGroupsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllSyncGroupsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PasswordSyncGroup>) ApiClient.Deserialize(response.Content, typeof(List<PasswordSyncGroup>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of partition tags across partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, in, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PartitionTag&gt;</returns>
        public List<PartitionTag> AssetPartitionsGetAllTagsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions/Tags";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllTagsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAllTagsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PartitionTag>) ApiClient.Deserialize(response.Content, typeof(List<PartitionTag>), response.Headers);
        }
    
        /// <summary>
        /// Gets all accounts belonging to assets assigned to this partition 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetPartition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetPartitionsGetAssetAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetAssetAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/Accounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAssetAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAssetAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single AssetPartition entity 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AssetPartition</returns>
        public AssetPartition AssetPartitionsGetAssetPartitionByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetAssetPartitionByIdAsync");
    
            var path = "/v4/AssetPartitions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAssetPartitionByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAssetPartitionByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetPartition) ApiClient.Deserialize(response.Content, typeof(AssetPartition), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of asset partitions 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetPartition&gt;</returns>
        public List<AssetPartition> AssetPartitionsGetAssetPartitionsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AssetPartitions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAssetPartitionsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAssetPartitionsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetPartition>) ApiClient.Deserialize(response.Content, typeof(List<AssetPartition>), response.Headers);
        }
    
        /// <summary>
        /// Gets all assets that belong to the specified partition 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to get tasks for</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Asset&gt;</returns>
        public List<Asset> AssetPartitionsGetAssetsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetAssetsAsync");
    
            var path = "/v4/AssetPartitions/{id}/Assets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Asset>) ApiClient.Deserialize(response.Content, typeof(List<Asset>), response.Headers);
        }
    
        /// <summary>
        /// Gets accounts that the specified schedule is assigned to 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetPartitionsGetChangeScheduleAccountsAsync (int? id, int? scheduleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetChangeScheduleAccountsAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsGetChangeScheduleAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/ChangeSchedules/{scheduleId}/Accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetChangeScheduleAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetChangeScheduleAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single PartitionProfileChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of a PartitionProfileChangeSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordChangeSchedule</returns>
        public PasswordChangeSchedule AssetPartitionsGetChangeScheduleByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetChangeScheduleByIdAsync");
    
            var path = "/v4/AssetPartitions/ChangeSchedules/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetChangeScheduleByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetChangeScheduleByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordChangeSchedule) ApiClient.Deserialize(response.Content, typeof(PasswordChangeSchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets accounts that the specified schedule is assigned to 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetPartitionsGetCheckScheduleAccountsAsync (int? id, int? scheduleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetCheckScheduleAccountsAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsGetCheckScheduleAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/CheckSchedules/{scheduleId}/Accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetCheckScheduleAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetCheckScheduleAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single PartitionProfileCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of a PartitionProfileCheckSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordCheckSchedule</returns>
        public PasswordCheckSchedule AssetPartitionsGetCheckScheduleByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetCheckScheduleByIdAsync");
    
            var path = "/v4/AssetPartitions/CheckSchedules/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetCheckScheduleByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetCheckScheduleByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordCheckSchedule) ApiClient.Deserialize(response.Content, typeof(PasswordCheckSchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets an asset partition&#x27;s discovered services 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredService&gt;</returns>
        public List<DiscoveredService> AssetPartitionsGetDiscoveredServicesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetDiscoveredServicesAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredServices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveredServicesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveredServicesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredService>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredService>), response.Headers);
        }
    
        /// <summary>
        /// Gets an asset&#x27;s discovered services 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredService&gt;</returns>
        public List<DiscoveredService> AssetPartitionsGetDiscoveredServicesByAssetAsync (int? id, int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetDiscoveredServicesByAssetAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsGetDiscoveredServicesByAssetAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredServices/{assetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveredServicesByAssetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveredServicesByAssetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredService>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredService>), response.Headers);
        }
    
        /// <summary>
        /// Gets an asset&#x27;s discovered services 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="serviceName">Name of a discovered service. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <returns>List&lt;DiscoveredService&gt;</returns>
        public List<DiscoveredService> AssetPartitionsGetDiscoveredServicesByServiceNameAsync (int? id, int? assetId, string serviceName, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetDiscoveredServicesByServiceNameAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsGetDiscoveredServicesByServiceNameAsync");
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling AssetPartitionsGetDiscoveredServicesByServiceNameAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredServices/{assetId}/{serviceName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveredServicesByServiceNameAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveredServicesByServiceNameAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredService>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredService>), response.Headers);
        }
    
        /// <summary>
        /// Gets an discovered SSH key 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountId">Unique ID of an account</param>
        /// <param name="fingerprint">MD5 fingerprint of SSH Key</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <returns>DiscoveredSshKey</returns>
        public DiscoveredSshKey AssetPartitionsGetDiscoveredSshKeyByFingerprintAsync (int? id, int? assetId, int? accountId, string fingerprint, SshKeyFormat keyFormat, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetDiscoveredSshKeyByFingerprintAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsGetDiscoveredSshKeyByFingerprintAsync");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling AssetPartitionsGetDiscoveredSshKeyByFingerprintAsync");
            // verify the required parameter 'fingerprint' is set
            if (fingerprint == null) throw new ApiException(400, "Missing required parameter 'fingerprint' when calling AssetPartitionsGetDiscoveredSshKeyByFingerprintAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredSshKeys/{assetId}/{accountId}/{fingerprint}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
path = path.Replace("{" + "fingerprint" + "}", ApiClient.ParameterToString(fingerprint));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (keyFormat != null) queryParams.Add("keyFormat", ApiClient.ParameterToString(keyFormat)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveredSshKeyByFingerprintAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveredSshKeyByFingerprintAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DiscoveredSshKey) ApiClient.Deserialize(response.Content, typeof(DiscoveredSshKey), response.Headers);
        }
    
        /// <summary>
        /// Gets the discovered SSH keys for an asset partition 
        /// </summary>
        /// <param name="id">Unique ID of the asset</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredSshKey&gt;</returns>
        public List<DiscoveredSshKey> AssetPartitionsGetDiscoveredSshKeysAsync (int? id, SshKeyFormat keyFormat, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetDiscoveredSshKeysAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredSshKeys";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveredSshKeysAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveredSshKeysAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredSshKey>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredSshKey>), response.Headers);
        }
    
        /// <summary>
        /// Gets discovered SSH keys for an account 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountId">Unique ID of an account</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredSshKey&gt;</returns>
        public List<DiscoveredSshKey> AssetPartitionsGetDiscoveredSshKeysByAccountAsync (int? id, int? assetId, int? accountId, SshKeyFormat keyFormat, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetDiscoveredSshKeysByAccountAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsGetDiscoveredSshKeysByAccountAsync");
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling AssetPartitionsGetDiscoveredSshKeysByAccountAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredSshKeys/{assetId}/{accountId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveredSshKeysByAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveredSshKeysByAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredSshKey>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredSshKey>), response.Headers);
        }
    
        /// <summary>
        /// Gets discovered SSH keys for an asset 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredSshKey&gt;</returns>
        public List<DiscoveredSshKey> AssetPartitionsGetDiscoveredSshKeysByAssetAsync (int? id, int? assetId, SshKeyFormat keyFormat, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetDiscoveredSshKeysByAssetAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsGetDiscoveredSshKeysByAssetAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredSshKeys/{assetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveredSshKeysByAssetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveredSshKeysByAssetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredSshKey>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredSshKey>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific asset discovery job 
        /// </summary>
        /// <param name="id">Unique ID of the asset discovery job</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AssetDiscoveryJob</returns>
        public AssetDiscoveryJob AssetPartitionsGetDiscoveryJobByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetDiscoveryJobByIdAsync");
    
            var path = "/v4/AssetPartitions/DiscoveryJobs/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveryJobByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveryJobByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetDiscoveryJob) ApiClient.Deserialize(response.Content, typeof(AssetDiscoveryJob), response.Headers);
        }
    
        /// <summary>
        /// Gets all rules that belong to an asset discovery rule 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="jobId">Unique identifier of the AssetDiscoveryJob</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetDiscoveryRule&gt;</returns>
        public List<AssetDiscoveryRule> AssetPartitionsGetDiscoveryJobRulesAsync (int? id, int? jobId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetDiscoveryJobRulesAsync");
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling AssetPartitionsGetDiscoveryJobRulesAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveryJobs/{jobId}/Rules";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "jobId" + "}", ApiClient.ParameterToString(jobId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveryJobRulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetDiscoveryJobRulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetDiscoveryRule>) ApiClient.Deserialize(response.Content, typeof(List<AssetDiscoveryRule>), response.Headers);
        }
    
        /// <summary>
        /// Gets the tagged objects 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="tagId">Unique ID of the tag</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, in, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ObjectWithTag&gt;</returns>
        public List<ObjectWithTag> AssetPartitionsGetObjectsWithTagAsync (int? id, int? tagId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetObjectsWithTagAsync");
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling AssetPartitionsGetObjectsWithTagAsync");
    
            var path = "/v4/AssetPartitions/{id}/Tags/{tagId}/Occurrences";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "tagId" + "}", ApiClient.ParameterToString(tagId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetObjectsWithTagAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetObjectsWithTagAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ObjectWithTag>) ApiClient.Deserialize(response.Content, typeof(List<ObjectWithTag>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of PartitionProfileAccountDiscoverySchedules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountDiscoverySchedule&gt;</returns>
        public List<AccountDiscoverySchedule> AssetPartitionsGetPartitionAccountDiscoveryAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionAccountDiscoveryAsync");
    
            var path = "/v4/AssetPartitions/{id}/AccountDiscoverySchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionAccountDiscoveryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionAccountDiscoveryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountDiscoverySchedule>) ApiClient.Deserialize(response.Content, typeof(List<AccountDiscoverySchedule>), response.Headers);
        }
    
        /// <summary>
        /// Gets a PartitionProfileAccountDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique ID of PartitionProfileAccountDiscoverySchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccountDiscoverySchedule</returns>
        public AccountDiscoverySchedule AssetPartitionsGetPartitionAccountDiscoveryScheduleByIdAsync (int? id, int? scheduleId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionAccountDiscoveryScheduleByIdAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsGetPartitionAccountDiscoveryScheduleByIdAsync");
    
            var path = "/v4/AssetPartitions/{id}/AccountDiscoverySchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionAccountDiscoveryScheduleByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionAccountDiscoveryScheduleByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountDiscoverySchedule) ApiClient.Deserialize(response.Content, typeof(AccountDiscoverySchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets a single PartitionProfileChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique ID of a PartitionProfileChangeSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordChangeSchedule</returns>
        public PasswordChangeSchedule AssetPartitionsGetPartitionChangeScheduleByIdAsync (int? id, int? scheduleId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionChangeScheduleByIdAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsGetPartitionChangeScheduleByIdAsync");
    
            var path = "/v4/AssetPartitions/{id}/ChangeSchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionChangeScheduleByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionChangeScheduleByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordChangeSchedule) ApiClient.Deserialize(response.Content, typeof(PasswordChangeSchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of partition change schedules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordChangeSchedule&gt;</returns>
        public List<PasswordChangeSchedule> AssetPartitionsGetPartitionChangeSchedulesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionChangeSchedulesAsync");
    
            var path = "/v4/AssetPartitions/{id}/ChangeSchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionChangeSchedulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionChangeSchedulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PasswordChangeSchedule>) ApiClient.Deserialize(response.Content, typeof(List<PasswordChangeSchedule>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single PartitionProfileCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique ID of a PartitionProfileCheckSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordCheckSchedule</returns>
        public PasswordCheckSchedule AssetPartitionsGetPartitionCheckScheduleByIdAsync (int? id, int? scheduleId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionCheckScheduleByIdAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsGetPartitionCheckScheduleByIdAsync");
    
            var path = "/v4/AssetPartitions/{id}/CheckSchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionCheckScheduleByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionCheckScheduleByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordCheckSchedule) ApiClient.Deserialize(response.Content, typeof(PasswordCheckSchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of partition password check schedules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordCheckSchedule&gt;</returns>
        public List<PasswordCheckSchedule> AssetPartitionsGetPartitionCheckSchedulesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionCheckSchedulesAsync");
    
            var path = "/v4/AssetPartitions/{id}/CheckSchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionCheckSchedulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionCheckSchedulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PasswordCheckSchedule>) ApiClient.Deserialize(response.Content, typeof(List<PasswordCheckSchedule>), response.Headers);
        }
    
        /// <summary>
        /// Gets a discovered account 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountName">Name of a discovered account. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>DiscoveredAssetAccount</returns>
        public DiscoveredAssetAccount AssetPartitionsGetPartitionDiscoveredAccountAsync (int? id, int? assetId, string accountName, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionDiscoveredAccountAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsGetPartitionDiscoveredAccountAsync");
            // verify the required parameter 'accountName' is set
            if (accountName == null) throw new ApiException(400, "Missing required parameter 'accountName' when calling AssetPartitionsGetPartitionDiscoveredAccountAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredAccounts/{assetId}/{accountName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionDiscoveredAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionDiscoveredAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DiscoveredAssetAccount) ApiClient.Deserialize(response.Content, typeof(DiscoveredAssetAccount), response.Headers);
        }
    
        /// <summary>
        /// Gets an asset partition&#x27;s discovered accounts 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredAssetAccount&gt;</returns>
        public List<DiscoveredAssetAccount> AssetPartitionsGetPartitionDiscoveredAccountsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionDiscoveredAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredAccounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionDiscoveredAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionDiscoveredAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredAssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredAssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets an asset&#x27;s discovered accounts 
        /// </summary>
        /// <param name="id">Unique ID of a Partition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredAssetAccount&gt;</returns>
        public List<DiscoveredAssetAccount> AssetPartitionsGetPartitionDiscoveredAccountsByAssetAsync (int? id, int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionDiscoveredAccountsByAssetAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsGetPartitionDiscoveredAccountsByAssetAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredAccounts/{assetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionDiscoveredAccountsByAssetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionDiscoveredAccountsByAssetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredAssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredAssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific asset discovery job 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="jobId">Unique ID of the asset discovery job</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AssetDiscoveryJob</returns>
        public AssetDiscoveryJob AssetPartitionsGetPartitionDiscoveryJobAsync (int? id, int? jobId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionDiscoveryJobAsync");
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling AssetPartitionsGetPartitionDiscoveryJobAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveryJobs/{jobId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "jobId" + "}", ApiClient.ParameterToString(jobId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionDiscoveryJobAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionDiscoveryJobAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetDiscoveryJob) ApiClient.Deserialize(response.Content, typeof(AssetDiscoveryJob), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of asset discovery jobs 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetDiscoveryJob&gt;</returns>
        public List<AssetDiscoveryJob> AssetPartitionsGetPartitionDiscoveryJobsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionDiscoveryJobsAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveryJobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionDiscoveryJobsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionDiscoveryJobsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetDiscoveryJob>) ApiClient.Deserialize(response.Content, typeof(List<AssetDiscoveryJob>), response.Headers);
        }
    
        /// <summary>
        /// Gets all owners of the specified partition 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetAccount to get tasks for</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> AssetPartitionsGetPartitionManagedByAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionManagedByAsync");
    
            var path = "/v4/AssetPartitions/{id}/ManagedBy";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionManagedByAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionManagedByAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Gets a profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of PartitionProfile</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordProfile</returns>
        public PasswordProfile AssetPartitionsGetPartitionProfileByIdAsync (int? id, int? profileId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionProfileByIdAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetPartitionProfileByIdAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionProfileByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionProfileByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordProfile) ApiClient.Deserialize(response.Content, typeof(PasswordProfile), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of profiles for a specific partition 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordProfile&gt;</returns>
        public List<PasswordProfile> AssetPartitionsGetPartitionProfilesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionProfilesAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionProfilesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionProfilesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PasswordProfile>) ApiClient.Deserialize(response.Content, typeof(List<PasswordProfile>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single SshKeyChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique ID of a SshKeyChangeSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyChangeSchedule</returns>
        public SshKeyChangeSchedule AssetPartitionsGetPartitionSshKeyChangeScheduleByIdAsync (int? id, int? scheduleId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionSshKeyChangeScheduleByIdAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsGetPartitionSshKeyChangeScheduleByIdAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyChangeSchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionSshKeyChangeScheduleByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionSshKeyChangeScheduleByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyChangeSchedule) ApiClient.Deserialize(response.Content, typeof(SshKeyChangeSchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of partition change schedules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyChangeSchedule&gt;</returns>
        public List<SshKeyChangeSchedule> AssetPartitionsGetPartitionSshKeyChangeSchedulesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionSshKeyChangeSchedulesAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyChangeSchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionSshKeyChangeSchedulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionSshKeyChangeSchedulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SshKeyChangeSchedule>) ApiClient.Deserialize(response.Content, typeof(List<SshKeyChangeSchedule>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single SshKeyCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique ID of a SshKeyCheckSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyCheckSchedule</returns>
        public SshKeyCheckSchedule AssetPartitionsGetPartitionSshKeyCheckScheduleByIdAsync (int? id, int? scheduleId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionSshKeyCheckScheduleByIdAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsGetPartitionSshKeyCheckScheduleByIdAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyCheckSchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionSshKeyCheckScheduleByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionSshKeyCheckScheduleByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyCheckSchedule) ApiClient.Deserialize(response.Content, typeof(SshKeyCheckSchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets a single SshKeyDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique ID of a SshKeyDiscoverySchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyDiscoverySchedule</returns>
        public SshKeyDiscoverySchedule AssetPartitionsGetPartitionSshKeyDiscoveryScheduleByIdAsync (int? id, int? scheduleId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionSshKeyDiscoveryScheduleByIdAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsGetPartitionSshKeyDiscoveryScheduleByIdAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyDiscoverySchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionSshKeyDiscoveryScheduleByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionSshKeyDiscoveryScheduleByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyDiscoverySchedule) ApiClient.Deserialize(response.Content, typeof(SshKeyDiscoverySchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of partition Discovery schedules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyDiscoverySchedule&gt;</returns>
        public List<SshKeyDiscoverySchedule> AssetPartitionsGetPartitionSshKeyDiscoverySchedulesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionSshKeyDiscoverySchedulesAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyDiscoverySchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionSshKeyDiscoverySchedulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionSshKeyDiscoverySchedulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SshKeyDiscoverySchedule>) ApiClient.Deserialize(response.Content, typeof(List<SshKeyDiscoverySchedule>), response.Headers);
        }
    
        /// <summary>
        /// Gets a partition tag 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="tagId">Unique ID of the tag</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PartitionTag</returns>
        public PartitionTag AssetPartitionsGetPartitionTagByIdAsync (int? id, int? tagId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionTagByIdAsync");
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling AssetPartitionsGetPartitionTagByIdAsync");
    
            var path = "/v4/AssetPartitions/{id}/Tags/{tagId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "tagId" + "}", ApiClient.ParameterToString(tagId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionTagByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionTagByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PartitionTag) ApiClient.Deserialize(response.Content, typeof(PartitionTag), response.Headers);
        }
    
        /// <summary>
        /// Gets a partition tag managed by 
        /// </summary>
        /// <param name="id">Unique ID of the tag</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> AssetPartitionsGetPartitionTagManagedByAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionTagManagedByAsync");
    
            var path = "/v4/AssetPartitions/Tags/{id}/ManagedBy";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionTagManagedByAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionTagManagedByAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of partition tags 
        /// </summary>
        /// <param name="id">Unique ID of partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, in, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PartitionTag&gt;</returns>
        public List<PartitionTag> AssetPartitionsGetPartitionTagsAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPartitionTagsAsync");
    
            var path = "/v4/AssetPartitions/{id}/Tags";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionTagsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPartitionTagsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PartitionTag>) ApiClient.Deserialize(response.Content, typeof(List<PartitionTag>), response.Headers);
        }
    
        /// <summary>
        /// Gets accounts that the specified rule is assigned to 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="ruleId">Unique identifier of the password rule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetPartitionsGetPasswordRuleAccountsAsync (int? id, int? ruleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPasswordRuleAccountsAsync");
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling AssetPartitionsGetPasswordRuleAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/PasswordRules/{ruleId}/Accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "ruleId" + "}", ApiClient.ParameterToString(ruleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPasswordRuleAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPasswordRuleAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific password rule 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="ruleId">Unique ID of a PasswordRule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccountPasswordRule</returns>
        public AccountPasswordRule AssetPartitionsGetPasswordRuleAsync (int? id, int? ruleId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPasswordRuleAsync");
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling AssetPartitionsGetPasswordRuleAsync");
    
            var path = "/v4/AssetPartitions/{id}/PasswordRules/{ruleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "ruleId" + "}", ApiClient.ParameterToString(ruleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPasswordRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPasswordRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountPasswordRule) ApiClient.Deserialize(response.Content, typeof(AccountPasswordRule), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific password rule 
        /// </summary>
        /// <param name="ruleId">Unique ID of a PasswordRule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>AccountPasswordRule</returns>
        public AccountPasswordRule AssetPartitionsGetPasswordRuleByIdAsync (int? ruleId, string fields)
        {
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling AssetPartitionsGetPasswordRuleByIdAsync");
    
            var path = "/v4/AssetPartitions/PasswordRules/{ruleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ruleId" + "}", ApiClient.ParameterToString(ruleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPasswordRuleByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPasswordRuleByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountPasswordRule) ApiClient.Deserialize(response.Content, typeof(AccountPasswordRule), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of password rules 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountPasswordRule&gt;</returns>
        public List<AccountPasswordRule> AssetPartitionsGetPasswordRulesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetPasswordRulesAsync");
    
            var path = "/v4/AssetPartitions/{id}/PasswordRules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPasswordRulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetPasswordRulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountPasswordRule>) ApiClient.Deserialize(response.Content, typeof(List<AccountPasswordRule>), response.Headers);
        }
    
        /// <summary>
        /// Gets the account password rule on the selected partition profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <returns>AccountPasswordRule</returns>
        public AccountPasswordRule AssetPartitionsGetProfileAccountPasswordRuleAsync (int? id, int? profileId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetProfileAccountPasswordRuleAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetProfileAccountPasswordRuleAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/PasswordRule";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileAccountPasswordRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileAccountPasswordRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountPasswordRule) ApiClient.Deserialize(response.Content, typeof(AccountPasswordRule), response.Headers);
        }
    
        /// <summary>
        /// Gets the accounts that are explicitly using this profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetPartitionsGetProfileAssetAccountsAsync (int? id, int? profileId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetProfileAssetAccountsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetProfileAssetAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/Accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileAssetAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileAssetAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets the Assets that are explicitly using this profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Asset&gt;</returns>
        public List<Asset> AssetPartitionsGetProfileAssetsAsync (int? id, int? profileId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetProfileAssetsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetProfileAssetsAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/Assets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Asset>) ApiClient.Deserialize(response.Content, typeof(List<Asset>), response.Headers);
        }
    
        /// <summary>
        /// Gets a profile 
        /// </summary>
        /// <param name="id">Unique ID of PartitionProfile</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordProfile</returns>
        public PasswordProfile AssetPartitionsGetProfileByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetProfileByIdAsync");
    
            var path = "/v4/AssetPartitions/Profiles/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordProfile) ApiClient.Deserialize(response.Content, typeof(PasswordProfile), response.Headers);
        }
    
        /// <summary>
        /// Gets the change schedule on the selected partition profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <returns>PasswordChangeSchedule</returns>
        public PasswordChangeSchedule AssetPartitionsGetProfileChangeScheduleAsync (int? id, int? profileId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetProfileChangeScheduleAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetProfileChangeScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/ChangeSchedule";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileChangeScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileChangeScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordChangeSchedule) ApiClient.Deserialize(response.Content, typeof(PasswordChangeSchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets the check schedule on the selected partition profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <returns>PasswordCheckSchedule</returns>
        public PasswordCheckSchedule AssetPartitionsGetProfileCheckScheduleAsync (int? id, int? profileId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetProfileCheckScheduleAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetProfileCheckScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/CheckSchedule";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileCheckScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileCheckScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordCheckSchedule) ApiClient.Deserialize(response.Content, typeof(PasswordCheckSchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordSyncGroup</returns>
        public PasswordSyncGroup AssetPartitionsGetProfileSyncGroupByIdAsync (int? id, int? profileId, int? syncGroupId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetProfileSyncGroupByIdAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetProfileSyncGroupByIdAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsGetProfileSyncGroupByIdAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/SyncGroups/{syncGroupId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileSyncGroupByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileSyncGroupByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordSyncGroup) ApiClient.Deserialize(response.Content, typeof(PasswordSyncGroup), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of sync groups for a specific profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordSyncGroup&gt;</returns>
        public List<PasswordSyncGroup> AssetPartitionsGetProfileSyncGroupsAsync (int? id, int? profileId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetProfileSyncGroupsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetProfileSyncGroupsAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/SyncGroups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileSyncGroupsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetProfileSyncGroupsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PasswordSyncGroup>) ApiClient.Deserialize(response.Content, typeof(List<PasswordSyncGroup>), response.Headers);
        }
    
        /// <summary>
        /// Gets accounts that the specified schedule is assigned to 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetPartitionsGetSshKeyChangeScheduleAccountsAsync (int? id, int? scheduleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeyChangeScheduleAccountsAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsGetSshKeyChangeScheduleAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyChangeSchedules/{scheduleId}/Accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyChangeScheduleAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyChangeScheduleAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets the change schedule on the selected partition profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <returns>SshKeyChangeSchedule</returns>
        public SshKeyChangeSchedule AssetPartitionsGetSshKeyChangeScheduleAsync (int? id, int? profileId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeyChangeScheduleAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetSshKeyChangeScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/ChangeSchedule";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyChangeScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyChangeScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyChangeSchedule) ApiClient.Deserialize(response.Content, typeof(SshKeyChangeSchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets a single SshKeyChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of a SshKeyChangeSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyChangeSchedule</returns>
        public SshKeyChangeSchedule AssetPartitionsGetSshKeyChangeScheduleByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeyChangeScheduleByIdAsync");
    
            var path = "/v4/AssetPartitions/SshKeyChangeSchedules/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyChangeScheduleByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyChangeScheduleByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyChangeSchedule) ApiClient.Deserialize(response.Content, typeof(SshKeyChangeSchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets accounts that the specified schedule is assigned to 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetPartitionsGetSshKeyCheckScheduleAccountsAsync (int? id, int? scheduleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeyCheckScheduleAccountsAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsGetSshKeyCheckScheduleAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyCheckSchedules/{scheduleId}/Accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyCheckScheduleAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyCheckScheduleAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets the check schedule on the selected partition profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <returns>SshKeyCheckSchedule</returns>
        public SshKeyCheckSchedule AssetPartitionsGetSshKeyCheckScheduleAsync (int? id, int? profileId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeyCheckScheduleAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetSshKeyCheckScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/CheckSchedule";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyCheckScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyCheckScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyCheckSchedule) ApiClient.Deserialize(response.Content, typeof(SshKeyCheckSchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets a single SshKeyCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of a SshKeyCheckSchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyCheckSchedule</returns>
        public SshKeyCheckSchedule AssetPartitionsGetSshKeyCheckScheduleByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeyCheckScheduleByIdAsync");
    
            var path = "/v4/AssetPartitions/SshKeyCheckSchedules/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyCheckScheduleByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyCheckScheduleByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyCheckSchedule) ApiClient.Deserialize(response.Content, typeof(SshKeyCheckSchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of partition SSH key check schedules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyCheckSchedule&gt;</returns>
        public List<SshKeyCheckSchedule> AssetPartitionsGetSshKeyCheckSchedulesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeyCheckSchedulesAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyCheckSchedules";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyCheckSchedulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyCheckSchedulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SshKeyCheckSchedule>) ApiClient.Deserialize(response.Content, typeof(List<SshKeyCheckSchedule>), response.Headers);
        }
    
        /// <summary>
        /// Gets accounts that the specified schedule is assigned to 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetPartitionsGetSshKeyDiscoveryScheduleAccountsAsync (int? id, int? scheduleId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeyDiscoveryScheduleAccountsAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsGetSshKeyDiscoveryScheduleAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyDiscoverySchedules/{scheduleId}/Accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyDiscoveryScheduleAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyDiscoveryScheduleAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets a single SshKeyDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of a SshKeyDiscoverySchedule</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyDiscoverySchedule</returns>
        public SshKeyDiscoverySchedule AssetPartitionsGetSshKeyDiscoveryScheduleByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeyDiscoveryScheduleByIdAsync");
    
            var path = "/v4/AssetPartitions/SshKeyDiscoverySchedules/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyDiscoveryScheduleByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyDiscoveryScheduleByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyDiscoverySchedule) ApiClient.Deserialize(response.Content, typeof(SshKeyDiscoverySchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets the accounts that are explicitly using this SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetPartitionsGetSshKeyProfileAssetAccountsAsync (int? id, int? profileId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeyProfileAssetAccountsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetSshKeyProfileAssetAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/Accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyProfileAssetAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyProfileAssetAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets the Assets that are explicitly using this SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Asset&gt;</returns>
        public List<Asset> AssetPartitionsGetSshKeyProfileAssetsAsync (int? id, int? profileId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeyProfileAssetsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetSshKeyProfileAssetsAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/Assets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyProfileAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyProfileAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Asset>) ApiClient.Deserialize(response.Content, typeof(List<Asset>), response.Headers);
        }
    
        /// <summary>
        /// Gets an SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of SshKeyProfile</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeyProfile</returns>
        public SshKeyProfile AssetPartitionsGetSshKeyProfileByIdAsync (int? id, int? profileId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeyProfileByIdAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetSshKeyProfileByIdAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyProfileByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyProfileByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyProfile) ApiClient.Deserialize(response.Content, typeof(SshKeyProfile), response.Headers);
        }
    
        /// <summary>
        /// Gets the discovery schedule on the selected partition profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <returns>SshKeyDiscoverySchedule</returns>
        public SshKeyDiscoverySchedule AssetPartitionsGetSshKeyProfileDiscoveryScheduleAsync (int? id, int? profileId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeyProfileDiscoveryScheduleAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetSshKeyProfileDiscoveryScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/DiscoverySchedule";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyProfileDiscoveryScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyProfileDiscoveryScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyDiscoverySchedule) ApiClient.Deserialize(response.Content, typeof(SshKeyDiscoverySchedule), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of SSH key profiles for a specific partition 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyProfile&gt;</returns>
        public List<SshKeyProfile> AssetPartitionsGetSshKeyProfilesAsync (int? id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeyProfilesAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyProfilesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeyProfilesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SshKeyProfile>) ApiClient.Deserialize(response.Content, typeof(List<SshKeyProfile>), response.Headers);
        }
    
        /// <summary>
        /// Gets all accounts that belong to a profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeySyncGroupAccount&gt;</returns>
        public List<SshKeySyncGroupAccount> AssetPartitionsGetSshKeySyncGroupAccountsAsync (int? id, int? profileId, int? syncGroupId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeySyncGroupAccountsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetSshKeySyncGroupAccountsAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsGetSshKeySyncGroupAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/SshKeySyncGroups/{syncGroupId}/Accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeySyncGroupAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeySyncGroupAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SshKeySyncGroupAccount>) ApiClient.Deserialize(response.Content, typeof(List<SshKeySyncGroupAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SshKeySyncGroup</returns>
        public SshKeySyncGroup AssetPartitionsGetSshKeySyncGroupByIdAsync (int? id, int? profileId, int? syncGroupId, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeySyncGroupByIdAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetSshKeySyncGroupByIdAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsGetSshKeySyncGroupByIdAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/SshKeySyncGroups/{syncGroupId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeySyncGroupByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeySyncGroupByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeySyncGroup) ApiClient.Deserialize(response.Content, typeof(SshKeySyncGroup), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of sync groups for a specific profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeySyncGroup&gt;</returns>
        public List<SshKeySyncGroup> AssetPartitionsGetSshKeySyncGroupsAsync (int? id, int? profileId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSshKeySyncGroupsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetSshKeySyncGroupsAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/SshKeySyncGroups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeySyncGroupsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSshKeySyncGroupsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SshKeySyncGroup>) ApiClient.Deserialize(response.Content, typeof(List<SshKeySyncGroup>), response.Headers);
        }
    
        /// <summary>
        /// Gets all accounts that belong to a profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SyncGroupAccount&gt;</returns>
        public List<SyncGroupAccount> AssetPartitionsGetSyncGroupAccountsAsync (int? id, int? profileId, int? syncGroupId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSyncGroupAccountsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsGetSyncGroupAccountsAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsGetSyncGroupAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/SyncGroups/{syncGroupId}/Accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSyncGroupAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSyncGroupAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SyncGroupAccount>) ApiClient.Deserialize(response.Content, typeof(List<SyncGroupAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of the sync group</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PasswordSyncGroup</returns>
        public PasswordSyncGroup AssetPartitionsGetSyncGroupsByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetSyncGroupsByIdAsync");
    
            var path = "/v4/AssetPartitions/SyncGroups/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSyncGroupsByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetSyncGroupsByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordSyncGroup) ApiClient.Deserialize(response.Content, typeof(PasswordSyncGroup), response.Headers);
        }
    
        /// <summary>
        /// Gets a partition tag 
        /// </summary>
        /// <param name="id">Unique ID of the tag</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PartitionTag</returns>
        public PartitionTag AssetPartitionsGetTagByIdAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsGetTagByIdAsync");
    
            var path = "/v4/AssetPartitions/Tags/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetTagByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsGetTagByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PartitionTag) ApiClient.Deserialize(response.Content, typeof(PartitionTag), response.Headers);
        }
    
        /// <summary>
        /// Marks a discovered service as ignored 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="serviceName">Name of a discovered service. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <returns>DiscoveredService</returns>
        public DiscoveredService AssetPartitionsIgnoreDiscoveredServiceAsync (int? id, int? assetId, string serviceName)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsIgnoreDiscoveredServiceAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsIgnoreDiscoveredServiceAsync");
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling AssetPartitionsIgnoreDiscoveredServiceAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredServices/{assetId}/{serviceName}/Ignore";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsIgnoreDiscoveredServiceAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsIgnoreDiscoveredServiceAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DiscoveredService) ApiClient.Deserialize(response.Content, typeof(DiscoveredService), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple asset account ignore requests 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="body">Discovered asset accounts to process</param>
        /// <returns>List&lt;DiscoveredAssetAccountBatchResponse&gt;</returns>
        public List<DiscoveredAssetAccountBatchResponse> AssetPartitionsIgnoreMultipleAccountsAsync (int? id, List<DiscoveredAssetAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsIgnoreMultipleAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredAccounts/BatchIgnore";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsIgnoreMultipleAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsIgnoreMultipleAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredAssetAccountBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredAssetAccountBatchResponse>), response.Headers);
        }
    
        /// <summary>
        /// Marks a discovered account as ignored 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountName">Name of a discovered account. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <returns>DiscoveredAssetAccount</returns>
        public DiscoveredAssetAccount AssetPartitionsIgnorePartitionDiscoveredAccountAsync (int? id, int? assetId, string accountName)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsIgnorePartitionDiscoveredAccountAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsIgnorePartitionDiscoveredAccountAsync");
            // verify the required parameter 'accountName' is set
            if (accountName == null) throw new ApiException(400, "Missing required parameter 'accountName' when calling AssetPartitionsIgnorePartitionDiscoveredAccountAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredAccounts/{assetId}/{accountName}/Ignore";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
path = path.Replace("{" + "accountName" + "}", ApiClient.ParameterToString(accountName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsIgnorePartitionDiscoveredAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsIgnorePartitionDiscoveredAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DiscoveredAssetAccount) ApiClient.Deserialize(response.Content, typeof(DiscoveredAssetAccount), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple asset account manage requests 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="body">Parameters for managing multiple discovered accounts</param>
        /// <returns>List&lt;ManagedDiscoveredAssetAccountBatchResponse&gt;</returns>
        public List<ManagedDiscoveredAssetAccountBatchResponse> AssetPartitionsManageMultipleAccountsAsync (int? id, BatchManageParameters body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsManageMultipleAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredAccounts/BatchManage";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsManageMultipleAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsManageMultipleAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ManagedDiscoveredAssetAccountBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<ManagedDiscoveredAssetAccountBatchResponse>), response.Headers);
        }
    
        /// <summary>
        /// Brings a discovered account under management 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountName">Name of a discovered account. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <param name="body">Additional optional parameters for configuring the new account</param>
        /// <returns>AssetAccount</returns>
        public AssetAccount AssetPartitionsManagePartitionDiscoveredAccountAsync (int? id, int? assetId, string accountName, AccountTemplate body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsManagePartitionDiscoveredAccountAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsManagePartitionDiscoveredAccountAsync");
            // verify the required parameter 'accountName' is set
            if (accountName == null) throw new ApiException(400, "Missing required parameter 'accountName' when calling AssetPartitionsManagePartitionDiscoveredAccountAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredAccounts/{assetId}/{accountName}/Manage";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
path = path.Replace("{" + "accountName" + "}", ApiClient.ParameterToString(accountName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsManagePartitionDiscoveredAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsManagePartitionDiscoveredAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetAccount) ApiClient.Deserialize(response.Content, typeof(AssetAccount), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove assets assigned to an existing account discovery schedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the account discovery schedule</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Users to assign to the account discovery schedule</param>
        /// <returns>List&lt;Asset&gt;</returns>
        public List<Asset> AssetPartitionsModifyAccountDiscoveryAssetsAsync (int? id, int? scheduleId, ListOperation operation, List<Asset> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsModifyAccountDiscoveryAssetsAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsModifyAccountDiscoveryAssetsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetPartitionsModifyAccountDiscoveryAssetsAsync");
    
            var path = "/v4/AssetPartitions/{id}/AccountDiscoverySchedules/{scheduleId}/Assets/{operation}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifyAccountDiscoveryAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifyAccountDiscoveryAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Asset>) ApiClient.Deserialize(response.Content, typeof(List<Asset>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove profile schedule&#x27;s rules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">rules to assign to the profile schedule</param>
        /// <returns>List&lt;AccountDiscoveryRule&gt;</returns>
        public List<AccountDiscoveryRule> AssetPartitionsModifyAccountDiscoveryRulesAsync (int? id, int? scheduleId, ListOperation operation, List<AccountDiscoveryRule> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsModifyAccountDiscoveryRulesAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsModifyAccountDiscoveryRulesAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetPartitionsModifyAccountDiscoveryRulesAsync");
    
            var path = "/v4/AssetPartitions/{id}/AccountDiscoverySchedules/{scheduleId}/Rules/{operation}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifyAccountDiscoveryRulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifyAccountDiscoveryRulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountDiscoveryRule>) ApiClient.Deserialize(response.Content, typeof(List<AccountDiscoveryRule>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;SyncGroupAccount&gt;</returns>
        public List<SyncGroupAccount> AssetPartitionsModifyAccountsAsync (int? id, int? profileId, int? syncGroupId, ListOperation operation, List<SyncGroupAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsModifyAccountsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsModifyAccountsAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsModifyAccountsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetPartitionsModifyAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/SyncGroups/{syncGroupId}/Accounts/{operation}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifyAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifyAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SyncGroupAccount>) ApiClient.Deserialize(response.Content, typeof(List<SyncGroupAccount>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove rules assigned to an asset discovery job 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="jobId">Unique identifier of the AssetDiscoveryJob</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Accounts to assign to the AssetDiscoveryJob</param>
        /// <returns>List&lt;AssetDiscoveryRule&gt;</returns>
        public List<AssetDiscoveryRule> AssetPartitionsModifyDiscoveryJobRulesAsync (int? id, int? jobId, ListOperation operation, List<AssetDiscoveryRule> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsModifyDiscoveryJobRulesAsync");
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling AssetPartitionsModifyDiscoveryJobRulesAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetPartitionsModifyDiscoveryJobRulesAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveryJobs/{jobId}/Rules/{operation}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "jobId" + "}", ApiClient.ParameterToString(jobId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifyDiscoveryJobRulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifyDiscoveryJobRulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetDiscoveryRule>) ApiClient.Deserialize(response.Content, typeof(List<AssetDiscoveryRule>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove assigned owners of this partition 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetPartition</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">List of owners to assign to this partition</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> AssetPartitionsModifyManagedByAsync (int? id, ListOperation operation, List<Identity> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsModifyManagedByAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetPartitionsModifyManagedByAsync");
    
            var path = "/v4/AssetPartitions/{id}/ManagedBy/{operation}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifyManagedByAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifyManagedByAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove accounts to an existing profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetPartitionsModifyProfileAssetAccountsAsync (int? id, int? profileId, ListOperation operation, List<AssetAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsModifyProfileAssetAccountsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsModifyProfileAssetAccountsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetPartitionsModifyProfileAssetAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/Accounts/{operation}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifyProfileAssetAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifyProfileAssetAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove assets to an existing profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;Asset&gt;</returns>
        public List<Asset> AssetPartitionsModifyProfileAssetsAsync (int? id, int? profileId, ListOperation operation, List<Asset> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsModifyProfileAssetsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsModifyProfileAssetsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetPartitionsModifyProfileAssetsAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/Assets/{operation}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifyProfileAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifyProfileAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Asset>) ApiClient.Deserialize(response.Content, typeof(List<Asset>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;SshKeySyncGroupAccount&gt;</returns>
        public List<SshKeySyncGroupAccount> AssetPartitionsModifySshKeyAccountsAsync (int? id, int? profileId, int? syncGroupId, ListOperation operation, List<SshKeySyncGroupAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsModifySshKeyAccountsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsModifySshKeyAccountsAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsModifySshKeyAccountsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetPartitionsModifySshKeyAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/SshKeySyncGroups/{syncGroupId}/Accounts/{operation}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifySshKeyAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifySshKeyAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SshKeySyncGroupAccount>) ApiClient.Deserialize(response.Content, typeof(List<SshKeySyncGroupAccount>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove accounts to an existing SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetPartitionsModifySshKeyProfileAssetAccountsAsync (int? id, int? profileId, ListOperation operation, List<AssetAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsModifySshKeyProfileAssetAccountsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsModifySshKeyProfileAssetAccountsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetPartitionsModifySshKeyProfileAssetAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/Accounts/{operation}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifySshKeyProfileAssetAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifySshKeyProfileAssetAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove accounts to an existing SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;Asset&gt;</returns>
        public List<Asset> AssetPartitionsModifySshKeyProfileAssetsAsync (int? id, int? profileId, ListOperation operation, List<Asset> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsModifySshKeyProfileAssetsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsModifySshKeyProfileAssetsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling AssetPartitionsModifySshKeyProfileAssetsAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/Assets/{operation}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifySshKeyProfileAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsModifySshKeyProfileAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Asset>) ApiClient.Deserialize(response.Content, typeof(List<Asset>), response.Headers);
        }
    
        /// <summary>
        /// Run asset discovery job now 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="jobId">Database ID of asset discovery job</param>
        /// <param name="extendedLogging">Whether to include extended logging for the platform operation</param>
        /// <returns>AssetDiscoveryLog</returns>
        public AssetDiscoveryLog AssetPartitionsRunDiscoveryJobAsync (int? id, int? jobId, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsRunDiscoveryJobAsync");
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling AssetPartitionsRunDiscoveryJobAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveryJobs/{jobId}/RunDiscovery";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "jobId" + "}", ApiClient.ParameterToString(jobId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsRunDiscoveryJobAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsRunDiscoveryJobAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetDiscoveryLog) ApiClient.Deserialize(response.Content, typeof(AssetDiscoveryLog), response.Headers);
        }
    
        /// <summary>
        /// Sets the assets that are assigned to this account discovery schedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the account discovery schedule</param>
        /// <param name="body">Users to assign to the account discovery schedule</param>
        /// <returns>List&lt;Asset&gt;</returns>
        public List<Asset> AssetPartitionsSetAccountDiscoveryAssetsAsync (int? id, int? scheduleId, List<Asset> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsSetAccountDiscoveryAssetsAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsSetAccountDiscoveryAssetsAsync");
    
            var path = "/v4/AssetPartitions/{id}/AccountDiscoverySchedules/{scheduleId}/Assets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetAccountDiscoveryAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetAccountDiscoveryAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Asset>) ApiClient.Deserialize(response.Content, typeof(List<Asset>), response.Headers);
        }
    
        /// <summary>
        /// Sets the accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;SyncGroupAccount&gt;</returns>
        public List<SyncGroupAccount> AssetPartitionsSetAccountsAsync (int? id, int? profileId, int? syncGroupId, List<SyncGroupAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsSetAccountsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsSetAccountsAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsSetAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/SyncGroups/{syncGroupId}/Accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SyncGroupAccount>) ApiClient.Deserialize(response.Content, typeof(List<SyncGroupAccount>), response.Headers);
        }
    
        /// <summary>
        /// Sets the rules assigned to an asset discovery job 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="jobId">Unique identifier of the AssetDiscoveryJob</param>
        /// <param name="body">Accounts to assign to the AssetDiscoveryJob</param>
        /// <returns>List&lt;AssetDiscoveryRule&gt;</returns>
        public List<AssetDiscoveryRule> AssetPartitionsSetDiscoveryJobRulesAsync (int? id, int? jobId, List<AssetDiscoveryRule> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsSetDiscoveryJobRulesAsync");
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling AssetPartitionsSetDiscoveryJobRulesAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveryJobs/{jobId}/Rules";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "jobId" + "}", ApiClient.ParameterToString(jobId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetDiscoveryJobRulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetDiscoveryJobRulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetDiscoveryRule>) ApiClient.Deserialize(response.Content, typeof(List<AssetDiscoveryRule>), response.Headers);
        }
    
        /// <summary>
        /// Updates the assigned owners of this partition 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetPartition</param>
        /// <param name="body">List of owners to assign to this partition</param>
        /// <returns>List&lt;Identity&gt;</returns>
        public List<Identity> AssetPartitionsSetPartitionManagedByAsync (int? id, List<Identity> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsSetPartitionManagedByAsync");
    
            var path = "/v4/AssetPartitions/{id}/ManagedBy";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetPartitionManagedByAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetPartitionManagedByAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Identity>) ApiClient.Deserialize(response.Content, typeof(List<Identity>), response.Headers);
        }
    
        /// <summary>
        /// Sets the sync group password 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="body">Password to set for this sync group</param>
        /// <returns></returns>
        public void AssetPartitionsSetPasswordAsync (int? id, int? profileId, int? syncGroupId, string body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsSetPasswordAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsSetPasswordAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsSetPasswordAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/SyncGroups/{syncGroupId}/Password";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetPasswordAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetPasswordAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sets the accounts that are explicitly using this profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetPartitionsSetProfileAssetAccountsAsync (int? id, int? profileId, List<AssetAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsSetProfileAssetAccountsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsSetProfileAssetAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/Accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetProfileAssetAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetProfileAssetAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Sets the assets that are explicitly using this profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;Asset&gt;</returns>
        public List<Asset> AssetPartitionsSetProfileAssetsAsync (int? id, int? profileId, List<Asset> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsSetProfileAssetsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsSetProfileAssetsAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/Assets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetProfileAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetProfileAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Asset>) ApiClient.Deserialize(response.Content, typeof(List<Asset>), response.Headers);
        }
    
        /// <summary>
        /// Sets the accounts assigned to this group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="body">Accounts to assign to the AccountGroup</param>
        /// <returns>List&lt;SshKeySyncGroupAccount&gt;</returns>
        public List<SshKeySyncGroupAccount> AssetPartitionsSetSshKeyAccountsAsync (int? id, int? profileId, int? syncGroupId, List<SshKeySyncGroupAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsSetSshKeyAccountsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsSetSshKeyAccountsAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsSetSshKeyAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/SshKeySyncGroups/{syncGroupId}/Accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetSshKeyAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetSshKeyAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SshKeySyncGroupAccount>) ApiClient.Deserialize(response.Content, typeof(List<SshKeySyncGroupAccount>), response.Headers);
        }
    
        /// <summary>
        /// Sets the sync group SSH key 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="body">SSH keyto set for this sync group</param>
        /// <param name="keyFormat">The format of the SSH private key (defaults to OpenSsh)&lt;br /&gt;&lt;br /&gt;              - OpenSsh - OpenSSH legacy PEM format&lt;br /&gt;              - Ssh2 - Tectia format for use with tools from SSH.com&lt;br /&gt;              - Putty - Putty format for use with PuTTY tools&lt;br /&gt;</param>
        /// <returns></returns>
        public void AssetPartitionsSetSshKeyAsync (int? id, int? profileId, int? syncGroupId, AccountSshKey body, SshKeyFormat keyFormat)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsSetSshKeyAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsSetSshKeyAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsSetSshKeyAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/SshKeySyncGroups/{syncGroupId}/SshKey";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetSshKeyAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetSshKeyAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sets the accounts that are explicitly using this SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;AssetAccount&gt;</returns>
        public List<AssetAccount> AssetPartitionsSetSshKeyProfileAssetAccountsAsync (int? id, int? profileId, List<AssetAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsSetSshKeyProfileAssetAccountsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsSetSshKeyProfileAssetAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/Accounts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetSshKeyProfileAssetAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetSshKeyProfileAssetAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetAccount>) ApiClient.Deserialize(response.Content, typeof(List<AssetAccount>), response.Headers);
        }
    
        /// <summary>
        /// Sets the assets that are explicitly using this SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <param name="body">Users to assign to the profile</param>
        /// <returns>List&lt;Asset&gt;</returns>
        public List<Asset> AssetPartitionsSetSshKeyProfileAssetsAsync (int? id, int? profileId, List<Asset> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsSetSshKeyProfileAssetsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsSetSshKeyProfileAssetsAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/Assets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetSshKeyProfileAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSetSshKeyProfileAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Asset>) ApiClient.Deserialize(response.Content, typeof(List<Asset>), response.Headers);
        }
    
        /// <summary>
        /// Marks a discovered service as visible 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="serviceName">Name of a discovered service. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <returns>DiscoveredService</returns>
        public DiscoveredService AssetPartitionsShowDiscoveredServiceAsync (int? id, int? assetId, string serviceName)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsShowDiscoveredServiceAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsShowDiscoveredServiceAsync");
            // verify the required parameter 'serviceName' is set
            if (serviceName == null) throw new ApiException(400, "Missing required parameter 'serviceName' when calling AssetPartitionsShowDiscoveredServiceAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredServices/{assetId}/{serviceName}/Show";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
path = path.Replace("{" + "serviceName" + "}", ApiClient.ParameterToString(serviceName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsShowDiscoveredServiceAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsShowDiscoveredServiceAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DiscoveredService) ApiClient.Deserialize(response.Content, typeof(DiscoveredService), response.Headers);
        }
    
        /// <summary>
        /// Processes multiple asset account show requests 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="body">Discovered asset accounts to process</param>
        /// <returns>List&lt;DiscoveredAssetAccountBatchResponse&gt;</returns>
        public List<DiscoveredAssetAccountBatchResponse> AssetPartitionsShowMultipleAccountsAsync (int? id, List<DiscoveredAssetAccount> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsShowMultipleAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredAccounts/BatchShow";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsShowMultipleAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsShowMultipleAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredAssetAccountBatchResponse>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredAssetAccountBatchResponse>), response.Headers);
        }
    
        /// <summary>
        /// Marks a discovered account as visible 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="assetId">Unique ID of an Asset</param>
        /// <param name="accountName">Name of a discovered account. For directory accounts you must also specify the domain name e.g., {accountName}@{domainName}</param>
        /// <returns>DiscoveredAssetAccount</returns>
        public DiscoveredAssetAccount AssetPartitionsShowPartitionDiscoveredAccountAsync (int? id, int? assetId, string accountName)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsShowPartitionDiscoveredAccountAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling AssetPartitionsShowPartitionDiscoveredAccountAsync");
            // verify the required parameter 'accountName' is set
            if (accountName == null) throw new ApiException(400, "Missing required parameter 'accountName' when calling AssetPartitionsShowPartitionDiscoveredAccountAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveredAccounts/{assetId}/{accountName}/Show";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
path = path.Replace("{" + "accountName" + "}", ApiClient.ParameterToString(accountName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsShowPartitionDiscoveredAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsShowPartitionDiscoveredAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DiscoveredAssetAccount) ApiClient.Deserialize(response.Content, typeof(DiscoveredAssetAccount), response.Headers);
        }
    
        /// <summary>
        /// Sync credentials for all accounts in sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AssetPartitionsSyncAccountsAsync (int? id, int? profileId, int? syncGroupId, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsSyncAccountsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsSyncAccountsAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsSyncAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/SyncGroups/{syncGroupId}/Sync";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSyncAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSyncAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Sync credentials for all accounts in sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AssetPartitionsSyncSshKeyAccountsAsync (int? id, int? profileId, int? syncGroupId, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsSyncSshKeyAccountsAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsSyncSshKeyAccountsAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsSyncSshKeyAccountsAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/SshKeySyncGroups/{syncGroupId}/Sync";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSyncSshKeyAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsSyncSshKeyAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Runs Discovery on the given PartitionProfileAccountDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">Discovery parameters</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>AccountDiscoveryLog</returns>
        public AccountDiscoveryLog AssetPartitionsTestAccountDiscoveryAsync (int? id, CustomPartitionDiscoverAccountsParameters body, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsTestAccountDiscoveryAsync");
    
            var path = "/v4/AssetPartitions/{id}/AccountDiscoverySchedules/TestDiscovery";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsTestAccountDiscoveryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsTestAccountDiscoveryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountDiscoveryLog) ApiClient.Deserialize(response.Content, typeof(AccountDiscoveryLog), response.Headers);
        }
    
        /// <summary>
        /// Tests an asset account partition tagging rule change against partition asset accounts 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="body">Tagging rule to test</param>
        /// <param name="operationalOnly">Do not return no-op results</param>
        /// <param name="limit">Limit response to this number of results</param>
        /// <returns>List&lt;DynamicTaggingRuleTestResult&gt;</returns>
        public List<DynamicTaggingRuleTestResult> AssetPartitionsTestAssetAccountRuleAsync (int? id, TaggingGroupingRule body, bool? operationalOnly, int? limit)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsTestAssetAccountRuleAsync");
    
            var path = "/v4/AssetPartitions/{id}/Tags/TestAssetAccountRule";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (operationalOnly != null) queryParams.Add("operationalOnly", ApiClient.ParameterToString(operationalOnly)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsTestAssetAccountRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsTestAssetAccountRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DynamicTaggingRuleTestResult>) ApiClient.Deserialize(response.Content, typeof(List<DynamicTaggingRuleTestResult>), response.Headers);
        }
    
        /// <summary>
        /// Tests an asset partition tagging rule change against partition assets 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="body">Tagging rule to test</param>
        /// <param name="operationalOnly">Do not return no-op results</param>
        /// <param name="limit">Limit response to this number of results</param>
        /// <returns>List&lt;DynamicTaggingRuleTestResult&gt;</returns>
        public List<DynamicTaggingRuleTestResult> AssetPartitionsTestAssetRuleAsync (int? id, TaggingGroupingRule body, bool? operationalOnly, int? limit)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsTestAssetRuleAsync");
    
            var path = "/v4/AssetPartitions/{id}/Tags/TestAssetRule";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (operationalOnly != null) queryParams.Add("operationalOnly", ApiClient.ParameterToString(operationalOnly)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsTestAssetRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsTestAssetRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DynamicTaggingRuleTestResult>) ApiClient.Deserialize(response.Content, typeof(List<DynamicTaggingRuleTestResult>), response.Headers);
        }
    
        /// <summary>
        /// Tests the set of specific asset discovery conditions. Assets will only be discovered but not added to the database. 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="body">Parameters for testing asset discovery conditions</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>AssetDiscoveryLog</returns>
        public AssetDiscoveryLog AssetPartitionsTestDiscoveryAsync (int? id, TestAssetDiscoveryParameters body, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsTestDiscoveryAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveryJobs/TestDiscovery";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsTestDiscoveryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsTestDiscoveryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetDiscoveryLog) ApiClient.Deserialize(response.Content, typeof(AssetDiscoveryLog), response.Headers);
        }
    
        /// <summary>
        /// Runs Service Discovery on the given PartitionProfileAccountDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="body">Discovery parameters</param>
        /// <param name="extendedLogging">Generate debug task log for action</param>
        /// <returns>ServiceDiscoveryLog</returns>
        public ServiceDiscoveryLog AssetPartitionsTestServiceDiscoveryAsync (int? id, CustomPartitionDiscoverAccountsParameters body, bool? extendedLogging)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsTestServiceDiscoveryAsync");
    
            var path = "/v4/AssetPartitions/{id}/AccountDiscoverySchedules/TestServiceDiscovery";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsTestServiceDiscoveryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsTestServiceDiscoveryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServiceDiscoveryLog) ApiClient.Deserialize(response.Content, typeof(ServiceDiscoveryLog), response.Headers);
        }
    
        /// <summary>
        /// Tests an asset account partition tagging rule change against partition asset accounts 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="tagId">Unique ID of the partition tag</param>
        /// <param name="body">Tagging rule to test</param>
        /// <param name="operationalOnly">Do not return no-op results</param>
        /// <param name="limit">Limit response to this number of results</param>
        /// <returns>List&lt;DynamicTaggingRuleTestResult&gt;</returns>
        public List<DynamicTaggingRuleTestResult> AssetPartitionsTestTagAssetAccountRuleAsync (int? id, int? tagId, TaggingGroupingRule body, bool? operationalOnly, int? limit)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsTestTagAssetAccountRuleAsync");
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling AssetPartitionsTestTagAssetAccountRuleAsync");
    
            var path = "/v4/AssetPartitions/{id}/Tags/{tagId}/TestAssetAccountRule";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "tagId" + "}", ApiClient.ParameterToString(tagId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (operationalOnly != null) queryParams.Add("operationalOnly", ApiClient.ParameterToString(operationalOnly)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsTestTagAssetAccountRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsTestTagAssetAccountRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DynamicTaggingRuleTestResult>) ApiClient.Deserialize(response.Content, typeof(List<DynamicTaggingRuleTestResult>), response.Headers);
        }
    
        /// <summary>
        /// Tests an asset partition tagging rule change against partition assets 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="tagId">Unique ID of the partition tag</param>
        /// <param name="body">Tagging rule to test</param>
        /// <param name="operationalOnly">Do not return no-op results</param>
        /// <param name="limit">Limit response to this number of results</param>
        /// <returns>List&lt;DynamicTaggingRuleTestResult&gt;</returns>
        public List<DynamicTaggingRuleTestResult> AssetPartitionsTestTagAssetRuleAsync (int? id, int? tagId, TaggingGroupingRule body, bool? operationalOnly, int? limit)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsTestTagAssetRuleAsync");
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling AssetPartitionsTestTagAssetRuleAsync");
    
            var path = "/v4/AssetPartitions/{id}/Tags/{tagId}/TestAssetRule";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "tagId" + "}", ApiClient.ParameterToString(tagId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (operationalOnly != null) queryParams.Add("operationalOnly", ApiClient.ParameterToString(operationalOnly)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsTestTagAssetRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsTestTagAssetRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DynamicTaggingRuleTestResult>) ApiClient.Deserialize(response.Content, typeof(List<DynamicTaggingRuleTestResult>), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing PartitionProfileAccountDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the PartitionProfileAccountDiscoverySchedule</param>
        /// <param name="body">Updated PartitionProfileAccountDiscoverySchedule</param>
        /// <returns>AccountDiscoverySchedule</returns>
        public AccountDiscoverySchedule AssetPartitionsUpdateAccountDiscoveryAsync (int? id, int? scheduleId, AccountDiscoverySchedule body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsUpdateAccountDiscoveryAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsUpdateAccountDiscoveryAsync");
    
            var path = "/v4/AssetPartitions/{id}/AccountDiscoverySchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateAccountDiscoveryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateAccountDiscoveryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountDiscoverySchedule) ApiClient.Deserialize(response.Content, typeof(AccountDiscoverySchedule), response.Headers);
        }
    
        /// <summary>
        /// Sets an existing profile schedule&#x27;s rules 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the profile schedule</param>
        /// <param name="body">rules to assign to the profile schedule</param>
        /// <returns>List&lt;AccountDiscoveryRule&gt;</returns>
        public List<AccountDiscoveryRule> AssetPartitionsUpdateAccountDiscoveryRulesAsync (int? id, int? scheduleId, List<AccountDiscoveryRule> body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsUpdateAccountDiscoveryRulesAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsUpdateAccountDiscoveryRulesAsync");
    
            var path = "/v4/AssetPartitions/{id}/AccountDiscoverySchedules/{scheduleId}/Rules";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateAccountDiscoveryRulesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateAccountDiscoveryRulesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountDiscoveryRule>) ApiClient.Deserialize(response.Content, typeof(List<AccountDiscoveryRule>), response.Headers);
        }
    
        /// <summary>
        /// Updates an AssetPartition 
        /// </summary>
        /// <param name="id">Unique identifier of the AssetPartition to update</param>
        /// <param name="body">Updated AssetPartition</param>
        /// <returns>AssetPartition</returns>
        public AssetPartition AssetPartitionsUpdateAssetPartitionAsync (int? id, AssetPartition body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsUpdateAssetPartitionAsync");
    
            var path = "/v4/AssetPartitions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateAssetPartitionAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateAssetPartitionAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetPartition) ApiClient.Deserialize(response.Content, typeof(AssetPartition), response.Headers);
        }
    
        /// <summary>
        /// Updates a PartitionProfileChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the PartitionProfileChangeSchedule to update</param>
        /// <param name="body">Updated PartitionProfileChangeSchedule</param>
        /// <returns>PasswordChangeSchedule</returns>
        public PasswordChangeSchedule AssetPartitionsUpdateChangeScheduleAsync (int? id, int? scheduleId, PasswordChangeSchedule body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsUpdateChangeScheduleAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsUpdateChangeScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/ChangeSchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateChangeScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateChangeScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordChangeSchedule) ApiClient.Deserialize(response.Content, typeof(PasswordChangeSchedule), response.Headers);
        }
    
        /// <summary>
        /// Updates a PartitionProfileCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the PartitionProfileCheckSchedule to update</param>
        /// <param name="body">Updated PartitionProfileCheckSchedule</param>
        /// <returns>PasswordCheckSchedule</returns>
        public PasswordCheckSchedule AssetPartitionsUpdateCheckScheduleAsync (int? id, int? scheduleId, PasswordCheckSchedule body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsUpdateCheckScheduleAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsUpdateCheckScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/CheckSchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateCheckScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateCheckScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordCheckSchedule) ApiClient.Deserialize(response.Content, typeof(PasswordCheckSchedule), response.Headers);
        }
    
        /// <summary>
        /// Updates an asset discovery job 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="jobId">Unique identifier of the AssetDiscoveryJob</param>
        /// <param name="body">Updated AssetDiscoveryJob</param>
        /// <returns>AssetDiscoveryJob</returns>
        public AssetDiscoveryJob AssetPartitionsUpdateDiscoveryJobAsync (int? id, int? jobId, AssetDiscoveryJob body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsUpdateDiscoveryJobAsync");
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling AssetPartitionsUpdateDiscoveryJobAsync");
    
            var path = "/v4/AssetPartitions/{id}/DiscoveryJobs/{jobId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "jobId" + "}", ApiClient.ParameterToString(jobId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateDiscoveryJobAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateDiscoveryJobAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetDiscoveryJob) ApiClient.Deserialize(response.Content, typeof(AssetDiscoveryJob), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing password rule 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="ruleId">Unique identifier of the AccountPasswordRule to update</param>
        /// <param name="body">Updated AccountPasswordRule</param>
        /// <returns>AccountPasswordRule</returns>
        public AccountPasswordRule AssetPartitionsUpdatePasswordRuleAsync (int? id, int? ruleId, AccountPasswordRule body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsUpdatePasswordRuleAsync");
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling AssetPartitionsUpdatePasswordRuleAsync");
    
            var path = "/v4/AssetPartitions/{id}/PasswordRules/{ruleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "ruleId" + "}", ApiClient.ParameterToString(ruleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdatePasswordRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdatePasswordRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountPasswordRule) ApiClient.Deserialize(response.Content, typeof(AccountPasswordRule), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing application asset configuration profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the PartitionProfile</param>
        /// <param name="body">Updated PartitionProfile</param>
        /// <returns>PasswordProfile</returns>
        public PasswordProfile AssetPartitionsUpdateProfileAsync (int? id, int? profileId, PasswordProfile body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsUpdateProfileAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsUpdateProfileAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateProfileAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateProfileAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordProfile) ApiClient.Deserialize(response.Content, typeof(PasswordProfile), response.Headers);
        }
    
        /// <summary>
        /// Updates a SshKeyChangeSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the SshKeyChangeSchedule to update</param>
        /// <param name="body">Updated SshKeyChangeSchedule</param>
        /// <returns>SshKeyChangeSchedule</returns>
        public SshKeyChangeSchedule AssetPartitionsUpdateSshKeyChangeScheduleAsync (int? id, int? scheduleId, SshKeyChangeSchedule body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsUpdateSshKeyChangeScheduleAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsUpdateSshKeyChangeScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyChangeSchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateSshKeyChangeScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateSshKeyChangeScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyChangeSchedule) ApiClient.Deserialize(response.Content, typeof(SshKeyChangeSchedule), response.Headers);
        }
    
        /// <summary>
        /// Updates a SshKeyCheckSchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the SshKeyCheckSchedule to update</param>
        /// <param name="body">Updated SshKeyCheckSchedule</param>
        /// <returns>SshKeyCheckSchedule</returns>
        public SshKeyCheckSchedule AssetPartitionsUpdateSshKeyCheckScheduleAsync (int? id, int? scheduleId, SshKeyCheckSchedule body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsUpdateSshKeyCheckScheduleAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsUpdateSshKeyCheckScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyCheckSchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateSshKeyCheckScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateSshKeyCheckScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyCheckSchedule) ApiClient.Deserialize(response.Content, typeof(SshKeyCheckSchedule), response.Headers);
        }
    
        /// <summary>
        /// Updates a SshKeyDiscoverySchedule 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="scheduleId">Unique identifier of the SshKeyDiscoverySchedule to update</param>
        /// <param name="body">Updated SshKeyDiscoverySchedule</param>
        /// <returns>SshKeyDiscoverySchedule</returns>
        public SshKeyDiscoverySchedule AssetPartitionsUpdateSshKeyDiscoveryScheduleAsync (int? id, int? scheduleId, SshKeyDiscoverySchedule body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsUpdateSshKeyDiscoveryScheduleAsync");
            // verify the required parameter 'scheduleId' is set
            if (scheduleId == null) throw new ApiException(400, "Missing required parameter 'scheduleId' when calling AssetPartitionsUpdateSshKeyDiscoveryScheduleAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyDiscoverySchedules/{scheduleId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "scheduleId" + "}", ApiClient.ParameterToString(scheduleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateSshKeyDiscoveryScheduleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateSshKeyDiscoveryScheduleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyDiscoverySchedule) ApiClient.Deserialize(response.Content, typeof(SshKeyDiscoverySchedule), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing SSH key profile 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique identifier of the SshKeyProfile</param>
        /// <param name="body">Updated SshKeyProfile</param>
        /// <returns>SshKeyProfile</returns>
        public SshKeyProfile AssetPartitionsUpdateSshKeyProfileAsync (int? id, int? profileId, SshKeyProfile body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsUpdateSshKeyProfileAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsUpdateSshKeyProfileAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateSshKeyProfileAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateSshKeyProfileAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyProfile) ApiClient.Deserialize(response.Content, typeof(SshKeyProfile), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="body">Updated SshKeySyncGroup</param>
        /// <returns>SshKeySyncGroup</returns>
        public SshKeySyncGroup AssetPartitionsUpdateSshKeySyncGroupAsync (int? id, int? profileId, int? syncGroupId, SshKeySyncGroup body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsUpdateSshKeySyncGroupAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsUpdateSshKeySyncGroupAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsUpdateSshKeySyncGroupAsync");
    
            var path = "/v4/AssetPartitions/{id}/SshKeyProfiles/{profileId}/SshKeySyncGroups/{syncGroupId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateSshKeySyncGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateSshKeySyncGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeySyncGroup) ApiClient.Deserialize(response.Content, typeof(SshKeySyncGroup), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing profile sync group 
        /// </summary>
        /// <param name="id">Unique ID of asset partition</param>
        /// <param name="profileId">Unique ID of profile</param>
        /// <param name="syncGroupId">Unique ID of sync group</param>
        /// <param name="body">Updated PasswordSyncGroup</param>
        /// <returns>PasswordSyncGroup</returns>
        public PasswordSyncGroup AssetPartitionsUpdateSyncGroupAsync (int? id, int? profileId, int? syncGroupId, PasswordSyncGroup body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsUpdateSyncGroupAsync");
            // verify the required parameter 'profileId' is set
            if (profileId == null) throw new ApiException(400, "Missing required parameter 'profileId' when calling AssetPartitionsUpdateSyncGroupAsync");
            // verify the required parameter 'syncGroupId' is set
            if (syncGroupId == null) throw new ApiException(400, "Missing required parameter 'syncGroupId' when calling AssetPartitionsUpdateSyncGroupAsync");
    
            var path = "/v4/AssetPartitions/{id}/Profiles/{profileId}/SyncGroups/{syncGroupId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "profileId" + "}", ApiClient.ParameterToString(profileId));
path = path.Replace("{" + "syncGroupId" + "}", ApiClient.ParameterToString(syncGroupId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateSyncGroupAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateSyncGroupAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordSyncGroup) ApiClient.Deserialize(response.Content, typeof(PasswordSyncGroup), response.Headers);
        }
    
        /// <summary>
        /// Updates a partition tag 
        /// </summary>
        /// <param name="id">Unique ID of the partition</param>
        /// <param name="tagId">Unique identifier of the tag</param>
        /// <param name="body">Updated Tag</param>
        /// <returns>PartitionTag</returns>
        public PartitionTag AssetPartitionsUpdateTagAsync (int? id, int? tagId, PartitionTag body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsUpdateTagAsync");
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling AssetPartitionsUpdateTagAsync");
    
            var path = "/v4/AssetPartitions/{id}/Tags/{tagId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "tagId" + "}", ApiClient.ParameterToString(tagId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateTagAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsUpdateTagAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PartitionTag) ApiClient.Deserialize(response.Content, typeof(PartitionTag), response.Headers);
        }
    
        /// <summary>
        /// Validates a proposed password against the given rule 
        /// </summary>
        /// <param name="id">Unique ID of an AssetPartition</param>
        /// <param name="ruleId">Unique identifier of the PartitionAccountPasswordRule to update</param>
        /// <param name="body">Password to validate against this rule</param>
        /// <returns>bool?</returns>
        public bool? AssetPartitionsValidateAccountPasswordByRuleAsync (int? id, int? ruleId, string body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AssetPartitionsValidateAccountPasswordByRuleAsync");
            // verify the required parameter 'ruleId' is set
            if (ruleId == null) throw new ApiException(400, "Missing required parameter 'ruleId' when calling AssetPartitionsValidateAccountPasswordByRuleAsync");
    
            var path = "/v4/AssetPartitions/{id}/PasswordRules/{ruleId}/ValidatePassword";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "ruleId" + "}", ApiClient.ParameterToString(ruleId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsValidateAccountPasswordByRuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssetPartitionsValidateAccountPasswordByRuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
    }
}
