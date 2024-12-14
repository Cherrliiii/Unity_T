using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order : MonoBehaviour
{
    [SerializeField]
    private GameObject winUI;

    public GameObject starPanel;
    public List<Tracing> tracing = new List<Tracing>();
    public int pathCount = 0;
    public bool success = false;

    void Start()
    {
        ShowSlider(pathCount);
        winUI.SetActive(false);
    }

    void Update()
    {
        if (success) return;

        if (pathCount < tracing.Count && tracing[pathCount].finish)
        {
            pathCount++;
            ShowSlider(pathCount);
        }
        else if (pathCount == tracing.Count)
        {
            pathCount = 0;
            success = true;
            starPanel.SetActive(true);

            Time.timeScale = 0;
            winUI.SetActive(true);
         
        }
    }

    void ShowSlider(int index)
    {
        for (int i = 0; i < tracing.Count; i++)
        {
            if (i == index) tracing[i].gameObject.SetActive(true);
            else tracing[i].gameObject.SetActive(false);
            Debug.Log(i);
        }
    }
}