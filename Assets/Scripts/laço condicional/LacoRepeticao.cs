using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LacoRepeticao : MonoBehaviour
{
    //For -> E utilizado quando se sabe a quantidade de repeticao

    //While ou DoWhile -> [e ultilizado quando nao se asabe a quantidade de repeticao

    //ForEach -> usado em listas ou arrays para executar uma operacao para

    //array -> e uma lista

    //int y = 0; 
    //int x = 0; 


   

    void Start()
    {
        //for (inicializador; condicao; incremento/ decremento
        //for (int variavel = 0; variavel < 10; variavel ++)
        //{
        //    if (variavel == 5)
        //    {
        //        break;
        //    }

        //    if ( variavel == 6 )
        //    {
        //        continue;
        //    }
        //    print(variavel);
        //}


        ////while 
        //while (x <= 10)
        //{
        //    print(x);
        //    x++;
        //}

        ////do while 
        //do
        //{
        //    print(y);
        //    y--;
        //}
        //while (y >= 0);

        //Assey
        //int[] num = { 10, 20, 30, 40, 50, 60, 70, 80 };
        //print(num[3]);

        //num[0] += 0;

        //print(num[0]);

        //string[] nomes; 

        //nomes = new string[5];
        //nomes[0] = "tadola";

        //print(nomes[1]);

        //for (int i = 0; i < 8; i++)
        //{
        //    print(num[i]);
        //} 

        //foreach (var item in num)
        //{
        //    print(item);
        //}

        //-----------------------------------------------------------

        // Criando uma lista de inteiros chamdos nums
        List <int> nums = new List <int>();

        //Adiciona elementos a lista de nums

        nums.Add (1);  
        nums.Add (2);
        nums.Add (3);
        nums.Add (4);
        nums.Add (5);
        nums.Add (6);
        nums.Add (7);
        nums.Add (8);

        //remove o primeiro vslor "4" encontrado na lista (indice 3)
        nums. Remove (4);

        //ordena os elementos da lista em ordem crescente
        nums.Sort ();

        nums.Reverse ();

        nums.IndexOf (1);

    }

    void Update()
    {
        
    }
}
