using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadWeek : MonoBehaviour
{
    [SerializeField]
    int week;
    // Start is called before the first frame update
    void Start()
    {
        week = PlayerPrefs.GetInt("Week");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
