using Unity.VisualScripting;
using UnityEngine;

public class exercicio01 : MonoBehaviour
{
    [SerializeField] int vidaHeroi = 10;
    string resultado;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       resultado = vidaHeroi > 0 ? "personagem Vivo" : "Game Over";
        print(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
