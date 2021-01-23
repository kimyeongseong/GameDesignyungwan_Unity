using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public  float time;

    // Use this for initialization
    void Start()
    {
        Ranksave();
        time = 80;
    }

    void Ranksave()
    {
        //score1최고점
        //score score1
        if (PlayerPrefs.GetInt("score") < PlayerPrefs.GetInt("score1")) //최고점수가 더 클때
        {
        }
        else if (PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("score1")) //현재 점수가 더 클때
        {
            PlayerPrefs.SetInt("score1", PlayerPrefs.GetInt("score"));
        }
        else if (PlayerPrefs.GetInt("score") == PlayerPrefs.GetInt("score1")) //현재 점수가 더 클때
        {
            PlayerPrefs.SetInt("score1", PlayerPrefs.GetInt("score"));
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (time != 0)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                time = 0;
                Ranksave();
                SceneManager.LoadScene("RankCheck");
            }
        }
        int t = Mathf.FloorToInt(time);
        Text uiText = GetComponent<Text>();
        uiText.text = "Time : " + t.ToString()+"";
    }

}
