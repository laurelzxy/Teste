using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class desafio01 : MonoBehaviour
{
    //    Escreva um programa que conta o número de consoantes em uma string.
    //Faça um algoritmo que receba o dia, o mês e o ano em que uma pessoa nasceu, imprima na tela quantos anos, 
    // meses e dias essa pessoa já viveu.Leve em consideração o ano com 365 dias e o mês com 30 dias.

    [SerializeField] string nome = "";
    [SerializeField] int consoante;

    char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E','I', 'O', 'U' };
   void Start()
    {
        for (int i = nome.Length -1; i >= 0; i--)
        {
            char c = nome[i];
            vogais.Contains(c);
            if (!vogais.Contains(c))
            {
                consoante++;
            }
        }
            print(consoante);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
