using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nhgn : MonoBehaviour
{
    public GameObject[] a;
    public int b;
    public Sprite[] c;
    // Use this for initialization
    void Start()
    {
        a[0].GetComponent<SpriteRenderer>().sprite = c[0];//
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            b--;
            if (b <= 0)
            {
                b = 0;
            }
            if (b == 0)
            {
                a[0].GetComponent<SpriteRenderer>().sprite = c[0];//
                a[1].GetComponent<SpriteRenderer>().sprite = c[4];
                a[2].GetComponent<SpriteRenderer>().sprite = c[5];

            }
            else if(b == 1)
            {
                a[0].GetComponent<SpriteRenderer>().sprite = c[3];
                a[1].GetComponent<SpriteRenderer>().sprite = c[1];//
                a[2].GetComponent<SpriteRenderer>().sprite = c[5];
            }
            else if(b == 2)
            {
                a[0].GetComponent<SpriteRenderer>().sprite = c[3];
                a[1].GetComponent<SpriteRenderer>().sprite = c[4];
                a[2].GetComponent<SpriteRenderer>().sprite = c[2];//
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            b++;
            if (b >= 3)
            {
                b = 2;
            }
            if (b == 0)
            {
                a[0].GetComponent<SpriteRenderer>().sprite = c[0];//
                a[1].GetComponent<SpriteRenderer>().sprite = c[4];
                a[2].GetComponent<SpriteRenderer>().sprite = c[5];

            }
            else if (b == 1)
            {
                a[0].GetComponent<SpriteRenderer>().sprite = c[3];
                a[1].GetComponent<SpriteRenderer>().sprite = c[1];//
                a[2].GetComponent<SpriteRenderer>().sprite = c[5];
            }
            else if (b == 2)
            {
                a[0].GetComponent<SpriteRenderer>().sprite = c[3];
                a[1].GetComponent<SpriteRenderer>().sprite = c[4];
                a[2].GetComponent<SpriteRenderer>().sprite = c[2];//
            }
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(b==0)
            {
                SceneManager.LoadScene(1);
            }
            else if (b == 1)
            {
                SceneManager.LoadScene(2);

            }
            else if (b == 2)
            {
                SceneManager.LoadScene(3);

            }
        }
        // if (Input.GetKeyDown(KeyCode.UpArrow))
        // {
        //     b--;
        //     if (b <= 3)
        //     {
        //         b = 0;
        //     }
        //     a[b].GetComponent<SpriteRenderer>().sprite = c[b];
        // }
        //else  if (Input.GetKeyDown(KeyCode.DownArrow))
        // {
        //     b++;
        //     if (b >=3)
        //     {
        //         b = 0;
        //     }
        //     a[b].GetComponent<SpriteRenderer>().sprite = c[b];
        // }
    }
}
