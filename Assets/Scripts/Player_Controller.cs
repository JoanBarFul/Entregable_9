using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player_Controller : MonoBehaviour
{
    private float rotateSpeed = 500f;
    private float forwardSpeed = 5f;
    private float turnSpeed = 100f;
    public bool avance = false;
    private float limZ = 24.5f;
    private float negLimZ = 0.5f;
    private float limX = 24.5f;
    private float negLimX = 0.5f;
    public Material verdeMat;
    public Material azulMat;
    public Material rojoMat;
    public GameObject bola;
    
    

    
    void Start()
    {
        //Al cargar la escena el "player" coge la posición de guardada en el "Persistance_Data"
        transform.position = Persistance_Data.sharedInstance.playerPosition;
    }

    void Update()
    {
        //Movimiento del "player"
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.right * Time.deltaTime * forwardSpeed);
            avance = true;
        }
        else { avance = false; }

        //Rotación del "player"
        if (Input.GetKey(KeyCode.A))
        { transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed); }
        
        if (Input.GetKey(KeyCode.D))
        { transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed); }

        //Límites del "player"
        if( transform.position.z >= limZ)
        { transform.position = new Vector3(transform.position.x, transform.position.y, limZ); }

        if (transform.position.z <= negLimZ)
        { transform.position = new Vector3(transform.position.x, transform.position.y, negLimZ); }

        if (transform.position.x <= negLimX)
        { transform.position = new Vector3(negLimX, transform.position.y, transform.position.z); }

        if (transform.position.x >= limX)
        { transform.position = new Vector3(limX, transform.position.y, transform.position.z); }

        //Asigna el material que se ha elegido en la preimera escena
        if (Persistance_Data.sharedInstance.verdeMaterial == true)
        { bola.GetComponent<Renderer>().material = verdeMat; }

        if (Persistance_Data.sharedInstance.azulMaterial == true)
        { bola.GetComponent<Renderer>().material = azulMat; }

        if (Persistance_Data.sharedInstance.rojoMaterial == true)
        { bola.GetComponent<Renderer>().material = rojoMat; }

        
        //Cambio de escena
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Guarda posición del "player"
            Persistance_Data.sharedInstance.playerPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            SceneManager.LoadScene("Entregable_9_1");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Persistance_Data.sharedInstance.playerPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            //Suma al contador de intentos
            Persistance_Data.sharedInstance.intentosTotalesNum ++;
            Persistance_Data.sharedInstance.intentosNum ++;

            //Guarda fuera del juego los cambios de escena totales
            PlayerPrefs.SetInt("Save", Persistance_Data.sharedInstance.intentosTotalesNum);

            SceneManager.LoadScene("Entregable_9_2");
        }
    }
}
