# com.Messente.Omnichannel.Model.Viber
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Channel** | **string** |  | 
**Sender** | **string** | Phone number or alphanumeric sender name | [optional] 
**Validity** | **int?** | After how many minutes this channel is considered as failed and the next channel is attempted | [optional] 
**Text** | **string** | Plaintext content for Viber | [optional] 
**ImageUrl** | **string** | URL for the embedded image. Valid combinations: 1) &#39;image_url&#39; 2) &#39;text&#39;, &#39;image_url&#39;, &#39;button_url&#39;, &#39;button_text&#39; | [optional] 
**ButtonUrl** | **string** | URL of the button, must be specified along with &#39;text&#39;, &#39;button_text&#39;  and &#39;image_url&#39; (optional) | [optional] 
**ButtonText** | **string** | Must be specified along with &#39;text&#39;, &#39;button_url&#39;, &#39;button_text&#39;, &#39;image_url&#39; (optional) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

