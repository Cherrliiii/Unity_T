using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Drag : MonoBehaviour
{
    public GameObject selectPeice;
    public GameObject linePrefab;

    Line activeLine;

    private List<Vector2> points;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
            if (hit.transform.CompareTag("Hand"))
            {
                selectPeice = hit.transform.gameObject;
                GameObject newLine = Instantiate(linePrefab);
                activeLine = newLine.GetComponent<Line>();
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            selectPeice = null;
            activeLine = null;
        }

        if (activeLine != null)
        {
            Vector2 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            activeLine.UpdateLine(MousePoint);
        }

        if (selectPeice != null)
        {
            Vector2 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectPeice.transform.position = new Vector2(MousePoint.x, MousePoint.y);
        }
    }
}
