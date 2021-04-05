using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationManager : MonoBehaviour
{


    public static VibrationManager singleton;

    
    
    
    // VVV this piece of code on the bottom is used to call the controller vibration
    // VibrationManager.singleton.TriggerVibration(40, 2 , 255, OVRInput.Controller.Rtouch)

    
    // Start is called before the first frame update
    void Start()
    {
        if(singleton && singleton != this)
        {
            Destroy(this);
        }
        else
        {
            singleton = this; 
        }    
    }



    void Update() 
    {
        OVRInput.Update();
    }


    void FixedUpdate() 
    {
        OVRInput.FixedUpdate();
    }

    public void TriggerVibration(int iteration, int frequency, int strength , OVRInput.Controller controller)
    {
        OVRHapticsClip clip = new OVRHapticsClip();

        for (int i = 0; i < iteration; i++)
        {
            clip.WriteSample(i % frequency == 0 ? (byte) strength : (byte) 0);
        }

        // if(controller == OVRInput.Controller.Ltouch)
        // {
        //     OVRHaptics.LeftChannel.Preempt(clip);
        // }
        // else if (controller == OVRInput.Controller.Rtouch)
        // {
        //     OVRHaptics.RightChannel.Preempt(clip);
        // }

        if (controller == OVRInput.Controller.RTouch)
        {
            OVRHaptics.RightChannel.Preempt(clip);
            OVRHaptics.LeftChannel.Preempt(clip);
        }
        else if (controller == OVRInput.Controller.LTouch)
        {
            OVRHaptics.LeftChannel.Preempt(clip);
            OVRHaptics.RightChannel.Preempt(clip);
        }
    }
}
