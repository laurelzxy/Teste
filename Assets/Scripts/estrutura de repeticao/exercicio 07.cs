using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using UnityEngine;

public class exercicio07 : MonoBehaviour
{
    //Dada uma lista de números,encontre o maior valor.
    void Start()
    {
        List<int> nums = new List<int>();

        nums.Add(5);
        nums.Add(15);
        nums.Add(10);
        nums.Add(22);
        nums.Add(20);
        nums.Add(50);
        nums.Add(35);
        nums.Add(36);

        int n = nums.Max();

        print(n);
    }

    void Update()
    {
        
    }
}
