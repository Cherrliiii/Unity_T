using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlRotate : MonoBehaviour
{


    [SerializeField]
    private GameObject winUI;

    [SerializeField]
    private GameObject rahu;

    [SerializeField]
    private ParticleSystem exploedEFX;

    public List<GameObject> allPieces;
    public bool winRot;
    void Start()
    {
        allPieces = new List<GameObject>(GameObject.FindGameObjectsWithTag("RotatePuzz"));
        winUI.SetActive(false);
        rahu.SetActive(false);
    }

    private void Update()
    {
       foreach(GameObject pieces in allPieces)
        {
            if(pieces.GetComponent<RotatePuzz>().inRightAngle == false)
            {
                winRot = false;
                break;
            }
            else { winRot = true; }
        }

       if(winRot == true)
        {
            Time.timeScale = 0;
            winUI.SetActive(true);
            rahu.SetActive(true);
            exploedEFX.Play();
           

        }
    }

  
}
