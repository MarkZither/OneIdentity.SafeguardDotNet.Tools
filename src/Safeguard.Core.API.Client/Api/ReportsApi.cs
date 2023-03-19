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
    public interface IReportsApi
    {
        /// <summary>
        /// Generates a report of what accounts have failing tasks 
        /// </summary>
        /// <param name="accountTaskName">Specific task type for which to generate a failed account report</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for task report queries</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountTaskData&gt;</returns>
        List<AccountTaskData> ReportsGenerateFailedAccountTaskReportAsync (AccountTaskNames accountTaskName, string fields, string filter, int? limit, bool? count, string orderby, int? page, string q);
        /// <summary>
        /// Generates a report of what assets have failing tasks 
        /// </summary>
        /// <param name="assetTaskName">Specific task type for which to generate a failed asset report</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for task report queries</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountTaskData&gt;</returns>
        List<AccountTaskData> ReportsGenerateFailedAssetTaskReportAsync (AssetTaskNames assetTaskName, string fields, string filter, int? limit, bool? count, string orderby, int? page, string q);
        /// <summary>
        /// Generates a summary report of account tasks 
        /// </summary>
        /// <returns>AccountTaskSummaryReport</returns>
        AccountTaskSummaryReport ReportsGenerateTaskSummaryReportAsync ();
        /// <summary>
        /// Generates a report of what users can access a set of accounts 
        /// </summary>
        /// <param name="accountIds">Comma-separated list of accounts to report access for. Will report on all accounts by default. (preferred over filter)</param>
        /// <param name="accessRequestType">Only report on access via a specific request type (preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for entitlement queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserAccountEntitlement&gt;</returns>
        List<UserAccountEntitlement> ReportsGetAccountEntitlementsAsync (string accountIds, AccessRequestType accessRequestType, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Generates a report of what users can access accounts on a set of policy assets 
        /// </summary>
        /// <param name="assetIds">Comma-separated list of policy assets to report access for. Will report on all assets by default. (preferred over filter)</param>
        /// <param name="accessRequestType">Only report on access via a specific request type (preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for entitlement queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserAccountEntitlement&gt;</returns>
        List<UserAccountEntitlement> ReportsGetAssetEntitlementsAsync (string assetIds, AccessRequestType accessRequestType, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of report categories 
        /// </summary>
        /// <returns>List&lt;EntitlementReportTypes&gt;</returns>
        List<EntitlementReportTypes> ReportsGetEntitlementReportTypes ();
        /// <summary>
        /// Generates a report of owned items by type: Account, Asset, Partition, Tag, User 
        /// </summary>
        /// <param name="reportType">Ownership Report Type</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipReportType&gt;</returns>
        List<UserOwnershipReportType> ReportsGetOwnershipReportByTypeAsync (OwnershipReportTypes reportType, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Generates a report of how a user owns an item 
        /// </summary>
        /// <param name="userId">Ownership User Id</param>
        /// <param name="itemId">Ownership Item Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>UserOwnershipDetail</returns>
        UserOwnershipDetail ReportsGetOwnershipReportDetailsByUserIdItemIdAsync (int? userId, int? itemId, string filter, int? page, int? limit, string fields, string orderby, string q);
        /// <summary>
        /// Generates a report of how a user owns an item by tag 
        /// </summary>
        /// <param name="userId">Ownership User Id</param>
        /// <param name="itemId">Ownership Item Id</param>
        /// <param name="tagId">Ownership Tag Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>UserOwnershipDetail</returns>
        UserOwnershipDetail ReportsGetOwnershipReportDetailsByUserIdItemIdTagIdAsync (int? userId, int? itemId, int? tagId, string filter, int? page, int? limit, string fields, string orderby, string q);
        /// <summary>
        /// Generates a report of a set of items by tag 
        /// </summary>
        /// <param name="tagId">Ownership Tag Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        List<UserOwnershipDetail> ReportsGetOwnershipReportItemsByTagIdAsync (int? tagId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Generates a report of a set of items by user 
        /// </summary>
        /// <param name="userId">Ownership User Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        List<UserOwnershipDetail> ReportsGetOwnershipReportItemsByUserIdAsync (int? userId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Generates a report of owners by account with parent asset and parent partition 
        /// </summary>
        /// <param name="accountId">Ownership Account Id</param>
        /// <param name="assetId">Ownership Asset Id</param>
        /// <param name="partitionId">Ownership Partition Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        List<UserOwnershipDetail> ReportsGetOwnershipReportOwnersByAccountIdAssetIdPartitionIdAsync (int? accountId, int? assetId, int? partitionId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Generates a report of owners by account 
        /// </summary>
        /// <param name="accountId">Ownership Account Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        List<UserOwnershipDetail> ReportsGetOwnershipReportOwnersByAccountIdAsync (int? accountId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Generates a report of owners by asset 
        /// </summary>
        /// <param name="assetId">Ownership Asset Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        List<UserOwnershipDetail> ReportsGetOwnershipReportOwnersByAssetIdAsync (int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Generates a report of owners by asset and parent partition 
        /// </summary>
        /// <param name="assetId">Ownership Asset Id</param>
        /// <param name="partitionId">Ownership Partition Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        List<UserOwnershipDetail> ReportsGetOwnershipReportOwnersByAssetIdPartitionIdAsync (int? assetId, int? partitionId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Generates a report of owners by partition 
        /// </summary>
        /// <param name="partitionId">Ownership Partition Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        List<UserOwnershipDetail> ReportsGetOwnershipReportOwnersByPartitionIdAsync (int? partitionId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Generates a report of owners by tag 
        /// </summary>
        /// <param name="tagId">Ownership Tag Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        List<UserOwnershipDetail> ReportsGetOwnershipReportOwnersByTagIdAsync (int? tagId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of report categories 
        /// </summary>
        /// <returns>List&lt;OwnershipReportTypes&gt;</returns>
        List<OwnershipReportTypes> ReportsGetOwnershipReportTypes ();
        /// <summary>
        /// Gets a list of task report categories 
        /// </summary>
        /// <returns>List&lt;TaskReportTypes&gt;</returns>
        List<TaskReportTypes> ReportsGetTaskReportTypes ();
        /// <summary>
        /// Generates a report of what accounts can be accessed by a set of users 
        /// </summary>
        /// <param name="userIds">Comma-separated list of users to report access for. Will report on all users by default. (preferred over filter)</param>
        /// <param name="accessRequestType">Only report on access via a specific request type (preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for entitlement queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserAccountEntitlement&gt;</returns>
        List<UserAccountEntitlement> ReportsGetUserEntitlementsAsync (string userIds, AccessRequestType accessRequestType, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a list of report categories 
        /// </summary>
        /// <returns>List&lt;ReportCategories&gt;</returns>
        List<ReportCategories> ReportsGetV3ReportCategories ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportsApi : IReportsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportsApi(String basePath)
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
        /// Generates a report of what accounts have failing tasks 
        /// </summary>
        /// <param name="accountTaskName">Specific task type for which to generate a failed account report</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for task report queries</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountTaskData&gt;</returns>
        public List<AccountTaskData> ReportsGenerateFailedAccountTaskReportAsync (AccountTaskNames accountTaskName, string fields, string filter, int? limit, bool? count, string orderby, int? page, string q)
        {
            // verify the required parameter 'accountTaskName' is set
            if (accountTaskName == null) throw new ApiException(400, "Missing required parameter 'accountTaskName' when calling ReportsGenerateFailedAccountTaskReportAsync");
    
            var path = "/v4/Reports/Tasks/FailedAccountTasks/{accountTaskName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountTaskName" + "}", ApiClient.ParameterToString(accountTaskName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGenerateFailedAccountTaskReportAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGenerateFailedAccountTaskReportAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountTaskData>) ApiClient.Deserialize(response.Content, typeof(List<AccountTaskData>), response.Headers);
        }
    
        /// <summary>
        /// Generates a report of what assets have failing tasks 
        /// </summary>
        /// <param name="assetTaskName">Specific task type for which to generate a failed asset report</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for task report queries</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;AccountTaskData&gt;</returns>
        public List<AccountTaskData> ReportsGenerateFailedAssetTaskReportAsync (AssetTaskNames assetTaskName, string fields, string filter, int? limit, bool? count, string orderby, int? page, string q)
        {
            // verify the required parameter 'assetTaskName' is set
            if (assetTaskName == null) throw new ApiException(400, "Missing required parameter 'assetTaskName' when calling ReportsGenerateFailedAssetTaskReportAsync");
    
            var path = "/v4/Reports/Tasks/FailedAssetTasks/{assetTaskName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "assetTaskName" + "}", ApiClient.ParameterToString(assetTaskName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGenerateFailedAssetTaskReportAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGenerateFailedAssetTaskReportAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AccountTaskData>) ApiClient.Deserialize(response.Content, typeof(List<AccountTaskData>), response.Headers);
        }
    
        /// <summary>
        /// Generates a summary report of account tasks 
        /// </summary>
        /// <returns>AccountTaskSummaryReport</returns>
        public AccountTaskSummaryReport ReportsGenerateTaskSummaryReportAsync ()
        {
    
            var path = "/v4/Reports/Tasks/AccountTaskSummary";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGenerateTaskSummaryReportAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGenerateTaskSummaryReportAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AccountTaskSummaryReport) ApiClient.Deserialize(response.Content, typeof(AccountTaskSummaryReport), response.Headers);
        }
    
        /// <summary>
        /// Generates a report of what users can access a set of accounts 
        /// </summary>
        /// <param name="accountIds">Comma-separated list of accounts to report access for. Will report on all accounts by default. (preferred over filter)</param>
        /// <param name="accessRequestType">Only report on access via a specific request type (preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for entitlement queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserAccountEntitlement&gt;</returns>
        public List<UserAccountEntitlement> ReportsGetAccountEntitlementsAsync (string accountIds, AccessRequestType accessRequestType, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Reports/Entitlements/AccountEntitlements";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accountIds != null) queryParams.Add("accountIds", ApiClient.ParameterToString(accountIds)); // query parameter
 if (accessRequestType != null) queryParams.Add("accessRequestType", ApiClient.ParameterToString(accessRequestType)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetAccountEntitlementsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetAccountEntitlementsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserAccountEntitlement>) ApiClient.Deserialize(response.Content, typeof(List<UserAccountEntitlement>), response.Headers);
        }
    
        /// <summary>
        /// Generates a report of what users can access accounts on a set of policy assets 
        /// </summary>
        /// <param name="assetIds">Comma-separated list of policy assets to report access for. Will report on all assets by default. (preferred over filter)</param>
        /// <param name="accessRequestType">Only report on access via a specific request type (preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for entitlement queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserAccountEntitlement&gt;</returns>
        public List<UserAccountEntitlement> ReportsGetAssetEntitlementsAsync (string assetIds, AccessRequestType accessRequestType, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Reports/Entitlements/AssetEntitlements";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (assetIds != null) queryParams.Add("assetIds", ApiClient.ParameterToString(assetIds)); // query parameter
 if (accessRequestType != null) queryParams.Add("accessRequestType", ApiClient.ParameterToString(accessRequestType)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetAssetEntitlementsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetAssetEntitlementsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserAccountEntitlement>) ApiClient.Deserialize(response.Content, typeof(List<UserAccountEntitlement>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of report categories 
        /// </summary>
        /// <returns>List&lt;EntitlementReportTypes&gt;</returns>
        public List<EntitlementReportTypes> ReportsGetEntitlementReportTypes ()
        {
    
            var path = "/v4/Reports/Entitlements";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetEntitlementReportTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetEntitlementReportTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<EntitlementReportTypes>) ApiClient.Deserialize(response.Content, typeof(List<EntitlementReportTypes>), response.Headers);
        }
    
        /// <summary>
        /// Generates a report of owned items by type: Account, Asset, Partition, Tag, User 
        /// </summary>
        /// <param name="reportType">Ownership Report Type</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipReportType&gt;</returns>
        public List<UserOwnershipReportType> ReportsGetOwnershipReportByTypeAsync (OwnershipReportTypes reportType, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'reportType' is set
            if (reportType == null) throw new ApiException(400, "Missing required parameter 'reportType' when calling ReportsGetOwnershipReportByTypeAsync");
    
            var path = "/v4/Reports/Ownership/{reportType}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "reportType" + "}", ApiClient.ParameterToString(reportType));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportByTypeAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportByTypeAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserOwnershipReportType>) ApiClient.Deserialize(response.Content, typeof(List<UserOwnershipReportType>), response.Headers);
        }
    
        /// <summary>
        /// Generates a report of how a user owns an item 
        /// </summary>
        /// <param name="userId">Ownership User Id</param>
        /// <param name="itemId">Ownership Item Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>UserOwnershipDetail</returns>
        public UserOwnershipDetail ReportsGetOwnershipReportDetailsByUserIdItemIdAsync (int? userId, int? itemId, string filter, int? page, int? limit, string fields, string orderby, string q)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling ReportsGetOwnershipReportDetailsByUserIdItemIdAsync");
            // verify the required parameter 'itemId' is set
            if (itemId == null) throw new ApiException(400, "Missing required parameter 'itemId' when calling ReportsGetOwnershipReportDetailsByUserIdItemIdAsync");
    
            var path = "/v4/Reports/Ownership/User/{userId}/Item/{itemId}/Details";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "itemId" + "}", ApiClient.ParameterToString(itemId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportDetailsByUserIdItemIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportDetailsByUserIdItemIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserOwnershipDetail) ApiClient.Deserialize(response.Content, typeof(UserOwnershipDetail), response.Headers);
        }
    
        /// <summary>
        /// Generates a report of how a user owns an item by tag 
        /// </summary>
        /// <param name="userId">Ownership User Id</param>
        /// <param name="itemId">Ownership Item Id</param>
        /// <param name="tagId">Ownership Tag Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>UserOwnershipDetail</returns>
        public UserOwnershipDetail ReportsGetOwnershipReportDetailsByUserIdItemIdTagIdAsync (int? userId, int? itemId, int? tagId, string filter, int? page, int? limit, string fields, string orderby, string q)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling ReportsGetOwnershipReportDetailsByUserIdItemIdTagIdAsync");
            // verify the required parameter 'itemId' is set
            if (itemId == null) throw new ApiException(400, "Missing required parameter 'itemId' when calling ReportsGetOwnershipReportDetailsByUserIdItemIdTagIdAsync");
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling ReportsGetOwnershipReportDetailsByUserIdItemIdTagIdAsync");
    
            var path = "/v4/Reports/Ownership/User/{userId}/Item/{itemId}/Tag/{tagId}/Details";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));
path = path.Replace("{" + "itemId" + "}", ApiClient.ParameterToString(itemId));
path = path.Replace("{" + "tagId" + "}", ApiClient.ParameterToString(tagId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "BearerAuth", "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportDetailsByUserIdItemIdTagIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportDetailsByUserIdItemIdTagIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserOwnershipDetail) ApiClient.Deserialize(response.Content, typeof(UserOwnershipDetail), response.Headers);
        }
    
        /// <summary>
        /// Generates a report of a set of items by tag 
        /// </summary>
        /// <param name="tagId">Ownership Tag Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        public List<UserOwnershipDetail> ReportsGetOwnershipReportItemsByTagIdAsync (int? tagId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling ReportsGetOwnershipReportItemsByTagIdAsync");
    
            var path = "/v4/Reports/Ownership/Tag/{tagId}/Items";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportItemsByTagIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportItemsByTagIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserOwnershipDetail>) ApiClient.Deserialize(response.Content, typeof(List<UserOwnershipDetail>), response.Headers);
        }
    
        /// <summary>
        /// Generates a report of a set of items by user 
        /// </summary>
        /// <param name="userId">Ownership User Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        public List<UserOwnershipDetail> ReportsGetOwnershipReportItemsByUserIdAsync (int? userId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling ReportsGetOwnershipReportItemsByUserIdAsync");
    
            var path = "/v4/Reports/Ownership/User/{userId}/Items";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportItemsByUserIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportItemsByUserIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserOwnershipDetail>) ApiClient.Deserialize(response.Content, typeof(List<UserOwnershipDetail>), response.Headers);
        }
    
        /// <summary>
        /// Generates a report of owners by account with parent asset and parent partition 
        /// </summary>
        /// <param name="accountId">Ownership Account Id</param>
        /// <param name="assetId">Ownership Asset Id</param>
        /// <param name="partitionId">Ownership Partition Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        public List<UserOwnershipDetail> ReportsGetOwnershipReportOwnersByAccountIdAssetIdPartitionIdAsync (int? accountId, int? assetId, int? partitionId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ReportsGetOwnershipReportOwnersByAccountIdAssetIdPartitionIdAsync");
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling ReportsGetOwnershipReportOwnersByAccountIdAssetIdPartitionIdAsync");
            // verify the required parameter 'partitionId' is set
            if (partitionId == null) throw new ApiException(400, "Missing required parameter 'partitionId' when calling ReportsGetOwnershipReportOwnersByAccountIdAssetIdPartitionIdAsync");
    
            var path = "/v4/Reports/Ownership/Account/{accountId}/Asset/{assetId}/AssetPartition/{partitionId}/Owners";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
path = path.Replace("{" + "partitionId" + "}", ApiClient.ParameterToString(partitionId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportOwnersByAccountIdAssetIdPartitionIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportOwnersByAccountIdAssetIdPartitionIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserOwnershipDetail>) ApiClient.Deserialize(response.Content, typeof(List<UserOwnershipDetail>), response.Headers);
        }
    
        /// <summary>
        /// Generates a report of owners by account 
        /// </summary>
        /// <param name="accountId">Ownership Account Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        public List<UserOwnershipDetail> ReportsGetOwnershipReportOwnersByAccountIdAsync (int? accountId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'accountId' is set
            if (accountId == null) throw new ApiException(400, "Missing required parameter 'accountId' when calling ReportsGetOwnershipReportOwnersByAccountIdAsync");
    
            var path = "/v4/Reports/Ownership/Account/{accountId}/Owners";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "accountId" + "}", ApiClient.ParameterToString(accountId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportOwnersByAccountIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportOwnersByAccountIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserOwnershipDetail>) ApiClient.Deserialize(response.Content, typeof(List<UserOwnershipDetail>), response.Headers);
        }
    
        /// <summary>
        /// Generates a report of owners by asset 
        /// </summary>
        /// <param name="assetId">Ownership Asset Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        public List<UserOwnershipDetail> ReportsGetOwnershipReportOwnersByAssetIdAsync (int? assetId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling ReportsGetOwnershipReportOwnersByAssetIdAsync");
    
            var path = "/v4/Reports/Ownership/Asset/{assetId}/Owners";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportOwnersByAssetIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportOwnersByAssetIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserOwnershipDetail>) ApiClient.Deserialize(response.Content, typeof(List<UserOwnershipDetail>), response.Headers);
        }
    
        /// <summary>
        /// Generates a report of owners by asset and parent partition 
        /// </summary>
        /// <param name="assetId">Ownership Asset Id</param>
        /// <param name="partitionId">Ownership Partition Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        public List<UserOwnershipDetail> ReportsGetOwnershipReportOwnersByAssetIdPartitionIdAsync (int? assetId, int? partitionId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'assetId' is set
            if (assetId == null) throw new ApiException(400, "Missing required parameter 'assetId' when calling ReportsGetOwnershipReportOwnersByAssetIdPartitionIdAsync");
            // verify the required parameter 'partitionId' is set
            if (partitionId == null) throw new ApiException(400, "Missing required parameter 'partitionId' when calling ReportsGetOwnershipReportOwnersByAssetIdPartitionIdAsync");
    
            var path = "/v4/Reports/Ownership/Asset/{assetId}/AssetPartition/{partitionId}/Owners";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "assetId" + "}", ApiClient.ParameterToString(assetId));
path = path.Replace("{" + "partitionId" + "}", ApiClient.ParameterToString(partitionId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportOwnersByAssetIdPartitionIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportOwnersByAssetIdPartitionIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserOwnershipDetail>) ApiClient.Deserialize(response.Content, typeof(List<UserOwnershipDetail>), response.Headers);
        }
    
        /// <summary>
        /// Generates a report of owners by partition 
        /// </summary>
        /// <param name="partitionId">Ownership Partition Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        public List<UserOwnershipDetail> ReportsGetOwnershipReportOwnersByPartitionIdAsync (int? partitionId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'partitionId' is set
            if (partitionId == null) throw new ApiException(400, "Missing required parameter 'partitionId' when calling ReportsGetOwnershipReportOwnersByPartitionIdAsync");
    
            var path = "/v4/Reports/Ownership/Partition/{partitionId}/Owners";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "partitionId" + "}", ApiClient.ParameterToString(partitionId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportOwnersByPartitionIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportOwnersByPartitionIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserOwnershipDetail>) ApiClient.Deserialize(response.Content, typeof(List<UserOwnershipDetail>), response.Headers);
        }
    
        /// <summary>
        /// Generates a report of owners by tag 
        /// </summary>
        /// <param name="tagId">Ownership Tag Id</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserOwnershipDetail&gt;</returns>
        public List<UserOwnershipDetail> ReportsGetOwnershipReportOwnersByTagIdAsync (int? tagId, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'tagId' is set
            if (tagId == null) throw new ApiException(400, "Missing required parameter 'tagId' when calling ReportsGetOwnershipReportOwnersByTagIdAsync");
    
            var path = "/v4/Reports/Ownership/Tag/{tagId}/Owners";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportOwnersByTagIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportOwnersByTagIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserOwnershipDetail>) ApiClient.Deserialize(response.Content, typeof(List<UserOwnershipDetail>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of report categories 
        /// </summary>
        /// <returns>List&lt;OwnershipReportTypes&gt;</returns>
        public List<OwnershipReportTypes> ReportsGetOwnershipReportTypes ()
        {
    
            var path = "/v4/Reports/Ownership";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetOwnershipReportTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<OwnershipReportTypes>) ApiClient.Deserialize(response.Content, typeof(List<OwnershipReportTypes>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of task report categories 
        /// </summary>
        /// <returns>List&lt;TaskReportTypes&gt;</returns>
        public List<TaskReportTypes> ReportsGetTaskReportTypes ()
        {
    
            var path = "/v4/Reports/Tasks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetTaskReportTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetTaskReportTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TaskReportTypes>) ApiClient.Deserialize(response.Content, typeof(List<TaskReportTypes>), response.Headers);
        }
    
        /// <summary>
        /// Generates a report of what accounts can be accessed by a set of users 
        /// </summary>
        /// <param name="userIds">Comma-separated list of users to report access for. Will report on all users by default. (preferred over filter)</param>
        /// <param name="accessRequestType">Only report on access via a specific request type (preferred over filter)</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.  WARNING - Not fully supported for entitlement queries</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;UserAccountEntitlement&gt;</returns>
        public List<UserAccountEntitlement> ReportsGetUserEntitlementsAsync (string userIds, AccessRequestType accessRequestType, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/Reports/Entitlements/UserEntitlements";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userIds != null) queryParams.Add("userIds", ApiClient.ParameterToString(userIds)); // query parameter
 if (accessRequestType != null) queryParams.Add("accessRequestType", ApiClient.ParameterToString(accessRequestType)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetUserEntitlementsAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetUserEntitlementsAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<UserAccountEntitlement>) ApiClient.Deserialize(response.Content, typeof(List<UserAccountEntitlement>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of report categories 
        /// </summary>
        /// <returns>List&lt;ReportCategories&gt;</returns>
        public List<ReportCategories> ReportsGetV3ReportCategories ()
        {
    
            var path = "/v4/Reports";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetV3ReportCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReportsGetV3ReportCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ReportCategories>) ApiClient.Deserialize(response.Content, typeof(List<ReportCategories>), response.Headers);
        }
    
    }
}
