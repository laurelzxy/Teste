using NUnit.Framework;
using System;
using UnityEngine;

//    Para cada número entre 0 e 10000, escreva apenas
//“fizz” no console quando for divisível por 3, “buzz” quando for
//divisível por 5 e “fizz buzz” quando for divisível pelos dois.Se o
//número não for divisível por nenhum deles, escreva-o no console.
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
