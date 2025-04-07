using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulacroT3 : MonoBehaviour
{
    public string codigoAnimal;
    public int diasEstadia;


    int comidaDiaria;
    int comidaConsumida;
    float precioTotal;

    float precioAlimento = 80;
    int comidaDiariaG = 300;
    int comidaDiariaPP = 400;
    int comidaDiariaPG = 700;
    int diasMinimos = 3;

    // Start is called before the first frame update
    void Start()
    {
        if (diasEstadia < diasMinimos)
        {
            Debug.Log($"La cantidad mínima de días para una estadía es {diasMinimos}.");
            return;
        }

        switch (codigoAnimal)
        {
            case "G":
                comidaDiaria = comidaDiariaG;
                break;

            case "PP":
                comidaDiaria = comidaDiariaPP;
                break;

            case "PG":
                comidaDiaria = comidaDiariaPG;
                break;

            default:
                Debug.Log("Debe ingresar un código de animal válido.");
                return;
        }

        comidaConsumida = comidaDiaria * diasEstadia;
        precioTotal = (precioAlimento / 100) * comidaConsumida;

        Debug.Log($"Para ese período es necesitan {comidaConsumida} gramos de alimento.");
        Debug.Log($"El precio total de la comida será de ${precioTotal}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
