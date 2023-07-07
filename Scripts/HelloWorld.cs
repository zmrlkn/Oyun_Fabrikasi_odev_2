using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    void numbers(int one, int two)
    {
        int i;
        i = one;

        string numara = "";


        numara = " numara; ";
        while (i <= two)
        {
            numara =  numara + i + " ";
            i++;
        }
        print(numara);

        numara = "2 ye bolunenler; "; 
        for (i = one; i <= two; i++)
        {
            if (i % 2 == 0)
            {
                numara = numara + i + " ";
            }
        }
        print(numara);

        numara = "3 e bolunenler; ";
        for (i = one; i <= two; i++)
        {
            if (i % 3 == 0)
            {
                numara = numara + i + " ";
            }
        }
        print(numara);

        numara = "4 e bolunenler; ";
        for (i = one; i <= two; i++)
        {
            if (i % 4 == 0)
            {
                numara = numara + i + " ";
            }
        }
        print(numara);

        numara = "5 e bolunenler; ";
        for (i = one; i <= two; i++)
        {
            if (i % 5 == 0)
            {
                numara = numara + i + " ";
            }
        }
        print(numara);
      

    }

    void Start()
    {
        numbers(1, 10);

        // Update is called once per frame
    void Update()
    {

    }
    }
}
