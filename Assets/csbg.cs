﻿using UnityEngine;
using System.Collections;

public class csbg : MonoBehaviour
{
    public float speed; //이동 속도

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //왼쪽방향으로 speed만큼 이동하게됩니다.
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        //x좌표가 -12.8보다 작아지게 되면...
        if (transform.position.x < -18.3f)
        {
            //위치를 0, 0 으로 옮겨줍니다.
            transform.position = new Vector2(+17.2f, transform.position.y);
        }
    }
}
