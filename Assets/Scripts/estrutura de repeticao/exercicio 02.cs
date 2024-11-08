using UnityEngine;

//Um personagem ataca cinco vezes, e o
//dano do ataque aumenta em 2 a cada vez. Exiba o dano a cada
//ataque.
public class exercicio02 : MonoBehaviour
{
    [SerializeField] int ataque = 1;
    [SerializeField] int dano = 1;
    void Start()
    {
        for (int ataque = 1; ataque <= 5; ataque++)
        {
            dano += 2;

            print(dano);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
