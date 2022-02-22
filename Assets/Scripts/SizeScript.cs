using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeScript : MonoBehaviour
{
    // Rota el cubo
    public void Rotation(float sizeRotation)
    { gameObject.transform.rotation = Quaternion.Euler( 0, sizeRotation * 15, 0); }
}
