using UnityEngine;
using UnityEngine.Rendering;

public class exercicio3 : MonoBehaviour
{
    [SerializeField] bool playerVivo; //true
    [SerializeField] bool powerUp; //true
    double vidaPlayer = 100;

    void Start()
    {
        if (playerVivo == false && powerUp == true)
        {
            vidaPlayer = vidaPlayer * 0.5;
            print("Ainda não, vida atual" + vidaPlayer);
        }
        else
        {
            print("Game Over");
        }
    }

    void Update()
    {
        
    }
}
