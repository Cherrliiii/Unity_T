using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week : MonoBehaviour
{   //���week�˹
    [SerializeField]
    int week;
    [SerializeField]
    int WhatWeek;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Week", WhatWeek);
        week = PlayerPrefs.GetInt("Week");
    }


}
