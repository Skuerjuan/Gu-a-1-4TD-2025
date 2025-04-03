using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AporteDeCapital : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    // Start is called before the first frame update
    void Start()
    {
        int total = num1 + num2 + num3;
        int[] lista = { num1, num2, num3 };
        for (int i = 0; i < 3; i++) {
            Debug.Log($"Persona{i + 1}: capital aportado: ${lista[i]}, Porcentaje del capital: %{((float) lista[i] / total) * 100}, Monto total aportado: ${total}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
