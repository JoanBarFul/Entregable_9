using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(-3, 0.75f, 0);

    void Update()
    { transform.position = player.transform.position + offset; }
}
