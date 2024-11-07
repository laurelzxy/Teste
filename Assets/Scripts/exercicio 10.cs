using UnityEngine;

//Crie um script onde o jogador pode coletar
//diferentes tipos de itens (como moedas, poções, ou power-ups)
//que têm efeitos diferentes dependendo do tipo coletado. Use um
//switch case para determinar o efeito de cada tipo de item.
public class exercicio10 : MonoBehaviour
{
    [SerializeField] int inventario= 1;
    void Start()
    {
        switch (inventario)
        {
            case 1:
                print("Moeda coletado \n voce ganhou 5 moedas!!");
                    break;
            case 2:
                print("poção de cura coletado \n voce recebeu 3 coracoes");
                    break;
            case 3:
                print("Power-up coletado \n velocidade aumentada");
                    break;
            default:
                Debug.Log("Item desconhecido");
                break;
        }

    }

    void Update()
    {
        
    }
}
