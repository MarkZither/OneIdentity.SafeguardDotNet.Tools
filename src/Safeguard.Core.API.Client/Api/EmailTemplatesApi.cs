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
    public interface IEmailTemplatesApi
    {
        /// <summary>
        /// Gets a single template 
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>EmailTemplate</returns>
        EmailTemplate EmailTemplatesGetEmailTemplateByIdAsync (EventName id, string fields);
        /// <summary>
        /// Gets the event associated with an email template 
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ModelEvent</returns>
        ModelEvent EmailTemplatesGetEmailTemplateEventAsync (EventName id, string fields);
        /// <summary>
        /// Gets a list of templates 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;EmailTemplate&gt;</returns>
        List<EmailTemplate> EmailTemplatesGetEmailTemplatesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q);
        /// <summary>
        /// Renders a sample event notification email using template data 
        /// </summary>
        /// <param name="body">Email template to render test email for</param>
        /// <returns>EmailTemplate</returns>
        EmailTemplate EmailTemplatesRenderEmailTemplateTestEmailAsync (EmailTemplate body);
        /// <summary>
        /// Renders a sample event notification email using a template 
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate</param>
        /// <returns>EmailTemplate</returns>
        EmailTemplate EmailTemplatesRenderEmailTemplateTestEmailByIdAsync (EventName id);
        /// <summary>
        /// Resets an email template to the default 
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate</param>
        /// <returns>EmailTemplate</returns>
        EmailTemplate EmailTemplatesResetEmailTemplateAsync (EventName id);
        /// <summary>
        /// Sends a sample event notification email using template data 
        /// </summary>
        /// <param name="body">Email template to render test email for</param>
        /// <returns>EmailTemplate</returns>
        EmailTemplate EmailTemplatesSendEmailTemplateTestEmailAsync (SendTestEmailParameters body);
        /// <summary>
        /// Sends a sample event notification email using a template 
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate</param>
        /// <param name="body">email address to send test email to</param>
        /// <returns>EmailTemplate</returns>
        EmailTemplate EmailTemplatesSendEmailTemplateTestEmailByIdAsync (EventName id, string body);
        /// <summary>
        /// Updates an email template 
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate to update</param>
        /// <param name="body">Updated EmailTemplate</param>
        /// <returns>EmailTemplate</returns>
        EmailTemplate EmailTemplatesUpdateEmailTemplateAsync (EventName id, EmailTemplate body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EmailTemplatesApi : IEmailTemplatesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplatesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EmailTemplatesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmailTemplatesApi(String basePath)
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
        /// Gets a single template 
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>EmailTemplate</returns>
        public EmailTemplate EmailTemplatesGetEmailTemplateByIdAsync (EventName id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EmailTemplatesGetEmailTemplateByIdAsync");
    
            var path = "/v4/EmailTemplates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesGetEmailTemplateByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesGetEmailTemplateByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EmailTemplate) ApiClient.Deserialize(response.Content, typeof(EmailTemplate), response.Headers);
        }
    
        /// <summary>
        /// Gets the event associated with an email template 
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <returns>ModelEvent</returns>
        public ModelEvent EmailTemplatesGetEmailTemplateEventAsync (EventName id, string fields)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EmailTemplatesGetEmailTemplateEventAsync");
    
            var path = "/v4/EmailTemplates/{id}/Event";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesGetEmailTemplateEventAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesGetEmailTemplateEventAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ModelEvent) ApiClient.Deserialize(response.Content, typeof(ModelEvent), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of templates 
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <returns>List&lt;EmailTemplate&gt;</returns>
        public List<EmailTemplate> EmailTemplatesGetEmailTemplatesAsync (string filter, int? page, int? limit, bool? count, string fields, string orderby, string q)
        {
    
            var path = "/v4/EmailTemplates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesGetEmailTemplatesAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesGetEmailTemplatesAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<EmailTemplate>) ApiClient.Deserialize(response.Content, typeof(List<EmailTemplate>), response.Headers);
        }
    
        /// <summary>
        /// Renders a sample event notification email using template data 
        /// </summary>
        /// <param name="body">Email template to render test email for</param>
        /// <returns>EmailTemplate</returns>
        public EmailTemplate EmailTemplatesRenderEmailTemplateTestEmailAsync (EmailTemplate body)
        {
    
            var path = "/v4/EmailTemplates/RenderTestEmail";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesRenderEmailTemplateTestEmailAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesRenderEmailTemplateTestEmailAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EmailTemplate) ApiClient.Deserialize(response.Content, typeof(EmailTemplate), response.Headers);
        }
    
        /// <summary>
        /// Renders a sample event notification email using a template 
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate</param>
        /// <returns>EmailTemplate</returns>
        public EmailTemplate EmailTemplatesRenderEmailTemplateTestEmailByIdAsync (EventName id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EmailTemplatesRenderEmailTemplateTestEmailByIdAsync");
    
            var path = "/v4/EmailTemplates/{id}/RenderTestEmail";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesRenderEmailTemplateTestEmailByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesRenderEmailTemplateTestEmailByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EmailTemplate) ApiClient.Deserialize(response.Content, typeof(EmailTemplate), response.Headers);
        }
    
        /// <summary>
        /// Resets an email template to the default 
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate</param>
        /// <returns>EmailTemplate</returns>
        public EmailTemplate EmailTemplatesResetEmailTemplateAsync (EventName id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EmailTemplatesResetEmailTemplateAsync");
    
            var path = "/v4/EmailTemplates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesResetEmailTemplateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesResetEmailTemplateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EmailTemplate) ApiClient.Deserialize(response.Content, typeof(EmailTemplate), response.Headers);
        }
    
        /// <summary>
        /// Sends a sample event notification email using template data 
        /// </summary>
        /// <param name="body">Email template to render test email for</param>
        /// <returns>EmailTemplate</returns>
        public EmailTemplate EmailTemplatesSendEmailTemplateTestEmailAsync (SendTestEmailParameters body)
        {
    
            var path = "/v4/EmailTemplates/SendTestEmail";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesSendEmailTemplateTestEmailAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesSendEmailTemplateTestEmailAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EmailTemplate) ApiClient.Deserialize(response.Content, typeof(EmailTemplate), response.Headers);
        }
    
        /// <summary>
        /// Sends a sample event notification email using a template 
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate</param>
        /// <param name="body">email address to send test email to</param>
        /// <returns>EmailTemplate</returns>
        public EmailTemplate EmailTemplatesSendEmailTemplateTestEmailByIdAsync (EventName id, string body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EmailTemplatesSendEmailTemplateTestEmailByIdAsync");
    
            var path = "/v4/EmailTemplates/{id}/SendTestEmail";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesSendEmailTemplateTestEmailByIdAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesSendEmailTemplateTestEmailByIdAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EmailTemplate) ApiClient.Deserialize(response.Content, typeof(EmailTemplate), response.Headers);
        }
    
        /// <summary>
        /// Updates an email template 
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate to update</param>
        /// <param name="body">Updated EmailTemplate</param>
        /// <returns>EmailTemplate</returns>
        public EmailTemplate EmailTemplatesUpdateEmailTemplateAsync (EventName id, EmailTemplate body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EmailTemplatesUpdateEmailTemplateAsync");
    
            var path = "/v4/EmailTemplates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesUpdateEmailTemplateAsync: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EmailTemplatesUpdateEmailTemplateAsync: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EmailTemplate) ApiClient.Deserialize(response.Content, typeof(EmailTemplate), response.Headers);
        }
    
    }
}
