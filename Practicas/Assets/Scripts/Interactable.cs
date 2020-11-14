using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Interactable : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isInsideZone;
    public static bool interactuar;
    public KeyCode key= KeyCode.K;
    //Metodos abstractos
    public virtual void Interact(){}
    void Update() {
        // if(isInsideZone && Input.GetKeyDown(key))
        if(isInsideZone && interactuar)
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
        interactuar = false;
    }

    protected void setKey(KeyCode key)
    {
        this.key = key;
    }


    public void setInteract()
    {
        interactuar = true;
    }

    public void clrInteract()
    {
        interactuar = false;
    }
}
