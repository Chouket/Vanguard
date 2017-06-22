using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Script.Tools;

using Newtonsoft.Json;

public class JsonCardParser : MonoBehaviour {

    JsonCardData _shadowCards = null;

    void Start ()
    {
        string jsonPath = Application.dataPath + "/CardsInfos/JsonCards/ShadowPaladin3.json";
        Debug.Log(jsonPath);
        List<JsonCardData> items = JsonConvert.DeserializeObject<List<JsonCardData>>(jsonPath);
	}
	
	void Update ()
    {
	}
}
