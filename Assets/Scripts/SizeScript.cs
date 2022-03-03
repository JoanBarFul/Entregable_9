using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SizeScript : MonoBehaviour
{
   

    // Rota el cubo
    public void Rotation(float sizeRotation)
    { gameObject.transform.rotation = Quaternion.Euler( 0, sizeRotation * 15, 0); }

    public void ChangeScene()
    {
        
        SceneManager.LoadScene("Entregable_9_1");
        
    }
}
