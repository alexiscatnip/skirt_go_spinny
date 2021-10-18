using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnyManager : MonoBehaviour
{
    public float speedfactor = 2;
    public float speedClamp = 1;
    public float bOppRot =-1;

    float momentumInputSpeed;
    // 1 to 0. dont put above 1....
    public float decreaseFactor = 0.2f;
    public GameObject objectSpinny;

    private float currentInputDelta;

    public SpinnyManager(GameObject objectSpinny)
    {
        this.objectSpinny = objectSpinny;
    }

    // Start is called before the first frame update
    void Start()
    {
        init();
    }

    private void init()
    {
        momentumInputSpeed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentInputDelta = currentInputDelta * (1 - Math.Min(1, decreaseFactor));
        rotateSpinnyItem(currentInputDelta);
        //var presentRotationSpeed = 0;
        //if (Mathf.Abs(momentumInputSpeed) > Mathf.Abs(currentInputDelta))
        //{
        //    rotateSpinnyItem(momentumInputSpeed);

        //}else
        //{
        //    rotateSpinnyItem(currentInputDelta);
        //    momentumInputSpeed = currentInputDelta;
        //}

    }
    
    private void rotateSpinnyItem(float rotation1Direction)
    {

        objectSpinny.transform.Rotate(0, rotation1Direction, 0);
    }

    public void updateInputDelta(float touchPointHorz)
    {
        currentInputDelta = touchPointHorz;
        //momentum = touchPointHorz * Math.Max(speedClamp, speedfactor) * bOppRot * momentum;
        //rotateSpinnyItem(momentum);
    }

}
