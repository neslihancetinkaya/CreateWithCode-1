using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    [SerializeField] private bool IsFirstPlayer;
    
    void Update()
    {
        // Take Input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if (IsFirstPlayer)
        {
            // Movement
            if (Input.GetKey(KeyCode.UpArrow))
                transform.Translate(Vector3.forward * (Time.deltaTime * speed * 1));
            
            else if (Input.GetKey(KeyCode.DownArrow))
                transform.Translate(Vector3.forward * (Time.deltaTime * speed * -1));

            // Rotation
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * -1);
            
            else if (Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * 1);
            
        }
        else
        {
            // Movement
            if (Input.GetKey(KeyCode.W))
                transform.Translate(Vector3.forward * (Time.deltaTime * speed * 1));
            
            else if (Input.GetKey(KeyCode.S))
                transform.Translate(Vector3.forward * (Time.deltaTime * speed * -1));

            // Rotation
            if (Input.GetKey(KeyCode.A))
                transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * -1);
            
            else if (Input.GetKey(KeyCode.D))
                transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * 1);
        }
    }
}
