using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

[System.Serializable]
public class CardsCollection
{
    public JsonCards[] cards;
}

[System.Serializable]
public class JsonCards
{
    public int CardID;
    public string Name;
    public int Grade;
    public int ATK;
    public string Clan;
    public string Race;
    public string Nation;
    public string Type;
    public List<string> Text;
}

public class JsonParser : MonoBehaviour
{

    public CardsCollection LoadJson(string path)
    {
        string json = File.ReadAllText(path);
        CardsCollection Cc = JsonUtility.FromJson<CardsCollection>(json);
        return Cc;
    }
}