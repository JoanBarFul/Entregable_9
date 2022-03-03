using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Game_Manager : MonoBehaviour
{
    public Button verdeBTN;
    public Button azulBTN;
    public Button rojoBTN;
    

   void Start()
    {
        
        verdeBTN.onClick.AddListener(TaskOnClick);
        azulBTN.onClick.AddListener(TaskOnClick2);
        rojoBTN.onClick.AddListener(TaskOnClick3);
    }

    void TaskOnClick()
    {
        Deselect();
        Persistance_Data.sharedInstance.verdeMaterial = true;
    }

    void TaskOnClick2()
    {
        Deselect();
        Persistance_Data.sharedInstance.azulMaterial = true;
    }

    void TaskOnClick3()
    {
        Deselect();
        Persistance_Data.sharedInstance.rojoMaterial = true;
    }

    void Deselect()
    {
        Persistance_Data.sharedInstance.verdeMaterial = false;
        Persistance_Data.sharedInstance.azulMaterial = false;
        Persistance_Data.sharedInstance.rojoMaterial = false;
    }
}
