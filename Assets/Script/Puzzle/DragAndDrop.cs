using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public GameObject selectPeice;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
            if (hit.transform.CompareTag("Dress"))
            {
                if (!hit.transform.GetComponent<DressPeices>().inRightPos)
                {
                    selectPeice = hit.transform.gameObject;
                    selectPeice.GetComponent<DressPeices>().selected = true;
                }
                
            }  
        }

        if(Input.GetMouseButtonUp(0))
        {
            selectPeice.GetComponent<DressPeices>().selected = false;
            selectPeice = null;
            
        }
        
        if (selectPeice != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectPeice.transform.position = new Vector3(MousePoint.x, MousePoint.y , -0.5f);
        }
    }
}
