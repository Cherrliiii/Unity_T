using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneToPlay : MonoBehaviour
{
    

    // Start is called before the first frame update
    private void OnEnable()
    {
        SceneManager.LoadScene("Room D2", LoadSceneMode.Single);
    }
}
