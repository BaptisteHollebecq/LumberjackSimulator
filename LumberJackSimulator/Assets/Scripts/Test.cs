using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.XR;


public class Test : MonoBehaviour
{
    bool leftGrip = false;
    bool rightGrip = false;

    bool leftTrigger = false;
    bool rightTrigger = false;

    private void OnLeftGrip(InputValue value)
    {
        if (value.Get<float>() > .9f && !leftGrip)
        {
            leftGrip = true;
            Debug.Log("leftGrip True");
        }
        if (value.Get<float>() < .1f && leftGrip)
        {
            leftGrip = false;
            Debug.Log("leftGrip False");
        }
    }
}
