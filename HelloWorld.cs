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
        string twoo = "";
        string three = "";
        string four = "";
        string five = "";


        numara = " numara; ";
        while (i <= two)
        {
            numara =  numara + i + " ";
            i++;
        }
        print(numara);

        twoo = "2 ye bolunenler; "; 
        for (i = one; i <= two; i++)
        {
            if (i % 2 == 0)
            {
                twoo = twoo + i + " ";
            }
        }
        print(twoo);

        three = "3 e bolunenler; ";
        for (i = one; i <= two; i++)
        {
            if (i % 3 == 0)
            {
                three = three + i + " ";
            }
        }
        print(three);

        four = "4 e bolunenler; ";
        for (i = one; i <= two; i++)
        {
            if (i % 4 == 0)
            {
                four = four + i + " ";
            }
        }
        print(four);

        five = "5 e bolunenler; ";
        for (i = one; i <= two; i++)
        {
            if (i % 5 == 0)
            {
                five = five + i + " ";
            }
        }
        print(five);
      

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
