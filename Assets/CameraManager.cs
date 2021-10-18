using System;
using System.Collections;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera main;
    private float targetFOV;

    public CameraManager(Camera main)
    {
        this.main = main;
        targetFOV = main.fieldOfView;
    }

    private void Update()
    {
        main.fieldOfView = (float)(main.fieldOfView*0.95  + targetFOV*0.05);

    }

    //update the fov of camera based on speed
    internal void zoomCamera(float fov)
    {
        targetFOV = fov;

    }


}