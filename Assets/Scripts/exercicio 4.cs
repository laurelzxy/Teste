using UnityEngine;

//Um jogador possui itens limitados
//no invent�rio. Verifique se o jogador possui uma "Po��o de Vida".
//Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
//indispon�vel".
public class exercicio4 : MonoBehaviour
{
    [SerializeField] bool pocaoVida;
    void Start()
    {
        print(pocaoVida == true ? "Usando pocao de vida" : "Pocao indisponivel");
    }

    void Update()
    {
        
    }
}
