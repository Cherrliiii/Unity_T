using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressPeices : MonoBehaviour
{
    private Vector3 rightPos;
    public bool inRightPos;
    public bool selected;

    void Start()
    {
        rightPos = transform.position;
        transform.position = new Vector3(Random.Range(5f, 7f), Random.Range(-4f, 4f), -0.5f);
    }

    void Update()
    {
        if(Vector3.Distance(transform.position,rightPos) < 1f)
        {
            if(!selected)
            {
                transform.position = rightPos;
                inRightPos = true;
            }   
        }
    }
}
