/*
 * Private API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Auth.Private.Client.Client;
using Auth.Private.Client.Model;

namespace Auth.Private.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILoginCallbackApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackAcceptRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiApiPrivateLoginCallbackAcceptResponse</returns>
        ApiApiPrivateLoginCallbackAcceptResponse ApiPrivateLoginCallbackAcceptPost(ApiApiPrivateLoginCallbackAcceptRequest? apiApiPrivateLoginCallbackAcceptRequest = default(ApiApiPrivateLoginCallbackAcceptRequest?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackAcceptRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiApiPrivateLoginCallbackAcceptResponse</returns>
        ApiResponse<ApiApiPrivateLoginCallbackAcceptResponse> ApiPrivateLoginCallbackAcceptPostWithHttpInfo(ApiApiPrivateLoginCallbackAcceptRequest? apiApiPrivateLoginCallbackAcceptRequest = default(ApiApiPrivateLoginCallbackAcceptRequest?), int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackRejectRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiApiPrivateLoginCallbackRejectResponse</returns>
        ApiApiPrivateLoginCallbackRejectResponse ApiPrivateLoginCallbackRejectPost(ApiApiPrivateLoginCallbackRejectRequest? apiApiPrivateLoginCallbackRejectRequest = default(ApiApiPrivateLoginCallbackRejectRequest?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackRejectRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiApiPrivateLoginCallbackRejectResponse</returns>
        ApiResponse<ApiApiPrivateLoginCallbackRejectResponse> ApiPrivateLoginCallbackRejectPostWithHttpInfo(ApiApiPrivateLoginCallbackRejectRequest? apiApiPrivateLoginCallbackRejectRequest = default(ApiApiPrivateLoginCallbackRejectRequest?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILoginCallbackApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackAcceptRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiApiPrivateLoginCallbackAcceptResponse</returns>
        System.Threading.Tasks.Task<ApiApiPrivateLoginCallbackAcceptResponse> ApiPrivateLoginCallbackAcceptPostAsync(ApiApiPrivateLoginCallbackAcceptRequest? apiApiPrivateLoginCallbackAcceptRequest = default(ApiApiPrivateLoginCallbackAcceptRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackAcceptRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiApiPrivateLoginCallbackAcceptResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiApiPrivateLoginCallbackAcceptResponse>> ApiPrivateLoginCallbackAcceptPostWithHttpInfoAsync(ApiApiPrivateLoginCallbackAcceptRequest? apiApiPrivateLoginCallbackAcceptRequest = default(ApiApiPrivateLoginCallbackAcceptRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackRejectRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiApiPrivateLoginCallbackRejectResponse</returns>
        System.Threading.Tasks.Task<ApiApiPrivateLoginCallbackRejectResponse> ApiPrivateLoginCallbackRejectPostAsync(ApiApiPrivateLoginCallbackRejectRequest? apiApiPrivateLoginCallbackRejectRequest = default(ApiApiPrivateLoginCallbackRejectRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackRejectRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiApiPrivateLoginCallbackRejectResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiApiPrivateLoginCallbackRejectResponse>> ApiPrivateLoginCallbackRejectPostWithHttpInfoAsync(ApiApiPrivateLoginCallbackRejectRequest? apiApiPrivateLoginCallbackRejectRequest = default(ApiApiPrivateLoginCallbackRejectRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILoginCallbackApi : ILoginCallbackApiSync, ILoginCallbackApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LoginCallbackApi : ILoginCallbackApi
    {
        private Auth.Private.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginCallbackApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoginCallbackApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginCallbackApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoginCallbackApi(string basePath)
        {
            this.Configuration = Auth.Private.Client.Client.Configuration.MergeConfigurations(
                Auth.Private.Client.Client.GlobalConfiguration.Instance,
                new Auth.Private.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Auth.Private.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Auth.Private.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Auth.Private.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginCallbackApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LoginCallbackApi(Auth.Private.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Auth.Private.Client.Client.Configuration.MergeConfigurations(
                Auth.Private.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Auth.Private.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Auth.Private.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Auth.Private.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginCallbackApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public LoginCallbackApi(Auth.Private.Client.Client.ISynchronousClient client, Auth.Private.Client.Client.IAsynchronousClient asyncClient, Auth.Private.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Auth.Private.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Auth.Private.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Auth.Private.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Auth.Private.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Auth.Private.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackAcceptRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiApiPrivateLoginCallbackAcceptResponse</returns>
        public ApiApiPrivateLoginCallbackAcceptResponse ApiPrivateLoginCallbackAcceptPost(ApiApiPrivateLoginCallbackAcceptRequest? apiApiPrivateLoginCallbackAcceptRequest = default(ApiApiPrivateLoginCallbackAcceptRequest?), int operationIndex = 0)
        {
            Auth.Private.Client.Client.ApiResponse<ApiApiPrivateLoginCallbackAcceptResponse> localVarResponse = ApiPrivateLoginCallbackAcceptPostWithHttpInfo(apiApiPrivateLoginCallbackAcceptRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackAcceptRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiApiPrivateLoginCallbackAcceptResponse</returns>
        public Auth.Private.Client.Client.ApiResponse<ApiApiPrivateLoginCallbackAcceptResponse> ApiPrivateLoginCallbackAcceptPostWithHttpInfo(ApiApiPrivateLoginCallbackAcceptRequest? apiApiPrivateLoginCallbackAcceptRequest = default(ApiApiPrivateLoginCallbackAcceptRequest?), int operationIndex = 0)
        {
            Auth.Private.Client.Client.RequestOptions localVarRequestOptions = new Auth.Private.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Auth.Private.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Auth.Private.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = apiApiPrivateLoginCallbackAcceptRequest;

            localVarRequestOptions.Operation = "LoginCallbackApi.ApiPrivateLoginCallbackAcceptPost";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<ApiApiPrivateLoginCallbackAcceptResponse>("/api/private/login/callback/accept", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiPrivateLoginCallbackAcceptPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackAcceptRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiApiPrivateLoginCallbackAcceptResponse</returns>
        public async System.Threading.Tasks.Task<ApiApiPrivateLoginCallbackAcceptResponse> ApiPrivateLoginCallbackAcceptPostAsync(ApiApiPrivateLoginCallbackAcceptRequest? apiApiPrivateLoginCallbackAcceptRequest = default(ApiApiPrivateLoginCallbackAcceptRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Auth.Private.Client.Client.ApiResponse<ApiApiPrivateLoginCallbackAcceptResponse> localVarResponse = await ApiPrivateLoginCallbackAcceptPostWithHttpInfoAsync(apiApiPrivateLoginCallbackAcceptRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackAcceptRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiApiPrivateLoginCallbackAcceptResponse)</returns>
        public async System.Threading.Tasks.Task<Auth.Private.Client.Client.ApiResponse<ApiApiPrivateLoginCallbackAcceptResponse>> ApiPrivateLoginCallbackAcceptPostWithHttpInfoAsync(ApiApiPrivateLoginCallbackAcceptRequest? apiApiPrivateLoginCallbackAcceptRequest = default(ApiApiPrivateLoginCallbackAcceptRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Auth.Private.Client.Client.RequestOptions localVarRequestOptions = new Auth.Private.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Auth.Private.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Auth.Private.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = apiApiPrivateLoginCallbackAcceptRequest;

            localVarRequestOptions.Operation = "LoginCallbackApi.ApiPrivateLoginCallbackAcceptPost";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ApiApiPrivateLoginCallbackAcceptResponse>("/api/private/login/callback/accept", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiPrivateLoginCallbackAcceptPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackRejectRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiApiPrivateLoginCallbackRejectResponse</returns>
        public ApiApiPrivateLoginCallbackRejectResponse ApiPrivateLoginCallbackRejectPost(ApiApiPrivateLoginCallbackRejectRequest? apiApiPrivateLoginCallbackRejectRequest = default(ApiApiPrivateLoginCallbackRejectRequest?), int operationIndex = 0)
        {
            Auth.Private.Client.Client.ApiResponse<ApiApiPrivateLoginCallbackRejectResponse> localVarResponse = ApiPrivateLoginCallbackRejectPostWithHttpInfo(apiApiPrivateLoginCallbackRejectRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackRejectRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ApiApiPrivateLoginCallbackRejectResponse</returns>
        public Auth.Private.Client.Client.ApiResponse<ApiApiPrivateLoginCallbackRejectResponse> ApiPrivateLoginCallbackRejectPostWithHttpInfo(ApiApiPrivateLoginCallbackRejectRequest? apiApiPrivateLoginCallbackRejectRequest = default(ApiApiPrivateLoginCallbackRejectRequest?), int operationIndex = 0)
        {
            Auth.Private.Client.Client.RequestOptions localVarRequestOptions = new Auth.Private.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Auth.Private.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Auth.Private.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = apiApiPrivateLoginCallbackRejectRequest;

            localVarRequestOptions.Operation = "LoginCallbackApi.ApiPrivateLoginCallbackRejectPost";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<ApiApiPrivateLoginCallbackRejectResponse>("/api/private/login/callback/reject", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiPrivateLoginCallbackRejectPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackRejectRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiApiPrivateLoginCallbackRejectResponse</returns>
        public async System.Threading.Tasks.Task<ApiApiPrivateLoginCallbackRejectResponse> ApiPrivateLoginCallbackRejectPostAsync(ApiApiPrivateLoginCallbackRejectRequest? apiApiPrivateLoginCallbackRejectRequest = default(ApiApiPrivateLoginCallbackRejectRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Auth.Private.Client.Client.ApiResponse<ApiApiPrivateLoginCallbackRejectResponse> localVarResponse = await ApiPrivateLoginCallbackRejectPostWithHttpInfoAsync(apiApiPrivateLoginCallbackRejectRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Auth.Private.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiApiPrivateLoginCallbackRejectRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ApiApiPrivateLoginCallbackRejectResponse)</returns>
        public async System.Threading.Tasks.Task<Auth.Private.Client.Client.ApiResponse<ApiApiPrivateLoginCallbackRejectResponse>> ApiPrivateLoginCallbackRejectPostWithHttpInfoAsync(ApiApiPrivateLoginCallbackRejectRequest? apiApiPrivateLoginCallbackRejectRequest = default(ApiApiPrivateLoginCallbackRejectRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Auth.Private.Client.Client.RequestOptions localVarRequestOptions = new Auth.Private.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Auth.Private.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Auth.Private.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = apiApiPrivateLoginCallbackRejectRequest;

            localVarRequestOptions.Operation = "LoginCallbackApi.ApiPrivateLoginCallbackRejectPost";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ApiApiPrivateLoginCallbackRejectResponse>("/api/private/login/callback/reject", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiPrivateLoginCallbackRejectPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
