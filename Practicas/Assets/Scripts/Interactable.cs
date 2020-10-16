using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isInsideZone;
    public KeyCode key= KeyCode.K;
    //Metodos abstractos
    public virtual void Interact(){}
    void Update() {
        if(isInsideZone && Input.GetKeyDown(key))
        {
            Interact();
        }    
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(!other.CompareTag("Player"))
        {
            return;
        }   
        else
        {
            isInsideZone = true;
        } 
    }

    private void OnTriggerExit(Collider other) {
        if(!other.CompareTag("Player"))
        {
            return;
        }  
        isInsideZone = false;
    }
}
