using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {
    public static int n_Score;
    public GameObject Line;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Text ScoreText = GetComponent<Text>();
        GetComponent<Text>().text = "" + PlayerPrefs.GetInt("score");
        //GetComponent<TextMesh>().text = PlayerPrefs.GetInt("score")+ "<color=REd>마리</color>";
    }
}
