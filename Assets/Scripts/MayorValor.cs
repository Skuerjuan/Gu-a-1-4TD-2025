using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayorValor : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 > num2 && num1 > num3) Debug.Log($"num1 ({num1}) es el más grande.");
        else if (num2 > num3) Debug.Log($"num2 ({num2}) es el más grande.");
        else if (num3 > num2) Debug.Log($"num3 ({num3}) es el más grande.");
        else Debug.Log("Los números son iguales.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
