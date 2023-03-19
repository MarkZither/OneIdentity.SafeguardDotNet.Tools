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
    public class AuthenticationProvidersApiController : ControllerBase
    { 
        /// <summary>
        /// Any authentication provider that was marked as the default will be cleared such that the              system will not have a default provider and the login page will display a drop down list of all              available authentication providers for the user to choose from.
        /// </summary>
        /// <response code="204">Success - No Content</response>
        /// <response code="403">Must have GlobalAdmin or ApplianceAdmin permission</response>
        [HttpPost]
        [Route("/service/core/v4/AuthenticationProviders/ClearDefault")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("AuthenticationProvidersClearDefaultAsync")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have GlobalAdmin or ApplianceAdmin permission")]
        public virtual IActionResult AuthenticationProvidersClearDefaultAsync()
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            throw new NotImplementedException();
        }

        /// <summary>
        /// When set to {true} on a provider, the login page will not display a drop down list              of all available providers. Instead, the end user will be defaulted in to using the specified provider.              Only one provider can be marked as the default at a time. When updating the specified provider,              any previously set default will be cleared.              &lt;br&gt;If a default provider is set and you need to log in using some other provider, like the              Safeguard Local provider in order to log in as a local administrator user, a query string parameter              can be appended to the login page URL, &#x27;primaryProviderID&#x27;, where the value is set to the &#x27;RstsProviderId&#x27;              you need. For example, \&quot;https://&lt;safeguard&gt;/RSTS/Login?response_type&#x3D;token&amp;redirect_uri&#x3D;https%3A%2F%2F&lt;safeguard&gt;%2F&amp;primaryProviderID&#x3D;local\&quot;.&lt;br&gt;You cannot set a provider that is used for two-factor authentication as the default.&lt;br&gt;This functionality is only applicable to web browser based logins, not programmatic API/OAuth2 logins.
        /// </summary>
        /// <param name="id">Unique ID of the AuthenticationProvider</param>
        /// <response code="200">Success</response>
        /// <response code="400">60932 - A provider used for two-factor authentication cannot be set as the default.</response>
        /// <response code="403">Must have GlobalAdmin or ApplianceAdmin permission</response>
        /// <response code="404">Authentication provider not found</response>
        [HttpPost]
        [Route("/service/core/v4/AuthenticationProviders/{id}/ForceAsDefault")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("AuthenticationProvidersForceAsDefaultAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(AuthenticationProvider), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "60932 - A provider used for two-factor authentication cannot be set as the default.")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have GlobalAdmin or ApplianceAdmin permission")]
        public virtual IActionResult AuthenticationProvidersForceAsDefaultAsync([FromRoute][Required]int? id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AuthenticationProvider));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"RstsProviderId\" : \"RstsProviderId\",\n  \"IdentityProviderId\" : 6,\n  \"RstsProviderScope\" : \"RstsProviderScope\",\n  \"TypeReferenceName\" : \"Unknown\",\n  \"Id\" : 0,\n  \"ForceAsDefault\" : true,\n  \"Name\" : \"Name\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<AuthenticationProvider>(exampleJson)
                        : default(AuthenticationProvider);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Gets a queryable list of authentication providers
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, contains, ieq, icontains, in [ {item1}, {item2}, etc], (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <response code="200">Success</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/service/core/v4/AuthenticationProviders")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("AuthenticationProvidersGetAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<AuthenticationProvider>), description: "Success")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Forbidden")]
        public virtual IActionResult AuthenticationProvidersGetAsync([FromQuery]string filter, [FromQuery]int? page, [FromQuery]int? limit, [FromQuery]bool? count, [FromQuery]string fields, [FromQuery]string orderby, [FromQuery]string q)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<AuthenticationProvider>));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "[ {\n  \"RstsProviderId\" : \"RstsProviderId\",\n  \"IdentityProviderId\" : 6,\n  \"RstsProviderScope\" : \"RstsProviderScope\",\n  \"TypeReferenceName\" : \"Unknown\",\n  \"Id\" : 0,\n  \"ForceAsDefault\" : true,\n  \"Name\" : \"Name\"\n}, {\n  \"RstsProviderId\" : \"RstsProviderId\",\n  \"IdentityProviderId\" : 6,\n  \"RstsProviderScope\" : \"RstsProviderScope\",\n  \"TypeReferenceName\" : \"Unknown\",\n  \"Id\" : 0,\n  \"ForceAsDefault\" : true,\n  \"Name\" : \"Name\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<AuthenticationProvider>>(exampleJson)
                        : default(List<AuthenticationProvider>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Gets a single authentication provider
        /// </summary>
        /// <param name="id">Unique ID of AuthenticationProvider</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <response code="200">Success</response>
        /// <response code="403">Forbidden</response>
        /// <response code="404">Not Found</response>
        [HttpGet]
        [Route("/service/core/v4/AuthenticationProviders/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("AuthenticationProvidersGetByIdAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(AuthenticationProvider), description: "Success")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Forbidden")]
        public virtual IActionResult AuthenticationProvidersGetByIdAsync([FromRoute][Required]int? id, [FromQuery]string fields)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AuthenticationProvider));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"RstsProviderId\" : \"RstsProviderId\",\n  \"IdentityProviderId\" : 6,\n  \"RstsProviderScope\" : \"RstsProviderScope\",\n  \"TypeReferenceName\" : \"Unknown\",\n  \"Id\" : 0,\n  \"ForceAsDefault\" : true,\n  \"Name\" : \"Name\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<AuthenticationProvider>(exampleJson)
                        : default(AuthenticationProvider);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}