using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesMG : MonoBehaviour
{
    [SerializeField]
    public GameObject aPhone;

    public void loadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void loadMenu()
    {loadScene("Menu");}

    //ä»áµèÅÐ¤Ñ·«Õ¹
    public void loadCS()
    {loadScene("CutScene");}
    public void loadDay1ToDay2()
    { loadScene("Day1ToDay2"); }
    public void loadDay2ToDay3()
    {loadScene("Day2ToDay3");}
    public void loadDay4ToDay5()
    {loadScene("Day4ToDay5"); }
    public void loadDay5ToDay6()
    {loadScene("Day5ToDay6");}
    public void loadEndDay6()
    { loadScene("EndDay6"); }


    public void Quitgame()
    {Application.Quit();}

    public void phoneAppear()
    {
        aPhone.gameObject.SetActive(!aPhone.gameObject.activeSelf);
        if(aPhone.activeSelf)
        { Time.timeScale = 0f ; }
        else { Time.timeScale = 1f; }
    }
}
