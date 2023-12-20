using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.NiceVibrations;

public class HapticFeedback_DY : MonoBehaviour
{


    public void Vibrate()
    {
        MMVibrationManager.Haptic(HapticTypes.LightImpact, true, this);
    }

}