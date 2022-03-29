using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio4 : MonoBehaviour
{
    public int num1;
    public int num2;
    int suma;
    // Start is called before the first frame update
    void Start()
    {
        suma = num1 + num2;
        Debug.Log("La  suma entre " + num1 + " y " + num2 + " da como resultado " + suma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
