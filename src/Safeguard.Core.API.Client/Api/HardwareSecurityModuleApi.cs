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
    public interface IHardwareSecurityModuleApi
    {
        /// <summary>
        /// Updates the appliances this client certificate is used by. 
        /// </summary>
        /// <param name="thumbprint"></param>
        /// <param name="body"></param>
        /// <returns>List&lt;Appliance&gt;</returns>
        List<Appliance> HardwareSecurityModuleAssignClientCertificateByThumbprintAsync (string thumbprint, List<Appliance> body);
        /// <summary>
        /// Deletes a client certificate. 
        /// </summary>
        /// <param name="thumbprint">The thumbprint of the certificate to delete.</param>
        /// <returns></returns>
        void HardwareSecurityModuleDeleteClientCertificatesAsync (string thumbprint);
        /// <summary>
        /// Disables the hardware security module integration. 
        /// </summary>
        /// <returns></returns>
        void HardwareSecurityModuleDeleteHardwareSecurityModuleAsync ();
        /// <summary>
        /// Deletes a server certificate. 
        /// </summary>
        /// <param name="thumbprint">The thumbprint of the certificate to delete.</param>
        /// <returns></returns>
        void HardwareSecurityModuleDeleteServerCertificatesAsync (string thumbprint);
        /// <summary>
        /// Gets the appliances the specified hardware security module certificate is used by. 
        /// </summary>
        /// <param name="thumbprint"></param>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="count"></param>
        /// <param name="fields"></param>
        /// <param name="orderby"></param>
        /// <param name="q"></param>
        /// <returns>List&lt;Appliance&gt;</returns>
        List<Appliance> HardwareSecurityModuleGetAppliancesByThumbprintAsync (string thumbprint, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets a hardware security module client certificate. 
        /// </summary>
        /// <param name="thumbprint"></param>
        /// <param name="fields"></param>
        /// <returns>SslCertificate</returns>
        SslCertificate HardwareSecurityModuleGetClientCertificateByThumbprintAsync (string thumbprint, string fields);
        /// <summary>
        /// Gets the hardware security module client certificates. 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="count"></param>
        /// <param name="fields"></param>
        /// <param name="orderby"></param>
        /// <param name="q"></param>
        /// <returns>List&lt;SslCertificate&gt;</returns>
        List<SslCertificate> HardwareSecurityModuleGetClientCertificatesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Gets the hardware security module integration status. 
        /// </summary>
        /// <returns>HardwareSecurityModuleStatus</returns>
        HardwareSecurityModuleStatus HardwareSecurityModuleGetHardwareSecurityModuleAsync ();
        /// <summary>
        /// Forces a health check, and gets the hardware security module integration status. 
        /// </summary>
        /// <returns>HardwareSecurityModuleStatus</returns>
        HardwareSecurityModuleStatus HardwareSecurityModuleGetHardwareSecurityModuleStatusAsync ();
        /// <summary>
        /// Gets a server certificate. 
        /// </summary>
        /// <param name="thumbprint">The thumbprint of the certificate.</param>
        /// <returns>ServerCertificate</returns>
        ServerCertificate HardwareSecurityModuleGetServerCertificateAsync (string thumbprint);
        /// <summary>
        /// Gets the server certificates. 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="count"></param>
        /// <param name="fields"></param>
        /// <param name="orderby"></param>
        /// <param name="q"></param>
        /// <returns>List&lt;ServerCertificate&gt;</returns>
        List<ServerCertificate> HardwareSecurityModuleGetServerCertificatesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Adds a hardware security module client certificate. 
        /// </summary>
        /// <param name="body">The client certificate to add.</param>
        /// <returns>SslCertificate</returns>
        SslCertificate HardwareSecurityModulePostClientCertificatesAsync (HardwareSecurityModuleClientCertificate body);
        /// <summary>
        /// Enables the hardware security module integration for the cluster. 
        /// </summary>
        /// <param name="body">The hardware security module configuration details.</param>
        /// <returns></returns>
        void HardwareSecurityModulePostHardwareSecurityModuleAsync (HardwareSecurityModuleConfiguration body);
        /// <summary>
        /// Adds a server certificate. 
        /// </summary>
        /// <param name="body">The server certificate to add.</param>
        /// <returns>ServerCertificate</returns>
        ServerCertificate HardwareSecurityModulePostServerCertificatesAsync (string body);
        /// <summary>
        /// Updates the hardware security module configuration. 
        /// </summary>
        /// <param name="body">The hardware security module configuration details.</param>
        /// <returns>HardwareSecurityModuleStatus</returns>
        HardwareSecurityModuleStatus HardwareSecurityModulePutHardwareSecurityModuleAsync (HardwareSecurityModuleConfiguration body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HardwareSecurityModuleApi : IHardwareSecurityModuleApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareSecurityModuleApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public HardwareSecurityModuleApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HardwareSecurityModuleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HardwareSecurityModuleApi(String basePath)
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
        /// Updates the appliances this client certificate is used by. 
        /// </summary>
        /// <param name="thumbprint"></param>
        /// <param name="body"></param>
        /// <returns>List&lt;Appliance&gt;</returns>
        public List<Appliance> HardwareSecurityModuleAssignClientCertificateByThumbprintAsync (string thumbprint, List<Appliance> body)
        {
            // verify the required parameter 'thumbprint' is set
            if (thumbprint == null) throw new ApiException(400, "Missing required parameter 'thumbprint' when calling HardwareSecurityModuleAssignClientCertificateByThumbprintAsync");
    
            var path = "/v4/HardwareSecurityModule/ClientCertificates/{thumbprint}/Appliances";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleAssignClientCertificateByThumbprintAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleAssignClientCertificateByThumbprintAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Appliance>) ApiClient.Deserialize(response.Content, typeof(List<Appliance>), response.Headers);
        }
    
        /// <summary>
        /// Deletes a client certificate. 
        /// </summary>
        /// <param name="thumbprint">The thumbprint of the certificate to delete.</param>
        /// <returns></returns>
        public void HardwareSecurityModuleDeleteClientCertificatesAsync (string thumbprint)
        {
            // verify the required parameter 'thumbprint' is set
            if (thumbprint == null) throw new ApiException(400, "Missing required parameter 'thumbprint' when calling HardwareSecurityModuleDeleteClientCertificatesAsync");
    
            var path = "/v4/HardwareSecurityModule/ClientCertificates/{thumbprint}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleDeleteClientCertificatesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleDeleteClientCertificatesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Disables the hardware security module integration. 
        /// </summary>
        /// <returns></returns>
        public void HardwareSecurityModuleDeleteHardwareSecurityModuleAsync ()
        {
    
            var path = "/v4/HardwareSecurityModule";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleDeleteHardwareSecurityModuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleDeleteHardwareSecurityModuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Deletes a server certificate. 
        /// </summary>
        /// <param name="thumbprint">The thumbprint of the certificate to delete.</param>
        /// <returns></returns>
        public void HardwareSecurityModuleDeleteServerCertificatesAsync (string thumbprint)
        {
            // verify the required parameter 'thumbprint' is set
            if (thumbprint == null) throw new ApiException(400, "Missing required parameter 'thumbprint' when calling HardwareSecurityModuleDeleteServerCertificatesAsync");
    
            var path = "/v4/HardwareSecurityModule/ServerCertificates/{thumbprint}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleDeleteServerCertificatesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleDeleteServerCertificatesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the appliances the specified hardware security module certificate is used by. 
        /// </summary>
        /// <param name="thumbprint"></param>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="count"></param>
        /// <param name="fields"></param>
        /// <param name="orderby"></param>
        /// <param name="q"></param>
        /// <returns>List&lt;Appliance&gt;</returns>
        public List<Appliance> HardwareSecurityModuleGetAppliancesByThumbprintAsync (string thumbprint, string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
            // verify the required parameter 'thumbprint' is set
            if (thumbprint == null) throw new ApiException(400, "Missing required parameter 'thumbprint' when calling HardwareSecurityModuleGetAppliancesByThumbprintAsync");
    
            var path = "/v4/HardwareSecurityModule/ClientCertificates/{thumbprint}/Appliances";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleGetAppliancesByThumbprintAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleGetAppliancesByThumbprintAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Appliance>) ApiClient.Deserialize(response.Content, typeof(List<Appliance>), response.Headers);
        }
    
        /// <summary>
        /// Gets a hardware security module client certificate. 
        /// </summary>
        /// <param name="thumbprint"></param>
        /// <param name="fields"></param>
        /// <returns>SslCertificate</returns>
        public SslCertificate HardwareSecurityModuleGetClientCertificateByThumbprintAsync (string thumbprint, string fields)
        {
            // verify the required parameter 'thumbprint' is set
            if (thumbprint == null) throw new ApiException(400, "Missing required parameter 'thumbprint' when calling HardwareSecurityModuleGetClientCertificateByThumbprintAsync");
    
            var path = "/v4/HardwareSecurityModule/ClientCertificates/{thumbprint}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleGetClientCertificateByThumbprintAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleGetClientCertificateByThumbprintAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SslCertificate) ApiClient.Deserialize(response.Content, typeof(SslCertificate), response.Headers);
        }
    
        /// <summary>
        /// Gets the hardware security module client certificates. 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="count"></param>
        /// <param name="fields"></param>
        /// <param name="orderby"></param>
        /// <param name="q"></param>
        /// <returns>List&lt;SslCertificate&gt;</returns>
        public List<SslCertificate> HardwareSecurityModuleGetClientCertificatesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/HardwareSecurityModule/ClientCertificates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleGetClientCertificatesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleGetClientCertificatesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<SslCertificate>) ApiClient.Deserialize(response.Content, typeof(List<SslCertificate>), response.Headers);
        }
    
        /// <summary>
        /// Gets the hardware security module integration status. 
        /// </summary>
        /// <returns>HardwareSecurityModuleStatus</returns>
        public HardwareSecurityModuleStatus HardwareSecurityModuleGetHardwareSecurityModuleAsync ()
        {
    
            var path = "/v4/HardwareSecurityModule";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleGetHardwareSecurityModuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleGetHardwareSecurityModuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HardwareSecurityModuleStatus) ApiClient.Deserialize(response.Content, typeof(HardwareSecurityModuleStatus), response.Headers);
        }
    
        /// <summary>
        /// Forces a health check, and gets the hardware security module integration status. 
        /// </summary>
        /// <returns>HardwareSecurityModuleStatus</returns>
        public HardwareSecurityModuleStatus HardwareSecurityModuleGetHardwareSecurityModuleStatusAsync ()
        {
    
            var path = "/v4/HardwareSecurityModule/Status";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleGetHardwareSecurityModuleStatusAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleGetHardwareSecurityModuleStatusAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HardwareSecurityModuleStatus) ApiClient.Deserialize(response.Content, typeof(HardwareSecurityModuleStatus), response.Headers);
        }
    
        /// <summary>
        /// Gets a server certificate. 
        /// </summary>
        /// <param name="thumbprint">The thumbprint of the certificate.</param>
        /// <returns>ServerCertificate</returns>
        public ServerCertificate HardwareSecurityModuleGetServerCertificateAsync (string thumbprint)
        {
            // verify the required parameter 'thumbprint' is set
            if (thumbprint == null) throw new ApiException(400, "Missing required parameter 'thumbprint' when calling HardwareSecurityModuleGetServerCertificateAsync");
    
            var path = "/v4/HardwareSecurityModule/ServerCertificates/{thumbprint}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleGetServerCertificateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleGetServerCertificateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServerCertificate) ApiClient.Deserialize(response.Content, typeof(ServerCertificate), response.Headers);
        }
    
        /// <summary>
        /// Gets the server certificates. 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="count"></param>
        /// <param name="fields"></param>
        /// <param name="orderby"></param>
        /// <param name="q"></param>
        /// <returns>List&lt;ServerCertificate&gt;</returns>
        public List<ServerCertificate> HardwareSecurityModuleGetServerCertificatesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/HardwareSecurityModule/ServerCertificates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleGetServerCertificatesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModuleGetServerCertificatesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ServerCertificate>) ApiClient.Deserialize(response.Content, typeof(List<ServerCertificate>), response.Headers);
        }
    
        /// <summary>
        /// Adds a hardware security module client certificate. 
        /// </summary>
        /// <param name="body">The client certificate to add.</param>
        /// <returns>SslCertificate</returns>
        public SslCertificate HardwareSecurityModulePostClientCertificatesAsync (HardwareSecurityModuleClientCertificate body)
        {
    
            var path = "/v4/HardwareSecurityModule/ClientCertificates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModulePostClientCertificatesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModulePostClientCertificatesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SslCertificate) ApiClient.Deserialize(response.Content, typeof(SslCertificate), response.Headers);
        }
    
        /// <summary>
        /// Enables the hardware security module integration for the cluster. 
        /// </summary>
        /// <param name="body">The hardware security module configuration details.</param>
        /// <returns></returns>
        public void HardwareSecurityModulePostHardwareSecurityModuleAsync (HardwareSecurityModuleConfiguration body)
        {
    
            var path = "/v4/HardwareSecurityModule";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModulePostHardwareSecurityModuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModulePostHardwareSecurityModuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Adds a server certificate. 
        /// </summary>
        /// <param name="body">The server certificate to add.</param>
        /// <returns>ServerCertificate</returns>
        public ServerCertificate HardwareSecurityModulePostServerCertificatesAsync (string body)
        {
    
            var path = "/v4/HardwareSecurityModule/ServerCertificates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModulePostServerCertificatesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModulePostServerCertificatesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ServerCertificate) ApiClient.Deserialize(response.Content, typeof(ServerCertificate), response.Headers);
        }
    
        /// <summary>
        /// Updates the hardware security module configuration. 
        /// </summary>
        /// <param name="body">The hardware security module configuration details.</param>
        /// <returns>HardwareSecurityModuleStatus</returns>
        public HardwareSecurityModuleStatus HardwareSecurityModulePutHardwareSecurityModuleAsync (HardwareSecurityModuleConfiguration body)
        {
    
            var path = "/v4/HardwareSecurityModule";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModulePutHardwareSecurityModuleAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HardwareSecurityModulePutHardwareSecurityModuleAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HardwareSecurityModuleStatus) ApiClient.Deserialize(response.Content, typeof(HardwareSecurityModuleStatus), response.Headers);
        }
    
    }
}
