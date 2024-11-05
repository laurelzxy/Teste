using UnityEngine;

//Implemente um sistema de diálogos onde o jogador
//pode interagir com um NPC (personagem não jogável), e o NPC
//responde com diferentes frases dependendo do estado do jogo.
//Use switch case para definir as respostas baseadas no estado do
//jogador.
public class exercicio11 : MonoBehaviour
{
    [SerializeField] int interacao = 1;
    [SerializeField] int NPC = 1;

    void Start()
    {
        switch (interacao)
        {
            case 1:
                print("Oie migo");
                break;
            case 2:
                print("Bom dia!!");
                break;
            case 3:
                print("Boa noite!!");
                    break;
        }

        switch( NPC)
        {
            case 1:
                print("ola tudo bem?");
                    break;
            case 2:
                print("como vai?");
                    break;
            case 3:
                print("ate amanha!!");
                break;

        }
    }

    void Update()
    {
        
    }
}
