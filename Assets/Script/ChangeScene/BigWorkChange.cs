using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BigWorkChange : MonoBehaviour
{
    [SerializeField]
    int week;

    void Start()
    {
        week = PlayerPrefs.GetInt("Week");
        Time.timeScale = 1;
    }

    private void OnMouseDown()
    {
        
        if (week == 1)
        {SceneManager.LoadScene("Scenes/Day1Draw");}
        else if (week == 2)
        {SceneManager.LoadScene("Scenes/Day2_Again_and_Again");}
        else if(week == 4)
        {SceneManager.LoadScene("Scenes/Day4TracingLine");}
        else if(week == 5)
        {SceneManager.LoadScene("Scenes/Day5_Placement");}
        else if(week == 6)
        {SceneManager.LoadScene("Scenes/Day6DressUp");}
       
    }

}
