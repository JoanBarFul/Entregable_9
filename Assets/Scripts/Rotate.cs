using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Player_Controller playerControllerScript;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.avance == true)
        {
            transform.Rotate(Vector3.back * Time.deltaTime * 500);
        }
    }
}
