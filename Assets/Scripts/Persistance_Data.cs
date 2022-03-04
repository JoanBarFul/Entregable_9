using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Persistance_Data : MonoBehaviour
{
    public static Persistance_Data sharedInstance;
    public Vector3 playerPosition = new Vector3(13f, 0.35f, 13f);
    public Vector3 playerRotation;
    public bool verdeMaterial;
    public bool azulMaterial;
    public bool rojoMaterial;
    public int intentosNum = 0;
    public int intentosContador;
    public int intentosTotalesNum = 0;
    

    void Start()
    {
        //Coge lo que está guardado fuera del juego
        intentosTotalesNum = PlayerPrefs.GetInt("Save");
        intentosContador = intentosTotalesNum;
    }

    
    //Hace que el archivo no se destruya entre escenas
    void Awake()
{
    if (sharedInstance == null)
    {
        sharedInstance = this;
        DontDestroyOnLoad(this);
    }

    else { Destroy(gameObject); }
}
}
   

   