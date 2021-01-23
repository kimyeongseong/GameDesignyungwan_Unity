using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class an : MonoBehaviour
{
    public GameObject[] a;
         int b;
    public GameObject[] c;
    int r;
    public int Index = 3;
    public GameObject pos;
    public Vector3 pos2;
    public GameObject[] go;
    public int blockCount;
    public GameObject ran;
     int[]  fdfds;
    public Sprite[] sprit;
    public Sprite[] xsprit;
    public int fdgggg;
    [HideInInspector]
    // Use this for initialization
    void Start()
    {
        createNums();
        fdgggg = 0;
    }
    public void createNums()//안주 생성.
    {
        for (int i = 0; i < Index; i++)
        {
            fdfds = new int[Index];
            pos2 += new Vector3(1.05f, 0, 0);
            go = new GameObject[Index];
            r = Random.Range(0, Index);
            fdfds[i] = r;
            Debug.Log(fdfds[i]);
            go[i] = Instantiate(c[r], new Vector3(-8.0f, -0.6f, 0), Quaternion.identity, transform.parent);
            go[i].transform.position += pos2;
            blockCount++;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            b--;
            if (b <= 0)
            {
                b = 0;
            }
            Debug.Log(fdfds[0]);
            Debug.Log(fdfds[1]);
            Debug.Log(fdfds[2]);
            Debug.Log(fdfds[3]);
            Debug.Log(fdfds[4]);
            pos.transform.position = a[b].transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            b++;
            if (b >= 5)
            {
                b = 4;
            }
            Debug.Log(fdfds[0]);
            Debug.Log(fdfds[1]);
            Debug.Log(fdfds[2]);
            Debug.Log(fdfds[3]);
            Debug.Log(fdfds[4]);
            pos.transform.position = a[b].transform.position;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            
                if (fdfds[fdgggg] == b)
                {
                    Debug.Log(fdfds[fdgggg]);
                    Debug.Log(b);
                     //fdgggg++;
                    return;
                }
                //fdgggg
        }
    }
}
