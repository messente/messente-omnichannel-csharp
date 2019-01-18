# com.Messente.Omnichannel - the C# library for Messente's Omnichannel API

Messente's API which allows sending messages via various channels with fallback options.

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

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
    public class SendOmniMessageExample
    {
        public void main()
        {
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "<MESSENTE_API_USERNAME>";
            Configuration.Default.Password = "<MESSENTE_API_PASSWORD>";

            List<object> messages = new List<object>();
            var sms = new SMS(sender: "<sender number or name>", text: "Hello SMS!");
            var viber = new Viber(text: "Hello viber!");
            var whatsapp = new WhatsApp(text: new WhatsAppText(body: "Hello WhatsApp!"));
            messages.Add(viber);
            messages.Add(whatsapp);
            messages.Add(sms);

            var apiInstance = new OmnimessageApi();
            var omnimessage = new Omnimessage(to: "<phone_number>", messages: messages);

            try
            {
                // Sends an Omnimessage
                OmniMessageCreateSuccessResponse result = apiInstance.SendOmnimessage(omnimessage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OmnimessageApi.SendOmnimessage: " + e.Message);

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

