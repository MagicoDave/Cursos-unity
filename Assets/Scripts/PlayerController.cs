using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerController : MonoBehaviour
{

    private float speed = 15.0f;
    private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the car in forward based on forwardInput
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Turns the car based on horizontalInput
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput *  Time.deltaTime);
    }
}
