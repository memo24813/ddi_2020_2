using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InventoryUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pnlInventoryUI;
    public GameObject pnlControl;
    private Inventory inventory;
    void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        if(inventory==null)
            return;
        pnlInventoryUI.SetActive(false);

        inventory.onChange +=UpdateUI;
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.I))
        // {
        //     pnlInventoryUI.SetActive(!pnlInventoryUI.activeSelf);
        //     UpdateUI();
        // }
    }


    void UpdateUI()
    {
        Slot[] slots = GetComponentsInChildren<Slot>();

        for(int i=0; i<slots.Length; i++)
        {   
            if(i<inventory.items.Count)
                slots[i].SetItem(inventory.items[i]);
            else 
                slots[i].Clear();
        } 
    }

    public void ShowInventory()
    {
        pnlInventoryUI.SetActive(!pnlInventoryUI.activeSelf);
        UpdateUI();
    }

    public void ControlsHide()
    {
        pnlControl.SetActive(!pnlControl.activeSelf);
    }
}
