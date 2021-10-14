using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateObject : MonoBehaviour {

    public float metersSeg = 1;
    void Update()
    {
        transform.Translate(0, 0, metersSeg * Time.deltaTime);
    }
}
