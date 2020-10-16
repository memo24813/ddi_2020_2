using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingProblem3 : MonoBehaviour
{
    // Start is called before the first frame update
    int [] array;
    int [] result;
    void Start()
    {
        array = new int[]{2,4,5,2,9,4,3};
        result = SumaDos(array,6);
        Debug.Log("Las posiciones fueron: ["+result[0]);
        Debug.Log("Las posiciones fueron:  = " +string.Join("",new List<int>(result).ConvertAll(i => i.ToString()).ToArray()));
        
    }

    public int[] SumaDos(int [] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; i++)
            {
                if(nums[i]+nums[j]==target)
                    return new int[]{i,j};
            }
        }

        return new int []{-1};
    }
}
