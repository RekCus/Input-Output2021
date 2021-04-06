using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    private void OnTriggerEnter(Collider collision)
    {   
        OVRInput.Update();
        VibrationManager.singleton.TriggerVibration(40, 2 , 255, OVRInput.Controller.RTouch);
        Debug.Log("SCORE!!");
        Scoreui.scoreValue += 10;
    }

}
