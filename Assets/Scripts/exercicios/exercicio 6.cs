using UnityEngine;

//O jogador pode escolher entre o
//personagem Guerreiro ou Mago. Exiba "Guerreiro escolhido" se o
//jogador selecionar Guerreiro e "Mago escolhido" se selecionar
//Mago.
public class exercicio6 : MonoBehaviour
{
    [SerializeField] bool guerreiro;
    [SerializeField] bool mago;

    void Start()
    {
        print(guerreiro == true ? "Guerreiro escolhido" : "Mago escolhido");
        
    }

    void Update()
    {
        
    }
}
