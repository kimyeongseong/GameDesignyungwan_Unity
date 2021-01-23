using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlock : MonoBehaviour
{
    public GameObject[] Blocks;
    public int num = 0;
    Vector3 pos;
    public GameObject[] go = new GameObject[7];
    public int blockCount;
    public int Index = 0;
    public float bgdb;
    public float bgdb2;
    public bool a;
    public bool b;

    public GameObject ggfdg;
    // Use this for initialization
    void Start()
    {
        pos = new Vector3(-2f, 4.5f, 0);
        blockCount = 7;
        createBlocks();
    }

    // Update is called once per frame
    void Update()
    {
        if (a == true)
        {
            bgdb += Time.deltaTime;
            if (bgdb >= 1.3f)
            {
                CrushBlock();
                a = false;
            }
        }
        else if (b == true)
        {
            bgdb2 += Time.deltaTime;
            if (bgdb2 >= 1.3f)
            {
                CrushBlock2();
                b = false;
            }
        }
        /*if (Input.GetKeyDown (KeyCode.Space)) {
			Destroy ((Object)go [Index]);
			Index++;
			if (Index == 7) { 
				Index = 0;
				num = 0;
				createBlocks ();

			}
		}*/
    }

    public void createBlocks()
    {
        for (int i = Index; i < 7; i++)
        {
            int r = Random.Range(0, 4);
            go[i] = GameObject.Instantiate(this.Blocks[r]) as GameObject;
            go[i].transform.parent = this.gameObject.transform;
            pos -= new Vector3(0, 1.1f, 0);
            go[i].transform.position += pos;
            num++;
        }
    }

   
    public void CrushBlock()//완전 삭제 후 생성.
    {
        a = true;

        go[Index].GetComponent<Animator>().SetInteger("crush", 2);
        ggfdg.GetComponent<Animator>().SetInteger("t", 1);

        if (bgdb >= 1.2f)
        {
            ggfdg.GetComponent<Animator>().SetInteger("t", 0);

            Destroy((Object)go[Index]);
            Index++;
            blockCount--;
            a = false;
            bgdb = 0;
            pos += new Vector3(0, 1f, 0);
            if (blockCount == 3)
            {
                go[0] = go[4];
                go[1] = go[5];
                go[2] = go[6];
                go[0].transform.position += new Vector3(0, 4.0f, 0);
                go[1].transform.position += new Vector3(0, 4.0f, 0);
                go[2].transform.position += new Vector3(0, 4.0f, 0);
                Index--;
                createBlocks();
                Index = 0;
                blockCount = 7;
            }
        }
    }
    public void CrushBlock2()//완전 삭제 후 생성.실패
    {
        b = true;

        go[Index].GetComponent<Animator>().SetInteger("crush", 1);
        ggfdg.GetComponent<Animator>().SetInteger("t", 2);

        if (bgdb2 >= 1.2f)
        {
            ggfdg.GetComponent<Animator>().SetInteger("t", 0);

            Destroy((Object)go[Index]);
            Index++;
            blockCount--;
            b = false;
            bgdb2 = 0;
            pos += new Vector3(0, 1f, 0);
            if (blockCount == 3)
            {
                go[0] = go[4];
                go[1] = go[5];
                go[2] = go[6];
                go[0].transform.position += new Vector3(0, 4.0f, 0);
                go[1].transform.position += new Vector3(0, 4.0f, 0);
                go[2].transform.position += new Vector3(0, 4.0f, 0);
                Index--;
                createBlocks();
                Index = 0;
                blockCount = 7;
            }
        }
    }
}
