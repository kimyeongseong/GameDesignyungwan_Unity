using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class rank : MonoBehaviour {
    public GameObject a;
    public string b;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void dewqeqw(InputField ip)
    {
        //b = ip;
        PlayerPrefs.SetString("id", b);
        a.GetComponent<Text>().text = ""+ip;
    }
}
