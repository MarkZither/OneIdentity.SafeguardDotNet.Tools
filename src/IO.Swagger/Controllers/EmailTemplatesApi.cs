/*
 * Safeguard Core API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v4
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class EmailTemplatesApiController : ControllerBase
    { 
        /// <summary>
        /// Gets a single template
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/service/core/v4/EmailTemplates/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("EmailTemplatesGetEmailTemplateByIdAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(EmailTemplate), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Bad Request")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission")]
        public virtual IActionResult EmailTemplatesGetEmailTemplateByIdAsync([FromRoute][Required]EventName id, [FromQuery]string fields)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(EmailTemplate));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"ReplyToEmail\" : \"ReplyToEmail\",\n  \"SubjectTemplate\" : \"SubjectTemplate\",\n  \"Event\" : {\n    \"ActivityLogFlag\" : true,\n    \"AllowedAdminRoles\" : [ \"GlobalAdmin\", \"GlobalAdmin\" ],\n    \"Category\" : \"Unknown\",\n    \"Description\" : \"Description\",\n    \"SyslogFlag\" : true,\n    \"EmailFlag\" : true,\n    \"Properties\" : [ {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    }, {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    } ],\n    \"AllowPartitionOwner\" : true,\n    \"AsyncUnicastFlag\" : true,\n    \"SnmpFlag\" : true,\n    \"ObjectType\" : \"Unknown\",\n    \"Obsolete\" : true,\n    \"CategoryDisplayName\" : \"CategoryDisplayName\",\n    \"AsyncBroadcastFlag\" : true,\n    \"DisplayName\" : \"DisplayName\",\n    \"IsObjectAware\" : true,\n    \"Level\" : \"Debug\",\n    \"AsyncMulticastFlag\" : true\n  },\n  \"IsModified\" : true,\n  \"EventName\" : \"Unknown\",\n  \"BodyTemplate\" : \"BodyTemplate\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<EmailTemplate>(exampleJson)
                        : default(EmailTemplate);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Gets the event associated with an email template
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/service/core/v4/EmailTemplates/{id}/Event")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("EmailTemplatesGetEmailTemplateEventAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelEvent), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Bad Request")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission")]
        public virtual IActionResult EmailTemplatesGetEmailTemplateEventAsync([FromRoute][Required]EventName id, [FromQuery]string fields)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ModelEvent));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"ActivityLogFlag\" : true,\n  \"AllowedAdminRoles\" : [ \"GlobalAdmin\", \"GlobalAdmin\" ],\n  \"Category\" : \"Unknown\",\n  \"Description\" : \"Description\",\n  \"SyslogFlag\" : true,\n  \"EmailFlag\" : true,\n  \"Properties\" : [ {\n    \"Description\" : \"Description\",\n    \"IsCommon\" : true,\n    \"Name\" : \"Name\"\n  }, {\n    \"Description\" : \"Description\",\n    \"IsCommon\" : true,\n    \"Name\" : \"Name\"\n  } ],\n  \"AllowPartitionOwner\" : true,\n  \"AsyncUnicastFlag\" : true,\n  \"SnmpFlag\" : true,\n  \"ObjectType\" : \"Unknown\",\n  \"Obsolete\" : true,\n  \"CategoryDisplayName\" : \"CategoryDisplayName\",\n  \"AsyncBroadcastFlag\" : true,\n  \"DisplayName\" : \"DisplayName\",\n  \"IsObjectAware\" : true,\n  \"Level\" : \"Debug\",\n  \"AsyncMulticastFlag\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ModelEvent>(exampleJson)
                        : default(ModelEvent);            //TODO: Change the data returned
            return new ObjectResult(example);
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
        /// <response code="200">Success</response>
        /// <response code="403">Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission</response>
        [HttpGet]
        [Route("/service/core/v4/EmailTemplates")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("EmailTemplatesGetEmailTemplatesAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<EmailTemplate>), description: "Success")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission")]
        public virtual IActionResult EmailTemplatesGetEmailTemplatesAsync([FromQuery]string filter, [FromQuery]int? page, [FromQuery]int? limit, [FromQuery]bool? count, [FromQuery]string fields, [FromQuery]string orderby, [FromQuery]string q)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<EmailTemplate>));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "[ {\n  \"ReplyToEmail\" : \"ReplyToEmail\",\n  \"SubjectTemplate\" : \"SubjectTemplate\",\n  \"Event\" : {\n    \"ActivityLogFlag\" : true,\n    \"AllowedAdminRoles\" : [ \"GlobalAdmin\", \"GlobalAdmin\" ],\n    \"Category\" : \"Unknown\",\n    \"Description\" : \"Description\",\n    \"SyslogFlag\" : true,\n    \"EmailFlag\" : true,\n    \"Properties\" : [ {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    }, {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    } ],\n    \"AllowPartitionOwner\" : true,\n    \"AsyncUnicastFlag\" : true,\n    \"SnmpFlag\" : true,\n    \"ObjectType\" : \"Unknown\",\n    \"Obsolete\" : true,\n    \"CategoryDisplayName\" : \"CategoryDisplayName\",\n    \"AsyncBroadcastFlag\" : true,\n    \"DisplayName\" : \"DisplayName\",\n    \"IsObjectAware\" : true,\n    \"Level\" : \"Debug\",\n    \"AsyncMulticastFlag\" : true\n  },\n  \"IsModified\" : true,\n  \"EventName\" : \"Unknown\",\n  \"BodyTemplate\" : \"BodyTemplate\"\n}, {\n  \"ReplyToEmail\" : \"ReplyToEmail\",\n  \"SubjectTemplate\" : \"SubjectTemplate\",\n  \"Event\" : {\n    \"ActivityLogFlag\" : true,\n    \"AllowedAdminRoles\" : [ \"GlobalAdmin\", \"GlobalAdmin\" ],\n    \"Category\" : \"Unknown\",\n    \"Description\" : \"Description\",\n    \"SyslogFlag\" : true,\n    \"EmailFlag\" : true,\n    \"Properties\" : [ {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    }, {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    } ],\n    \"AllowPartitionOwner\" : true,\n    \"AsyncUnicastFlag\" : true,\n    \"SnmpFlag\" : true,\n    \"ObjectType\" : \"Unknown\",\n    \"Obsolete\" : true,\n    \"CategoryDisplayName\" : \"CategoryDisplayName\",\n    \"AsyncBroadcastFlag\" : true,\n    \"DisplayName\" : \"DisplayName\",\n    \"IsObjectAware\" : true,\n    \"Level\" : \"Debug\",\n    \"AsyncMulticastFlag\" : true\n  },\n  \"IsModified\" : true,\n  \"EventName\" : \"Unknown\",\n  \"BodyTemplate\" : \"BodyTemplate\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<EmailTemplate>>(exampleJson)
                        : default(List<EmailTemplate>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Renders a sample event notification email using template data
        /// </summary>
        /// <param name="body">Email template to render test email for</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission</response>
        [HttpPost]
        [Route("/service/core/v4/EmailTemplates/RenderTestEmail")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("EmailTemplatesRenderEmailTemplateTestEmailAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(EmailTemplate), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Bad Request")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission")]
        public virtual IActionResult EmailTemplatesRenderEmailTemplateTestEmailAsync([FromBody]EmailTemplate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(EmailTemplate));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "{\n  \"ReplyToEmail\" : \"ReplyToEmail\",\n  \"SubjectTemplate\" : \"SubjectTemplate\",\n  \"Event\" : {\n    \"ActivityLogFlag\" : true,\n    \"AllowedAdminRoles\" : [ \"GlobalAdmin\", \"GlobalAdmin\" ],\n    \"Category\" : \"Unknown\",\n    \"Description\" : \"Description\",\n    \"SyslogFlag\" : true,\n    \"EmailFlag\" : true,\n    \"Properties\" : [ {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    }, {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    } ],\n    \"AllowPartitionOwner\" : true,\n    \"AsyncUnicastFlag\" : true,\n    \"SnmpFlag\" : true,\n    \"ObjectType\" : \"Unknown\",\n    \"Obsolete\" : true,\n    \"CategoryDisplayName\" : \"CategoryDisplayName\",\n    \"AsyncBroadcastFlag\" : true,\n    \"DisplayName\" : \"DisplayName\",\n    \"IsObjectAware\" : true,\n    \"Level\" : \"Debug\",\n    \"AsyncMulticastFlag\" : true\n  },\n  \"IsModified\" : true,\n  \"EventName\" : \"Unknown\",\n  \"BodyTemplate\" : \"BodyTemplate\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<EmailTemplate>(exampleJson)
                        : default(EmailTemplate);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Renders a sample event notification email using a template
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission</response>
        /// <response code="404">Not Found</response>
        /// <response code="502">Email Delivery Failed</response>
        [HttpPost]
        [Route("/service/core/v4/EmailTemplates/{id}/RenderTestEmail")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("EmailTemplatesRenderEmailTemplateTestEmailByIdAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(EmailTemplate), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Bad Request")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission")]
        public virtual IActionResult EmailTemplatesRenderEmailTemplateTestEmailByIdAsync([FromRoute][Required]EventName id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(EmailTemplate));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 502 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(502);
            string exampleJson = null;
            exampleJson = "{\n  \"ReplyToEmail\" : \"ReplyToEmail\",\n  \"SubjectTemplate\" : \"SubjectTemplate\",\n  \"Event\" : {\n    \"ActivityLogFlag\" : true,\n    \"AllowedAdminRoles\" : [ \"GlobalAdmin\", \"GlobalAdmin\" ],\n    \"Category\" : \"Unknown\",\n    \"Description\" : \"Description\",\n    \"SyslogFlag\" : true,\n    \"EmailFlag\" : true,\n    \"Properties\" : [ {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    }, {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    } ],\n    \"AllowPartitionOwner\" : true,\n    \"AsyncUnicastFlag\" : true,\n    \"SnmpFlag\" : true,\n    \"ObjectType\" : \"Unknown\",\n    \"Obsolete\" : true,\n    \"CategoryDisplayName\" : \"CategoryDisplayName\",\n    \"AsyncBroadcastFlag\" : true,\n    \"DisplayName\" : \"DisplayName\",\n    \"IsObjectAware\" : true,\n    \"Level\" : \"Debug\",\n    \"AsyncMulticastFlag\" : true\n  },\n  \"IsModified\" : true,\n  \"EventName\" : \"Unknown\",\n  \"BodyTemplate\" : \"BodyTemplate\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<EmailTemplate>(exampleJson)
                        : default(EmailTemplate);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Resets an email template to the default
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate</param>
        /// <response code="200">Success</response>
        /// <response code="400">Bad Request</response>
        /// <response code="403">Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin or PartitionAdmin permission</response>
        /// <response code="404">Not Found</response>
        [HttpDelete]
        [Route("/service/core/v4/EmailTemplates/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("EmailTemplatesResetEmailTemplateAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(EmailTemplate), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Bad Request")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin or PartitionAdmin permission")]
        public virtual IActionResult EmailTemplatesResetEmailTemplateAsync([FromRoute][Required]EventName id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(EmailTemplate));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"ReplyToEmail\" : \"ReplyToEmail\",\n  \"SubjectTemplate\" : \"SubjectTemplate\",\n  \"Event\" : {\n    \"ActivityLogFlag\" : true,\n    \"AllowedAdminRoles\" : [ \"GlobalAdmin\", \"GlobalAdmin\" ],\n    \"Category\" : \"Unknown\",\n    \"Description\" : \"Description\",\n    \"SyslogFlag\" : true,\n    \"EmailFlag\" : true,\n    \"Properties\" : [ {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    }, {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    } ],\n    \"AllowPartitionOwner\" : true,\n    \"AsyncUnicastFlag\" : true,\n    \"SnmpFlag\" : true,\n    \"ObjectType\" : \"Unknown\",\n    \"Obsolete\" : true,\n    \"CategoryDisplayName\" : \"CategoryDisplayName\",\n    \"AsyncBroadcastFlag\" : true,\n    \"DisplayName\" : \"DisplayName\",\n    \"IsObjectAware\" : true,\n    \"Level\" : \"Debug\",\n    \"AsyncMulticastFlag\" : true\n  },\n  \"IsModified\" : true,\n  \"EventName\" : \"Unknown\",\n  \"BodyTemplate\" : \"BodyTemplate\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<EmailTemplate>(exampleJson)
                        : default(EmailTemplate);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Sends a sample event notification email using template data
        /// </summary>
        /// <param name="body">Email template to render test email for</param>
        /// <response code="200">Success</response>
        /// <response code="400">Email Delivery Failed</response>
        /// <response code="403">Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission</response>
        [HttpPost]
        [Route("/service/core/v4/EmailTemplates/SendTestEmail")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("EmailTemplatesSendEmailTemplateTestEmailAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(EmailTemplate), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Email Delivery Failed")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission")]
        public virtual IActionResult EmailTemplatesSendEmailTemplateTestEmailAsync([FromBody]SendTestEmailParameters body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(EmailTemplate));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "{\n  \"ReplyToEmail\" : \"ReplyToEmail\",\n  \"SubjectTemplate\" : \"SubjectTemplate\",\n  \"Event\" : {\n    \"ActivityLogFlag\" : true,\n    \"AllowedAdminRoles\" : [ \"GlobalAdmin\", \"GlobalAdmin\" ],\n    \"Category\" : \"Unknown\",\n    \"Description\" : \"Description\",\n    \"SyslogFlag\" : true,\n    \"EmailFlag\" : true,\n    \"Properties\" : [ {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    }, {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    } ],\n    \"AllowPartitionOwner\" : true,\n    \"AsyncUnicastFlag\" : true,\n    \"SnmpFlag\" : true,\n    \"ObjectType\" : \"Unknown\",\n    \"Obsolete\" : true,\n    \"CategoryDisplayName\" : \"CategoryDisplayName\",\n    \"AsyncBroadcastFlag\" : true,\n    \"DisplayName\" : \"DisplayName\",\n    \"IsObjectAware\" : true,\n    \"Level\" : \"Debug\",\n    \"AsyncMulticastFlag\" : true\n  },\n  \"IsModified\" : true,\n  \"EventName\" : \"Unknown\",\n  \"BodyTemplate\" : \"BodyTemplate\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<EmailTemplate>(exampleJson)
                        : default(EmailTemplate);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Sends a sample event notification email using a template
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate</param>
        /// <param name="body">email address to send test email to</param>
        /// <response code="200">Success</response>
        /// <response code="400">Email Delivery Failed</response>
        /// <response code="403">Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission</response>
        /// <response code="404">Not Found</response>
        [HttpPost]
        [Route("/service/core/v4/EmailTemplates/{id}/SendTestEmail")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("EmailTemplatesSendEmailTemplateTestEmailByIdAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(EmailTemplate), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "Email Delivery Failed")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin, PartitionAdmin, ApplicationAuditor, SystemAuditor or Auditor permission")]
        public virtual IActionResult EmailTemplatesSendEmailTemplateTestEmailByIdAsync([FromRoute][Required]EventName id, [FromBody]string body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(EmailTemplate));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"ReplyToEmail\" : \"ReplyToEmail\",\n  \"SubjectTemplate\" : \"SubjectTemplate\",\n  \"Event\" : {\n    \"ActivityLogFlag\" : true,\n    \"AllowedAdminRoles\" : [ \"GlobalAdmin\", \"GlobalAdmin\" ],\n    \"Category\" : \"Unknown\",\n    \"Description\" : \"Description\",\n    \"SyslogFlag\" : true,\n    \"EmailFlag\" : true,\n    \"Properties\" : [ {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    }, {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    } ],\n    \"AllowPartitionOwner\" : true,\n    \"AsyncUnicastFlag\" : true,\n    \"SnmpFlag\" : true,\n    \"ObjectType\" : \"Unknown\",\n    \"Obsolete\" : true,\n    \"CategoryDisplayName\" : \"CategoryDisplayName\",\n    \"AsyncBroadcastFlag\" : true,\n    \"DisplayName\" : \"DisplayName\",\n    \"IsObjectAware\" : true,\n    \"Level\" : \"Debug\",\n    \"AsyncMulticastFlag\" : true\n  },\n  \"IsModified\" : true,\n  \"EventName\" : \"Unknown\",\n  \"BodyTemplate\" : \"BodyTemplate\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<EmailTemplate>(exampleJson)
                        : default(EmailTemplate);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Updates an email template
        /// </summary>
        /// <param name="id">Unique identifier of the EmailTemplate to update</param>
        /// <param name="body">Updated EmailTemplate</param>
        /// <response code="200">Success</response>
        /// <response code="400">60102 - id value does not match the resource URI</response>
        /// <response code="403">Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin or PartitionAdmin permission</response>
        /// <response code="404">EmailTemplate does not exist</response>
        [HttpPut]
        [Route("/service/core/v4/EmailTemplates/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("EmailTemplatesUpdateEmailTemplateAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(EmailTemplate), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "60102 - id value does not match the resource URI")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have HelpdeskAdmin, OperationsAdmin, PolicyAdmin, AssetAdmin or PartitionAdmin permission")]
        public virtual IActionResult EmailTemplatesUpdateEmailTemplateAsync([FromRoute][Required]EventName id, [FromBody]EmailTemplate body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(EmailTemplate));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"ReplyToEmail\" : \"ReplyToEmail\",\n  \"SubjectTemplate\" : \"SubjectTemplate\",\n  \"Event\" : {\n    \"ActivityLogFlag\" : true,\n    \"AllowedAdminRoles\" : [ \"GlobalAdmin\", \"GlobalAdmin\" ],\n    \"Category\" : \"Unknown\",\n    \"Description\" : \"Description\",\n    \"SyslogFlag\" : true,\n    \"EmailFlag\" : true,\n    \"Properties\" : [ {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    }, {\n      \"Description\" : \"Description\",\n      \"IsCommon\" : true,\n      \"Name\" : \"Name\"\n    } ],\n    \"AllowPartitionOwner\" : true,\n    \"AsyncUnicastFlag\" : true,\n    \"SnmpFlag\" : true,\n    \"ObjectType\" : \"Unknown\",\n    \"Obsolete\" : true,\n    \"CategoryDisplayName\" : \"CategoryDisplayName\",\n    \"AsyncBroadcastFlag\" : true,\n    \"DisplayName\" : \"DisplayName\",\n    \"IsObjectAware\" : true,\n    \"Level\" : \"Debug\",\n    \"AsyncMulticastFlag\" : true\n  },\n  \"IsModified\" : true,\n  \"EventName\" : \"Unknown\",\n  \"BodyTemplate\" : \"BodyTemplate\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<EmailTemplate>(exampleJson)
                        : default(EmailTemplate);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
