using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dados : MonoBehaviour
{
    public int dado1;
    public int dado2;
    public int dado3;
    int contadorDeSeis;
    // Start is called before the first frame update
    void Start()
    {
        contadorDeSeis = 0;
        if (dado1 == 6) contadorDeSeis++;
        if (dado2 == 6) contadorDeSeis++;
        if (dado3 == 6) contadorDeSeis++;
        switch (contadorDeSeis) {
            case 0:
                Debug.Log("Insuficiente");
                break;
            case 1:
                Debug.Log("Regular");
                break;
            case 2:
                Debug.Log("Muy bien");
                break;
            case 3:
                Debug.Log("Excelente");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
