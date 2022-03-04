using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Player_Controller playerControllerScript;

    void Update()
    {
        //Cuando "player" avanza también rueda
        if (playerControllerScript.avance == true)
        { transform.Rotate(Vector3.back * Time.deltaTime * 500); }
    }
}
