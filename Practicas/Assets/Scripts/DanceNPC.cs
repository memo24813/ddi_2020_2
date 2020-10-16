using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceNPC : Interactable
{
    // Start is called before the first frame update
    private Animator anim;
    private void Awake() {
        key = KeyCode.G;
        anim = GetComponent<Animator>();
    }

    public override void Interact()
    {
        base.Interact();
        anim.SetBool("DanceNPC",true);

    }
}
