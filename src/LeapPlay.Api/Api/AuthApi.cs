/* 
 * Leap Play
 *
 * Learn more at https://www.leap-play.com
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace LeapPlay.Api.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Receive an Access and Refresh Token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginRequest">Login Request Dto (optional)</param>
        /// <returns>LoginResponse</returns>
        LoginResponse Login (RequestLoginModel loginRequest = null);

        /// <summary>
        /// Receive an Access and Refresh Token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginRequest">Login Request Dto (optional)</param>
        /// <returns>ApiResponse of LoginResponse</returns>
        ApiResponse<LoginResponse> LoginWithHttpInfo (RequestLoginModel loginRequest = null);
        /// <summary>
        /// Invalidate the Refresh token (Auth)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void Logout ();

        /// <summary>
        /// Invalidate the Refresh token (Auth)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> LogoutWithHttpInfo ();
        /// <summary>
        /// Receive a new Access token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestTokenRefresh">Refresh Token Dto (optional)</param>
        /// <param name="authorization">Any previous Access Token. (optional)</param>
        /// <returns>AccessToken</returns>
        AccessToken RefreshToken (RequestTokenRefresh requestTokenRefresh = null, string authorization = null);

        /// <summary>
        /// Receive a new Access token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestTokenRefresh">Refresh Token Dto (optional)</param>
        /// <param name="authorization">Any previous Access Token. (optional)</param>
        /// <returns>ApiResponse of AccessToken</returns>
        ApiResponse<AccessToken> RefreshTokenWithHttpInfo (RequestTokenRefresh requestTokenRefresh = null, string authorization = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Receive an Access and Refresh Token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginRequest">Login Request Dto (optional)</param>
        /// <returns>Task of LoginResponse</returns>
        System.Threading.Tasks.Task<LoginResponse> LoginAsync (RequestLoginModel loginRequest = null);

        /// <summary>
        /// Receive an Access and Refresh Token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginRequest">Login Request Dto (optional)</param>
        /// <returns>Task of ApiResponse (LoginResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoginResponse>> LoginAsyncWithHttpInfo (RequestLoginModel loginRequest = null);
        /// <summary>
        /// Invalidate the Refresh token (Auth)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task LogoutAsync ();

        /// <summary>
        /// Invalidate the Refresh token (Auth)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> LogoutAsyncWithHttpInfo ();
        /// <summary>
        /// Receive a new Access token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestTokenRefresh">Refresh Token Dto (optional)</param>
        /// <param name="authorization">Any previous Access Token. (optional)</param>
        /// <returns>Task of AccessToken</returns>
        System.Threading.Tasks.Task<AccessToken> RefreshTokenAsync (RequestTokenRefresh requestTokenRefresh = null, string authorization = null);

        /// <summary>
        /// Receive a new Access token
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestTokenRefresh">Refresh Token Dto (optional)</param>
        /// <param name="authorization">Any previous Access Token. (optional)</param>
        /// <returns>Task of ApiResponse (AccessToken)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccessToken>> RefreshTokenAsyncWithHttpInfo (RequestTokenRefresh requestTokenRefresh = null, string authorization = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthApi : IAuthApi
    {
        private LeapPlay.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthApi(String basePath)
        {
            this.Configuration = new LeapPlay.Api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = LeapPlay.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthApi(LeapPlay.Api.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = LeapPlay.Api.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = LeapPlay.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public LeapPlay.Api.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public LeapPlay.Api.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Receive an Access and Refresh Token 
        /// </summary>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginRequest">Login Request Dto (optional)</param>
        /// <returns>LoginResponse</returns>
        public LoginResponse Login (RequestLoginModel loginRequest = null)
        {
             ApiResponse<LoginResponse> localVarResponse = LoginWithHttpInfo(loginRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Receive an Access and Refresh Token 
        /// </summary>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginRequest">Login Request Dto (optional)</param>
        /// <returns>ApiResponse of LoginResponse</returns>
        public ApiResponse< LoginResponse > LoginWithHttpInfo (RequestLoginModel loginRequest = null)
        {

            var localVarPath = "./api/v1/auth/login";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (loginRequest != null && loginRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(loginRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loginRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Login", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LoginResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (LoginResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoginResponse)));
        }

        /// <summary>
        /// Receive an Access and Refresh Token 
        /// </summary>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginRequest">Login Request Dto (optional)</param>
        /// <returns>Task of LoginResponse</returns>
        public async System.Threading.Tasks.Task<LoginResponse> LoginAsync (RequestLoginModel loginRequest = null)
        {
             ApiResponse<LoginResponse> localVarResponse = await LoginAsyncWithHttpInfo(loginRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Receive an Access and Refresh Token 
        /// </summary>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginRequest">Login Request Dto (optional)</param>
        /// <returns>Task of ApiResponse (LoginResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LoginResponse>> LoginAsyncWithHttpInfo (RequestLoginModel loginRequest = null)
        {

            var localVarPath = "./api/v1/auth/login";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (loginRequest != null && loginRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(loginRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = loginRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Login", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LoginResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (LoginResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LoginResponse)));
        }

        /// <summary>
        /// Invalidate the Refresh token (Auth) 
        /// </summary>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void Logout ()
        {
             LogoutWithHttpInfo();
        }

        /// <summary>
        /// Invalidate the Refresh token (Auth) 
        /// </summary>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> LogoutWithHttpInfo ()
        {

            var localVarPath = "./api/v1/auth/logout";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Logout", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Invalidate the Refresh token (Auth) 
        /// </summary>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task LogoutAsync ()
        {
             await LogoutAsyncWithHttpInfo();

        }

        /// <summary>
        /// Invalidate the Refresh token (Auth) 
        /// </summary>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> LogoutAsyncWithHttpInfo ()
        {

            var localVarPath = "./api/v1/auth/logout";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Logout", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Receive a new Access token 
        /// </summary>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestTokenRefresh">Refresh Token Dto (optional)</param>
        /// <param name="authorization">Any previous Access Token. (optional)</param>
        /// <returns>AccessToken</returns>
        public AccessToken RefreshToken (RequestTokenRefresh requestTokenRefresh = null, string authorization = null)
        {
             ApiResponse<AccessToken> localVarResponse = RefreshTokenWithHttpInfo(requestTokenRefresh, authorization);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Receive a new Access token 
        /// </summary>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestTokenRefresh">Refresh Token Dto (optional)</param>
        /// <param name="authorization">Any previous Access Token. (optional)</param>
        /// <returns>ApiResponse of AccessToken</returns>
        public ApiResponse< AccessToken > RefreshTokenWithHttpInfo (RequestTokenRefresh requestTokenRefresh = null, string authorization = null)
        {

            var localVarPath = "./api/v1/auth/refreshtoken";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (requestTokenRefresh != null && requestTokenRefresh.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(requestTokenRefresh); // http body (model) parameter
            }
            else
            {
                localVarPostBody = requestTokenRefresh; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RefreshToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccessToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (AccessToken) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccessToken)));
        }

        /// <summary>
        /// Receive a new Access token 
        /// </summary>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestTokenRefresh">Refresh Token Dto (optional)</param>
        /// <param name="authorization">Any previous Access Token. (optional)</param>
        /// <returns>Task of AccessToken</returns>
        public async System.Threading.Tasks.Task<AccessToken> RefreshTokenAsync (RequestTokenRefresh requestTokenRefresh = null, string authorization = null)
        {
             ApiResponse<AccessToken> localVarResponse = await RefreshTokenAsyncWithHttpInfo(requestTokenRefresh, authorization);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Receive a new Access token 
        /// </summary>
        /// <exception cref="LeapPlay.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestTokenRefresh">Refresh Token Dto (optional)</param>
        /// <param name="authorization">Any previous Access Token. (optional)</param>
        /// <returns>Task of ApiResponse (AccessToken)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccessToken>> RefreshTokenAsyncWithHttpInfo (RequestTokenRefresh requestTokenRefresh = null, string authorization = null)
        {

            var localVarPath = "./api/v1/auth/refreshtoken";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (requestTokenRefresh != null && requestTokenRefresh.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(requestTokenRefresh); // http body (model) parameter
            }
            else
            {
                localVarPostBody = requestTokenRefresh; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RefreshToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccessToken>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (AccessToken) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccessToken)));
        }

    }
}
