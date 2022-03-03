using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    public TextMeshProUGUI cambiosText;
    public TextMeshProUGUI cambiosTotalesText;

    void Start()
    {
        cambiosText.text = $"Cambios = {Persistance_Data.sharedInstance.intentosNum}";
        cambiosTotalesText.text = $"Cambios Totales = {Persistance_Data.sharedInstance.intentosContador}";
    }

   
}
