using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class desafio01 : MonoBehaviour
{
    //    Escreva um programa que conta o n�mero de consoantes em uma string.
    //Fa�a um algoritmo que receba o dia, o m�s e o ano em que uma pessoa nasceu, imprima na tela quantos anos, 
    // meses e dias essa pessoa j� viveu.Leve em considera��o o ano com 365 dias e o m�s com 30 dias.

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
