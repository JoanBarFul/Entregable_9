using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Controller : MonoBehaviour
{
    private float rotateSpeed = 500;
    private float forwardSpeed = 5;
    private float turnSpeed = 100;
    public bool avance = false;
  
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Persistance_Data.sharedInstance.playerPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.right * Time.deltaTime * forwardSpeed);
            avance = true;
        }
        else { avance = false; }

        if (Input.GetKey(KeyCode.A))
        { transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed); }
        
        if (Input.GetKey(KeyCode.D))
        { transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed); }


        if (Input.GetKeyDown(KeyCode.P))
        {
            //Persistance_Data.sharedInstance.playerRotation = transform.position;
            
            Persistance_Data.sharedInstance.playerPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            SceneManager.LoadScene("Entregable_9_2");
        }
    }
}
