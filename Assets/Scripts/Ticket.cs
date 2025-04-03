using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticket : MonoBehaviour
{
    public string fecha;
    public string nombreComprador;
    public string nombreProducto;
    public int cantidadProducto;
    public float precioProducto;
    // Start is called before the first frame update
    void Start()
    {
        if (fecha.Length != 8) Debug.Log("Fecha incorrecta ingresada.");
        else
        {
            Debug.Log("Fecha de compra: " + fecha);
            Debug.Log("Nombre del comprador: " + nombreComprador);
            Debug.Log("Producto solicitado: " + nombreProducto);
            Debug.Log("Cantidad solicitada: " + cantidadProducto);
            Debug.Log("Precio unitario: $" + precioProducto);
            Debug.Log("Total a pagar: $" + (precioProducto*cantidadProducto));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
