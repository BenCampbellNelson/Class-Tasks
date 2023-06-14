using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PlayerController implements the MonoBehaviour interface.
// The MonoBehaviour interface's members which PlayerController must implement are Start() and Update()
public class PlayerController : MonoBehaviour
{
    // Public field which you can set its value in the Player GameObject's inspector window
    public float speed;

    private Rigidbody2D rb;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        // Getting the component of type Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the value of the virtual axis identified by "Horizontal" or "Vertical"
        // Resource: https://docs.unity3d.com/ScriptReference/Input.GetAxisRaw
        float directionY = Input.GetAxisRaw("Vertical");
        direction = new Vector2(0, directionY).normalized;
    }

    void FixedUpdate()
    {
        // The Rigidbody's velocity is specified as a vector with components in 
        // the X and Y directions. This allows the Player GameObject to move
        // in the Y direction direction at a given speed

        rb.velocity = new Vector2(0, direction.y * speed);
    }
}
