using UnityEngine;

//Crie um script que lê o placar de uma partida entre
//time A e time B. Depois, escreva no console qual dos três
//resultados possíveis aconteceu: vitória do time A, vitória do time B
//ou empate. Se o empate teve mais de 3 pontos para cada lado,
//escreva que foi “um empate emocionante”.
public class exercicio9 : MonoBehaviour
{
    [SerializeField] int resultadoMax= 5;
    [SerializeField] int resultadoMin= 0;
    [SerializeField] int resultadoA ;
    [SerializeField] int resultadoB ;
    void Start()
    {
        resultadoA = Random.Range(resultadoMax, resultadoMin);
        resultadoB = Random.Range(resultadoMax, resultadoMin);
        print("Time A: " + resultadoA + "\n Time B: " + resultadoB);

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
