using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class C_Scene : MonoBehaviour {
    public string Scene_name;
    public AudioSource a;
    public void Change_Scene()
    {
        a.Play();
        SceneManager.LoadScene(0);
    }
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

	}
}
