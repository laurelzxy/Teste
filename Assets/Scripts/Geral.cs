using Unity.VisualScripting;
using UnityEngine;

public class Geral : MonoBehaviour
{
    //variaveis
    //[SerializeField] int vidaJogador = 10;

    //float velocidadeCArro = 125.5f;

    //double velocidade = 120.2;

    //string nomeJogador = "tadola";

    //char apelido = 't';

    //bool vivo = false


    //operadores relacionais
    //== (igual)
    //!=(diferente)
    //> (maior que)
    //< (menor que)
    //<= (menor igual)
    //>=(maior igual)

    //operadores logicos
    //&& 

    //If nao compara se e maior que algo

     //switch case comparacao de igualdade
    //estado 1 - vilao ataca
    //estado 2 - vilao defende
    //estado 3 - vilao toma dano 

    [SerializeField] int estadoVilao = 1;


    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        switch (estadoVilao)
        {
            case 1:
                print("vilao atacando");
                    break;
            case 2:
                print("vilao defende");
                break;
            case 3:
                print("vilao tomando um coro");
                    break;

            default:
                print("valor nao indentificado");
                break;

        }
        //Debug.Log("Hello Word!");
        //print(vidaVilao == vidaHeroi);false

        //Operador ternario 
        //codicao ? valor a ser atrinuido caso verdadeiro : caso falso 
        //resultado = vidaHeroi < vidaVilao ? "Vida Heroi Menor" : "Vida Heroi Maior");

        //estrutura condicional
        

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
