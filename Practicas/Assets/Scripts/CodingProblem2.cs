using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodingProblem2 : MonoBehaviour
{
    // Start is called before the first frame update

    string [] Students;
    void Start()
    {
        Students= new string[]{"Areli","Dalet","Daniel","Eduardo","Enola","Gilberto",
        "Guillermo","Humberto","Jaime","Jessica","Joaquin","Leonardo","Luis","Omar",
        "Pablo","Paul","Ricardo","Sergio","Victor"};

        if(NameSearch(Students,"Enola",Students.Length))
        {
            Debug.Log("Se encontro el nombre");
        }
        else
        {
            Debug.Log("No se encontro el nombre");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool NameSearch(string [] s, string x, int n)
    {
        int l = 0;
        int r = n - 1;
        while(l<=r)
        {
            int m = l + (r - 1)/2;

            if(string.Compare(x.ToUpper(),s[m].ToUpper())==0)
                return true;
                
                if(string.Compare(x.ToUpper(),s[m].ToUpper())>0)
                    l = m+1;
                else
                    r = m -1;
        }

        return false;
    }
}
