using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Text ScoreText = GetComponent<Text>();
        GetComponent<TextMesh>().text = "" + PlayerPrefs.GetInt("score");
    }
}
