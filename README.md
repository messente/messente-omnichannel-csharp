# com.Messente.Omnichannel - the C# library for Messente's Omnichannel API

Messente's API which allows sending messages via various channels with fallback options.

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using com.Messente.Omnichannel.Api;
using com.Messente.Omnichannel.Client;
using com.Messente.Omnichannel.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using com.Messente.Omnichannel.Api;
using com.Messente.Omnichannel.Client;
using com.Messente.Omnichannel.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure HTTP basic authorization: basicAuth
            # API information from https://dashboard.messente.com/api-settings
            Configuration.Default.Username = "<MESSENTE_API_USERNAME>";
            Configuration.Default.Password = "<MESSENTE_API_PASSWORD>"";
            var apiInstance = new DeliveryReportApi();
            var omnimessageId = new Guid?(); // Guid? | UUID of the Omnimessage to for which the delivery report is to be retrieved

            try
            {
                // Retrieves the delivery report for the Omnimessage
                DeliveryReportResponse result = apiInstance.RetrieveDeliveryReport(omnimessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DeliveryReportApi.RetrieveDeliveryReport: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.messente.com/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DeliveryReportApi* | [**RetrieveDeliveryReport**](docs/DeliveryReportApi.md#retrievedeliveryreport) | **GET** /omnimessage/{omnimessage_id}/status | Retrieves the delivery report for the Omnimessage
*OmnimessageApi* | [**CancelScheduledMessage**](docs/OmnimessageApi.md#cancelscheduledmessage) | **DELETE** /omnimessage/{omnimessage_id} | Cancels a scheduled Omnimessage
*OmnimessageApi* | [**SendOmnimessage**](docs/OmnimessageApi.md#sendomnimessage) | **POST** /omnimessage | Sends an Omnimessage


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Channel](docs/Channel.md)
 - [Model.DeliveryReportResponse](docs/DeliveryReportResponse.md)
 - [Model.DeliveryResult](docs/DeliveryResult.md)
 - [Model.Err](docs/Err.md)
 - [Model.ErrorItem](docs/ErrorItem.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.Message](docs/Message.md)
 - [Model.MessageResult](docs/MessageResult.md)
 - [Model.OmniMessageCreateSuccessResponse](docs/OmniMessageCreateSuccessResponse.md)
 - [Model.Omnimessage](docs/Omnimessage.md)
 - [Model.ResponseErrorCode](docs/ResponseErrorCode.md)
 - [Model.ResponseErrorTitle](docs/ResponseErrorTitle.md)
 - [Model.SMS](docs/SMS.md)
 - [Model.Status](docs/Status.md)
 - [Model.Viber](docs/Viber.md)
 - [Model.WhatsApp](docs/WhatsApp.md)
 - [Model.WhatsAppAudio](docs/WhatsAppAudio.md)
 - [Model.WhatsAppDocument](docs/WhatsAppDocument.md)
 - [Model.WhatsAppImage](docs/WhatsAppImage.md)
 - [Model.WhatsAppText](docs/WhatsAppText.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="basicAuth"></a>
### basicAuth

- **Type**: HTTP basic authentication

