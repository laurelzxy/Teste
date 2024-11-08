using UnityEngine;

//Para fazer um jogo de RPG, vamos precisar
//calcular probabilidades e simular a rolagem de dados. Crie um
//script em que o usuário defina o número de faces de um dado
//(int) e calcule a rolagem de um dado com esse número de faces.
//Use a função abaixo para o cálculo: Random.Range(valor_min,
//valor_max); (Coloque o código dentro da função-evento Start).
public class exercicio7 : MonoBehaviour
{
    [SerializeField] int numeroFaces;
    void Start()
    {
        //if(numeroFaces == 0)
        //{
        //    print("O numero de faces do dadi nao pode ser: " + numeroFaces);
        //}
        //else
        //{
        //    print(Random.Range(1, numeroFaces));
        //}
        print(numeroFaces == 0 ? ("o numero de faces do dado nao pode ser: " + numeroFaces) : (Random.Range(1, numeroFaces)));
    }

    void Update()
    {
        
    }
}
