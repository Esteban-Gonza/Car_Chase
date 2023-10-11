using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    [SerializeField] float speed = 5;
    [SerializeField] float turnSpeed;

    float horizontalInput;
    float forwardlInput;

    private void FixedUpdate(){
        horizontalInput = Input.GetAxis("Horizontal");
        forwardlInput = Input.GetAxis("Vertical");

        //Move vehicle
        transform.Translate(Vector3.forward * speed * forwardlInput * Time.deltaTime);
        //Rotate vehicle
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}