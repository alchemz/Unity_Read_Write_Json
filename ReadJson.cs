using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class RootObject
{
    public string Name { get; set; }
    public int Level { get; set; }
    public List<int> Stats { get; set; }
}


public class RootObject_
{
    public string Name { get; set; }
    public int Level { get; set; }
    public List<List<int>> Stats { get; set; }
}
public class ReadJson : MonoBehaviour {

    
    private string jsonString;
    private JsonData cmdData;


    private string jsonString_;
    private JsonData cmdData_;
    // Use this for initialization
    void Start()
    {
        
        jsonString = File.ReadAllText(Application.dataPath + "/Resources/test.json");
        RootObject stats = JsonMapper.ToObject<RootObject>(jsonString);
        //cmdData = JsonMapper.ToObject(jsonString);
        Debug.Log(stats.Name);
        Debug.Log(stats.Level);
        Debug.Log(stats.Stats[0]);


        jsonString_ = File.ReadAllText(Application.dataPath + "/Resources/test2.json");
        RootObject_ stats_ = JsonMapper.ToObject<RootObject_>(jsonString_);
        Debug.Log(stats_.Stats[0][0]+" " +stats_.Stats[0][1]);
        Debug.Log(stats_.Stats[1][0] + " " + stats_.Stats[1][1]);
        Debug.Log(stats_.Stats[2][0] + " " + stats_.Stats[2][1]);
        cmdData_ = JsonMapper.ToObject(jsonString);
        
      
    }
}


