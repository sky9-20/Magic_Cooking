using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSlider : MonoBehaviour
{
    public float Slide = 15;

    // Update is called once per frame
    void OnMouseDown()
    {

        Vector3 pos = Camera.main.gameObject.transform.position;
        pos.x += Slide;
        Camera.main.gameObject.transform.position = pos;
    }
}
