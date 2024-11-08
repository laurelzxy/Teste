using UnityEngine;

//Implemente um sistema de diálogos onde o jogador
//pode interagir com um NPC (personagem não jogável), e o NPC
//responde com diferentes frases dependendo do estado do jogo.
//Use switch case para definir as respostas baseadas no estado do
//jogador.
public class exercicio11 : MonoBehaviour
{
    [SerializeField] int interacao = 1;
    

    void Start()
    {
        switch (interacao)
        {
            case 1:
                print("DA para fazer com ternario?");
                    break;

            case 2:
                print("Sextou!!!");
                break;

            case 3:
                print("Cade o tadeu");
                    break;

            default:
                print("não tenho nada a dizer sobre isso");
                break;

        }

        
    }

    void Update()
    {
        
    }
}
