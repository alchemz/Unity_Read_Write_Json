using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class CsWriteJson : MonoBehaviour {
    public int[] inc = new int[] { 1, 2, 3, 4, 4 };
    public Character Player = new Character(0,"Austin", 7, false, new int[] { 7,4,11});
    //convert the character to json

    JsonData playerJson;

	// Use this for initialization
	void Start () {
        playerJson = JsonMapper.ToJson(Player);
        Debug.Log(playerJson);
        File.WriteAllText(Application.dataPath + "/Player.json", playerJson.ToString());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


public class Character
{
    public int id;
    public string name;
    public int health;
    public bool aggressive;
    public int[] stats;


    public Character(int id, string name, int health, bool aggressive, int[] stats)
    {
        this.id = id;
        this.name = name;
        this.health = health;
        this.aggressive = aggressive;
        this.stats = stats;
    }
}