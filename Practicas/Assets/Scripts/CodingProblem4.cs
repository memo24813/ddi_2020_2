using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingProblem4 : MonoBehaviour
{

    int [] numbers = {12,345,2,6,7896};
    void Start()
    {
        Debug.Log(getCountDigitEven(numbers));
    }

    int getCountDigitEven(int [] numbers)
    {
        int count=0;

        foreach (int num in numbers)
            if(NumLenght(num)%2==0)
                count++;
        
        return count;
    }
    int NumLenght(int number)
    {
        int count=0;
        while(number!=0)
        {
            number/=10;
            count++;
        }

        return count;
    }
}
