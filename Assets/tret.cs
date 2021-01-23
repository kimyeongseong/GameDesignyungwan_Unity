using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tret : MonoBehaviour {
    public float x;
    public float y;
    public bool a;
    public float time;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if(gameObject.GetComponent<Animator>().GetInteger("crush")==2)
        {
            time += Time.deltaTime;
            if(time>0.8f)
            transform.position += new Vector3(-x, y, 0);
        }
    }
}
