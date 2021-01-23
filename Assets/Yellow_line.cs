using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yellow_line : MonoBehaviour
{
    public static int CurIndex;
    public int playerState = 0;
    public int fds;
    public GameObject CreateNum;
    public GameObject CreateBlock;
    public GameObject text;
    public int score;
    public List<int> NumList;
    public int Index;
    public int gfd;
    public static int CrushCount;
    public GameObject[] a;
    public GameObject[] b;
    public GameObject[] c;
    public GameObject[] d;
    public bool bbdb;
    public GameObject pos2;
    float bgdb;
    public GameObject ggfdg;
    public AudioSource sound;
    public AudioSource fail;
    public AudioSource final;

    void Awake()
    {
        CrushCount = 0;
        CurIndex = 5;
    }

    void Start()
    {
        //PlayerPrefs.SetInt("score", score);
        text.GetComponent<Text>().text = "점수 " + score;
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.Save();
        gfd = CreateNum.GetComponent<CreateNum>().r;
        NumList = CreateNum.GetComponent<CreateNum>().Ret_NumList();
        Index = CreateNum.GetComponent<CreateNum>().Ret_Index();
    }

    void Update()
    {
        if (bgdb >= 1.2f)
        {
            //CreateBlock.GetComponent<CreateBlock>().CrushBlock();
            bbdb = false;
            ggfdg.GetComponent<Animator>().SetInteger("t", 0);

            bgdb = 0;
        }
        if (bbdb == true)
        {
            bgdb += Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && playerState > 0)
        {
            //transform.position -= new Vector3(1.0f, 0.0f, 0.0f);
            playerState--;
            pos2.transform.position = d[playerState].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && playerState < CurIndex - 1)
        {
            //transform.position += new Vector3(1.0f, 0.0f, 0.0f);
            playerState++;
            pos2.transform.position = d[playerState].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (playerState == NumList[Index - 1])
            {
                Index--;
                CreateNum.GetComponent<CreateNum>().chan();
                fail.Play();

                if (Index == 0)//끝
                {
                    CrushCount++;
                    score++;
                    final.Play();
                    text.GetComponent<Text>().text = "점수 " + score;
                    PlayerPrefs.SetInt("score", score);
                    PlayerPrefs.Save();
                    bbdb = true;
                    CreateNum.GetComponent<CreateNum>().C_Nums();
                    CreateNum.GetComponent<CreateNum>().destroyNums();
                    CreateNum.GetComponent<CreateNum>().createNums();
                    NumList = CreateNum.GetComponent<CreateNum>().Ret_NumList();
                    Index = CreateNum.GetComponent<CreateNum>().Ret_Index();
                    CreateBlock.GetComponent<CreateBlock>().CrushBlock();
                }
            }
            else
            {
                sound.Play();
                CreateNum.GetComponent<CreateNum>().chan2();
                ggfdg.GetComponent<Animator>().SetInteger("t", 2);
                Index = 5;
                score -= 2;

                if (score <= 0)
                {
                    score = 0;
                }
                text.GetComponent<Text>().text = "점수 " + score;
                PlayerPrefs.SetInt("score", score);
                PlayerPrefs.Save();
                CrushCount++;
                CreateBlock.GetComponent<CreateBlock>().CrushBlock2();
            }
        }
    }
    public void PCurIndex()
    {
        CurIndex++;
    }

    public int ScoreRe()
    {
        return CrushCount;
    }
}
