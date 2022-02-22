using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private float rotateSpeed = 500;
    private float turnSpeed = 5;
    private float verticalInput;
    private float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back * Time.deltaTime * rotateSpeed);

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.back * Time.deltaTime * turnSpeed * verticalInput);
    }
}
