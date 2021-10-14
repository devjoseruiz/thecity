using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSinceStart : MonoBehaviour {

    public float sinceStart;
    void Update()
    {
        sinceStart = Time.realtimeSinceStartup;
    }
}
