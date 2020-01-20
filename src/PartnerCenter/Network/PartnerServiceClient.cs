﻿// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Network
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Threading.Tasks;
    using Exceptions;
    using Extensions;
    using Models;
    using Models.JsonConverters;
    using Models.Resolvers;
    using Newtonsoft.Json;
    using RequestContext;
    using Rest;

    /// <summary>
    /// Acts as mediator betweeen the SDK and the partner service.
    /// </summary>
    public class PartnerServiceClient : ServiceClient<PartnerServiceClient>, IPartnerServiceClient
    {
        /// <summary>
        /// The name of the application name header. 
        /// </summary>
        private const string ApplicationNameHeader = "MS-PartnerCenter-Application";

        /// <summary>
        /// The authorization scheme used by the partner service.
        /// </summary>
        private const string AuthorizationScheme = "Bearer";

        /// <summary>
        /// The name of the client header.
        /// </summary>
        private const string ClientHeader = "MS-PartnerCenter-Client";

        /// <summary>
        /// The name of the correlation identifier header.
        /// </summary>
        private const string CorrelationIdHeaderName = "MS-CorrelationId";

        /// <summary>
        /// The name of the locale header.
        /// </summary>
        private const string LocaleHeaderName = "X-Locale";

        /// <summary>
        /// The JSON media type value.
        /// </summary>
        private const string MediaType = "application/json";

        /// <summary>
        /// The HTTP patch method type.
        /// </summary>
        private const string PatchMethod = "PATCH";

        /// <summary>
        /// The name of the request identifier header.
        /// </summary>
        private const string RequestIdHeaderName = "MS-RequestId";

        /// <summary>
        /// The name of the SDK version header.
        /// </summary>
        public const string SdkVersionHeader = "MS-SdkVersion";

        /// <summary>
        /// The root partner operations instance.
        /// </summary>
        private readonly IPartner rootPartnerOperations;

        /// <summary>
        /// The request context amended to the partner service operations.
        /// </summary>
        private IRequestContext requestContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerServiceClient" /> class.
        /// </summary>
        /// <param name="httpClient">The client used to perform HTTP operations.</param>
        public PartnerServiceClient(HttpClient httpClient)
            : base(httpClient, false)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerServiceClient" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="endpoint">The address of the resource being accessed.</param>
        public PartnerServiceClient(IPartner rootPartnerOperations, Uri endpoint)
        {
            rootPartnerOperations.AssertNotNull(nameof(rootPartnerOperations));
            endpoint.AssertNotNull(nameof(endpoint));

            Endpoint = endpoint;
            this.rootPartnerOperations = rootPartnerOperations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerServiceClient" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="endpoint">The address of the resource being accessed.</param>
        /// <param name="handlers">List of handlers from top to bottom (outer handler is the first in the list).</param>
        public PartnerServiceClient(IPartner rootPartnerOperations, Uri endpoint, params DelegatingHandler[] handlers)
            : base(handlers)
        {
            rootPartnerOperations.AssertNotNull(nameof(rootPartnerOperations));
            endpoint.AssertNotNull(nameof(endpoint));

            Endpoint = endpoint;
            this.rootPartnerOperations = rootPartnerOperations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerServiceClient" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="endpoint">Address of the resource being accessed.</param>
        /// <param name="httpClient">The client used to perform HTTP operations.</param>
        public PartnerServiceClient(IPartner rootPartnerOperations, Uri endpoint, HttpClient httpClient)
            : base(httpClient, false)
        {
            rootPartnerOperations.AssertNotNull(nameof(rootPartnerOperations));
            endpoint.AssertNotNull(nameof(endpoint));
            httpClient.AssertNotNull(nameof(httpClient));

            Endpoint = endpoint;
            this.rootPartnerOperations = rootPartnerOperations;
        }

        /// <summary>
        /// Gets or sets the address of the resource being accessed.
        /// </summary>
        public Uri Endpoint { get; private set; }

        /// <summary>
        /// Executes a HTTP DELETE request against the partner service.
        /// </summary>
        /// <param name="relativeUri">Relative address of the request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task DeleteAsync(Uri relativeUri, CancellationToken cancellationToken = default)
        {
            string invocationId = null;

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, new Uri(Endpoint, relativeUri)))
            {
                await AddRequestHeadersAsync(request).ConfigureAwait(false);

                if (ServiceClientTracing.IsEnabled)
                {
                    invocationId = ServiceClientTracing.NextInvocationId.ToString();

                    Dictionary<string, object> tracingParameters = new Dictionary<string, object>
                    {
                        { "relativeUri", relativeUri }
                    };

                    ServiceClientTracing.Enter(invocationId, this, "Delete", tracingParameters);
                }

                await HandleResponseAsync(invocationId, request, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Executes a HTTP GET request against the partner service.
        /// </summary>
        /// <typeparam name="TResource">Type of resource to be returned.</typeparam>
        /// <param name="link">A link object containing the request information.</param>
        /// <param name="converter">A JSON converter used to deserialize the response.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The response from the HTTP GET request.</returns>
        public async Task<TResource> GetAsync<TResource>(Link link, JsonConverter converter = null, CancellationToken cancellationToken = default)
        {
            string invocationId = null;

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri(Endpoint, $"/{PartnerService.Instance.ApiVersion}/{link.Uri}")))
            {
                foreach (KeyValuePair<string, string> header in link.Headers)
                {
                    request.Headers.Add(header.Key, header.Value);
                }

                if (ServiceClientTracing.IsEnabled)
                {
                    invocationId = ServiceClientTracing.NextInvocationId.ToString();

                    Dictionary<string, object> tracingParameters = new Dictionary<string, object>
                    {
                        { "link", link },
                        { "converter", converter },
                        { "cancellationToken", cancellationToken }
                    };

                    ServiceClientTracing.Enter(invocationId, this, "Get", tracingParameters);
                }

                await AddRequestHeadersAsync(request).ConfigureAwait(false);
                return await HandleResponseAsync<TResource>(invocationId, request, converter, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Executes a HTTP GET request against the partner service.
        /// </summary>
        /// <typeparam name="TResource">Type of resource to be returned.</typeparam>
        /// <param name="relativeUri">Relative address of the request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The response from the HTTP get request.</returns>
        public async Task<TResource> GetAsync<TResource>(Uri relativeUri, CancellationToken cancellationToken = default)
        {
            return await GetAsync<TResource>(
                relativeUri,
                null,
                null,
                null,
                cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Executes a HTTP GET request against the partner service.
        /// </summary>
        /// <typeparam name="TResource">Type of resource to be returned.</typeparam>
        /// <param name="relativeUri">Relative address of the request.</param>
        /// <param name="parameters">Query string parameters that will be added to the address.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The response from the HTTP GET request.</returns>
        public async Task<TResource> GetAsync<TResource>(Uri relativeUri, IDictionary<string, string> parameters, CancellationToken cancellationToken = default)
        {
            return await GetAsync<TResource>(
                relativeUri,
                null,
                parameters,
                null,
                cancellationToken).ConfigureAwait(false);
        }


        /// <summary>
        /// Executes a HTTP GET request against the partner service.
        /// </summary>
        /// <typeparam name="TResource">Type of resource to be returned.</typeparam>
        /// <param name="relativeUri">Relative address of the request.</param>
        /// <param name="parameters">Query string parameters that will be added to the address.</param>
        /// <param name="converter">A JSON converter used to deserialize the response.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The response from the HTTP GET request.</returns>
        public async Task<TResource> GetAsync<TResource>(Uri relativeUri, IDictionary<string, string> parameters = null, JsonConverter converter = null, CancellationToken cancellationToken = default)
        {
            return await GetAsync<TResource>(
                relativeUri,
                null,
                parameters,
                converter,
                cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Executes a HTTP GET request against the partner service.
        /// </summary>
        /// <typeparam name="TResource">Type of resource to be returned.</typeparam>
        /// <param name="relativeUri">Relative address of the request.</param>
        /// <param name="headers">Additional headers to be added to the request.</param>
        /// <param name="parameters">Query string parameters that will be added to the address.</param>
        /// <param name="converter">A JSON converter used to deserialize the response.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The response from the HTTP GET request.</returns>
        public async Task<TResource> GetAsync<TResource>(Uri relativeUri, IDictionary<string, string> headers = null, IDictionary<string, string> parameters = null, JsonConverter converter = null, CancellationToken cancellationToken = default)
        {
            Uri address = new Uri(Endpoint, relativeUri);
            string invocationId = null;

            if (parameters != null && parameters.Count > 0)
            {
                address = address.AddQueryParemeters(parameters);
            }

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, address))
            {
                await AddRequestHeadersAsync(request).ConfigureAwait(false);

                if (ServiceClientTracing.IsEnabled)
                {
                    invocationId = ServiceClientTracing.NextInvocationId.ToString();

                    Dictionary<string, object> tracingParameters = new Dictionary<string, object>
                    {
                        { "relativeUri", relativeUri },
                        { "headers", headers},
                        { "parameters", parameters },
                        { "converter", converter },
                        { "cancellationToken", cancellationToken }
                    };

                    ServiceClientTracing.Enter(invocationId, this, "Get", tracingParameters);
                }

                return await HandleResponseAsync<TResource>(invocationId, request, converter, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Executes a HTTP GET request against the partner service.
        /// </summary>
        /// <typeparam name="TResource">Type of resource to be returned.</typeparam>
        /// <param name="relativeUri">Relative address of the request.</param>
        /// <param name="converter">A JSON converter used to deserialize the response.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The response from the HTTP GET request.</returns>
        public async Task<TResource> GetAsync<TResource>(Uri relativeUri, JsonConverter converter = null, CancellationToken cancellationToken = default)
        {
            return await GetAsync<TResource>(
                relativeUri,
                null,
                null,
                converter,
                cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Executes a file content request against the partner service.
        /// </summary>
        /// <param name="relativeUri">Relative address of the request.</param>
        /// <param name="mediaType">The media type to be accepted.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The file content stream.</returns>
        public async Task<Stream> GetFileContentAsync(Uri relativeUri, string mediaType, CancellationToken cancellationToken = default)
        {
            HttpRequestMessage request;

            request = new HttpRequestMessage(HttpMethod.Get, new Uri(Endpoint, relativeUri));
            await AddRequestHeadersAsync(request).ConfigureAwait(false);

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));

            HttpResponseMessage response = await HttpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);

            if (response.Content == null)
            {
                return null;
            }

            return await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Executes a HTTP HEAD request against the partner service.
        /// </summary>
        /// <param name="relativeUri">Relative address of the request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns></returns>
        public async Task<TResource> HeadAsync<TResource>(Uri relativeUri, CancellationToken cancellationToken = default)
        {
            string invocationId = null;

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Head, new Uri(Endpoint, relativeUri)))
            {
                await AddRequestHeadersAsync(request).ConfigureAwait(false);

                if (ServiceClientTracing.IsEnabled)
                {
                    invocationId = ServiceClientTracing.NextInvocationId.ToString();

                    Dictionary<string, object> tracingParameters = new Dictionary<string, object>
                    {
                        { "relativeUri", relativeUri },
                        { "cancellationToken", cancellationToken }
                    };

                    ServiceClientTracing.Enter(invocationId, this, "Head", tracingParameters);
                }

                return await HandleResponseAsync<TResource>(invocationId, request, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Executes a PATCH request against the partner service.
        /// </summary>
        /// <typeparam name="TRequest">Type of resource being sent.</typeparam>
        /// <typeparam name="TResource">Type of resource to be returned.</typeparam>
        /// <param name="relativeUri">Relative address of the request.</param>
        /// <param name="content">The content for the body of the request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The response from the HTTP PATCH request.</returns>
        public async Task<TResource> PatchAsync<TRequest, TResource>(Uri relativeUri, TRequest content, CancellationToken cancellationToken = default)
        {
            string invocationId = null;

            using (HttpRequestMessage request = new HttpRequestMessage(new HttpMethod(PatchMethod), new Uri(Endpoint, relativeUri)))
            {
                await AddRequestHeadersAsync(request).ConfigureAwait(false);

                request.Content = new StringContent(JsonConvert.SerializeObject(content, GetSerializationSettings()));
                request.Content.Headers.ContentType = new MediaTypeHeaderValue(MediaType);

                if (ServiceClientTracing.IsEnabled)
                {
                    invocationId = ServiceClientTracing.NextInvocationId.ToString();

                    Dictionary<string, object> tracingParameters = new Dictionary<string, object>
                    {
                        { "relativeUri", relativeUri },
                        { "content", content },
                        { "cancellationToken", cancellationToken }
                    };

                    ServiceClientTracing.Enter(invocationId, this, "Patch", tracingParameters);
                }

                return await HandleResponseAsync<TResource>(invocationId, request, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Executes a POST request against the partner service.
        /// </summary>
        /// <typeparam name="TRequest">Type of resource being sent.</typeparam>
        /// <typeparam name="TResource">Type of resource to be returned.</typeparam>
        /// <param name="relativeUri">Relative address of the request.</param>
        /// <param name="content">The content for the body of the request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The response from the HTTP POST request.</returns>
        public async Task<TResource> PostAsync<TRequest, TResource>(Uri relativeUri, TRequest content, CancellationToken cancellationToken = default)
        {
            return await PostAsync<TRequest, TResource>(relativeUri, content, null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Executes a POST request against the partner service.
        /// </summary>
        /// <typeparam name="TRequest">Type of resource being sent.</typeparam>
        /// <typeparam name="TResource">Type of resource to be returned.</typeparam>
        /// <param name="relativeUri">Relative address of the request.</param>
        /// <param name="content">The content for the body of the request.</param>
        /// <param name="parameters">Query string parameters that will be added to the address.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The response from the HTTP POST request.</returns>
        public async Task<TResource> PostAsync<TRequest, TResource>(Uri relativeUri, TRequest content, IDictionary<string, string> parameters = null, CancellationToken cancellationToken = default)
        {
            Uri address = new Uri(Endpoint, relativeUri);
            string invocationId = null;

            if (parameters != null)
            {
                address = address.AddQueryParemeters(parameters);
            }

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, address))
            {
                await AddRequestHeadersAsync(request).ConfigureAwait(false);

                request.Content = new StringContent(JsonConvert.SerializeObject(content, GetSerializationSettings()));
                request.Content.Headers.ContentType = new MediaTypeHeaderValue(MediaType);

                if (ServiceClientTracing.IsEnabled)
                {
                    invocationId = ServiceClientTracing.NextInvocationId.ToString();

                    Dictionary<string, object> tracingParameters = new Dictionary<string, object>
                    {
                        { "relativeUri", relativeUri },
                        { "content", content },
                        { "parameters", parameters },
                        { "cancellationToken", cancellationToken }
                    };

                    ServiceClientTracing.Enter(invocationId, this, "Post", tracingParameters);
                }

                return await HandleResponseAsync<TResource>(invocationId, request, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Executes a PUT request against the partner service.
        /// </summary>
        /// <typeparam name="TRequest">Type of resource being sent.</typeparam>
        /// <typeparam name="TResource">Type of resource to be returned.</typeparam>
        /// <param name="relativeUri">Relative address of the request.</param>
        /// <param name="content">The content for the body of the request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The response from the HTTP PUT request.</returns>
        public async Task<TResource> PutAsync<TRequest, TResource>(Uri relativeUri, TRequest content, CancellationToken cancellationToken = default)
        {
            return await PutAsync<TRequest, TResource>(relativeUri, content, null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Executes a PUT request against the partner service.
        /// </summary>
        /// <typeparam name="TRequest">Type of resource being sent.</typeparam>
        /// <typeparam name="TResource">Type of resource to be returned.</typeparam>
        /// <param name="relativeUri">Relative address of the request.</param>
        /// <param name="content">The content for the body of the request.</param>
        /// <param name="parameters">Query string parameters that will be added to the address.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The response from the HTTP PUT request.</returns>
        public async Task<TResource> PutAsync<TRequest, TResource>(Uri relativeUri, TRequest content, IDictionary<string, string> parameters = null, CancellationToken cancellationToken = default)
        {
            Uri address = new Uri(Endpoint, relativeUri);
            string invocationId = null;

            if (parameters != null)
            {
                address = address.AddQueryParemeters(parameters);
            }

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, address))
            {
                await AddRequestHeadersAsync(request).ConfigureAwait(false);

                request.Content = new StringContent(JsonConvert.SerializeObject(content, GetSerializationSettings()));
                request.Content.Headers.ContentType = new MediaTypeHeaderValue(MediaType);

                if (ServiceClientTracing.IsEnabled)
                {
                    invocationId = ServiceClientTracing.NextInvocationId.ToString();

                    Dictionary<string, object> tracingParameters = new Dictionary<string, object>
                    {
                        { "relativeUri", relativeUri },
                        { "content", content },
                        { "parameters", parameters },
                        { "cancellationToken", cancellationToken }
                    };

                    ServiceClientTracing.Enter(invocationId, this, "Put", tracingParameters);
                }

                return await HandleResponseAsync<TResource>(invocationId, request, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Adds the headers to the request.
        /// </summary>
        /// <param name="request">The HTTP request being made.</param>
        /// <param name="additionalHeaders">Additional headers to be added.</param>
        private async Task AddRequestHeadersAsync(HttpRequestMessage request, IDictionary<string, string> additionalHeaders = null)
        {
            if (rootPartnerOperations.RequestContext.RequestId == Guid.Empty)
            {
                requestContext = RequestContextFactory.Create(
                    rootPartnerOperations.RequestContext.CorrelationId,
                    Guid.NewGuid(),
                    rootPartnerOperations.RequestContext.Locale);
            }
            else
            {
                requestContext = rootPartnerOperations.RequestContext;
            }

            if (!string.IsNullOrEmpty(PartnerService.Instance.ApplicationName))
            {
                request.Headers.Add(ApplicationNameHeader, PartnerService.Instance.ApplicationName);
            }

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaType));

            request.Headers.Add(ClientHeader, PartnerService.Instance.Configuration.PartnerCenterClient);
            request.Headers.Add(CorrelationIdHeaderName, requestContext.CorrelationId.ToString());
            request.Headers.Add(LocaleHeaderName, requestContext.Locale);
            request.Headers.Add(RequestIdHeaderName, requestContext.RequestId.ToString());
            request.Headers.Add(SdkVersionHeader, PartnerService.Instance.AssemblyVersion);

            if (rootPartnerOperations.Credentials.IsExpired())
            {
                if (PartnerService.Instance.RefreshCredentials != null)
                {
                    await PartnerService.Instance.RefreshCredentials(
                        rootPartnerOperations.Credentials,
                        requestContext).ConfigureAwait(false);
                }
                else
                {
                    throw new PartnerException(
                        "The partner credentials have expired. Please provide updated credentials.",
                        requestContext,
                        PartnerErrorCategory.Unauthorized);
                }
            }

            request.Headers.Authorization = new AuthenticationHeaderValue(
                AuthorizationScheme,
                rootPartnerOperations.Credentials.PartnerServiceToken);

            if (additionalHeaders != null)
            {
                foreach (KeyValuePair<string, string> header in additionalHeaders)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }
        }

        private static PartnerErrorCategory GetErrorCategory(HttpStatusCode statusCode)
        {
            return statusCode switch
            {
                HttpStatusCode.BadRequest => PartnerErrorCategory.BadInput,
                HttpStatusCode.Unauthorized => PartnerErrorCategory.Unauthorized,
                HttpStatusCode.Forbidden => PartnerErrorCategory.Forbidden,
                HttpStatusCode.NotFound => PartnerErrorCategory.NotFound,
                HttpStatusCode.MethodNotAllowed => PartnerErrorCategory.InvalidOperation,
                HttpStatusCode.NotAcceptable => PartnerErrorCategory.UnsupportedDataFormat,
                HttpStatusCode.Conflict => PartnerErrorCategory.AlreadyExists,
                (HttpStatusCode)429 => PartnerErrorCategory.TooManyRequests,
                HttpStatusCode.ServiceUnavailable => PartnerErrorCategory.ServerBusy,
                _ => PartnerErrorCategory.ServerError,
            };
        }

        private static JsonSerializerSettings GetSerializationSettings(JsonConverter converter = null)
        {
            return new JsonSerializerSettings
            {
                Converters = new List<JsonConverter>
                {
                    {
                        converter ?? new EnumJsonConverter()
                    }
                },
                ContractResolver = new PrivateContractResolver(),
                CheckAdditionalContent = true,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize
            };
        }

        private async Task HandleResponseAsync(string invocationId, HttpRequestMessage request, CancellationToken cancellationToken = default)
        {
            bool shouldTrace = ServiceClientTracing.IsEnabled;

            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, request);
            }

            cancellationToken.ThrowIfCancellationRequested();

            HttpResponseMessage response = await HttpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);

            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, response);
            }

            string responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                return;
            }

            ApiFault fault = JsonConvert.DeserializeObject<ApiFault>(responseContent, GetSerializationSettings());
            PartnerErrorCategory errorCategory = GetErrorCategory(response.StatusCode);

            PartnerException ex = new PartnerException(fault, requestContext, errorCategory)
            {
                Request = new HttpRequestMessageWrapper(request, null),
                Response = new HttpResponseMessageWrapper(response, responseContent)
            };

            if (shouldTrace)
            {
                ServiceClientTracing.Error(invocationId, ex);
            }

            throw ex;
        }

        private async Task<TResource> HandleResponseAsync<TResource>(string invocationId, HttpRequestMessage request, CancellationToken cancellationToken = default)
        {
            return await HandleResponseAsync<TResource>(invocationId, request, null, cancellationToken).ConfigureAwait(false);
        }

        private async Task<TResource> HandleResponseAsync<TResource>(string invocationId, HttpRequestMessage request, JsonConverter converter = null, CancellationToken cancellationToken = default)
        {
            bool shouldTrace = ServiceClientTracing.IsEnabled;

            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, request);
            }

            cancellationToken.ThrowIfCancellationRequested();

            HttpResponseMessage response = await HttpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);

            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, response);
            }

            string responseContent = response.Content == null ? string.Empty : await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                if (typeof(TResource) == typeof(HttpResponseMessage))
                {
                    return (TResource)Convert.ChangeType(response, typeof(TResource));
                }

                return JsonConvert.DeserializeObject<TResource>(responseContent, GetSerializationSettings(converter));
            }

            ApiFault fault = null;
            PartnerErrorCategory errorCategory = GetErrorCategory(response.StatusCode);
            PartnerException exception = null;

            if (string.IsNullOrEmpty(responseContent))
            {
                exception = new PartnerException(response.ReasonPhrase, requestContext, errorCategory)
                {
                    Request = new HttpRequestMessageWrapper(request, null),
                    Response = new HttpResponseMessageWrapper(response, responseContent)
                };
            }
            else
            {
                try
                {
                    fault = JsonConvert.DeserializeObject<ApiFault>(responseContent, GetSerializationSettings(converter));

                    exception = new PartnerException(fault, requestContext, errorCategory)
                    {
                        Request = new HttpRequestMessageWrapper(request, null),
                        Response = new HttpResponseMessageWrapper(response, responseContent)
                    };
                }
                catch (Exception)
                { }

                if (fault == null)
                {
                    exception = new PartnerException(string.IsNullOrEmpty(responseContent) ? response.ReasonPhrase : responseContent, requestContext, errorCategory);
                }
            }

            if (shouldTrace)
            {
                ServiceClientTracing.Error(invocationId, exception);
            }

            throw exception;
        }
    }
}