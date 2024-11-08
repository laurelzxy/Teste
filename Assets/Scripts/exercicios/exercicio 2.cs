using Unity.VisualScripting;
using UnityEngine;

public class exercicio2 : MonoBehaviour
{
    [SerializeField] bool powerUp; 
    //! inverte o valor
    void Start()
    {
        //if (powerUp == true)
        //{
        //    print("power-up Coletado");
        //}
        //else
        //{
        //    print("nenhum power-up encontrado");
        //}

        //Condicao ? caso vdd: caso falso 
        print (powerUp == true ? "power-up Coletado" : "nenhum power-up encontrado");
    }

    void Update()
    {
        
    }
}
