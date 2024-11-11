using UnityEngine;

//Cada combo realizado aumenta em 10
//pontos. Exiba a pontuação total após 7 combos.
public class exercicio04 : MonoBehaviour
{
    [SerializeField] int pontuacao;
    void Start()
    {
        for (int i = 1; i <= 7; i++) 
        {
            pontuacao += 10;
            print("pontuação: " + pontuacao);
        }
    }

    void Update()
    {
        
    }
}
