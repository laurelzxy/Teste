using UnityEngine;

//O jogador coleta 3 moedas a
//cada fase. Ap�s 10 fases, exiba o total de moedas coletadas.
public class exercicio03 : MonoBehaviour
{
    [SerializeField] int moeda;
    

    void Start()
    {
 // Valor inicial; Em quanto ele vai come�ar
 // Condi��o para continuar a repeti��o
 // Incrementa��o

        for ( int i =1; i <= 10; i++)
        {
            moeda += 3;
            print("fase "+ i + ", Moedas = " + moeda);
        }
    }

    void Update()
    {
        
    }
}
