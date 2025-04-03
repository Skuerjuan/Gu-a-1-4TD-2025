using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaDeLaSemana : MonoBehaviour
{
    public int dia;
    // Start is called before the first frame update
    void Start()
    {
        string[] dias = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };
        if (dia < 0 || dia > 6) Debug.Log("El día ingresado no es válido.");
        else Debug.Log(dias[dia]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
