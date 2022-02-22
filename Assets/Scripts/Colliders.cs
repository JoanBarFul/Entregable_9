using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliders : MonoBehaviour
{
    public GameObject exColors;
    public GameObject exSize;

    void Start()
    { Deselect(); }     // Al empezar se ocultan los textos

    void OnMouseOver()
    {
        // Al pasar el raton por encima de un boton (colision) se activa el texto correspondiente
        if (gameObject.tag == "ButtonCollider")
        {
            exSize.SetActive(false);
            exColors.SetActive(true); 
        }

        // Al pasar el raton por encima del "slider" (colision) se activa el texto correspondiente
        else if (gameObject.tag == "SliderCollider")
        {
            exColors.SetActive(false);
            exSize.SetActive(true); 
        }

        // Al pasar el raton por encima de otro "collider" se desactivan los textos
        else { Deselect(); }
    }

    // Desactiva los textos
    public void Deselect()
    {
        exColors.SetActive(false);
        exSize.SetActive(false);
    }
}
