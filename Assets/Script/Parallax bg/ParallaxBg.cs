using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBg : MonoBehaviour
{
    public ParallaxCam parallaxCam;
    List<ParallaxLayers> parallaxLayers = new List<ParallaxLayers>();

    void Start()
    {
        if (parallaxCam == null)
            parallaxCam = Camera.main.GetComponent<ParallaxCam>();

        if (parallaxCam != null)
            parallaxCam.onCameraTranslate += Move;

        SetLayers();
    }

    void SetLayers()
    {
        parallaxLayers.Clear();

        for (int i = 0; i < transform.childCount; i++)
        {
            ParallaxLayers layer = transform.GetChild(i).GetComponent<ParallaxLayers>();

            if (layer != null)
            {
                layer.name = "Layer-" + i;
                parallaxLayers.Add(layer);
            }
        }
    }

    void Move(float delta)
    {
        foreach (ParallaxLayers layer in parallaxLayers)
        {
            layer.Move(delta);
        }
    }
}
