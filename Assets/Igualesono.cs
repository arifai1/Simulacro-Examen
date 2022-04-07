using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Igualesono : MonoBehaviour
{
    // Start is called before the first frame update
    public int num1;
    public int num2;
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Los numeros son iguales");
        }
        else
        {
            Debug.Log("No son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
