using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.
//    Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.

public class PrecioProducto : MonoBehaviour
{
    // Start is called before the first frame update
    public int Precio;
    public int Precio2;
    public int Precio3;
    public int MontoDisponible;
    
    void Start()
    {
        int sum;
        int sobrante;
        sum = Precio + Precio2 + Precio3;
        if (sum > MontoDisponible)
        {
            sobrante = sum - MontoDisponible;
            Debug.Log("La suma de los tres productos es mayor al dinero disponible. Faltan "+sobrante+" pesos.");
            
            
        }
        else
        {
            sobrante = MontoDisponible - sum;
            Debug.Log("La suma de los tres productos es menor al dinero disponible. Sobran "+sobrante+ " pesos.");
            
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
