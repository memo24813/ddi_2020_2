using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCGenerateMision : Interactable
{
    
    NPCMessage NPCM;
    public string messageMision;
    public string messageInteract;
    private void Awake() {
        key = KeyCode.E;
        NPCM = GetComponent<NPCMessage>();
    }


    public override void Interact()
    {
        base.Interact();
        NPCM.messagenpc= messageMision;
        NPCM.optionnpc=messageInteract;
        NPCM.messageNPC.text=messageMision;
        NPCM.optionNPC.text=messageInteract;
        Destroy(this);
    }
}
