using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TIMER : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeText;

    [SerializeField] TextMeshProUGUI levelText;

    float elapsedTime;

    [SerializeField]
    int poin;
    [SerializeField]
    int PoinTo;

    [SerializeField]
    int week;

    //[SerializeField]
    //int PoinTo2;
    //[SerializeField]
    //int PoinTo4;
    //[SerializeField]
    //int PoinTo5;
    //[SerializeField]
    //int PoinTo6;



    void Start()
    {
        week = PlayerPrefs.GetInt("Week");
    
    }

        // Update is called once per frame
        void Update()
    {
        elapsedTime += Time.deltaTime;
        int min = Mathf.FloorToInt(elapsedTime / 60);
        int sec = Mathf.FloorToInt(elapsedTime % 60);
        timeText.text = string.Format("{0:00}:{1:00}", min, sec);
        level();

        //PoinTo2 = PlayerPrefs.GetInt("Poin2");
        //PoinTo4 = PlayerPrefs.GetInt("Poin4");
        //PoinTo5 = PlayerPrefs.GetInt("Poin5");
        //PoinTo6 = PlayerPrefs.GetInt("Poin6");
    }

    void level()
    {
        if (elapsedTime <= 10f)
        {
            levelText.text = "A";
            //poinGo(4);
        }
        else if (elapsedTime >= 10f && elapsedTime < 15f)
        {
            levelText.text = "B";
            //poinGo(3);
        }
        else if (elapsedTime >= 15f && elapsedTime < 20f)
        {
            levelText.text = "C";
            //poinGo(2);
        }
        else if (elapsedTime >= 20f && elapsedTime < 30f)
        {
            //levelText.text = "D";
            //poinGo(1);
        }
        else if (elapsedTime >= 30f)
        {
            levelText.text = "F";
            //poinGo(0);
        }


    }

    //void poinGo(int WhatGrad)
    //{

    //    if (week == 2)
    //    { PlayerPrefs.SetInt("Poin2", WhatGrad); }
    //    if (week == 4)
    //    { PlayerPrefs.SetInt("Poin4", WhatGrad); }
    //    if (week == 5)
    //    { PlayerPrefs.SetInt("Poin5", WhatGrad); }
    //    if (week == 6)
    //    { PlayerPrefs.SetInt("Poin6", WhatGrad); }
    //}


}
