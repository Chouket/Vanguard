using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Newtonsoft.Json;

public class CardEditor : EditorWindow {

    string jsonPath = "CardsInfos/TestJson/";
    string jsonFileName = "default.json";
    string myString = "Hello World";
    bool groupEnabled;
    bool myBool = true;
    bool createBool = false;
    float myFloat = 1.123456789f;

    static List<JsonData> _data = new List<JsonData>();

    [MenuItem("Window/CardEditor %ce")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(CardEditor));
    }

    void OnGUI()
    {
        GUILayout.Label("Base Settings", EditorStyles.boldLabel);

        jsonPath = EditorGUILayout.TextField("Json path", jsonPath);
        jsonFileName = EditorGUILayout.TextField("Json File Name: ", jsonFileName);
        EditorGUILayout.Separator();
        myString = EditorGUILayout.TextField("Text Field", myString);

        groupEnabled = EditorGUILayout.BeginToggleGroup("Optional Settings", groupEnabled);
        myBool = EditorGUILayout.Toggle("Toggle", myBool);
        myFloat = EditorGUILayout.Slider(myFloat, -3f, 3f);
        EditorGUILayout.EndToggleGroup();

        EditorGUILayout.Separator();
        createBool = EditorGUILayout.Toggle("Create button clicked", createBool);
        if (GUILayout.Button("Add onject in list"))
        {
            JsonData newData = new JsonData();
            newData.myString = myString;
            newData.myFloat = myFloat;
            newData.myBool = myBool;
            _data.Add(newData);
        }
        if (GUILayout.Button("Add Object in Json"))
        {
            createBool = true;
            AddInJson();
        }
    }

    private void AddInJson()
    {
        //string directoryPath = Application.dataPath + "/" + jsonPath;
        //string path = directoryPath + jsonFileName;
        //
        //CheckPath(directoryPath, path);
        //
        //WriteJsonStringInFile(path, _data);

        //string dataToJson = JsonUtility.ToJson(data) + ",\n";
        //File.AppendAllText(path, dataToJson);
    }

    private void WriteJsonStringInFile(string path, List<JsonData> data)
    {
        Debug.Log(data[0].myString);
        string dataToJson = JsonUtility.ToJson(data.ToArray());
        Debug.Log(dataToJson);
        StreamWriter str = File.AppendText(path);
        str.WriteLine(dataToJson);
        str.Close();
    }

    private void CheckPath(string directoryPath, string path)
    {
        if (!Directory.Exists(directoryPath))
            Directory.CreateDirectory(directoryPath);

        if (!File.Exists(path))
        {
            AddBasicMarkerInNewFile(path);
        }
    }

    private void AddBasicMarkerInNewFile(string path)
    {
        StreamWriter str = File.CreateText(path);
        //str.WriteLine("[");
        //str.WriteLine("]");
        str.Close();
    }
}

public class JsonData : MonoBehaviour {

    public string myString;
    public bool myBool;
    public float myFloat;

}