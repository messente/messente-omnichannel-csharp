# com.Messente.Omnichannel.Model.DeliveryResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | [**Status**](Status.md) |  | [optional] 
**Channel** | [**Channel**](Channel.md) |  | [optional] 
**MessageId** | **Guid?** | Unique identifier for the message | [optional] 
**Error** | **string** | Human-readable description of what went wrong, *null* in case of success or if the messages has not been processed yet | [optional] 
**Err** | [**Err**](Err.md) |  | [optional] 
**Timestamp** | **DateTime?** | When this status was received by Omnichannel API | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

