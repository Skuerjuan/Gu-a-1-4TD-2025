using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulacroT1 : MonoBehaviour
{
    public float montoInicial;
    public char moneda;
    float montoFinal;
    string monedaEntera;

    float montoMinimo = 1000;
    float cotizacion;

    float cotizacionDolar = 1073.63f;
    float cotizacionEuro = 1179.4f;
    float cotizacionReal = 183.75f;
    // Start is called before the first frame update
    void Start()
    {
        if (montoInicial < montoMinimo)
        {
            Debug.Log($"El monto mínimo es $1000.");
            return;
        }

        switch (moneda)
        {
            case 'D':
                cotizacion = cotizacionDolar;
                monedaEntera = "Dólar(es)";
                break;
            case 'R':
                cotizacion = cotizacionReal;
                monedaEntera = "Real(es)";
                break;
            case 'E':
                cotizacion = cotizacionEuro;
                monedaEntera = "Euro(s)";
                break;
            default:
                Debug.Log("Opción de moneda extranjera no válida.");
                return;
        }

        montoFinal = montoInicial / cotizacion;


        Debug.Log($"${montoInicial} pesos son iguales a {montoFinal} {monedaEntera}.");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
