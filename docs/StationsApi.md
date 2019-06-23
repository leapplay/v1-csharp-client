# LeapPlay.Api.Api.StationsApi

All URIs are relative to *https://api.leap-play.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateStation**](StationsApi.md#createstation) | **PUT** /api/v1/stations | Creates a Station (Auth)
[**GetSessionLogsAll**](StationsApi.md#getsessionlogsall) | **GET** /api/v1/stations/sessions | Gets closed Sessions from all stations (Auth)
[**GetSessionLogsByStationId**](StationsApi.md#getsessionlogsbystationid) | **GET** /api/v1/stations/{stationId}/sessions | Gets closed Sessions (Auth)
[**GetSettings**](StationsApi.md#getsettings) | **GET** /api/v1/stations/settings | Gets the Settings of all Stations (Auth)
[**GetSettingsByStationId**](StationsApi.md#getsettingsbystationid) | **GET** /api/v1/stations/{stationId}/settings | Get the Settings of an Station (Auth)
[**GetState**](StationsApi.md#getstate) | **GET** /api/v1/stations/{stationId} | Get the Station&#39;s State (Auth)
[**GetStates**](StationsApi.md#getstates) | **GET** /api/v1/stations | Gets Collection of Station States (Auth)
[**SessionCreate**](StationsApi.md#sessioncreate) | **PUT** /api/v1/stations/{stationId}/sessions | Creates a Session (Auth)
[**SessionStop**](StationsApi.md#sessionstop) | **POST** /api/v1/stations/{stationId}/sessions/current/stop | Stops the running Session (Auth)
[**SessionUpdate**](StationsApi.md#sessionupdate) | **POST** /api/v1/stations/{stationId}/sessions/current/update | Updates the running Session. (Auth)
[**SetSettings**](StationsApi.md#setsettings) | **POST** /api/v1/stations/{stationId}/settings | Sets the Settings for an Station (Auth)
[**SetStationMode**](StationsApi.md#setstationmode) | **POST** /api/v1/stations/{stationId}/settings/mode | Sets the Operation Mode (Auth)
[**SetStationPassword**](StationsApi.md#setstationpassword) | **POST** /api/v1/stations/{stationId}/settings/password | Changes the Password (Auth)
[**SetStationQrCode**](StationsApi.md#setstationqrcode) | **POST** /api/v1/stations/{stationId}/settings/qrcode | Sets the QrCode (Auth)


<a name="createstation"></a>
# **CreateStation**
> StationSettings CreateStation (RequestCreateStation createStation = null)

Creates a Station (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class CreateStationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StationsApi();
            var createStation = new RequestCreateStation(); // RequestCreateStation | Create Station Dto (optional) 

            try
            {
                // Creates a Station (Auth)
                StationSettings result = apiInstance.CreateStation(createStation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.CreateStation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createStation** | [**RequestCreateStation**](RequestCreateStation.md)| Create Station Dto | [optional] 

### Return type

[**StationSettings**](StationSettings.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsessionlogsall"></a>
# **GetSessionLogsAll**
> ICollection<SessionLog> GetSessionLogsAll (int? take = null, int? skip = null)

Gets closed Sessions from all stations (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class GetSessionLogsAllExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StationsApi();
            var take = 56;  // int? | Entries to return (optional)  (default to 50)
            var skip = 56;  // int? | Entries to skip (optional)  (default to 0)

            try
            {
                // Gets closed Sessions from all stations (Auth)
                ICollection&lt;SessionLog&gt; result = apiInstance.GetSessionLogsAll(take, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.GetSessionLogsAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **take** | **int?**| Entries to return | [optional] [default to 50]
 **skip** | **int?**| Entries to skip | [optional] [default to 0]

### Return type

[**ICollection<SessionLog>**](SessionLog.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsessionlogsbystationid"></a>
# **GetSessionLogsByStationId**
> ICollection<SessionLog> GetSessionLogsByStationId (Guid? stationId, int? take = null, int? skip = null)

Gets closed Sessions (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class GetSessionLogsByStationIdExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StationsApi();
            var stationId = new Guid?(); // Guid? | Station Id
            var take = 56;  // int? | Entries to return (optional)  (default to 50)
            var skip = 56;  // int? | Entries to skip (optional)  (default to 0)

            try
            {
                // Gets closed Sessions (Auth)
                ICollection&lt;SessionLog&gt; result = apiInstance.GetSessionLogsByStationId(stationId, take, skip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.GetSessionLogsByStationId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | [**Guid?**](Guid?.md)| Station Id | 
 **take** | **int?**| Entries to return | [optional] [default to 50]
 **skip** | **int?**| Entries to skip | [optional] [default to 0]

### Return type

[**ICollection<SessionLog>**](SessionLog.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsettings"></a>
# **GetSettings**
> ICollection<StationSettings> GetSettings ()

Gets the Settings of all Stations (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class GetSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StationsApi();

            try
            {
                // Gets the Settings of all Stations (Auth)
                ICollection&lt;StationSettings&gt; result = apiInstance.GetSettings();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.GetSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ICollection<StationSettings>**](StationSettings.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsettingsbystationid"></a>
# **GetSettingsByStationId**
> StationSettings GetSettingsByStationId (Guid? stationId)

Get the Settings of an Station (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class GetSettingsByStationIdExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StationsApi();
            var stationId = new Guid?(); // Guid? | Station Id

            try
            {
                // Get the Settings of an Station (Auth)
                StationSettings result = apiInstance.GetSettingsByStationId(stationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.GetSettingsByStationId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | [**Guid?**](Guid?.md)| Station Id | 

### Return type

[**StationSettings**](StationSettings.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstate"></a>
# **GetState**
> StationCurrentState GetState (Guid? stationId)

Get the Station's State (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class GetStateExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StationsApi();
            var stationId = new Guid?(); // Guid? | Station Id

            try
            {
                // Get the Station's State (Auth)
                StationCurrentState result = apiInstance.GetState(stationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.GetState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | [**Guid?**](Guid?.md)| Station Id | 

### Return type

[**StationCurrentState**](StationCurrentState.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getstates"></a>
# **GetStates**
> ICollection<StationCurrentState> GetStates (string networkStateFilter = null)

Gets Collection of Station States (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class GetStatesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StationsApi();
            var networkStateFilter = networkStateFilter_example;  // string | Optional Network State Filter (optional) 

            try
            {
                // Gets Collection of Station States (Auth)
                ICollection&lt;StationCurrentState&gt; result = apiInstance.GetStates(networkStateFilter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.GetStates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **networkStateFilter** | **string**| Optional Network State Filter | [optional] 

### Return type

[**ICollection<StationCurrentState>**](StationCurrentState.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessioncreate"></a>
# **SessionCreate**
> CreatedSession SessionCreate (Guid? stationId, RequestNewStationSession createSessionRequest = null)

Creates a Session (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class SessionCreateExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StationsApi();
            var stationId = new Guid?(); // Guid? | Station Id
            var createSessionRequest = new RequestNewStationSession(); // RequestNewStationSession | New Session Request Dto (optional) 

            try
            {
                // Creates a Session (Auth)
                CreatedSession result = apiInstance.SessionCreate(stationId, createSessionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.SessionCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | [**Guid?**](Guid?.md)| Station Id | 
 **createSessionRequest** | [**RequestNewStationSession**](RequestNewStationSession.md)| New Session Request Dto | [optional] 

### Return type

[**CreatedSession**](CreatedSession.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionstop"></a>
# **SessionStop**
> StoppedSession SessionStop (Guid? stationId)

Stops the running Session (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class SessionStopExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StationsApi();
            var stationId = new Guid?(); // Guid? | Station Id

            try
            {
                // Stops the running Session (Auth)
                StoppedSession result = apiInstance.SessionStop(stationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.SessionStop: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | [**Guid?**](Guid?.md)| Station Id | 

### Return type

[**StoppedSession**](StoppedSession.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionupdate"></a>
# **SessionUpdate**
> UpdatedSession SessionUpdate (Guid? stationId, RequestSessionUpdate updateSessionRequest = null)

Updates the running Session. (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class SessionUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StationsApi();
            var stationId = new Guid?(); // Guid? | Station Id
            var updateSessionRequest = new RequestSessionUpdate(); // RequestSessionUpdate | The Update Request Dto (optional) 

            try
            {
                // Updates the running Session. (Auth)
                UpdatedSession result = apiInstance.SessionUpdate(stationId, updateSessionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.SessionUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | [**Guid?**](Guid?.md)| Station Id | 
 **updateSessionRequest** | [**RequestSessionUpdate**](RequestSessionUpdate.md)| The Update Request Dto | [optional] 

### Return type

[**UpdatedSession**](UpdatedSession.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setsettings"></a>
# **SetSettings**
> void SetSettings (Guid? stationId, RequestStationSettings setSettingsRequest = null)

Sets the Settings for an Station (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class SetSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StationsApi();
            var stationId = new Guid?(); // Guid? | Station Id
            var setSettingsRequest = new RequestStationSettings(); // RequestStationSettings | Settings Dto (optional) 

            try
            {
                // Sets the Settings for an Station (Auth)
                apiInstance.SetSettings(stationId, setSettingsRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.SetSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | [**Guid?**](Guid?.md)| Station Id | 
 **setSettingsRequest** | [**RequestStationSettings**](RequestStationSettings.md)| Settings Dto | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setstationmode"></a>
# **SetStationMode**
> void SetStationMode (Guid? stationId, RequestStationMode setModeRequest = null)

Sets the Operation Mode (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class SetStationModeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StationsApi();
            var stationId = new Guid?(); // Guid? | Station Id
            var setModeRequest = new RequestStationMode(); // RequestStationMode | The Operation Mode (optional) 

            try
            {
                // Sets the Operation Mode (Auth)
                apiInstance.SetStationMode(stationId, setModeRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.SetStationMode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | [**Guid?**](Guid?.md)| Station Id | 
 **setModeRequest** | [**RequestStationMode**](RequestStationMode.md)| The Operation Mode | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setstationpassword"></a>
# **SetStationPassword**
> void SetStationPassword (Guid? stationId, RequestSetStationPassword setPasswordRequest = null)

Changes the Password (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class SetStationPasswordExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StationsApi();
            var stationId = new Guid?(); // Guid? | Station Id
            var setPasswordRequest = new RequestSetStationPassword(); // RequestSetStationPassword | New Password (optional) 

            try
            {
                // Changes the Password (Auth)
                apiInstance.SetStationPassword(stationId, setPasswordRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.SetStationPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | [**Guid?**](Guid?.md)| Station Id | 
 **setPasswordRequest** | [**RequestSetStationPassword**](RequestSetStationPassword.md)| New Password | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setstationqrcode"></a>
# **SetStationQrCode**
> void SetStationQrCode (Guid? stationId, RequestStationQrCode setQrCodeRequest = null)

Sets the QrCode (Auth)

### Example
```csharp
using System;
using System.Diagnostics;
using LeapPlay.Api.Api;
using LeapPlay.Api.Client;
using LeapPlay.Api.Model;

namespace Example
{
    public class SetStationQrCodeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StationsApi();
            var stationId = new Guid?(); // Guid? | Station Id
            var setQrCodeRequest = new RequestStationQrCode(); // RequestStationQrCode | QrCode (optional) 

            try
            {
                // Sets the QrCode (Auth)
                apiInstance.SetStationQrCode(stationId, setQrCodeRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationsApi.SetStationQrCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stationId** | [**Guid?**](Guid?.md)| Station Id | 
 **setQrCodeRequest** | [**RequestStationQrCode**](RequestStationQrCode.md)| QrCode | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

