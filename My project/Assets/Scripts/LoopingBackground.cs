using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float speed;
    public Renderer renderer;

    // You can remove the Start() method

    // Update is called once per frame
    void Update()
    {
        // This will be used to move the repeating background on the X axis. Note: ignore the warning
        renderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}