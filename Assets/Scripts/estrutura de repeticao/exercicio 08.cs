using UnityEngine;

//Escreva um programa que inverte uma
//string usando um loop for.
public class exercicio08 : MonoBehaviour
{
    string nome = "laura";
    string inverter= "";
    void Start()
    {
        for (int i =nome.Length - 1; i >= 0;  i--)
        {
            
            inverter += nome[i];
        }
        print("A palavra " + nome + " invertido � : " + inverter);
    }

    void Update()
    {
        
    }
}
