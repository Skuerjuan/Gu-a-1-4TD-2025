using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estacionamiento : MonoBehaviour
{
    public int hora;
    bool estaAbierto;
    // Start is called before the first frame update
    void Start()
    {
        if (hora < 0 || hora > 24) Debug.Log("Ha ingresado una hora incorrecta.");
        else {
            estaAbierto = (hora > 10 && hora < 18);
            if (estaAbierto) Debug.Log("El estacionamiento está abierto.");
            else Debug.Log("El estacionamiento no está abierto.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
