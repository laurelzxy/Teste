using UnityEngine;

//Ap�s completar uma miss�o, o jogador
//recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
//exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
//incompleta".
public class exercicio5 : MonoBehaviour
{
    [SerializeField] int pontos;


    void Start()
    {
        if (pontos >= 50)
        {
            print("missao bem-sucedida");
        }
        else
        {
            print("missao incompleta");
        }


     }

    void Update()
    {
        
    }
}
