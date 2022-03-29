using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0 en una variable llamada num1 y muestre un mensaje por pantalla indicando//
//"el  número es par" o "el número es impar". Deberá utilizar el operador “módulo” es el caracter  %.//

public class ejercicio6 : MonoBehaviour
{
    public int num1;
    int resto;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 <= 0) return;
        
            resto = num1 % 2;

            if (resto == 0)
            {
                Debug.Log("El numero es par");
            }

            else
            {
                Debug.Log("el numero es impar");
            }
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
