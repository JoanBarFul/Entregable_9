using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Persistance_Data : MonoBehaviour
{
    public static Persistance_Data sharedInstance;
    public Vector3 playerPosition = new Vector3(13f, 0.35f, 13f);
    public Vector3 playerRotation;

    // Update is called once per frame
    void Update()
    {
        
    }
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
