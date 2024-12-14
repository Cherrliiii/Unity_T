using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{
    [SerializeField]
    int PoinTo2;
    [SerializeField]
    int PoinTo4;
    [SerializeField]
    int PoinTo5;
    [SerializeField]
    int PoinTo6;
    [SerializeField]
    int Sum;
    [SerializeField]
    int Week;

    [SerializeField] TextMeshProUGUI GradText;

    void Start()
    {
        PoinTo2 = PlayerPrefs.GetInt("Poin2");
        PoinTo4 = PlayerPrefs.GetInt("Poin4");
        PoinTo5 = PlayerPrefs.GetInt("Poin5");
        PoinTo6 = PlayerPrefs.GetInt("Poin6");
    }

    void DoIt()
    {
       if(Week==2)
        { WhatGrad(PoinTo2); }
        if (Week == 4)
        { WhatGrad(PoinTo4); }
        if (Week == 5)
        { WhatGrad(PoinTo5); }
        if (Week == 6)
        { WhatGrad(PoinTo6); }
        if (Week == 10)
        { HowCal(); }
    }

    void HowCal()
    {
        Sum = Mathf.RoundToInt((PoinTo2 + PoinTo4 + PoinTo5 + PoinTo6)/4);
        WhatGrad(Sum);
    }

    void WhatGrad (int Pointooo)
    {
        if (Pointooo >= 4)
        { GradText.text = "A"; }
        if (Pointooo == 3)
        { GradText.text = "B"; }
        if (Pointooo == 2)
        { GradText.text = "C"; }
        if (Pointooo == 1)
        { GradText.text = "D"; }
        else
        { GradText.text = "F"; }
    }

    void AllGrad()
    {
        GradText.text = "week 2 : ";
        WhatGrad(PoinTo2);
        GradText.text = "week 3 : ";
        WhatGrad(PoinTo4);
        GradText.text = "week 4 : ";
        WhatGrad(PoinTo5);
        GradText.text = "week 5 : ";
        WhatGrad(PoinTo6);
    }



}
