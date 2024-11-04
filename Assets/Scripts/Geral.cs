using UnityEngine;

public class Geral : MonoBehaviour
{
    //variaveis
    //[SerializeField] int vidaJogador = 10;

    //float velocidadeCArro = 125.5f;

    //double velocidade = 120.2;

    //string nomeJogador = "tadola";

    //char apelido = 't';

    //bool vivo = false;


    //operadores relacionais
    //== (igual)
    //!=(diferente)
    //> (maior que)
    //< (menor que)
    //<= (menor igual)
    //>=(maior igual)



    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int vidaVilao = 300;
    string resultado;


    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("Hello Word!");
        //print(vidaVilao == vidaHeroi);false

        //Operador ternario 
        //codicao ? valor a ser atrinuido caso verdadeiro : caso falso 
        //resultado = vidaHeroi < vidaVilao ? "Vida Heroi Menor" : "Vida Heroi Maior");

        //estrutura condicional
        if (vidaHeroi < vidaVilao)
        {
            //print("Vida Heroi Menor");
            //print("Vida Heroi Menor");

            resultado = "Vida Heroi Menor";
            print(resultado);
        }
        else if (vidaHeroi == vidaVilao)
        {
            resultado = "Vida Heroi igual a vida Vilao";
            print(resultado);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
