using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using UnityEngine;

public class exercicio07 : MonoBehaviour
{
    //Dada uma lista de números,encontre o maior valor.

    int[] numeros = { 12, 20, 40, 33, 22, 10 };
    int maior = 0;
    void Start()
    {
        maior = numeros[0];

        foreach (var item in numeros)
        {
            if (item > maior)
            {
                maior = item;
            }
        }

        print(" O maior numero é: " + maior);
    }

    void Update()
    {
        
    }
}
