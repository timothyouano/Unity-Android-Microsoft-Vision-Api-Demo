using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionAPItoCAM : MonoBehaviour {


        public string ApiKey = "YOUR VISION API KEY HERE"; // replace with your own key
        // Emotion URL can be /tag or /analyze depending on what you need the vision service to be - View Microsoft Documentation for more details
        public string emotionURL = "https://westcentralus.api.cognitive.microsoft.com/vision/v1.0/tag";

        public List<AnalyzedObject> imageCategories = new List<AnalyzedObject>();

        public string fileName { get; private set; }
        string responseData;

        // Use this for initialization
        void Start()
        {
            fileName = System.IO.Path.Combine(Application.streamingAssetsPath, "lion.jpg");
        }

        public void getData(byte[] bytes)
        {
            StartCoroutine(GetDataFromImages(bytes));
        }

        IEnumerator GetDataFromImages(byte[] bytes)
        {
            var headers = new Dictionary<string, string>() {
                { "Ocp-Apim-Subscription-Key", ApiKey },
                { "Content-Type", "application/octet-stream" }
            };

            WWW www = new WWW(emotionURL, bytes, headers);

            yield return www;
            responseData = www.text;
            ParseJSONData(responseData);
        }

        // Parsing Data
        public void ParseJSONData(string respString)
        {
            JSONObject dataArray = new JSONObject(respString);
            AnalyzedObject _imageObject = ConvertObjectToFoundImageObject(dataArray);
        }

        private AnalyzedObject ConvertObjectToFoundImageObject(JSONObject obj)
        {
            JSONObject _categories = obj.list[0]; // Get the list of categories
            return new AnalyzedObject(_categories);
        }
}
