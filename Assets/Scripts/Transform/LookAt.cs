using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

    public Transform objective;
    void Update()
    {
        transform.LookAt(objective);
    }
}
