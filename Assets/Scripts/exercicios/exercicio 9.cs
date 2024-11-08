using UnityEngine;

//Crie um script que lê o placar de uma partida entre
//time A e time B. Depois, escreva no console qual dos três
//resultados possíveis aconteceu: vitória do time A, vitória do time B
//ou empate. Se o empate teve mais de 3 pontos para cada lado,
//escreva que foi “um empate emocionante”.
public class exercicio9 : MonoBehaviour
{
    
    [SerializeField] int resultadoA ;
    [SerializeField] int resultadoB ;
    void Start()
    {
        resultadoA = Random.Range(1, 5);
        resultadoB = Random.Range(1, 5);

        if (resultadoA == resultadoB && resultadoA >= 3 && resultadoB >=3 )
        {
            print("Um empate emocionante");
        }
        else if ( resultadoA > resultadoB)
        {
            print("Vitoria do time A");
        }
        else if( resultadoA < resultadoB)
        {
            print("Vitoria do time B ");
        }
        else if ( resultadoA == resultadoB )
        {
            print("empate");
        }
    }

    void Update()
    {
        
    }
}
