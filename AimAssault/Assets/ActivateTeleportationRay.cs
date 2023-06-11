using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
        public GameObject leftTeleportation;
        public GameObject rightTeleportation;

        public InputActionProperty leftActivate;
        public InputActionProperty rigthActivate;

        public InputActionProperty leftCancel;
        public InputActionProperty rightCancel;

    // Start is called before the first frame update
        
    
    // Update is called once per frame
    void Update() 
    {
        leftTeleportation.SetActive(leftCancel.action.ReadValue<float>() == 0 &&  leftActivate.action.ReadValue<float>() > 0.1f);
        rightTeleportation.SetActive(rightCancel.action.ReadValue<float>() == 0 &&  rigthActivate.action.ReadValue<float>() > 0.1f);
    }
}
