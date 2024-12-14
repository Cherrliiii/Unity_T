using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject selectRotate;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
            if (hit.transform.CompareTag("RotatePuzz"))
            {
                if (!hit.transform.GetComponent<RotatePuzz>().inRightAngle)
                {
                    selectRotate = hit.transform.gameObject;
                }
            }
        }

        if (selectRotate != null)
        {
            selectRotate.transform.Rotate(0f, 0f, 90f);
            selectRotate = null;
        }
    }
}
