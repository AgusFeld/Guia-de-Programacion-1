using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio7 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    // Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y
    // num3, muestre el valor del mayor de todos.
    // En caso de igualdad entre los tres imprimir &quot;Los números son iguales&quot;. Test1: num1 =
    // 12, num2 = 4, num3= 7. Resultado esperado: El mayor número es num1 Test2: num1
    // = 2, num2 = 65, num3= 8. Resultado esperado: El mayor número es num2
    void Start()
    {
        if (num1 == num2 && num2 == num3)
        {
            Debug.Log("Los tres numeros son iguales: " + num1);
            return;
        }

        int[] numeros = new int[3];
        int mayornum = 0;
        int buscador = 0;
        int encontrador = 0;


        numeros[0] = num1;
        numeros[1] = num2;
        numeros[2] = num3;

        foreach(int i in numeros)
        {
            if (i > mayornum)
            {
                mayornum = i;
                encontrador = buscador;
            }
            buscador++;
        }


        Debug.Log("El numero mas grande es: " + numeros[encontrador]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//El foreach evalua todos los indices de un array, empezando desde 0. El valor que contiene el indice evaluado,
//Mientras no sea nulo, va a ser asignado a la variable incializada en el foreach (en este caso la variable i)
//Este algoritmo en particular tiene 2 partes principales: Buscar el valor maximo en el array, y guardar su indice.
//mayornum es la variable que almacena el valor si es encontrado. 
// Al hacer if(i > mayornum), si encuentra un valor mayor al numero mayor previamente encontrado, actualiza mayornum.
// encontrador y buscador cumplen la segunda parte del algoritmo, que es almacenar el indice del valor maximo. 
// Como el foreach pasa por todos los valores del array, si ponemos una variable que incrementa por 1 cada vez que 
// Se completa el array, podemos saber cual es el indice siendo evaluado.
// Enonces, cuando se encuentra un nuevo valor maximo, encontrador se actualiza al valor del indice del numero mas grande
// Encontrado
