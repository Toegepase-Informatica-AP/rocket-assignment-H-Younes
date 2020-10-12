using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{

    public Rigidbody rocket;
    public float upForce = 35f;
    public float sideForce = 10f;
    public float rotation = 150f;

    void Update()
    {
        if (Input.GetKey("space"))
        {
            rocket.AddForce(0, upForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rocket.AddForce(movement * sideForce);

        if (Input.GetKey("left"))
        {
            transform.Rotate(0, 0, rotation * Time.deltaTime);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 0, (-rotation) * Time.deltaTime);
        }
    }
}
