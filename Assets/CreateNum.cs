using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNum : MonoBehaviour
{
    public GameObject[] Nums;
    public GameObject[] Color_Nums;
    public List<int> NumList = new List<int>();
    public List<int> Color_NumList = new List<int>();
    public int Index = 1;
    Vector3 pos;
    public GameObject[] go;
    public GameObject[] Color_go;
    public int blockCount = 0;
    public Sprite[] a;
    public int r;
    public GameObject[] posobj;
    public int gfdag=4;
    //public Sprite a;
    //public chang b;
    // Use this for initialization
    void Start()
    {
        createNums();
        gfdag = 4;
}   

// Update is called once per frame
void Update()
    {

    }
    public void createNums()//안주 생성.
    {

        pos = new Vector3(-6.5f, 1.5f, 0);
        go = new GameObject[Index];
        Color_go = new GameObject[Index];
        blockCount = 0;
        for (int i = 0; i < Index; i++)
        {
            r = Random.Range(0, Index);
            go[blockCount] = GameObject.Instantiate(this.Nums[r]) as GameObject;
            go[blockCount].transform.parent = this.gameObject.transform;
            //Color_go[blockCount] = GameObject.Instantiate(this.Color_Nums[r]) as GameObject;
            NumList.Add(r);
            Color_NumList.Add(r);
            pos -= new Vector3(1.0f, 0, 0);
            go[blockCount].transform.position += pos;
            blockCount++;
  
        }
    }
    public void chan()
    {
        //Destroy(go[gfdag]);
        Debug.Log(gfdag);
        go[gfdag].GetComponent<SpriteRenderer>().sprite= go[gfdag].GetComponent<chang>().sadhk2;
        if (gfdag <= 0)
        {
            gfdag = 5;
        }
        gfdag--;
        //if (Nums[r] == Color_Nums[r])
        //{
        //    //Debug.Log("hello");
        //if()
        //Color_go[r].transform.position = new Vector3();
        //}
    }
    public void chan2()
    {
        gfdag=4 ;
        go[4].GetComponent<SpriteRenderer>().sprite = go[4].GetComponent<chang>().sadhk;
        go[3].GetComponent<SpriteRenderer>().sprite = go[3].GetComponent<chang>().sadhk;
        go[2].GetComponent<SpriteRenderer>().sprite = go[2].GetComponent<chang>().sadhk;
        go[1].GetComponent<SpriteRenderer>().sprite = go[1].GetComponent<chang>().sadhk;
        go[0].GetComponent<SpriteRenderer>().sprite = go[0].GetComponent<chang>().sadhk;
    }
    public void C_Nums()
    {
        if (Nums[0] == Color_Nums[0])
        {

        }
    }
    public void destroyNums()
    {

        for (int i = 0; i < Index; i++)
        {
            Destroy((Object)go[i]);
            NumList.RemoveAt(0);
            Color_NumList.RemoveAt(0);
        }
    }
    public List<int> Ret_NumList()
    {
        return NumList;
    }
    public int Ret_Index()
    {
        return Index;
    }

    public void PIndex()
    {
        Index++;
    }
}
