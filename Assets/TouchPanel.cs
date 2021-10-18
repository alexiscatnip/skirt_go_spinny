using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPanel : MonoBehaviour
{
    public SpinnyManager sm;

    public bool singleTouchIsOrbitMode = true;
    public GameObject objectSpinny;
    private float bOppRot = -1;

    private void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        if (! Input.GetMouseButton(0))
        {
            return;
        }


        if (singleTouchIsOrbitMode)
        {
            var mouseHorzDelta = getTouchLocHorz();
            sm.updateInputDelta(mouseHorzDelta  * bOppRot);


        } else
        {
            return;
        }
        
    }

    private float getTouchLocHorz()
    {
        return Input.GetAxis("Mouse X");

    }
}
