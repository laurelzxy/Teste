using NUnit.Framework;
using System;
using UnityEngine;

//    Para cada n�mero entre 0 e 10000, escreva apenas
//�fizz� no console quando for divis�vel por 3, �buzz� quando for
//divis�vel por 5 e �fizz buzz� quando for divis�vel pelos dois.Se o
//n�mero n�o for divis�vel por nenhum deles, escreva-o no console.
public class exercicio06 : MonoBehaviour
{
    void Start()
    {
        for (int nums = 0; nums <= 10000; nums++)
        {
            if (nums % 3 == 0 && nums % 5== 0)
            {
                print("Fiz buzzzzz");
            }
            else if (nums % 5 == 0)
            {
                print("Buzzzzz");

            } else if (nums % 3 == 0)
            {
                print("Fizzz");
            }else
            {
                print(nums);
            }


        }



    }

    void Update()
    {
        
    }
}
