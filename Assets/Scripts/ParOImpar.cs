using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParOImpar : MonoBehaviour
{
    public uint num1;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 < 1) Debug.Log("El número debe ser mayor a 0.");
        else {
            bool esPar = (num1 % 2 == 0);
            if (esPar) Debug.Log("El número es par");
            else Debug.Log("El número es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
