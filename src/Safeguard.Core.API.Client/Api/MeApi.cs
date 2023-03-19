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
    public interface IMeApi
    {
        /// <summary>
        /// Adds a new personal account 
        /// </summary>
        /// <param name="body">PersonalAccount to add</param>
        /// <returns>PersonalAccount</returns>
        PersonalAccount MeAddPersonalAccountAsync (PersonalAccount body);
        /// <summary>
        /// Changes the local user&#x27;s password. Requires that you know the user&#x27;s current password 
        /// </summary>
        /// <param name="body">Current password and the new password to set</param>
        /// <returns></returns>
        void MeChangeMyPasswordAsync (ChangePasswordParameters body);
        /// <summary>
        /// Creates an UserRequestFavorite 
        /// </summary>
        /// <param name="body">UserRequestFavorite to create</param>
        /// <returns>UserRequestFavorite</returns>
        UserRequestFavorite MeCreateRequestFavoriteAsync (UserRequestFavorite body);
        /// <summary>
        /// Creates a new scheduled audit log search report 
        /// </summary>
        /// <param name="body">Scheduled report to create</param>
        /// <returns>ScheduledAuditLogReport</returns>
        ScheduledAuditLogReport MeCreateScheduledAuditLogSearchReportAsync (ScheduledAuditLogReport body);
        /// <summary>
        /// Removes a FIDO2 authenticator from the current user After registering your first authenticator, you must always have at least one.  In other words, you cannot delete              all of the authenticators (this can, however, be done by an administrator).  In order to delete your last authenticator,              you must first register a new one, such that you have two.  Then you can choose to delete your previous authenticator.
        /// </summary>
        /// <param name="credentialId">Unique, opaque identifier of the authenticator, in Base64Url encoded format</param>
        /// <returns></returns>
        void MeDeleteFido2AuthenticatorAsync (string credentialId);
        /// <summary>
        /// Removes current user photo 
        /// </summary>
        /// <returns></returns>
        void MeDeleteMyPhotoAsync ();
        /// <summary>
        /// Removes a preference for the current user 
        /// </summary>
        /// <param name="name">Unique identifier of the UserPreference</param>
        /// <returns></returns>
        void MeDeleteMyPreferenceAsync (string name);
        /// <summary>
        /// Remove a personal account 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account</param>
        /// <returns></returns>
        void MeDeletePersonalAccountAsync (int? id);
        /// <summary>
        /// Removes an UserRequestFavorite 
        /// </summary>
        /// <param name="favoriteId">Unique identifier of the UserRequestFavorite</param>
        /// <returns></returns>
        void MeDeleteRequestFavoriteAsync (string favoriteId);
        /// <summary>
        /// Removes a scheduled audit log search report 
        /// </summary>
        /// <param name="id">Unique identifier of the scheduled audit log search report</param>
        /// <returns></returns>
        void MeDeleteScheduledAuditLogReportAsync (int? id);
        /// <summary>
        /// Disable event subscriber for the current user 
        /// </summary>
        /// <param name="id">Unique identifier of the Subscribers</param>
        /// <returns>MyEventSubscriber</returns>
        MyEventSubscriber MeDisableMySubscriberAsync (int? id);
        /// <summary>
        /// Disable event subscribers for the current user 
        /// </summary>
        /// <param name="body">Unique identifier of the Subscribers</param>
        /// <returns>List&lt;MyEventSubscriber&gt;</returns>
        List<MyEventSubscriber> MeDisableSubscribersAsync (List<int?> body);
        /// <summary>
        /// Enable event subscriber for the current user 
        /// </summary>
        /// <param name="id">Unique identifier of the Subscribers</param>
        /// <returns>MyEventSubscriber</returns>
        MyEventSubscriber MeEnableMySubscriberAsync (int? id);
        /// <summary>
        /// Enable event subscribers for the current user 
        /// </summary>
        /// <param name="body">Unique identifier of the Subscribers</param>
        /// <returns>List&lt;MyEventSubscriber&gt;</returns>
        List<MyEventSubscriber> MeEnableSubscribersAsync (List<int?> body);
        /// <summary>
        /// Executes the audit log search using saved report configuration 
        /// </summary>
        /// <param name="id">Scheduled report to execute</param>
        /// <returns>List&lt;AuditSearchLog&gt;</returns>
        List<AuditSearchLog> MeExecuteScheduledAuditLogReportAsync (int? id);
        /// <summary>
        /// Generates a new personal account password 
        /// </summary>
        /// <param name="body">Personal account password generation rules</param>
        /// <returns></returns>
        void MeGeneratePersonalAccountPasswordAsync (PersonalAccountPasswordRule body);
        /// <summary>
        /// Gets a specific asset that can be requested by the specified user 
        /// </summary>
        /// <param name="assetId">Unique identifier of the asset</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PolicyAsset</returns>
        PolicyAsset MeGetAccessRequestAssetAsync (int? assetId, string fields);
        /// <summary>
        /// Gets a list of assets that have accounts requestable by the specified user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyAsset&gt;</returns>
        List<PolicyAsset> MeGetAccessRequestAssetsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the entitlements for the current user 
        /// </summary>
        /// <param name="accessRequestType">Only report on access via a specific request type</param>
        /// <param name="assetIds">List of asset IDs to get entitlements for (preferred over filter)</param>
        /// <param name="accountIds">List of account IDs to get entitlements for (preferred over filter)</param>
        /// <param name="includeActiveRequests">Whether to include information about active requests for same account</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;MeEntitlement&gt;</returns>
        List<MeEntitlement> MeGetAccessRequestEntitlementsAsync (AccessRequestType accessRequestType, string assetIds, string accountIds, bool? includeActiveRequests, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all requests that the current user can perform an action on 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ActionableAccessRequests</returns>
        ActionableAccessRequests MeGetActionableRequestsAsync (string fields);
        /// <summary>
        /// Gets all requests that the current user can perform an action on 
        /// </summary>
        /// <param name="accessRequestRole">Return results based on user&#x27;s access request role, i.e. Requester, Approver, Reviewer, Admin</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequest&gt;</returns>
        List<AccessRequest> MeGetActionableRequestsByRequestRoleAsync (AccessRequestRole accessRequestRole, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all requests belonging to the specified request favorite 
        /// </summary>
        /// <param name="favoriteId">Unique ID of the request favorite</param>
        /// <param name="includeActiveRequests">Whether to include information about active requests for same account</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SavedAccessRequest&gt;</returns>
        List<SavedAccessRequest> MeGetFavoriteRequestsAsync (string favoriteId, bool? includeActiveRequests, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific FIDO2 authenticator that has been registered by the current user 
        /// </summary>
        /// <param name="credentialId">Unique, opaque identifier of the authenticator, in Base64Url encoded format</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Fido2Authenticator</returns>
        Fido2Authenticator MeGetFido2AuthenticatorAsync (string credentialId, string fields);
        /// <summary>
        /// Gets all registered FIDO2 authenticators for the current user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Fido2Authenticator&gt;</returns>
        List<Fido2Authenticator> MeGetFido2AuthenticatorsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Get a secure string that is to be included as a query string parameter of an HTTP redirect request that will allow              the current user to register a new FIDO2 authenticator 
        /// </summary>
        /// <returns>string</returns>
        string MeGetFido2RegistrationRedirectAsync ();
        /// <summary>
        /// Get policy accounts that have been linked to this user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyAccount&gt;</returns>
        List<PolicyAccount> MeGetLinkedAccountsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a fully expanded representation of an authenticated user 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Me</returns>
        Me MeGetMeAsync (string fields);
        /// <summary>
        /// Gets information about assets, partitions, accounts this user owns 
        /// </summary>
        /// <param name="objectType">Optional Ownership Object Type</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnership&gt;</returns>
        List<UserOwnership> MeGetMyOwnershipAsync (OwnershipType objectType, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets all asset partitions owned by the user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetPartition&gt;</returns>
        List<AssetPartition> MeGetMyPartitionsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the user&#x27;s photo 
        /// </summary>
        /// <returns>UserPhoto</returns>
        UserPhoto MeGetMyPhotoAsync ();
        /// <summary>
        /// Gets a specific preference for the current user 
        /// </summary>
        /// <param name="name">Unique identifier of the UserPreference</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>UserPreference</returns>
        UserPreference MeGetMyPreferenceAsync (string name, string fields);
        /// <summary>
        /// Gets all preferences for the current user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserPreference&gt;</returns>
        List<UserPreference> MeGetMyPreferencesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets information about all roles the current user belongs to 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserRole&gt;</returns>
        List<UserRole> MeGetMyRolesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific event subscriber for the current user 
        /// </summary>
        /// <param name="id">Unique ID of the subscriber</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>MyEventSubscriber</returns>
        MyEventSubscriber MeGetMySubscriberAsync (int? id, string fields);
        /// <summary>
        /// Gets all event subscribers for the current user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;MyEventSubscriber&gt;</returns>
        List<MyEventSubscriber> MeGetMySubscribersAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a personal account for the current user 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PersonalAccount</returns>
        PersonalAccount MeGetPersonalAccountAsync (int? id, string fields);
        /// <summary>
        /// Gets a personal account password for the current user 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account password</param>
        /// <returns>string</returns>
        string MeGetPersonalAccountPasswordAsync (int? id);
        /// <summary>
        /// Gets a personal account password for the current user 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account password</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PersonalAccountPasswordHistory&gt;</returns>
        List<PersonalAccountPasswordHistory> MeGetPersonalAccountPasswordHistoryAsync (int? id, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the personal accounts for the current user 
        /// </summary>
        /// <param name="personalAccountType">Type of personal accounts to retrieve</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PersonalAccount&gt;</returns>
        List<PersonalAccount> MeGetPersonalAccountsAsync (PersonalAccountType personalAccountType, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the user&#x27;s photo in raw format 
        /// </summary>
        /// <returns>byte[]</returns>
        byte[] MeGetRawPhotoAsync ();
        /// <summary>
        /// Gets a specific request favorites for the current user 
        /// </summary>
        /// <param name="favoriteId">Unique ID of the request favorite</param>
        /// <param name="includeActiveRequests">Whether to include information about active requests for same account</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>UserRequestFavorite</returns>
        UserRequestFavorite MeGetRequestFavoriteAsync (string favoriteId, bool? includeActiveRequests, string fields);
        /// <summary>
        /// Gets all favorite requests for the current user 
        /// </summary>
        /// <param name="includeActiveRequests">Whether to include information about active requests for same account</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserRequestFavorite&gt;</returns>
        List<UserRequestFavorite> MeGetRequestFavoritesAsync (bool? includeActiveRequests, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific scheduled audit log search report for the current user 
        /// </summary>
        /// <param name="id">Unique ID of the search</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ScheduledAuditLogReport</returns>
        ScheduledAuditLogReport MeGetScheduledAuditLogReportAsync (int? id, string fields);
        /// <summary>
        /// Gets all scheduled audit log search reports for the current user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ScheduledAuditLogReport&gt;</returns>
        List<ScheduledAuditLogReport> MeGetScheduledAuditLogReportsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of users 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ShareWithUser&gt;</returns>
        List<ShareWithUser> MeGetUsersAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Add/Remove the requests assigned to the specified request favorite 
        /// </summary>
        /// <param name="favoriteId">Unique ID of the request favorite</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Requests to assign to the UserRequestFavorite</param>
        /// <returns>List&lt;SavedAccessRequest&gt;</returns>
        List<SavedAccessRequest> MeModifyFavoriteRequestsAsync (string favoriteId, ListOperation operation, List<SavedAccessRequest> body);
        /// <summary>
        /// Updates current user&#x27;s photo in binary form 
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        void MePutMyRawPhotoAsync (PhotoRawBody body);
        /// <summary>
        /// Sets the requests assigned to the specified request favorite 
        /// </summary>
        /// <param name="favoriteId">Unique ID of the request favorite</param>
        /// <param name="body">Requests to assign to the UserRequestFavorite</param>
        /// <returns>List&lt;SavedAccessRequest&gt;</returns>
        List<SavedAccessRequest> MeSetFavoriteRequestsAsync (string favoriteId, List<SavedAccessRequest> body);
        /// <summary>
        /// Updates the user supplied friendly name given to a FIDO2 authenticator owned by the current user 
        /// </summary>
        /// <param name="credentialId">Unique, opaque identifier of the authenticator, in Base64Url encoded format</param>
        /// <param name="body">Value to set for this preference</param>
        /// <returns>Fido2Authenticator</returns>
        Fido2Authenticator MeSetFido2AuthenticatorNameAsync (string credentialId, Fido2Authenticator body);
        /// <summary>
        /// Updates or create a preference for the current user 
        /// </summary>
        /// <param name="name">Unique identifier of the UserPreference</param>
        /// <param name="body">Value to set for this preference</param>
        /// <returns>UserPreference</returns>
        UserPreference MeSetMyPreferenceAsync (string name, UserPreference body);
        /// <summary>
        /// Shares a personal account with another user 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account</param>
        /// <param name="body">PersonalAccountShare information</param>
        /// <returns>PersonalAccount</returns>
        PersonalAccount MeSharePersonalAccountAsync (int? id, PersonalAccountShare body);
        /// <summary>
        /// Unshares a personal account with another user 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account</param>
        /// <param name="sharedWithId">Unique identifier of the user that the personal account is shared with</param>
        /// <returns></returns>
        void MeUnsharePersonalAccountAsync (int? id, int? sharedWithId);
        /// <summary>
        /// Allows the current user to update the email address, phone number(s), photo, and time zone 
        /// </summary>
        /// <param name="body">Updated User</param>
        /// <returns>Me</returns>
        Me MeUpdateMeAsync (Me body);
        /// <summary>
        /// Updates current users photo 
        /// </summary>
        /// <param name="body">Updated Photo</param>
        /// <returns></returns>
        void MeUpdateMyPhotoAsync (UserPhoto body);
        /// <summary>
        /// Updates an existing personal account 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account</param>
        /// <param name="body">PersonalAccount to update</param>
        /// <returns>PersonalAccount</returns>
        PersonalAccount MeUpdatePersonalAccountAsync (int? id, PersonalAccount body);
        /// <summary>
        /// Updates an existing personal account password 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account</param>
        /// <param name="body">Personal account Password to update</param>
        /// <returns></returns>
        void MeUpdatePersonalAccountPasswordAsync (int? id, string body);
        /// <summary>
        /// Updates the personal account share 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account</param>
        /// <param name="sharedWithId">Unique identifier of the user that the personal account is shared with</param>
        /// <param name="body">PersonalAccountShare information</param>
        /// <returns>PersonalAccount</returns>
        PersonalAccount MeUpdatePersonalAccountShareAsync (int? id, int? sharedWithId, PersonalAccountShare body);
        /// <summary>
        /// Updates an UserRequestFavorite 
        /// </summary>
        /// <param name="favoriteId">Unique identifier of the UserRequestFavorite</param>
        /// <param name="body">Updated UserRequestFavorite</param>
        /// <returns>UserRequestFavorite</returns>
        UserRequestFavorite MeUpdateRequestFavoriteAsync (string favoriteId, UserRequestFavorite body);
        /// <summary>
        /// Updates a scheduled audit log search report 
        /// </summary>
        /// <param name="id">Unique identifier of the scheduled audit log search report</param>
        /// <param name="body">Updated scheduled audit log search report</param>
        /// <returns>ScheduledAuditLogReport</returns>
        ScheduledAuditLogReport MeUpdateScheduledAuditLogSearchReportAsync (int? id, ScheduledAuditLogReport body);
        /// <summary>
        /// Validates that a password meets requirements 
        /// </summary>
        /// <param name="body">Password to validate</param>
        /// <returns>bool?</returns>
        bool? MeValidateMyPasswordAsync (string body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MeApi : IMeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MeApi(String basePath)
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
        /// Adds a new personal account 
        /// </summary>
        /// <param name="body">PersonalAccount to add</param>
        /// <returns>PersonalAccount</returns>
        public PersonalAccount MeAddPersonalAccountAsync (PersonalAccount body)
        {
    
            var path = "/v4/Me/PersonalAccounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeAddPersonalAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeAddPersonalAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PersonalAccount) ApiClient.Deserialize(response.Content, typeof(PersonalAccount), response.Headers);
        }
    
        /// <summary>
        /// Changes the local user&#x27;s password. Requires that you know the user&#x27;s current password 
        /// </summary>
        /// <param name="body">Current password and the new password to set</param>
        /// <returns></returns>
        public void MeChangeMyPasswordAsync (ChangePasswordParameters body)
        {
    
            var path = "/v4/Me/Password";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeChangeMyPasswordAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeChangeMyPasswordAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Creates an UserRequestFavorite 
        /// </summary>
        /// <param name="body">UserRequestFavorite to create</param>
        /// <returns>UserRequestFavorite</returns>
        public UserRequestFavorite MeCreateRequestFavoriteAsync (UserRequestFavorite body)
        {
    
            var path = "/v4/Me/RequestFavorites";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeCreateRequestFavoriteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeCreateRequestFavoriteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserRequestFavorite) ApiClient.Deserialize(response.Content, typeof(UserRequestFavorite), response.Headers);
        }
    
        /// <summary>
        /// Creates a new scheduled audit log search report 
        /// </summary>
        /// <param name="body">Scheduled report to create</param>
        /// <returns>ScheduledAuditLogReport</returns>
        public ScheduledAuditLogReport MeCreateScheduledAuditLogSearchReportAsync (ScheduledAuditLogReport body)
        {
    
            var path = "/v4/Me/ScheduledAuditLogReports";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeCreateScheduledAuditLogSearchReportAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeCreateScheduledAuditLogSearchReportAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ScheduledAuditLogReport) ApiClient.Deserialize(response.Content, typeof(ScheduledAuditLogReport), response.Headers);
        }
    
        /// <summary>
        /// Removes a FIDO2 authenticator from the current user After registering your first authenticator, you must always have at least one.  In other words, you cannot delete              all of the authenticators (this can, however, be done by an administrator).  In order to delete your last authenticator,              you must first register a new one, such that you have two.  Then you can choose to delete your previous authenticator.
        /// </summary>
        /// <param name="credentialId">Unique, opaque identifier of the authenticator, in Base64Url encoded format</param>
        /// <returns></returns>
        public void MeDeleteFido2AuthenticatorAsync (string credentialId)
        {
            // verify the required parameter 'credentialId' is set
            if (credentialId == null) throw new ApiException(400, "Missing required parameter 'credentialId' when calling MeDeleteFido2AuthenticatorAsync");
    
            var path = "/v4/Me/Fido2Authenticators/{credentialId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "credentialId" + "}", ApiClient.ParameterToString(credentialId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeDeleteFido2AuthenticatorAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeDeleteFido2AuthenticatorAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes current user photo 
        /// </summary>
        /// <returns></returns>
        public void MeDeleteMyPhotoAsync ()
        {
    
            var path = "/v4/Me/Photo";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeDeleteMyPhotoAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeDeleteMyPhotoAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a preference for the current user 
        /// </summary>
        /// <param name="name">Unique identifier of the UserPreference</param>
        /// <returns></returns>
        public void MeDeleteMyPreferenceAsync (string name)
        {
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling MeDeleteMyPreferenceAsync");
    
            var path = "/v4/Me/Preferences/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeDeleteMyPreferenceAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeDeleteMyPreferenceAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove a personal account 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account</param>
        /// <returns></returns>
        public void MeDeletePersonalAccountAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeDeletePersonalAccountAsync");
    
            var path = "/v4/Me/PersonalAccounts/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeDeletePersonalAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeDeletePersonalAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes an UserRequestFavorite 
        /// </summary>
        /// <param name="favoriteId">Unique identifier of the UserRequestFavorite</param>
        /// <returns></returns>
        public void MeDeleteRequestFavoriteAsync (string favoriteId)
        {
            // verify the required parameter 'favoriteId' is set
            if (favoriteId == null) throw new ApiException(400, "Missing required parameter 'favoriteId' when calling MeDeleteRequestFavoriteAsync");
    
            var path = "/v4/Me/RequestFavorites/{favoriteId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "favoriteId" + "}", ApiClient.ParameterToString(favoriteId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeDeleteRequestFavoriteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeDeleteRequestFavoriteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a scheduled audit log search report 
        /// </summary>
        /// <param name="id">Unique identifier of the scheduled audit log search report</param>
        /// <returns></returns>
        public void MeDeleteScheduledAuditLogReportAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeDeleteScheduledAuditLogReportAsync");
    
            var path = "/v4/Me/ScheduledAuditLogReports/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeDeleteScheduledAuditLogReportAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeDeleteScheduledAuditLogReportAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Disable event subscriber for the current user 
        /// </summary>
        /// <param name="id">Unique identifier of the Subscribers</param>
        /// <returns>MyEventSubscriber</returns>
        public MyEventSubscriber MeDisableMySubscriberAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeDisableMySubscriberAsync");
    
            var path = "/v4/Me/Subscribers/{id}/Disable";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeDisableMySubscriberAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeDisableMySubscriberAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MyEventSubscriber) ApiClient.Deserialize(response.Content, typeof(MyEventSubscriber), response.Headers);
        }
    
        /// <summary>
        /// Disable event subscribers for the current user 
        /// </summary>
        /// <param name="body">Unique identifier of the Subscribers</param>
        /// <returns>List&lt;MyEventSubscriber&gt;</returns>
        public List<MyEventSubscriber> MeDisableSubscribersAsync (List<int?> body)
        {
    
            var path = "/v4/Me/Subscribers/Disable";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeDisableSubscribersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeDisableSubscribersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<MyEventSubscriber>) ApiClient.Deserialize(response.Content, typeof(List<MyEventSubscriber>), response.Headers);
        }
    
        /// <summary>
        /// Enable event subscriber for the current user 
        /// </summary>
        /// <param name="id">Unique identifier of the Subscribers</param>
        /// <returns>MyEventSubscriber</returns>
        public MyEventSubscriber MeEnableMySubscriberAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeEnableMySubscriberAsync");
    
            var path = "/v4/Me/Subscribers/{id}/Enable";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeEnableMySubscriberAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeEnableMySubscriberAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MyEventSubscriber) ApiClient.Deserialize(response.Content, typeof(MyEventSubscriber), response.Headers);
        }
    
        /// <summary>
        /// Enable event subscribers for the current user 
        /// </summary>
        /// <param name="body">Unique identifier of the Subscribers</param>
        /// <returns>List&lt;MyEventSubscriber&gt;</returns>
        public List<MyEventSubscriber> MeEnableSubscribersAsync (List<int?> body)
        {
    
            var path = "/v4/Me/Subscribers/Enable";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeEnableSubscribersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeEnableSubscribersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<MyEventSubscriber>) ApiClient.Deserialize(response.Content, typeof(List<MyEventSubscriber>), response.Headers);
        }
    
        /// <summary>
        /// Executes the audit log search using saved report configuration 
        /// </summary>
        /// <param name="id">Scheduled report to execute</param>
        /// <returns>List&lt;AuditSearchLog&gt;</returns>
        public List<AuditSearchLog> MeExecuteScheduledAuditLogReportAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeExecuteScheduledAuditLogReportAsync");
    
            var path = "/v4/Me/ScheduledAuditLogReports/{id}/Execute";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeExecuteScheduledAuditLogReportAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeExecuteScheduledAuditLogReportAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AuditSearchLog>) ApiClient.Deserialize(response.Content, typeof(List<AuditSearchLog>), response.Headers);
        }
    
        /// <summary>
        /// Generates a new personal account password 
        /// </summary>
        /// <param name="body">Personal account password generation rules</param>
        /// <returns></returns>
        public void MeGeneratePersonalAccountPasswordAsync (PersonalAccountPasswordRule body)
        {
    
            var path = "/v4/Me/PersonalAccounts/GeneratePassword";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGeneratePersonalAccountPasswordAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGeneratePersonalAccountPasswordAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a specific asset that can be requested by the specified user 
        /// </summary>
        /// <param name="assetId">Unique identifier of the asset</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PolicyAsset</returns>
        public PolicyAsset MeGetAccessRequestAssetAsync (int? assetId, string fields)
        {
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling MeGetAccessRequestAssetAsync");
    
            var path = "/v4/Me/AccessRequestAssets/{assetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetAccessRequestAssetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetAccessRequestAssetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PolicyAsset) ApiClient.Deserialize(response.Content, typeof(PolicyAsset), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of assets that have accounts requestable by the specified user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyAsset&gt;</returns>
        public List<PolicyAsset> MeGetAccessRequestAssetsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Me/AccessRequestAssets";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetAccessRequestAssetsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetAccessRequestAssetsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyAsset>) ApiClient.Deserialize(response.Content, typeof(List<PolicyAsset>), response.Headers);
        }
    
        /// <summary>
        /// Gets the entitlements for the current user 
        /// </summary>
        /// <param name="accessRequestType">Only report on access via a specific request type</param>
        /// <param name="assetIds">List of asset IDs to get entitlements for (preferred over filter)</param>
        /// <param name="accountIds">List of account IDs to get entitlements for (preferred over filter)</param>
        /// <param name="includeActiveRequests">Whether to include information about active requests for same account</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;MeEntitlement&gt;</returns>
        public List<MeEntitlement> MeGetAccessRequestEntitlementsAsync (AccessRequestType accessRequestType, string assetIds, string accountIds, bool? includeActiveRequests, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Me/RequestEntitlements";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessRequestType != null) queryParams.Add("accessRequestType", ApiClient.ParameterToString(accessRequestType)); // query parameter
 if (assetIds != null) queryParams.Add("assetIds", ApiClient.ParameterToString(assetIds)); // query parameter
 if (accountIds != null) queryParams.Add("accountIds", ApiClient.ParameterToString(accountIds)); // query parameter
 if (includeActiveRequests != null) queryParams.Add("includeActiveRequests", ApiClient.ParameterToString(includeActiveRequests)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetAccessRequestEntitlementsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetAccessRequestEntitlementsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<MeEntitlement>) ApiClient.Deserialize(response.Content, typeof(List<MeEntitlement>), response.Headers);
        }
    
        /// <summary>
        /// Gets all requests that the current user can perform an action on 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ActionableAccessRequests</returns>
        public ActionableAccessRequests MeGetActionableRequestsAsync (string fields)
        {
    
            var path = "/v4/Me/ActionableRequests";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetActionableRequestsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetActionableRequestsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ActionableAccessRequests) ApiClient.Deserialize(response.Content, typeof(ActionableAccessRequests), response.Headers);
        }
    
        /// <summary>
        /// Gets all requests that the current user can perform an action on 
        /// </summary>
        /// <param name="accessRequestRole">Return results based on user&#x27;s access request role, i.e. Requester, Approver, Reviewer, Admin</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccessRequest&gt;</returns>
        public List<AccessRequest> MeGetActionableRequestsByRequestRoleAsync (AccessRequestRole accessRequestRole, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'accessRequestRole' is set
            if (accessRequestRole == null) throw new ApiException(400, "Missing required parameter 'accessRequestRole' when calling MeGetActionableRequestsByRequestRoleAsync");
    
            var path = "/v4/Me/ActionableRequests/{accessRequestRole}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accessRequestRole" + "}", ApiClient.ParameterToString(accessRequestRole));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetActionableRequestsByRequestRoleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetActionableRequestsByRequestRoleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccessRequest>) ApiClient.Deserialize(response.Content, typeof(List<AccessRequest>), response.Headers);
        }
    
        /// <summary>
        /// Gets all requests belonging to the specified request favorite 
        /// </summary>
        /// <param name="favoriteId">Unique ID of the request favorite</param>
        /// <param name="includeActiveRequests">Whether to include information about active requests for same account</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SavedAccessRequest&gt;</returns>
        public List<SavedAccessRequest> MeGetFavoriteRequestsAsync (string favoriteId, bool? includeActiveRequests, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'favoriteId' is set
            if (favoriteId == null) throw new ApiException(400, "Missing required parameter 'favoriteId' when calling MeGetFavoriteRequestsAsync");
    
            var path = "/v4/Me/RequestFavorites/{favoriteId}/Requests";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "favoriteId" + "}", ApiClient.ParameterToString(favoriteId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includeActiveRequests != null) queryParams.Add("includeActiveRequests", ApiClient.ParameterToString(includeActiveRequests)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetFavoriteRequestsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetFavoriteRequestsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SavedAccessRequest>) ApiClient.Deserialize(response.Content, typeof(List<SavedAccessRequest>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific FIDO2 authenticator that has been registered by the current user 
        /// </summary>
        /// <param name="credentialId">Unique, opaque identifier of the authenticator, in Base64Url encoded format</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Fido2Authenticator</returns>
        public Fido2Authenticator MeGetFido2AuthenticatorAsync (string credentialId, string fields)
        {
            // verify the required parameter 'credentialId' is set
            if (credentialId == null) throw new ApiException(400, "Missing required parameter 'credentialId' when calling MeGetFido2AuthenticatorAsync");
    
            var path = "/v4/Me/Fido2Authenticators/{credentialId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "credentialId" + "}", ApiClient.ParameterToString(credentialId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetFido2AuthenticatorAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetFido2AuthenticatorAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Fido2Authenticator) ApiClient.Deserialize(response.Content, typeof(Fido2Authenticator), response.Headers);
        }
    
        /// <summary>
        /// Gets all registered FIDO2 authenticators for the current user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Fido2Authenticator&gt;</returns>
        public List<Fido2Authenticator> MeGetFido2AuthenticatorsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Me/Fido2Authenticators";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetFido2AuthenticatorsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetFido2AuthenticatorsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Fido2Authenticator>) ApiClient.Deserialize(response.Content, typeof(List<Fido2Authenticator>), response.Headers);
        }
    
        /// <summary>
        /// Get a secure string that is to be included as a query string parameter of an HTTP redirect request that will allow              the current user to register a new FIDO2 authenticator 
        /// </summary>
        /// <returns>string</returns>
        public string MeGetFido2RegistrationRedirectAsync ()
        {
    
            var path = "/v4/Me/Fido2Authenticators/RegistrationRedirect";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetFido2RegistrationRedirectAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetFido2RegistrationRedirectAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Get policy accounts that have been linked to this user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PolicyAccount&gt;</returns>
        public List<PolicyAccount> MeGetLinkedAccountsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Me/LinkedPolicyAccounts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetLinkedAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetLinkedAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PolicyAccount>) ApiClient.Deserialize(response.Content, typeof(List<PolicyAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets a fully expanded representation of an authenticated user 
        /// </summary>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>Me</returns>
        public Me MeGetMeAsync (string fields)
        {
    
            var path = "/v4/Me";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMeAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMeAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Me) ApiClient.Deserialize(response.Content, typeof(Me), response.Headers);
        }
    
        /// <summary>
        /// Gets information about assets, partitions, accounts this user owns 
        /// </summary>
        /// <param name="objectType">Optional Ownership Object Type</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnership&gt;</returns>
        public List<UserOwnership> MeGetMyOwnershipAsync (OwnershipType objectType, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Me/Ownership";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (objectType != null) queryParams.Add("objectType", ApiClient.ParameterToString(objectType)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMyOwnershipAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMyOwnershipAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserOwnership>) ApiClient.Deserialize(response.Content, typeof(List<UserOwnership>), response.Headers);
        }
    
        /// <summary>
        /// Gets all asset partitions owned by the user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AssetPartition&gt;</returns>
        public List<AssetPartition> MeGetMyPartitionsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Me/OwnedPartitions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMyPartitionsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMyPartitionsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AssetPartition>) ApiClient.Deserialize(response.Content, typeof(List<AssetPartition>), response.Headers);
        }
    
        /// <summary>
        /// Gets the user&#x27;s photo 
        /// </summary>
        /// <returns>UserPhoto</returns>
        public UserPhoto MeGetMyPhotoAsync ()
        {
    
            var path = "/v4/Me/Photo";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMyPhotoAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMyPhotoAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserPhoto) ApiClient.Deserialize(response.Content, typeof(UserPhoto), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific preference for the current user 
        /// </summary>
        /// <param name="name">Unique identifier of the UserPreference</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>UserPreference</returns>
        public UserPreference MeGetMyPreferenceAsync (string name, string fields)
        {
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling MeGetMyPreferenceAsync");
    
            var path = "/v4/Me/Preferences/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMyPreferenceAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMyPreferenceAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserPreference) ApiClient.Deserialize(response.Content, typeof(UserPreference), response.Headers);
        }
    
        /// <summary>
        /// Gets all preferences for the current user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserPreference&gt;</returns>
        public List<UserPreference> MeGetMyPreferencesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Me/Preferences";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMyPreferencesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMyPreferencesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserPreference>) ApiClient.Deserialize(response.Content, typeof(List<UserPreference>), response.Headers);
        }
    
        /// <summary>
        /// Gets information about all roles the current user belongs to 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserRole&gt;</returns>
        public List<UserRole> MeGetMyRolesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Me/Roles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMyRolesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMyRolesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserRole>) ApiClient.Deserialize(response.Content, typeof(List<UserRole>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific event subscriber for the current user 
        /// </summary>
        /// <param name="id">Unique ID of the subscriber</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>MyEventSubscriber</returns>
        public MyEventSubscriber MeGetMySubscriberAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeGetMySubscriberAsync");
    
            var path = "/v4/Me/Subscribers/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMySubscriberAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMySubscriberAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MyEventSubscriber) ApiClient.Deserialize(response.Content, typeof(MyEventSubscriber), response.Headers);
        }
    
        /// <summary>
        /// Gets all event subscribers for the current user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;MyEventSubscriber&gt;</returns>
        public List<MyEventSubscriber> MeGetMySubscribersAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Me/Subscribers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMySubscribersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetMySubscribersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<MyEventSubscriber>) ApiClient.Deserialize(response.Content, typeof(List<MyEventSubscriber>), response.Headers);
        }
    
        /// <summary>
        /// Gets a personal account for the current user 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>PersonalAccount</returns>
        public PersonalAccount MeGetPersonalAccountAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeGetPersonalAccountAsync");
    
            var path = "/v4/Me/PersonalAccounts/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetPersonalAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetPersonalAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PersonalAccount) ApiClient.Deserialize(response.Content, typeof(PersonalAccount), response.Headers);
        }
    
        /// <summary>
        /// Gets a personal account password for the current user 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account password</param>
        /// <returns>string</returns>
        public string MeGetPersonalAccountPasswordAsync (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeGetPersonalAccountPasswordAsync");
    
            var path = "/v4/Me/PersonalAccounts/{id}/Password";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetPersonalAccountPasswordAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetPersonalAccountPasswordAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Gets a personal account password for the current user 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account password</param>
        /// <param name="startDate">Get activity that occurred after this date. Defaults to 1 day before endDate. (Preferred over &#x27;filter&#x27;)</param>
        /// <param name="endDate">Get activity that occurred before this date. Defaults to now. (Preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for audit log queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PersonalAccountPasswordHistory&gt;</returns>
        public List<PersonalAccountPasswordHistory> MeGetPersonalAccountPasswordHistoryAsync (int? id, DateTime? startDate, DateTime? endDate, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeGetPersonalAccountPasswordHistoryAsync");
    
            var path = "/v4/Me/PersonalAccounts/{id}/PasswordHistory";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetPersonalAccountPasswordHistoryAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetPersonalAccountPasswordHistoryAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PersonalAccountPasswordHistory>) ApiClient.Deserialize(response.Content, typeof(List<PersonalAccountPasswordHistory>), response.Headers);
        }
    
        /// <summary>
        /// Gets the personal accounts for the current user 
        /// </summary>
        /// <param name="personalAccountType">Type of personal accounts to retrieve</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;PersonalAccount&gt;</returns>
        public List<PersonalAccount> MeGetPersonalAccountsAsync (PersonalAccountType personalAccountType, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Me/PersonalAccounts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (personalAccountType != null) queryParams.Add("personalAccountType", ApiClient.ParameterToString(personalAccountType)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetPersonalAccountsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetPersonalAccountsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<PersonalAccount>) ApiClient.Deserialize(response.Content, typeof(List<PersonalAccount>), response.Headers);
        }
    
        /// <summary>
        /// Gets the user&#x27;s photo in raw format 
        /// </summary>
        /// <returns>byte[]</returns>
        public byte[] MeGetRawPhotoAsync ()
        {
    
            var path = "/v4/Me/Photo/Raw";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetRawPhotoAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetRawPhotoAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific request favorites for the current user 
        /// </summary>
        /// <param name="favoriteId">Unique ID of the request favorite</param>
        /// <param name="includeActiveRequests">Whether to include information about active requests for same account</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>UserRequestFavorite</returns>
        public UserRequestFavorite MeGetRequestFavoriteAsync (string favoriteId, bool? includeActiveRequests, string fields)
        {
            // verify the required parameter 'favoriteId' is set
            if (favoriteId == null) throw new ApiException(400, "Missing required parameter 'favoriteId' when calling MeGetRequestFavoriteAsync");
    
            var path = "/v4/Me/RequestFavorites/{favoriteId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "favoriteId" + "}", ApiClient.ParameterToString(favoriteId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includeActiveRequests != null) queryParams.Add("includeActiveRequests", ApiClient.ParameterToString(includeActiveRequests)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetRequestFavoriteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetRequestFavoriteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserRequestFavorite) ApiClient.Deserialize(response.Content, typeof(UserRequestFavorite), response.Headers);
        }
    
        /// <summary>
        /// Gets all favorite requests for the current user 
        /// </summary>
        /// <param name="includeActiveRequests">Whether to include information about active requests for same account</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserRequestFavorite&gt;</returns>
        public List<UserRequestFavorite> MeGetRequestFavoritesAsync (bool? includeActiveRequests, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Me/RequestFavorites";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includeActiveRequests != null) queryParams.Add("includeActiveRequests", ApiClient.ParameterToString(includeActiveRequests)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetRequestFavoritesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetRequestFavoritesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserRequestFavorite>) ApiClient.Deserialize(response.Content, typeof(List<UserRequestFavorite>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific scheduled audit log search report for the current user 
        /// </summary>
        /// <param name="id">Unique ID of the search</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ScheduledAuditLogReport</returns>
        public ScheduledAuditLogReport MeGetScheduledAuditLogReportAsync (int? id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeGetScheduledAuditLogReportAsync");
    
            var path = "/v4/Me/ScheduledAuditLogReports/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetScheduledAuditLogReportAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetScheduledAuditLogReportAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ScheduledAuditLogReport) ApiClient.Deserialize(response.Content, typeof(ScheduledAuditLogReport), response.Headers);
        }
    
        /// <summary>
        /// Gets all scheduled audit log search reports for the current user 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ScheduledAuditLogReport&gt;</returns>
        public List<ScheduledAuditLogReport> MeGetScheduledAuditLogReportsAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Me/ScheduledAuditLogReports";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetScheduledAuditLogReportsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetScheduledAuditLogReportsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ScheduledAuditLogReport>) ApiClient.Deserialize(response.Content, typeof(List<ScheduledAuditLogReport>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of users 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;ShareWithUser&gt;</returns>
        public List<ShareWithUser> MeGetUsersAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Me/PersonalAccounts/ShareWithUsers";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetUsersAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeGetUsersAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ShareWithUser>) ApiClient.Deserialize(response.Content, typeof(List<ShareWithUser>), response.Headers);
        }
    
        /// <summary>
        /// Add/Remove the requests assigned to the specified request favorite 
        /// </summary>
        /// <param name="favoriteId">Unique ID of the request favorite</param>
        /// <param name="operation">Operation to perform on the list</param>
        /// <param name="body">Requests to assign to the UserRequestFavorite</param>
        /// <returns>List&lt;SavedAccessRequest&gt;</returns>
        public List<SavedAccessRequest> MeModifyFavoriteRequestsAsync (string favoriteId, ListOperation operation, List<SavedAccessRequest> body)
        {
            // verify the required parameter 'favoriteId' is set
            if (favoriteId == null) throw new ApiException(400, "Missing required parameter 'favoriteId' when calling MeModifyFavoriteRequestsAsync");
            // verify the required parameter 'operation' is set
            if (operation == null) throw new ApiException(400, "Missing required parameter 'operation' when calling MeModifyFavoriteRequestsAsync");
    
            var path = "/v4/Me/RequestFavorites/{favoriteId}/Requests/{operation}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "favoriteId" + "}", ApiClient.ParameterToString(favoriteId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeModifyFavoriteRequestsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeModifyFavoriteRequestsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SavedAccessRequest>) ApiClient.Deserialize(response.Content, typeof(List<SavedAccessRequest>), response.Headers);
        }
    
        /// <summary>
        /// Updates current user&#x27;s photo in binary form 
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        public void MePutMyRawPhotoAsync (PhotoRawBody body)
        {
    
            var path = "/v4/Me/Photo/Raw";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MePutMyRawPhotoAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MePutMyRawPhotoAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Sets the requests assigned to the specified request favorite 
        /// </summary>
        /// <param name="favoriteId">Unique ID of the request favorite</param>
        /// <param name="body">Requests to assign to the UserRequestFavorite</param>
        /// <returns>List&lt;SavedAccessRequest&gt;</returns>
        public List<SavedAccessRequest> MeSetFavoriteRequestsAsync (string favoriteId, List<SavedAccessRequest> body)
        {
            // verify the required parameter 'favoriteId' is set
            if (favoriteId == null) throw new ApiException(400, "Missing required parameter 'favoriteId' when calling MeSetFavoriteRequestsAsync");
    
            var path = "/v4/Me/RequestFavorites/{favoriteId}/Requests";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "favoriteId" + "}", ApiClient.ParameterToString(favoriteId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeSetFavoriteRequestsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeSetFavoriteRequestsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SavedAccessRequest>) ApiClient.Deserialize(response.Content, typeof(List<SavedAccessRequest>), response.Headers);
        }
    
        /// <summary>
        /// Updates the user supplied friendly name given to a FIDO2 authenticator owned by the current user 
        /// </summary>
        /// <param name="credentialId">Unique, opaque identifier of the authenticator, in Base64Url encoded format</param>
        /// <param name="body">Value to set for this preference</param>
        /// <returns>Fido2Authenticator</returns>
        public Fido2Authenticator MeSetFido2AuthenticatorNameAsync (string credentialId, Fido2Authenticator body)
        {
            // verify the required parameter 'credentialId' is set
            if (credentialId == null) throw new ApiException(400, "Missing required parameter 'credentialId' when calling MeSetFido2AuthenticatorNameAsync");
    
            var path = "/v4/Me/Fido2Authenticators/{credentialId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "credentialId" + "}", ApiClient.ParameterToString(credentialId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeSetFido2AuthenticatorNameAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeSetFido2AuthenticatorNameAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Fido2Authenticator) ApiClient.Deserialize(response.Content, typeof(Fido2Authenticator), response.Headers);
        }
    
        /// <summary>
        /// Updates or create a preference for the current user 
        /// </summary>
        /// <param name="name">Unique identifier of the UserPreference</param>
        /// <param name="body">Value to set for this preference</param>
        /// <returns>UserPreference</returns>
        public UserPreference MeSetMyPreferenceAsync (string name, UserPreference body)
        {
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling MeSetMyPreferenceAsync");
    
            var path = "/v4/Me/Preferences/{name}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "name" + "}", ApiClient.ParameterToString(name));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeSetMyPreferenceAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeSetMyPreferenceAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserPreference) ApiClient.Deserialize(response.Content, typeof(UserPreference), response.Headers);
        }
    
        /// <summary>
        /// Shares a personal account with another user 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account</param>
        /// <param name="body">PersonalAccountShare information</param>
        /// <returns>PersonalAccount</returns>
        public PersonalAccount MeSharePersonalAccountAsync (int? id, PersonalAccountShare body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeSharePersonalAccountAsync");
    
            var path = "/v4/Me/PersonalAccounts/{id}/Share";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeSharePersonalAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeSharePersonalAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PersonalAccount) ApiClient.Deserialize(response.Content, typeof(PersonalAccount), response.Headers);
        }
    
        /// <summary>
        /// Unshares a personal account with another user 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account</param>
        /// <param name="sharedWithId">Unique identifier of the user that the personal account is shared with</param>
        /// <returns></returns>
        public void MeUnsharePersonalAccountAsync (int? id, int? sharedWithId)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeUnsharePersonalAccountAsync");
            // verify the required parameter 'sharedWithId' is set
            if (sharedWithId == null) throw new ApiException(400, "Missing required parameter 'sharedWithId' when calling MeUnsharePersonalAccountAsync");
    
            var path = "/v4/Me/PersonalAccounts/{id}/Share/{sharedWithId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "sharedWithId" + "}", ApiClient.ParameterToString(sharedWithId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeUnsharePersonalAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeUnsharePersonalAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Allows the current user to update the email address, phone number(s), photo, and time zone 
        /// </summary>
        /// <param name="body">Updated User</param>
        /// <returns>Me</returns>
        public Me MeUpdateMeAsync (Me body)
        {
    
            var path = "/v4/Me";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeUpdateMeAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeUpdateMeAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Me) ApiClient.Deserialize(response.Content, typeof(Me), response.Headers);
        }
    
        /// <summary>
        /// Updates current users photo 
        /// </summary>
        /// <param name="body">Updated Photo</param>
        /// <returns></returns>
        public void MeUpdateMyPhotoAsync (UserPhoto body)
        {
    
            var path = "/v4/Me/Photo";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeUpdateMyPhotoAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeUpdateMyPhotoAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates an existing personal account 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account</param>
        /// <param name="body">PersonalAccount to update</param>
        /// <returns>PersonalAccount</returns>
        public PersonalAccount MeUpdatePersonalAccountAsync (int? id, PersonalAccount body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeUpdatePersonalAccountAsync");
    
            var path = "/v4/Me/PersonalAccounts/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeUpdatePersonalAccountAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeUpdatePersonalAccountAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PersonalAccount) ApiClient.Deserialize(response.Content, typeof(PersonalAccount), response.Headers);
        }
    
        /// <summary>
        /// Updates an existing personal account password 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account</param>
        /// <param name="body">Personal account Password to update</param>
        /// <returns></returns>
        public void MeUpdatePersonalAccountPasswordAsync (int? id, string body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeUpdatePersonalAccountPasswordAsync");
    
            var path = "/v4/Me/PersonalAccounts/{id}/Password";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeUpdatePersonalAccountPasswordAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeUpdatePersonalAccountPasswordAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the personal account share 
        /// </summary>
        /// <param name="id">Unique identifier of the personal account</param>
        /// <param name="sharedWithId">Unique identifier of the user that the personal account is shared with</param>
        /// <param name="body">PersonalAccountShare information</param>
        /// <returns>PersonalAccount</returns>
        public PersonalAccount MeUpdatePersonalAccountShareAsync (int? id, int? sharedWithId, PersonalAccountShare body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeUpdatePersonalAccountShareAsync");
            // verify the required parameter 'sharedWithId' is set
            if (sharedWithId == null) throw new ApiException(400, "Missing required parameter 'sharedWithId' when calling MeUpdatePersonalAccountShareAsync");
    
            var path = "/v4/Me/PersonalAccounts/{id}/Share/{sharedWithId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "sharedWithId" + "}", ApiClient.ParameterToString(sharedWithId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeUpdatePersonalAccountShareAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeUpdatePersonalAccountShareAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PersonalAccount) ApiClient.Deserialize(response.Content, typeof(PersonalAccount), response.Headers);
        }
    
        /// <summary>
        /// Updates an UserRequestFavorite 
        /// </summary>
        /// <param name="favoriteId">Unique identifier of the UserRequestFavorite</param>
        /// <param name="body">Updated UserRequestFavorite</param>
        /// <returns>UserRequestFavorite</returns>
        public UserRequestFavorite MeUpdateRequestFavoriteAsync (string favoriteId, UserRequestFavorite body)
        {
            // verify the required parameter 'favoriteId' is set
            if (favoriteId == null) throw new ApiException(400, "Missing required parameter 'favoriteId' when calling MeUpdateRequestFavoriteAsync");
    
            var path = "/v4/Me/RequestFavorites/{favoriteId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "favoriteId" + "}", ApiClient.ParameterToString(favoriteId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeUpdateRequestFavoriteAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeUpdateRequestFavoriteAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserRequestFavorite) ApiClient.Deserialize(response.Content, typeof(UserRequestFavorite), response.Headers);
        }
    
        /// <summary>
        /// Updates a scheduled audit log search report 
        /// </summary>
        /// <param name="id">Unique identifier of the scheduled audit log search report</param>
        /// <param name="body">Updated scheduled audit log search report</param>
        /// <returns>ScheduledAuditLogReport</returns>
        public ScheduledAuditLogReport MeUpdateScheduledAuditLogSearchReportAsync (int? id, ScheduledAuditLogReport body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MeUpdateScheduledAuditLogSearchReportAsync");
    
            var path = "/v4/Me/ScheduledAuditLogReports/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeUpdateScheduledAuditLogSearchReportAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeUpdateScheduledAuditLogSearchReportAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ScheduledAuditLogReport) ApiClient.Deserialize(response.Content, typeof(ScheduledAuditLogReport), response.Headers);
        }
    
        /// <summary>
        /// Validates that a password meets requirements 
        /// </summary>
        /// <param name="body">Password to validate</param>
        /// <returns>bool?</returns>
        public bool? MeValidateMyPasswordAsync (string body)
        {
    
            var path = "/v4/Me/ValidatePassword";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MeValidateMyPasswordAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MeValidateMyPasswordAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (bool?) ApiClient.Deserialize(response.Content, typeof(bool?), response.Headers);
        }
    
    }
}
