using Unity.VisualScripting;
using UnityEngine;

public class exercicio01 : MonoBehaviour
{
    [SerializeField] int vidaHeroi = 10;
    string resultado;


    void Start()
    {
       resultado = vidaHeroi > 0 ? "personagem Vivo" : "Game Over";
        print(resultado);
    }

    void Update()
    {
        
    }
}
