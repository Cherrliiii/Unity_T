using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Line : MonoBehaviour
{
    public LineRenderer line;
    List<Vector2> points;
    public void UpdateLine(Vector2 pos)
    {
        if (points == null)
        {
            points = new List<Vector2>();
            SetPoint(pos);
            return;
        }

        if (Vector2.Distance(points.Last(), pos) > 0.1f)
        {
            SetPoint(pos);
        }
    }

    private void SetPoint(Vector2 point)
    {
        points.Add(point);

        line.positionCount = points.Count;
        line.SetPosition(points.Count - 1, point);
    }
}
