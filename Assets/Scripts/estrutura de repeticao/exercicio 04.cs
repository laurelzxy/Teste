using UnityEngine;

//Cada combo realizado aumenta em 10
//pontos. Exiba a pontua��o total ap�s 7 combos.
public class exercicio04 : MonoBehaviour
{
    [SerializeField] int pontuacao;
    void Start()
    {
        for (int i = 1; i <= 7; i++) 
        {
            pontuacao += 10;
            print("pontua��o: " + pontuacao);
        }
    }

    void Update()
    {
        
    }
}
