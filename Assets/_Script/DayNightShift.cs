using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightShift : MonoBehaviour
{
    public Light sun;
    public float timePassSpeed = 1f;

    // Update is called once per frame
    void FixedUpdate()
    {
        sun.transform.Rotate(-timePassSpeed, 0f, 0f, Space.Self);
    }
}
