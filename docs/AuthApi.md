# LeapPlay.Api.Api.AuthApi

All URIs are relative to *https://api.leap-play.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Login**](AuthApi.md#login) | **POST** /api/v1/auth/login | Receive an Access and Refresh Token
[**Logout**](AuthApi.md#logout) | **POST** /api/v1/auth/logout | Invalidate the Refresh token (Auth)
[**RefreshToken**](AuthApi.md#refreshtoken) | **POST** /api/v1/auth/refreshtoken | Receive a new Access token


<a name="login"></a>
# **Login**
> LoginResponse Login (RequestLoginModel loginRequest = null)

Receive an Access and Refresh Token

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class LoginExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var loginRequest = new RequestLoginModel(); // RequestLoginModel | Login Request Dto (optional) 

            try
            {
                // Receive an Access and Refresh Token
                LoginResponse result = apiInstance.Login(loginRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.Login: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loginRequest** | [**RequestLoginModel**](RequestLoginModel.md)| Login Request Dto | [optional] 

### Return type

[**LoginResponse**](LoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logout"></a>
# **Logout**
> void Logout ()

Invalidate the Refresh token (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class LogoutExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthApi();

            try
            {
                // Invalidate the Refresh token (Auth)
                apiInstance.Logout();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.Logout: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="refreshtoken"></a>
# **RefreshToken**
> AccessToken RefreshToken (RequestTokenRefresh requestTokenRefresh = null, string authorization = null)

Receive a new Access token

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class RefreshTokenExample
    {
        public void main()
        {
            var apiInstance = new AuthApi();
            var requestTokenRefresh = new RequestTokenRefresh(); // RequestTokenRefresh | Refresh Token Dto (optional) 
            var authorization = authorization_example;  // string | Any previous Access Token. (optional) 

            try
            {
                // Receive a new Access token
                AccessToken result = apiInstance.RefreshToken(requestTokenRefresh, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.RefreshToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestTokenRefresh** | [**RequestTokenRefresh**](RequestTokenRefresh.md)| Refresh Token Dto | [optional] 
 **authorization** | **string**| Any previous Access Token. | [optional] 

### Return type

[**AccessToken**](AccessToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

