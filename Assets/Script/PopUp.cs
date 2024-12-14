using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PopUp : MonoBehaviour
{
    public bool inRange;
    public GameObject work;
    public GameObject workingInteract;

    private void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            inRange = true;
            work.SetActive(true);
            workingInteract.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inRange = false;
            work.SetActive(false);
            workingInteract.SetActive(false);
        }
    }
}
