using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tImeGo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1; // ����������������ա����
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
