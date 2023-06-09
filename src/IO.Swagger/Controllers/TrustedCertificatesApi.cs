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
    public class TrustedCertificatesApiController : ControllerBase
    { 
        /// <summary>
        /// Installs a new certificate authority certificate chain
        /// </summary>
        /// <param name="body">Base-64 encoded DER data for certificate chain</param>
        /// <response code="201">Created</response>
        /// <response code="403">Must have ApplianceAdmin permission</response>
        [HttpPost]
        [Route("/service/core/v4/TrustedCertificates/Chain")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("TrustedCertificatesAddCertChainAsync")]
        [SwaggerResponse(statusCode: 201, type: typeof(List<ServerCertificate>), description: "Created")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have ApplianceAdmin permission")]
        public virtual IActionResult TrustedCertificatesAddCertChainAsync([FromBody]string body)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(List<ServerCertificate>));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "[ {\n  \"Thumbprint\" : \"Thumbprint\",\n  \"Passphrase\" : \"Passphrase\",\n  \"DnsNames\" : [ \"DnsNames\", \"DnsNames\" ],\n  \"NotAfter\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Subject\" : \"Subject\",\n  \"IpAddresses\" : [ \"IpAddresses\", \"IpAddresses\" ],\n  \"CertificateType\" : \"Unknown\",\n  \"IssuerCertificates\" : [ \"IssuerCertificates\", \"IssuerCertificates\" ],\n  \"SystemOwnedPrivateKey\" : true,\n  \"IsCertificateAuthority\" : true,\n  \"Base64CertificateData\" : \"Base64CertificateData\",\n  \"NotBefore\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"IssuedBy\" : \"IssuedBy\",\n  \"IsSystemOwned\" : true\n}, {\n  \"Thumbprint\" : \"Thumbprint\",\n  \"Passphrase\" : \"Passphrase\",\n  \"DnsNames\" : [ \"DnsNames\", \"DnsNames\" ],\n  \"NotAfter\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Subject\" : \"Subject\",\n  \"IpAddresses\" : [ \"IpAddresses\", \"IpAddresses\" ],\n  \"CertificateType\" : \"Unknown\",\n  \"IssuerCertificates\" : [ \"IssuerCertificates\", \"IssuerCertificates\" ],\n  \"SystemOwnedPrivateKey\" : true,\n  \"IsCertificateAuthority\" : true,\n  \"Base64CertificateData\" : \"Base64CertificateData\",\n  \"NotBefore\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"IssuedBy\" : \"IssuedBy\",\n  \"IsSystemOwned\" : true\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<ServerCertificate>>(exampleJson)
                        : default(List<ServerCertificate>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Installs a new certificate authority certificate
        /// </summary>
        /// <param name="body">ServerCertificate to create</param>
        /// <response code="201">Created</response>
        /// <response code="400">60245 - Request body was missing</response>
        /// <response code="403">Must have ApplianceAdmin permission</response>
        [HttpPost]
        [Route("/service/core/v4/TrustedCertificates")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("TrustedCertificatesCreateEntityAsync")]
        [SwaggerResponse(statusCode: 201, type: typeof(ServerCertificate), description: "Created")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "60245 - Request body was missing")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have ApplianceAdmin permission")]
        public virtual IActionResult TrustedCertificatesCreateEntityAsync([FromBody]ServerCertificate body)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201, default(ServerCertificate));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "{\n  \"Thumbprint\" : \"Thumbprint\",\n  \"Passphrase\" : \"Passphrase\",\n  \"DnsNames\" : [ \"DnsNames\", \"DnsNames\" ],\n  \"NotAfter\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Subject\" : \"Subject\",\n  \"IpAddresses\" : [ \"IpAddresses\", \"IpAddresses\" ],\n  \"CertificateType\" : \"Unknown\",\n  \"IssuerCertificates\" : [ \"IssuerCertificates\", \"IssuerCertificates\" ],\n  \"SystemOwnedPrivateKey\" : true,\n  \"IsCertificateAuthority\" : true,\n  \"Base64CertificateData\" : \"Base64CertificateData\",\n  \"NotBefore\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"IssuedBy\" : \"IssuedBy\",\n  \"IsSystemOwned\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ServerCertificate>(exampleJson)
                        : default(ServerCertificate);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Removes a trusted certificate
        /// </summary>
        /// <param name="id">Unique identifier of the ServerCertificate</param>
        /// <response code="204">Success - No Content</response>
        /// <response code="400">60097 - ServerCertificate Id was missing</response>
        /// <response code="403">Must have ApplianceAdmin permission</response>
        [HttpDelete]
        [Route("/service/core/v4/TrustedCertificates/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("TrustedCertificatesDeleteAsync")]
        [SwaggerResponse(statusCode: 400, type: typeof(ApiError), description: "60097 - ServerCertificate Id was missing")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have ApplianceAdmin permission")]
        public virtual IActionResult TrustedCertificatesDeleteAsync([FromRoute][Required]string id)
        { 
            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ApiError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a queryable list of trusted certificates
        /// </summary>
        /// <param name="filter">Filter results. Available operators: eq, ne, gt, ge, lt, le, and, or, not, (). Use \\ to escape quotes in strings.</param>
        /// <param name="page">Which page (starting with 0) of data to return</param>
        /// <param name="limit">The size of a page of data</param>
        /// <param name="count">When specified, the method will return a single integer value representing the total number of items that match the given filter criteria. If specified, the fields and orderby parameter values are ignored.</param>
        /// <param name="fields">List of property names (comma-separated) to include in entity output. Prepend list with - to exclude from output.</param>
        /// <param name="orderby">List of property names (comma-separated) to sort entities by. Prepend properties with - for  descending.</param>
        /// <param name="q">Search all string fields for the specified value</param>
        /// <response code="200">Success</response>
        /// <response code="403">Must have OperationsAdmin, SystemAuditor or Auditor permission</response>
        [HttpGet]
        [Route("/service/core/v4/TrustedCertificates")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("TrustedCertificatesGetAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<ServerCertificate>), description: "Success")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have OperationsAdmin, SystemAuditor or Auditor permission")]
        public virtual IActionResult TrustedCertificatesGetAsync([FromQuery]string filter, [FromQuery]int? page, [FromQuery]int? limit, [FromQuery]bool? count, [FromQuery]string fields, [FromQuery]string orderby, [FromQuery]string q)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<ServerCertificate>));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));
            string exampleJson = null;
            exampleJson = "[ {\n  \"Thumbprint\" : \"Thumbprint\",\n  \"Passphrase\" : \"Passphrase\",\n  \"DnsNames\" : [ \"DnsNames\", \"DnsNames\" ],\n  \"NotAfter\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Subject\" : \"Subject\",\n  \"IpAddresses\" : [ \"IpAddresses\", \"IpAddresses\" ],\n  \"CertificateType\" : \"Unknown\",\n  \"IssuerCertificates\" : [ \"IssuerCertificates\", \"IssuerCertificates\" ],\n  \"SystemOwnedPrivateKey\" : true,\n  \"IsCertificateAuthority\" : true,\n  \"Base64CertificateData\" : \"Base64CertificateData\",\n  \"NotBefore\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"IssuedBy\" : \"IssuedBy\",\n  \"IsSystemOwned\" : true\n}, {\n  \"Thumbprint\" : \"Thumbprint\",\n  \"Passphrase\" : \"Passphrase\",\n  \"DnsNames\" : [ \"DnsNames\", \"DnsNames\" ],\n  \"NotAfter\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Subject\" : \"Subject\",\n  \"IpAddresses\" : [ \"IpAddresses\", \"IpAddresses\" ],\n  \"CertificateType\" : \"Unknown\",\n  \"IssuerCertificates\" : [ \"IssuerCertificates\", \"IssuerCertificates\" ],\n  \"SystemOwnedPrivateKey\" : true,\n  \"IsCertificateAuthority\" : true,\n  \"Base64CertificateData\" : \"Base64CertificateData\",\n  \"NotBefore\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"IssuedBy\" : \"IssuedBy\",\n  \"IsSystemOwned\" : true\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<ServerCertificate>>(exampleJson)
                        : default(List<ServerCertificate>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Gets a trusted certificate
        /// </summary>
        /// <param name="id">Unique ID of ServerCertificate</param>
        /// <param name="fields">List of property names to include in entity output</param>
        /// <response code="200">Success</response>
        /// <response code="403">Must have OperationsAdmin, SystemAuditor or Auditor permission</response>
        /// <response code="404">Server Certificate not found</response>
        [HttpGet]
        [Route("/service/core/v4/TrustedCertificates/{id}")]
        [Authorize(AuthenticationSchemes = BearerAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("TrustedCertificatesGetByIdAsync")]
        [SwaggerResponse(statusCode: 200, type: typeof(ServerCertificate), description: "Success")]
        [SwaggerResponse(statusCode: 403, type: typeof(ApiError), description: "Must have OperationsAdmin, SystemAuditor or Auditor permission")]
        public virtual IActionResult TrustedCertificatesGetByIdAsync([FromRoute][Required]string id, [FromQuery]string fields)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ServerCertificate));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ApiError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"Thumbprint\" : \"Thumbprint\",\n  \"Passphrase\" : \"Passphrase\",\n  \"DnsNames\" : [ \"DnsNames\", \"DnsNames\" ],\n  \"NotAfter\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"Subject\" : \"Subject\",\n  \"IpAddresses\" : [ \"IpAddresses\", \"IpAddresses\" ],\n  \"CertificateType\" : \"Unknown\",\n  \"IssuerCertificates\" : [ \"IssuerCertificates\", \"IssuerCertificates\" ],\n  \"SystemOwnedPrivateKey\" : true,\n  \"IsCertificateAuthority\" : true,\n  \"Base64CertificateData\" : \"Base64CertificateData\",\n  \"NotBefore\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"IssuedBy\" : \"IssuedBy\",\n  \"IsSystemOwned\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ServerCertificate>(exampleJson)
                        : default(ServerCertificate);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
