using Unity.VisualScripting;
using UnityEngine;

public class LacoRepeticao : MonoBehaviour
{
    //For -> E utilizado quando se sabe a quantidade de repeticao

    //While ou DoWhile -> [e ultilizado quando nao se asabe a quantidade de repeticao

    //ForEach -> usado em listas ou arrays para executar uma operacao para

    //array -> e uma lista

    int y = 0; 
    int x = 0; 


   

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


        //while 
        while (x <= 10)
        {
            print(x);
            x++;
        }

        //do while 
        do
        {
            print(y);
            y--;
        }
        while (y >= 0);

        int[] num = { 10, 20, 30, 40, 50, 60, 70, 80 };
        print(num[3]);

        num[0] += 0;

        print(num[0]);

        string[] nomes; 
        
        nomes = new string[5];
        nomes[0] = "tadola";

        print(nomes[1]);
    }

    void Update()
    {
        
    }
}
