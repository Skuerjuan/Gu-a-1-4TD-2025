using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    //declarando variables
    int edadUsuario;
    float sueldoUsuario;
    string domicilio;
    bool estaAprobado;

    // Start is called before the first frame update
    void Start()
    {
        //inicializando variables
        edadUsuario = 45;
        sueldoUsuario = 1000.00f;
        domicilio = "Libertador";
        estaAprobado = true;

        //loggeando valores
        UnityEngine.Debug.Log(edadUsuario);
        UnityEngine.Debug.Log(sueldoUsuario);
        UnityEngine.Debug.Log(domicilio);
        UnityEngine.Debug.Log(estaAprobado);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
