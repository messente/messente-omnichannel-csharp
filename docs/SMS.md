# com.Messente.Omnichannel.Model.SMS
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Channel** | **string** |  | 
**Sender** | **string** | Phone number or alphanumeric sender name | [optional] 
**Validity** | **int?** | After how many minutes this channel is considered as failed and the next channel is attempted | [optional] 
**Text** | **string** | Text content of the SMS | 
**Autoconvert** | **decimal?** | Defines how non-GSM characters will be treated: - \&quot;on\&quot; Use replacement settings from the account&#39;s [API Auto Replace settings page](https://dashboard.messente.com/api-settings/auto-replace)(default) - \&quot;full\&quot; All non GSM 03.38 characters will be replaced with suitable alternatives - \&quot;off\&quot; Message content is not modified in any way  | [optional] 
**Udh** | **string** | hex-encoded string containing SMS UDH | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

