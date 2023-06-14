using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed;

    // You can remove the Start() method

    // Update is called once per frame
    void Update()
    {
        // This will be used to move the camera on the X axis
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
}
