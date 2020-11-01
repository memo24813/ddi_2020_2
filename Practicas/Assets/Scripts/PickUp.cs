using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : Interactable
{
    
    private Inventory inventory;

    public Item item;
    private void Start() 
    {
        inventory = FindObjectOfType<Inventory>();
        if(inventory== null)
        {
            Debug.LogWarning("No se encontro el inventario.");
        }
        setKey(KeyCode.E);
    }
    public override void Interact()
    {
        Debug.Log("Agarrando Item");
        inventory.Add(item);
        Destroy(gameObject);
    }

}
