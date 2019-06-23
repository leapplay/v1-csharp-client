# LeapPlay.Api.Api.AccountsApi

All URIs are relative to *https://api.leap-play.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangePassword**](AccountsApi.md#changepassword) | **POST** /api/v1/accounts/password/change | Changes the Password and provides a new Refresh Token (Auth)
[**ConfirmEmail**](AccountsApi.md#confirmemail) | **POST** /api/v1/accounts/email/confirmation | Confirms ownership of an E-Mail Address by an E-Mail Confirmation Token
[**Register**](AccountsApi.md#register) | **POST** /api/v1/accounts/register | Registers a User Account
[**RequestPassword**](AccountsApi.md#requestpassword) | **POST** /api/v1/accounts/password/forgot | Receives a Reset Token that is required to reset the Password
[**ResendEMailConfirmation**](AccountsApi.md#resendemailconfirmation) | **POST** /api/v1/accounts/email/confirmation/send | Re-sends a message with a EMail Confirmation Token.
[**ResetPassword**](AccountsApi.md#resetpassword) | **POST** /api/v1/accounts/password/reset | Resets the Password with an Reset Token


<a name="changepassword"></a>
# **ChangePassword**
> ChangedPasswordUser ChangePassword (RequestChangePassword changePasswordRequest)

Changes the Password and provides a new Refresh Token (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class ChangePasswordExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi();
            var changePasswordRequest = new RequestChangePassword(); // RequestChangePassword | The change password request.

            try
            {
                // Changes the Password and provides a new Refresh Token (Auth)
                ChangedPasswordUser result = apiInstance.ChangePassword(changePasswordRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ChangePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changePasswordRequest** | [**RequestChangePassword**](RequestChangePassword.md)| The change password request. | 

### Return type

[**ChangedPasswordUser**](ChangedPasswordUser.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmemail"></a>
# **ConfirmEmail**
> void ConfirmEmail (RequestEmailConfirmation emailConfirmationRequest)

Confirms ownership of an E-Mail Address by an E-Mail Confirmation Token

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class ConfirmEmailExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var emailConfirmationRequest = new RequestEmailConfirmation(); // RequestEmailConfirmation | The request email confirmation.

            try
            {
                // Confirms ownership of an E-Mail Address by an E-Mail Confirmation Token
                apiInstance.ConfirmEmail(emailConfirmationRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ConfirmEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailConfirmationRequest** | [**RequestEmailConfirmation**](RequestEmailConfirmation.md)| The request email confirmation. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="register"></a>
# **Register**
> void Register (RequestRegisterUser registerRequest)

Registers a User Account

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class RegisterExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var registerRequest = new RequestRegisterUser(); // RequestRegisterUser | 

            try
            {
                // Registers a User Account
                apiInstance.Register(registerRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.Register: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **registerRequest** | [**RequestRegisterUser**](RequestRegisterUser.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestpassword"></a>
# **RequestPassword**
> void RequestPassword (RequestForgotPassword forgotPasswordRequest)

Receives a Reset Token that is required to reset the Password

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class RequestPasswordExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var forgotPasswordRequest = new RequestForgotPassword(); // RequestForgotPassword | Request object holding the required parameter

            try
            {
                // Receives a Reset Token that is required to reset the Password
                apiInstance.RequestPassword(forgotPasswordRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.RequestPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **forgotPasswordRequest** | [**RequestForgotPassword**](RequestForgotPassword.md)| Request object holding the required parameter | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resendemailconfirmation"></a>
# **ResendEMailConfirmation**
> void ResendEMailConfirmation (RequestResendConfirmationEmail resendConfirmationEmailRequest)

Re-sends a message with a EMail Confirmation Token.

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class ResendEMailConfirmationExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var resendConfirmationEmailRequest = new RequestResendConfirmationEmail(); // RequestResendConfirmationEmail | The resend email confirmation request.

            try
            {
                // Re-sends a message with a EMail Confirmation Token.
                apiInstance.ResendEMailConfirmation(resendConfirmationEmailRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ResendEMailConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resendConfirmationEmailRequest** | [**RequestResendConfirmationEmail**](RequestResendConfirmationEmail.md)| The resend email confirmation request. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetpassword"></a>
# **ResetPassword**
> void ResetPassword (RequestResetPassword resetPasswordRequest)

Resets the Password with an Reset Token

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class ResetPasswordExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var resetPasswordRequest = new RequestResetPassword(); // RequestResetPassword | The request reset password.

            try
            {
                // Resets the Password with an Reset Token
                apiInstance.ResetPassword(resetPasswordRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.ResetPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resetPasswordRequest** | [**RequestResetPassword**](RequestResetPassword.md)| The request reset password. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

