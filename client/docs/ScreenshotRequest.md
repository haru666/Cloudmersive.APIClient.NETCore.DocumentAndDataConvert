# Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Model.ScreenshotRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | URL address of the website to screenshot.  HTTP and HTTPS are both supported, as are custom ports. | [optional] 
**ExtraLoadingWait** | **int?** | Optional: Additional number of milliseconds to wait once the web page has finished loading before taking the screenshot.  Can be helpful for highly asynchronous websites.  Provide a value of 0 for the default of 5000 milliseconds (5 seconds) | [optional] 
**ScreenshotWidth** | **int?** | Optional: Width of the screenshot in pixels; supply 0 to default to 1280 x 1024, supply -1 to measure the full screen height of the page and attempt to take a screen-height screenshot | [optional] 
**ScreenshotHeight** | **int?** | Optional: Height of the screenshot in pixels; supply 0 to default to 1280 x 1024, supply -1 to measure the full screen height of the page and attempt to take a screen-height screenshot | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

