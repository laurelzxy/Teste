using UnityEngine;

//A cada fase completada, a
//dificuldade aumenta em 5 pontos. Exiba a dificuldade após cada
//fase, em um total de 6 fases.
public class exercicio05 : MonoBehaviour
{
    //6 fases 
    //5 pontos
    [SerializeField] int fases;
    void Start()
    {
        for (int i = 1; i <= 6; i++)
        {
            fases += 5;
            print("Fase: " + i + "Dificuldade: " + fases);
        }
    }

    void Update()
    {
        
    }
}
