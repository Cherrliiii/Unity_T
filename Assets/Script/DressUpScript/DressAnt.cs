using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressAnt : MonoBehaviour
{

    private bool dragging = false;
    private Vector3 offset;


    void Start()
    {
        transform.position = new Vector3(Random.Range(2f, 7f), Random.Range(-4f, 4f), -0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }

    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }

    private void OnMouseUp()
    {
        dragging = false;
    }
}
