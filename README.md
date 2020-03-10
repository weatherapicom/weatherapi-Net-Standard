# Getting started


# Introduction

WeatherAPI.com provides access to weather and geo data via a JSON/XML restful API. It allows developers to create desktop, web and mobile applications using this data very easy.

We provide following data through our API:

  * Real-time weather

  * 10 day weather forecast

  * Astronomy

  * Time zone

  * Location data

  * Search or Autocomplete API

  * NEW: Historical weather

# Getting Started

You need to [signup](https://www.weatherapi.com/signup.aspx) and then you can find your API key under [your account](https://www.weatherapi.com/login.aspx), and start using API right away!

If you find any features missing or have any suggestions, please [contact us](https://www.weatherapi.com/contact.aspx).

# Authentication

API access to the data is protected by an API key. If at anytime, you find the API key has become vulnerable, please regenerate the key using Regenerate button next to the API key.

Authentication to the WeatherAPI.com API is provided by passing your API key as request parameter through an API .

  ##  key parameter
  key=YOUR_API_KEY


## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (WeatherAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Weather%20API-CSharp&workspaceName=WeatherAPI&projectName=WeatherAPI.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the WeatherAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Weather%20API-CSharp&workspaceName=WeatherAPI&projectName=WeatherAPI.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Weather%20API-CSharp&workspaceName=WeatherAPI&projectName=WeatherAPI.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Weather%20API-CSharp&workspaceName=WeatherAPI&projectName=WeatherAPI.Standard)

### 3. Add reference of the library project

In order to use the WeatherAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Weather%20API-CSharp&workspaceName=WeatherAPI&projectName=WeatherAPI.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` WeatherAPI.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```WeatherAPI.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Weather%20API-CSharp&workspaceName=WeatherAPI&projectName=WeatherAPI.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Weather%20API-CSharp&workspaceName=WeatherAPI&projectName=WeatherAPI.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| key | TODO: add a description |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string key = "key";

WeatherAPIClient client = new WeatherAPIClient(key);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [APIsController](#ap_is_controller)

## <a name="ap_is_controller"></a>![Class: ](https://apidocs.io/img/class.png "WeatherAPI.Standard.Controllers.APIsController") APIsController

### Get singleton instance

The singleton instance of the ``` APIsController ``` class can be accessed from the API Client.

```csharp
APIsController aPIs = client.APIs;
```

### <a name="get_realtime_weather"></a>![Method: ](https://apidocs.io/img/method.png "WeatherAPI.Standard.Controllers.APIsController.GetRealtimeWeather") GetRealtimeWeather

> Current weather or realtime weather API method allows a user to get up to date current weather information in json and xml. The data is returned as a Current Object.Current object contains current or realtime weather information for a given city.


```csharp
Task<Models.CurrentJsonResponse> GetRealtimeWeather(string q, string lang = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| q |  ``` Required ```  | Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more. |
| lang |  ``` Optional ```  | Returns 'condition:text' field in API in the desired language. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to check 'lang-code'. |


#### Example Usage

```csharp
string q = "q";
string lang = "lang";

Models.CurrentJsonResponse result = await aPIs.GetRealtimeWeather(q, lang);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error code 1003: Parameter 'q' not provided.Error code 1005: API request url is invalid.Error code 1006: No location found matching parameter 'q'Error code 9999: Internal application error. |
| 401 | Error code 1002: API key not provided.Error code 2006: API key provided is invalid |
| 403 | Error code 2007: API key has exceeded calls per month quota.<br />Error code 2008: API key has been disabled. |


### <a name="get_forecast_weather"></a>![Method: ](https://apidocs.io/img/method.png "WeatherAPI.Standard.Controllers.APIsController.GetForecastWeather") GetForecastWeather

> Forecast weather API method returns upto next 10 day weather forecast and weather alert as json. The data is returned as a Forecast Object.<br />Forecast object contains astronomy data, day weather forecast and hourly interval weather information for a given city.


```csharp
Task<Models.ForecastJsonResponse> GetForecastWeather(
        string q,
        int days,
        DateTime? dt = null,
        int? unixdt = null,
        int? hour = null,
        string lang = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| q |  ``` Required ```  | Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more. |
| days |  ``` Required ```  | Number of days of weather forecast. Value ranges from 1 to 10 |
| dt |  ``` Optional ```  | Date should be between today and next 10 day in yyyy-MM-dd format |
| unixdt |  ``` Optional ```  | Please either pass 'dt' or 'unixdt' and not both in same request.<br />unixdt should be between today and next 10 day in Unix format |
| hour |  ``` Optional ```  | Must be in 24 hour. For example 5 pm should be hour=17, 6 am as hour=6 |
| lang |  ``` Optional ```  | Returns 'condition:text' field in API in the desired language. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to check 'lang-code'. |


#### Example Usage

```csharp
string q = "q";
int days = 160;
DateTime? dt = DateTime.Now();
int? unixdt = 160;
int? hour = 160;
string lang = "lang";

Models.ForecastJsonResponse result = await aPIs.GetForecastWeather(q, days, dt, unixdt, hour, lang);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error code 1003: Parameter 'q' not provided.Error code 1005: API request url is invalid.Error code 1006: No location found matching parameter 'q'Error code 9999: Internal application error. |
| 401 | Error code 1002: API key not provided.Error code 2006: API key provided is invalid |
| 403 | Error code 2007: API key has exceeded calls per month quota.<br />Error code 2008: API key has been disabled. |


### <a name="get_history_weather"></a>![Method: ](https://apidocs.io/img/method.png "WeatherAPI.Standard.Controllers.APIsController.GetHistoryWeather") GetHistoryWeather

> History weather API method returns historical weather for a date on or after 1st Jan, 2015 as json. The data is returned as a Forecast Object.


```csharp
Task<Models.HistoryJsonResponse> GetHistoryWeather(
        string q,
        DateTime dt,
        int? unixdt = null,
        DateTime? endDt = null,
        int? unixendDt = null,
        int? hour = null,
        string lang = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| q |  ``` Required ```  | Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more. |
| dt |  ``` Required ```  | Date on or after 1st Jan, 2015 in yyyy-MM-dd format |
| unixdt |  ``` Optional ```  | Please either pass 'dt' or 'unixdt' and not both in same request.<br />unixdt should be on or after 1st Jan, 2015 in Unix format |
| endDt |  ``` Optional ```  | Date on or after 1st Jan, 2015 in yyyy-MM-dd format'end_dt' should be greater than 'dt' parameter and difference should not be more than 30 days between the two dates. |
| unixendDt |  ``` Optional ```  | Date on or after 1st Jan, 2015 in Unix Timestamp format<br />unixend_dt has same restriction as 'end_dt' parameter. Please either pass 'end_dt' or 'unixend_dt' and not both in same request. e.g.: unixend_dt=1490227200 |
| hour |  ``` Optional ```  | Must be in 24 hour. For example 5 pm should be hour=17, 6 am as hour=6 |
| lang |  ``` Optional ```  | Returns 'condition:text' field in API in the desired language. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to check 'lang-code'. |


#### Example Usage

```csharp
string q = "q";
DateTime dt = DateTime.Now();
int? unixdt = 160;
DateTime? endDt = DateTime.Now();
int? unixendDt = 160;
int? hour = 160;
string lang = "lang";

Models.HistoryJsonResponse result = await aPIs.GetHistoryWeather(q, dt, unixdt, endDt, unixendDt, hour, lang);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error code 1003: Parameter 'q' not provided.Error code 1005: API request url is invalid.Error code 1006: No location found matching parameter 'q'Error code 9999: Internal application error. |
| 401 | Error code 1002: API key not provided.Error code 2006: API key provided is invalid |
| 403 | Error code 2007: API key has exceeded calls per month quota.<br />Error code 2008: API key has been disabled. |


### <a name="search_autocomplete_weather"></a>![Method: ](https://apidocs.io/img/method.png "WeatherAPI.Standard.Controllers.APIsController.SearchAutocompleteWeather") SearchAutocompleteWeather

> WeatherAPI.com Search or Autocomplete API returns matching cities and towns as an array of Location object.


```csharp
Task<List<Models.SearchJsonResponse>> SearchAutocompleteWeather(string q)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| q |  ``` Required ```  | Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more. |


#### Example Usage

```csharp
string q = "q";

List<Models.SearchJsonResponse> result = await aPIs.SearchAutocompleteWeather(q);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error code 1003: Parameter 'q' not provided.Error code 1005: API request url is invalid.Error code 1006: No location found matching parameter 'q'Error code 9999: Internal application error. |
| 401 | Error code 1002: API key not provided.Error code 2006: API key provided is invalid |
| 403 | Error code 2007: API key has exceeded calls per month quota.<br />Error code 2008: API key has been disabled. |


### <a name="get_ip_lookup"></a>![Method: ](https://apidocs.io/img/method.png "WeatherAPI.Standard.Controllers.APIsController.GetIpLookup") GetIpLookup

> IP Lookup API method allows a user to get up to date information for an IP address.


```csharp
Task<Models.IpJsonResponse> GetIpLookup(string q)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| q |  ``` Required ```  | Pass IP address. |


#### Example Usage

```csharp
string q = "q";

Models.IpJsonResponse result = await aPIs.GetIpLookup(q);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error code 1003: Parameter 'q' not provided.Error code 1005: API request url is invalid.Error code 1006: No location found matching parameter 'q'Error code 9999: Internal application error. |
| 401 | Error code 1002: API key not provided.Error code 2006: API key provided is invalid |
| 403 | Error code 2007: API key has exceeded calls per month quota.<br />Error code 2008: API key has been disabled. |


### <a name="get_time_zone"></a>![Method: ](https://apidocs.io/img/method.png "WeatherAPI.Standard.Controllers.APIsController.GetTimeZone") GetTimeZone

> Return Location Object


```csharp
Task<Models.TimezoneJsonResponse> GetTimeZone(string q)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| q |  ``` Required ```  | Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more. |


#### Example Usage

```csharp
string q = "q";

Models.TimezoneJsonResponse result = await aPIs.GetTimeZone(q);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error code 1003: Parameter 'q' not provided.Error code 1005: API request url is invalid.Error code 1006: No location found matching parameter 'q'Error code 9999: Internal application error. |
| 401 | Error code 1002: API key not provided.Error code 2006: API key provided is invalid |
| 403 | Error code 2007: API key has exceeded calls per month quota.<br />Error code 2008: API key has been disabled. |


### <a name="get_astronomy"></a>![Method: ](https://apidocs.io/img/method.png "WeatherAPI.Standard.Controllers.APIsController.GetAstronomy") GetAstronomy

> Return Location and Astronomy Object


```csharp
Task<Models.AstronomyJsonResponse> GetAstronomy(string q, DateTime dt)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| q |  ``` Required ```  | Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name. Visit [request parameter section](https://www.weatherapi.com/docs/#intro-request) to learn more. |
| dt |  ``` Required ```  | Date on or after 1st Jan, 2015 in yyyy-MM-dd format |


#### Example Usage

```csharp
string q = "q";
DateTime dt = DateTime.Now();

Models.AstronomyJsonResponse result = await aPIs.GetAstronomy(q, dt);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Error code 1003: Parameter 'q' not provided.Error code 1005: API request url is invalid.Error code 1006: No location found matching parameter 'q'Error code 9999: Internal application error. |
| 401 | Error code 1002: API key not provided.Error code 2006: API key provided is invalid |
| 403 | Error code 2007: API key has exceeded calls per month quota.<br />Error code 2008: API key has been disabled. |


[Back to List of Controllers](#list_of_controllers)



