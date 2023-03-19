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
    public interface IAuditLogApi
    {
        /// <summary>
        /// Gets a set of access request activity log entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="accountId">Get activity that occurred for a specific account (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequestActivityLog&gt;</returns>
        List<AccessRequestActivityLog> AuditLogGetAccessRequestActivitiesAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, int? accountId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets access request activity log entry with given ID 
        /// </summary>
        /// <param name="requestId">The unique ID of the access request</param>
        /// <param name="logId">The database ID of the activity log entry</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>AccessRequestActivityLog</returns>
        AccessRequestActivityLog AuditLogGetAccessRequestActivitiesByIdAsync (string requestId, string logId, string fields);
        /// <summary>
        /// Gets access request activity log entries for a request 
        /// </summary>
        /// <param name="requestId">The unique ID of the access request</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequestActivityLog&gt;</returns>
        List<AccessRequestActivityLog> AuditLogGetAccessRequestActivitiesByRequestIdAsync (string requestId, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a set of access request session activity log entries 
        /// </summary>
        /// <param name="requestId">The unique ID of the access request</param>
        /// <param name="logId">The database ID of the activity log entry</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequestSessionActivityLog&gt;</returns>
        List<AccessRequestSessionActivityLog> AuditLogGetAccessRequestActivitySessionLogAsync (string requestId, string logId, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets access request session activity log entry with given ID 
        /// </summary>
        /// <param name="requestId">The unique ID of the access request</param>
        /// <param name="sessionId">The unique session ID of a session in the access request</param>
        /// <param name="logId">The database ID of the activity log entry</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>AccessRequestSessionActivityLog</returns>
        AccessRequestSessionActivityLog AuditLogGetAccessRequestSessionActivitiesByIdAsync (string requestId, int? sessionId, string logId, string fields);
        /// <summary>
        /// Gets access request session activity log entries for a request 
        /// </summary>
        /// <param name="requestId">The unique ID of the access request</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequestSessionActivityLog&gt;</returns>
        List<AccessRequestSessionActivityLog> AuditLogGetAccessRequestSessionActivitiesByRequestIdAsync (string requestId, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets access request session activity log entries for a request 
        /// </summary>
        /// <param name="requestId">The unique ID of the access request</param>
        /// <param name="sessionId">The unique session ID of a session in the access request</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>AccessRequestSessionActivityLog</returns>
        AccessRequestSessionActivityLog AuditLogGetAccessRequestSessionActivitiesBySessionIdAsync (string requestId, int? sessionId, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a set of access request Session log entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="accountId">Get activity that occurred for a specific account (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequestSessionActivityLog&gt;</returns>
        List<AccessRequestSessionActivityLog> AuditLogGetAccessRequestSessionActivityAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, int? accountId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the perma-link to the SPS portal for the session datat 
        /// </summary>
        /// <param name="requestId">The unique ID of the access request</param>
        /// <param name="sessionId">The unique session ID of a session in the access request</param>
        /// <returns>string</returns>
        string AuditLogGetAccessRequestSessionAuditPortalLinkAsync (string requestId, int? sessionId);
        /// <summary>
        /// Retrieve the session playback data required to replay the session recording matching this session id. 
        /// </summary>
        /// <param name="requestId">Unique identifier of the AccessRequest</param>
        /// <param name="sessionId">Unique ID of the session to replay</param>
        /// <returns>SessionPlaybackData</returns>
        SessionPlaybackData AuditLogGetAccessRequestSessionPlaybackAsync (string requestId, int? sessionId);
        /// <summary>
        /// Gets a list of audit log access request types 
        /// </summary>
        /// <returns>List&lt;AuditLogAccessRequestType&gt;</returns>
        List<AuditLogAccessRequestType> AuditLogGetAccessRequestTypes ();
        /// <summary>
        /// Gets a set of AccessRequest log entries 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequestLog&gt;</returns>
        List<AccessRequestLog> AuditLogGetAccessRequestsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a set of AccessRequest entries 
        /// </summary>
        /// <param name="id">id of specify request. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>AccessRequestLog</returns>
        AccessRequestLog AuditLogGetAccessRequestsByLogIdAsync (string id, string fields);
        /// <summary>
        /// Gets a set of AccountDiscoveryLog entries 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>AccountDiscoveryLog</returns>
        AccountDiscoveryLog AuditLogGetAccountDiscoveryLogByIdAsync (string id, string fields);
        /// <summary>
        /// Gets a set of AccountDiscoveryLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountDiscoveryLog&gt;</returns>
        List<AccountDiscoveryLog> AuditLogGetAccountDiscoveryLogsAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a set of ApplianceLog entries 
        /// </summary>
        /// <param name="category">Get activity that occurred for either audit category Pangaea.Data.Cassandra.ApplianceLogCategory.Patch or Pangaea.Data.Cassandra.ApplianceLogCategory.Appliance  (Preferred over filter)</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ApplianceLog&gt;</returns>
        List<ApplianceLog> AuditLogGetApplianceLogAsync (ApplianceLogCategory category, DateTime? startDate, DateTime? endDate, int? userId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets ApplianceLog entry by id 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="category">Get activity that occurred for either audit category Pangaea.Data.Cassandra.ApplianceLogCategory.Patch or Pangaea.Data.Cassandra.ApplianceLogCategory.Appliance  (Preferred over filter)</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>ApplianceLog</returns>
        ApplianceLog AuditLogGetApplianceLogByIdAsync (string id, ApplianceLogCategory category, string fields);
        /// <summary>
        /// Gets a set of ArchiveActivityLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ArchiveActivityLog&gt;</returns>
        List<ArchiveActivityLog> AuditLogGetArchiveActivityAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific ArchiveActivityLog entry 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>ArchiveActivityLog</returns>
        ArchiveActivityLog AuditLogGetArchiveActivityByIdAsync (string id, string fields);
        /// <summary>
        /// Gets a set of AssetDiscoveryLog entries by id 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>AssetDiscoveryLog</returns>
        AssetDiscoveryLog AuditLogGetAssetDiscoveryLogByIdAsync (string id, string fields);
        /// <summary>
        /// Gets a set of AssetDiscoveryLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetDiscoveryLog&gt;</returns>
        List<AssetDiscoveryLog> AuditLogGetAssetDiscoveryLogsAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the data and audit log maintenance settings. 
        /// </summary>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>AuditLogMaintenance</returns>
        AuditLogMaintenance AuditLogGetAuditLogMaintenanceAsync (string fields);
        /// <summary>
        /// Gets current state of the audit log stream service.  The audit log stream service is the ability for the audit log data to be requested by and streamed to a linked SPS appliance. 
        /// </summary>
        /// <returns>AuditLogStreamService</returns>
        AuditLogStreamService AuditLogGetAuditLogStreamServiceAsync ();
        /// <summary>
        /// Gets a list of audit log types 
        /// </summary>
        /// <returns>List&lt;AuditLogType&gt;</returns>
        List<AuditLogType> AuditLogGetAuditTypes ();
        /// <summary>
        /// Gets a specific LicenseHistoryLog entry 
        /// </summary>
        /// <param name="licenseType">The database ID of the object that was changed</param>
        /// <param name="logId">The database ID of the log entry</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>LicenseHistoryLog</returns>
        LicenseHistoryLog AuditLogGetByLicenseHistoryByLogIdAsync (LicensableModule licenseType, string logId, string fields);
        /// <summary>
        /// Gets a set of ObjectChangeLog entries for the passed objectType and objectId. 
        /// </summary>
        /// <param name="objectType">The type of object that was changed</param>
        /// <param name="objectId">The database ID of the object that was changed</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ObjectChangeLog&gt;</returns>
        List<ObjectChangeLog> AuditLogGetByObjectIdAsync (ObjectType objectType, string objectId, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific of ObjectChangeLog entry for the passed objectType and objectId and logId. 
        /// </summary>
        /// <param name="objectType">The type of object that was changed</param>
        /// <param name="objectId">The database ID of the object that was changed</param>
        /// <param name="logId">The database ID of the log entry</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>ObjectChangeLog</returns>
        ObjectChangeLog AuditLogGetByObjectLogIdAsync (ObjectType objectType, string objectId, string logId, string fields);
        /// <summary>
        /// Gets a set of ObjectChangeLog entries for the passed objectType. 
        /// </summary>
        /// <param name="objectType">The type of object that was changed</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ObjectChangeLog&gt;</returns>
        List<ObjectChangeLog> AuditLogGetByObjectTypeAsync (ObjectType objectType, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a set of directory sync activity logs 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DirectorySyncActivityLog&gt;</returns>
        List<DirectorySyncActivityLog> AuditLogGetDirectorySyncActivityAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets directory sync activity log entry for a specific task and ID 
        /// </summary>
        /// <param name="taskName">The type of task</param>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>DirectorySyncActivityLog</returns>
        DirectorySyncActivityLog AuditLogGetDirectorySyncActivityByIdAsync (TaskNames taskName, string id, string fields);
        /// <summary>
        /// Gets directory sync activity log entries for a specific task 
        /// </summary>
        /// <param name="taskName">The type of task</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>DirectorySyncActivityLog</returns>
        DirectorySyncActivityLog AuditLogGetDirectorySyncActivityByNameAsync (TaskNames taskName, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets accounts discovered from a particular discovery task 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredAccountLog&gt;</returns>
        List<DiscoveredAccountLog> AuditLogGetDiscoveredAccountsAsync (string id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the discovered assets from a specific job log 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredAsset&gt;</returns>
        List<DiscoveredAsset> AuditLogGetDiscoveredAssetsByIdAsync (string id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets Services discovered from a particular discovery task 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredServiceLog&gt;</returns>
        List<DiscoveredServiceLog> AuditLogGetDiscoveredServicesAsync (string id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of audit log discovery types 
        /// </summary>
        /// <returns>List&lt;AuditLogDiscoveryType&gt;</returns>
        List<AuditLogDiscoveryType> AuditLogGetDiscoveryTypes ();
        /// <summary>
        /// Gets a set of LicenseHistoryLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;LicenseHistoryLog&gt;</returns>
        List<LicenseHistoryLog> AuditLogGetLicenseHistoryAsync (DateTime? startDate, DateTime? endDate, int? userId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a set of LicenseHistoryLog entries 
        /// </summary>
        /// <param name="licenseType">Product license to get history for</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;LicenseHistoryLog&gt;</returns>
        List<LicenseHistoryLog> AuditLogGetLicenseHistoryByTypeAsync (LicensableModule licenseType, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a set of audit log login entries 
        /// </summary>
        /// <param name="startDate">Log time range start. Default 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Log time range end (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;LoginActivityLog&gt;</returns>
        List<LoginActivityLog> AuditLogGetLoginHistoryAsync (DateTime? startDate, DateTime? endDate, int? userId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a set of LoginActivityLog entries 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>LoginActivityLog</returns>
        LoginActivityLog AuditLogGetLoginHistoryByIdAsync (string id, string fields);
        /// <summary>
        /// Gets a set of ObjectChangeLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="accountId">Get activity that occurred for a specific account (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ObjectChangeLog&gt;</returns>
        List<ObjectChangeLog> AuditLogGetObjectChangesAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, int? accountId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a set of PasswordActivityLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="accountId">Get activity that occurred for a specific account (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordActivityLog&gt;</returns>
        List<PasswordActivityLog> AuditLogGetPasswordActivityAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, int? accountId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a set of PasswordActivityLog entries 
        /// </summary>
        /// <param name="taskName">The type of task</param>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AuditLogGetPasswordActivityByIdAsync (TaskNames taskName, string id, string fields);
        /// <summary>
        /// Gets password activity log entries for a specific task 
        /// </summary>
        /// <param name="taskName">The type of task</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>PasswordActivityLog</returns>
        PasswordActivityLog AuditLogGetPasswordActivityByNameAsync (TaskNames taskName, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a set of PatchHistory entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PatchHistory&gt;</returns>
        List<PatchHistory> AuditLogGetPatchHistoryAsync (DateTime? startDate, DateTime? endDate, int? userId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific patch history entry. 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>PatchHistory</returns>
        PatchHistory AuditLogGetPatchHistoryByIdAsync (string id, string fields);
        /// <summary>
        /// Gets a specific base64 encoded script 
        /// </summary>
        /// <param name="platformId">Unique ID of the platform</param>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <returns>string</returns>
        string AuditLogGetPlatformScriptByIdAsync (int? platformId, string id);
        /// <summary>
        /// Gets a set of platform script log entries 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PlatformScriptLog&gt;</returns>
        List<PlatformScriptLog> AuditLogGetPlatformScriptIndexAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets platform script log entries for a specific platform 
        /// </summary>
        /// <param name="platformId">Unique ID of the platform</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>PlatformScriptLog</returns>
        PlatformScriptLog AuditLogGetPlatformScriptLogByIdAsync (int? platformId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific script in raw format 
        /// </summary>
        /// <param name="platformId">Unique ID of the platform</param>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <returns>byte[]</returns>
        byte[] AuditLogGetRawPlatformScriptByIdAsync (int? platformId, string id);
        /// <summary>
        /// Gets a ServiceDiscoveryLog entry by id 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <returns>ServiceDiscoveryLog</returns>
        ServiceDiscoveryLog AuditLogGetServiceDiscoveryLogByIdAsync (string id, string fields);
        /// <summary>
        /// Gets a set of ServiceDiscoveryLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ServiceDiscoveryLog&gt;</returns>
        List<ServiceDiscoveryLog> AuditLogGetServiceDiscoveryLogsAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the audit log signing certificate 
        /// </summary>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>ServerCertificate</returns>
        ServerCertificate AuditLogGetSigningCertificateAsync (string fields);
        /// <summary>
        /// Gets the audit log signing certificate history 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ServerCertificateLog&gt;</returns>
        List<ServerCertificateLog> AuditLogGetSigningCertificateHistoryAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a set of SshKeyDiscoveryLog entries 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>SshKeyDiscoveryLog</returns>
        SshKeyDiscoveryLog AuditLogGetSshKeyDiscoveryLogByIdAsync (string id, string fields);
        /// <summary>
        /// Gets a set of SshKeyDiscoveryLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="accountId">Get activity that occurred for a specific account (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyDiscoveryLog&gt;</returns>
        List<SshKeyDiscoveryLog> AuditLogGetSshKeyDiscoveryLogsAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, int? accountId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Reset the audit log signing certificate 
        /// </summary>
        /// <returns>ServerCertificate</returns>
        ServerCertificate AuditLogResetSigningCertificateAsync ();
        /// <summary>
        /// Schedule a data maintenance job to run now. Supports cancellation during archiving by force complete of the cluster lock. 
        /// </summary>
        /// <param name="archiveOnly">If true, this is a test run and we will not purge audit logs after archive. Defaults to false.</param>
        /// <param name="syncAuditData">If true, sync the audit data after archive/purge completes. Defaults to false.</param>
        /// <returns></returns>
        void AuditLogRunNowAsync (bool? archiveOnly, bool? syncAuditData);
        /// <summary>
        /// Update the data and audit log maintenance settings. 
        /// </summary>
        /// <param name="body">Settings to save</param>
        /// <returns>AuditLogMaintenance</returns>
        AuditLogMaintenance AuditLogSaveAuditLogMaintenanceAsync (AuditLogMaintenance body);
        /// <summary>
        /// Update the audit log signing certificate 
        /// </summary>
        /// <param name="body">Settings to save</param>
        /// <returns>ServerCertificate</returns>
        ServerCertificate AuditLogSaveSigningCertificateAsync (ServerCertificate body);
        /// <summary>
        /// Gets a set of AuditSearchLog entries 
        /// </summary>
        /// <param name="category">Get activity that occurred for a specific audit category (Preferred over filter)</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over filter)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="accountId">Get activity that occurred for a specific account (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AuditSearchLog&gt;</returns>
        List<AuditSearchLog> AuditLogSearchAuditLogAsync (AuditLogCategory category, DateTime? startDate, DateTime? endDate, int? userId, int? assetId, int? accountId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Update the audit log streaming service. 
        /// </summary>
        /// <param name="body">Audit log streaming service</param>
        /// <returns>AuditLogStreamService</returns>
        AuditLogStreamService AuditLogUpdateAccessRequestBrokerAsync (AuditLogStreamService body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuditLogApi : IAuditLogApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuditLogApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuditLogApi(String basePath)
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
        /// Gets a set of access request activity log entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="accountId">Get activity that occurred for a specific account (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequestActivityLog&gt;</returns>
        public List<AccessRequestActivityLog> AuditLogGetAccessRequestActivitiesAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, int? accountId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/AccessRequests/Activities";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
 if (assetId != null) queryParams.Add("assetId", ApiClient.ParameterToString(assetId)); // query parameter
 if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestActivitiesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestActivitiesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessRequestActivityLog>) ApiClient.Deserialize(response.Content, typeof(List<AccessRequestActivityLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets access request activity log entry with given ID 
        /// </summary>
        /// <param name="requestId">The unique ID of the access request</param>
        /// <param name="logId">The database ID of the activity log entry</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>AccessRequestActivityLog</returns>
        public AccessRequestActivityLog AuditLogGetAccessRequestActivitiesByIdAsync (string requestId, string logId, string fields)
        {
            // verify the required parameter 'requestId' is set
            if (requestId == null) throw new ApiException(400, "Missing required parameter 'requestId' when calling AuditLogGetAccessRequestActivitiesByIdAsync");
            // verify the required parameter 'logId' is set
            if (logId == null) throw new ApiException(400, "Missing required parameter 'logId' when calling AuditLogGetAccessRequestActivitiesByIdAsync");
    
            var path = "/v4/AuditLog/AccessRequests/Activities/{requestId}/{logId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "requestId" + "}", ApiClient.ParameterToString(requestId));
path = path.Replace("{" + "logId" + "}", ApiClient.ParameterToString(logId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestActivitiesByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestActivitiesByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequestActivityLog) ApiClient.Deserialize(response.Content, typeof(AccessRequestActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Gets access request activity log entries for a request 
        /// </summary>
        /// <param name="requestId">The unique ID of the access request</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequestActivityLog&gt;</returns>
        public List<AccessRequestActivityLog> AuditLogGetAccessRequestActivitiesByRequestIdAsync (string requestId, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'requestId' is set
            if (requestId == null) throw new ApiException(400, "Missing required parameter 'requestId' when calling AuditLogGetAccessRequestActivitiesByRequestIdAsync");
    
            var path = "/v4/AuditLog/AccessRequests/Activities/{requestId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "requestId" + "}", ApiClient.ParameterToString(requestId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestActivitiesByRequestIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestActivitiesByRequestIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessRequestActivityLog>) ApiClient.Deserialize(response.Content, typeof(List<AccessRequestActivityLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of access request session activity log entries 
        /// </summary>
        /// <param name="requestId">The unique ID of the access request</param>
        /// <param name="logId">The database ID of the activity log entry</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequestSessionActivityLog&gt;</returns>
        public List<AccessRequestSessionActivityLog> AuditLogGetAccessRequestActivitySessionLogAsync (string requestId, string logId, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'requestId' is set
            if (requestId == null) throw new ApiException(400, "Missing required parameter 'requestId' when calling AuditLogGetAccessRequestActivitySessionLogAsync");
            // verify the required parameter 'logId' is set
            if (logId == null) throw new ApiException(400, "Missing required parameter 'logId' when calling AuditLogGetAccessRequestActivitySessionLogAsync");
    
            var path = "/v4/AuditLog/AccessRequests/Activities/{requestId}/{logId}/SessionLog";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "requestId" + "}", ApiClient.ParameterToString(requestId));
path = path.Replace("{" + "logId" + "}", ApiClient.ParameterToString(logId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestActivitySessionLogAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestActivitySessionLogAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessRequestSessionActivityLog>) ApiClient.Deserialize(response.Content, typeof(List<AccessRequestSessionActivityLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets access request session activity log entry with given ID 
        /// </summary>
        /// <param name="requestId">The unique ID of the access request</param>
        /// <param name="sessionId">The unique session ID of a session in the access request</param>
        /// <param name="logId">The database ID of the activity log entry</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>AccessRequestSessionActivityLog</returns>
        public AccessRequestSessionActivityLog AuditLogGetAccessRequestSessionActivitiesByIdAsync (string requestId, int? sessionId, string logId, string fields)
        {
            // verify the required parameter 'requestId' is set
            if (requestId == null) throw new ApiException(400, "Missing required parameter 'requestId' when calling AuditLogGetAccessRequestSessionActivitiesByIdAsync");
            // verify the required parameter 'sessionId' is set
            if (sessionId == null) throw new ApiException(400, "Missing required parameter 'sessionId' when calling AuditLogGetAccessRequestSessionActivitiesByIdAsync");
            // verify the required parameter 'logId' is set
            if (logId == null) throw new ApiException(400, "Missing required parameter 'logId' when calling AuditLogGetAccessRequestSessionActivitiesByIdAsync");
    
            var path = "/v4/AuditLog/AccessRequests/Sessions/{requestId}/{sessionId}/{logId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "requestId" + "}", ApiClient.ParameterToString(requestId));
path = path.Replace("{" + "sessionId" + "}", ApiClient.ParameterToString(sessionId));
path = path.Replace("{" + "logId" + "}", ApiClient.ParameterToString(logId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestSessionActivitiesByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestSessionActivitiesByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequestSessionActivityLog) ApiClient.Deserialize(response.Content, typeof(AccessRequestSessionActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Gets access request session activity log entries for a request 
        /// </summary>
        /// <param name="requestId">The unique ID of the access request</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequestSessionActivityLog&gt;</returns>
        public List<AccessRequestSessionActivityLog> AuditLogGetAccessRequestSessionActivitiesByRequestIdAsync (string requestId, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'requestId' is set
            if (requestId == null) throw new ApiException(400, "Missing required parameter 'requestId' when calling AuditLogGetAccessRequestSessionActivitiesByRequestIdAsync");
    
            var path = "/v4/AuditLog/AccessRequests/Sessions/{requestId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "requestId" + "}", ApiClient.ParameterToString(requestId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestSessionActivitiesByRequestIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestSessionActivitiesByRequestIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessRequestSessionActivityLog>) ApiClient.Deserialize(response.Content, typeof(List<AccessRequestSessionActivityLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets access request session activity log entries for a request 
        /// </summary>
        /// <param name="requestId">The unique ID of the access request</param>
        /// <param name="sessionId">The unique session ID of a session in the access request</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>AccessRequestSessionActivityLog</returns>
        public AccessRequestSessionActivityLog AuditLogGetAccessRequestSessionActivitiesBySessionIdAsync (string requestId, int? sessionId, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'requestId' is set
            if (requestId == null) throw new ApiException(400, "Missing required parameter 'requestId' when calling AuditLogGetAccessRequestSessionActivitiesBySessionIdAsync");
            // verify the required parameter 'sessionId' is set
            if (sessionId == null) throw new ApiException(400, "Missing required parameter 'sessionId' when calling AuditLogGetAccessRequestSessionActivitiesBySessionIdAsync");
    
            var path = "/v4/AuditLog/AccessRequests/Sessions/{requestId}/{sessionId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "requestId" + "}", ApiClient.ParameterToString(requestId));
path = path.Replace("{" + "sessionId" + "}", ApiClient.ParameterToString(sessionId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestSessionActivitiesBySessionIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestSessionActivitiesBySessionIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequestSessionActivityLog) ApiClient.Deserialize(response.Content, typeof(AccessRequestSessionActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of access request Session log entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="accountId">Get activity that occurred for a specific account (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequestSessionActivityLog&gt;</returns>
        public List<AccessRequestSessionActivityLog> AuditLogGetAccessRequestSessionActivityAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, int? accountId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/AccessRequests/Sessions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
 if (assetId != null) queryParams.Add("assetId", ApiClient.ParameterToString(assetId)); // query parameter
 if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestSessionActivityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestSessionActivityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessRequestSessionActivityLog>) ApiClient.Deserialize(response.Content, typeof(List<AccessRequestSessionActivityLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets the perma-link to the SPS portal for the session datat 
        /// </summary>
        /// <param name="requestId">The unique ID of the access request</param>
        /// <param name="sessionId">The unique session ID of a session in the access request</param>
        /// <returns>string</returns>
        public string AuditLogGetAccessRequestSessionAuditPortalLinkAsync (string requestId, int? sessionId)
        {
            // verify the required parameter 'requestId' is set
            if (requestId == null) throw new ApiException(400, "Missing required parameter 'requestId' when calling AuditLogGetAccessRequestSessionAuditPortalLinkAsync");
            // verify the required parameter 'sessionId' is set
            if (sessionId == null) throw new ApiException(400, "Missing required parameter 'sessionId' when calling AuditLogGetAccessRequestSessionAuditPortalLinkAsync");
    
            var path = "/v4/AuditLog/AccessRequests/Sessions/{requestId}/{sessionId}/AuditPortalLink";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "requestId" + "}", ApiClient.ParameterToString(requestId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestSessionAuditPortalLinkAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestSessionAuditPortalLinkAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the session playback data required to replay the session recording matching this session id. 
        /// </summary>
        /// <param name="requestId">Unique identifier of the AccessRequest</param>
        /// <param name="sessionId">Unique ID of the session to replay</param>
        /// <returns>SessionPlaybackData</returns>
        public SessionPlaybackData AuditLogGetAccessRequestSessionPlaybackAsync (string requestId, int? sessionId)
        {
            // verify the required parameter 'requestId' is set
            if (requestId == null) throw new ApiException(400, "Missing required parameter 'requestId' when calling AuditLogGetAccessRequestSessionPlaybackAsync");
            // verify the required parameter 'sessionId' is set
            if (sessionId == null) throw new ApiException(400, "Missing required parameter 'sessionId' when calling AuditLogGetAccessRequestSessionPlaybackAsync");
    
            var path = "/v4/AuditLog/AccessRequests/Sessions/{requestId}/{sessionId}/Playback";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "requestId" + "}", ApiClient.ParameterToString(requestId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestSessionPlaybackAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestSessionPlaybackAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SessionPlaybackData) ApiClient.Deserialize(response.Content, typeof(SessionPlaybackData), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of audit log access request types 
        /// </summary>
        /// <returns>List&lt;AuditLogAccessRequestType&gt;</returns>
        public List<AuditLogAccessRequestType> AuditLogGetAccessRequestTypes ()
        {
    
            var path = "/v4/AuditLog/AccessRequests";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AuditLogAccessRequestType>) ApiClient.Deserialize(response.Content, typeof(List<AuditLogAccessRequestType>), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of AccessRequest log entries 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequestLog&gt;</returns>
        public List<AccessRequestLog> AuditLogGetAccessRequestsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/AccessRequests/Requests";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessRequestLog>) ApiClient.Deserialize(response.Content, typeof(List<AccessRequestLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of AccessRequest entries 
        /// </summary>
        /// <param name="id">id of specify request. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>AccessRequestLog</returns>
        public AccessRequestLog AuditLogGetAccessRequestsByLogIdAsync (string id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetAccessRequestsByLogIdAsync");
    
            var path = "/v4/AuditLog/AccessRequests/Requests/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestsByLogIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccessRequestsByLogIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccessRequestLog) ApiClient.Deserialize(response.Content, typeof(AccessRequestLog), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of AccountDiscoveryLog entries 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>AccountDiscoveryLog</returns>
        public AccountDiscoveryLog AuditLogGetAccountDiscoveryLogByIdAsync (string id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetAccountDiscoveryLogByIdAsync");
    
            var path = "/v4/AuditLog/Discovery/Accounts/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccountDiscoveryLogByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccountDiscoveryLogByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountDiscoveryLog) ApiClient.Deserialize(response.Content, typeof(AccountDiscoveryLog), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of AccountDiscoveryLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountDiscoveryLog&gt;</returns>
        public List<AccountDiscoveryLog> AuditLogGetAccountDiscoveryLogsAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/Discovery/Accounts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
 if (assetId != null) queryParams.Add("assetId", ApiClient.ParameterToString(assetId)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccountDiscoveryLogsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAccountDiscoveryLogsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountDiscoveryLog>) ApiClient.Deserialize(response.Content, typeof(List<AccountDiscoveryLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of ApplianceLog entries 
        /// </summary>
        /// <param name="category">Get activity that occurred for either audit category Pangaea.Data.Cassandra.ApplianceLogCategory.Patch or Pangaea.Data.Cassandra.ApplianceLogCategory.Appliance  (Preferred over filter)</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ApplianceLog&gt;</returns>
        public List<ApplianceLog> AuditLogGetApplianceLogAsync (ApplianceLogCategory category, DateTime? startDate, DateTime? endDate, int? userId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/Appliances";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (category != null) queryParams.Add("category", ApiClient.ParameterToString(category)); // query parameter
 if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetApplianceLogAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetApplianceLogAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ApplianceLog>) ApiClient.Deserialize(response.Content, typeof(List<ApplianceLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets ApplianceLog entry by id 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="category">Get activity that occurred for either audit category Pangaea.Data.Cassandra.ApplianceLogCategory.Patch or Pangaea.Data.Cassandra.ApplianceLogCategory.Appliance  (Preferred over filter)</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>ApplianceLog</returns>
        public ApplianceLog AuditLogGetApplianceLogByIdAsync (string id, ApplianceLogCategory category, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetApplianceLogByIdAsync");
    
            var path = "/v4/AuditLog/Appliances/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (category != null) queryParams.Add("category", ApiClient.ParameterToString(category)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetApplianceLogByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetApplianceLogByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApplianceLog) ApiClient.Deserialize(response.Content, typeof(ApplianceLog), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of ArchiveActivityLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ArchiveActivityLog&gt;</returns>
        public List<ArchiveActivityLog> AuditLogGetArchiveActivityAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/Archives";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
 if (assetId != null) queryParams.Add("assetId", ApiClient.ParameterToString(assetId)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetArchiveActivityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetArchiveActivityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ArchiveActivityLog>) ApiClient.Deserialize(response.Content, typeof(List<ArchiveActivityLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific ArchiveActivityLog entry 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>ArchiveActivityLog</returns>
        public ArchiveActivityLog AuditLogGetArchiveActivityByIdAsync (string id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetArchiveActivityByIdAsync");
    
            var path = "/v4/AuditLog/Archives/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetArchiveActivityByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetArchiveActivityByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ArchiveActivityLog) ApiClient.Deserialize(response.Content, typeof(ArchiveActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of AssetDiscoveryLog entries by id 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>AssetDiscoveryLog</returns>
        public AssetDiscoveryLog AuditLogGetAssetDiscoveryLogByIdAsync (string id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetAssetDiscoveryLogByIdAsync");
    
            var path = "/v4/AuditLog/Discovery/Assets/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAssetDiscoveryLogByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAssetDiscoveryLogByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AssetDiscoveryLog) ApiClient.Deserialize(response.Content, typeof(AssetDiscoveryLog), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of AssetDiscoveryLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetDiscoveryLog&gt;</returns>
        public List<AssetDiscoveryLog> AuditLogGetAssetDiscoveryLogsAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/Discovery/Assets";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
 if (assetId != null) queryParams.Add("assetId", ApiClient.ParameterToString(assetId)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAssetDiscoveryLogsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAssetDiscoveryLogsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetDiscoveryLog>) ApiClient.Deserialize(response.Content, typeof(List<AssetDiscoveryLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets the data and audit log maintenance settings. 
        /// </summary>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>AuditLogMaintenance</returns>
        public AuditLogMaintenance AuditLogGetAuditLogMaintenanceAsync (string fields)
        {
    
            var path = "/v4/AuditLog/Maintenance";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAuditLogMaintenanceAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAuditLogMaintenanceAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AuditLogMaintenance) ApiClient.Deserialize(response.Content, typeof(AuditLogMaintenance), response.Headers);
        }
    
        /// <summary>
        /// Gets current state of the audit log stream service.  The audit log stream service is the ability for the audit log data to be requested by and streamed to a linked SPS appliance. 
        /// </summary>
        /// <returns>AuditLogStreamService</returns>
        public AuditLogStreamService AuditLogGetAuditLogStreamServiceAsync ()
        {
    
            var path = "/v4/AuditLog/StreamService";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAuditLogStreamServiceAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAuditLogStreamServiceAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AuditLogStreamService) ApiClient.Deserialize(response.Content, typeof(AuditLogStreamService), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of audit log types 
        /// </summary>
        /// <returns>List&lt;AuditLogType&gt;</returns>
        public List<AuditLogType> AuditLogGetAuditTypes ()
        {
    
            var path = "/v4/AuditLog";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAuditTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetAuditTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AuditLogType>) ApiClient.Deserialize(response.Content, typeof(List<AuditLogType>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific LicenseHistoryLog entry 
        /// </summary>
        /// <param name="licenseType">The database ID of the object that was changed</param>
        /// <param name="logId">The database ID of the log entry</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>LicenseHistoryLog</returns>
        public LicenseHistoryLog AuditLogGetByLicenseHistoryByLogIdAsync (LicensableModule licenseType, string logId, string fields)
        {
            // verify the required parameter 'licenseType' is set
            if (licenseType == null) throw new ApiException(400, "Missing required parameter 'licenseType' when calling AuditLogGetByLicenseHistoryByLogIdAsync");
            // verify the required parameter 'logId' is set
            if (logId == null) throw new ApiException(400, "Missing required parameter 'logId' when calling AuditLogGetByLicenseHistoryByLogIdAsync");
    
            var path = "/v4/AuditLog/Licenses/{licenseType}/{logId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "licenseType" + "}", ApiClient.ParameterToString(licenseType));
path = path.Replace("{" + "logId" + "}", ApiClient.ParameterToString(logId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetByLicenseHistoryByLogIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetByLicenseHistoryByLogIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LicenseHistoryLog) ApiClient.Deserialize(response.Content, typeof(LicenseHistoryLog), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of ObjectChangeLog entries for the passed objectType and objectId. 
        /// </summary>
        /// <param name="objectType">The type of object that was changed</param>
        /// <param name="objectId">The database ID of the object that was changed</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ObjectChangeLog&gt;</returns>
        public List<ObjectChangeLog> AuditLogGetByObjectIdAsync (ObjectType objectType, string objectId, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'objectType' is set
            if (objectType == null) throw new ApiException(400, "Missing required parameter 'objectType' when calling AuditLogGetByObjectIdAsync");
            // verify the required parameter 'objectId' is set
            if (objectId == null) throw new ApiException(400, "Missing required parameter 'objectId' when calling AuditLogGetByObjectIdAsync");
    
            var path = "/v4/AuditLog/ObjectChanges/{objectType}/{objectId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "objectType" + "}", ApiClient.ParameterToString(objectType));
path = path.Replace("{" + "objectId" + "}", ApiClient.ParameterToString(objectId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetByObjectIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetByObjectIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ObjectChangeLog>) ApiClient.Deserialize(response.Content, typeof(List<ObjectChangeLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific of ObjectChangeLog entry for the passed objectType and objectId and logId. 
        /// </summary>
        /// <param name="objectType">The type of object that was changed</param>
        /// <param name="objectId">The database ID of the object that was changed</param>
        /// <param name="logId">The database ID of the log entry</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>ObjectChangeLog</returns>
        public ObjectChangeLog AuditLogGetByObjectLogIdAsync (ObjectType objectType, string objectId, string logId, string fields)
        {
            // verify the required parameter 'objectType' is set
            if (objectType == null) throw new ApiException(400, "Missing required parameter 'objectType' when calling AuditLogGetByObjectLogIdAsync");
            // verify the required parameter 'objectId' is set
            if (objectId == null) throw new ApiException(400, "Missing required parameter 'objectId' when calling AuditLogGetByObjectLogIdAsync");
            // verify the required parameter 'logId' is set
            if (logId == null) throw new ApiException(400, "Missing required parameter 'logId' when calling AuditLogGetByObjectLogIdAsync");
    
            var path = "/v4/AuditLog/ObjectChanges/{objectType}/{objectId}/{logId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "objectType" + "}", ApiClient.ParameterToString(objectType));
path = path.Replace("{" + "objectId" + "}", ApiClient.ParameterToString(objectId));
path = path.Replace("{" + "logId" + "}", ApiClient.ParameterToString(logId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetByObjectLogIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetByObjectLogIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ObjectChangeLog) ApiClient.Deserialize(response.Content, typeof(ObjectChangeLog), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of ObjectChangeLog entries for the passed objectType. 
        /// </summary>
        /// <param name="objectType">The type of object that was changed</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ObjectChangeLog&gt;</returns>
        public List<ObjectChangeLog> AuditLogGetByObjectTypeAsync (ObjectType objectType, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'objectType' is set
            if (objectType == null) throw new ApiException(400, "Missing required parameter 'objectType' when calling AuditLogGetByObjectTypeAsync");
    
            var path = "/v4/AuditLog/ObjectChanges/{objectType}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "objectType" + "}", ApiClient.ParameterToString(objectType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetByObjectTypeAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetByObjectTypeAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ObjectChangeLog>) ApiClient.Deserialize(response.Content, typeof(List<ObjectChangeLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of directory sync activity logs 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DirectorySyncActivityLog&gt;</returns>
        public List<DirectorySyncActivityLog> AuditLogGetDirectorySyncActivityAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/DirectorySync";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
 if (assetId != null) queryParams.Add("assetId", ApiClient.ParameterToString(assetId)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetDirectorySyncActivityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetDirectorySyncActivityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DirectorySyncActivityLog>) ApiClient.Deserialize(response.Content, typeof(List<DirectorySyncActivityLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets directory sync activity log entry for a specific task and ID 
        /// </summary>
        /// <param name="taskName">The type of task</param>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>DirectorySyncActivityLog</returns>
        public DirectorySyncActivityLog AuditLogGetDirectorySyncActivityByIdAsync (TaskNames taskName, string id, string fields)
        {
            // verify the required parameter 'taskName' is set
            if (taskName == null) throw new ApiException(400, "Missing required parameter 'taskName' when calling AuditLogGetDirectorySyncActivityByIdAsync");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetDirectorySyncActivityByIdAsync");
    
            var path = "/v4/AuditLog/DirectorySync/{taskName}/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetDirectorySyncActivityByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetDirectorySyncActivityByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DirectorySyncActivityLog) ApiClient.Deserialize(response.Content, typeof(DirectorySyncActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Gets directory sync activity log entries for a specific task 
        /// </summary>
        /// <param name="taskName">The type of task</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>DirectorySyncActivityLog</returns>
        public DirectorySyncActivityLog AuditLogGetDirectorySyncActivityByNameAsync (TaskNames taskName, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'taskName' is set
            if (taskName == null) throw new ApiException(400, "Missing required parameter 'taskName' when calling AuditLogGetDirectorySyncActivityByNameAsync");
    
            var path = "/v4/AuditLog/DirectorySync/{taskName}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetDirectorySyncActivityByNameAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetDirectorySyncActivityByNameAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DirectorySyncActivityLog) ApiClient.Deserialize(response.Content, typeof(DirectorySyncActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Gets accounts discovered from a particular discovery task 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredAccountLog&gt;</returns>
        public List<DiscoveredAccountLog> AuditLogGetDiscoveredAccountsAsync (string id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetDiscoveredAccountsAsync");
    
            var path = "/v4/AuditLog/Discovery/Accounts/{id}/DiscoveredAccounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetDiscoveredAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetDiscoveredAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredAccountLog>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredAccountLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets the discovered assets from a specific job log 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredAsset&gt;</returns>
        public List<DiscoveredAsset> AuditLogGetDiscoveredAssetsByIdAsync (string id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetDiscoveredAssetsByIdAsync");
    
            var path = "/v4/AuditLog/Discovery/Assets/{id}/DiscoveredAssets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetDiscoveredAssetsByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetDiscoveredAssetsByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredAsset>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredAsset>), response.Headers);
        }
    
        /// <summary>
        /// Gets Services discovered from a particular discovery task 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;DiscoveredServiceLog&gt;</returns>
        public List<DiscoveredServiceLog> AuditLogGetDiscoveredServicesAsync (string id, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetDiscoveredServicesAsync");
    
            var path = "/v4/AuditLog/Discovery/Services/{id}/DiscoveredServices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetDiscoveredServicesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetDiscoveredServicesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DiscoveredServiceLog>) ApiClient.Deserialize(response.Content, typeof(List<DiscoveredServiceLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of audit log discovery types 
        /// </summary>
        /// <returns>List&lt;AuditLogDiscoveryType&gt;</returns>
        public List<AuditLogDiscoveryType> AuditLogGetDiscoveryTypes ()
        {
    
            var path = "/v4/AuditLog/Discovery";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetDiscoveryTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetDiscoveryTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AuditLogDiscoveryType>) ApiClient.Deserialize(response.Content, typeof(List<AuditLogDiscoveryType>), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of LicenseHistoryLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;LicenseHistoryLog&gt;</returns>
        public List<LicenseHistoryLog> AuditLogGetLicenseHistoryAsync (DateTime? startDate, DateTime? endDate, int? userId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/Licenses";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetLicenseHistoryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetLicenseHistoryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<LicenseHistoryLog>) ApiClient.Deserialize(response.Content, typeof(List<LicenseHistoryLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of LicenseHistoryLog entries 
        /// </summary>
        /// <param name="licenseType">Product license to get history for</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;LicenseHistoryLog&gt;</returns>
        public List<LicenseHistoryLog> AuditLogGetLicenseHistoryByTypeAsync (LicensableModule licenseType, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'licenseType' is set
            if (licenseType == null) throw new ApiException(400, "Missing required parameter 'licenseType' when calling AuditLogGetLicenseHistoryByTypeAsync");
    
            var path = "/v4/AuditLog/Licenses/{licenseType}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "licenseType" + "}", ApiClient.ParameterToString(licenseType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetLicenseHistoryByTypeAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetLicenseHistoryByTypeAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<LicenseHistoryLog>) ApiClient.Deserialize(response.Content, typeof(List<LicenseHistoryLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of audit log login entries 
        /// </summary>
        /// <param name="startDate">Log time range start. Default 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Log time range end (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;LoginActivityLog&gt;</returns>
        public List<LoginActivityLog> AuditLogGetLoginHistoryAsync (DateTime? startDate, DateTime? endDate, int? userId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/Logins";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetLoginHistoryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetLoginHistoryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<LoginActivityLog>) ApiClient.Deserialize(response.Content, typeof(List<LoginActivityLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of LoginActivityLog entries 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>LoginActivityLog</returns>
        public LoginActivityLog AuditLogGetLoginHistoryByIdAsync (string id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetLoginHistoryByIdAsync");
    
            var path = "/v4/AuditLog/Logins/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetLoginHistoryByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetLoginHistoryByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (LoginActivityLog) ApiClient.Deserialize(response.Content, typeof(LoginActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of ObjectChangeLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="accountId">Get activity that occurred for a specific account (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ObjectChangeLog&gt;</returns>
        public List<ObjectChangeLog> AuditLogGetObjectChangesAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, int? accountId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/ObjectChanges";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
 if (assetId != null) queryParams.Add("assetId", ApiClient.ParameterToString(assetId)); // query parameter
 if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetObjectChangesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetObjectChangesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ObjectChangeLog>) ApiClient.Deserialize(response.Content, typeof(List<ObjectChangeLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of PasswordActivityLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="accountId">Get activity that occurred for a specific account (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PasswordActivityLog&gt;</returns>
        public List<PasswordActivityLog> AuditLogGetPasswordActivityAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, int? accountId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/Passwords";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
 if (assetId != null) queryParams.Add("assetId", ApiClient.ParameterToString(assetId)); // query parameter
 if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPasswordActivityAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPasswordActivityAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PasswordActivityLog>) ApiClient.Deserialize(response.Content, typeof(List<PasswordActivityLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of PasswordActivityLog entries 
        /// </summary>
        /// <param name="taskName">The type of task</param>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AuditLogGetPasswordActivityByIdAsync (TaskNames taskName, string id, string fields)
        {
            // verify the required parameter 'taskName' is set
            if (taskName == null) throw new ApiException(400, "Missing required parameter 'taskName' when calling AuditLogGetPasswordActivityByIdAsync");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetPasswordActivityByIdAsync");
    
            var path = "/v4/AuditLog/Passwords/{taskName}/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPasswordActivityByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPasswordActivityByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Gets password activity log entries for a specific task 
        /// </summary>
        /// <param name="taskName">The type of task</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>PasswordActivityLog</returns>
        public PasswordActivityLog AuditLogGetPasswordActivityByNameAsync (TaskNames taskName, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'taskName' is set
            if (taskName == null) throw new ApiException(400, "Missing required parameter 'taskName' when calling AuditLogGetPasswordActivityByNameAsync");
    
            var path = "/v4/AuditLog/Passwords/{taskName}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPasswordActivityByNameAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPasswordActivityByNameAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PasswordActivityLog) ApiClient.Deserialize(response.Content, typeof(PasswordActivityLog), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of PatchHistory entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PatchHistory&gt;</returns>
        public List<PatchHistory> AuditLogGetPatchHistoryAsync (DateTime? startDate, DateTime? endDate, int? userId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/Patches";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPatchHistoryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPatchHistoryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PatchHistory>) ApiClient.Deserialize(response.Content, typeof(List<PatchHistory>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific patch history entry. 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>PatchHistory</returns>
        public PatchHistory AuditLogGetPatchHistoryByIdAsync (string id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetPatchHistoryByIdAsync");
    
            var path = "/v4/AuditLog/Patches/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPatchHistoryByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPatchHistoryByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PatchHistory) ApiClient.Deserialize(response.Content, typeof(PatchHistory), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific base64 encoded script 
        /// </summary>
        /// <param name="platformId">Unique ID of the platform</param>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <returns>string</returns>
        public string AuditLogGetPlatformScriptByIdAsync (int? platformId, string id)
        {
            // verify the required parameter 'platformId' is set
            if (platformId == null) throw new ApiException(400, "Missing required parameter 'platformId' when calling AuditLogGetPlatformScriptByIdAsync");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetPlatformScriptByIdAsync");
    
            var path = "/v4/AuditLog/PlatformScripts/{platformId}/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platformId" + "}", ApiClient.ParameterToString(platformId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPlatformScriptByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPlatformScriptByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of platform script log entries 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PlatformScriptLog&gt;</returns>
        public List<PlatformScriptLog> AuditLogGetPlatformScriptIndexAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/PlatformScripts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPlatformScriptIndexAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPlatformScriptIndexAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PlatformScriptLog>) ApiClient.Deserialize(response.Content, typeof(List<PlatformScriptLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets platform script log entries for a specific platform 
        /// </summary>
        /// <param name="platformId">Unique ID of the platform</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>PlatformScriptLog</returns>
        public PlatformScriptLog AuditLogGetPlatformScriptLogByIdAsync (int? platformId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'platformId' is set
            if (platformId == null) throw new ApiException(400, "Missing required parameter 'platformId' when calling AuditLogGetPlatformScriptLogByIdAsync");
    
            var path = "/v4/AuditLog/PlatformScripts/{platformId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platformId" + "}", ApiClient.ParameterToString(platformId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPlatformScriptLogByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetPlatformScriptLogByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PlatformScriptLog) ApiClient.Deserialize(response.Content, typeof(PlatformScriptLog), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific script in raw format 
        /// </summary>
        /// <param name="platformId">Unique ID of the platform</param>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <returns>byte[]</returns>
        public byte[] AuditLogGetRawPlatformScriptByIdAsync (int? platformId, string id)
        {
            // verify the required parameter 'platformId' is set
            if (platformId == null) throw new ApiException(400, "Missing required parameter 'platformId' when calling AuditLogGetRawPlatformScriptByIdAsync");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetRawPlatformScriptByIdAsync");
    
            var path = "/v4/AuditLog/PlatformScripts/{platformId}/{id}/Raw";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "platformId" + "}", ApiClient.ParameterToString(platformId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetRawPlatformScriptByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetRawPlatformScriptByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Gets a ServiceDiscoveryLog entry by id 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <returns>ServiceDiscoveryLog</returns>
        public ServiceDiscoveryLog AuditLogGetServiceDiscoveryLogByIdAsync (string id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetServiceDiscoveryLogByIdAsync");
    
            var path = "/v4/AuditLog/Discovery/Services/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetServiceDiscoveryLogByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetServiceDiscoveryLogByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServiceDiscoveryLog) ApiClient.Deserialize(response.Content, typeof(ServiceDiscoveryLog), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of ServiceDiscoveryLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ServiceDiscoveryLog&gt;</returns>
        public List<ServiceDiscoveryLog> AuditLogGetServiceDiscoveryLogsAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/Discovery/Services";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
 if (assetId != null) queryParams.Add("assetId", ApiClient.ParameterToString(assetId)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetServiceDiscoveryLogsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetServiceDiscoveryLogsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ServiceDiscoveryLog>) ApiClient.Deserialize(response.Content, typeof(List<ServiceDiscoveryLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets the audit log signing certificate 
        /// </summary>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>ServerCertificate</returns>
        public ServerCertificate AuditLogGetSigningCertificateAsync (string fields)
        {
    
            var path = "/v4/AuditLog/Retention/SigningCertificate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetSigningCertificateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetSigningCertificateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServerCertificate) ApiClient.Deserialize(response.Content, typeof(ServerCertificate), response.Headers);
        }
    
        /// <summary>
        /// Gets the audit log signing certificate history 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], ()</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ServerCertificateLog&gt;</returns>
        public List<ServerCertificateLog> AuditLogGetSigningCertificateHistoryAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/Retention/SigningCertificate/History";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetSigningCertificateHistoryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetSigningCertificateHistoryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ServerCertificateLog>) ApiClient.Deserialize(response.Content, typeof(List<ServerCertificateLog>), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of SshKeyDiscoveryLog entries 
        /// </summary>
        /// <param name="id">Database Id of the log to retrieve</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <returns>SshKeyDiscoveryLog</returns>
        public SshKeyDiscoveryLog AuditLogGetSshKeyDiscoveryLogByIdAsync (string id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AuditLogGetSshKeyDiscoveryLogByIdAsync");
    
            var path = "/v4/AuditLog/Discovery/SshKeys/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetSshKeyDiscoveryLogByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetSshKeyDiscoveryLogByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SshKeyDiscoveryLog) ApiClient.Deserialize(response.Content, typeof(SshKeyDiscoveryLog), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of SshKeyDiscoveryLog entries 
        /// </summary>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="accountId">Get activity that occurred for a specific account (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SshKeyDiscoveryLog&gt;</returns>
        public List<SshKeyDiscoveryLog> AuditLogGetSshKeyDiscoveryLogsAsync (DateTime? startDate, DateTime? endDate, int? userId, int? assetId, int? accountId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/Discovery/SshKeys";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
 if (assetId != null) queryParams.Add("assetId", ApiClient.ParameterToString(assetId)); // query parameter
 if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetSshKeyDiscoveryLogsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogGetSshKeyDiscoveryLogsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SshKeyDiscoveryLog>) ApiClient.Deserialize(response.Content, typeof(List<SshKeyDiscoveryLog>), response.Headers);
        }
    
        /// <summary>
        /// Reset the audit log signing certificate 
        /// </summary>
        /// <returns>ServerCertificate</returns>
        public ServerCertificate AuditLogResetSigningCertificateAsync ()
        {
    
            var path = "/v4/AuditLog/Retention/SigningCertificate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogResetSigningCertificateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogResetSigningCertificateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServerCertificate) ApiClient.Deserialize(response.Content, typeof(ServerCertificate), response.Headers);
        }
    
        /// <summary>
        /// Schedule a data maintenance job to run now. Supports cancellation during archiving by force complete of the cluster lock. 
        /// </summary>
        /// <param name="archiveOnly">If true, this is a test run and we will not purge audit logs after archive. Defaults to false.</param>
        /// <param name="syncAuditData">If true, sync the audit data after archive/purge completes. Defaults to false.</param>
        /// <returns></returns>
        public void AuditLogRunNowAsync (bool? archiveOnly, bool? syncAuditData)
        {
    
            var path = "/v4/AuditLog/Maintenance/RunNow";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (archiveOnly != null) queryParams.Add("archiveOnly", ApiClient.ParameterToString(archiveOnly)); // query parameter
 if (syncAuditData != null) queryParams.Add("syncAuditData", ApiClient.ParameterToString(syncAuditData)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogRunNowAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogRunNowAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update the data and audit log maintenance settings. 
        /// </summary>
        /// <param name="body">Settings to save</param>
        /// <returns>AuditLogMaintenance</returns>
        public AuditLogMaintenance AuditLogSaveAuditLogMaintenanceAsync (AuditLogMaintenance body)
        {
    
            var path = "/v4/AuditLog/Maintenance";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogSaveAuditLogMaintenanceAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogSaveAuditLogMaintenanceAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AuditLogMaintenance) ApiClient.Deserialize(response.Content, typeof(AuditLogMaintenance), response.Headers);
        }
    
        /// <summary>
        /// Update the audit log signing certificate 
        /// </summary>
        /// <param name="body">Settings to save</param>
        /// <returns>ServerCertificate</returns>
        public ServerCertificate AuditLogSaveSigningCertificateAsync (ServerCertificate body)
        {
    
            var path = "/v4/AuditLog/Retention/SigningCertificate";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogSaveSigningCertificateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogSaveSigningCertificateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServerCertificate) ApiClient.Deserialize(response.Content, typeof(ServerCertificate), response.Headers);
        }
    
        /// <summary>
        /// Gets a set of AuditSearchLog entries 
        /// </summary>
        /// <param name="category">Get activity that occurred for a specific audit category (Preferred over filter)</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over filter)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="userId">Get activity that occurred for a specific user (Preferred over filter)</param>
        /// <param name="assetId">Get activity that occurred for a specific asset (Preferred over filter)</param>
        /// <param name="accountId">Get activity that occurred for a specific account (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AuditSearchLog&gt;</returns>
        public List<AuditSearchLog> AuditLogSearchAuditLogAsync (AuditLogCategory category, DateTime? startDate, DateTime? endDate, int? userId, int? assetId, int? accountId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/AuditLog/Search";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (category != null) queryParams.Add("category", ApiClient.ParameterToString(category)); // query parameter
 if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (userId != null) queryParams.Add("userId", ApiClient.ParameterToString(userId)); // query parameter
 if (assetId != null) queryParams.Add("assetId", ApiClient.ParameterToString(assetId)); // query parameter
 if (accountId != null) queryParams.Add("accountId", ApiClient.ParameterToString(accountId)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogSearchAuditLogAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogSearchAuditLogAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AuditSearchLog>) ApiClient.Deserialize(response.Content, typeof(List<AuditSearchLog>), response.Headers);
        }
    
        /// <summary>
        /// Update the audit log streaming service. 
        /// </summary>
        /// <param name="body">Audit log streaming service</param>
        /// <returns>AuditLogStreamService</returns>
        public AuditLogStreamService AuditLogUpdateAccessRequestBrokerAsync (AuditLogStreamService body)
        {
    
            var path = "/v4/AuditLog/StreamService";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogUpdateAccessRequestBrokerAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditLogUpdateAccessRequestBrokerAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AuditLogStreamService) ApiClient.Deserialize(response.Content, typeof(AuditLogStreamService), response.Headers);
        }
    
    }
}
