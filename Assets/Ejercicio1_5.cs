using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_5 : MonoBehaviour
{
    public int num1, num2, num3;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            EscribirCadena(RetornaNumeroMayor(num1, num2, num3).ToString());
        }
    }

    int RetornaNumeroMayor(int num1, int num2, int num3)
    {
        if (num1 == num2 && num2 == num3)
        {
            return (-1);
        }

        else if (num1 > num2)
        {
            if (num1 > num3)
            {
                return (num1);
            }

            else
            {
                return (num3);
            }
        }

        else if (num2 > num3)
        {
            return (num2);
        }

        else
        {
            return (num3);
        }

    }

    void EscribirCadena(string cadena)
    {
        Debug.Log(cadena);
    }
}


