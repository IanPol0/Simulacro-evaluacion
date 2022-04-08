//Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y 
//un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto 
//de dinero disponible.Luego indicar cuánto dinero sobra o falta.



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{
    public float Precio1;
    public float Precio2;
    public float Precio3;
    public float DineroDisponible;
    float MontoTotal;
    float DineroExtra;
    // Start is called before the first frame update
    void Start()
    {
        MontoTotal = Precio1 + Precio2 + Precio3;

        if (MontoTotal > DineroDisponible)
        {
            Debug.Log("El monto total supera el monto disponible");
            DineroExtra = MontoTotal - DineroDisponible;
            Debug.Log("Faltan $" + DineroExtra);
        }
        
        else if (DineroDisponible > MontoTotal)
        {
            Debug.Log("El monto disponible es suficiente para pagar el monto total");
            DineroExtra = DineroDisponible - MontoTotal;
            Debug.Log("Sobra $" + DineroExtra);
        }

        else if (DineroDisponible == MontoTotal)
        {
            Debug.Log("Te alcanzo justito");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
