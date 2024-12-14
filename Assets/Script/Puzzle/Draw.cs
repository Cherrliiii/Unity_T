using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    [SerializeField] LineRenderer trailPrefab = null;

    private LineRenderer currentTrail;
    private List<Vector3> points = new List<Vector3>();

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {  CreateNewLine();}

        if (Input.GetMouseButton(0))
        {  AddPoint();}

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (transform.childCount != 0)
            {
                foreach (Transform R in transform)
                {
                    Destroy(R.gameObject);
                }
            }
        }
         
    }

    private void CreateNewLine()
    {
        currentTrail = Instantiate(trailPrefab);
        currentTrail.transform.SetParent(transform, true);
        points.Clear();
    }

    private void UpdateLinePoints()
    {
        if (currentTrail != null && points.Count > 1)
        {
            currentTrail.positionCount = points.Count;
            currentTrail.SetPositions(points.ToArray());
        }
    }

    private void AddPoint()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
        if (hit.collider.CompareTag("Paper"))
        {
            points.Add(hit.point);
            UpdateLinePoints();
            return;
        }
        else
            return;
    }

       
}
