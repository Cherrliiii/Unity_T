using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Tracing : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public GameObject path;
    public GameObject hand;
    public GameObject draw;

    public bool onTrigger = false;
    public bool finish = false;

    void Start()
    {
        path.SetActive(true);
        hand.SetActive(true);
        draw.SetActive(false);
    }


    void Update()
    {
        if (finish == true)
        {
            hand.SetActive(false);
            path.SetActive(false);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Fill")
        {
            onTrigger = true;
        }

        if (other.name == end.name)
        {
            finish = true;
            draw.SetActive(true);
            hand.SetActive(false);
            path.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Fill")
        {
            onTrigger = false;
        }

    }
}
