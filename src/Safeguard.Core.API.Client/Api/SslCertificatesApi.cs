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
    public interface ISslCertificatesApi
    {
        /// <summary>
        /// Update the appliances this SSL certificate is used by. 
        /// </summary>
        /// <param name="thumbprint">thumbprint of SSL certificate</param>
        /// <param name="body">Appliances to update</param>
        /// <returns>List&lt;Appliance&gt;</returns>
        List<Appliance> SslCertificatesAssignSslCertificateAsync (string thumbprint, List<Appliance> body);
        /// <summary>
        /// Gets the appliances the specified certificate is used by 
        /// </summary>
        /// <param name="thumbprint">thumbprint of SSL certificate</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Appliance&gt;</returns>
        List<Appliance> SslCertificatesGetAppliancesAsync (string thumbprint, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the currently installed SSL certificates 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SslCertificate&gt;</returns>
        List<SslCertificate> SslCertificatesGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a specific SSL certificate 
        /// </summary>
        /// <param name="thumbprint">Thumbprint of certificate</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SslCertificate</returns>
        SslCertificate SslCertificatesGetByThumbprintAsync (string thumbprint, string fields);
        /// <summary>
        /// Installs the SSL cert and assigns it to cluster appliances. 
        /// </summary>
        /// <param name="body">Updated ServerCertificate</param>
        /// <returns>SslCertificate</returns>
        SslCertificate SslCertificatesInstallCertificateAsync (SslCertificate body);
        /// <summary>
        /// Remove a specific SSL certificate 
        /// </summary>
        /// <param name="thumbprint">Thumbprint of certificate</param>
        /// <returns></returns>
        void SslCertificatesRemoveByThumbprintAsync (string thumbprint);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SslCertificatesApi : ISslCertificatesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SslCertificatesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SslCertificatesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SslCertificatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SslCertificatesApi(String basePath)
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
        /// Update the appliances this SSL certificate is used by. 
        /// </summary>
        /// <param name="thumbprint">thumbprint of SSL certificate</param>
        /// <param name="body">Appliances to update</param>
        /// <returns>List&lt;Appliance&gt;</returns>
        public List<Appliance> SslCertificatesAssignSslCertificateAsync (string thumbprint, List<Appliance> body)
        {
            // verify the required parameter 'thumbprint' is set
            if (thumbprint == null) throw new ApiException(400, "Missing required parameter 'thumbprint' when calling SslCertificatesAssignSslCertificateAsync");
    
            var path = "/v4/SslCertificates/{thumbprint}/Appliances";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "thumbprint" + "}", ApiClient.ParameterToString(thumbprint));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SslCertificatesAssignSslCertificateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SslCertificatesAssignSslCertificateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Appliance>) ApiClient.Deserialize(response.Content, typeof(List<Appliance>), response.Headers);
        }
    
        /// <summary>
        /// Gets the appliances the specified certificate is used by 
        /// </summary>
        /// <param name="thumbprint">thumbprint of SSL certificate</param>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;Appliance&gt;</returns>
        public List<Appliance> SslCertificatesGetAppliancesAsync (string thumbprint, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'thumbprint' is set
            if (thumbprint == null) throw new ApiException(400, "Missing required parameter 'thumbprint' when calling SslCertificatesGetAppliancesAsync");
    
            var path = "/v4/SslCertificates/{thumbprint}/Appliances";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "thumbprint" + "}", ApiClient.ParameterToString(thumbprint));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SslCertificatesGetAppliancesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SslCertificatesGetAppliancesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Appliance>) ApiClient.Deserialize(response.Content, typeof(List<Appliance>), response.Headers);
        }
    
        /// <summary>
        /// Gets the currently installed SSL certificates 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;SslCertificate&gt;</returns>
        public List<SslCertificate> SslCertificatesGetAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/SslCertificates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SslCertificatesGetAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SslCertificatesGetAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SslCertificate>) ApiClient.Deserialize(response.Content, typeof(List<SslCertificate>), response.Headers);
        }
    
        /// <summary>
        /// Gets a specific SSL certificate 
        /// </summary>
        /// <param name="thumbprint">Thumbprint of certificate</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>SslCertificate</returns>
        public SslCertificate SslCertificatesGetByThumbprintAsync (string thumbprint, string fields)
        {
            // verify the required parameter 'thumbprint' is set
            if (thumbprint == null) throw new ApiException(400, "Missing required parameter 'thumbprint' when calling SslCertificatesGetByThumbprintAsync");
    
            var path = "/v4/SslCertificates/{thumbprint}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "thumbprint" + "}", ApiClient.ParameterToString(thumbprint));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SslCertificatesGetByThumbprintAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SslCertificatesGetByThumbprintAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SslCertificate) ApiClient.Deserialize(response.Content, typeof(SslCertificate), response.Headers);
        }
    
        /// <summary>
        /// Installs the SSL cert and assigns it to cluster appliances. 
        /// </summary>
        /// <param name="body">Updated ServerCertificate</param>
        /// <returns>SslCertificate</returns>
        public SslCertificate SslCertificatesInstallCertificateAsync (SslCertificate body)
        {
    
            var path = "/v4/SslCertificates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SslCertificatesInstallCertificateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SslCertificatesInstallCertificateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SslCertificate) ApiClient.Deserialize(response.Content, typeof(SslCertificate), response.Headers);
        }
    
        /// <summary>
        /// Remove a specific SSL certificate 
        /// </summary>
        /// <param name="thumbprint">Thumbprint of certificate</param>
        /// <returns></returns>
        public void SslCertificatesRemoveByThumbprintAsync (string thumbprint)
        {
            // verify the required parameter 'thumbprint' is set
            if (thumbprint == null) throw new ApiException(400, "Missing required parameter 'thumbprint' when calling SslCertificatesRemoveByThumbprintAsync");
    
            var path = "/v4/SslCertificates/{thumbprint}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "thumbprint" + "}", ApiClient.ParameterToString(thumbprint));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SslCertificatesRemoveByThumbprintAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SslCertificatesRemoveByThumbprintAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
