using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NPCMessage : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TextMeshProUGUI messageNPC,optionNPC;
    public string messagenpc,optionnpc;
    public GameObject Panel;
    void Start()
    {
        hidePanel();
        messageNPC.text=messagenpc;
        optionNPC.text = optionnpc;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other) {
        
        if(!other.CompareTag("Player"))
        {
            return;
        }
        else
        {
            showPanel();
        }
    }
    private void OnTriggerExit(Collider other) {
        
        if(!other.CompareTag("Player"))
        {
            return;
        }
        else
        {
            hidePanel();
        }
    }

    public void hidePanel()
    {
        Panel.SetActive(false);
    }
    public void showPanel()
    {
        messageNPC.text=messagenpc;
        optionNPC.text = optionnpc;
        Panel.SetActive(true);
    }
}
