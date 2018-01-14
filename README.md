# Unity-Android-Microsoft-Vision-Api-Demo
A sample for integrating Microsoft Cognitive Services - Vision Api to Unity Android devices this project is strictly for android devices only but if you want to integrate it to desktop you can message me on how to integrate it on desktop. This was integrated in our project ANI - An E-Learning for kids, the project is not yet done I'll update this as soon it is published

License:
You are free to modify the project to your will. Either using it for commercial or personal use as long as I have my name on it.

Instructions:
*The sample has two scripts - VisionAPI and AnalyzedObject
VisionAPI concerns the sending of data to Microsoft Services with the details of what data to get in return.
Replace the ApiKey with your own key, get you Vision API key here:
https://azure.microsoft.com/en-us/try/cognitive-services/?api=computer-vision
and the emotionURL to your desired service for the Vision API, you can find more info in this URL: https://docs.microsoft.com/en-us/azure/cognitive-services/computer-vision/vision-api-how-to-topics/howtosubscribe. This demo uses the /tags to get tags about the image from the server, do as you wish to obtain desired outputs.

*Create an empty GameObject and name it VisionAPI drag and drop the scripts mentioned above. Create a button and drag the VisionAPI GameObject to the onclick method and set it to VisionAPI -> getData(). Make a Text UI and name it Result to get the best guess about the Image

*Change the fileName inside VisionAPI script to your desired image to be processed, the example project uses the images in the StreamingAssets

Any issues?
Make a thread and well fix it together! Hit me up on facebook, I'll respond ASAP - https://www.facebook.com/TrashTalkTim
