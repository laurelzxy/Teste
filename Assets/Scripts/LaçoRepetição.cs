using Unity.VisualScripting;
using UnityEngine;

public class LacoRepeticao : MonoBehaviour
{
    //For -> é ultilizado quando se sabe a quantidade de repetoções exatas

    //While ou DoWhile -> é utilizado quando não se sabe a quantidade de repetições

    //Foreach -> Usado em uma lista ou arrays para executar uma operação para cada item de lista

    //Array -> é uma lista

    void Start()
    {
        //for - inicializador ; codicao; incremento/decremento
        for (int i = 0; i <= 10; i++)
        {
            if (i == 5)
            {
                break;


            }

            print();

        }

    }
    void Update()
    {

    }
}