using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTime : MonoBehaviour {

    public float customTimeScale = 1;
    void Update()
    {
        Time.timeScale = customTimeScale;
    }
}
