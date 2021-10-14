using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Move : MonoBehaviour {

    public Vector3 moveForward = Vector3.forward;
    public Vector3 moveBack = Vector3.back;
    public Vector3 moveLeft = Vector3.left;
    public Vector3 moveRight = Vector3.right;
    public Vector3 moveUp = Vector3.up;
    public Vector3 moveDown = Vector3.down;

    void Update()
    {
        transform.position += moveDown;
    }
}
