using UnityEngine;

//Escreva um programa que inverte uma
//string usando um loop for.
public class exercicio08 : MonoBehaviour
{
    string nome = "laura";
    string inverter;
    void Start()
    {
        for (int i =nome.Length - 1; i >= 0;  i--)
        {
            char world = nome[i];
            string letra = world.ToString();
            inverter += letra;
        }
        print("A palavra " + nome + " invertido é : " + inverter);
    }

    void Update()
    {
        
    }
}
