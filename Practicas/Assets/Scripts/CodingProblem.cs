using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingProblem : MonoBehaviour
{
    int [] array = {8,1,2,2,3};
    void Start()
    {
        array = SmallerNumbers(array);  
        Debug.Log("Array Numbers  = " +string.Join("",new List<int>(array).ConvertAll(i => i.ToString()).ToArray()));
    }
    
    int [] SmallerNumbers(int [] nums)
    {
        int [] arrayaux = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            for(int j=0; j<nums.Length; j++)
            {
                if(nums[i]>nums[j])
                {
                    arrayaux[i]++;
                }
            }
        }
        return arrayaux;
    }
}
