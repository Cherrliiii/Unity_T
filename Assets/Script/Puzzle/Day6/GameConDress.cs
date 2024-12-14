using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCon_Day6 : MonoBehaviour
{
 

    [SerializeField]
    private GameObject winUI;

    public List<GameObject> allPieces;
    public bool winRot;
    void Start()
    {
        allPieces = new List<GameObject>(GameObject.FindGameObjectsWithTag("Dress"));
        winUI.SetActive(false);
    }

    private void Update()
    {
        foreach (GameObject pieces in allPieces)
        {
            if (pieces.GetComponent<DressPeices>().inRightPos == false)
            {
                winRot = false;
                break;
            }
            else { winRot = true; }
        }

 
        if (winRot == true)
        {
            winUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
