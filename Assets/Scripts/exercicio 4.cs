using UnityEngine;

//Um jogador possui itens limitados
//no inventário. Verifique se o jogador possui uma "Poção de Vida".
//Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
//indisponível".
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
