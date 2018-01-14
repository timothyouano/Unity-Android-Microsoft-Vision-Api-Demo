using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Project by: Timothy Ouano - https://github.com/timokranz/

public class AnalyzedObject : MonoBehaviour {

    public List<ObjectCategory> categories { get; private set; }
    public Text txt = GameObject.Find("Result").GetComponent<Text>();

    public AnalyzedObject(JSONObject cat)
    {
        categories = ConvertScoresToCategoryList(cat);
        GetHighestObjectCategory();
    }

    public List<ObjectCategory> ConvertScoresToCategoryList(JSONObject cat)
    {
        List<ObjectCategory> visionGuesses = new List<ObjectCategory>();
        for (int i = 0; i < cat.Count; i++)
        {
            JSONObject lineObj = cat[i];
            ObjectCategory c = new ObjectCategory(lineObj.list[0].ToString(), float.Parse(lineObj.list[1].ToString()));
            visionGuesses.Add(c);
            Debug.Log(c.ToString());
        }
        return visionGuesses;
    }

    public ObjectCategory GetHighestObjectCategory()
    {
        ObjectCategory max = categories[0];
        foreach (ObjectCategory e in categories)
        {
            if (e.score > max.score)
            {
                max = e;
            }
        }
        Debug.Log("Best ObjectCategory Guess: " + max.ToString());
        txt.text = max.ToString();
        return max;
    }
}
