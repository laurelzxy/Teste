using UnityEngine;

//Após completar uma missão, o jogador
//recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
//exiba "Missão bem-sucedida"; caso contrário, "Missão
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
