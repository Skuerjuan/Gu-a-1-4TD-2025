using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saludo : MonoBehaviour
{
    public string nombre;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Hola {nombre}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
