using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePuzz : MonoBehaviour
{
    public bool inRightAngle;
    int[] integers = new int[] { 0, 90, 180, 270 };
    void Start()
    {
        transform.rotation = new Quaternion(0f, 0f, integers[Random.Range(0, integers.Length)], 0f);
    }

    void Update()
    {
        if (transform.rotation.z == 0f)
        {
            inRightAngle = true;  
        }
    }
}
