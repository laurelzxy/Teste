using UnityEngine;

//Crie uma contagem
//regressiva de 5 a 1 e exiba "Início da partida!" ao final.
public class exercicio1 : MonoBehaviour
{
    [SerializeField] int num = 0;
    void Start()
    {
        for (int num = 5; num >= 1; num--) 
        {
            print(num);
        }

        print("Inicio da partida!");
        
 
    }

    void Update()
    {
        
    }
}
